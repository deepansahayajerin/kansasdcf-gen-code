#region Comments
/* Conversion Comments
   ************************************************************
   **   MODERN SYSTEMS INC.  COPYRIGHT 2000-2022
   **   DB-SHUTTLE COBOL to C# Conversion
   ************************************************************
   ** INIT   *  INITIAL VERSION   *  2022-03-02 04:42:54 PM
   **        *   FROM COBOL PGM   :  SWEXEE06
   **        *   FROM CANISTER    :  SR.CAECSES.PROD.LIBR.SOURCE.PDS
   ************************************************************ */

/* Original Program Identification Comments
   **************************************************************
                       SOURCE CODE GENERATED BY
                   INFORMATION ENGINEERING FACILITY (TM)
                       TEXAS INSTRUMENTS INC.
                COPYRIGHT (C) TEXAS INSTRUMENTS INC. 1996
       NAME: OE_EAB_RECEIVE_FPLS_ERRORS       DATE: 96/07/17
       TARGET OS:   MVS                       TIME: 18:51:50
       TARGET DBMS: DB2                       USER: SWMTJWH
       GENERATION OPTIONS:
       DEBUG TRACE OPTION SELECTED
       DATA MODELING CONSTRAINT ENFORCEMENT NOT SELECTED
       OPTIMIZED IMPORT VIEW INITIALIZATION SELECTED
   **************************************************************
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
using MDSY.Framework.IO.Common;
#endregion

namespace GOV.KS.DCF.CSS.Batch.BL
{
    #region File Section Class
    internal class SWEXEE06_fd : PredefinedRecordBase
    {
        #region Name constants
        /// <summary>
        /// Name constants.
        /// </summary>
        internal static class Names
        {
            internal const string FileSection = "SWEXEE06_fd_FileSection";
            internal const string EXTFILE = "EXTFILE";
            internal const string EXTFILE_RECORD = "EXTFILE_RECORD";
        }
        #endregion

        #region Direct-access element properties
        public IFileLink EXTFILE { get; set; }
        public IField EXTFILE_RECORD { get { return GetElementByName<IField>(Names.EXTFILE_RECORD); } }


        internal SWEXEE06_ws WS;
        #endregion

        #region Data structure definition
        /// <summary>
        /// Defines the entirety of the FileSection IRecord structure as described by the Ateras.Framework.Buffer API.
        /// </summary>
        /// <param name="recordDef">The IStructureDefinition object to be used in defining the record structure.</param>
        protected override void DefineRecordStructure(IStructureDefinition recordDef)
        {
            recordDef.CreateNewField(Names.EXTFILE_RECORD, FieldType.String, 475);

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

            EXTFILE = FileHandler.GetFile("EXTFILE");
            EXTFILE.StatusField = WS.EXTFILE_STAT;
            EXTFILE.AssociatedBuffer = EXTFILE_RECORD;
        }
        #endregion

        #region Constructors
        public SWEXEE06_fd(SWEXEE06_ws ws)
            : base()
        {
            this.WS = ws;
            Initialize();

        }
        #endregion
    }
    #endregion File Section Class
    #region Working Storage Class
    internal class SWEXEE06_ws : PredefinedRecordBase
    {
        #region Name constants
        /// <summary>
        /// Name constants.
        /// </summary>
        internal static class Names
        {
            internal const string WorkingStorage = "SWEXEE06_ws_WorkingStorage";
            internal const string EXTFILE_STAT = "EXTFILE_STAT";
            internal const string WS_MISC = "WS_MISC";
            internal const string WS_ENTRY = "WS_ENTRY";
            internal const string WS_RECORD_COUNT = "WS_RECORD_COUNT";
            internal const string WS_EXTERNAL_FPLS_REQUEST = "WS_EXTERNAL_FPLS_REQUEST";
            internal const string SPACES_1 = "SPACES_1";
            internal const string AP_CSE_PERSON_NUMBER = "AP_CSE_PERSON_NUMBER";
            internal const string FPLS_LOCATE_REQUEST_IDENT = "FPLS_LOCATE_REQUEST_IDENT";
            internal const string SPACES_2 = "SPACES_2";
            internal const string TRANSACTION_ERROR = "TRANSACTION_ERROR";
            internal const string SPACES_3 = "SPACES_3";
            internal const string FUNC_0747912471_ESC_FLAG = "FUNC_0747912471_ESC_FLAG";
        }
        #endregion

        #region Direct-access element properties
        public IField EXTFILE_STAT { get { return GetExternalElementByName<IField>(Names.EXTFILE_STAT); } }
        public IGroup WS_MISC { get { return GetElementByName<IGroup>(Names.WS_MISC); } }
        public IField WS_ENTRY { get { return GetElementByName<IField>(Names.WS_ENTRY); } }
        public IField WS_RECORD_COUNT { get { return GetElementByName<IField>(Names.WS_RECORD_COUNT); } }
        public IGroup WS_EXTERNAL_FPLS_REQUEST { get { return GetElementByName<IGroup>(Names.WS_EXTERNAL_FPLS_REQUEST); } }
        public IField SPACES_1 { get { return GetElementByName<IField>(Names.SPACES_1); } }
        public IField AP_CSE_PERSON_NUMBER { get { return GetElementByName<IField>(Names.AP_CSE_PERSON_NUMBER); } }
        public IField FPLS_LOCATE_REQUEST_IDENT { get { return GetElementByName<IField>(Names.FPLS_LOCATE_REQUEST_IDENT); } }
        public IField SPACES_2 { get { return GetElementByName<IField>(Names.SPACES_2); } }
        public IField TRANSACTION_ERROR { get { return GetElementByName<IField>(Names.TRANSACTION_ERROR); } }
        public IField SPACES_3 { get { return GetElementByName<IField>(Names.SPACES_3); } }
        public IField FUNC_0747912471_ESC_FLAG { get { return GetElementByName<IField>(Names.FUNC_0747912471_ESC_FLAG); } }

        #endregion

        #region Data structure definition
        /// <summary>
        /// Defines the entirety of the WorkingStorage IRecord structure as described by the Ateras.Framework.Buffer API.
        /// </summary>
        /// <param name="recordDef">The IStructureDefinition object to be used in defining the record structure.</param>
        protected override void DefineRecordStructure(IStructureDefinition recordDef)
        {
            WsExternals.Instance.CreateNewField(Names.EXTFILE_STAT, FieldType.UnsignedNumeric, 2);

            recordDef.CreateNewGroup(Names.WS_MISC, (WS_MISC) =>
           {
               WS_MISC.CreateNewField(Names.WS_ENTRY, FieldType.String, 40, "SWEX490W WORKING STORAGE STARTS HERE");
               WS_MISC.CreateNewField(Names.WS_RECORD_COUNT, FieldType.UnsignedNumeric, 7, ZEROES);
           });

            recordDef.CreateNewGroup(Names.WS_EXTERNAL_FPLS_REQUEST, (WS_EXTERNAL_FPLS_REQUEST) =>
           {
               WS_EXTERNAL_FPLS_REQUEST.CreateNewField(Names.SPACES_1, FieldType.String, 40);
               WS_EXTERNAL_FPLS_REQUEST.CreateNewField(Names.AP_CSE_PERSON_NUMBER, FieldType.String, 10);
               WS_EXTERNAL_FPLS_REQUEST.CreateNewField(Names.FPLS_LOCATE_REQUEST_IDENT, FieldType.UnsignedNumeric, 5);
               WS_EXTERNAL_FPLS_REQUEST.CreateNewField(Names.SPACES_2, FieldType.String, 281);
               WS_EXTERNAL_FPLS_REQUEST.CreateNewField(Names.TRANSACTION_ERROR, FieldType.String, 10);
               WS_EXTERNAL_FPLS_REQUEST.CreateNewField(Names.SPACES_3, FieldType.String, 129);
           });
            recordDef.CreateNewField(Names.FUNC_0747912471_ESC_FLAG, FieldType.String, 1);

        }

        protected override string GetRecordName()
        {
            return Names.WorkingStorage;
        }
        #endregion

    }
    #endregion Working Storage Class

    #region Linkage Section Class
    internal class SWEXEE06_ls : PredefinedRecordBase
    {
        #region Name constants
        /// <summary>
        /// Name constants.
        /// </summary>
        internal static class Names
        {
            internal const string LinkageSection = "SWEXEE06_ls_LinkageSection";
            internal const string IEF_RUNTIME_PARM1 = "IEF_RUNTIME_PARM1";
            internal const string IEF_RUNTIME_PARM2 = "IEF_RUNTIME_PARM2";
            internal const string PSMGR_EAB_DATA = "PSMGR_EAB_DATA";
            internal const string PSMGR_EABPCB_CNT = "PSMGR_EABPCB_CNT";
            internal const string PSMGR_EABPCB_ENTRY = "PSMGR_EABPCB_ENTRY";
            internal const string PSMGR_EABPCB_ADR = "PSMGR_EABPCB_ADR";
            internal const string W_IA = "W_IA";
            internal const string A_0747912474_IA = "A_0747912474_IA";
            internal const string IMPORT_0001EV = "IMPORT_0001EV";
            internal const string EXTERNAL_0001ET = "EXTERNAL_0001ET";
            internal const string FILE_INSTRUCTION_0001AS = "FILE_INSTRUCTION_0001AS";
            internal const string FILE_INSTRUCTION_0001 = "FILE_INSTRUCTION_0001";
            internal const string FILE_INSTRUCTION_0001XX = "FILE_INSTRUCTION_0001XX";
            internal const string W_OA = "W_OA";
            internal const string A_0747912478_OA = "A_0747912478_OA";
            internal const string EXPORT_0002EV = "EXPORT_0002EV";
            internal const string EXTERNAL_FPLS_REQUEST_0002ET = "EXTERNAL_FPLS_REQUEST_0002ET";
            internal const string AP_CSE_PERSON_NUMBER_0002AS = "AP_CSE_PERSON_NUMBER_0002AS";
            internal const string AP_CSE_PERSON_NUMBER_0002 = "AP_CSE_PERSON_NUMBER_0002";
            internal const string AP_CSE_PERSON_NUMBER_0002XX = "AP_CSE_PERSON_NUMBER_0002XX";
            internal const string FPLS_LOCATE_REQUEST_IDE_0003AS = "FPLS_LOCATE_REQUEST_IDE_0003AS";
            internal const string FPLS_LOCATE_REQUEST_IDENT_0003 = "FPLS_LOCATE_REQUEST_IDENT_0003";
            internal const string FPLS_LOCATE_REQUEST_IDE_0003XX = "FPLS_LOCATE_REQUEST_IDE_0003XX";
            internal const string TRANSACTION_ERROR_0003AS = "TRANSACTION_ERROR_0003AS";
            internal const string TRANSACTION_ERROR_0003 = "TRANSACTION_ERROR_0003";
            internal const string TRANSACTION_ERROR_0003XX = "TRANSACTION_ERROR_0003XX";
            internal const string EXPORT_0004EV = "EXPORT_0004EV";
            internal const string EXTERNAL_0004ET = "EXTERNAL_0004ET";
            internal const string FILE_INSTRUCTION_0004AS = "FILE_INSTRUCTION_0004AS";
            internal const string FILE_INSTRUCTION_0004 = "FILE_INSTRUCTION_0004";
            internal const string FILE_INSTRUCTION_0004XX = "FILE_INSTRUCTION_0004XX";
            internal const string NUMERIC_RETURN_CODE_0004AS = "NUMERIC_RETURN_CODE_0004AS";
            internal const string NUMERIC_RETURN_CODE_0004 = "NUMERIC_RETURN_CODE_0004";
            internal const string NUMERIC_RETURN_CODE_0004XX = "NUMERIC_RETURN_CODE_0004XX";
            internal const string TEXT_RETURN_CODE_0004AS = "TEXT_RETURN_CODE_0004AS";
            internal const string TEXT_RETURN_CODE_0004 = "TEXT_RETURN_CODE_0004";
            internal const string TEXT_RETURN_CODE_0004XX = "TEXT_RETURN_CODE_0004XX";
            internal const string TEXT_LINE_80_0004AS = "TEXT_LINE_80_0004AS";
            internal const string TEXT_LINE_80_0004 = "TEXT_LINE_80_0004";
            internal const string TEXT_LINE_80_0004XX = "TEXT_LINE_80_0004XX";
        }
        #endregion

        #region Direct-access element properties
        public IField IEF_RUNTIME_PARM1 { get { return GetElementByName<IField>(Names.IEF_RUNTIME_PARM1); } }
        public IField IEF_RUNTIME_PARM2 { get { return GetElementByName<IField>(Names.IEF_RUNTIME_PARM2); } }
        public IGroup PSMGR_EAB_DATA { get { return GetElementByName<IGroup>(Names.PSMGR_EAB_DATA); } }
        public IField PSMGR_EABPCB_CNT { get { return GetElementByName<IField>(Names.PSMGR_EABPCB_CNT); } }
        public IArrayElementAccessor<IGroup> PSMGR_EABPCB_ENTRY { get { return GetArrayElementAccessor<IGroup>(Names.PSMGR_EABPCB_ENTRY); } }
        public IArrayElementAccessor<IField> PSMGR_EABPCB_ADR { get { return GetArrayElementAccessor<IField>(Names.PSMGR_EABPCB_ADR); } }
        public IGroup W_IA { get { return GetElementByName<IGroup>(Names.W_IA); } }
        public IGroup A_0747912474_IA { get { return GetElementByName<IGroup>(Names.A_0747912474_IA); } }
        public IGroup IMPORT_0001EV { get { return GetElementByName<IGroup>(Names.IMPORT_0001EV); } }
        public IGroup EXTERNAL_0001ET { get { return GetElementByName<IGroup>(Names.EXTERNAL_0001ET); } }
        public IField FILE_INSTRUCTION_0001AS { get { return GetElementByName<IField>(Names.FILE_INSTRUCTION_0001AS); } }
        public IField FILE_INSTRUCTION_0001 { get { return GetElementByName<IField>(Names.FILE_INSTRUCTION_0001); } }
        public IField FILE_INSTRUCTION_0001XX { get { return GetElementByName<IField>(Names.FILE_INSTRUCTION_0001XX); } }
        public IGroup W_OA { get { return GetElementByName<IGroup>(Names.W_OA); } }
        public IGroup A_0747912478_OA { get { return GetElementByName<IGroup>(Names.A_0747912478_OA); } }
        public IGroup EXPORT_0002EV { get { return GetElementByName<IGroup>(Names.EXPORT_0002EV); } }
        public IGroup EXTERNAL_FPLS_REQUEST_0002ET { get { return GetElementByName<IGroup>(Names.EXTERNAL_FPLS_REQUEST_0002ET); } }
        public IField AP_CSE_PERSON_NUMBER_0002AS { get { return GetElementByName<IField>(Names.AP_CSE_PERSON_NUMBER_0002AS); } }
        public IField AP_CSE_PERSON_NUMBER_0002 { get { return GetElementByName<IField>(Names.AP_CSE_PERSON_NUMBER_0002); } }
        public IField AP_CSE_PERSON_NUMBER_0002XX { get { return GetElementByName<IField>(Names.AP_CSE_PERSON_NUMBER_0002XX); } }
        public IField FPLS_LOCATE_REQUEST_IDE_0003AS { get { return GetElementByName<IField>(Names.FPLS_LOCATE_REQUEST_IDE_0003AS); } }
        public IField FPLS_LOCATE_REQUEST_IDENT_0003 { get { return GetElementByName<IField>(Names.FPLS_LOCATE_REQUEST_IDENT_0003); } }
        public IField FPLS_LOCATE_REQUEST_IDE_0003XX { get { return GetElementByName<IField>(Names.FPLS_LOCATE_REQUEST_IDE_0003XX); } }
        public IField TRANSACTION_ERROR_0003AS { get { return GetElementByName<IField>(Names.TRANSACTION_ERROR_0003AS); } }
        public IField TRANSACTION_ERROR_0003 { get { return GetElementByName<IField>(Names.TRANSACTION_ERROR_0003); } }
        public IField TRANSACTION_ERROR_0003XX { get { return GetElementByName<IField>(Names.TRANSACTION_ERROR_0003XX); } }
        public IGroup EXPORT_0004EV { get { return GetElementByName<IGroup>(Names.EXPORT_0004EV); } }
        public IGroup EXTERNAL_0004ET { get { return GetElementByName<IGroup>(Names.EXTERNAL_0004ET); } }
        public IField FILE_INSTRUCTION_0004AS { get { return GetElementByName<IField>(Names.FILE_INSTRUCTION_0004AS); } }
        public IField FILE_INSTRUCTION_0004 { get { return GetElementByName<IField>(Names.FILE_INSTRUCTION_0004); } }
        public IField FILE_INSTRUCTION_0004XX { get { return GetElementByName<IField>(Names.FILE_INSTRUCTION_0004XX); } }
        public IField NUMERIC_RETURN_CODE_0004AS { get { return GetElementByName<IField>(Names.NUMERIC_RETURN_CODE_0004AS); } }
        public IField NUMERIC_RETURN_CODE_0004 { get { return GetElementByName<IField>(Names.NUMERIC_RETURN_CODE_0004); } }
        public IField NUMERIC_RETURN_CODE_0004XX { get { return GetElementByName<IField>(Names.NUMERIC_RETURN_CODE_0004XX); } }
        public IField TEXT_RETURN_CODE_0004AS { get { return GetElementByName<IField>(Names.TEXT_RETURN_CODE_0004AS); } }
        public IField TEXT_RETURN_CODE_0004 { get { return GetElementByName<IField>(Names.TEXT_RETURN_CODE_0004); } }
        public IField TEXT_RETURN_CODE_0004XX { get { return GetElementByName<IField>(Names.TEXT_RETURN_CODE_0004XX); } }
        public IField TEXT_LINE_80_0004AS { get { return GetElementByName<IField>(Names.TEXT_LINE_80_0004AS); } }
        public IField TEXT_LINE_80_0004 { get { return GetElementByName<IField>(Names.TEXT_LINE_80_0004); } }
        public IField TEXT_LINE_80_0004XX { get { return GetElementByName<IField>(Names.TEXT_LINE_80_0004XX); } }

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

            recordDef.CreateNewGroup(Names.W_IA, (W_IA) =>
           {
               W_IA.CreateNewGroup(Names.A_0747912474_IA, (A_0747912474_IA) =>
               {
                   A_0747912474_IA.CreateNewGroup(Names.IMPORT_0001EV, (IMPORT_0001EV) =>
                   {
                       IMPORT_0001EV.CreateNewGroup(Names.EXTERNAL_0001ET, (EXTERNAL_0001ET) =>
                       {
                           EXTERNAL_0001ET.CreateNewField(Names.FILE_INSTRUCTION_0001AS, FieldType.String, 1);

                           IField FILE_INSTRUCTION_0001_local = EXTERNAL_0001ET.CreateNewField(Names.FILE_INSTRUCTION_0001, FieldType.String, 10);
                           EXTERNAL_0001ET.CreateNewFieldRedefine(Names.FILE_INSTRUCTION_0001XX, FieldType.String, FILE_INSTRUCTION_0001_local, 10);
                       });
                   });
               });
           });

            recordDef.CreateNewGroup(Names.W_OA, (W_OA) =>
           {
               W_OA.CreateNewGroup(Names.A_0747912478_OA, (A_0747912478_OA) =>
               {
                   A_0747912478_OA.CreateNewGroup(Names.EXPORT_0002EV, (EXPORT_0002EV) =>
                   {
                       EXPORT_0002EV.CreateNewGroup(Names.EXTERNAL_FPLS_REQUEST_0002ET, (EXTERNAL_FPLS_REQUEST_0002ET) =>
                       {
                           EXTERNAL_FPLS_REQUEST_0002ET.CreateNewField(Names.AP_CSE_PERSON_NUMBER_0002AS, FieldType.String, 1);

                           IField AP_CSE_PERSON_NUMBER_0002_local = EXTERNAL_FPLS_REQUEST_0002ET.CreateNewField(Names.AP_CSE_PERSON_NUMBER_0002, FieldType.String, 10);
                           EXTERNAL_FPLS_REQUEST_0002ET.CreateNewFieldRedefine(Names.AP_CSE_PERSON_NUMBER_0002XX, FieldType.String, AP_CSE_PERSON_NUMBER_0002_local, 10);
                           EXTERNAL_FPLS_REQUEST_0002ET.CreateNewField(Names.FPLS_LOCATE_REQUEST_IDE_0003AS, FieldType.String, 1);

                           IField FPLS_LOCATE_REQUEST_IDENT_0003_local = EXTERNAL_FPLS_REQUEST_0002ET.CreateNewField(Names.FPLS_LOCATE_REQUEST_IDENT_0003, FieldType.SignedNumeric, 5);
                           EXTERNAL_FPLS_REQUEST_0002ET.CreateNewFieldRedefine(Names.FPLS_LOCATE_REQUEST_IDE_0003XX, FieldType.String, FPLS_LOCATE_REQUEST_IDENT_0003_local, 5);
                           EXTERNAL_FPLS_REQUEST_0002ET.CreateNewField(Names.TRANSACTION_ERROR_0003AS, FieldType.String, 1);

                           IField TRANSACTION_ERROR_0003_local = EXTERNAL_FPLS_REQUEST_0002ET.CreateNewField(Names.TRANSACTION_ERROR_0003, FieldType.String, 10);
                           EXTERNAL_FPLS_REQUEST_0002ET.CreateNewFieldRedefine(Names.TRANSACTION_ERROR_0003XX, FieldType.String, TRANSACTION_ERROR_0003_local, 10);
                       });
                   });
                   A_0747912478_OA.CreateNewGroup(Names.EXPORT_0004EV, (EXPORT_0004EV) =>
                   {
                       EXPORT_0004EV.CreateNewGroup(Names.EXTERNAL_0004ET, (EXTERNAL_0004ET) =>
                       {
                           EXTERNAL_0004ET.CreateNewField(Names.FILE_INSTRUCTION_0004AS, FieldType.String, 1);

                           IField FILE_INSTRUCTION_0004_local = EXTERNAL_0004ET.CreateNewField(Names.FILE_INSTRUCTION_0004, FieldType.String, 10);
                           EXTERNAL_0004ET.CreateNewFieldRedefine(Names.FILE_INSTRUCTION_0004XX, FieldType.String, FILE_INSTRUCTION_0004_local, 10);
                           EXTERNAL_0004ET.CreateNewField(Names.NUMERIC_RETURN_CODE_0004AS, FieldType.String, 1);

                           IField NUMERIC_RETURN_CODE_0004_local = EXTERNAL_0004ET.CreateNewField(Names.NUMERIC_RETURN_CODE_0004, FieldType.SignedNumeric, 2);
                           EXTERNAL_0004ET.CreateNewFieldRedefine(Names.NUMERIC_RETURN_CODE_0004XX, FieldType.String, NUMERIC_RETURN_CODE_0004_local, 2);
                           EXTERNAL_0004ET.CreateNewField(Names.TEXT_RETURN_CODE_0004AS, FieldType.String, 1);

                           IField TEXT_RETURN_CODE_0004_local = EXTERNAL_0004ET.CreateNewField(Names.TEXT_RETURN_CODE_0004, FieldType.String, 2);
                           EXTERNAL_0004ET.CreateNewFieldRedefine(Names.TEXT_RETURN_CODE_0004XX, FieldType.String, TEXT_RETURN_CODE_0004_local, 2);
                           EXTERNAL_0004ET.CreateNewField(Names.TEXT_LINE_80_0004AS, FieldType.String, 1);

                           IField TEXT_LINE_80_0004_local = EXTERNAL_0004ET.CreateNewField(Names.TEXT_LINE_80_0004, FieldType.String, 130);
                           EXTERNAL_0004ET.CreateNewFieldRedefine(Names.TEXT_LINE_80_0004XX, FieldType.String, TEXT_LINE_80_0004_local, 130);
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
            SetPassedParm(W_IA, args, 2);
            SetPassedParm(W_OA, args, 3);
            SetPassedParm(PSMGR_EAB_DATA, args, 4);
        }


        public void UpdateReturnParameters(object[] args)
        {
            SetReturnParm(IEF_RUNTIME_PARM1, args, 0);
            SetReturnParm(IEF_RUNTIME_PARM2, args, 1);
            SetReturnParm(W_IA, args, 2);
            SetReturnParm(W_OA, args, 3);
            SetReturnParm(PSMGR_EAB_DATA, args, 4);
        }
    }
    #endregion Linkage Section Class

    #region Business Logic Class
    public class SWEXEE06 : EABBase
    {

        #region Public Constructors
        public SWEXEE06()
            : base()
        {
            this.ProgramName.SetValue("SWEXEE06");

            WS = new SWEXEE06_ws();
            FD = new SWEXEE06_fd(WS);
            LS = new SWEXEE06_ls();
        }

        #endregion

        #region Private Fields


        //==== Working Storage Data Class ========================================
        private SWEXEE06_ws WS;

        //==== File Data Class ========================================
        private SWEXEE06_fd FD;

        //==== Linkage Section Data Class ========================================
        private SWEXEE06_ls LS;
        #endregion

        #region Public Methods
        //========================================================================
        //==== RunMain Entry Point Method ========================================
        //========================================================================
        public override int ExecuteMain(params object[] args)                                              //COBOL==> PROCEDURE DIVISION USING IEF-RUNTIME-PARM1 , IEF-RUNTIME-PARM2 , W-IA , W-OA , PSMGR-EAB-DATA.
        {
            try
            {
                WS.Initialize();
                LS.SetPassedParameters(args);
                RunMain();
                LS.UpdateReturnParameters(args);
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
            // Execute Procedure Division Logic
            M_MAIN_0747912471(returnMethod);
        }
        /// <summary>
        /// Method M_MAIN_0747912471
        /// </summary>
        private void M_MAIN_0747912471(string returnMethod = "")
        {
            M_PARA_0747912471_INIT("M_PARA_0747912471_INIT_EXIT"); if (Control.ExitProgram) { return; }           //COBOL==> PERFORM PARA-0747912471-INIT THRU PARA-0747912471-INIT-EXIT
            M_PARA_0747912471("M_PARA_0747912471_EXIT"); if (Control.ExitProgram) { return; }                     //COBOL==> PERFORM PARA-0747912471 THRU PARA-0747912471-EXIT
            Control.ExitProgram = true; return;                                                                 //COBOL==> GOBACK.
        }
        /// <summary>
        /// Method M_PARA_0747912471
        /// </summary>
        private void M_PARA_0747912471(string returnMethod = "")
        {
            WS.FUNC_0747912471_ESC_FLAG.SetValue("N");                                                          //COBOL==> MOVE 'N' TO FUNC-0747912471-ESC-FLAG .
            LS.TEXT_RETURN_CODE_0004.SetValueWithSpaces();                                                      //COBOL==> MOVE SPACES TO TEXT-RETURN-CODE-0004.
            LS.NUMERIC_RETURN_CODE_0004.SetValue(ZEROES);                                                       //COBOL==> MOVE ZEROES TO NUMERIC-RETURN-CODE-0004.
            LS.FILE_INSTRUCTION_0004.SetValue(LS.FILE_INSTRUCTION_0001);                                        //COBOL==> MOVE FILE-INSTRUCTION-0001 TO FILE-INSTRUCTION-0004.
            if (returnMethod != "" && returnMethod != "M_PARA_0747912471") { M_1000_EAB_CODE_MAIN(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_1000_EAB_CODE_MAIN
        /// </summary>
        private void M_1000_EAB_CODE_MAIN(string returnMethod = "")
        {
            if (LS.FILE_INSTRUCTION_0001.IsEqualTo("OPEN"))                                                     //COBOL==> IF FILE-INSTRUCTION-0001 = 'OPEN'
            {
                M_1100_OPEN_FILE("M_1100_EXIT"); if (Control.ExitProgram) { return; }                                 //COBOL==> PERFORM 1100-OPEN-FILE THRU 1100-EXIT
                M_9999_EXIT(CheckGotoReturn(returnMethod)); return;                                                 //COBOL==> GO TO 9999-EXIT
            }                                                                                                   //COBOL==> END-IF.
            if (LS.FILE_INSTRUCTION_0001.IsEqualTo("READ"))                                                     //COBOL==> IF FILE-INSTRUCTION-0001 = 'READ'
            {
                M_1300_READ_FILE("M_1300_EXIT"); if (Control.ExitProgram) { return; }                                 //COBOL==> PERFORM 1300-READ-FILE THRU 1300-EXIT
                M_9999_EXIT(CheckGotoReturn(returnMethod)); return;                                                 //COBOL==> GO TO 9999-EXIT
            }                                                                                                   //COBOL==> END-IF.
            if (LS.FILE_INSTRUCTION_0001.IsEqualTo("CLOSE"))                                                    //COBOL==> IF FILE-INSTRUCTION-0001 = 'CLOSE'
            {
                M_1400_CLOSE_FILE("M_1400_EXIT"); if (Control.ExitProgram) { return; }                                //COBOL==> PERFORM 1400-CLOSE-FILE THRU 1400-EXIT
                M_9999_EXIT(CheckGotoReturn(returnMethod)); return;                                                 //COBOL==> GO TO 9999-EXIT
            }                                                                                                   //COBOL==> END-IF.
            LS.TEXT_RETURN_CODE_0004.SetValue("FN");                                                            //COBOL==> MOVE 'FN' TO TEXT-RETURN-CODE-0004.
            LS.TEXT_LINE_80_0004.SetValue("BAD FILE INSTRUCTION SENT");                                         //COBOL==> MOVE 'BAD FILE INSTRUCTION SENT' TO TEXT-LINE-80-0004.
            LS.NUMERIC_RETURN_CODE_0004.SetValue(1);                                                            //COBOL==> MOVE 1 TO NUMERIC-RETURN-CODE-0004.
            M_9999_EXIT(CheckGotoReturn(returnMethod)); return;                                                 //COBOL==> GO TO 9999-EXIT.
        }
        /// <summary>
        /// Method M_1100_OPEN_FILE
        /// </summary>
        /// <remarks>
        ///COMMENT:     OPEN INPUT FILE
        /// </remarks>
        private void M_1100_OPEN_FILE(string returnMethod = "")
        {
            FD.EXTFILE.OpenFile(FileAccessMode.Read);                                                           //COBOL==> OPEN INPUT EXTFILE.
            if (!(WS.EXTFILE_STAT.IsEqualTo(0)))                                                                //COBOL==> IF EXTFILE-STAT NOT = 0
            {
                LS.TEXT_RETURN_CODE_0004.SetValue("OP");                                                            //COBOL==> MOVE 'OP' TO TEXT-RETURN-CODE-0004
                LS.TEXT_LINE_80_0004.SetValue("AN ERROR OCCURRED ON OPEN ");                                        //COBOL==> MOVE 'AN ERROR OCCURRED ON OPEN ' TO TEXT-LINE-80-0004
                LS.NUMERIC_RETURN_CODE_0004.SetValue(WS.EXTFILE_STAT);                                              //COBOL==> MOVE EXTFILE-STAT TO NUMERIC-RETURN-CODE-0004
            }                                                                                                   //COBOL==> END-IF.
            if (returnMethod != "" && returnMethod != "M_1100_OPEN_FILE") { M_1100_EXIT(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_1100_EXIT
        /// </summary>
        private void M_1100_EXIT(string returnMethod = "")
        {
            if (returnMethod == "M_1100_EXIT") { return; }                                                      //COBOL==> EXIT.
            if (returnMethod != "" && returnMethod != "M_1100_EXIT") { M_1300_READ_FILE(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_1300_READ_FILE
        /// </summary>
        /// <remarks>
        ///COMMENT:     READ THE INPUT FPLS RESPONSE FILE
        /// </remarks>
        private void M_1300_READ_FILE(string returnMethod = "")
        {
            WS.WS_EXTERNAL_FPLS_REQUEST.SetValue(FD.EXTFILE.ReadLineInto());                                    //COBOL==> READ EXTFILE INTO WS-EXTERNAL-FPLS-REQUEST.
            if (WS.EXTFILE_STAT.IsEqualTo("10"))                                                                //COBOL==> IF EXTFILE-STAT = '10'
            {
                LS.TEXT_LINE_80_0004.SetValue("REACHED END OF FPLS RESPONSE FILE");                                 //COBOL==> MOVE 'REACHED END OF FPLS RESPONSE FILE' TO TEXT-LINE-80-0004
                LS.TEXT_RETURN_CODE_0004.SetValue("EF");                                                            //COBOL==> MOVE 'EF' TO TEXT-RETURN-CODE-0004
                LS.NUMERIC_RETURN_CODE_0004.SetValue(WS.EXTFILE_STAT);                                              //COBOL==> MOVE EXTFILE-STAT TO NUMERIC-RETURN-CODE-0004
                M_1400_CLOSE_FILE("M_1400_EXIT"); if (Control.ExitProgram) { return; }                                //COBOL==> PERFORM 1400-CLOSE-FILE THRU 1400-EXIT
                M_1300_EXIT(CheckGotoReturn(returnMethod)); return;                                                 //COBOL==> GO TO 1300-EXIT
            }                                                                                                   //COBOL==> END-IF.
            if (!(WS.EXTFILE_STAT.IsEqualTo("00")))                                                             //COBOL==> IF EXTFILE-STAT NOT = '00'
            {
                LS.TEXT_LINE_80_0004.SetValue("ERROR IN READING RESPONSE FILE");                                    //COBOL==> MOVE 'ERROR IN READING RESPONSE FILE' TO TEXT-LINE-80-0004
                LS.TEXT_RETURN_CODE_0004.SetValue("XX");                                                            //COBOL==> MOVE 'XX' TO TEXT-RETURN-CODE-0004
                LS.NUMERIC_RETURN_CODE_0004.SetValue(WS.EXTFILE_STAT);                                              //COBOL==> MOVE EXTFILE-STAT TO NUMERIC-RETURN-CODE-0004
                M_1400_CLOSE_FILE("M_1400_EXIT"); if (Control.ExitProgram) { return; }                                //COBOL==> PERFORM 1400-CLOSE-FILE THRU 1400-EXIT
                M_1300_EXIT(CheckGotoReturn(returnMethod)); return;                                                 //COBOL==> GO TO 1300-EXIT
            }                                                                                                   //COBOL==> END-IF.
            LS.AP_CSE_PERSON_NUMBER_0002.SetValue(WS.AP_CSE_PERSON_NUMBER);                                     //COBOL==> MOVE AP-CSE-PERSON-NUMBER TO AP-CSE-PERSON-NUMBER-0002.
            LS.FPLS_LOCATE_REQUEST_IDENT_0003.SetValue(WS.FPLS_LOCATE_REQUEST_IDENT);                           //COBOL==> MOVE FPLS-LOCATE-REQUEST-IDENT TO FPLS-LOCATE-REQUEST-IDENT-0003.
            LS.TRANSACTION_ERROR_0003.SetValue(WS.TRANSACTION_ERROR);                                           //COBOL==> MOVE TRANSACTION-ERROR TO TRANSACTION-ERROR-0003.
            WS.WS_RECORD_COUNT.Add(1);                                                                          //COBOL==> ADD 1 TO WS-RECORD-COUNT.
            if (returnMethod != "" && returnMethod != "M_1300_READ_FILE") { M_1300_EXIT(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_1300_EXIT
        /// </summary>
        private void M_1300_EXIT(string returnMethod = "")
        {
            if (returnMethod == "M_1300_EXIT") { return; }                                                      //COBOL==> EXIT.
            if (returnMethod != "" && returnMethod != "M_1300_EXIT") { M_1400_CLOSE_FILE(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_1400_CLOSE_FILE
        /// </summary>
        /// <remarks>
        ///COMMENT:     CLOSE THE OUTPUT FILE
        /// </remarks>
        private void M_1400_CLOSE_FILE(string returnMethod = "")
        {
            FD.EXTFILE.CloseFile();                                                                             //COBOL==> CLOSE EXTFILE.
            if (!(WS.EXTFILE_STAT.IsEqualTo(0)))                                                                //COBOL==> IF EXTFILE-STAT NOT = 0
            {
                LS.TEXT_RETURN_CODE_0004.SetValue("CL");                                                            //COBOL==> MOVE 'CL' TO TEXT-RETURN-CODE-0004
                LS.TEXT_LINE_80_0004.SetValue("ERROR IN CLOSING FILE");                                             //COBOL==> MOVE 'ERROR IN CLOSING FILE' TO TEXT-LINE-80-0004
                LS.NUMERIC_RETURN_CODE_0004.SetValue(WS.EXTFILE_STAT);                                              //COBOL==> MOVE EXTFILE-STAT TO NUMERIC-RETURN-CODE-0004
            }                                                                                                   //COBOL==> END-IF.
            if (returnMethod != "" && returnMethod != "M_1400_CLOSE_FILE") { M_1400_EXIT(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_1400_EXIT
        /// </summary>
        private void M_1400_EXIT(string returnMethod = "")
        {
            if (returnMethod == "M_1400_EXIT") { return; }                                                      //COBOL==> EXIT.
            if (returnMethod != "" && returnMethod != "M_1400_EXIT") { M_9999_EXIT(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_9999_EXIT
        /// </summary>
        /// <remarks>
        ///COMMENT:     PLEASE NOTE THAT THIS IS OF THE USER WRITTEN CODE
        ///COMMENT:     THIS EXIT FUNCTIONS AS AN EXIT/RETURN.
        ///COMMENT:     CONTROL JUST FALLS THRU
        /// </remarks>
        private void M_9999_EXIT(string returnMethod = "")
        {
            if (returnMethod == "M_9999_EXIT") { return; }                                                      //COBOL==> EXIT.
            if (returnMethod != "" && returnMethod != "M_9999_EXIT") { M_PARA_0747912471_EXIT(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_PARA_0747912471_EXIT
        /// </summary>
        private void M_PARA_0747912471_EXIT(string returnMethod = "")
        {
            if (returnMethod == "M_PARA_0747912471_EXIT") { return; }                                           //COBOL==> EXIT.
            if (returnMethod != "" && returnMethod != "M_PARA_0747912471_EXIT") { M_PARA_0747912471_INIT(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_PARA_0747912471_INIT
        /// </summary>
        private void M_PARA_0747912471_INIT(string returnMethod = "")
        {
            LS.EXPORT_0002EV.ResetToInitialValue();                                                             //COBOL==> INITIALIZE EXPORT-0002EV
            LS.EXPORT_0004EV.ResetToInitialValue();                                                             //COBOL==> INITIALIZE EXPORT-0004EV .
            if (returnMethod != "" && returnMethod != "M_PARA_0747912471_INIT") { M_PARA_0747912471_INIT_EXIT(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_PARA_0747912471_INIT_EXIT
        /// </summary>
        private void M_PARA_0747912471_INIT_EXIT(string returnMethod = "")
        {
            if (returnMethod == "M_PARA_0747912471_INIT_EXIT") { return; }                                      //COBOL==> EXIT.
        }
        #endregion
    }
    #endregion
}
