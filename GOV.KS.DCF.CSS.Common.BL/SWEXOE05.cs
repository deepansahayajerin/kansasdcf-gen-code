#region Comments
/* Conversion Comments
   ************************************************************
   **   MODERN SYSTEMS INC.  COPYRIGHT 2000-2021
   **   DB-SHUTTLE COBOL to C# Conversion
   ************************************************************
   ** INIT   *  INITIAL VERSION   *  2021-12-07 03:23:27 PM
   **        *   FROM COBOL PGM   :  SWEXOE05
   **        *   FROM CANISTER    :  SR.CAECSES.PROD.LIBR.SOURCE.PDS
   ************************************************************ */

/* Original Program Identification Comments
   **************************************************************
    READ AE BENEFITS (GRANTS) FROM SEQUENTIAL EXTRACT FILE
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
#endregion

namespace GOV.KS.DCF.CSS.Common.BL
{
    #region File Section Class
    internal class SWEXOE05_fd : PredefinedRecordBase
    {
        #region Name constants
        /// <summary>
        /// Name constants.
        /// </summary>
        internal static class Names
        {
            internal const string FileSection = "SWEXOE05_fd_FileSection";
            internal const string BENEFITS_FILE = "BENEFITS_FILE";
            internal const string BENEFITS_REC = "BENEFITS_REC";
            internal const string CONTROL_FILE = "CONTROL_FILE";
            internal const string CONTROL_REC = "CONTROL_REC";
        }
        #endregion

        #region Direct-access element properties
        public IFileLink BENEFITS_FILE { get; set; }
        public IField BENEFITS_REC { get { return GetElementByName<IField>(Names.BENEFITS_REC); } }
        public IFileLink CONTROL_FILE { get; set; }
        public IField CONTROL_REC { get { return GetElementByName<IField>(Names.CONTROL_REC); } }

        #endregion

        #region Data structure definition
        /// <summary>
        /// Defines the entirety of the FileSection IRecord structure as described by the Ateras.Framework.Buffer API.
        /// </summary>
        /// <param name="recordDef">The IStructureDefinition object to be used in defining the record structure.</param>
        protected override void DefineRecordStructure(IStructureDefinition recordDef)
        {
            recordDef.CreateNewField(Names.BENEFITS_REC, FieldType.String, 46);
            recordDef.CreateNewField(Names.CONTROL_REC, FieldType.String, 80);

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

            BENEFITS_FILE = FileHandler.GetFile("UT_S_GRANTS");
            BENEFITS_FILE.AssociatedBuffer = BENEFITS_REC;

            CONTROL_FILE = FileHandler.GetFile("UT_S_CONTROL");
            CONTROL_FILE.AssociatedBuffer = CONTROL_REC;
        }
        #endregion

        #region Constructors
        public SWEXOE05_fd()
            : base()
        {
            Initialize();

        }
        #endregion
    }
    #endregion File Section Class
    #region Working Storage Class
    internal class SWEXOE05_ws : PredefinedRecordBase
    {
        #region Name constants
        /// <summary>
        /// Name constants.
        /// </summary>
        internal static class Names
        {
            internal const string WorkingStorage = "SWEXOE05_ws_WorkingStorage";
            internal const string WS_COUNTERS = "WS_COUNTERS";
            internal const string WS_ACTUAL_COUNT = "WS_ACTUAL_COUNT";
            internal const string WS_ACTUAL_AMOUNT = "WS_ACTUAL_AMOUNT";
            internal const string WS_EOF = "WS_EOF";
            internal const string WS_CONTROL_REC = "WS_CONTROL_REC";
            internal const string WSCR_REC_TYPE_TWO = "WSCR_REC_TYPE_TWO";
            internal const string WSCR_RECORD_COUNT = "WSCR_RECORD_COUNT";
            internal const string WSCR_BENEFIT_TOT_AMT = "WSCR_BENEFIT_TOT_AMT";
            internal const string WSCR_FILE_DATE_YYYYMMDD = "WSCR_FILE_DATE_YYYYMMDD";
            internal const string WS_BENEFITS_REC = "WS_BENEFITS_REC";
            internal const string WS_REC_TYPE = "WS_REC_TYPE";
            internal const string WS_CASE_NUMBER = "WS_CASE_NUMBER";
            internal const string WS_PROGRAM_TYPE = "WS_PROGRAM_TYPE";
            internal const string WS_ISSUE_TYPE = "WS_ISSUE_TYPE";
            internal const string WS_BENEFIT_DATE = "WS_BENEFIT_DATE";
            internal const string WS_BENEFIT_YYYY = "WS_BENEFIT_YYYY";
            internal const string WS_BENEFIT_MM = "WS_BENEFIT_MM";
            internal const string WS_BENEFIT_AMOUNT = "WS_BENEFIT_AMOUNT";
            internal const string WS_PERSON_NUMBER = "WS_PERSON_NUMBER";
            internal const string WS_RELATIONSHIP = "WS_RELATIONSHIP";
            internal const string WS_TOTALS_REC = "WS_TOTALS_REC";
            internal const string WS_REC_TYPE_TWO = "WS_REC_TYPE_TWO";
            internal const string WS_RECORD_COUNT = "WS_RECORD_COUNT";
            internal const string WS_BENEFIT_TOT_AMT = "WS_BENEFIT_TOT_AMT";
            internal const string WS_FILE_DATE_YYYYMMDD = "WS_FILE_DATE_YYYYMMDD";
        }
        #endregion

        #region Direct-access element properties
        public IGroup WS_COUNTERS { get { return GetElementByName<IGroup>(Names.WS_COUNTERS); } }
        public IField WS_ACTUAL_COUNT { get { return GetElementByName<IField>(Names.WS_ACTUAL_COUNT); } }
        public IField WS_ACTUAL_AMOUNT { get { return GetElementByName<IField>(Names.WS_ACTUAL_AMOUNT); } }
        public IField WS_EOF { get { return GetElementByName<IField>(Names.WS_EOF); } }
        public IGroup WS_CONTROL_REC { get { return GetElementByName<IGroup>(Names.WS_CONTROL_REC); } }
        public IField WSCR_REC_TYPE_TWO { get { return GetElementByName<IField>(Names.WSCR_REC_TYPE_TWO); } }
        public IField WSCR_RECORD_COUNT { get { return GetElementByName<IField>(Names.WSCR_RECORD_COUNT); } }
        public IField WSCR_BENEFIT_TOT_AMT { get { return GetElementByName<IField>(Names.WSCR_BENEFIT_TOT_AMT); } }
        public IField WSCR_FILE_DATE_YYYYMMDD { get { return GetElementByName<IField>(Names.WSCR_FILE_DATE_YYYYMMDD); } }
        public IGroup WS_BENEFITS_REC { get { return GetElementByName<IGroup>(Names.WS_BENEFITS_REC); } }
        public IField WS_REC_TYPE { get { return GetElementByName<IField>(Names.WS_REC_TYPE); } }
        public IField WS_CASE_NUMBER { get { return GetElementByName<IField>(Names.WS_CASE_NUMBER); } }
        public IField WS_PROGRAM_TYPE { get { return GetElementByName<IField>(Names.WS_PROGRAM_TYPE); } }
        public IField WS_ISSUE_TYPE { get { return GetElementByName<IField>(Names.WS_ISSUE_TYPE); } }
        public IGroup WS_BENEFIT_DATE { get { return GetElementByName<IGroup>(Names.WS_BENEFIT_DATE); } }
        public IField WS_BENEFIT_YYYY { get { return GetElementByName<IField>(Names.WS_BENEFIT_YYYY); } }
        public IField WS_BENEFIT_MM { get { return GetElementByName<IField>(Names.WS_BENEFIT_MM); } }
        public IField WS_BENEFIT_AMOUNT { get { return GetElementByName<IField>(Names.WS_BENEFIT_AMOUNT); } }
        public IField WS_PERSON_NUMBER { get { return GetElementByName<IField>(Names.WS_PERSON_NUMBER); } }
        public IField WS_RELATIONSHIP { get { return GetElementByName<IField>(Names.WS_RELATIONSHIP); } }
        public IGroup WS_TOTALS_REC { get { return GetElementByName<IGroup>(Names.WS_TOTALS_REC); } }
        public IField WS_REC_TYPE_TWO { get { return GetElementByName<IField>(Names.WS_REC_TYPE_TWO); } }
        public IField WS_RECORD_COUNT { get { return GetElementByName<IField>(Names.WS_RECORD_COUNT); } }
        public IField WS_BENEFIT_TOT_AMT { get { return GetElementByName<IField>(Names.WS_BENEFIT_TOT_AMT); } }
        public IField WS_FILE_DATE_YYYYMMDD { get { return GetElementByName<IField>(Names.WS_FILE_DATE_YYYYMMDD); } }

        #endregion

        #region Data structure definition
        /// <summary>
        /// Defines the entirety of the WorkingStorage IRecord structure as described by the Ateras.Framework.Buffer API.
        /// </summary>
        /// <param name="recordDef">The IStructureDefinition object to be used in defining the record structure.</param>
        protected override void DefineRecordStructure(IStructureDefinition recordDef)
        {

            recordDef.CreateNewGroup(Names.WS_COUNTERS, (WS_COUNTERS) =>
           {
               WS_COUNTERS.CreateNewField(Names.WS_ACTUAL_COUNT, FieldType.UnsignedNumeric, 8, 0);
               WS_COUNTERS.CreateNewField(Names.WS_ACTUAL_AMOUNT, FieldType.SignedNumeric, 11, +0, 2);
           });
            recordDef.CreateNewField(Names.WS_EOF, FieldType.String, 1, SPACE);

            recordDef.CreateNewGroup(Names.WS_CONTROL_REC, (WS_CONTROL_REC) =>
           {
               WS_CONTROL_REC.CreateNewField(Names.WSCR_REC_TYPE_TWO, FieldType.String, 1, SPACE);
               WS_CONTROL_REC.CreateNewFillerField(FieldType.String, 1, SPACE);
               WS_CONTROL_REC.CreateNewField(Names.WSCR_RECORD_COUNT, FieldType.UnsignedNumeric, 8, 0);
               WS_CONTROL_REC.CreateNewFillerField(FieldType.String, 1, SPACE);
               WS_CONTROL_REC.CreateNewField(Names.WSCR_BENEFIT_TOT_AMT, FieldType.SignedNumeric, 11, +0, 2);
               WS_CONTROL_REC.CreateNewFillerField(FieldType.String, 1, SPACE);
               WS_CONTROL_REC.CreateNewField(Names.WSCR_FILE_DATE_YYYYMMDD, FieldType.UnsignedNumeric, 8, 0);
               WS_CONTROL_REC.CreateNewFillerField(FieldType.String, 49, SPACES);
           });

            IGroup WS_BENEFITS_REC_local = (IGroup)recordDef.CreateNewGroup(Names.WS_BENEFITS_REC, (WS_BENEFITS_REC) =>
           {
               WS_BENEFITS_REC.CreateNewField(Names.WS_REC_TYPE, FieldType.String, 1, SPACE);
               WS_BENEFITS_REC.CreateNewFillerField(FieldType.String, 1, SPACE);
               WS_BENEFITS_REC.CreateNewField(Names.WS_CASE_NUMBER, FieldType.String, 8, SPACES);
               WS_BENEFITS_REC.CreateNewFillerField(FieldType.String, 1, SPACE);
               WS_BENEFITS_REC.CreateNewField(Names.WS_PROGRAM_TYPE, FieldType.String, 2, SPACES);
               WS_BENEFITS_REC.CreateNewFillerField(FieldType.String, 1, SPACE);
               WS_BENEFITS_REC.CreateNewField(Names.WS_ISSUE_TYPE, FieldType.String, 2, SPACES);
               WS_BENEFITS_REC.CreateNewFillerField(FieldType.String, 1, SPACE);
               WS_BENEFITS_REC.CreateNewGroup(Names.WS_BENEFIT_DATE, (WS_BENEFIT_DATE) =>
               {
                   WS_BENEFIT_DATE.CreateNewField(Names.WS_BENEFIT_YYYY, FieldType.UnsignedNumeric, 4, ZERO);
                   WS_BENEFIT_DATE.CreateNewField(Names.WS_BENEFIT_MM, FieldType.UnsignedNumeric, 2, ZERO);
               });
               WS_BENEFITS_REC.CreateNewFillerField(FieldType.String, 1, SPACE);
               WS_BENEFITS_REC.CreateNewField(Names.WS_BENEFIT_AMOUNT, FieldType.SignedNumeric, 8, +0, 2);
               WS_BENEFITS_REC.CreateNewFillerField(FieldType.String, 1, SPACE);
               WS_BENEFITS_REC.CreateNewField(Names.WS_PERSON_NUMBER, FieldType.String, 10, SPACES);
               WS_BENEFITS_REC.CreateNewFillerField(FieldType.String, 1, SPACE);
               WS_BENEFITS_REC.CreateNewField(Names.WS_RELATIONSHIP, FieldType.String, 2, SPACES);
           });
            recordDef.CreateNewGroupRedefine(Names.WS_TOTALS_REC, WS_BENEFITS_REC_local, (WS_TOTALS_REC) =>
            {
                WS_TOTALS_REC.CreateNewField(Names.WS_REC_TYPE_TWO, FieldType.String, 1);
                WS_TOTALS_REC.CreateNewFillerField(1, FillWith.Hashes);
                WS_TOTALS_REC.CreateNewField(Names.WS_RECORD_COUNT, FieldType.UnsignedNumeric, 8);
                WS_TOTALS_REC.CreateNewFillerField(1, FillWith.Hashes);
                WS_TOTALS_REC.CreateNewField(Names.WS_BENEFIT_TOT_AMT, FieldType.SignedNumeric, 11, null, 2);
                WS_TOTALS_REC.CreateNewFillerField(1, FillWith.Hashes);
                WS_TOTALS_REC.CreateNewField(Names.WS_FILE_DATE_YYYYMMDD, FieldType.UnsignedNumeric, 8);
                WS_TOTALS_REC.CreateNewFillerField(15, FillWith.Hashes);
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
    internal class SWEXOE05_ls : PredefinedRecordBase
    {
        #region Name constants
        /// <summary>
        /// Name constants.
        /// </summary>
        internal static class Names
        {
            internal const string LinkageSection = "SWEXOE05_ls_LinkageSection";
            internal const string IEF_RUNTIME_PARM1 = "IEF_RUNTIME_PARM1";
            internal const string IEF_RUNTIME_PARM2 = "IEF_RUNTIME_PARM2";
            internal const string GLOBDATA = "GLOBDATA";
            internal const string PSMGR_IEF_COMMAND = "PSMGR_IEF_COMMAND";
            internal const string PSMGR_IEF_COMMAND_1 = "PSMGR_IEF_COMMAND_1";
            internal const string PSMGR_IEF_COMMAND_2 = "PSMGR_IEF_COMMAND_2";
            internal const string PSMGR_IEF_TRANCODE = "PSMGR_IEF_TRANCODE";
            internal const string PSMGR_EXIT_STATE = "PSMGR_EXIT_STATE";
            internal const string PSMGR_EXIT_INFOMSG = "PSMGR_EXIT_INFOMSG";
            internal const string PSMGR_USER_ID = "PSMGR_USER_ID";
            internal const string PSMGR_TERMINAL_ID = "PSMGR_TERMINAL_ID";
            internal const string PSMGR_PRINTER_ID = "PSMGR_PRINTER_ID";
            internal const string PSMGR_CURRENT_DATE = "PSMGR_CURRENT_DATE";
            internal const string PSMGR_CURRENT_TIME = "PSMGR_CURRENT_TIME";
            internal const string PSMGR_RUNTIME_TYPE = "PSMGR_RUNTIME_TYPE";
            internal const string PSMGR_FUNCTION_DATA = "PSMGR_FUNCTION_DATA";
            internal const string PSMGR_FUNC_ERRMSG = "PSMGR_FUNC_ERRMSG";
            internal const string PSMGR_FUNC_NAME = "PSMGR_FUNC_NAME";
            internal const string PSMGR_FUNC_IN_DATE = "PSMGR_FUNC_IN_DATE";
            internal const string PSMGR_FUNC_IN_DDURA = "PSMGR_FUNC_IN_DDURA";
            internal const string DDURA_YEAR = "DDURA_YEAR";
            internal const string DDURA_Y_MISS = "DDURA_Y_MISS";
            internal const string DDURA_YYYY = "DDURA_YYYY";
            internal const string DDURA_MONTH = "DDURA_MONTH";
            internal const string DDURA_M_MISS = "DDURA_M_MISS";
            internal const string DDURA_MM = "DDURA_MM";
            internal const string DDURA_DAY = "DDURA_DAY";
            internal const string DDURA_D_MISS = "DDURA_D_MISS";
            internal const string DDURA_DD = "DDURA_DD";
            internal const string PSMGR_FUNC_OUT_DATE = "PSMGR_FUNC_OUT_DATE";
            internal const string PSMGR_FUNC_IN_TIME = "PSMGR_FUNC_IN_TIME";
            internal const string PSMGR_FUNC_IN_TDURA = "PSMGR_FUNC_IN_TDURA";
            internal const string TDURA_HOUR = "TDURA_HOUR";
            internal const string TDURA_H_MISS = "TDURA_H_MISS";
            internal const string TDURA_HH = "TDURA_HH";
            internal const string TDURA_MINUTE = "TDURA_MINUTE";
            internal const string TDURA_M_MISS = "TDURA_M_MISS";
            internal const string TDURA_MM = "TDURA_MM";
            internal const string TDURA_SECOND = "TDURA_SECOND";
            internal const string TDURA_S_MISS = "TDURA_S_MISS";
            internal const string TDURA_SS = "TDURA_SS";
            internal const string PSMGR_FUNC_OUT_TIME = "PSMGR_FUNC_OUT_TIME";
            internal const string PSMGR_IEF_NEXTTRAN = "PSMGR_IEF_NEXTTRAN";
            internal const string PSMGR_EXIT_MSGTYPE = "PSMGR_EXIT_MSGTYPE";
            internal const string PSMGR_IEF_DEBUG_FLAGS = "PSMGR_IEF_DEBUG_FLAGS";
            internal const string PSMGR_IEF_DEBUG = "PSMGR_IEF_DEBUG";
            internal const string PSMGR_DEBUG_ON = "PSMGR_DEBUG_ON";
            internal const string PSMGR_ENVIRONMENT_DATA = "PSMGR_ENVIRONMENT_DATA";
            internal const string PSMGR_PCB_CNT = "PSMGR_PCB_CNT";
            internal const string PSMGR_PCB_ENTRY = "PSMGR_PCB_ENTRY";
            internal const string PSMGR_PCB_ADR = "PSMGR_PCB_ADR";
            internal const string PSMGR_EAB_DATA = "PSMGR_EAB_DATA";
            internal const string PSMGR_EABPCB_CNT = "PSMGR_EABPCB_CNT";
            internal const string PSMGR_EABPCB_ENTRY = "PSMGR_EABPCB_ENTRY";
            internal const string PSMGR_EABPCB_ADR = "PSMGR_EABPCB_ADR";
            internal const string PSMGR_ERROR_DATA = "PSMGR_ERROR_DATA";
            internal const string ERROR_ACTION_NAME = "ERROR_ACTION_NAME";
            internal const string ERROR_ENCOUNTERED_SW = "ERROR_ENCOUNTERED_SW";
            internal const string VIEW_OVERFLOW_SW = "VIEW_OVERFLOW_SW";
            internal const string PSMGR_DASG_DATA = "PSMGR_DASG_DATA";
            internal const string ACTION_ID_X = "ACTION_ID_X";
            internal const string ACTION_ID = "ACTION_ID";
            internal const string ATTRIBUTE_ID_X = "ATTRIBUTE_ID_X";
            internal const string ATTRIBUTE_ID = "ATTRIBUTE_ID";
            internal const string STATUS_FLAG = "STATUS_FLAG";
            internal const string FATAL_ERROR_SF = "FATAL_ERROR_SF";
            internal const string DB_ERROR_SF = "DB_ERROR_SF";
            internal const string ABORT_SHOW_DBMS_MSG_SF = "ABORT_SHOW_DBMS_MSG_SF";
            internal const string ABORT_SHOW_USER_MSG_SF = "ABORT_SHOW_USER_MSG_SF";
            internal const string RETRY_TRAN_REQUESTED_SF = "RETRY_TRAN_REQUESTED_SF";
            internal const string PSTEP_USE_FAILURE = "PSTEP_USE_FAILURE";
            internal const string LAST_STATUS = "LAST_STATUS";
            internal const string DB_ERROR_FL_LS = "DB_ERROR_FL_LS";
            internal const string DB_DEADLOCK_TIMOUT_FL_LS = "DB_DEADLOCK_TIMOUT_FL_LS";
            internal const string DUPLICATE_FOUND_FL_LS = "DUPLICATE_FOUND_FL_LS";
            internal const string INVALID_DATAA_FL_LS = "INVALID_DATAA_FL_LS";
            internal const string INVALID_DATAB_TYPE_FL_LS = "INVALID_DATAB_TYPE_FL_LS";
            internal const string INVALID_DATAB_PERM_FL_LS = "INVALID_DATAB_PERM_FL_LS";
            internal const string FATAL_ERROR_FL_LS = "FATAL_ERROR_FL_LS";
            internal const string NOT_FOUND_FL_LS = "NOT_FOUND_FL_LS";
            internal const string NOT_UNIQUE_FL_LS = "NOT_UNIQUE_FL_LS";
            internal const string IEF_FUNCTION_ERROR_FL_LS = "IEF_FUNCTION_ERROR_FL_LS";
            internal const string IEF_DURATION_ERROR_FL_LS = "IEF_DURATION_ERROR_FL_LS";
            internal const string USED_PSTEP_NOT_FOUND = "USED_PSTEP_NOT_FOUND";
            internal const string USED_PSTEP_ROUTING_ERR = "USED_PSTEP_ROUTING_ERR";
            internal const string USED_PSTEP_SND_FMT_ERR = "USED_PSTEP_SND_FMT_ERR";
            internal const string USED_PSTEP_ENCRYPT_ERR = "USED_PSTEP_ENCRYPT_ERR";
            internal const string USED_PSTEP_SND_BFR_ERR = "USED_PSTEP_SND_BFR_ERR";
            internal const string USED_PSTEP_RCV_BFR_ERR = "USED_PSTEP_RCV_BFR_ERR";
            internal const string USED_PSTEP_RCV_FMT_ERR = "USED_PSTEP_RCV_FMT_ERR";
            internal const string USED_PSTEP_TIRSECR_ERR = "USED_PSTEP_TIRSECR_ERR";
            internal const string USED_PSTEP_TOKEN_ERR = "USED_PSTEP_TOKEN_ERR";
            internal const string USED_PSTEP_SEND_MAX_SIZE = "USED_PSTEP_SEND_MAX_SIZE";
            internal const string USED_PSTEP_SECG_ERR = "USED_PSTEP_SECG_ERR";
            internal const string USED_PSTEP_ALLOC_ERR = "USED_PSTEP_ALLOC_ERR";
            internal const string USED_PSTEP_CONNECT_ERR = "USED_PSTEP_CONNECT_ERR";
            internal const string USED_PSTEP_XERR = "USED_PSTEP_XERR";
            internal const string USED_PSTEP_RCV_UA_ERR = "USED_PSTEP_RCV_UA_ERR";
            internal const string USED_PSTEP_RCV_ES_ERR = "USED_PSTEP_RCV_ES_ERR";
            internal const string USED_PSTEP_XFAL = "USED_PSTEP_XFAL";
            internal const string USED_PSTEP_SETOA_ERR = "USED_PSTEP_SETOA_ERR";
            internal const string USED_PSTEP_RCV_VIEW_ERR = "USED_PSTEP_RCV_VIEW_ERR";
            internal const string USED_PSTEP_DECRYPT_ERR = "USED_PSTEP_DECRYPT_ERR";
            internal const string SAVE_SQLCA = "SAVE_SQLCA";
            internal const string PSMGR_DEBUG_DATA = "PSMGR_DEBUG_DATA";
            internal const string PSMGR_TRACE_ADR = "PSMGR_TRACE_ADR";
            internal const string LAST_STATEMENT_X = "LAST_STATEMENT_X";
            internal const string LAST_STATEMENT_NUM = "LAST_STATEMENT_NUM";
            internal const string CUR_AB_ID = "CUR_AB_ID";
            internal const string CUR_AB_NAME = "CUR_AB_NAME";
            internal const string PSMGR_TIRDATE_SAVEAREA = "PSMGR_TIRDATE_SAVEAREA";
            internal const string PSMGR_TIRDATE_CMCB = "PSMGR_TIRDATE_CMCB";
            internal const string PSMGR_TIRDATE_DATE = "PSMGR_TIRDATE_DATE";
            internal const string PSMGR_TIRDATE_TIME = "PSMGR_TIRDATE_TIME";
            internal const string PSMGR_TIRDATE_INC = "PSMGR_TIRDATE_INC";
            internal const string PSMGR_TIRDATE_RC = "PSMGR_TIRDATE_RC";
            internal const string PSMGR_TIRDATE_OK = "PSMGR_TIRDATE_OK";
            internal const string PSMGR_TIRDATE_WARNING = "PSMGR_TIRDATE_WARNING";
            internal const string PSMGR_TIRDATE_ERROR = "PSMGR_TIRDATE_ERROR";
            internal const string PSMGR_TIRDATE_REQ = "PSMGR_TIRDATE_REQ";
            internal const string PSMGR_TIRDATE_DATEF = "PSMGR_TIRDATE_DATEF";
            internal const string PSMGR_TIRDATE_TIMEF = "PSMGR_TIRDATE_TIMEF";
            internal const string PSMGR_TIRDATE_RETMSG = "PSMGR_TIRDATE_RETMSG";
            internal const string PSMGR_TIRDATE_TSTAMP = "PSMGR_TIRDATE_TSTAMP";
            internal const string PSMGR_TIRDATE_DATE_Z = "PSMGR_TIRDATE_DATE_Z";
            internal const string PSMGR_TIRDATE_TIME_Z = "PSMGR_TIRDATE_TIME_Z";
            internal const string PSMGR_TIRDATE_SKIP_VAL = "PSMGR_TIRDATE_SKIP_VAL";
            internal const string PSMGR_ROLLBACK_RQSTED = "PSMGR_ROLLBACK_RQSTED";
            internal const string ROLLBACK_RQSTED = "ROLLBACK_RQSTED";
            internal const string ABEND_RQSTED = "ABEND_RQSTED";
            internal const string TERMINATE_RQSTED = "TERMINATE_RQSTED";
            internal const string TIRTRCE_SAVE_AREA = "TIRTRCE_SAVE_AREA";
            internal const string TOP_INDX = "TOP_INDX";
            internal const string BOTTOM_INDX = "BOTTOM_INDX";
            internal const string END_INDX = "END_INDX";
            internal const string LAST_STMT = "LAST_STMT";
            internal const string TOP_OF_CALL = "TOP_OF_CALL";
            internal const string TRACE_BREAK_POINT = "TRACE_BREAK_POINT";
            internal const string TRACE_BREAK_POINT_STATUS = "TRACE_BREAK_POINT_STATUS";
            internal const string LAST_AB_NAME = "LAST_AB_NAME";
            internal const string COLOR = "COLOR";
            internal const string COLORT = "COLORT";
            internal const string HILITE = "HILITE";
            internal const string TRACE_ON_OFF = "TRACE_ON_OFF";
            internal const string CASCADE_DELETE_FLAGS = "CASCADE_DELETE_FLAGS";
            internal const string V1PRESENT = "V1PRESENT";
            internal const string V2PRESENT = "V2PRESENT";
            internal const string CASCADE1 = "CASCADE1";
            internal const string CASCADE2 = "CASCADE2";
            internal const string PROCESSQ_FLAG = "PROCESSQ_FLAG";
            internal const string PSMGR_ACTIVE_DIALECT = "PSMGR_ACTIVE_DIALECT";
            internal const string DIALECT_NAME = "DIALECT_NAME";
            internal const string MESSAGE_TABLE_NAME = "MESSAGE_TABLE_NAME";
            internal const string TRANSLATE_TABLE_NAME = "TRANSLATE_TABLE_NAME";
            internal const string PSMGR_FUNCTION_DATA_EXT = "PSMGR_FUNCTION_DATA_EXT";
            internal const string PSMGR_FUNC_IN_TIMESTAMP = "PSMGR_FUNC_IN_TIMESTAMP";
            internal const string PSMGR_FUNC_IN_TSDURA = "PSMGR_FUNC_IN_TSDURA";
            internal const string TSDURA_MICROSECOND = "TSDURA_MICROSECOND";
            internal const string TSDURA_M_MISS = "TSDURA_M_MISS";
            internal const string TSDURA_MS = "TSDURA_MS";
            internal const string PSMGR_FUNC_OUT_TIMESTAMP = "PSMGR_FUNC_OUT_TIMESTAMP";
            internal const string PSMGR_CICS_FAIL_SW = "PSMGR_CICS_FAIL_SW";
            internal const string INHIBIT_CICS_RECEIVE = "INHIBIT_CICS_RECEIVE";
            internal const string CLIENT_USERID = "CLIENT_USERID";
            internal const string CLIENT_PASSWORD = "CLIENT_PASSWORD";
            internal const string LOAD_MODULE_NAME = "LOAD_MODULE_NAME";
            internal const string INSTRUMENT_CODE = "INSTRUMENT_CODE";
            internal const string TX_RETRY_LIMIT = "TX_RETRY_LIMIT";
            internal const string TX_TIMEOUT = "TX_TIMEOUT";
            internal const string PSMGR_EXTRA_ERRINFO = "PSMGR_EXTRA_ERRINFO";
            internal const string ERRINFO_BUF_SIZE = "ERRINFO_BUF_SIZE";
            internal const string ERRINFO_MSG_SIZE = "ERRINFO_MSG_SIZE";
            internal const string ERRINFO_BUF_ADDR = "ERRINFO_BUF_ADDR";
            internal const string TX_RETRY_COUNT = "TX_RETRY_COUNT";
            internal const string TX_USER_RETRY_ALLOWED = "TX_USER_RETRY_ALLOWED";
            internal const string PSMGR_PSTEP_USE_PTRS = "PSMGR_PSTEP_USE_PTRS";
            internal const string PSTEP_FAIL_MSG_PTR = "PSTEP_FAIL_MSG_PTR";
            internal const string PSTEP_GURB_REST_PTR = "PSTEP_GURB_REST_PTR";
            internal const string PSTEP_LIPS_PTR = "PSTEP_LIPS_PTR";
            internal const string PSTEP_TBL_PTR = "PSTEP_TBL_PTR";
            internal const string PSTEP_DDF_PTR = "PSTEP_DDF_PTR";
            internal const string PSTEP_COMM_ID = "PSTEP_COMM_ID";
            internal const string PSTEP_APPL_LIST_PTR = "PSTEP_APPL_LIST_PTR";
            internal const string PSTEP_CURR_PST_PTR = "PSTEP_CURR_PST_PTR";
            internal const string PSMGR_PSTEP_USE_SYSFLDS = "PSMGR_PSTEP_USE_SYSFLDS";
            internal const string PSMGR_EIBERRCD = "PSMGR_EIBERRCD";
            internal const string PSMGR_EIBFN = "PSMGR_EIBFN";
            internal const string PSMGR_EIBRESP = "PSMGR_EIBRESP";
            internal const string PSMGR_EIBRESP2 = "PSMGR_EIBRESP2";
            internal const string IMPORT_0001EV = "IMPORT_0001EV";
            internal const string EAB_FILE_HANDLING_0001ET = "EAB_FILE_HANDLING_0001ET";
            internal const string ACTION_0001AS = "ACTION_0001AS";
            internal const string ACTION_0001 = "ACTION_0001";
            internal const string ACTION_0001XX = "ACTION_0001XX";
            internal const string EXPORT_0002EV = "EXPORT_0002EV";
            internal const string CSE_PERSON_0002ET = "CSE_PERSON_0002ET";
            internal const string NUMBER_0002AS = "NUMBER_0002AS";
            internal const string NUMBER_0002 = "NUMBER_0002";
            internal const string NUMBER_0002XX = "NUMBER_0002XX";
            internal const string EXPORT_0003EV = "EXPORT_0003EV";
            internal const string IM_HOUSEHOLD_0003ET = "IM_HOUSEHOLD_0003ET";
            internal const string AE_CASE_NO_0003AS = "AE_CASE_NO_0003AS";
            internal const string AE_CASE_NO_0003 = "AE_CASE_NO_0003";
            internal const string AE_CASE_NO_0003XX = "AE_CASE_NO_0003XX";
            internal const string EXPORT_0004EV = "EXPORT_0004EV";
            internal const string IM_HOUSEHOLD_MBR_MNTHLY_0004ET = "IM_HOUSEHOLD_MBR_MNTHLY_0004ET";
            internal const string YEAR_0004AS = "YEAR_0004AS";
            internal const string YEAR_0004 = "YEAR_0004";
            internal const string YEAR_0004XX = "YEAR_0004XX";
            internal const string MONTH_0004AS = "MONTH_0004AS";
            internal const string MONTH_0004 = "MONTH_0004";
            internal const string MONTH_0004XX = "MONTH_0004XX";
            internal const string RELATIONSHIP_0004AS = "RELATIONSHIP_0004AS";
            internal const string RELATIONSHIP_0004 = "RELATIONSHIP_0004";
            internal const string RELATIONSHIP_0004XX = "RELATIONSHIP_0004XX";
            internal const string GRANT_AMOUNT_0004AS = "GRANT_AMOUNT_0004AS";
            internal const string GRANT_AMOUNT_0004 = "GRANT_AMOUNT_0004";
            internal const string GRANT_AMOUNT_0004XX = "GRANT_AMOUNT_0004XX";
            internal const string EXPORT_PROGRAM_TYPE_0005EV = "EXPORT_PROGRAM_TYPE_0005EV";
            internal const string WORK_AREA_0005ET = "WORK_AREA_0005ET";
            internal const string TEXT_2_0005AS = "TEXT_2_0005AS";
            internal const string TEXT_2_0005 = "TEXT_2_0005";
            internal const string TEXT_2_0005XX = "TEXT_2_0005XX";
            internal const string EXPORT_ISSUE_TYPE_0006EV = "EXPORT_ISSUE_TYPE_0006EV";
            internal const string WORK_AREA_0006ET = "WORK_AREA_0006ET";
            internal const string TEXT_2_0006AS = "TEXT_2_0006AS";
            internal const string TEXT_2_0006 = "TEXT_2_0006";
            internal const string TEXT_2_0006XX = "TEXT_2_0006XX";
            internal const string EXPORT_0007EV = "EXPORT_0007EV";
            internal const string EAB_FILE_HANDLING_0007ET = "EAB_FILE_HANDLING_0007ET";
            internal const string STATUS_0007AS = "STATUS_0007AS";
            internal const string STATUS_0007 = "STATUS_0007";
            internal const string STATUS_0007XX = "STATUS_0007XX";
        }
        #endregion

        #region Direct-access element properties
        public IField IEF_RUNTIME_PARM1 { get { return GetElementByName<IField>(Names.IEF_RUNTIME_PARM1); } }
        public IField IEF_RUNTIME_PARM2 { get { return GetElementByName<IField>(Names.IEF_RUNTIME_PARM2); } }
        public IGroup GLOBDATA { get { return GetElementByName<IGroup>(Names.GLOBDATA); } }
        public IGroup PSMGR_IEF_COMMAND { get { return GetElementByName<IGroup>(Names.PSMGR_IEF_COMMAND); } }
        public IField PSMGR_IEF_COMMAND_1 { get { return GetElementByName<IField>(Names.PSMGR_IEF_COMMAND_1); } }
        public IField PSMGR_IEF_COMMAND_2 { get { return GetElementByName<IField>(Names.PSMGR_IEF_COMMAND_2); } }
        public IField PSMGR_IEF_TRANCODE { get { return GetElementByName<IField>(Names.PSMGR_IEF_TRANCODE); } }
        public IField PSMGR_EXIT_STATE { get { return GetElementByName<IField>(Names.PSMGR_EXIT_STATE); } }
        public IField PSMGR_EXIT_INFOMSG { get { return GetElementByName<IField>(Names.PSMGR_EXIT_INFOMSG); } }
        public IField PSMGR_USER_ID { get { return GetElementByName<IField>(Names.PSMGR_USER_ID); } }
        public IField PSMGR_TERMINAL_ID { get { return GetElementByName<IField>(Names.PSMGR_TERMINAL_ID); } }
        public IField PSMGR_PRINTER_ID { get { return GetElementByName<IField>(Names.PSMGR_PRINTER_ID); } }
        public IField PSMGR_CURRENT_DATE { get { return GetElementByName<IField>(Names.PSMGR_CURRENT_DATE); } }
        public IField PSMGR_CURRENT_TIME { get { return GetElementByName<IField>(Names.PSMGR_CURRENT_TIME); } }
        public IField PSMGR_RUNTIME_TYPE { get { return GetElementByName<IField>(Names.PSMGR_RUNTIME_TYPE); } }
        public IGroup PSMGR_FUNCTION_DATA { get { return GetElementByName<IGroup>(Names.PSMGR_FUNCTION_DATA); } }
        public IField PSMGR_FUNC_ERRMSG { get { return GetElementByName<IField>(Names.PSMGR_FUNC_ERRMSG); } }
        public IField PSMGR_FUNC_NAME { get { return GetElementByName<IField>(Names.PSMGR_FUNC_NAME); } }
        public IField PSMGR_FUNC_IN_DATE { get { return GetElementByName<IField>(Names.PSMGR_FUNC_IN_DATE); } }
        public IGroup PSMGR_FUNC_IN_DDURA { get { return GetElementByName<IGroup>(Names.PSMGR_FUNC_IN_DDURA); } }
        public IGroup DDURA_YEAR { get { return GetElementByName<IGroup>(Names.DDURA_YEAR); } }
        public IField DDURA_Y_MISS { get { return GetElementByName<IField>(Names.DDURA_Y_MISS); } }
        public IField DDURA_YYYY { get { return GetElementByName<IField>(Names.DDURA_YYYY); } }
        public IGroup DDURA_MONTH { get { return GetElementByName<IGroup>(Names.DDURA_MONTH); } }
        public IField DDURA_M_MISS { get { return GetElementByName<IField>(Names.DDURA_M_MISS); } }
        public IField DDURA_MM { get { return GetElementByName<IField>(Names.DDURA_MM); } }
        public IGroup DDURA_DAY { get { return GetElementByName<IGroup>(Names.DDURA_DAY); } }
        public IField DDURA_D_MISS { get { return GetElementByName<IField>(Names.DDURA_D_MISS); } }
        public IField DDURA_DD { get { return GetElementByName<IField>(Names.DDURA_DD); } }
        public IField PSMGR_FUNC_OUT_DATE { get { return GetElementByName<IField>(Names.PSMGR_FUNC_OUT_DATE); } }
        public IField PSMGR_FUNC_IN_TIME { get { return GetElementByName<IField>(Names.PSMGR_FUNC_IN_TIME); } }
        public IGroup PSMGR_FUNC_IN_TDURA { get { return GetElementByName<IGroup>(Names.PSMGR_FUNC_IN_TDURA); } }
        public IGroup TDURA_HOUR { get { return GetElementByName<IGroup>(Names.TDURA_HOUR); } }
        public IField TDURA_H_MISS { get { return GetElementByName<IField>(Names.TDURA_H_MISS); } }
        public IField TDURA_HH { get { return GetElementByName<IField>(Names.TDURA_HH); } }
        public IGroup TDURA_MINUTE { get { return GetElementByName<IGroup>(Names.TDURA_MINUTE); } }
        public IField TDURA_M_MISS { get { return GetElementByName<IField>(Names.TDURA_M_MISS); } }
        public IField TDURA_MM { get { return GetElementByName<IField>(Names.TDURA_MM); } }
        public IGroup TDURA_SECOND { get { return GetElementByName<IGroup>(Names.TDURA_SECOND); } }
        public IField TDURA_S_MISS { get { return GetElementByName<IField>(Names.TDURA_S_MISS); } }
        public IField TDURA_SS { get { return GetElementByName<IField>(Names.TDURA_SS); } }
        public IField PSMGR_FUNC_OUT_TIME { get { return GetElementByName<IField>(Names.PSMGR_FUNC_OUT_TIME); } }
        public IField PSMGR_IEF_NEXTTRAN { get { return GetElementByName<IField>(Names.PSMGR_IEF_NEXTTRAN); } }
        public IField PSMGR_EXIT_MSGTYPE { get { return GetElementByName<IField>(Names.PSMGR_EXIT_MSGTYPE); } }
        public IGroup PSMGR_IEF_DEBUG_FLAGS { get { return GetElementByName<IGroup>(Names.PSMGR_IEF_DEBUG_FLAGS); } }
        public IField PSMGR_IEF_DEBUG { get { return GetElementByName<IField>(Names.PSMGR_IEF_DEBUG); } }
        public ICheckField PSMGR_DEBUG_ON { get { return GetElementByName<ICheckField>(Names.PSMGR_DEBUG_ON); } }
        public IGroup PSMGR_ENVIRONMENT_DATA { get { return GetElementByName<IGroup>(Names.PSMGR_ENVIRONMENT_DATA); } }
        public IField PSMGR_PCB_CNT { get { return GetElementByName<IField>(Names.PSMGR_PCB_CNT); } }
        public IArrayElementAccessor<IGroup> PSMGR_PCB_ENTRY { get { return GetArrayElementAccessor<IGroup>(Names.PSMGR_PCB_ENTRY); } }
        public IArrayElementAccessor<IField> PSMGR_PCB_ADR { get { return GetArrayElementAccessor<IField>(Names.PSMGR_PCB_ADR); } }
        public IGroup PSMGR_EAB_DATA { get { return GetElementByName<IGroup>(Names.PSMGR_EAB_DATA); } }
        public IField PSMGR_EABPCB_CNT { get { return GetElementByName<IField>(Names.PSMGR_EABPCB_CNT); } }
        public IArrayElementAccessor<IGroup> PSMGR_EABPCB_ENTRY { get { return GetArrayElementAccessor<IGroup>(Names.PSMGR_EABPCB_ENTRY); } }
        public IArrayElementAccessor<IField> PSMGR_EABPCB_ADR { get { return GetArrayElementAccessor<IField>(Names.PSMGR_EABPCB_ADR); } }
        public IGroup PSMGR_ERROR_DATA { get { return GetElementByName<IGroup>(Names.PSMGR_ERROR_DATA); } }
        public IField ERROR_ACTION_NAME { get { return GetElementByName<IField>(Names.ERROR_ACTION_NAME); } }
        public IField ERROR_ENCOUNTERED_SW { get { return GetElementByName<IField>(Names.ERROR_ENCOUNTERED_SW); } }
        public IField VIEW_OVERFLOW_SW { get { return GetElementByName<IField>(Names.VIEW_OVERFLOW_SW); } }
        public IGroup PSMGR_DASG_DATA { get { return GetElementByName<IGroup>(Names.PSMGR_DASG_DATA); } }
        public IGroup ACTION_ID_X { get { return GetElementByName<IGroup>(Names.ACTION_ID_X); } }
        public IField ACTION_ID { get { return GetElementByName<IField>(Names.ACTION_ID); } }
        public IGroup ATTRIBUTE_ID_X { get { return GetElementByName<IGroup>(Names.ATTRIBUTE_ID_X); } }
        public IField ATTRIBUTE_ID { get { return GetElementByName<IField>(Names.ATTRIBUTE_ID); } }
        public IField STATUS_FLAG { get { return GetElementByName<IField>(Names.STATUS_FLAG); } }
        public ICheckField FATAL_ERROR_SF { get { return GetElementByName<ICheckField>(Names.FATAL_ERROR_SF); } }
        public ICheckField DB_ERROR_SF { get { return GetElementByName<ICheckField>(Names.DB_ERROR_SF); } }
        public ICheckField ABORT_SHOW_DBMS_MSG_SF { get { return GetElementByName<ICheckField>(Names.ABORT_SHOW_DBMS_MSG_SF); } }
        public ICheckField ABORT_SHOW_USER_MSG_SF { get { return GetElementByName<ICheckField>(Names.ABORT_SHOW_USER_MSG_SF); } }
        public ICheckField RETRY_TRAN_REQUESTED_SF { get { return GetElementByName<ICheckField>(Names.RETRY_TRAN_REQUESTED_SF); } }
        public ICheckField PSTEP_USE_FAILURE { get { return GetElementByName<ICheckField>(Names.PSTEP_USE_FAILURE); } }
        public IField LAST_STATUS { get { return GetElementByName<IField>(Names.LAST_STATUS); } }
        public ICheckField DB_ERROR_FL_LS { get { return GetElementByName<ICheckField>(Names.DB_ERROR_FL_LS); } }
        public ICheckField DB_DEADLOCK_TIMOUT_FL_LS { get { return GetElementByName<ICheckField>(Names.DB_DEADLOCK_TIMOUT_FL_LS); } }
        public ICheckField DUPLICATE_FOUND_FL_LS { get { return GetElementByName<ICheckField>(Names.DUPLICATE_FOUND_FL_LS); } }
        public ICheckField INVALID_DATAA_FL_LS { get { return GetElementByName<ICheckField>(Names.INVALID_DATAA_FL_LS); } }
        public ICheckField INVALID_DATAB_TYPE_FL_LS { get { return GetElementByName<ICheckField>(Names.INVALID_DATAB_TYPE_FL_LS); } }
        public ICheckField INVALID_DATAB_PERM_FL_LS { get { return GetElementByName<ICheckField>(Names.INVALID_DATAB_PERM_FL_LS); } }
        public ICheckField FATAL_ERROR_FL_LS { get { return GetElementByName<ICheckField>(Names.FATAL_ERROR_FL_LS); } }
        public ICheckField NOT_FOUND_FL_LS { get { return GetElementByName<ICheckField>(Names.NOT_FOUND_FL_LS); } }
        public ICheckField NOT_UNIQUE_FL_LS { get { return GetElementByName<ICheckField>(Names.NOT_UNIQUE_FL_LS); } }
        public ICheckField IEF_FUNCTION_ERROR_FL_LS { get { return GetElementByName<ICheckField>(Names.IEF_FUNCTION_ERROR_FL_LS); } }
        public ICheckField IEF_DURATION_ERROR_FL_LS { get { return GetElementByName<ICheckField>(Names.IEF_DURATION_ERROR_FL_LS); } }
        public ICheckField USED_PSTEP_NOT_FOUND { get { return GetElementByName<ICheckField>(Names.USED_PSTEP_NOT_FOUND); } }
        public ICheckField USED_PSTEP_ROUTING_ERR { get { return GetElementByName<ICheckField>(Names.USED_PSTEP_ROUTING_ERR); } }
        public ICheckField USED_PSTEP_SND_FMT_ERR { get { return GetElementByName<ICheckField>(Names.USED_PSTEP_SND_FMT_ERR); } }
        public ICheckField USED_PSTEP_ENCRYPT_ERR { get { return GetElementByName<ICheckField>(Names.USED_PSTEP_ENCRYPT_ERR); } }
        public ICheckField USED_PSTEP_SND_BFR_ERR { get { return GetElementByName<ICheckField>(Names.USED_PSTEP_SND_BFR_ERR); } }
        public ICheckField USED_PSTEP_RCV_BFR_ERR { get { return GetElementByName<ICheckField>(Names.USED_PSTEP_RCV_BFR_ERR); } }
        public ICheckField USED_PSTEP_RCV_FMT_ERR { get { return GetElementByName<ICheckField>(Names.USED_PSTEP_RCV_FMT_ERR); } }
        public ICheckField USED_PSTEP_TIRSECR_ERR { get { return GetElementByName<ICheckField>(Names.USED_PSTEP_TIRSECR_ERR); } }
        public ICheckField USED_PSTEP_TOKEN_ERR { get { return GetElementByName<ICheckField>(Names.USED_PSTEP_TOKEN_ERR); } }
        public ICheckField USED_PSTEP_SEND_MAX_SIZE { get { return GetElementByName<ICheckField>(Names.USED_PSTEP_SEND_MAX_SIZE); } }
        public ICheckField USED_PSTEP_SECG_ERR { get { return GetElementByName<ICheckField>(Names.USED_PSTEP_SECG_ERR); } }
        public ICheckField USED_PSTEP_ALLOC_ERR { get { return GetElementByName<ICheckField>(Names.USED_PSTEP_ALLOC_ERR); } }
        public ICheckField USED_PSTEP_CONNECT_ERR { get { return GetElementByName<ICheckField>(Names.USED_PSTEP_CONNECT_ERR); } }
        public ICheckField USED_PSTEP_XERR { get { return GetElementByName<ICheckField>(Names.USED_PSTEP_XERR); } }
        public ICheckField USED_PSTEP_RCV_UA_ERR { get { return GetElementByName<ICheckField>(Names.USED_PSTEP_RCV_UA_ERR); } }
        public ICheckField USED_PSTEP_RCV_ES_ERR { get { return GetElementByName<ICheckField>(Names.USED_PSTEP_RCV_ES_ERR); } }
        public ICheckField USED_PSTEP_XFAL { get { return GetElementByName<ICheckField>(Names.USED_PSTEP_XFAL); } }
        public ICheckField USED_PSTEP_SETOA_ERR { get { return GetElementByName<ICheckField>(Names.USED_PSTEP_SETOA_ERR); } }
        public ICheckField USED_PSTEP_RCV_VIEW_ERR { get { return GetElementByName<ICheckField>(Names.USED_PSTEP_RCV_VIEW_ERR); } }
        public ICheckField USED_PSTEP_DECRYPT_ERR { get { return GetElementByName<ICheckField>(Names.USED_PSTEP_DECRYPT_ERR); } }
        public IField SAVE_SQLCA { get { return GetElementByName<IField>(Names.SAVE_SQLCA); } }
        public IGroup PSMGR_DEBUG_DATA { get { return GetElementByName<IGroup>(Names.PSMGR_DEBUG_DATA); } }
        public IField PSMGR_TRACE_ADR { get { return GetElementByName<IField>(Names.PSMGR_TRACE_ADR); } }
        public IGroup LAST_STATEMENT_X { get { return GetElementByName<IGroup>(Names.LAST_STATEMENT_X); } }
        public IField LAST_STATEMENT_NUM { get { return GetElementByName<IField>(Names.LAST_STATEMENT_NUM); } }
        public IField CUR_AB_ID { get { return GetElementByName<IField>(Names.CUR_AB_ID); } }
        public IField CUR_AB_NAME { get { return GetElementByName<IField>(Names.CUR_AB_NAME); } }
        public IField PSMGR_TIRDATE_SAVEAREA { get { return GetElementByName<IField>(Names.PSMGR_TIRDATE_SAVEAREA); } }
        public IGroup PSMGR_TIRDATE_CMCB { get { return GetElementByName<IGroup>(Names.PSMGR_TIRDATE_CMCB); } }
        public IField PSMGR_TIRDATE_DATE { get { return GetElementByName<IField>(Names.PSMGR_TIRDATE_DATE); } }
        public IField PSMGR_TIRDATE_TIME { get { return GetElementByName<IField>(Names.PSMGR_TIRDATE_TIME); } }
        public IField PSMGR_TIRDATE_INC { get { return GetElementByName<IField>(Names.PSMGR_TIRDATE_INC); } }
        public IField PSMGR_TIRDATE_RC { get { return GetElementByName<IField>(Names.PSMGR_TIRDATE_RC); } }
        public ICheckField PSMGR_TIRDATE_OK { get { return GetElementByName<ICheckField>(Names.PSMGR_TIRDATE_OK); } }
        public ICheckField PSMGR_TIRDATE_WARNING { get { return GetElementByName<ICheckField>(Names.PSMGR_TIRDATE_WARNING); } }
        public ICheckField PSMGR_TIRDATE_ERROR { get { return GetElementByName<ICheckField>(Names.PSMGR_TIRDATE_ERROR); } }
        public IField PSMGR_TIRDATE_REQ { get { return GetElementByName<IField>(Names.PSMGR_TIRDATE_REQ); } }
        public IField PSMGR_TIRDATE_DATEF { get { return GetElementByName<IField>(Names.PSMGR_TIRDATE_DATEF); } }
        public IField PSMGR_TIRDATE_TIMEF { get { return GetElementByName<IField>(Names.PSMGR_TIRDATE_TIMEF); } }
        public IField PSMGR_TIRDATE_RETMSG { get { return GetElementByName<IField>(Names.PSMGR_TIRDATE_RETMSG); } }
        public IField PSMGR_TIRDATE_TSTAMP { get { return GetElementByName<IField>(Names.PSMGR_TIRDATE_TSTAMP); } }
        public IField PSMGR_TIRDATE_DATE_Z { get { return GetElementByName<IField>(Names.PSMGR_TIRDATE_DATE_Z); } }
        public IField PSMGR_TIRDATE_TIME_Z { get { return GetElementByName<IField>(Names.PSMGR_TIRDATE_TIME_Z); } }
        public IField PSMGR_TIRDATE_SKIP_VAL { get { return GetElementByName<IField>(Names.PSMGR_TIRDATE_SKIP_VAL); } }
        public IField PSMGR_ROLLBACK_RQSTED { get { return GetElementByName<IField>(Names.PSMGR_ROLLBACK_RQSTED); } }
        public ICheckField ROLLBACK_RQSTED { get { return GetElementByName<ICheckField>(Names.ROLLBACK_RQSTED); } }
        public ICheckField ABEND_RQSTED { get { return GetElementByName<ICheckField>(Names.ABEND_RQSTED); } }
        public ICheckField TERMINATE_RQSTED { get { return GetElementByName<ICheckField>(Names.TERMINATE_RQSTED); } }
        public IGroup TIRTRCE_SAVE_AREA { get { return GetElementByName<IGroup>(Names.TIRTRCE_SAVE_AREA); } }
        public IField TOP_INDX { get { return GetElementByName<IField>(Names.TOP_INDX); } }
        public IField BOTTOM_INDX { get { return GetElementByName<IField>(Names.BOTTOM_INDX); } }
        public IField END_INDX { get { return GetElementByName<IField>(Names.END_INDX); } }
        public IField LAST_STMT { get { return GetElementByName<IField>(Names.LAST_STMT); } }
        public IField TOP_OF_CALL { get { return GetElementByName<IField>(Names.TOP_OF_CALL); } }
        public IField TRACE_BREAK_POINT { get { return GetElementByName<IField>(Names.TRACE_BREAK_POINT); } }
        public IField TRACE_BREAK_POINT_STATUS { get { return GetElementByName<IField>(Names.TRACE_BREAK_POINT_STATUS); } }
        public IField LAST_AB_NAME { get { return GetElementByName<IField>(Names.LAST_AB_NAME); } }
        public IField COLOR { get { return GetElementByName<IField>(Names.COLOR); } }
        public IField COLORT { get { return GetElementByName<IField>(Names.COLORT); } }
        public IField HILITE { get { return GetElementByName<IField>(Names.HILITE); } }
        public IField TRACE_ON_OFF { get { return GetElementByName<IField>(Names.TRACE_ON_OFF); } }
        public IGroup CASCADE_DELETE_FLAGS { get { return GetElementByName<IGroup>(Names.CASCADE_DELETE_FLAGS); } }
        public IField V1PRESENT { get { return GetElementByName<IField>(Names.V1PRESENT); } }
        public IField V2PRESENT { get { return GetElementByName<IField>(Names.V2PRESENT); } }
        public IField CASCADE1 { get { return GetElementByName<IField>(Names.CASCADE1); } }
        public IField CASCADE2 { get { return GetElementByName<IField>(Names.CASCADE2); } }
        public IField PROCESSQ_FLAG { get { return GetElementByName<IField>(Names.PROCESSQ_FLAG); } }
        public IGroup PSMGR_ACTIVE_DIALECT { get { return GetElementByName<IGroup>(Names.PSMGR_ACTIVE_DIALECT); } }
        public IField DIALECT_NAME { get { return GetElementByName<IField>(Names.DIALECT_NAME); } }
        public IField MESSAGE_TABLE_NAME { get { return GetElementByName<IField>(Names.MESSAGE_TABLE_NAME); } }
        public IField TRANSLATE_TABLE_NAME { get { return GetElementByName<IField>(Names.TRANSLATE_TABLE_NAME); } }
        public IGroup PSMGR_FUNCTION_DATA_EXT { get { return GetElementByName<IGroup>(Names.PSMGR_FUNCTION_DATA_EXT); } }
        public IField PSMGR_FUNC_IN_TIMESTAMP { get { return GetElementByName<IField>(Names.PSMGR_FUNC_IN_TIMESTAMP); } }
        public IGroup PSMGR_FUNC_IN_TSDURA { get { return GetElementByName<IGroup>(Names.PSMGR_FUNC_IN_TSDURA); } }
        public IGroup TSDURA_MICROSECOND { get { return GetElementByName<IGroup>(Names.TSDURA_MICROSECOND); } }
        public IField TSDURA_M_MISS { get { return GetElementByName<IField>(Names.TSDURA_M_MISS); } }
        public IField TSDURA_MS { get { return GetElementByName<IField>(Names.TSDURA_MS); } }
        public IField PSMGR_FUNC_OUT_TIMESTAMP { get { return GetElementByName<IField>(Names.PSMGR_FUNC_OUT_TIMESTAMP); } }
        public IField PSMGR_CICS_FAIL_SW { get { return GetElementByName<IField>(Names.PSMGR_CICS_FAIL_SW); } }
        public ICheckField INHIBIT_CICS_RECEIVE { get { return GetElementByName<ICheckField>(Names.INHIBIT_CICS_RECEIVE); } }
        public IField CLIENT_USERID { get { return GetElementByName<IField>(Names.CLIENT_USERID); } }
        public IField CLIENT_PASSWORD { get { return GetElementByName<IField>(Names.CLIENT_PASSWORD); } }
        public IField LOAD_MODULE_NAME { get { return GetElementByName<IField>(Names.LOAD_MODULE_NAME); } }
        public IField INSTRUMENT_CODE { get { return GetElementByName<IField>(Names.INSTRUMENT_CODE); } }
        public IField TX_RETRY_LIMIT { get { return GetElementByName<IField>(Names.TX_RETRY_LIMIT); } }
        public IField TX_TIMEOUT { get { return GetElementByName<IField>(Names.TX_TIMEOUT); } }
        public IGroup PSMGR_EXTRA_ERRINFO { get { return GetElementByName<IGroup>(Names.PSMGR_EXTRA_ERRINFO); } }
        public IField ERRINFO_BUF_SIZE { get { return GetElementByName<IField>(Names.ERRINFO_BUF_SIZE); } }
        public IField ERRINFO_MSG_SIZE { get { return GetElementByName<IField>(Names.ERRINFO_MSG_SIZE); } }
        public IField ERRINFO_BUF_ADDR { get { return GetElementByName<IField>(Names.ERRINFO_BUF_ADDR); } }
        public IField TX_RETRY_COUNT { get { return GetElementByName<IField>(Names.TX_RETRY_COUNT); } }
        public IField TX_USER_RETRY_ALLOWED { get { return GetElementByName<IField>(Names.TX_USER_RETRY_ALLOWED); } }
        public IGroup PSMGR_PSTEP_USE_PTRS { get { return GetElementByName<IGroup>(Names.PSMGR_PSTEP_USE_PTRS); } }
        public IField PSTEP_FAIL_MSG_PTR { get { return GetElementByName<IField>(Names.PSTEP_FAIL_MSG_PTR); } }
        public IField PSTEP_GURB_REST_PTR { get { return GetElementByName<IField>(Names.PSTEP_GURB_REST_PTR); } }
        public IField PSTEP_LIPS_PTR { get { return GetElementByName<IField>(Names.PSTEP_LIPS_PTR); } }
        public IField PSTEP_TBL_PTR { get { return GetElementByName<IField>(Names.PSTEP_TBL_PTR); } }
        public IField PSTEP_DDF_PTR { get { return GetElementByName<IField>(Names.PSTEP_DDF_PTR); } }
        public IField PSTEP_COMM_ID { get { return GetElementByName<IField>(Names.PSTEP_COMM_ID); } }
        public IField PSTEP_APPL_LIST_PTR { get { return GetElementByName<IField>(Names.PSTEP_APPL_LIST_PTR); } }
        public IField PSTEP_CURR_PST_PTR { get { return GetElementByName<IField>(Names.PSTEP_CURR_PST_PTR); } }
        public IGroup PSMGR_PSTEP_USE_SYSFLDS { get { return GetElementByName<IGroup>(Names.PSMGR_PSTEP_USE_SYSFLDS); } }
        public IField PSMGR_EIBERRCD { get { return GetElementByName<IField>(Names.PSMGR_EIBERRCD); } }
        public IField PSMGR_EIBFN { get { return GetElementByName<IField>(Names.PSMGR_EIBFN); } }
        public IField PSMGR_EIBRESP { get { return GetElementByName<IField>(Names.PSMGR_EIBRESP); } }
        public IField PSMGR_EIBRESP2 { get { return GetElementByName<IField>(Names.PSMGR_EIBRESP2); } }
        public IGroup IMPORT_0001EV { get { return GetElementByName<IGroup>(Names.IMPORT_0001EV); } }
        public IGroup EAB_FILE_HANDLING_0001ET { get { return GetElementByName<IGroup>(Names.EAB_FILE_HANDLING_0001ET); } }
        public IField ACTION_0001AS { get { return GetElementByName<IField>(Names.ACTION_0001AS); } }
        public IField ACTION_0001 { get { return GetElementByName<IField>(Names.ACTION_0001); } }
        public IField ACTION_0001XX { get { return GetElementByName<IField>(Names.ACTION_0001XX); } }
        public IGroup EXPORT_0002EV { get { return GetElementByName<IGroup>(Names.EXPORT_0002EV); } }
        public IGroup CSE_PERSON_0002ET { get { return GetElementByName<IGroup>(Names.CSE_PERSON_0002ET); } }
        public IField NUMBER_0002AS { get { return GetElementByName<IField>(Names.NUMBER_0002AS); } }
        public IField NUMBER_0002 { get { return GetElementByName<IField>(Names.NUMBER_0002); } }
        public IField NUMBER_0002XX { get { return GetElementByName<IField>(Names.NUMBER_0002XX); } }
        public IGroup EXPORT_0003EV { get { return GetElementByName<IGroup>(Names.EXPORT_0003EV); } }
        public IGroup IM_HOUSEHOLD_0003ET { get { return GetElementByName<IGroup>(Names.IM_HOUSEHOLD_0003ET); } }
        public IField AE_CASE_NO_0003AS { get { return GetElementByName<IField>(Names.AE_CASE_NO_0003AS); } }
        public IField AE_CASE_NO_0003 { get { return GetElementByName<IField>(Names.AE_CASE_NO_0003); } }
        public IField AE_CASE_NO_0003XX { get { return GetElementByName<IField>(Names.AE_CASE_NO_0003XX); } }
        public IGroup EXPORT_0004EV { get { return GetElementByName<IGroup>(Names.EXPORT_0004EV); } }
        public IGroup IM_HOUSEHOLD_MBR_MNTHLY_0004ET { get { return GetElementByName<IGroup>(Names.IM_HOUSEHOLD_MBR_MNTHLY_0004ET); } }
        public IField YEAR_0004AS { get { return GetElementByName<IField>(Names.YEAR_0004AS); } }
        public IField YEAR_0004 { get { return GetElementByName<IField>(Names.YEAR_0004); } }
        public IField YEAR_0004XX { get { return GetElementByName<IField>(Names.YEAR_0004XX); } }
        public IField MONTH_0004AS { get { return GetElementByName<IField>(Names.MONTH_0004AS); } }
        public IField MONTH_0004 { get { return GetElementByName<IField>(Names.MONTH_0004); } }
        public IField MONTH_0004XX { get { return GetElementByName<IField>(Names.MONTH_0004XX); } }
        public IField RELATIONSHIP_0004AS { get { return GetElementByName<IField>(Names.RELATIONSHIP_0004AS); } }
        public IField RELATIONSHIP_0004 { get { return GetElementByName<IField>(Names.RELATIONSHIP_0004); } }
        public IField RELATIONSHIP_0004XX { get { return GetElementByName<IField>(Names.RELATIONSHIP_0004XX); } }
        public IField GRANT_AMOUNT_0004AS { get { return GetElementByName<IField>(Names.GRANT_AMOUNT_0004AS); } }
        public IField GRANT_AMOUNT_0004 { get { return GetElementByName<IField>(Names.GRANT_AMOUNT_0004); } }
        public IField GRANT_AMOUNT_0004XX { get { return GetElementByName<IField>(Names.GRANT_AMOUNT_0004XX); } }
        public IGroup EXPORT_PROGRAM_TYPE_0005EV { get { return GetElementByName<IGroup>(Names.EXPORT_PROGRAM_TYPE_0005EV); } }
        public IGroup WORK_AREA_0005ET { get { return GetElementByName<IGroup>(Names.WORK_AREA_0005ET); } }
        public IField TEXT_2_0005AS { get { return GetElementByName<IField>(Names.TEXT_2_0005AS); } }
        public IField TEXT_2_0005 { get { return GetElementByName<IField>(Names.TEXT_2_0005); } }
        public IField TEXT_2_0005XX { get { return GetElementByName<IField>(Names.TEXT_2_0005XX); } }
        public IGroup EXPORT_ISSUE_TYPE_0006EV { get { return GetElementByName<IGroup>(Names.EXPORT_ISSUE_TYPE_0006EV); } }
        public IGroup WORK_AREA_0006ET { get { return GetElementByName<IGroup>(Names.WORK_AREA_0006ET); } }
        public IField TEXT_2_0006AS { get { return GetElementByName<IField>(Names.TEXT_2_0006AS); } }
        public IField TEXT_2_0006 { get { return GetElementByName<IField>(Names.TEXT_2_0006); } }
        public IField TEXT_2_0006XX { get { return GetElementByName<IField>(Names.TEXT_2_0006XX); } }
        public IGroup EXPORT_0007EV { get { return GetElementByName<IGroup>(Names.EXPORT_0007EV); } }
        public IGroup EAB_FILE_HANDLING_0007ET { get { return GetElementByName<IGroup>(Names.EAB_FILE_HANDLING_0007ET); } }
        public IField STATUS_0007AS { get { return GetElementByName<IField>(Names.STATUS_0007AS); } }
        public IField STATUS_0007 { get { return GetElementByName<IField>(Names.STATUS_0007); } }
        public IField STATUS_0007XX { get { return GetElementByName<IField>(Names.STATUS_0007XX); } }

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

            recordDef.CreateNewGroup(Names.GLOBDATA, (GLOBDATA) =>
           {
               GLOBDATA.CreateNewGroup(Names.PSMGR_IEF_COMMAND, (PSMGR_IEF_COMMAND) =>
               {
                   PSMGR_IEF_COMMAND.CreateNewField(Names.PSMGR_IEF_COMMAND_1, FieldType.String, 8);
                   PSMGR_IEF_COMMAND.CreateNewField(Names.PSMGR_IEF_COMMAND_2, FieldType.String, 72);
               });
               GLOBDATA.CreateNewField(Names.PSMGR_IEF_TRANCODE, FieldType.String, 8);
               GLOBDATA.CreateNewField(Names.PSMGR_EXIT_STATE, FieldType.PackedDecimal, 11);
               GLOBDATA.CreateNewField(Names.PSMGR_EXIT_INFOMSG, FieldType.String, 80);
               GLOBDATA.CreateNewField(Names.PSMGR_USER_ID, FieldType.String, 8);
               GLOBDATA.CreateNewField(Names.PSMGR_TERMINAL_ID, FieldType.String, 8);
               GLOBDATA.CreateNewField(Names.PSMGR_PRINTER_ID, FieldType.String, 8);
               GLOBDATA.CreateNewField(Names.PSMGR_CURRENT_DATE, FieldType.CompInt, 9);
               GLOBDATA.CreateNewField(Names.PSMGR_CURRENT_TIME, FieldType.CompInt, 9);
               GLOBDATA.CreateNewField(Names.PSMGR_RUNTIME_TYPE, FieldType.String, 4);
               GLOBDATA.CreateNewGroup(Names.PSMGR_FUNCTION_DATA, (PSMGR_FUNCTION_DATA) =>
               {
                   PSMGR_FUNCTION_DATA.CreateNewField(Names.PSMGR_FUNC_ERRMSG, FieldType.String, 4);
                   PSMGR_FUNCTION_DATA.CreateNewField(Names.PSMGR_FUNC_NAME, FieldType.String, 8);
                   PSMGR_FUNCTION_DATA.CreateNewField(Names.PSMGR_FUNC_IN_DATE, FieldType.String, 8);
                   PSMGR_FUNCTION_DATA.CreateNewGroup(Names.PSMGR_FUNC_IN_DDURA, (PSMGR_FUNC_IN_DDURA) =>
                   {
                       PSMGR_FUNC_IN_DDURA.CreateNewGroup(Names.DDURA_YEAR, (DDURA_YEAR) =>
                       {
                           DDURA_YEAR.CreateNewField(Names.DDURA_Y_MISS, FieldType.String, 1);
                           DDURA_YEAR.CreateNewField(Names.DDURA_YYYY, FieldType.CompInt, 9);
                       });
                       PSMGR_FUNC_IN_DDURA.CreateNewGroup(Names.DDURA_MONTH, (DDURA_MONTH) =>
                       {
                           DDURA_MONTH.CreateNewField(Names.DDURA_M_MISS, FieldType.String, 1);
                           DDURA_MONTH.CreateNewField(Names.DDURA_MM, FieldType.CompInt, 9);
                       });
                       PSMGR_FUNC_IN_DDURA.CreateNewGroup(Names.DDURA_DAY, (DDURA_DAY) =>
                       {
                           DDURA_DAY.CreateNewField(Names.DDURA_D_MISS, FieldType.String, 1);
                           DDURA_DAY.CreateNewField(Names.DDURA_DD, FieldType.CompInt, 9);
                       });
                   });
                   PSMGR_FUNCTION_DATA.CreateNewField(Names.PSMGR_FUNC_OUT_DATE, FieldType.String, 8);
                   PSMGR_FUNCTION_DATA.CreateNewField(Names.PSMGR_FUNC_IN_TIME, FieldType.String, 6);
                   PSMGR_FUNCTION_DATA.CreateNewGroup(Names.PSMGR_FUNC_IN_TDURA, (PSMGR_FUNC_IN_TDURA) =>
                   {
                       PSMGR_FUNC_IN_TDURA.CreateNewGroup(Names.TDURA_HOUR, (TDURA_HOUR) =>
                       {
                           TDURA_HOUR.CreateNewField(Names.TDURA_H_MISS, FieldType.String, 1);
                           TDURA_HOUR.CreateNewField(Names.TDURA_HH, FieldType.CompInt, 9);
                       });
                       PSMGR_FUNC_IN_TDURA.CreateNewGroup(Names.TDURA_MINUTE, (TDURA_MINUTE) =>
                       {
                           TDURA_MINUTE.CreateNewField(Names.TDURA_M_MISS, FieldType.String, 1);
                           TDURA_MINUTE.CreateNewField(Names.TDURA_MM, FieldType.CompInt, 9);
                       });
                       PSMGR_FUNC_IN_TDURA.CreateNewGroup(Names.TDURA_SECOND, (TDURA_SECOND) =>
                       {
                           TDURA_SECOND.CreateNewField(Names.TDURA_S_MISS, FieldType.String, 1);
                           TDURA_SECOND.CreateNewField(Names.TDURA_SS, FieldType.CompInt, 9);
                       });
                   });
                   PSMGR_FUNCTION_DATA.CreateNewField(Names.PSMGR_FUNC_OUT_TIME, FieldType.String, 6);
               });
               GLOBDATA.CreateNewFillerField(2, FillWith.Hashes);
               GLOBDATA.CreateNewField(Names.PSMGR_IEF_NEXTTRAN, FieldType.String, 80);
               GLOBDATA.CreateNewField(Names.PSMGR_EXIT_MSGTYPE, FieldType.String, 1);
               GLOBDATA.CreateNewFillerField(11, FillWith.Hashes);
               GLOBDATA.CreateNewGroup(Names.PSMGR_IEF_DEBUG_FLAGS, (PSMGR_IEF_DEBUG_FLAGS) =>
               {
                   PSMGR_IEF_DEBUG_FLAGS.CreateNewField(Names.PSMGR_IEF_DEBUG, FieldType.String, 1)
                       .NewCheckField(Names.PSMGR_DEBUG_ON, "Y")
                       ;
                   PSMGR_IEF_DEBUG_FLAGS.CreateNewFillerField(15, FillWith.Hashes);
               });
               GLOBDATA.CreateNewGroup(Names.PSMGR_ENVIRONMENT_DATA, (PSMGR_ENVIRONMENT_DATA) =>
               {
                   PSMGR_ENVIRONMENT_DATA.CreateNewField(Names.PSMGR_PCB_CNT, FieldType.CompInt, 9);
                   PSMGR_ENVIRONMENT_DATA.CreateNewGroupArray(Names.PSMGR_PCB_ENTRY, 255, (PSMGR_PCB_ENTRY) =>
                   {
                       PSMGR_PCB_ENTRY.CreateNewField(Names.PSMGR_PCB_ADR, FieldType.CompInt, 9);
                   });
               });
               GLOBDATA.CreateNewGroup(Names.PSMGR_EAB_DATA, (PSMGR_EAB_DATA) =>
               {
                   PSMGR_EAB_DATA.CreateNewField(Names.PSMGR_EABPCB_CNT, FieldType.CompInt, 9);
                   PSMGR_EAB_DATA.CreateNewGroupArray(Names.PSMGR_EABPCB_ENTRY, 255, (PSMGR_EABPCB_ENTRY) =>
                   {
                       PSMGR_EABPCB_ENTRY.CreateNewField(Names.PSMGR_EABPCB_ADR, FieldType.CompInt, 9);
                   });
               });
               GLOBDATA.CreateNewGroup(Names.PSMGR_ERROR_DATA, (PSMGR_ERROR_DATA) =>
               {
                   PSMGR_ERROR_DATA.CreateNewField(Names.ERROR_ACTION_NAME, FieldType.String, 32);
                   PSMGR_ERROR_DATA.CreateNewField(Names.ERROR_ENCOUNTERED_SW, FieldType.String, 1);
                   PSMGR_ERROR_DATA.CreateNewField(Names.VIEW_OVERFLOW_SW, FieldType.String, 1);
               });
               GLOBDATA.CreateNewGroup(Names.PSMGR_DASG_DATA, (PSMGR_DASG_DATA) =>
               {
                   PSMGR_DASG_DATA.CreateNewGroup(Names.ACTION_ID_X, (ACTION_ID_X) =>
                   {
                       ACTION_ID_X.CreateNewField(Names.ACTION_ID, FieldType.UnsignedNumeric, 10);
                   });
                   PSMGR_DASG_DATA.CreateNewGroup(Names.ATTRIBUTE_ID_X, (ATTRIBUTE_ID_X) =>
                   {
                       ATTRIBUTE_ID_X.CreateNewField(Names.ATTRIBUTE_ID, FieldType.UnsignedNumeric, 10);
                   });
                   PSMGR_DASG_DATA.CreateNewField(Names.STATUS_FLAG, FieldType.String, 2)
                       .NewCheckField(Names.FATAL_ERROR_SF, "FE")
                       .NewCheckField(Names.DB_ERROR_SF, "DB")
                       .NewCheckField(Names.ABORT_SHOW_DBMS_MSG_SF, "AB")
                       .NewCheckField(Names.ABORT_SHOW_USER_MSG_SF, "AM")
                       .NewCheckField(Names.RETRY_TRAN_REQUESTED_SF, "RT")
                       .NewCheckField(Names.PSTEP_USE_FAILURE, "PU")
                       ;
                   PSMGR_DASG_DATA.CreateNewField(Names.LAST_STATUS, FieldType.String, 2)
                       .NewCheckField(Names.DB_ERROR_FL_LS, "DB")
                       .NewCheckField(Names.DB_DEADLOCK_TIMOUT_FL_LS, "DT")
                       .NewCheckField(Names.DUPLICATE_FOUND_FL_LS, "DF")
                       .NewCheckField(Names.INVALID_DATAA_FL_LS, "IA")
                       .NewCheckField(Names.INVALID_DATAB_TYPE_FL_LS, "BT")
                       .NewCheckField(Names.INVALID_DATAB_PERM_FL_LS, "BP")
                       .NewCheckField(Names.FATAL_ERROR_FL_LS, "FE")
                       .NewCheckField(Names.NOT_FOUND_FL_LS, "NF")
                       .NewCheckField(Names.NOT_UNIQUE_FL_LS, "NU")
                       .NewCheckField(Names.IEF_FUNCTION_ERROR_FL_LS, "IE")
                       .NewCheckField(Names.IEF_DURATION_ERROR_FL_LS, "DE")
                       .NewCheckField(Names.USED_PSTEP_NOT_FOUND, "PO")
                       .NewCheckField(Names.USED_PSTEP_ROUTING_ERR, "PX")
                       .NewCheckField(Names.USED_PSTEP_SND_FMT_ERR, "PF")
                       .NewCheckField(Names.USED_PSTEP_ENCRYPT_ERR, "PN")
                       .NewCheckField(Names.USED_PSTEP_SND_BFR_ERR, "PS")
                       .NewCheckField(Names.USED_PSTEP_RCV_BFR_ERR, "PR")
                       .NewCheckField(Names.USED_PSTEP_RCV_FMT_ERR, "PU")
                       .NewCheckField(Names.USED_PSTEP_TIRSECR_ERR, "PE")
                       .NewCheckField(Names.USED_PSTEP_TOKEN_ERR, "PT")
                       .NewCheckField(Names.USED_PSTEP_SEND_MAX_SIZE, "PM")
                       .NewCheckField(Names.USED_PSTEP_SECG_ERR, "PB")
                       .NewCheckField(Names.USED_PSTEP_ALLOC_ERR, "PA")
                       .NewCheckField(Names.USED_PSTEP_CONNECT_ERR, "PC")
                       .NewCheckField(Names.USED_PSTEP_XERR, "PD")
                       .NewCheckField(Names.USED_PSTEP_RCV_UA_ERR, "PH")
                       .NewCheckField(Names.USED_PSTEP_RCV_ES_ERR, "PI")
                       .NewCheckField(Names.USED_PSTEP_XFAL, "PJ")
                       .NewCheckField(Names.USED_PSTEP_SETOA_ERR, "PK")
                       .NewCheckField(Names.USED_PSTEP_RCV_VIEW_ERR, "PL")
                       .NewCheckField(Names.USED_PSTEP_DECRYPT_ERR, "PP")
                       ;
                   PSMGR_DASG_DATA.CreateNewField(Names.SAVE_SQLCA, FieldType.String, 255);
               });
               GLOBDATA.CreateNewGroup(Names.PSMGR_DEBUG_DATA, (PSMGR_DEBUG_DATA) =>
               {
                   PSMGR_DEBUG_DATA.CreateNewField(Names.PSMGR_TRACE_ADR, FieldType.CompInt, 9);
                   PSMGR_DEBUG_DATA.CreateNewGroup(Names.LAST_STATEMENT_X, (LAST_STATEMENT_X) =>
                   {
                       LAST_STATEMENT_X.CreateNewField(Names.LAST_STATEMENT_NUM, FieldType.UnsignedNumeric, 10);
                   });
                   PSMGR_DEBUG_DATA.CreateNewField(Names.CUR_AB_ID, FieldType.String, 10);
                   PSMGR_DEBUG_DATA.CreateNewField(Names.CUR_AB_NAME, FieldType.String, 32);
               });
               GLOBDATA.CreateNewField(Names.PSMGR_TIRDATE_SAVEAREA, FieldType.String, 12);
               GLOBDATA.CreateNewGroup(Names.PSMGR_TIRDATE_CMCB, (PSMGR_TIRDATE_CMCB) =>
               {
                   PSMGR_TIRDATE_CMCB.CreateNewField(Names.PSMGR_TIRDATE_DATE, FieldType.CompInt, 9);
                   PSMGR_TIRDATE_CMCB.CreateNewField(Names.PSMGR_TIRDATE_TIME, FieldType.CompInt, 9);
                   PSMGR_TIRDATE_CMCB.CreateNewFillerField(8, FillWith.Hashes);
                   PSMGR_TIRDATE_CMCB.CreateNewField(Names.PSMGR_TIRDATE_INC, FieldType.CompInt, 9);
                   PSMGR_TIRDATE_CMCB.CreateNewField(Names.PSMGR_TIRDATE_RC, FieldType.CompShort, 4)
                       .NewCheckField(Names.PSMGR_TIRDATE_OK, +0)
                       .NewCheckField(Names.PSMGR_TIRDATE_WARNING, +4)
                       .NewCheckField(Names.PSMGR_TIRDATE_ERROR, +8)
                       ;
                   PSMGR_TIRDATE_CMCB.CreateNewField(Names.PSMGR_TIRDATE_REQ, FieldType.UnsignedNumeric, 1);
                   PSMGR_TIRDATE_CMCB.CreateNewField(Names.PSMGR_TIRDATE_DATEF, FieldType.UnsignedNumeric, 1);
                   PSMGR_TIRDATE_CMCB.CreateNewField(Names.PSMGR_TIRDATE_TIMEF, FieldType.UnsignedNumeric, 1);
                   PSMGR_TIRDATE_CMCB.CreateNewField(Names.PSMGR_TIRDATE_RETMSG, FieldType.String, 60);

                   IField PSMGR_TIRDATE_TSTAMP_local = PSMGR_TIRDATE_CMCB.CreateNewField(Names.PSMGR_TIRDATE_TSTAMP, FieldType.String, 20);
                   PSMGR_TIRDATE_CMCB.CreateNewGroupRedefine("FILLER_d20", PSMGR_TIRDATE_TSTAMP_local, (FILLER_d20) =>
                   {
                       FILLER_d20.CreateNewField(Names.PSMGR_TIRDATE_DATE_Z, FieldType.UnsignedNumeric, 8);
                       FILLER_d20.CreateNewField(Names.PSMGR_TIRDATE_TIME_Z, FieldType.UnsignedNumeric, 8);
                       FILLER_d20.CreateNewFillerField(4, FillWith.Hashes);
                   });
                   PSMGR_TIRDATE_CMCB.CreateNewField(Names.PSMGR_TIRDATE_SKIP_VAL, FieldType.String, 1);
                   PSMGR_TIRDATE_CMCB.CreateNewFillerField(95, FillWith.Hashes);
               });
               GLOBDATA.CreateNewField(Names.PSMGR_ROLLBACK_RQSTED, FieldType.String, 1)
                   .NewCheckField(Names.ROLLBACK_RQSTED, "R")
                   .NewCheckField(Names.ABEND_RQSTED, "A")
                   .NewCheckField(Names.TERMINATE_RQSTED, "T")
                   ;
               GLOBDATA.CreateNewGroup(Names.TIRTRCE_SAVE_AREA, (TIRTRCE_SAVE_AREA) =>
               {
                   TIRTRCE_SAVE_AREA.CreateNewField(Names.TOP_INDX, FieldType.CompInt, 9);
                   TIRTRCE_SAVE_AREA.CreateNewField(Names.BOTTOM_INDX, FieldType.CompInt, 9);
                   TIRTRCE_SAVE_AREA.CreateNewField(Names.END_INDX, FieldType.CompInt, 9);
                   TIRTRCE_SAVE_AREA.CreateNewField(Names.LAST_STMT, FieldType.CompInt, 9);
                   TIRTRCE_SAVE_AREA.CreateNewField(Names.TOP_OF_CALL, FieldType.CompInt, 9);
                   TIRTRCE_SAVE_AREA.CreateNewField(Names.TRACE_BREAK_POINT, FieldType.CompInt, 9);
                   TIRTRCE_SAVE_AREA.CreateNewField(Names.TRACE_BREAK_POINT_STATUS, FieldType.String, 3);
                   TIRTRCE_SAVE_AREA.CreateNewField(Names.LAST_AB_NAME, FieldType.String, 32);
                   TIRTRCE_SAVE_AREA.CreateNewField(Names.COLOR, FieldType.String, 15);
                   TIRTRCE_SAVE_AREA.CreateNewField(Names.COLORT, FieldType.String, 15);
                   TIRTRCE_SAVE_AREA.CreateNewField(Names.HILITE, FieldType.String, 15);
                   TIRTRCE_SAVE_AREA.CreateNewField(Names.TRACE_ON_OFF, FieldType.String, 3);
               });
               GLOBDATA.CreateNewGroup(Names.CASCADE_DELETE_FLAGS, (CASCADE_DELETE_FLAGS) =>
               {
                   CASCADE_DELETE_FLAGS.CreateNewField(Names.V1PRESENT, FieldType.String, 1);
                   CASCADE_DELETE_FLAGS.CreateNewField(Names.V2PRESENT, FieldType.String, 1);
                   CASCADE_DELETE_FLAGS.CreateNewField(Names.CASCADE1, FieldType.String, 1);
                   CASCADE_DELETE_FLAGS.CreateNewField(Names.CASCADE2, FieldType.String, 1);
                   CASCADE_DELETE_FLAGS.CreateNewField(Names.PROCESSQ_FLAG, FieldType.String, 1);
               });
               GLOBDATA.CreateNewGroup(Names.PSMGR_ACTIVE_DIALECT, (PSMGR_ACTIVE_DIALECT) =>
               {
                   PSMGR_ACTIVE_DIALECT.CreateNewField(Names.DIALECT_NAME, FieldType.String, 8);
                   PSMGR_ACTIVE_DIALECT.CreateNewField(Names.MESSAGE_TABLE_NAME, FieldType.String, 8);
                   PSMGR_ACTIVE_DIALECT.CreateNewField(Names.TRANSLATE_TABLE_NAME, FieldType.String, 8);
               });
               GLOBDATA.CreateNewGroup(Names.PSMGR_FUNCTION_DATA_EXT, (PSMGR_FUNCTION_DATA_EXT) =>
               {
                   PSMGR_FUNCTION_DATA_EXT.CreateNewField(Names.PSMGR_FUNC_IN_TIMESTAMP, FieldType.String, 20);
                   PSMGR_FUNCTION_DATA_EXT.CreateNewGroup(Names.PSMGR_FUNC_IN_TSDURA, (PSMGR_FUNC_IN_TSDURA) =>
                   {
                       PSMGR_FUNC_IN_TSDURA.CreateNewGroup(Names.TSDURA_MICROSECOND, (TSDURA_MICROSECOND) =>
                       {
                           TSDURA_MICROSECOND.CreateNewField(Names.TSDURA_M_MISS, FieldType.String, 1);
                           TSDURA_MICROSECOND.CreateNewField(Names.TSDURA_MS, FieldType.CompInt, 9);
                       });
                   });
                   PSMGR_FUNCTION_DATA_EXT.CreateNewField(Names.PSMGR_FUNC_OUT_TIMESTAMP, FieldType.String, 20);
               });
               GLOBDATA.CreateNewFillerField(8, FillWith.Hashes);
               GLOBDATA.CreateNewField(Names.PSMGR_CICS_FAIL_SW, FieldType.String, 1)
                   .NewCheckField(Names.INHIBIT_CICS_RECEIVE, "I")
                   ;
               GLOBDATA.CreateNewField(Names.CLIENT_USERID, FieldType.String, 64);
               GLOBDATA.CreateNewField(Names.CLIENT_PASSWORD, FieldType.String, 64);
               GLOBDATA.CreateNewField(Names.LOAD_MODULE_NAME, FieldType.String, 8);
               GLOBDATA.CreateNewField(Names.INSTRUMENT_CODE, FieldType.CompInt, 9);
               GLOBDATA.CreateNewField(Names.TX_RETRY_LIMIT, FieldType.CompInt, 9);
               GLOBDATA.CreateNewField(Names.TX_TIMEOUT, FieldType.CompInt, 9);
               GLOBDATA.CreateNewGroup(Names.PSMGR_EXTRA_ERRINFO, (PSMGR_EXTRA_ERRINFO) =>
               {
                   PSMGR_EXTRA_ERRINFO.CreateNewField(Names.ERRINFO_BUF_SIZE, FieldType.CompInt, 9);
                   PSMGR_EXTRA_ERRINFO.CreateNewField(Names.ERRINFO_MSG_SIZE, FieldType.CompInt, 9);
                   PSMGR_EXTRA_ERRINFO.CreateNewField(Names.ERRINFO_BUF_ADDR, FieldType.String, 8);
               });
               GLOBDATA.CreateNewField(Names.TX_RETRY_COUNT, FieldType.CompInt, 9);
               GLOBDATA.CreateNewField(Names.TX_USER_RETRY_ALLOWED, FieldType.String, 1);
               GLOBDATA.CreateNewFillerField(3, FillWith.Hashes);
               GLOBDATA.CreateNewGroup(Names.PSMGR_PSTEP_USE_PTRS, (PSMGR_PSTEP_USE_PTRS) =>
               {
                   PSMGR_PSTEP_USE_PTRS.CreateNewField(Names.PSTEP_FAIL_MSG_PTR, FieldType.ReferencePointer, 4);
                   PSMGR_PSTEP_USE_PTRS.CreateNewField(Names.PSTEP_GURB_REST_PTR, FieldType.ReferencePointer, 4);
                   PSMGR_PSTEP_USE_PTRS.CreateNewField(Names.PSTEP_LIPS_PTR, FieldType.ReferencePointer, 4);
                   PSMGR_PSTEP_USE_PTRS.CreateNewField(Names.PSTEP_TBL_PTR, FieldType.ReferencePointer, 4);
                   PSMGR_PSTEP_USE_PTRS.CreateNewField(Names.PSTEP_DDF_PTR, FieldType.ReferencePointer, 4);
                   PSMGR_PSTEP_USE_PTRS.CreateNewField(Names.PSTEP_COMM_ID, FieldType.String, 8);
                   PSMGR_PSTEP_USE_PTRS.CreateNewField(Names.PSTEP_APPL_LIST_PTR, FieldType.ReferencePointer, 4);
                   PSMGR_PSTEP_USE_PTRS.CreateNewField(Names.PSTEP_CURR_PST_PTR, FieldType.ReferencePointer, 4);
               });
               GLOBDATA.CreateNewGroup(Names.PSMGR_PSTEP_USE_SYSFLDS, (PSMGR_PSTEP_USE_SYSFLDS) =>
               {
                   PSMGR_PSTEP_USE_SYSFLDS.CreateNewField(Names.PSMGR_EIBERRCD, FieldType.String, 4);
                   PSMGR_PSTEP_USE_SYSFLDS.CreateNewField(Names.PSMGR_EIBFN, FieldType.String, 2);
                   PSMGR_PSTEP_USE_SYSFLDS.CreateNewField(Names.PSMGR_EIBRESP, FieldType.String, 8);
                   PSMGR_PSTEP_USE_SYSFLDS.CreateNewField(Names.PSMGR_EIBRESP2, FieldType.String, 8);
               });
               GLOBDATA.CreateNewFillerField(199, FillWith.Hashes);
           });

            recordDef.CreateNewGroup(Names.IMPORT_0001EV, (IMPORT_0001EV) =>
           {
               IMPORT_0001EV.CreateNewGroup(Names.EAB_FILE_HANDLING_0001ET, (EAB_FILE_HANDLING_0001ET) =>
               {
                   EAB_FILE_HANDLING_0001ET.CreateNewField(Names.ACTION_0001AS, FieldType.String, 1);

                   IField ACTION_0001_local = EAB_FILE_HANDLING_0001ET.CreateNewField(Names.ACTION_0001, FieldType.String, 8);
                   EAB_FILE_HANDLING_0001ET.CreateNewFieldRedefine(Names.ACTION_0001XX, FieldType.String, ACTION_0001_local, 8);
               });
           });

            recordDef.CreateNewGroup(Names.EXPORT_0002EV, (EXPORT_0002EV) =>
           {
               EXPORT_0002EV.CreateNewGroup(Names.CSE_PERSON_0002ET, (CSE_PERSON_0002ET) =>
               {
                   CSE_PERSON_0002ET.CreateNewField(Names.NUMBER_0002AS, FieldType.String, 1);

                   IField NUMBER_0002_local = CSE_PERSON_0002ET.CreateNewField(Names.NUMBER_0002, FieldType.String, 10);
                   CSE_PERSON_0002ET.CreateNewFieldRedefine(Names.NUMBER_0002XX, FieldType.String, NUMBER_0002_local, 10);
               });
           });

            recordDef.CreateNewGroup(Names.EXPORT_0003EV, (EXPORT_0003EV) =>
           {
               EXPORT_0003EV.CreateNewGroup(Names.IM_HOUSEHOLD_0003ET, (IM_HOUSEHOLD_0003ET) =>
               {
                   IM_HOUSEHOLD_0003ET.CreateNewField(Names.AE_CASE_NO_0003AS, FieldType.String, 1);

                   IField AE_CASE_NO_0003_local = IM_HOUSEHOLD_0003ET.CreateNewField(Names.AE_CASE_NO_0003, FieldType.String, 8);
                   IM_HOUSEHOLD_0003ET.CreateNewFieldRedefine(Names.AE_CASE_NO_0003XX, FieldType.String, AE_CASE_NO_0003_local, 8);
               });
           });

            recordDef.CreateNewGroup(Names.EXPORT_0004EV, (EXPORT_0004EV) =>
           {
               EXPORT_0004EV.CreateNewGroup(Names.IM_HOUSEHOLD_MBR_MNTHLY_0004ET, (IM_HOUSEHOLD_MBR_MNTHLY_0004ET) =>
               {
                   IM_HOUSEHOLD_MBR_MNTHLY_0004ET.CreateNewField(Names.YEAR_0004AS, FieldType.String, 1);

                   IField YEAR_0004_local = IM_HOUSEHOLD_MBR_MNTHLY_0004ET.CreateNewField(Names.YEAR_0004, FieldType.SignedNumeric, 4);
                   IM_HOUSEHOLD_MBR_MNTHLY_0004ET.CreateNewFieldRedefine(Names.YEAR_0004XX, FieldType.String, YEAR_0004_local, 4);
                   IM_HOUSEHOLD_MBR_MNTHLY_0004ET.CreateNewField(Names.MONTH_0004AS, FieldType.String, 1);

                   IField MONTH_0004_local = IM_HOUSEHOLD_MBR_MNTHLY_0004ET.CreateNewField(Names.MONTH_0004, FieldType.SignedNumeric, 2);
                   IM_HOUSEHOLD_MBR_MNTHLY_0004ET.CreateNewFieldRedefine(Names.MONTH_0004XX, FieldType.String, MONTH_0004_local, 2);
                   IM_HOUSEHOLD_MBR_MNTHLY_0004ET.CreateNewField(Names.RELATIONSHIP_0004AS, FieldType.String, 1);

                   IField RELATIONSHIP_0004_local = IM_HOUSEHOLD_MBR_MNTHLY_0004ET.CreateNewField(Names.RELATIONSHIP_0004, FieldType.String, 2);
                   IM_HOUSEHOLD_MBR_MNTHLY_0004ET.CreateNewFieldRedefine(Names.RELATIONSHIP_0004XX, FieldType.String, RELATIONSHIP_0004_local, 2);
                   IM_HOUSEHOLD_MBR_MNTHLY_0004ET.CreateNewField(Names.GRANT_AMOUNT_0004AS, FieldType.String, 1);

                   IField GRANT_AMOUNT_0004_local = IM_HOUSEHOLD_MBR_MNTHLY_0004ET.CreateNewField(Names.GRANT_AMOUNT_0004, FieldType.SignedNumeric, 9, null, 2);
                   IM_HOUSEHOLD_MBR_MNTHLY_0004ET.CreateNewFieldRedefine(Names.GRANT_AMOUNT_0004XX, FieldType.String, GRANT_AMOUNT_0004_local, 9);
               });
           });

            recordDef.CreateNewGroup(Names.EXPORT_PROGRAM_TYPE_0005EV, (EXPORT_PROGRAM_TYPE_0005EV) =>
           {
               EXPORT_PROGRAM_TYPE_0005EV.CreateNewGroup(Names.WORK_AREA_0005ET, (WORK_AREA_0005ET) =>
               {
                   WORK_AREA_0005ET.CreateNewField(Names.TEXT_2_0005AS, FieldType.String, 1);

                   IField TEXT_2_0005_local = WORK_AREA_0005ET.CreateNewField(Names.TEXT_2_0005, FieldType.String, 2);
                   WORK_AREA_0005ET.CreateNewFieldRedefine(Names.TEXT_2_0005XX, FieldType.String, TEXT_2_0005_local, 2);
               });
           });

            recordDef.CreateNewGroup(Names.EXPORT_ISSUE_TYPE_0006EV, (EXPORT_ISSUE_TYPE_0006EV) =>
           {
               EXPORT_ISSUE_TYPE_0006EV.CreateNewGroup(Names.WORK_AREA_0006ET, (WORK_AREA_0006ET) =>
               {
                   WORK_AREA_0006ET.CreateNewField(Names.TEXT_2_0006AS, FieldType.String, 1);

                   IField TEXT_2_0006_local = WORK_AREA_0006ET.CreateNewField(Names.TEXT_2_0006, FieldType.String, 2);
                   WORK_AREA_0006ET.CreateNewFieldRedefine(Names.TEXT_2_0006XX, FieldType.String, TEXT_2_0006_local, 2);
               });
           });

            recordDef.CreateNewGroup(Names.EXPORT_0007EV, (EXPORT_0007EV) =>
           {
               EXPORT_0007EV.CreateNewGroup(Names.EAB_FILE_HANDLING_0007ET, (EAB_FILE_HANDLING_0007ET) =>
               {
                   EAB_FILE_HANDLING_0007ET.CreateNewField(Names.STATUS_0007AS, FieldType.String, 1);

                   IField STATUS_0007_local = EAB_FILE_HANDLING_0007ET.CreateNewField(Names.STATUS_0007, FieldType.String, 8);
                   EAB_FILE_HANDLING_0007ET.CreateNewFieldRedefine(Names.STATUS_0007XX, FieldType.String, STATUS_0007_local, 8);
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
            SetPassedParm(GLOBDATA, args, 2);
            SetPassedParm(IMPORT_0001EV, args, 3);
            SetPassedParm(EXPORT_0002EV, args, 4);
            SetPassedParm(EXPORT_0003EV, args, 5);
            SetPassedParm(EXPORT_0004EV, args, 6);
            SetPassedParm(EXPORT_PROGRAM_TYPE_0005EV, args, 7);
            SetPassedParm(EXPORT_ISSUE_TYPE_0006EV, args, 8);
            SetPassedParm(EXPORT_0007EV, args, 9);
        }


        public void UpdateReturnParameters(object[] args)
        {
            SetReturnParm(IEF_RUNTIME_PARM1, args, 0);
            SetReturnParm(IEF_RUNTIME_PARM2, args, 1);
            SetReturnParm(GLOBDATA, args, 2);
            SetReturnParm(IMPORT_0001EV, args, 3);
            SetReturnParm(EXPORT_0002EV, args, 4);
            SetReturnParm(EXPORT_0003EV, args, 5);
            SetReturnParm(EXPORT_0004EV, args, 6);
            SetReturnParm(EXPORT_PROGRAM_TYPE_0005EV, args, 7);
            SetReturnParm(EXPORT_ISSUE_TYPE_0006EV, args, 8);
            SetReturnParm(EXPORT_0007EV, args, 9);
        }
    }
    #endregion Linkage Section Class

    #region Business Logic Class
    public class SWEXOE05 : EABBase
    {

        #region Public Constructors
        public SWEXOE05()
            : base()
        {
            this.ProgramName.SetValue("SWEXOE05");

            WS = new SWEXOE05_ws();
            FD = new SWEXOE05_fd();
            LS = new SWEXOE05_ls();
        }

        #endregion

        #region Private Fields


        //==== Working Storage Data Class ========================================
        private SWEXOE05_ws WS;

        //==== File Data Class ========================================
        private SWEXOE05_fd FD;

        //==== Linkage Section Data Class ========================================
        private SWEXOE05_ls LS;
        #endregion

        #region Public Methods
        //========================================================================
        //==== RunMain Entry Point Method ========================================
        //========================================================================
        public override int ExecuteMain(params object[] args)                                              //COBOL==> PROCEDURE DIVISION USING IEF-RUNTIME-PARM1 , IEF-RUNTIME-PARM2 , GLOBDATA , IMPORT-0001EV , EXPORT-0002EV , EXPORT-0003EV , EXPORT-0004EV , EXPORT-PROGRAM-TYPE-0005EV , EXPORT-ISSUE-TYPE-0006EV , EXPORT-0007EV.
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
            M_MAIN_0156503770(returnMethod);
        }
        /// <summary>
        /// Method M_MAIN_0156503770
        /// </summary>
        private void M_MAIN_0156503770(string returnMethod = "")
        {
            M_PARA_0156503770_INIT("M_PARA_0156503770_INIT_EXIT"); if (Control.ExitProgram) { return; }           //COBOL==> PERFORM PARA-0156503770-INIT THRU PARA-0156503770-INIT-EXIT
            M_PARA_0156503770("M_PARA_0156503770_EXIT"); if (Control.ExitProgram) { return; }                     //COBOL==> PERFORM PARA-0156503770 THRU PARA-0156503770-EXIT
            Control.ExitProgram = true; return;                                                                 //COBOL==> GOBACK.
        }
        /// <summary>
        /// Method M_PARA_0156503770
        /// </summary>
        private void M_PARA_0156503770(string returnMethod = "")
        {
            LS.STATUS_0007.SetValue("OK");                                                                      //COBOL==> MOVE 'OK' TO STATUS-0007.
                                                                                                                // EvaluateList !LS.ACTION_0001!                                                                    //COBOL==> EVALUATE ACTION-0001
            if ((LS.ACTION_0001.IsEqualTo("OPEN")))                                                             //COBOL==> WHEN 'OPEN'
            {
                M_0100_INITIALIZE_AND_OPEN("M_0100_EXIT"); if (Control.ExitProgram) { return; }                       //COBOL==> PERFORM 0100-INITIALIZE-AND-OPEN THRU 0100-EXIT
            }                                                                                                //COBOL==> WHEN 'CONTROL1'
            else
            if ((LS.ACTION_0001.IsEqualTo("CONTROL1")))
            {
                M_0200_PROCESS_CONTROLS("M_0200_EXIT"); if (Control.ExitProgram) { return; }                          //COBOL==> PERFORM 0200-PROCESS-CONTROLS THRU 0200-EXIT
            }                                                                                                //COBOL==> WHEN 'READ'
            else
            if ((LS.ACTION_0001.IsEqualTo("READ")))
            {
                M_0400_MAIN("M_0400_EXIT"); if (Control.ExitProgram) { return; }                                      //COBOL==> PERFORM 0400-MAIN THRU 0400-EXIT
            }                                                                                                //COBOL==> WHEN 'CONTROL2'
            else
            if ((LS.ACTION_0001.IsEqualTo("CONTROL2")))
            {
                M_0800_WRITE_CONTROLS("M_0800_EXIT"); if (Control.ExitProgram) { return; }                            //COBOL==> PERFORM 0800-WRITE-CONTROLS THRU 0800-EXIT
            }                                                                                                //COBOL==> WHEN 'CLOSE'
            else
            if ((LS.ACTION_0001.IsEqualTo("CLOSE")))
            {
                M_0900_CLOSE("M_0900_EXIT"); if (Control.ExitProgram) { return; }                                     //COBOL==> PERFORM 0900-CLOSE THRU 0900-EXIT
            }                                                                                                //COBOL==> WHEN OTHER
            else
            {
                DisplayToLog("INVALID ACTION: " + LS.ACTION_0001.AsString());                                       //COBOL==> DISPLAY 'INVALID ACTION: ' ACTION-0001
                LS.STATUS_0007.SetValue("ABEND");                                                                   //COBOL==> MOVE 'ABEND' TO STATUS-0007
            }                                                                                                   //COBOL==> END-EVALUATE .
            if (returnMethod != "" && returnMethod != "M_PARA_0156503770") { M_PARA_0156503770_EXIT(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_PARA_0156503770_EXIT
        /// </summary>
        private void M_PARA_0156503770_EXIT(string returnMethod = "")
        {
            if (returnMethod == "M_PARA_0156503770_EXIT") { return; }                                           //COBOL==> EXIT.
            if (returnMethod != "" && returnMethod != "M_PARA_0156503770_EXIT") { M_0100_INITIALIZE_AND_OPEN(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_0100_INITIALIZE_AND_OPEN
        /// </summary>
        private void M_0100_INITIALIZE_AND_OPEN(string returnMethod = "")
        {
            FD.BENEFITS_FILE.OpenFile(FileAccessMode.Read);                                                     //COBOL==> OPEN INPUT BENEFITS-FILE I-O CONTROL-FILE.
            FD.CONTROL_FILE.OpenFile(FileAccessMode.ReadWrite);
            if (returnMethod != "" && returnMethod != "M_0100_INITIALIZE_AND_OPEN") { M_0100_EXIT(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_0100_EXIT
        /// </summary>
        private void M_0100_EXIT(string returnMethod = "")
        {
            if (returnMethod == "M_0100_EXIT") { return; }                                                      //COBOL==> EXIT.
            if (returnMethod != "" && returnMethod != "M_0100_EXIT") { M_0200_PROCESS_CONTROLS(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_0200_PROCESS_CONTROLS
        /// </summary>
        private void M_0200_PROCESS_CONTROLS(string returnMethod = "")
        {
            M_0300_READ_BENEFITS("M_0300_EXIT"); if (Control.ExitProgram) { return; }                             //COBOL==> PERFORM 0300-READ-BENEFITS THRU 0300-EXIT.
            WS.WS_CONTROL_REC.SetValue(FD.CONTROL_FILE.ReadLineInto());                                         //COBOL==> READ CONTROL-FILE INTO WS-CONTROL-REC
            if (FD.CONTROL_FILE.FileStatus == FileStatus.End_of_file)                                           //COBOL==> AT END
            {
                DisplayToLog("CONTROL FILE IS EMPTY");                                                              //COBOL==> DISPLAY 'CONTROL FILE IS EMPTY'
                LS.STATUS_0007.SetValue("ABEND");                                                                   //COBOL==> MOVE 'ABEND' TO STATUS-0007
                M_0200_EXIT(CheckGotoReturn(returnMethod)); return;                                                 //COBOL==> GO TO 0200-EXIT.
            }
            if (WS.WS_EOF.IsEqualTo("Y"))                                                                       //COBOL==> IF WS-EOF = 'Y'
            {
                LS.STATUS_0007.SetValue("EOF");                                                                     //COBOL==> MOVE 'EOF' TO STATUS-0007
                M_0200_EXIT(CheckGotoReturn(returnMethod)); return;                                                 //COBOL==> GO TO 0200-EXIT
            }                                                                                                   //COBOL==> END-IF.
            if (!(WS.WS_REC_TYPE_TWO.IsEqualTo("2")))                                                           //COBOL==> IF WS-REC-TYPE-TWO NOT EQUAL '2'
            {
                DisplayToLog("TRAILER RECORD MISSING FROM GRANT FILE");                                             //COBOL==> DISPLAY 'TRAILER RECORD MISSING FROM GRANT FILE'
                LS.STATUS_0007.SetValue("ABEND");                                                                   //COBOL==> MOVE 'ABEND' TO STATUS-0007
            }                                                                                                   //COBOL==> END-IF.
            if (WS.WSCR_FILE_DATE_YYYYMMDD.IsGreaterThan(WS.WS_FILE_DATE_YYYYMMDD))                             //COBOL==> IF WSCR-FILE-DATE-YYYYMMDD IS GREATER THAN WS-FILE-DATE-YYYYMMDD
            {
                DisplayToLog("FILE DATE INDICATES OLD INPUT FILE");                                                 //COBOL==> DISPLAY 'FILE DATE INDICATES OLD INPUT FILE'
                LS.STATUS_0007.SetValue("ABEND");                                                                   //COBOL==> MOVE 'ABEND' TO STATUS-0007
            }                                                                                                   //COBOL==> END-IF.
            if (((WS.WS_RECORD_COUNT.IsEqualTo(WS.WSCR_RECORD_COUNT))
             && (WS.WS_RECORD_COUNT.IsGreaterThan(ZEROS)))
             && (WS.WS_BENEFIT_TOT_AMT.IsEqualTo(WS.WSCR_BENEFIT_TOT_AMT)))  //COBOL==> IF WS-RECORD-COUNT = WSCR-RECORD-COUNT AND WS-RECORD-COUNT GREATER THAN ZERO AND WS-BENEFIT-TOT-AMT = WSCR-BENEFIT-TOT-AMT
            {
                DisplayToLog("RECORD COUNT INDICATES DUPLICATE FILE");                                              //COBOL==> DISPLAY 'RECORD COUNT INDICATES DUPLICATE FILE'
                LS.STATUS_0007.SetValue("ABEND");                                                                   //COBOL==> MOVE 'ABEND' TO STATUS-0007
            }                                                                                                   //COBOL==> END-IF.
            WS.WS_CONTROL_REC.SetValue(WS.WS_TOTALS_REC);                                                       //COBOL==> MOVE WS-TOTALS-REC TO WS-CONTROL-REC.
            if (returnMethod != "" && returnMethod != "M_0200_PROCESS_CONTROLS") { M_0200_EXIT(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_0200_EXIT
        /// </summary>
        private void M_0200_EXIT(string returnMethod = "")
        {
            if (returnMethod == "M_0200_EXIT") { return; }                                                      //COBOL==> EXIT.
            if (returnMethod != "" && returnMethod != "M_0200_EXIT") { M_0300_READ_BENEFITS(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_0300_READ_BENEFITS
        /// </summary>
        private void M_0300_READ_BENEFITS(string returnMethod = "")
        {
            WS.WS_BENEFITS_REC.SetValue(FD.BENEFITS_FILE.ReadLineInto());                                       //COBOL==> READ BENEFITS-FILE INTO WS-BENEFITS-REC
            if (FD.BENEFITS_FILE.FileStatus == FileStatus.End_of_file)                                          //COBOL==> AT END
            {
                WS.WS_EOF.SetValue("Y");                                                                            //COBOL==> MOVE 'Y' TO WS-EOF.
            }
            if (returnMethod != "" && returnMethod != "M_0300_READ_BENEFITS") { M_0300_EXIT(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_0300_EXIT
        /// </summary>
        private void M_0300_EXIT(string returnMethod = "")
        {
            if (returnMethod == "M_0300_EXIT") { return; }                                                      //COBOL==> EXIT.
            if (returnMethod != "" && returnMethod != "M_0300_EXIT") { M_0400_MAIN(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_0400_MAIN
        /// </summary>
        private void M_0400_MAIN(string returnMethod = "")
        {
            M_0300_READ_BENEFITS("M_0300_EXIT"); if (Control.ExitProgram) { return; }                             //COBOL==> PERFORM 0300-READ-BENEFITS THRU 0300-EXIT.
            if (WS.WS_EOF.IsEqualTo("Y"))                                                                       //COBOL==> IF WS-EOF = 'Y'
            {
                LS.STATUS_0007.SetValue("EOF");                                                                     //COBOL==> MOVE 'EOF' TO STATUS-0007
                M_0400_EXIT(CheckGotoReturn(returnMethod)); return;                                                 //COBOL==> GO TO 0400-EXIT
            }                                                                                                   //COBOL==> END-IF.
                                                                                                                // EvaluateList !WS.WS_REC_TYPE!                                                                    //COBOL==> EVALUATE WS-REC-TYPE
            if ((WS.WS_REC_TYPE.IsEqualTo("1")))                                                                //COBOL==> WHEN '1'
            {
                M_0500_MOVE("M_0500_EXIT"); if (Control.ExitProgram) { return; }                                      //COBOL==> PERFORM 0500-MOVE THRU 0500-EXIT
            }                                                                                                //COBOL==> WHEN '2'
            else
            if ((WS.WS_REC_TYPE.IsEqualTo("2")))
            {
                M_0400_EXIT(CheckGotoReturn(returnMethod)); return;                                                 //COBOL==> GO TO 0400-EXIT
            }                                                                                                //COBOL==> WHEN OTHER
            else
            {
                DisplayToLog("INVALID RECORD TYPE: " + WS.WS_REC_TYPE.AsString());                                  //COBOL==> DISPLAY 'INVALID RECORD TYPE: ' WS-REC-TYPE
                LS.STATUS_0007.SetValue("ABEND");                                                                   //COBOL==> MOVE 'ABEND' TO STATUS-0007
            }                                                                                                   //COBOL==> END-EVALUATE.
            if (returnMethod != "" && returnMethod != "M_0400_MAIN") { M_0400_EXIT(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_0400_EXIT
        /// </summary>
        private void M_0400_EXIT(string returnMethod = "")
        {
            if (returnMethod == "M_0400_EXIT") { return; }                                                      //COBOL==> EXIT.
            if (returnMethod != "" && returnMethod != "M_0400_EXIT") { M_0500_MOVE(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_0500_MOVE
        /// </summary>
        private void M_0500_MOVE(string returnMethod = "")
        {
            WS.WS_ACTUAL_COUNT.SetComputeValue(WS.WS_ACTUAL_COUNT.AsDecimal() + 1m);                            //COBOL==> COMPUTE WS-ACTUAL-COUNT = ( WS-ACTUAL-COUNT + 1 ) .
            WS.WS_ACTUAL_AMOUNT.SetComputeValue(WS.WS_ACTUAL_AMOUNT.AsDecimal() + WS.WS_BENEFIT_AMOUNT.AsDecimal());  //COBOL==> COMPUTE WS-ACTUAL-AMOUNT = ( WS-ACTUAL-AMOUNT + WS-BENEFIT-AMOUNT ) .
            LS.AE_CASE_NO_0003.SetValue(WS.WS_CASE_NUMBER);                                                     //COBOL==> MOVE WS-CASE-NUMBER TO AE-CASE-NO-0003.
            LS.TEXT_2_0005.SetValue(WS.WS_PROGRAM_TYPE);                                                        //COBOL==> MOVE WS-PROGRAM-TYPE TO TEXT-2-0005.
            LS.TEXT_2_0006.SetValue(WS.WS_ISSUE_TYPE);                                                          //COBOL==> MOVE WS-ISSUE-TYPE TO TEXT-2-0006.
            LS.YEAR_0004.SetValue(WS.WS_BENEFIT_YYYY);                                                          //COBOL==> MOVE WS-BENEFIT-YYYY TO YEAR-0004.
            LS.MONTH_0004.SetValue(WS.WS_BENEFIT_MM);                                                           //COBOL==> MOVE WS-BENEFIT-MM TO MONTH-0004.
            LS.GRANT_AMOUNT_0004.SetValue(WS.WS_BENEFIT_AMOUNT);                                                //COBOL==> MOVE WS-BENEFIT-AMOUNT TO GRANT-AMOUNT-0004.
            LS.NUMBER_0002.SetValue(WS.WS_PERSON_NUMBER);                                                       //COBOL==> MOVE WS-PERSON-NUMBER TO NUMBER-0002.
            LS.RELATIONSHIP_0004.SetValue(WS.WS_RELATIONSHIP);                                                  //COBOL==> MOVE WS-RELATIONSHIP TO RELATIONSHIP-0004.
            if (returnMethod != "" && returnMethod != "M_0500_MOVE") { M_0500_EXIT(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_0500_EXIT
        /// </summary>
        private void M_0500_EXIT(string returnMethod = "")
        {
            if (returnMethod == "M_0500_EXIT") { return; }                                                      //COBOL==> EXIT.
            if (returnMethod != "" && returnMethod != "M_0500_EXIT") { M_0800_WRITE_CONTROLS(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_0800_WRITE_CONTROLS
        /// </summary>
        private void M_0800_WRITE_CONTROLS(string returnMethod = "")
        {
            if ((WS.WS_ACTUAL_COUNT.IsEqualTo(WS.WSCR_RECORD_COUNT))
             && (WS.WS_ACTUAL_AMOUNT.IsEqualTo(WS.WSCR_BENEFIT_TOT_AMT)))  //COBOL==> IF WS-ACTUAL-COUNT = WSCR-RECORD-COUNT AND WS-ACTUAL-AMOUNT = WSCR-BENEFIT-TOT-AMT
            {
                FD.CONTROL_FILE.RewriteLine(WS.WS_CONTROL_REC.AsString());                                          //COBOL==> REWRITE CONTROL-REC FROM WS-CONTROL-REC
            }                                                                                                   //COBOL==> ELSE
            else
            {
                DisplayToLog("FILE OUT OF BALANCE");                                                                //COBOL==> DISPLAY 'FILE OUT OF BALANCE'
                DisplayToLog("RECORDS READ : " + WS.WS_ACTUAL_COUNT.AsString());                                    //COBOL==> DISPLAY 'RECORDS READ : ' WS-ACTUAL-COUNT
                DisplayToLog("TRAILER COUNT: " + WS.WSCR_RECORD_COUNT.AsString());                                  //COBOL==> DISPLAY 'TRAILER COUNT: ' WSCR-RECORD-COUNT
                DisplayToLog(" ");                                                                                  //COBOL==> DISPLAY ' '
                DisplayToLog("FILE AMOUNT: " + WS.WS_ACTUAL_AMOUNT.AsString());                                     //COBOL==> DISPLAY 'FILE AMOUNT: ' WS-ACTUAL-AMOUNT
                DisplayToLog("TRAILER AMT: " + WS.WSCR_BENEFIT_TOT_AMT.AsString());                                 //COBOL==> DISPLAY 'TRAILER AMT: ' WSCR-BENEFIT-TOT-AMT
                LS.STATUS_0007.SetValue("ABEND");                                                                   //COBOL==> MOVE 'ABEND' TO STATUS-0007
            }                                                                                                   //COBOL==> END-IF.
            if (returnMethod != "" && returnMethod != "M_0800_WRITE_CONTROLS") { M_0800_EXIT(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_0800_EXIT
        /// </summary>
        private void M_0800_EXIT(string returnMethod = "")
        {
            if (returnMethod == "M_0800_EXIT") { return; }                                                      //COBOL==> EXIT.
            if (returnMethod != "" && returnMethod != "M_0800_EXIT") { M_0900_CLOSE(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_0900_CLOSE
        /// </summary>
        private void M_0900_CLOSE(string returnMethod = "")
        {
            FD.BENEFITS_FILE.CloseFile();                                                                       //COBOL==> CLOSE BENEFITS-FILE CONTROL-FILE.
            FD.CONTROL_FILE.CloseFile();
            if (returnMethod != "" && returnMethod != "M_0900_CLOSE") { M_0900_EXIT(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_0900_EXIT
        /// </summary>
        private void M_0900_EXIT(string returnMethod = "")
        {
            if (returnMethod == "M_0900_EXIT") { return; }                                                      //COBOL==> EXIT.
            if (returnMethod != "" && returnMethod != "M_0900_EXIT") { M_PARA_0156503770_INIT(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_PARA_0156503770_INIT
        /// </summary>
        private void M_PARA_0156503770_INIT(string returnMethod = "")
        {
            LS.EXPORT_0002EV.ResetToInitialValue();                                                             //COBOL==> INITIALIZE EXPORT-0002EV
            LS.EXPORT_0003EV.ResetToInitialValue();                                                             //COBOL==> INITIALIZE EXPORT-0003EV
            LS.EXPORT_0004EV.ResetToInitialValue();                                                             //COBOL==> INITIALIZE EXPORT-0004EV
            LS.EXPORT_PROGRAM_TYPE_0005EV.ResetToInitialValue();                                                //COBOL==> INITIALIZE EXPORT-PROGRAM-TYPE-0005EV
            LS.EXPORT_ISSUE_TYPE_0006EV.ResetToInitialValue();                                                  //COBOL==> INITIALIZE EXPORT-ISSUE-TYPE-0006EV
            LS.EXPORT_0007EV.ResetToInitialValue();                                                             //COBOL==> INITIALIZE EXPORT-0007EV .
            if (returnMethod != "" && returnMethod != "M_PARA_0156503770_INIT") { M_PARA_0156503770_INIT_EXIT(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_PARA_0156503770_INIT_EXIT
        /// </summary>
        private void M_PARA_0156503770_INIT_EXIT(string returnMethod = "")
        {
            if (returnMethod == "M_PARA_0156503770_INIT_EXIT") { return; }                                      //COBOL==> EXIT.
        }
        #endregion
    }
    #endregion
}
