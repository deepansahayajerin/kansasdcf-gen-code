#region Comments
/* Conversion Comments
Cleanup STUB Created
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
    internal class CLEANUP_fd : PredefinedRecordBase
    {
        #region Name constants
        /// <summary>
        /// Name constants.
        /// </summary>
        internal static class Names
        {
            internal const string FileSection = "CLEANUP_fd_FileSection";
            internal const string INPUT_FILE = "INPUT_FILE";
            internal const string INPUT_RECORD = "INPUT_RECORD";
            internal const string INPUT_TEXT = "INPUT_TEXT";
        }
        #endregion

        #region Direct-access element properties
        public IFileLink INPUT_FILE { get; set; }
        public IGroup INPUT_RECORD { get { return GetElementByName<IGroup>(Names.INPUT_RECORD); } }
        public IField INPUT_TEXT { get { return GetElementByName<IField>(Names.INPUT_TEXT); } }


        internal CLEANUP_ws WS;
        #endregion

        #region Data structure definition
        /// <summary>
        /// Defines the entirety of the FileSection IRecord structure as described by the Ateras.Framework.Buffer API.
        /// </summary>
        /// <param name="recordDef">The IStructureDefinition object to be used in defining the record structure.</param>
        protected override void DefineRecordStructure(IStructureDefinition recordDef)
        {

            recordDef.CreateNewGroup(Names.INPUT_RECORD, (INPUT_RECORD) =>
           {
               INPUT_RECORD.CreateNewField(Names.INPUT_TEXT, FieldType.String, 80);
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

            INPUT_FILE = FileHandler.GetFile("INPUT");
            INPUT_FILE.AssociatedBuffer = INPUT_RECORD;
        }
        #endregion

        #region Constructors
        public CLEANUP_fd(CLEANUP_ws ws)
            : base()
        {
            this.WS = ws;
            Initialize();

        }
        #endregion
    }
    #endregion File Section Class
    #region Working Storage Class
    internal class CLEANUP_ws : PredefinedRecordBase
    {
        #region Name constants
        /// <summary>
        /// Name constants.
        /// </summary>
        internal static class Names
        {
            internal const string WorkingStorage = "CLEANUP_ws_WorkingStorage";
            internal const string DISPLAY = "DISPLAY";
            internal const string DISPLAY_COUNTS = "DISPLAY_COUNTS";
            internal const string FILE_STS = "FILE_STS";
            internal const string WS_RUN_DATE_X = "WS_RUN_DATE_X";
            internal const string WS_RUN_CC = "WS_RUN_CC";
            internal const string WS_RUN_DATE = "WS_RUN_DATE";
            internal const string WS_RUN_YY = "WS_RUN_YY";
            internal const string WS_RUN_MM = "WS_RUN_MM";
            internal const string WS_RUN_DD = "WS_RUN_DD";
            internal const string WS_RUN_TIME = "WS_RUN_TIME";
            internal const string WS_DISPLAY_MESSAGE = "WS_DISPLAY_MESSAGE";
            internal const string WS_ABEND_CODE = "WS_ABEND_CODE";
            internal const string SWITCHES = "SWITCHES";
            internal const string YES = "YES";
            internal const string NOPE = "NOPE";
            internal const string FILE_OPEN_SW = "FILE_OPEN_SW";
            internal const string FILE_OPEN = "FILE_OPEN";
            internal const string FILE_NOT_OPEN = "FILE_NOT_OPEN";
            internal const string VALID_ACTION_SW = "VALID_ACTION_SW";
            internal const string VALID_ACTION = "VALID_ACTION";
            internal const string COUNTERS = "COUNTERS";
            internal const string WS_TOTAL_CHECK = "WS_TOTAL_CHECK";
            internal const string WS_TOTAL_INPT_READ = "WS_TOTAL_INPT_READ";
        }
        #endregion

        #region Direct-access element properties
        public IGroup DISPLAY { get { return GetElementByName<IGroup>(Names.DISPLAY); } }
        public IField DISPLAY_COUNTS { get { return GetElementByName<IField>(Names.DISPLAY_COUNTS); } }
        public IField FILE_STS { get { return GetElementByName<IField>(Names.FILE_STS); } }
        public IGroup WS_RUN_DATE_X { get { return GetElementByName<IGroup>(Names.WS_RUN_DATE_X); } }
        public IField WS_RUN_CC { get { return GetElementByName<IField>(Names.WS_RUN_CC); } }
        public IGroup WS_RUN_DATE { get { return GetElementByName<IGroup>(Names.WS_RUN_DATE); } }
        public IField WS_RUN_YY { get { return GetElementByName<IField>(Names.WS_RUN_YY); } }
        public IField WS_RUN_MM { get { return GetElementByName<IField>(Names.WS_RUN_MM); } }
        public IField WS_RUN_DD { get { return GetElementByName<IField>(Names.WS_RUN_DD); } }
        public IField WS_RUN_TIME { get { return GetElementByName<IField>(Names.WS_RUN_TIME); } }
        public IField WS_DISPLAY_MESSAGE { get { return GetElementByName<IField>(Names.WS_DISPLAY_MESSAGE); } }
        public IField WS_ABEND_CODE { get { return GetElementByName<IField>(Names.WS_ABEND_CODE); } }
        public IGroup SWITCHES { get { return GetElementByName<IGroup>(Names.SWITCHES); } }
        public IField YES { get { return GetElementByName<IField>(Names.YES); } }
        public IField NOPE { get { return GetElementByName<IField>(Names.NOPE); } }
        public IField FILE_OPEN_SW { get { return GetElementByName<IField>(Names.FILE_OPEN_SW); } }
        public ICheckField FILE_OPEN { get { return GetElementByName<ICheckField>(Names.FILE_OPEN); } }
        public ICheckField FILE_NOT_OPEN { get { return GetElementByName<ICheckField>(Names.FILE_NOT_OPEN); } }
        public IField VALID_ACTION_SW { get { return GetElementByName<IField>(Names.VALID_ACTION_SW); } }
        public ICheckField VALID_ACTION { get { return GetElementByName<ICheckField>(Names.VALID_ACTION); } }
        public IGroup COUNTERS { get { return GetElementByName<IGroup>(Names.COUNTERS); } }
        public IField WS_TOTAL_CHECK { get { return GetElementByName<IField>(Names.WS_TOTAL_CHECK); } }
        public IField WS_TOTAL_INPT_READ { get { return GetElementByName<IField>(Names.WS_TOTAL_INPT_READ); } }

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

            recordDef.CreateNewGroup(Names.WS_RUN_DATE_X, (WS_RUN_DATE_X) =>
           {
               WS_RUN_DATE_X.CreateNewField(Names.WS_RUN_CC, FieldType.UnsignedNumeric, 2);
               WS_RUN_DATE_X.CreateNewGroup(Names.WS_RUN_DATE, (WS_RUN_DATE) =>
               {
                   WS_RUN_DATE.CreateNewField(Names.WS_RUN_YY, FieldType.UnsignedNumeric, 2);
                   WS_RUN_DATE.CreateNewField(Names.WS_RUN_MM, FieldType.UnsignedNumeric, 2);
                   WS_RUN_DATE.CreateNewField(Names.WS_RUN_DD, FieldType.UnsignedNumeric, 2);
               });
               WS_RUN_DATE_X.CreateNewField(Names.WS_RUN_TIME, FieldType.UnsignedNumeric, 8);
           });
            recordDef.CreateNewField(Names.WS_DISPLAY_MESSAGE, FieldType.String, 40, SPACES);
            recordDef.CreateNewField(Names.WS_ABEND_CODE, FieldType.CompShort, 4, 0);

            recordDef.CreateNewGroup(Names.SWITCHES, (SWITCHES) =>
           {
               SWITCHES.CreateNewField(Names.YES, FieldType.String, 1, "Y");
               SWITCHES.CreateNewField(Names.NOPE, FieldType.String, 1, "N");
               SWITCHES.CreateNewField(Names.FILE_OPEN_SW, FieldType.String, 1, "N")
                   .NewCheckField(Names.FILE_OPEN, "Y")
                   .NewCheckField(Names.FILE_NOT_OPEN, "N")
                   ;
               SWITCHES.CreateNewField(Names.VALID_ACTION_SW, FieldType.String, 8, SPACES)
                   .NewCheckField(Names.VALID_ACTION, "OPEN    ", "READ    ", "CLOSE   ")
                   ;
           });

            recordDef.CreateNewGroup(Names.COUNTERS, (COUNTERS) =>
           {
               COUNTERS.CreateNewField(Names.WS_TOTAL_CHECK, FieldType.String, 9);
               COUNTERS.CreateNewField(Names.WS_TOTAL_INPT_READ, FieldType.UnsignedNumeric, 9, 0);
           });

        }

        protected override string GetRecordName()
        {
            return Names.WorkingStorage;
        }
        #endregion

    }
    #endregion Working Storage Class

    #region Linkage Section Class
    internal class CLEANUP_ls : PredefinedRecordBase
    {
        #region Name constants
        /// <summary>
        /// Name constants.
        /// </summary>
        internal static class Names
        {
            internal const string LinkageSection = "CLEANUP_ls_LinkageSection";
            internal const string IEF_RUNTIME_PARM1 = "IEF_RUNTIME_PARM1";
            internal const string IEF_RUNTIME_PARM2 = "IEF_RUNTIME_PARM2";
            internal const string PSMGR_EAB_DATA = "PSMGR_EAB_DATA";
            internal const string PSMGR_EABPCB_CNT = "PSMGR_EABPCB_CNT";
            internal const string PSMGR_EABPCB_ENTRY = "PSMGR_EABPCB_ENTRY";
            internal const string PSMGR_EABPCB_ADR = "PSMGR_EABPCB_ADR";
            internal const string W_OA = "W_OA";
            internal const string A_1277169671_OA = "A_1277169671_OA";
            internal const string EXPORT_0001EV = "EXPORT_0001EV";
            internal const string EAB_FILE_HANDLING_0001ET = "EAB_FILE_HANDLING_0001ET";
            internal const string ACTION_0001 = "ACTION_0001";
            internal const string ACTION_0001XX = "ACTION_0001XX";
            internal const string STATUS_0001 = "STATUS_0001";
            internal const string STATUS_0001XX = "STATUS_0001XX";
            internal const string EXPORT_0002EV = "EXPORT_0002EV";
            internal const string LEGAL_ACTION_0002ET = "LEGAL_ACTION_0002ET";
            internal const string IDENTIFIER_0002 = "IDENTIFIER_0002";
            internal const string IDENTIFIER_0002XX = "IDENTIFIER_0002XX";
            internal const string STANDARD_NUMBER_0002 = "STANDARD_NUMBER_0002";
            internal const string STANDARD_NUMBER_0002XX = "STANDARD_NUMBER_0002XX";
            internal const string EXPORT_0003EV = "EXPORT_0003EV";
            internal const string CSE_PERSON_0003ET = "CSE_PERSON_0003ET";
            internal const string NUMBER_0003 = "NUMBER_0003";
            internal const string NUMBER_0003XX = "NUMBER_0003XX";
        }
        #endregion

        #region Direct-access element properties
        public IField IEF_RUNTIME_PARM1 { get { return GetElementByName<IField>(Names.IEF_RUNTIME_PARM1); } }
        public IField IEF_RUNTIME_PARM2 { get { return GetElementByName<IField>(Names.IEF_RUNTIME_PARM2); } }
        public IGroup PSMGR_EAB_DATA { get { return GetElementByName<IGroup>(Names.PSMGR_EAB_DATA); } }
        public IField PSMGR_EABPCB_CNT { get { return GetElementByName<IField>(Names.PSMGR_EABPCB_CNT); } }
        public IArrayElementAccessor<IGroup> PSMGR_EABPCB_ENTRY { get { return GetArrayElementAccessor<IGroup>(Names.PSMGR_EABPCB_ENTRY); } }
        public IArrayElementAccessor<IField> PSMGR_EABPCB_ADR { get { return GetArrayElementAccessor<IField>(Names.PSMGR_EABPCB_ADR); } }
        public IGroup W_OA { get { return GetElementByName<IGroup>(Names.W_OA); } }
        public IGroup A_1277169671_OA { get { return GetElementByName<IGroup>(Names.A_1277169671_OA); } }
        public IGroup EXPORT_0001EV { get { return GetElementByName<IGroup>(Names.EXPORT_0001EV); } }
        public IGroup EAB_FILE_HANDLING_0001ET { get { return GetElementByName<IGroup>(Names.EAB_FILE_HANDLING_0001ET); } }
        public IField ACTION_0001 { get { return GetElementByName<IField>(Names.ACTION_0001); } }
        public IField ACTION_0001XX { get { return GetElementByName<IField>(Names.ACTION_0001XX); } }
        public IField STATUS_0001 { get { return GetElementByName<IField>(Names.STATUS_0001); } }
        public IField STATUS_0001XX { get { return GetElementByName<IField>(Names.STATUS_0001XX); } }
        public IGroup EXPORT_0002EV { get { return GetElementByName<IGroup>(Names.EXPORT_0002EV); } }
        public IGroup LEGAL_ACTION_0002ET { get { return GetElementByName<IGroup>(Names.LEGAL_ACTION_0002ET); } }
        public IField IDENTIFIER_0002 { get { return GetElementByName<IField>(Names.IDENTIFIER_0002); } }
        public IField IDENTIFIER_0002XX { get { return GetElementByName<IField>(Names.IDENTIFIER_0002XX); } }
        public IField STANDARD_NUMBER_0002 { get { return GetElementByName<IField>(Names.STANDARD_NUMBER_0002); } }
        public IField STANDARD_NUMBER_0002XX { get { return GetElementByName<IField>(Names.STANDARD_NUMBER_0002XX); } }
        public IGroup EXPORT_0003EV { get { return GetElementByName<IGroup>(Names.EXPORT_0003EV); } }
        public IGroup CSE_PERSON_0003ET { get { return GetElementByName<IGroup>(Names.CSE_PERSON_0003ET); } }
        public IField NUMBER_0003 { get { return GetElementByName<IField>(Names.NUMBER_0003); } }
        public IField NUMBER_0003XX { get { return GetElementByName<IField>(Names.NUMBER_0003XX); } }

        #endregion

        #region Data structure definition
        /// <summary>
        /// Defines the entirety of the LinkageSection IRecord structure as described by the Ateras.Framework.Buffer API.
        /// </summary>
        /// <param name="recordDef">The IStructureDefinition object to be used in defining the record structure.</param>
        protected override void DefineRecordStructure(IStructureDefinition recordDef)
        {
            recordDef.CreateNewField(Names.IEF_RUNTIME_PARM1, FieldType.String, 1);
            recordDef.CreateNewField(Names.IEF_RUNTIME_PARM2, FieldType.String, 1);

            recordDef.CreateNewGroup(Names.PSMGR_EAB_DATA, (PSMGR_EAB_DATA) =>
           {
               PSMGR_EAB_DATA.CreateNewField(Names.PSMGR_EABPCB_CNT, FieldType.CompInt, 9);
               PSMGR_EAB_DATA.CreateNewGroupArray(Names.PSMGR_EABPCB_ENTRY, 255, (PSMGR_EABPCB_ENTRY) =>
               {
                   PSMGR_EABPCB_ENTRY.CreateNewField(Names.PSMGR_EABPCB_ADR, FieldType.CompInt, 9);
               });
           });

            recordDef.CreateNewGroup(Names.W_OA, (W_OA) =>
           {
               W_OA.CreateNewGroup(Names.A_1277169671_OA, (A_1277169671_OA) =>
               {
                   A_1277169671_OA.CreateNewGroup(Names.EXPORT_0001EV, (EXPORT_0001EV) =>
                   {
                       EXPORT_0001EV.CreateNewGroup(Names.EAB_FILE_HANDLING_0001ET, (EAB_FILE_HANDLING_0001ET) =>
                       {

                           IField ACTION_0001_local = EAB_FILE_HANDLING_0001ET.CreateNewField(Names.ACTION_0001, FieldType.String, 8);
                           EAB_FILE_HANDLING_0001ET.CreateNewFieldRedefine(Names.ACTION_0001XX, FieldType.String, ACTION_0001_local, 8);

                           IField STATUS_0001_local = EAB_FILE_HANDLING_0001ET.CreateNewField(Names.STATUS_0001, FieldType.String, 8);
                           EAB_FILE_HANDLING_0001ET.CreateNewFieldRedefine(Names.STATUS_0001XX, FieldType.String, STATUS_0001_local, 8);
                       });
                   });
                   A_1277169671_OA.CreateNewGroup(Names.EXPORT_0002EV, (EXPORT_0002EV) =>
                   {
                       EXPORT_0002EV.CreateNewGroup(Names.LEGAL_ACTION_0002ET, (LEGAL_ACTION_0002ET) =>
                       {

                           IField IDENTIFIER_0002_local = LEGAL_ACTION_0002ET.CreateNewField(Names.IDENTIFIER_0002, FieldType.SignedNumeric, 9);
                           LEGAL_ACTION_0002ET.CreateNewFieldRedefine(Names.IDENTIFIER_0002XX, FieldType.String, IDENTIFIER_0002_local, 9);

                           IField STANDARD_NUMBER_0002_local = LEGAL_ACTION_0002ET.CreateNewField(Names.STANDARD_NUMBER_0002, FieldType.String, 20);
                           LEGAL_ACTION_0002ET.CreateNewFieldRedefine(Names.STANDARD_NUMBER_0002XX, FieldType.String, STANDARD_NUMBER_0002_local, 20);
                       });
                   });
                   A_1277169671_OA.CreateNewGroup(Names.EXPORT_0003EV, (EXPORT_0003EV) =>
                   {
                       EXPORT_0003EV.CreateNewGroup(Names.CSE_PERSON_0003ET, (CSE_PERSON_0003ET) =>
                       {

                           IField NUMBER_0003_local = CSE_PERSON_0003ET.CreateNewField(Names.NUMBER_0003, FieldType.String, 10);
                           CSE_PERSON_0003ET.CreateNewFieldRedefine(Names.NUMBER_0003XX, FieldType.String, NUMBER_0003_local, 10);
                       });
                   });
               });
           });

        }

        protected override string GetRecordName()
        {
            return Names.LinkageSection;
        }
        #endregion

        public void SetPassedParameters(object[] args)
        {
            SetPassedParm(IEF_RUNTIME_PARM1, args, 0);
            SetPassedParm(IEF_RUNTIME_PARM2, args, 1);
            SetPassedParm(W_OA, args, 2);
            SetPassedParm(PSMGR_EAB_DATA, args, 3);
        }


        public void UpdateReturnParameters(object[] args)
        {
            SetReturnParm(IEF_RUNTIME_PARM1, args, 0);
            SetReturnParm(IEF_RUNTIME_PARM2, args, 1);
            SetReturnParm(W_OA, args, 2);
            SetReturnParm(PSMGR_EAB_DATA, args, 3);
        }
    }
    #endregion Linkage Section Class

    #region Business Logic Class
    public class CLEANUP : EABBase
    {

        #region Public Constructors
        public CLEANUP()
            : base()
        {
            this.ProgramName.SetValue("CLEANUP");

            WS = new CLEANUP_ws();
            FD = new CLEANUP_fd(WS);
            LS = new CLEANUP_ls();
        }

        #endregion

        #region Private Fields


        //==== Working Storage Data Class ========================================
        private CLEANUP_ws WS;

        //==== File Data Class ========================================
        private CLEANUP_fd FD;

        //==== Linkage Section Data Class ========================================
        private CLEANUP_ls LS;
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
            string returnMethod = "Main";
            //DO some cleanup                                                                      
            Control.ExitProgram = true; return;                                                                 //COBOL==> GOBACK.
        }

        #endregion
    }
    #endregion
}
