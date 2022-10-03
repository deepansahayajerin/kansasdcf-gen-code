#region Comments
/* Conversion Comments
TIRIOVFI STUB Created
*/
#endregion
#region Using Directives
using System;
using System.Data;
using System.Collections.Generic;
using MDSY.Framework.IO.Common;
using MDSY.Framework.Buffer;
using MDSY.Framework.Buffer.BaseClasses;
using MDSY.Framework.Buffer.Interfaces;
using MDSY.Framework.Buffer.Common;
using MDSY.Framework.Core;
using MDSY.Framework.Data.SQL;
using MDSY.Framework.Interfaces;
using GOV.KS.DCF.CSS.Common.BL;
#endregion

namespace GOV.KS.DCF.CSS.Batch.BL
{
    #region File Section Class
    internal class TIRIOVFI_fd : PredefinedRecordBase
    {
        #region Name constants
        /// <summary>
        /// Name constants.
        /// </summary>
        internal static class Names
        {
            internal const string FileSection = "TIRIOVFI_fd_FileSection";
            internal const string OUTPUT_FILE = "OUTPUT_FILE";
            internal const string OUTPUT_RECORD = "OUTPUT_RECORD";
            internal const string OUTPUT_TEXT = "OUTPUT_TEXT";
        }
        #endregion

        #region Direct-access element properties
        public IFileLink OUTPUT_FILE { get; set; }
        public IGroup OUTPUT_RECORD { get { return GetElementByName<IGroup>(Names.OUTPUT_RECORD); } }
        public IField OUTPUT_TEXT { get { return GetElementByName<IField>(Names.OUTPUT_TEXT); } }


        internal TIRIOVFI_ws WS;
        #endregion

        #region Data structure definition
        /// <summary>
        /// Defines the entirety of the FileSection IRecord structure as described by the Ateras.Framework.Buffer API.
        /// </summary>
        /// <param name="recordDef">The IStructureDefinition object to be used in defining the record structure.</param>
        protected override void DefineRecordStructure(IStructureDefinition recordDef)
        {

            recordDef.CreateNewGroup(Names.OUTPUT_RECORD, (INPUT_RECORD) =>
           {
               INPUT_RECORD.CreateNewField(Names.OUTPUT_TEXT, FieldType.String, 80);
           });

        }

        protected override string GetRecordName()
        {
            return Names.FileSection;
        }
        #endregion

        #region Initialize
        public override void Initialize()
        {
            InitializeWithLowValues();
            IFileHandler FileHandler = InversionContainer.GetImplementingObject<IFileHandler>();

            OUTPUT_FILE = FileHandler.GetFile("TIRIOVF");
            OUTPUT_FILE.AssociatedBuffer = OUTPUT_RECORD;
        }
        #endregion

        #region Constructors
        public TIRIOVFI_fd(TIRIOVFI_ws ws)
            : base()
        {
            this.WS = ws;
            Initialize();

        }
        #endregion
    }
    #endregion File Section Class
    #region Working Storage Class
    internal class TIRIOVFI_ws : PredefinedRecordBase
    {
        #region Name constants
        /// <summary>
        /// Name constants.
        /// </summary>
        internal static class Names
        {
            internal const string WorkingStorage = "TIRIOVFI_ws_WorkingStorage";
            internal const string DISPLAY = "DISPLAY";
            internal const string DISPLAY_COUNTS = "DISPLAY_COUNTS";
            internal const string FILE_STS = "FILE_STS";
        }
        #endregion

        #region Direct-access element properties
        public IGroup DISPLAY { get { return GetElementByName<IGroup>(Names.DISPLAY); } }
        public IField DISPLAY_COUNTS { get { return GetElementByName<IField>(Names.DISPLAY_COUNTS); } }
        public IField FILE_STS { get { return GetElementByName<IField>(Names.FILE_STS); } }

        #endregion

        #region Data structure definition
        /// <summary>
        /// Defines the entirety of the WorkingStorage IRecord structure as described by the Ateras.Framework.Buffer API.
        /// </summary>
        /// <param name="recordDef">The IStructureDefinition object to be used in defining the record structure.</param>
        protected override void DefineRecordStructure(IStructureDefinition recordDef)
        {

            recordDef.CreateNewGroup(Names.DISPLAY, (DISPLAY) =>
           {
               DISPLAY.CreateNewField(Names.DISPLAY_COUNTS, FieldType.NumericEdited, "ZZZ,ZZZ,ZZ9-", 12);
               DISPLAY.CreateNewField(Names.FILE_STS, FieldType.UnsignedNumeric, 2);
           });

        }

        protected override string GetRecordName()
        {
            return Names.WorkingStorage;
        }
        #endregion

    }
    #endregion Working Storage Class

    #region Business Logic Class
    public class TIRIOVFI : EABBase
    {

        #region Public Constructors
        public TIRIOVFI()
            : base()
        {
            this.ProgramName.SetValue("TIRIOVFI");

            WS = new TIRIOVFI_ws();
            FD = new TIRIOVFI_fd(WS);
        }

        #endregion

        #region Private Fields


        //==== Working Storage Data Class ========================================
        private TIRIOVFI_ws WS;

        //==== File Data Class ========================================
        private TIRIOVFI_fd FD;

        #endregion

        #region Public Methods
        //========================================================================
        //==== RunMain Entry Point Method ========================================
        //========================================================================
        public override int ExecuteMain()                                              //COBOL==> PROCEDURE DIVISION USING IEF-RUNTIME-PARM1 , IEF-RUNTIME-PARM2 , W-OA , PSMGR-EAB-DATA.
        {
            try
            {
                WS.Initialize();
                RunMain();
                return Return_Code.AsInt();
            }
            catch (Exception ex)
            {
                Control.ReturnException(ex);
                return 12;
            }
        }
        #endregion

        #region Private Methods

        private void RunMain()
        {
            FD.OUTPUT_FILE.OpenFile(FileAccessMode.Write);
            FD.OUTPUT_TEXT.SetValueWithSpaces();
            FD.OUTPUT_FILE.WriteLine(FD.OUTPUT_TEXT.AsString());
            FD.OUTPUT_FILE.CloseFile();
            Return_Code.SetValue(110);
            Control.ExitProgram = true; return;                                                                 //COBOL==> GOBACK.
        }

        #endregion
    }
    #endregion
}
