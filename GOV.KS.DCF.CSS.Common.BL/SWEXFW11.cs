#region Comments
/* Conversion Comments
   ************************************************************
   **   MODERN SYSTEMS INC.  COPYRIGHT 2000-2022
   **   DB-SHUTTLE COBOL to C# Conversion
   ************************************************************
   ** INIT   *  INITIAL VERSION   *  2022-03-02 04:48:04 PM
   **        *   FROM COBOL PGM   :  SWEXFW11
   **        *   FROM CANISTER    :  SR.CAECSES.PROD.LIBR.SOURCE.PDS
   ************************************************************ */

/* Original Program Identification Comments
   **************************************************************
                       SOURCE CODE GENERATED BY
                   INFORMATION ENGINEERING FACILITY (TM)
                       TEXAS INSTRUMENTS INC.
                COPYRIGHT (C) TEXAS INSTRUMENTS INC. 1997
       NAME: EAB_FORMAT_DEBT_DETAIL_LINE_2    DATE: 97/05/28
       TARGET OS:   MVS                       TIME: 19:23:38
       TARGET DBMS: DB2                       USER: SWMTRBM
       GENERATION OPTIONS:
       DEBUG TRACE OPTION NOT SELECTED
       DATA MODELING CONSTRAINT ENFORCEMENT NOT SELECTED
       OPTIMIZED IMPORT VIEW INITIALIZATION SELECTED
   **************************************************************
*/
#endregion
#region Using Directives
using MDSY.Framework.Buffer;
using MDSY.Framework.Buffer.BaseClasses;
using MDSY.Framework.Buffer.Common;
using MDSY.Framework.Buffer.Interfaces;
using System;
#endregion

namespace GOV.KS.DCF.CSS.Common.BL
{
    #region Working Storage Class
    internal class SWEXFW11_ws : PredefinedRecordBase
    {
        #region Name constants
        /// <summary>
        /// Name constants.
        /// </summary>
        internal static class Names
        {
            internal const string WorkingStorage = "SWEXFW11_ws_WorkingStorage";
            internal const string TEMP_RECORD = "TEMP_RECORD";
            internal const string SUPPORTED_PERSON_NUMBER = "SUPPORTED_PERSON_NUMBER";
            internal const string SUPPORTED_PERSON_NAME = "SUPPORTED_PERSON_NAME";
            internal const string COURT_ORDER_TYPE = "COURT_ORDER_TYPE";
            internal const string COURT_ORDER_NUMBER = "COURT_ORDER_NUMBER";
            internal const string WORKER_ID = "WORKER_ID";
            internal const string FUNC_0462955886_ESC_FLAG = "FUNC_0462955886_ESC_FLAG";
        }
        #endregion

        #region Direct-access element properties
        public IGroup TEMP_RECORD { get { return GetElementByName<IGroup>(Names.TEMP_RECORD); } }
        public IField SUPPORTED_PERSON_NUMBER { get { return GetElementByName<IField>(Names.SUPPORTED_PERSON_NUMBER); } }
        public IField SUPPORTED_PERSON_NAME { get { return GetElementByName<IField>(Names.SUPPORTED_PERSON_NAME); } }
        public IField COURT_ORDER_TYPE { get { return GetElementByName<IField>(Names.COURT_ORDER_TYPE); } }
        public IField COURT_ORDER_NUMBER { get { return GetElementByName<IField>(Names.COURT_ORDER_NUMBER); } }
        public IField WORKER_ID { get { return GetElementByName<IField>(Names.WORKER_ID); } }
        public IField FUNC_0462955886_ESC_FLAG { get { return GetElementByName<IField>(Names.FUNC_0462955886_ESC_FLAG); } }

        #endregion

        #region Data structure definition
        /// <summary>
        /// Defines the entirety of the WorkingStorage IRecord structure as described by the Ateras.Framework.Buffer API.
        /// </summary>
        /// <param name="recordDef">The IStructureDefinition object to be used in defining the record structure.</param>
        protected override void DefineRecordStructure(IStructureDefinition recordDef)
        {

            recordDef.CreateNewGroup(Names.TEMP_RECORD, (TEMP_RECORD) =>
           {
               TEMP_RECORD.CreateNewField(Names.SUPPORTED_PERSON_NUMBER, FieldType.String, 10);
               TEMP_RECORD.CreateNewFillerField(FieldType.String, 2, SPACES);
               TEMP_RECORD.CreateNewField(Names.SUPPORTED_PERSON_NAME, FieldType.String, 33);
               TEMP_RECORD.CreateNewFillerField(FieldType.String, 1, SPACES);
               TEMP_RECORD.CreateNewField(Names.COURT_ORDER_TYPE, FieldType.String, 1, SPACE);
               TEMP_RECORD.CreateNewFillerField(FieldType.String, 3, SPACES);
               TEMP_RECORD.CreateNewField(Names.COURT_ORDER_NUMBER, FieldType.String, 12, SPACES);
               TEMP_RECORD.CreateNewFillerField(FieldType.String, 4, SPACES);
               TEMP_RECORD.CreateNewField(Names.WORKER_ID, FieldType.String, 8, SPACES);
           });
            recordDef.CreateNewField(Names.FUNC_0462955886_ESC_FLAG, FieldType.String, 1);

        }

        protected override string GetRecordName()
        {
            return Names.WorkingStorage;
        }
        #endregion

    }
    #endregion Working Storage Class

    #region Linkage Section Class
    internal class SWEXFW11_ls : PredefinedRecordBase
    {
        #region Name constants
        /// <summary>
        /// Name constants.
        /// </summary>
        internal static class Names
        {
            internal const string LinkageSection = "SWEXFW11_ls_LinkageSection";
            internal const string IEF_RUNTIME_PARM1 = "IEF_RUNTIME_PARM1";
            internal const string IEF_RUNTIME_PARM2 = "IEF_RUNTIME_PARM2";
            internal const string PSMGR_EAB_DATA = "PSMGR_EAB_DATA";
            internal const string PSMGR_EABPCB_CNT = "PSMGR_EABPCB_CNT";
            internal const string PSMGR_EABPCB_ENTRY = "PSMGR_EABPCB_ENTRY";
            internal const string PSMGR_EABPCB_ADR = "PSMGR_EABPCB_ADR";
            internal const string W_IA = "W_IA";
            internal const string A_0462955889_IA = "A_0462955889_IA";
            internal const string IMPORT_0001EV = "IMPORT_0001EV";
            internal const string CSE_PERSONS_WORK_SET_0001ET = "CSE_PERSONS_WORK_SET_0001ET";
            internal const string NUMBER_0001AS = "NUMBER_0001AS";
            internal const string NUMBER_0001 = "NUMBER_0001";
            internal const string NUMBER_0001XX = "NUMBER_0001XX";
            internal const string FORMATTED_NAME_0001AS = "FORMATTED_NAME_0001AS";
            internal const string FORMATTED_NAME_0001 = "FORMATTED_NAME_0001";
            internal const string FORMATTED_NAME_0001XX = "FORMATTED_NAME_0001XX";
            internal const string IMPORT_0002EV = "IMPORT_0002EV";
            internal const string SERVICE_PROVIDER_0002ET = "SERVICE_PROVIDER_0002ET";
            internal const string USER_ID_0002AS = "USER_ID_0002AS";
            internal const string USER_ID_0002 = "USER_ID_0002";
            internal const string USER_ID_0002XX = "USER_ID_0002XX";
            internal const string IMPORT_0003EV = "IMPORT_0003EV";
            internal const string CASE_0003ET = "CASE_0003ET";
            internal const string NUMBER_0003AS = "NUMBER_0003AS";
            internal const string NUMBER_0003 = "NUMBER_0003";
            internal const string NUMBER_0003XX = "NUMBER_0003XX";
            internal const string IMPORT_0004EV = "IMPORT_0004EV";
            internal const string OBLIGATION_0004ET = "OBLIGATION_0004ET";
            internal const string SYSTEM_GENERATED_IDENTI_0005AS = "SYSTEM_GENERATED_IDENTI_0005AS";
            internal const string SYSTEM_GENERATED_IDENTIFI_0005 = "SYSTEM_GENERATED_IDENTIFI_0005";
            internal const string SYSTEM_GENERATED_IDENTI_0005XX = "SYSTEM_GENERATED_IDENTI_0005XX";
            internal const string ORDER_TYPE_CODE_0005AS = "ORDER_TYPE_CODE_0005AS";
            internal const string ORDER_TYPE_CODE_0005 = "ORDER_TYPE_CODE_0005";
            internal const string ORDER_TYPE_CODE_0005XX = "ORDER_TYPE_CODE_0005XX";
            internal const string IMPORT_0006EV = "IMPORT_0006EV";
            internal const string LEGAL_ACTION_0006ET = "LEGAL_ACTION_0006ET";
            internal const string IDENTIFIER_0006AS = "IDENTIFIER_0006AS";
            internal const string IDENTIFIER_0006 = "IDENTIFIER_0006";
            internal const string IDENTIFIER_0006XX = "IDENTIFIER_0006XX";
            internal const string COURT_CASE_NUMBER_0006AS = "COURT_CASE_NUMBER_0006AS";
            internal const string COURT_CASE_NUMBER_0006 = "COURT_CASE_NUMBER_0006";
            internal const string COURT_CASE_NUMBER_0006XX = "COURT_CASE_NUMBER_0006XX";
            internal const string STANDARD_NUMBER_0006AS = "STANDARD_NUMBER_0006AS";
            internal const string STANDARD_NUMBER_0006 = "STANDARD_NUMBER_0006";
            internal const string STANDARD_NUMBER_0006XX = "STANDARD_NUMBER_0006XX";
            internal const string W_OA = "W_OA";
            internal const string A_0462955890_OA = "A_0462955890_OA";
            internal const string EXPORT_0007EV = "EXPORT_0007EV";
            internal const string LIST_SCREEN_WORK_AREA_0007ET = "LIST_SCREEN_WORK_AREA_0007ET";
            internal const string TEXT_LINE_76_0007AS = "TEXT_LINE_76_0007AS";
            internal const string TEXT_LINE_76_0007 = "TEXT_LINE_76_0007";
            internal const string TEXT_LINE_76_0007XX = "TEXT_LINE_76_0007XX";
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
        public IGroup A_0462955889_IA { get { return GetElementByName<IGroup>(Names.A_0462955889_IA); } }
        public IGroup IMPORT_0001EV { get { return GetElementByName<IGroup>(Names.IMPORT_0001EV); } }
        public IGroup CSE_PERSONS_WORK_SET_0001ET { get { return GetElementByName<IGroup>(Names.CSE_PERSONS_WORK_SET_0001ET); } }
        public IField NUMBER_0001AS { get { return GetElementByName<IField>(Names.NUMBER_0001AS); } }
        public IField NUMBER_0001 { get { return GetElementByName<IField>(Names.NUMBER_0001); } }
        public IField NUMBER_0001XX { get { return GetElementByName<IField>(Names.NUMBER_0001XX); } }
        public IField FORMATTED_NAME_0001AS { get { return GetElementByName<IField>(Names.FORMATTED_NAME_0001AS); } }
        public IField FORMATTED_NAME_0001 { get { return GetElementByName<IField>(Names.FORMATTED_NAME_0001); } }
        public IField FORMATTED_NAME_0001XX { get { return GetElementByName<IField>(Names.FORMATTED_NAME_0001XX); } }
        public IGroup IMPORT_0002EV { get { return GetElementByName<IGroup>(Names.IMPORT_0002EV); } }
        public IGroup SERVICE_PROVIDER_0002ET { get { return GetElementByName<IGroup>(Names.SERVICE_PROVIDER_0002ET); } }
        public IField USER_ID_0002AS { get { return GetElementByName<IField>(Names.USER_ID_0002AS); } }
        public IField USER_ID_0002 { get { return GetElementByName<IField>(Names.USER_ID_0002); } }
        public IField USER_ID_0002XX { get { return GetElementByName<IField>(Names.USER_ID_0002XX); } }
        public IGroup IMPORT_0003EV { get { return GetElementByName<IGroup>(Names.IMPORT_0003EV); } }
        public IGroup CASE_0003ET { get { return GetElementByName<IGroup>(Names.CASE_0003ET); } }
        public IField NUMBER_0003AS { get { return GetElementByName<IField>(Names.NUMBER_0003AS); } }
        public IField NUMBER_0003 { get { return GetElementByName<IField>(Names.NUMBER_0003); } }
        public IField NUMBER_0003XX { get { return GetElementByName<IField>(Names.NUMBER_0003XX); } }
        public IGroup IMPORT_0004EV { get { return GetElementByName<IGroup>(Names.IMPORT_0004EV); } }
        public IGroup OBLIGATION_0004ET { get { return GetElementByName<IGroup>(Names.OBLIGATION_0004ET); } }
        public IField SYSTEM_GENERATED_IDENTI_0005AS { get { return GetElementByName<IField>(Names.SYSTEM_GENERATED_IDENTI_0005AS); } }
        public IField SYSTEM_GENERATED_IDENTIFI_0005 { get { return GetElementByName<IField>(Names.SYSTEM_GENERATED_IDENTIFI_0005); } }
        public IField SYSTEM_GENERATED_IDENTI_0005XX { get { return GetElementByName<IField>(Names.SYSTEM_GENERATED_IDENTI_0005XX); } }
        public IField ORDER_TYPE_CODE_0005AS { get { return GetElementByName<IField>(Names.ORDER_TYPE_CODE_0005AS); } }
        public IField ORDER_TYPE_CODE_0005 { get { return GetElementByName<IField>(Names.ORDER_TYPE_CODE_0005); } }
        public IField ORDER_TYPE_CODE_0005XX { get { return GetElementByName<IField>(Names.ORDER_TYPE_CODE_0005XX); } }
        public IGroup IMPORT_0006EV { get { return GetElementByName<IGroup>(Names.IMPORT_0006EV); } }
        public IGroup LEGAL_ACTION_0006ET { get { return GetElementByName<IGroup>(Names.LEGAL_ACTION_0006ET); } }
        public IField IDENTIFIER_0006AS { get { return GetElementByName<IField>(Names.IDENTIFIER_0006AS); } }
        public IField IDENTIFIER_0006 { get { return GetElementByName<IField>(Names.IDENTIFIER_0006); } }
        public IField IDENTIFIER_0006XX { get { return GetElementByName<IField>(Names.IDENTIFIER_0006XX); } }
        public IField COURT_CASE_NUMBER_0006AS { get { return GetElementByName<IField>(Names.COURT_CASE_NUMBER_0006AS); } }
        public IField COURT_CASE_NUMBER_0006 { get { return GetElementByName<IField>(Names.COURT_CASE_NUMBER_0006); } }
        public IField COURT_CASE_NUMBER_0006XX { get { return GetElementByName<IField>(Names.COURT_CASE_NUMBER_0006XX); } }
        public IField STANDARD_NUMBER_0006AS { get { return GetElementByName<IField>(Names.STANDARD_NUMBER_0006AS); } }
        public IField STANDARD_NUMBER_0006 { get { return GetElementByName<IField>(Names.STANDARD_NUMBER_0006); } }
        public IField STANDARD_NUMBER_0006XX { get { return GetElementByName<IField>(Names.STANDARD_NUMBER_0006XX); } }
        public IGroup W_OA { get { return GetElementByName<IGroup>(Names.W_OA); } }
        public IGroup A_0462955890_OA { get { return GetElementByName<IGroup>(Names.A_0462955890_OA); } }
        public IGroup EXPORT_0007EV { get { return GetElementByName<IGroup>(Names.EXPORT_0007EV); } }
        public IGroup LIST_SCREEN_WORK_AREA_0007ET { get { return GetElementByName<IGroup>(Names.LIST_SCREEN_WORK_AREA_0007ET); } }
        public IField TEXT_LINE_76_0007AS { get { return GetElementByName<IField>(Names.TEXT_LINE_76_0007AS); } }
        public IField TEXT_LINE_76_0007 { get { return GetElementByName<IField>(Names.TEXT_LINE_76_0007); } }
        public IField TEXT_LINE_76_0007XX { get { return GetElementByName<IField>(Names.TEXT_LINE_76_0007XX); } }

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
               W_IA.CreateNewGroup(Names.A_0462955889_IA, (A_0462955889_IA) =>
               {
                   A_0462955889_IA.CreateNewGroup(Names.IMPORT_0001EV, (IMPORT_0001EV) =>
                   {
                       IMPORT_0001EV.CreateNewGroup(Names.CSE_PERSONS_WORK_SET_0001ET, (CSE_PERSONS_WORK_SET_0001ET) =>
                       {
                           CSE_PERSONS_WORK_SET_0001ET.CreateNewField(Names.NUMBER_0001AS, FieldType.String, 1);

                           IField NUMBER_0001_local = CSE_PERSONS_WORK_SET_0001ET.CreateNewField(Names.NUMBER_0001, FieldType.String, 10);
                           CSE_PERSONS_WORK_SET_0001ET.CreateNewFieldRedefine(Names.NUMBER_0001XX, FieldType.String, NUMBER_0001_local, 10);
                           CSE_PERSONS_WORK_SET_0001ET.CreateNewField(Names.FORMATTED_NAME_0001AS, FieldType.String, 1);

                           IField FORMATTED_NAME_0001_local = CSE_PERSONS_WORK_SET_0001ET.CreateNewField(Names.FORMATTED_NAME_0001, FieldType.String, 33);
                           CSE_PERSONS_WORK_SET_0001ET.CreateNewFieldRedefine(Names.FORMATTED_NAME_0001XX, FieldType.String, FORMATTED_NAME_0001_local, 33);
                       });
                   });
                   A_0462955889_IA.CreateNewGroup(Names.IMPORT_0002EV, (IMPORT_0002EV) =>
                   {
                       IMPORT_0002EV.CreateNewGroup(Names.SERVICE_PROVIDER_0002ET, (SERVICE_PROVIDER_0002ET) =>
                       {
                           SERVICE_PROVIDER_0002ET.CreateNewField(Names.USER_ID_0002AS, FieldType.String, 1);

                           IField USER_ID_0002_local = SERVICE_PROVIDER_0002ET.CreateNewField(Names.USER_ID_0002, FieldType.String, 8);
                           SERVICE_PROVIDER_0002ET.CreateNewFieldRedefine(Names.USER_ID_0002XX, FieldType.String, USER_ID_0002_local, 8);
                       });
                   });
                   A_0462955889_IA.CreateNewGroup(Names.IMPORT_0003EV, (IMPORT_0003EV) =>
                   {
                       IMPORT_0003EV.CreateNewGroup(Names.CASE_0003ET, (CASE_0003ET) =>
                       {
                           CASE_0003ET.CreateNewField(Names.NUMBER_0003AS, FieldType.String, 1);

                           IField NUMBER_0003_local = CASE_0003ET.CreateNewField(Names.NUMBER_0003, FieldType.String, 10);
                           CASE_0003ET.CreateNewFieldRedefine(Names.NUMBER_0003XX, FieldType.String, NUMBER_0003_local, 10);
                       });
                   });
                   A_0462955889_IA.CreateNewGroup(Names.IMPORT_0004EV, (IMPORT_0004EV) =>
                   {
                       IMPORT_0004EV.CreateNewGroup(Names.OBLIGATION_0004ET, (OBLIGATION_0004ET) =>
                       {
                           OBLIGATION_0004ET.CreateNewField(Names.SYSTEM_GENERATED_IDENTI_0005AS, FieldType.String, 1);

                           IField SYSTEM_GENERATED_IDENTIFI_0005_local = OBLIGATION_0004ET.CreateNewField(Names.SYSTEM_GENERATED_IDENTIFI_0005, FieldType.SignedNumeric, 3);
                           OBLIGATION_0004ET.CreateNewFieldRedefine(Names.SYSTEM_GENERATED_IDENTI_0005XX, FieldType.String, SYSTEM_GENERATED_IDENTIFI_0005_local, 3);
                           OBLIGATION_0004ET.CreateNewField(Names.ORDER_TYPE_CODE_0005AS, FieldType.String, 1);

                           IField ORDER_TYPE_CODE_0005_local = OBLIGATION_0004ET.CreateNewField(Names.ORDER_TYPE_CODE_0005, FieldType.String, 1);
                           OBLIGATION_0004ET.CreateNewFieldRedefine(Names.ORDER_TYPE_CODE_0005XX, FieldType.String, ORDER_TYPE_CODE_0005_local, 1);
                       });
                   });
                   A_0462955889_IA.CreateNewGroup(Names.IMPORT_0006EV, (IMPORT_0006EV) =>
                   {
                       IMPORT_0006EV.CreateNewGroup(Names.LEGAL_ACTION_0006ET, (LEGAL_ACTION_0006ET) =>
                       {
                           LEGAL_ACTION_0006ET.CreateNewField(Names.IDENTIFIER_0006AS, FieldType.String, 1);

                           IField IDENTIFIER_0006_local = LEGAL_ACTION_0006ET.CreateNewField(Names.IDENTIFIER_0006, FieldType.SignedNumeric, 9);
                           LEGAL_ACTION_0006ET.CreateNewFieldRedefine(Names.IDENTIFIER_0006XX, FieldType.String, IDENTIFIER_0006_local, 9);
                           LEGAL_ACTION_0006ET.CreateNewField(Names.COURT_CASE_NUMBER_0006AS, FieldType.String, 1);

                           IField COURT_CASE_NUMBER_0006_local = LEGAL_ACTION_0006ET.CreateNewField(Names.COURT_CASE_NUMBER_0006, FieldType.String, 17);
                           LEGAL_ACTION_0006ET.CreateNewFieldRedefine(Names.COURT_CASE_NUMBER_0006XX, FieldType.String, COURT_CASE_NUMBER_0006_local, 17);
                           LEGAL_ACTION_0006ET.CreateNewField(Names.STANDARD_NUMBER_0006AS, FieldType.String, 1);

                           IField STANDARD_NUMBER_0006_local = LEGAL_ACTION_0006ET.CreateNewField(Names.STANDARD_NUMBER_0006, FieldType.String, 12);
                           LEGAL_ACTION_0006ET.CreateNewFieldRedefine(Names.STANDARD_NUMBER_0006XX, FieldType.String, STANDARD_NUMBER_0006_local, 12);
                       });
                   });
               });
           });

            recordDef.CreateNewGroup(Names.W_OA, (W_OA) =>
           {
               W_OA.CreateNewGroup(Names.A_0462955890_OA, (A_0462955890_OA) =>
               {
                   A_0462955890_OA.CreateNewGroup(Names.EXPORT_0007EV, (EXPORT_0007EV) =>
                   {
                       EXPORT_0007EV.CreateNewGroup(Names.LIST_SCREEN_WORK_AREA_0007ET, (LIST_SCREEN_WORK_AREA_0007ET) =>
                       {
                           LIST_SCREEN_WORK_AREA_0007ET.CreateNewField(Names.TEXT_LINE_76_0007AS, FieldType.String, 1);

                           IField TEXT_LINE_76_0007_local = LIST_SCREEN_WORK_AREA_0007ET.CreateNewField(Names.TEXT_LINE_76_0007, FieldType.String, 76);
                           LIST_SCREEN_WORK_AREA_0007ET.CreateNewFieldRedefine(Names.TEXT_LINE_76_0007XX, FieldType.String, TEXT_LINE_76_0007_local, 76);
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
            SetPassedParm(W_IA, args, 0);
            SetPassedParm(W_OA, args, 1);
            SetPassedParm(PSMGR_EAB_DATA, args, 2);
        }


        public void UpdateReturnParameters(object[] args)
        {
            SetReturnParm(W_IA, args, 0);
            SetReturnParm(W_OA, args, 1);
            SetReturnParm(PSMGR_EAB_DATA, args, 2);
        }
    }
    #endregion Linkage Section Class

    #region Business Logic Class
    public class SWEXFW11 : EABBase
    {

        #region Public Constructors
        public SWEXFW11()
            : base()
        {
            this.ProgramName.SetValue("SWEXFW11");

            WS = new SWEXFW11_ws();
            LS = new SWEXFW11_ls();
        }

        #endregion

        #region Private Fields


        //==== Working Storage Data Class ========================================
        private SWEXFW11_ws WS;

        //==== Linkage Section Data Class ========================================
        private SWEXFW11_ls LS;
        #endregion

        #region Public Methods
        //========================================================================
        //==== RunMain Entry Point Method ========================================
        //========================================================================
        public override int ExecuteMain(params object[] args)                                              //COBOL==> PROCEDURE DIVISION USING W-IA , W-OA , PSMGR-EAB-DATA.
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
            M_MAIN_0462955886(returnMethod);
        }
        /// <summary>
        /// Method M_MAIN_0462955886
        /// </summary>
        private void M_MAIN_0462955886(string returnMethod = "")
        {
            M_PARA_0462955886_INIT("M_PARA_0462955886_INIT_EXIT"); if (Control.ExitProgram) { return; }           //COBOL==> PERFORM PARA-0462955886-INIT THRU PARA-0462955886-INIT-EXIT
            M_PARA_0462955886("M_PARA_0462955886_EXIT"); if (Control.ExitProgram) { return; }                     //COBOL==> PERFORM PARA-0462955886 THRU PARA-0462955886-EXIT
            Control.ExitProgram = true; return;                                                                 //COBOL==> GOBACK.
        }
        /// <summary>
        /// Method M_PARA_0462955886
        /// </summary>
        private void M_PARA_0462955886(string returnMethod = "")
        {
            WS.FUNC_0462955886_ESC_FLAG.SetValue("N");                                                          //COBOL==> MOVE 'N' TO FUNC-0462955886-ESC-FLAG
                                                                                                                //COMMENT:  * * * * * * * * * * * * * * * * * * * * * *
                                                                                                                //COMMENT:    USER-WRITTEN CODE SHOULD BE INSERTED HERE
                                                                                                                //COMMENT:  * * * * * * * * * * * * * * * * * * * * * *
            M_BEGIN_MAIN_PROCESSING_PARA("M_END_MAIN_PROCESSING_PARA"); if (Control.ExitProgram) { return; }      //COBOL==> PERFORM BEGIN-MAIN-PROCESSING-PARA THRU END-MAIN-PROCESSING-PARA.
            if (returnMethod != "" && returnMethod != "M_PARA_0462955886") { M_PARA_0462955886_EXIT(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_PARA_0462955886_EXIT
        /// </summary>
        private void M_PARA_0462955886_EXIT(string returnMethod = "")
        {
            if (returnMethod == "M_PARA_0462955886_EXIT") { return; }                                           //COBOL==> EXIT.
            if (returnMethod != "" && returnMethod != "M_PARA_0462955886_EXIT") { M_PARA_0462955886_INIT(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_PARA_0462955886_INIT
        /// </summary>
        private void M_PARA_0462955886_INIT(string returnMethod = "")
        {
            LS.EXPORT_0007EV.ResetToInitialValue();                                                             //COBOL==> INITIALIZE EXPORT-0007EV .
            if (returnMethod != "" && returnMethod != "M_PARA_0462955886_INIT") { M_PARA_0462955886_INIT_EXIT(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_PARA_0462955886_INIT_EXIT
        /// </summary>
        private void M_PARA_0462955886_INIT_EXIT(string returnMethod = "")
        {
            if (returnMethod == "M_PARA_0462955886_INIT_EXIT") { return; }                                      //COBOL==> EXIT.
            if (returnMethod != "" && returnMethod != "M_PARA_0462955886_INIT_EXIT") { M_BEGIN_MAIN_PROCESSING_PARA(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_BEGIN_MAIN_PROCESSING_PARA
        /// </summary>
        private void M_BEGIN_MAIN_PROCESSING_PARA(string returnMethod = "")
        {
            WS.TEMP_RECORD.ResetToInitialValue();                                                               //COBOL==> INITIALIZE TEMP-RECORD , TEXT-LINE-76-0007
            LS.TEXT_LINE_76_0007.ResetToInitialValue();
            WS.SUPPORTED_PERSON_NUMBER.SetValue(LS.NUMBER_0001);                                                //COBOL==> MOVE NUMBER-0001 TO SUPPORTED-PERSON-NUMBER
                                                                                                                //COMMENT:      DISPLAY 'EAB2 LINE 001'
            WS.SUPPORTED_PERSON_NAME.SetValue(LS.FORMATTED_NAME_0001);                                          //COBOL==> MOVE FORMATTED-NAME-0001 TO SUPPORTED-PERSON-NAME
                                                                                                                //COMMENT:      DISPLAY 'EAB2 LINE 002'
            WS.COURT_ORDER_TYPE.SetValue(LS.ORDER_TYPE_CODE_0005);                                              //COBOL==> MOVE ORDER-TYPE-CODE-0005 TO COURT-ORDER-TYPE
                                                                                                                //COMMENT:      DISPLAY 'EAB2 LINE 003'
            WS.COURT_ORDER_NUMBER.SetValue(LS.STANDARD_NUMBER_0006);                                            //COBOL==> MOVE STANDARD-NUMBER-0006 TO COURT-ORDER-NUMBER
                                                                                                                //COMMENT:      DISPLAY 'EAB2 LINE 004'
            WS.WORKER_ID.SetValue(LS.USER_ID_0002);                                                             //COBOL==> MOVE USER-ID-0002 TO WORKER-ID
                                                                                                                //COMMENT:      DISPLAY 'EAB2 LINE 005'
                                                                                                                //COMMENT:      DISPLAY '2: ' TEMP-RECORD
            LS.TEXT_LINE_76_0007.SetValue(WS.TEMP_RECORD);                                                      //COBOL==> MOVE TEMP-RECORD TO TEXT-LINE-76-0007.
            if (returnMethod != "" && returnMethod != "M_BEGIN_MAIN_PROCESSING_PARA") { M_END_MAIN_PROCESSING_PARA(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_END_MAIN_PROCESSING_PARA
        /// </summary>
        /// <remarks>
        ///COMMENT:      DISPLAY '2: ' TEXT-LINE-76-0007.
        /// </remarks>
        private void M_END_MAIN_PROCESSING_PARA(string returnMethod = "")
        {
            if (returnMethod == "M_END_MAIN_PROCESSING_PARA") { return; }                                       //COBOL==> EXIT.
        }
        #endregion
    }
    #endregion
}