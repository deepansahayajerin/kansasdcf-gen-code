using System;
using System.Collections.Generic;
using MDSY.Framework.Core;
using MDSY.Framework.Buffer.Interfaces;
using MDSY.Framework.Buffer.Common;
using MDSY.Framework.Configuration.Common;
using MDSY.Framework.Data.SQL;

namespace GOV.KS.DCF.CSS.Common.BL
{
    /// <summary>
    /// Batch Control Services 
    /// </summary>
    [Serializable]
    public class EABBatchControl
    {

        #region Public Properties
        public IField Return_Code { get { return _bcRecord.GetFieldByName("_return_code"); } }

        public DBConversation DbConv { get; }

        public bool ExitProgram { get; set; }

        public bool CancelProgram { get; set; }

        public string ReturnTransID { get; set; }

        public string TransferProgram { get; set; }

        public static string CurrentSchema
        {
            get { return currentSchema; }
            set { currentSchema = value; }
        }

        public static string StoredProcSchema
        {
            get { return storedProcSchema; }
            set { storedProcSchema = value; }
        }

        public string ServerID
        {
            get
            {
                return Environment.GetEnvironmentVariable("COMPUTERNAME");
            }
        }

        #endregion

        #region private variables

        private IRecord _bcRecord;
        [ThreadStatic]
        private static IDictionary<string, EABBase> programInstanceCache;
        [ThreadStatic]
        private static string currentSchema;
        [ThreadStatic]
        private static string storedProcSchema;

        #endregion

        #region Constructors
        public EABBatchControl()
            : base()
        {
            if(programInstanceCache == null)
            programInstanceCache = new Dictionary<string, EABBase>();
            DbConv = new DBConversation();
            SetUpProgramVariables();
        }
        #endregion

        private void SetUpProgramVariables()
        {
            _bcRecord = MDSY.Framework.Buffer.Services.BufferServices.Factory.NewRecord("bcRecord", rec =>
            {
                rec.CreateNewField("_return_code", FieldType.CompShort, 4, +1111);
            });

            Return_Code.Assign(0);
        }
        public void Abort()
        {
            DbConv.Rollback();
        }

        #region Public Methods

        #region Link
        /// <summary>
        /// Link to new program down one level; Expect return back to same place in currecnt program.
        /// </summary>
        /// <param name="programName"></param>
        /// <param name="saveArea"></param>
        /// <param name="saveAreaLength"></param>
        /// <param name="respCode"></param>
        public void Link(string programName, IBufferValue saveArea, int saveAreaLength, IField respCode = null)
        {

            EABBase programInstance;

            if (!programInstanceCache.ContainsKey(programName.Trim()))
            {
                Type programType = ProgramUtilities.GetBLType(programName);
                if (programType == null) throw new Exception(string.Format("Link Program not found: {0}", programName));
                programInstanceCache.Add(programName.Trim(), (EABBase)Activator.CreateInstance(programType, this));
            }

            programInstance = programInstanceCache[programName.Trim()];
            programInstance.ExecuteMain();

            ExitProgram = false;
        }
        /// <summary>
        /// Link to new program down one level; Expect return back to same place in currecnt program.
        /// </summary>
        /// <param name="programName"></param>
        /// <param name="saveArea"></param>
        /// <param name="saveAreaLength"></param>
        /// <param name="respCode"></param>
        public void Link(IBufferValue programName, IBufferValue saveArea, int saveAreaLength, IField respCode = null)
        {
            Link(programName.DisplayValue, saveArea, saveAreaLength, respCode);
        }

        /// <summary>
        /// Link to new program down one level; Expect return back to same place in currecnt program.
        /// </summary>
        /// <param name="programName"></param>
        public void Link(IBufferValue programName)
        {
            Link(programName.DisplayValue);
        }

        /// <summary>
        /// Link to new program down one level; Expect return back to same place in currecnt program.
        /// </summary>
        /// <param name="programName"></param>
        public void Link(string programName)
        {
            EABBase programInstance;
            if (!programInstanceCache.ContainsKey(programName))
            {
                Type programType = ProgramUtilities.GetBLType(programName);
                if (programType == null) throw new Exception(string.Format("Link Program not found: {0}", programName));
                programInstanceCache.Add(programName.Trim(), (EABBase)Activator.CreateInstance(programType, this));
            }
            programInstance = programInstanceCache[programName.Trim()];
            programInstance.ExecuteMain();
            ExitProgram = false;
        }
        #endregion

        #region Call
        /// <summary>
        /// Call another new program
        /// </summary>
        public void Call(string programName, params object[] parms)
        {
            EABBase programInstance;

            if (!programInstanceCache.ContainsKey(programName.Trim()))
            {
                Type programType = ProgramUtilities.GetBLType(programName);
                if (programType == null) throw new Exception(string.Format("Called SubProgram not found: {0}", programName));
                programInstanceCache.Add(programName.Trim(), (EABBase)Activator.CreateInstance(programType)); //(programType, this));
            }

            programInstance = programInstanceCache[programName.Trim()];
            if (DbConv != null && programInstance.DbConv != null)
            {
                if (DbConv.Connection != null)
                {
                    programInstance.DbConv.SetNewConnection(DbConv.Connection);
                    if (DbConv.Transaction != null)
                    {
                        //The program that is doing the call already has a transaction, lets use it.
                        programInstance.DbConv.SetNewTransaction(DbConv.Transaction);
                    }
                }
                programInstance.DbConv.ProgramLevel = DbConv.ProgramLevel;
                programInstance.DbConv.ProgramLevelIncrement();
            }

            programInstance.Control.CancelProgram = false;
            programInstance.Control.ExitProgram = false;
            if (parms == null || parms.Length == 0)
                programInstance.ExecuteMain();
            else
                programInstance.ExecuteMain(parms);

            if (DbConv != null && programInstance.DbConv != null)
            {
                programInstance.DbConv.ProgramLevelDecrement();
                if (DbConv.Transaction != programInstance.DbConv.Transaction)
                    DbConv.Transaction = programInstance.DbConv.Transaction;
            }

            Return_Code.Assign(programInstance.Return_Code);

            if (programInstance.Control.CancelProgram)
            {
                ExitProgram = true;
                CancelProgram = true;
            }
            else
                ExitProgram = false;
        }

        /// <summary>
        /// Call another new program
        /// </summary>
        public void Call(IBufferValue programName, params object[] parms)
        {
            Call(programName.DisplayValue, parms);
        }
        #endregion

        #region Return
        /// <summary>
        /// Return to calling program
        /// </summary>
        /// <param name="saveArea"></param>
        public void Return(byte[] saveArea)
        {
            ExitProgram = true;
        }

        /// <summary>
        /// Return to start level with next transaction ID
        /// </summary>
        /// <param name="nextTransaction"></param>
        /// <param name="saveArea"></param>
        /// <param name="saveAreaLength"></param>
        public void Return(string nextTransaction, IBufferValue saveArea, int saveAreaLength)
        {
            ReturnTransID = nextTransaction;
            TransferProgram = string.Empty;
            ExitProgram = true;

        }
        /// <summary>
        /// Return to start level with next transaction ID
        /// </summary>
        /// <param name="nextTransaction"></param>
        /// <param name="saveArea"></param>
        /// <param name="saveAreaLength"></param>
        public void Return(IBufferValue nextTransaction, IBufferValue saveArea, int saveAreaLength)
        {
            Return(nextTransaction.DisplayValue, saveArea, saveAreaLength);
        }

        /// <summary>
        /// Return to start level with next transaction ID
        /// </summary>
        /// <param name="nextTransaction"></param>
        /// <param name="saveArea"></param>
        /// <param name="saveAreaLength"></param>
        public void Return(IBufferValue nextTransaction, IBufferValue saveArea)
        {
            Return(nextTransaction.DisplayValue, saveArea, saveArea.AsBytes.Length);
        }


        public void ReturnException(Exception ex)
        {
            Console.WriteLine("Batch runtime error: " + ex.Message);
            Console.WriteLine("         Stacktrace: " + ex.StackTrace);
            ExitProgram = true;

        }
        #endregion

        #region Misc.
        public void ThrowException()
        {

        }


        /// <summary>
        /// Retrieves current date time 
        /// </summary>
        /// <param name="dateTimeField"></param>
        public void GetLatestDateTime(IBufferValue dateTimeField)
        {
            DateTime centuryBegin = new DateTime(1900, 1, 1);
            DateTime currentDate = DateTime.Now;

            long elapsedTicks = (currentDate.Ticks - centuryBegin.Ticks) / 10000;
            dateTimeField.Assign(elapsedTicks);
        }

        public string GetCurrentTimeStamp()
        {
            DateTime currentDate = DateTime.Now;
            if (!string.IsNullOrEmpty(ConfigSettings.GetAppSettingsString("ApplicationDate")))
                currentDate = DateTime.ParseExact(ConfigSettings.GetAppSettingsString("ApplicationDate"), "yyyy-MM-dd", null) + DateTime.Now.TimeOfDay;

            return currentDate.ToString("yyyy-MM-dd HH:mm:ss.FFFFFF");
        }


        #endregion

        #endregion
    }
}
