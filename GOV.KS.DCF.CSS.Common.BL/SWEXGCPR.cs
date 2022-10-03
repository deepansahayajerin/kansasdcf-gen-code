#region Comments
/* Conversion Comments
   ************************************************************
   **   MODERN SYSTEMS INC.  COPYRIGHT 2000-2022
   **   DB-SHUTTLE COBOL to C# Conversion
   ************************************************************
   ** INIT   *  INITIAL VERSION   *  2022-03-02 04:48:19 PM
   **        *   FROM COBOL PGM   :  SWEXGCPR
   **        *   FROM CANISTER    :  SR.CAECSES.PROD.LIBR.SOURCE.PDS
   ************************************************************ */

/* Original Program Identification Comments
   DATE-COMPILED.
   
   *****************************************************************
   REMARKS:THIS PROGRAM READS KSD_SYSTEM_PART TABLE BY CLIENT KEY
           AND RETURNS CLIENT POINTER INFORMATION.
   
       CLIENT POINTER UTILITY.
   
               REQUIRED PARAMETER:
                A. CLIENT KEY: 1) WSI-CLIENT-NUMBER
                               2) WSI-CLIENT-NAME
                               3) WSI-CLIENT-SSN
               RETURN PARAMETER:
                A. WSO-CLIENT POINTER
                B. WSO-ABEND-FIELDS
                C. WSO-RETURN-ERRORS
   
       MODIFICATIONS:
          02/14/2014 GQB GADI BRAMSON INITIAL DEVELOPMENT
   **
   
   ** MAINTENANCE *************************************************
                         CHANGE
      DATE      AUTHOR   CONTROL DESCRIPTION
    ---------- --------- ------- ----------------------------------
    04/08/2016 G.BRAMSON         SYSTEM CODE CHANGES
    02/14/2014 G.BRAMSON CQ35825 NEW SUB-PROGRAM TO RETREIVE
                                 CLIENT POINTER INFO FROM DB2
    08/29/2017 RKM               ADD WITH UR TO QUERIES
   
   ****************************************************************
   
   *****************************************************************
   
*/
#endregion
#region Using Directives
using MDSY.Framework.Buffer;
using MDSY.Framework.Buffer.BaseClasses;
using MDSY.Framework.Buffer.Common;
using MDSY.Framework.Buffer.Interfaces;
using MDSY.Framework.Core;
using System;

/*  usings for referenced objects  */
#endregion

namespace GOV.KS.DCF.CSS.Common.BL
{
    #region Working Storage Class
    internal class SWEXGCPR_ws : PredefinedRecordBase
    {
        #region Name constants
        /// <summary>
        /// Name constants.
        /// </summary>
        internal static class Names
        {
            internal const string WorkingStorage = "SWEXGCPR_ws_WorkingStorage";
            internal const string WS_PARM_AREA = "WS_PARM_AREA";
            internal const string WSI_INPUT_AREA = "WSI_INPUT_AREA";
            internal const string WSI_CLIENT_KEY = "WSI_CLIENT_KEY";
            internal const string WSI_CLIENT_NUMBER = "WSI_CLIENT_NUMBER";
            internal const string WSI_CLIENT_NAME = "WSI_CLIENT_NAME";
            internal const string WSI_CLIENT_SURNAME = "WSI_CLIENT_SURNAME";
            internal const string WSI_CLIENT_GIVEN_NAME = "WSI_CLIENT_GIVEN_NAME";
            internal const string WSI_CLIENT_INITIALS = "WSI_CLIENT_INITIALS";
            internal const string WSI_CLIENT_SSN = "WSI_CLIENT_SSN";
            internal const string WSO_OUTPUT_AREA = "WSO_OUTPUT_AREA";
            internal const string WSO_CLIENT_POINTER = "WSO_CLIENT_POINTER";
            internal const string WSO_CLIENT_NUMBER = "WSO_CLIENT_NUMBER";
            internal const string WSO_VERIFIED_SSN_FLAG = "WSO_VERIFIED_SSN_FLAG";
            internal const string WSO_SYSTEM_PARTICIPATION = "WSO_SYSTEM_PARTICIPATION";
            internal const string WSO_SYSTEM_AE = "WSO_SYSTEM_AE";
            internal const string WSO_SYSTEM_CS = "WSO_SYSTEM_CS";
            internal const string WSO_SYSTEM_KP = "WSO_SYSTEM_KP";
            internal const string WSO_SYSTEM_KC = "WSO_SYSTEM_KC";
            internal const string WSO_SYSTEM_FA = "WSO_SYSTEM_FA";
            internal const string WSO_SYSTEM_KM = "WSO_SYSTEM_KM";
            internal const string WSO_ABEND_FIELDS = "WSO_ABEND_FIELDS";
            internal const string WSO_ABEND_TYPE = "WSO_ABEND_TYPE";
            internal const string WSO_ABEND_ADABAS = "WSO_ABEND_ADABAS";
            internal const string WSO_ADA_FILE_NUMBER = "WSO_ADA_FILE_NUMBER";
            internal const string WSO_ADA_FILE_ACTION = "WSO_ADA_FILE_ACTION";
            internal const string WSO_ADA_RESPONSE_CD = "WSO_ADA_RESPONSE_CD";
            internal const string WSO_ABEND_CICS = "WSO_ABEND_CICS";
            internal const string WSO_CICS_RESOURCE_NM = "WSO_CICS_RESOURCE_NM";
            internal const string WSO_CICS_FUNCTION_CD = "WSO_CICS_FUNCTION_CD";
            internal const string WSO_CICS_RESPONSE_CD = "WSO_CICS_RESPONSE_CD";
            internal const string WSO_RETURN_ERRORS = "WSO_RETURN_ERRORS";
            internal const string WSO_RETURN_PROG = "WSO_RETURN_PROG";
            internal const string WSO_RETURN_MSG = "WSO_RETURN_MSG";
            internal const string WSO_RETURN_VALUE = "WSO_RETURN_VALUE";
            internal const string WSO_RETURN_SQLCODE = "WSO_RETURN_SQLCODE";
            internal const string WS_SYSTEM_CODES = "WS_SYSTEM_CODES";
            internal const string WS_SYSTEM_CODE_AE = "WS_SYSTEM_CODE_AE";
            internal const string WS_SYSTEM_CODE_CS = "WS_SYSTEM_CODE_CS";
            internal const string WS_SYSTEM_CODE_KP = "WS_SYSTEM_CODE_KP";
            internal const string WS_SYSTEM_CODE_KC = "WS_SYSTEM_CODE_KC";
            internal const string WS_SYSTEM_CODE_FA = "WS_SYSTEM_CODE_FA";
            internal const string WS_SYSTEM_CODE_KM = "WS_SYSTEM_CODE_KM";
            internal const string SW_SWITCHES = "SW_SWITCHES";
            internal const string SW_EOF_SW = "SW_EOF_SW";
            internal const string SW_EOF_NOT_FOUND = "SW_EOF_NOT_FOUND";
            internal const string SW_EOF_NO = "SW_EOF_NO";
            internal const string SW_EOF_YES = "SW_EOF_YES";
            internal const string SW_ERR_SW = "SW_ERR_SW";
            internal const string SW_ERR_NO = "SW_ERR_NO";
            internal const string SW_ERR_YES = "SW_ERR_YES";
            internal const string DCLKSD_SYSTEM_PART = "DCLKSD_SYSTEM_PART";
            internal const string SPA_SYSTEM_CODE = "SPA_SYSTEM_CODE";
            internal const string SPA_PARTICIPATION_FLAG = "SPA_PARTICIPATION_FLAG";
            internal const string DCLKSD_CLIENT = "DCLKSD_CLIENT";
            internal const string CLI_VERIFIED_SSN_FLAG = "CLI_VERIFIED_SSN_FLAG";
            internal const string DBK1_KEYS = "DBK1_KEYS";
            internal const string DBK1_CLIENT_NUMBER = "DBK1_CLIENT_NUMBER";
            internal const string DBK1_CLIENT_NAME = "DBK1_CLIENT_NAME";
            internal const string DBK1_SSN = "DBK1_SSN";
        }
        #endregion

        #region Direct-access element properties
        public IGroup WS_PARM_AREA { get { return GetElementByName<IGroup>(Names.WS_PARM_AREA); } }
        public IGroup WSI_INPUT_AREA { get { return GetElementByName<IGroup>(Names.WSI_INPUT_AREA); } }
        public IGroup WSI_CLIENT_KEY { get { return GetElementByName<IGroup>(Names.WSI_CLIENT_KEY); } }
        public IField WSI_CLIENT_NUMBER { get { return GetElementByName<IField>(Names.WSI_CLIENT_NUMBER); } }
        public IGroup WSI_CLIENT_NAME { get { return GetElementByName<IGroup>(Names.WSI_CLIENT_NAME); } }
        public IField WSI_CLIENT_SURNAME { get { return GetElementByName<IField>(Names.WSI_CLIENT_SURNAME); } }
        public IField WSI_CLIENT_GIVEN_NAME { get { return GetElementByName<IField>(Names.WSI_CLIENT_GIVEN_NAME); } }
        public IField WSI_CLIENT_INITIALS { get { return GetElementByName<IField>(Names.WSI_CLIENT_INITIALS); } }
        public IField WSI_CLIENT_SSN { get { return GetElementByName<IField>(Names.WSI_CLIENT_SSN); } }
        public IGroup WSO_OUTPUT_AREA { get { return GetElementByName<IGroup>(Names.WSO_OUTPUT_AREA); } }
        public IGroup WSO_CLIENT_POINTER { get { return GetElementByName<IGroup>(Names.WSO_CLIENT_POINTER); } }
        public IField WSO_CLIENT_NUMBER { get { return GetElementByName<IField>(Names.WSO_CLIENT_NUMBER); } }
        public IField WSO_VERIFIED_SSN_FLAG { get { return GetElementByName<IField>(Names.WSO_VERIFIED_SSN_FLAG); } }
        public IGroup WSO_SYSTEM_PARTICIPATION { get { return GetElementByName<IGroup>(Names.WSO_SYSTEM_PARTICIPATION); } }
        public IField WSO_SYSTEM_AE { get { return GetElementByName<IField>(Names.WSO_SYSTEM_AE); } }
        public IField WSO_SYSTEM_CS { get { return GetElementByName<IField>(Names.WSO_SYSTEM_CS); } }
        public IField WSO_SYSTEM_KP { get { return GetElementByName<IField>(Names.WSO_SYSTEM_KP); } }
        public IField WSO_SYSTEM_KC { get { return GetElementByName<IField>(Names.WSO_SYSTEM_KC); } }
        public IField WSO_SYSTEM_FA { get { return GetElementByName<IField>(Names.WSO_SYSTEM_FA); } }
        public IField WSO_SYSTEM_KM { get { return GetElementByName<IField>(Names.WSO_SYSTEM_KM); } }
        public IGroup WSO_ABEND_FIELDS { get { return GetElementByName<IGroup>(Names.WSO_ABEND_FIELDS); } }
        public IField WSO_ABEND_TYPE { get { return GetElementByName<IField>(Names.WSO_ABEND_TYPE); } }
        public IGroup WSO_ABEND_ADABAS { get { return GetElementByName<IGroup>(Names.WSO_ABEND_ADABAS); } }
        public IField WSO_ADA_FILE_NUMBER { get { return GetElementByName<IField>(Names.WSO_ADA_FILE_NUMBER); } }
        public IField WSO_ADA_FILE_ACTION { get { return GetElementByName<IField>(Names.WSO_ADA_FILE_ACTION); } }
        public IField WSO_ADA_RESPONSE_CD { get { return GetElementByName<IField>(Names.WSO_ADA_RESPONSE_CD); } }
        public IGroup WSO_ABEND_CICS { get { return GetElementByName<IGroup>(Names.WSO_ABEND_CICS); } }
        public IField WSO_CICS_RESOURCE_NM { get { return GetElementByName<IField>(Names.WSO_CICS_RESOURCE_NM); } }
        public IField WSO_CICS_FUNCTION_CD { get { return GetElementByName<IField>(Names.WSO_CICS_FUNCTION_CD); } }
        public IField WSO_CICS_RESPONSE_CD { get { return GetElementByName<IField>(Names.WSO_CICS_RESPONSE_CD); } }
        public IGroup WSO_RETURN_ERRORS { get { return GetElementByName<IGroup>(Names.WSO_RETURN_ERRORS); } }
        public IField WSO_RETURN_PROG { get { return GetElementByName<IField>(Names.WSO_RETURN_PROG); } }
        public IField WSO_RETURN_MSG { get { return GetElementByName<IField>(Names.WSO_RETURN_MSG); } }
        public IGroup WSO_RETURN_VALUE { get { return GetElementByName<IGroup>(Names.WSO_RETURN_VALUE); } }
        public IField WSO_RETURN_SQLCODE { get { return GetElementByName<IField>(Names.WSO_RETURN_SQLCODE); } }
        public IGroup WS_SYSTEM_CODES { get { return GetElementByName<IGroup>(Names.WS_SYSTEM_CODES); } }
        public IField WS_SYSTEM_CODE_AE { get { return GetElementByName<IField>(Names.WS_SYSTEM_CODE_AE); } }
        public IField WS_SYSTEM_CODE_CS { get { return GetElementByName<IField>(Names.WS_SYSTEM_CODE_CS); } }
        public IField WS_SYSTEM_CODE_KP { get { return GetElementByName<IField>(Names.WS_SYSTEM_CODE_KP); } }
        public IField WS_SYSTEM_CODE_KC { get { return GetElementByName<IField>(Names.WS_SYSTEM_CODE_KC); } }
        public IField WS_SYSTEM_CODE_FA { get { return GetElementByName<IField>(Names.WS_SYSTEM_CODE_FA); } }
        public IField WS_SYSTEM_CODE_KM { get { return GetElementByName<IField>(Names.WS_SYSTEM_CODE_KM); } }
        public IGroup SW_SWITCHES { get { return GetElementByName<IGroup>(Names.SW_SWITCHES); } }
        public IField SW_EOF_SW { get { return GetElementByName<IField>(Names.SW_EOF_SW); } }
        public ICheckField SW_EOF_NOT_FOUND { get { return GetElementByName<ICheckField>(Names.SW_EOF_NOT_FOUND); } }
        public ICheckField SW_EOF_NO { get { return GetElementByName<ICheckField>(Names.SW_EOF_NO); } }
        public ICheckField SW_EOF_YES { get { return GetElementByName<ICheckField>(Names.SW_EOF_YES); } }
        public IField SW_ERR_SW { get { return GetElementByName<IField>(Names.SW_ERR_SW); } }
        public ICheckField SW_ERR_NO { get { return GetElementByName<ICheckField>(Names.SW_ERR_NO); } }
        public ICheckField SW_ERR_YES { get { return GetElementByName<ICheckField>(Names.SW_ERR_YES); } }
        public IGroup DCLKSD_SYSTEM_PART { get { return GetElementByName<IGroup>(Names.DCLKSD_SYSTEM_PART); } }
        public IField SPA_SYSTEM_CODE { get { return GetElementByName<IField>(Names.SPA_SYSTEM_CODE); } }
        public IField SPA_PARTICIPATION_FLAG { get { return GetElementByName<IField>(Names.SPA_PARTICIPATION_FLAG); } }
        public IGroup DCLKSD_CLIENT { get { return GetElementByName<IGroup>(Names.DCLKSD_CLIENT); } }
        public IField CLI_VERIFIED_SSN_FLAG { get { return GetElementByName<IField>(Names.CLI_VERIFIED_SSN_FLAG); } }
        public IGroup DBK1_KEYS { get { return GetElementByName<IGroup>(Names.DBK1_KEYS); } }
        public IField DBK1_CLIENT_NUMBER { get { return GetElementByName<IField>(Names.DBK1_CLIENT_NUMBER); } }
        public IField DBK1_CLIENT_NAME { get { return GetElementByName<IField>(Names.DBK1_CLIENT_NAME); } }
        public IField DBK1_SSN { get { return GetElementByName<IField>(Names.DBK1_SSN); } }

        public CPY_SQLCA SQLCA = new CPY_SQLCA(null, true);
        #endregion

        #region Data structure definition
        /// <summary>
        /// Defines the entirety of the WorkingStorage IRecord structure as described by the Ateras.Framework.Buffer API.
        /// </summary>
        /// <param name="recordDef">The IStructureDefinition object to be used in defining the record structure.</param>
        protected override void DefineRecordStructure(IStructureDefinition recordDef)
        {

            recordDef.CreateNewGroup(Names.WS_PARM_AREA, (WS_PARM_AREA) =>
           {
               WS_PARM_AREA.CreateNewGroup(Names.WSI_INPUT_AREA, (WSI_INPUT_AREA) =>
               {
                   WSI_INPUT_AREA.CreateNewGroup(Names.WSI_CLIENT_KEY, (WSI_CLIENT_KEY) =>
                   {
                       WSI_CLIENT_KEY.CreateNewField(Names.WSI_CLIENT_NUMBER, FieldType.String, 10);
                       WSI_CLIENT_KEY.CreateNewGroup(Names.WSI_CLIENT_NAME, (WSI_CLIENT_NAME) =>
                       {
                           WSI_CLIENT_NAME.CreateNewField(Names.WSI_CLIENT_SURNAME, FieldType.String, 17);
                           WSI_CLIENT_NAME.CreateNewField(Names.WSI_CLIENT_GIVEN_NAME, FieldType.String, 12);
                           WSI_CLIENT_NAME.CreateNewField(Names.WSI_CLIENT_INITIALS, FieldType.String, 1);
                       });
                       WSI_CLIENT_KEY.CreateNewField(Names.WSI_CLIENT_SSN, FieldType.UnsignedNumeric, 9);
                   });
               });
               WS_PARM_AREA.CreateNewGroup(Names.WSO_OUTPUT_AREA, (WSO_OUTPUT_AREA) =>
               {
                   WSO_OUTPUT_AREA.CreateNewGroup(Names.WSO_CLIENT_POINTER, (WSO_CLIENT_POINTER) =>
                   {
                       WSO_CLIENT_POINTER.CreateNewField(Names.WSO_CLIENT_NUMBER, FieldType.String, 10);
                       WSO_CLIENT_POINTER.CreateNewField(Names.WSO_VERIFIED_SSN_FLAG, FieldType.String, 1);
                       WSO_CLIENT_POINTER.CreateNewGroup(Names.WSO_SYSTEM_PARTICIPATION, (WSO_SYSTEM_PARTICIPATION) =>
                       {
                           WSO_SYSTEM_PARTICIPATION.CreateNewField(Names.WSO_SYSTEM_AE, FieldType.String, 1);
                           WSO_SYSTEM_PARTICIPATION.CreateNewField(Names.WSO_SYSTEM_CS, FieldType.String, 1);
                           WSO_SYSTEM_PARTICIPATION.CreateNewField(Names.WSO_SYSTEM_KP, FieldType.String, 1);
                           WSO_SYSTEM_PARTICIPATION.CreateNewField(Names.WSO_SYSTEM_KC, FieldType.String, 1);
                           WSO_SYSTEM_PARTICIPATION.CreateNewField(Names.WSO_SYSTEM_FA, FieldType.String, 1);
                           WSO_SYSTEM_PARTICIPATION.CreateNewField(Names.WSO_SYSTEM_KM, FieldType.String, 1);
                           WSO_SYSTEM_PARTICIPATION.CreateNewFillerField(14, FillWith.Hashes);
                       });
                   });
                   WSO_OUTPUT_AREA.CreateNewGroup(Names.WSO_ABEND_FIELDS, (WSO_ABEND_FIELDS) =>
                   {
                       WSO_ABEND_FIELDS.CreateNewField(Names.WSO_ABEND_TYPE, FieldType.String, 1);
                       WSO_ABEND_FIELDS.CreateNewGroup(Names.WSO_ABEND_ADABAS, (WSO_ABEND_ADABAS) =>
                       {
                           WSO_ABEND_ADABAS.CreateNewField(Names.WSO_ADA_FILE_NUMBER, FieldType.UnsignedNumeric, 4);
                           WSO_ABEND_ADABAS.CreateNewField(Names.WSO_ADA_FILE_ACTION, FieldType.String, 3);
                           WSO_ABEND_ADABAS.CreateNewField(Names.WSO_ADA_RESPONSE_CD, FieldType.UnsignedNumeric, 4);
                       });
                       WSO_ABEND_FIELDS.CreateNewGroup(Names.WSO_ABEND_CICS, (WSO_ABEND_CICS) =>
                       {
                           WSO_ABEND_CICS.CreateNewField(Names.WSO_CICS_RESOURCE_NM, FieldType.String, 8);
                           WSO_ABEND_CICS.CreateNewField(Names.WSO_CICS_FUNCTION_CD, FieldType.String, 2);
                           WSO_ABEND_CICS.CreateNewField(Names.WSO_CICS_RESPONSE_CD, FieldType.String, 6);
                       });
                   });
                   WSO_OUTPUT_AREA.CreateNewGroup(Names.WSO_RETURN_ERRORS, (WSO_RETURN_ERRORS) =>
                   {
                       WSO_RETURN_ERRORS.CreateNewField(Names.WSO_RETURN_PROG, FieldType.String, 10);
                       WSO_RETURN_ERRORS.CreateNewField(Names.WSO_RETURN_MSG, FieldType.String, 60);
                       WSO_RETURN_ERRORS.CreateNewGroup(Names.WSO_RETURN_VALUE, (WSO_RETURN_VALUE) =>
                       {
                           WSO_RETURN_VALUE.CreateNewField(Names.WSO_RETURN_SQLCODE, FieldType.SignedNumeric, 9);
                       });
                   });
               });
           });

            recordDef.CreateNewGroup(Names.WS_SYSTEM_CODES, (WS_SYSTEM_CODES) =>
           {
               WS_SYSTEM_CODES.CreateNewField(Names.WS_SYSTEM_CODE_AE, FieldType.String, 2, "AE");
               WS_SYSTEM_CODES.CreateNewField(Names.WS_SYSTEM_CODE_CS, FieldType.String, 2, "CS");
               WS_SYSTEM_CODES.CreateNewField(Names.WS_SYSTEM_CODE_KP, FieldType.String, 2, "KP");
               WS_SYSTEM_CODES.CreateNewField(Names.WS_SYSTEM_CODE_KC, FieldType.String, 2, "KC");
               WS_SYSTEM_CODES.CreateNewField(Names.WS_SYSTEM_CODE_FA, FieldType.String, 2, "FA");
               WS_SYSTEM_CODES.CreateNewField(Names.WS_SYSTEM_CODE_KM, FieldType.String, 2, "KM");
           });

            recordDef.CreateNewGroup(Names.SW_SWITCHES, (SW_SWITCHES) =>
           {
               SW_SWITCHES.CreateNewField(Names.SW_EOF_SW, FieldType.String, 1)
                   .NewCheckField(Names.SW_EOF_NOT_FOUND, SPACE)
                   .NewCheckField(Names.SW_EOF_NO, "N")
                   .NewCheckField(Names.SW_EOF_YES, "Y")
                   ;
               SW_SWITCHES.CreateNewField(Names.SW_ERR_SW, FieldType.String, 1)
                   .NewCheckField(Names.SW_ERR_NO, "N")
                   .NewCheckField(Names.SW_ERR_YES, "Y")
                   ;
           });

            recordDef.CreateNewGroup(Names.DCLKSD_SYSTEM_PART, (DCLKSD_SYSTEM_PART) =>
           {
               DCLKSD_SYSTEM_PART.CreateNewField(Names.SPA_SYSTEM_CODE, FieldType.String, 2);
               DCLKSD_SYSTEM_PART.CreateNewField(Names.SPA_PARTICIPATION_FLAG, FieldType.String, 1);
           });

            recordDef.CreateNewGroup(Names.DCLKSD_CLIENT, (DCLKSD_CLIENT) =>
           {
               DCLKSD_CLIENT.CreateNewField(Names.CLI_VERIFIED_SSN_FLAG, FieldType.String, 1);
           });

            recordDef.CreateNewGroup(Names.DBK1_KEYS, (DBK1_KEYS) =>
           {
               DBK1_KEYS.CreateNewField(Names.DBK1_CLIENT_NUMBER, FieldType.String, 10);
               DBK1_KEYS.CreateNewField(Names.DBK1_CLIENT_NAME, FieldType.String, 30);
               DBK1_KEYS.CreateNewField(Names.DBK1_SSN, FieldType.CompInt, 9);
           });


        }

        protected override string GetRecordName()
        {
            return Names.WorkingStorage;
        }
        #endregion

        #region Initialize
        public override void Initialize()
        {
            InitializeWithLowValues();
            SQLCA.InitializeWithLowValues();
        }
        #endregion

    }
    #endregion Working Storage Class

    #region Linkage Section Class
    internal class SWEXGCPR_ls : PredefinedRecordBase
    {
        #region Name constants
        /// <summary>
        /// Name constants.
        /// </summary>
        internal static class Names
        {
            internal const string LinkageSection = "SWEXGCPR_ls_LinkageSection";
            internal const string LS_PARM_AREA = "LS_PARM_AREA";
        }
        #endregion

        #region Direct-access element properties
        public IField LS_PARM_AREA { get { return GetElementByName<IField>(Names.LS_PARM_AREA); } }

        #endregion

        #region Data structure definition
        /// <summary>
        /// Defines the entirety of the LinkageSection IRecord structure as described by the Ateras.Framework.Buffer API.
        /// </summary>
        /// <param name="recordDef">The IStructureDefinition object to be used in defining the record structure.</param>
        protected override void DefineRecordStructure(IStructureDefinition recordDef)
        {
            recordDef.CreateNewField(Names.LS_PARM_AREA, FieldType.String, 187);

        }

        protected override string GetRecordName()
        {
            return Names.LinkageSection;
        }
        #endregion

        public void SetPassedParameters(object[] args)
        {
            SetPassedParm(LS_PARM_AREA, args, 0);
        }


        public void UpdateReturnParameters(object[] args)
        {
            SetReturnParm(LS_PARM_AREA, args, 0);
        }
    }
    #endregion Linkage Section Class

    #region Business Logic Class
    public class SWEXGCPR : EABBase
    {

        #region Public Constructors
        public SWEXGCPR()
            : base()
        {
            this.ProgramName.SetValue("SWEXGCPR");

            WS = new SWEXGCPR_ws();
            LS = new SWEXGCPR_ls();
            DbConv.SQLCA.Record = WS.SQLCA.Record;

            DbConv.SetQueryTextWithUR("SPA-VIEW", "SELECT SYSTEM_CODE, PARTICIPATION_FLAG FROM KSD_SYSTEM_PART WHERE FK_CLB_CLIENT_NO = {0}  AND FK_CLI_CLIENT_NAME = {1}  AND FK_CLI_SSN = {2} ",  //COBOL==>EXEC SQL DECLARE SPA-VIEW CURSOR FOR SELECT SYSTEM_CODE , PARTICIPATION_FLAG FROM KSD_SYSTEM_PART WHERE FK_CLB_CLIENT_NO = :DBK1-CLIENT-NUMBER AND FK_CLI_CLIENT_NAME = :DBK1-CLIENT-NAME AND FK_CLI_SSN = :DBK1-SSN WITH UR END-EXEC
                                WS.DBK1_CLIENT_NUMBER, WS.DBK1_CLIENT_NAME, WS.DBK1_SSN);

        }

        #endregion

        #region Private Fields


        //==== Working Storage Data Class ========================================
        private SWEXGCPR_ws WS;

        //==== Linkage Section Data Class ========================================
        private SWEXGCPR_ls LS;
        #endregion

        #region Public Methods
        //========================================================================
        //==== RunMain Entry Point Method ========================================
        //========================================================================
        public override int ExecuteMain(params object[] args)                                              //COBOL==> PROCEDURE DIVISION USING LS-PARM-AREA.
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
            M_0000_MAINLINE_ROUTINE("M_0000_EXIT");
        }
        /// <summary>
        /// Method M_0000_MAINLINE_ROUTINE //Section
        /// </summary>
        /// <remarks>
        ///COMMENT: -----------------------------------------------------------------
        ///COMMENT: -----------------------------------------------------------------
        /// </remarks>
        private void M_0000_MAINLINE_ROUTINE(string returnMethod = "")
        {
            //COMMENT: -----------------------------------------------------------------
            M_1000_PROCESS_INIT("M_1000_EXIT"); if (Control.ExitProgram) { return; }                              //COBOL==> PERFORM 1000-PROCESS-INIT.
            M_2000_PROCESS_MAIN("M_2000_EXIT"); if (Control.ExitProgram) { return; }                              //COBOL==> PERFORM 2000-PROCESS-MAIN.
            LS.LS_PARM_AREA.SetValue(WS.WS_PARM_AREA);                                                          //COBOL==> MOVE WS-PARM-AREA TO LS-PARM-AREA.
            Control.ExitProgram = true; return;                                                                 //COBOL==> GOBACK.
        }
        /// <summary>
        /// Method M_0000_EXIT
        /// </summary>
        private void M_0000_EXIT(string returnMethod = "")
        {
            if (returnMethod == "M_0000_EXIT") { return; }                                                      //COBOL==> EXIT.
            if (returnMethod != "" && returnMethod != "M_0000_EXIT") { M_0110_DECLARE_SPA_VIEW(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_0110_DECLARE_SPA_VIEW //Section
        /// </summary>
        /// <remarks>
        ///COMMENT: -----------------------------------------------------------------
        /// </remarks>
        private void M_0110_DECLARE_SPA_VIEW(string returnMethod = "")
        {
            //COMMENT: -----------------------------------------------------------------
            // Declare Relocated to Method SetUpProgram!                                                        //COBOL==> EXEC SQL DECLARE SPA-VIEW CURSOR FOR SELECT SYSTEM_CODE , PARTICIPATION_FLAG FROM KSD_SYSTEM_PART WHERE FK_CLB_CLIENT_NO = :DBK1-CLIENT-NUMBER AND FK_CLI_CLIENT_NAME = :DBK1-CLIENT-NAME AND FK_CLI_SSN = :DBK1-SSN WITH UR END-EXEC.
            if (returnMethod != "" && returnMethod != "M_0110_DECLARE_SPA_VIEW") { M_0110_EXIT(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_0110_EXIT
        /// </summary>
        private void M_0110_EXIT(string returnMethod = "")
        {
            if (returnMethod == "M_0110_EXIT") { return; }                                                      //COBOL==> EXIT.
            if (returnMethod != "" && returnMethod != "M_0110_EXIT") { M_1000_PROCESS_INIT(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_1000_PROCESS_INIT //Section
        /// </summary>
        /// <remarks>
        ///COMMENT: -----------------------------------------------------------------
        /// </remarks>
        private void M_1000_PROCESS_INIT(string returnMethod = "")
        {
            //COMMENT: -----------------------------------------------------------------
            WS.WS_PARM_AREA.SetValue(LS.LS_PARM_AREA);                                                          //COBOL==> MOVE LS-PARM-AREA TO WS-PARM-AREA.
            WS.WSO_OUTPUT_AREA.ResetToInitialValue();                                                           //COBOL==> INITIALIZE WSO-OUTPUT-AREA.
            WS.WSO_RETURN_PROG.SetValue("*SWEXGCPR*");                                                          //COBOL==> MOVE '*SWEXGCPR*' TO WSO-RETURN-PROG.
            WS.DBK1_CLIENT_NUMBER.SetValue(WS.WSI_CLIENT_NUMBER);                                               //COBOL==> MOVE WSI-CLIENT-NUMBER TO DBK1-CLIENT-NUMBER WSO-CLIENT-NUMBER.
            WS.WSO_CLIENT_NUMBER.SetValue(WS.WSI_CLIENT_NUMBER);
            WS.DBK1_CLIENT_NAME.SetValue(WS.WSI_CLIENT_NAME);                                                   //COBOL==> MOVE WSI-CLIENT-NAME TO DBK1-CLIENT-NAME.
            WS.DBK1_SSN.SetValue(WS.WSI_CLIENT_SSN);                                                            //COBOL==> MOVE WSI-CLIENT-SSN TO DBK1-SSN.
            WS.SW_EOF_NOT_FOUND.SetValue(true);                                                                 //COBOL==> SET SW-EOF-NOT-FOUND TO TRUE.
            WS.SW_ERR_NO.SetValue(true);                                                                        //COBOL==> SET SW-ERR-NO TO TRUE.
            if (returnMethod != "" && returnMethod != "M_1000_PROCESS_INIT") { M_1000_EXIT(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_1000_EXIT
        /// </summary>
        private void M_1000_EXIT(string returnMethod = "")
        {
            if (returnMethod == "M_1000_EXIT") { return; }                                                      //COBOL==> EXIT.
            if (returnMethod != "" && returnMethod != "M_1000_EXIT") { M_2000_PROCESS_MAIN(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_2000_PROCESS_MAIN //Section
        /// </summary>
        /// <remarks>
        ///COMMENT: -----------------------------------------------------------------
        /// </remarks>
        private void M_2000_PROCESS_MAIN(string returnMethod = "")
        {
            //COMMENT: -----------------------------------------------------------------
            M_2100_SELECT_CLIENT("M_2100_EXIT"); if (Control.ExitProgram) { return; }                             //COBOL==> PERFORM 2100-SELECT-CLIENT.
            if (WS.SW_ERR_YES.Value)                                                                            //COBOL==> IF SW-ERR-YES
            {
                M_2000_EXIT(CheckGotoReturn(returnMethod)); return;                                                 //COBOL==> GO TO 2000-EXIT
            }                                                                                                   //COBOL==> END-IF.
            M_2300_OPEN_SPA_VIEW("M_2300_EXIT"); if (Control.ExitProgram) { return; }                             //COBOL==> PERFORM 2300-OPEN-SPA-VIEW.
            if (WS.SW_ERR_YES.Value)                                                                            //COBOL==> IF SW-ERR-YES
            {
                M_2000_EXIT(CheckGotoReturn(returnMethod)); return;                                                 //COBOL==> GO TO 2000-EXIT
            }                                                                                                   //COBOL==> END-IF.
            while (!((WS.SW_EOF_YES.Value) || (WS.SW_ERR_YES.Value)))                                           //COBOL==> PERFORM 2400-FETCH-SPA-VIEW UNTIL SW-EOF-YES OR SW-ERR-YES.
            {
                M_2400_FETCH_SPA_VIEW("M_2400_EXIT"); if (Control.ExitProgram) { return; }
            }
            M_2900_CLOSE_SPA_VIEW("M_2900_EXIT"); if (Control.ExitProgram) { return; }                            //COBOL==> PERFORM 2900-CLOSE-SPA-VIEW.
            if (returnMethod != "" && returnMethod != "M_2000_PROCESS_MAIN") { M_2000_EXIT(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_2000_EXIT
        /// </summary>
        private void M_2000_EXIT(string returnMethod = "")
        {
            if (returnMethod == "M_2000_EXIT") { return; }                                                      //COBOL==> EXIT.
            if (returnMethod != "" && returnMethod != "M_2000_EXIT") { M_2100_SELECT_CLIENT(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_2100_SELECT_CLIENT //Section
        /// </summary>
        /// <remarks>
        ///COMMENT: -----------------------------------------------------------------
        /// </remarks>
        private void M_2100_SELECT_CLIENT(string returnMethod = "")
        {
            //COMMENT: -----------------------------------------------------------------
            DbConv.ExecuteSqlQueryWithUR("SELECT VERIFIED_SSN_FLAG INTO {0} FROM KSD_CLIENT WHERE FK_CLB_CLIENT_NO = {1} AND CLIENT_NAME = {2} AND SSN = {3} ",  //COBOL==> EXEC SQL SELECT VERIFIED_SSN_FLAG INTO :CLI-VERIFIED-SSN-FLAG FROM KSD_CLIENT WHERE FK_CLB_CLIENT_NO = :DBK1-CLIENT-NUMBER AND CLIENT_NAME = :DBK1-CLIENT-NAME AND SSN = :DBK1-SSN WITH UR END-EXEC.
                                 WS.CLI_VERIFIED_SSN_FLAG, WS.DBK1_CLIENT_NUMBER, WS.DBK1_CLIENT_NAME, WS.DBK1_SSN);
            // EvaluateList !DbConv.SQLCA.SQLCODE!                                                              //COBOL==> EVALUATE SQLCODE
            if ((DbConv.SQLCA.SQLCODE.IsZeroes()))                                                              //COBOL==> WHEN ZERO
            {
                WS.WSO_VERIFIED_SSN_FLAG.SetValue(WS.CLI_VERIFIED_SSN_FLAG);                                        //COBOL==> MOVE CLI-VERIFIED-SSN-FLAG TO WSO-VERIFIED-SSN-FLAG
            }                                                                                                //COBOL==> WHEN 100
            else
            if ((DbConv.SQLCA.SQLCODE.IsEqualTo(100)))
            {
                WS.WSO_ABEND_TYPE.SetValue("A");                                                                    //COBOL==> MOVE 'A' TO WSO-ABEND-TYPE
                WS.WSO_ADA_FILE_NUMBER.SetValue(149);                                                               //COBOL==> MOVE 149 TO WSO-ADA-FILE-NUMBER
                WS.WSO_ADA_FILE_ACTION.SetValue(" NF");                                                             //COBOL==> MOVE ' NF' TO WSO-ADA-FILE-ACTION
                WS.WSO_ADA_RESPONSE_CD.SetValueWithZeroes();                                                        //COBOL==> MOVE ZERO TO WSO-ADA-RESPONSE-CD
                                                                                                                    //COMMENT: ** GQB DISPLAY SQL ERROR MESSAGE ***
                WS.WSO_RETURN_MSG.SetValue("2100-SELECT-CLIENT CLNT NOT FOUND         SQLCODE=");                   //COBOL==> MOVE '2100-SELECT-CLIENT CLNT NOT FOUND         SQLCODE=' TO WSO-RETURN-MSG
                WS.WSO_RETURN_SQLCODE.SetValue(DbConv.SQLCA.SQLCODE);                                               //COBOL==> MOVE SQLCODE TO WSO-RETURN-SQLCODE
                WS.SW_ERR_YES.SetValue(true);                                                                       //COBOL==> SET SW-ERR-YES TO TRUE
            }                                                                                                //COBOL==> WHEN OTHER
            else
            {
                WS.WSO_ABEND_TYPE.SetValue("A");                                                                    //COBOL==> MOVE 'A' TO WSO-ABEND-TYPE
                WS.WSO_ADA_FILE_NUMBER.SetValue(149);                                                               //COBOL==> MOVE 149 TO WSO-ADA-FILE-NUMBER
                WS.WSO_ADA_FILE_ACTION.SetValue("RLF");                                                             //COBOL==> MOVE 'RLF' TO WSO-ADA-FILE-ACTION
                WS.WSO_ADA_RESPONSE_CD.SetValue(DbConv.SQLCA.SQLCODE);                                              //COBOL==> MOVE SQLCODE TO WSO-ADA-RESPONSE-CD
                                                                                                                    //COMMENT: ** GQB DISPLAY SQL ERROR MESSAGE ***
                WS.WSO_RETURN_MSG.SetValue("2100-SELECT-CLIENT FAILED.                SQLCODE=");                   //COBOL==> MOVE '2100-SELECT-CLIENT FAILED.                SQLCODE=' TO WSO-RETURN-MSG
                WS.WSO_RETURN_SQLCODE.SetValue(DbConv.SQLCA.SQLCODE);                                               //COBOL==> MOVE SQLCODE TO WSO-RETURN-SQLCODE
                WS.SW_ERR_YES.SetValue(true);                                                                       //COBOL==> SET SW-ERR-YES TO TRUE
            }                                                                                                   //COBOL==> END-EVALUATE.
            if (returnMethod != "" && returnMethod != "M_2100_SELECT_CLIENT") { M_2100_EXIT(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_2100_EXIT
        /// </summary>
        private void M_2100_EXIT(string returnMethod = "")
        {
            if (returnMethod == "M_2100_EXIT") { return; }                                                      //COBOL==> EXIT.
            if (returnMethod != "" && returnMethod != "M_2100_EXIT") { M_2300_OPEN_SPA_VIEW(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_2300_OPEN_SPA_VIEW //Section
        /// </summary>
        /// <remarks>
        ///COMMENT: -----------------------------------------------------------------
        /// </remarks>
        private void M_2300_OPEN_SPA_VIEW(string returnMethod = "")
        {
            //COMMENT: -----------------------------------------------------------------
            DbConv.OpenReader("SPA-VIEW");                                                                      //COBOL==> EXEC SQL OPEN SPA-VIEW END-EXEC.
                                                                                                                // EvaluateList !DbConv.SQLCA.SQLCODE!                                                              //COBOL==> EVALUATE SQLCODE
            if ((DbConv.SQLCA.SQLCODE.IsZeroes()))                                                              //COBOL==> WHEN ZERO
            {
                //Continue                                                                                          //COBOL==> CONTINUE
            }                                                                                                //COBOL==> WHEN OTHER
            else
            {
                WS.WSO_ABEND_TYPE.SetValue("A");                                                                    //COBOL==> MOVE 'A' TO WSO-ABEND-TYPE
                WS.WSO_ADA_FILE_NUMBER.SetValue(149);                                                               //COBOL==> MOVE 149 TO WSO-ADA-FILE-NUMBER
                WS.WSO_ADA_FILE_ACTION.SetValue("RLF");                                                             //COBOL==> MOVE 'RLF' TO WSO-ADA-FILE-ACTION
                WS.WSO_ADA_RESPONSE_CD.SetValue(DbConv.SQLCA.SQLCODE);                                              //COBOL==> MOVE SQLCODE TO WSO-ADA-RESPONSE-CD
                                                                                                                    //COMMENT: ** GQB DISPLAY SQL ERROR MESSAGE ***
                WS.WSO_RETURN_MSG.SetValue("2300-OPEN-SPA-VIEW FAILED.                SQLCODE=");                   //COBOL==> MOVE '2300-OPEN-SPA-VIEW FAILED.                SQLCODE=' TO WSO-RETURN-MSG
                WS.WSO_RETURN_SQLCODE.SetValue(DbConv.SQLCA.SQLCODE);                                               //COBOL==> MOVE SQLCODE TO WSO-RETURN-SQLCODE
                WS.SW_ERR_YES.SetValue(true);                                                                       //COBOL==> SET SW-ERR-YES TO TRUE
            }                                                                                                   //COBOL==> END-EVALUATE.
            if (returnMethod != "" && returnMethod != "M_2300_OPEN_SPA_VIEW") { M_2300_EXIT(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_2300_EXIT
        /// </summary>
        private void M_2300_EXIT(string returnMethod = "")
        {
            if (returnMethod == "M_2300_EXIT") { return; }                                                      //COBOL==> EXIT.
            if (returnMethod != "" && returnMethod != "M_2300_EXIT") { M_2400_FETCH_SPA_VIEW(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_2400_FETCH_SPA_VIEW //Section
        /// </summary>
        /// <remarks>
        ///COMMENT: -----------------------------------------------------------------
        /// </remarks>
        private void M_2400_FETCH_SPA_VIEW(string returnMethod = "")
        {
            //COMMENT: -----------------------------------------------------------------
            DbConv.FetchReaderRow("SPA-VIEW",                                                                //COBOL==> EXEC SQL FETCH SPA-VIEW INTO :SPA-SYSTEM-CODE , :SPA-PARTICIPATION-FLAG END-EXEC.
                             WS.SPA_SYSTEM_CODE, WS.SPA_PARTICIPATION_FLAG);
            // EvaluateList !DbConv.SQLCA.SQLCODE!                                                              //COBOL==> EVALUATE SQLCODE
            if ((DbConv.SQLCA.SQLCODE.IsZeroes()))                                                              //COBOL==> WHEN ZERO
            {
                WS.SW_EOF_NO.SetValue(true);                                                                        //COBOL==> SET SW-EOF-NO TO TRUE
                M_2410_POPULATE_SYSTEM_CODE("M_2410_EXIT"); if (Control.ExitProgram) { return; }                      //COBOL==> PERFORM 2410-POPULATE-SYSTEM-CODE
            }                                                                                                //COBOL==> WHEN 100
            else
            if ((DbConv.SQLCA.SQLCODE.IsEqualTo(100)))
            {
                WS.SW_EOF_YES.SetValue(true);                                                                       //COBOL==> SET SW-EOF-YES TO TRUE
            }                                                                                                //COBOL==> WHEN OTHER
            else
            {
                WS.WSO_ABEND_TYPE.SetValue("A");                                                                    //COBOL==> MOVE 'A' TO WSO-ABEND-TYPE
                WS.WSO_ADA_FILE_NUMBER.SetValue(149);                                                               //COBOL==> MOVE 149 TO WSO-ADA-FILE-NUMBER
                WS.WSO_ADA_FILE_ACTION.SetValue("RLF");                                                             //COBOL==> MOVE 'RLF' TO WSO-ADA-FILE-ACTION
                WS.WSO_ADA_RESPONSE_CD.SetValue(DbConv.SQLCA.SQLCODE);                                              //COBOL==> MOVE SQLCODE TO WSO-ADA-RESPONSE-CD
                                                                                                                    //COMMENT: ** GQB DISPLAY SQL ERROR MESSAGE ***
                WS.WSO_RETURN_MSG.SetValue("2400-FETCH-SPA-VIEW FAILED.               SQLCODE=");                   //COBOL==> MOVE '2400-FETCH-SPA-VIEW FAILED.               SQLCODE=' TO WSO-RETURN-MSG
                WS.WSO_RETURN_SQLCODE.SetValue(DbConv.SQLCA.SQLCODE);                                               //COBOL==> MOVE SQLCODE TO WSO-RETURN-SQLCODE
                WS.SW_ERR_YES.SetValue(true);                                                                       //COBOL==> SET SW-ERR-YES TO TRUE
            }                                                                                                   //COBOL==> END-EVALUATE.
            if (returnMethod != "" && returnMethod != "M_2400_FETCH_SPA_VIEW") { M_2400_EXIT(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_2400_EXIT
        /// </summary>
        private void M_2400_EXIT(string returnMethod = "")
        {
            if (returnMethod == "M_2400_EXIT") { return; }                                                      //COBOL==> EXIT.
            if (returnMethod != "" && returnMethod != "M_2400_EXIT") { M_2410_POPULATE_SYSTEM_CODE(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_2410_POPULATE_SYSTEM_CODE //Section
        /// </summary>
        /// <remarks>
        ///COMMENT: -----------------------------------------------------------------
        /// </remarks>
        private void M_2410_POPULATE_SYSTEM_CODE(string returnMethod = "")
        {
            //COMMENT: -----------------------------------------------------------------
            // EvaluateList !TRUE!                                                                              //COBOL==> EVALUATE TRUE
            if (WS.SPA_SYSTEM_CODE.IsEqualTo(WS.WS_SYSTEM_CODE_AE))                                         //COBOL==> WHEN SPA-SYSTEM-CODE = WS-SYSTEM-CODE-AE
            {
                WS.WSO_SYSTEM_AE.SetValue(WS.SPA_PARTICIPATION_FLAG);                                               //COBOL==> MOVE SPA-PARTICIPATION-FLAG TO WSO-SYSTEM-AE
            }                                                                                               //COBOL==> WHEN SPA-SYSTEM-CODE = WS-SYSTEM-CODE-CS
            else
            if (WS.SPA_SYSTEM_CODE.IsEqualTo(WS.WS_SYSTEM_CODE_CS))
            {
                WS.WSO_SYSTEM_CS.SetValue(WS.SPA_PARTICIPATION_FLAG);                                               //COBOL==> MOVE SPA-PARTICIPATION-FLAG TO WSO-SYSTEM-CS
            }                                                                                               //COBOL==> WHEN SPA-SYSTEM-CODE = WS-SYSTEM-CODE-KP
            else
            if (WS.SPA_SYSTEM_CODE.IsEqualTo(WS.WS_SYSTEM_CODE_KP))
            {
                WS.WSO_SYSTEM_KP.SetValue(WS.SPA_PARTICIPATION_FLAG);                                               //COBOL==> MOVE SPA-PARTICIPATION-FLAG TO WSO-SYSTEM-KP
            }                                                                                               //COBOL==> WHEN SPA-SYSTEM-CODE = WS-SYSTEM-CODE-KC
            else
            if (WS.SPA_SYSTEM_CODE.IsEqualTo(WS.WS_SYSTEM_CODE_KC))
            {
                WS.WSO_SYSTEM_KC.SetValue(WS.SPA_PARTICIPATION_FLAG);                                               //COBOL==> MOVE SPA-PARTICIPATION-FLAG TO WSO-SYSTEM-KC
            }                                                                                               //COBOL==> WHEN SPA-SYSTEM-CODE = WS-SYSTEM-CODE-FA
            else
            if (WS.SPA_SYSTEM_CODE.IsEqualTo(WS.WS_SYSTEM_CODE_FA))
            {
                WS.WSO_SYSTEM_FA.SetValue(WS.SPA_PARTICIPATION_FLAG);                                               //COBOL==> MOVE SPA-PARTICIPATION-FLAG TO WSO-SYSTEM-FA
            }                                                                                               //COBOL==> WHEN SPA-SYSTEM-CODE = WS-SYSTEM-CODE-KM
            else
            if (WS.SPA_SYSTEM_CODE.IsEqualTo(WS.WS_SYSTEM_CODE_KM))
            {
                WS.WSO_SYSTEM_KM.SetValue(WS.SPA_PARTICIPATION_FLAG);                                               //COBOL==> MOVE SPA-PARTICIPATION-FLAG TO WSO-SYSTEM-KM
            }                                                                                               //COBOL==> WHEN OTHER
            else
            {
                //COMMENT: ** GQB DISPLAY SQL ERROR MESSAGE ***
                //COMMENT:         MOVE
                //COMMENT:     '2410-POPULATE FAILED.     SYSTEM-CODE NOT DEFINED='
                //COMMENT:         TO WSO-RETURN-MSG
                //COMMENT:         MOVE SPA-SYSTEM-CODE TO WSO-RETURN-VALUE
                //COMMENT:         SET SW-ERR-YES TO TRUE
                //COMMENT: *       DISPLAY '*SWEXGCPR*SYS CODE ERR = ' SPA-SYSTEM-CODE
                //COMMENT: *       DISPLAY 'FOR CLNT: ' WSI-CLIENT-NUMBER
                //COMMENT: *               ' / ' WSI-CLIENT-NAME
                //COMMENT: *               ' / ' WSI-CLIENT-SSN
                //Continue                                                                                          //COBOL==> CONTINUE
            }                                                                                                   //COBOL==> END-EVALUATE.
            if (returnMethod != "" && returnMethod != "M_2410_POPULATE_SYSTEM_CODE") { M_2410_EXIT(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_2410_EXIT
        /// </summary>
        private void M_2410_EXIT(string returnMethod = "")
        {
            if (returnMethod == "M_2410_EXIT") { return; }                                                      //COBOL==> EXIT.
            if (returnMethod != "" && returnMethod != "M_2410_EXIT") { M_2900_CLOSE_SPA_VIEW(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_2900_CLOSE_SPA_VIEW //Section
        /// </summary>
        /// <remarks>
        ///COMMENT: -----------------------------------------------------------------
        /// </remarks>
        private void M_2900_CLOSE_SPA_VIEW(string returnMethod = "")
        {
            //COMMENT: -----------------------------------------------------------------
            DbConv.CloseReader("SPA-VIEW");                                                                     //COBOL==> EXEC SQL CLOSE SPA-VIEW END-EXEC.
            if (WS.SW_ERR_YES.Value)                                                                            //COBOL==> IF SW-ERR-YES
            {
                M_2900_EXIT(CheckGotoReturn(returnMethod)); return;                                                 //COBOL==> GO TO 2900-EXIT
            }                                                                                                   //COBOL==> END-IF.
                                                                                                                // EvaluateList !DbConv.SQLCA.SQLCODE!                                                              //COBOL==> EVALUATE SQLCODE
            if ((DbConv.SQLCA.SQLCODE.IsZeroes()))                                                              //COBOL==> WHEN ZERO
            {
                //Continue                                                                                          //COBOL==> CONTINUE
            }                                                                                                //COBOL==> WHEN OTHER
            else
            {
                WS.WSO_ABEND_TYPE.SetValue("A");                                                                    //COBOL==> MOVE 'A' TO WSO-ABEND-TYPE
                WS.WSO_ADA_FILE_NUMBER.SetValue(149);                                                               //COBOL==> MOVE 149 TO WSO-ADA-FILE-NUMBER
                WS.WSO_ADA_FILE_ACTION.SetValue("RLF");                                                             //COBOL==> MOVE 'RLF' TO WSO-ADA-FILE-ACTION
                WS.WSO_ADA_RESPONSE_CD.SetValue(DbConv.SQLCA.SQLCODE);                                              //COBOL==> MOVE SQLCODE TO WSO-ADA-RESPONSE-CD
                                                                                                                    //COMMENT: ** GQB DISPLAY SQL ERROR MESSAGE ***
                WS.WSO_RETURN_MSG.SetValue("2900-CLOSE-SPA-VIEW FAILED.               SQLCODE=");                   //COBOL==> MOVE '2900-CLOSE-SPA-VIEW FAILED.               SQLCODE=' TO WSO-RETURN-MSG
                WS.WSO_RETURN_SQLCODE.SetValue(DbConv.SQLCA.SQLCODE);                                               //COBOL==> MOVE SQLCODE TO WSO-RETURN-SQLCODE
                WS.SW_ERR_YES.SetValue(true);                                                                       //COBOL==> SET SW-ERR-YES TO TRUE
            }                                                                                                   //COBOL==> END-EVALUATE.
            if (returnMethod != "" && returnMethod != "M_2900_CLOSE_SPA_VIEW") { M_2900_EXIT(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_2900_EXIT
        /// </summary>
        private void M_2900_EXIT(string returnMethod = "")
        {
            if (returnMethod == "M_2900_EXIT") { return; }                                                      //COBOL==> EXIT.
        }
        #endregion
    }
    #endregion
}
