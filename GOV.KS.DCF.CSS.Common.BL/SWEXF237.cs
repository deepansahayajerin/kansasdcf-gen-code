#region Comments
/* Conversion Comments
   ************************************************************
   **   MODERN SYSTEMS INC.  COPYRIGHT 2000-2021
   **   DB-SHUTTLE COBOL to C# Conversion
   ************************************************************
   ** INIT   *  INITIAL VERSION   *  2021-12-07 03:08:47 PM
   **        *   FROM COBOL PGM   :  SWEXF237
   **        *   FROM CANISTER    :  SR.CAECSES.PROD.LIBR.SOURCE.PDS
   ************************************************************ */

/* Original Program Identification Comments
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
    internal class SWEXF237_fd : PredefinedRecordBase
    {
        #region Name constants
        /// <summary>
        /// Name constants.
        /// </summary>
        internal static class Names
        {
            internal const string FileSection = "SWEXF237_fd_FileSection";
            internal const string SEQ_FILE = "SEQ_FILE";
            internal const string SEQFILE_REC = "SEQFILE_REC";
        }
        #endregion

        #region Direct-access element properties
        public IFileLink SEQ_FILE { get; set; }
        public IField SEQFILE_REC { get { return GetElementByName<IField>(Names.SEQFILE_REC); } }


        internal SWEXF237_ws WS;
        #endregion

        #region Data structure definition
        /// <summary>
        /// Defines the entirety of the FileSection IRecord structure as described by the Ateras.Framework.Buffer API.
        /// </summary>
        /// <param name="recordDef">The IStructureDefinition object to be used in defining the record structure.</param>
        protected override void DefineRecordStructure(IStructureDefinition recordDef)
        {
            recordDef.CreateNewField(Names.SEQFILE_REC, FieldType.String, 120);

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

            SEQ_FILE = FileHandler.GetFile("SEQFILE");
            SEQ_FILE.StatusField = WS.WS_FILE_STATUS;
            SEQ_FILE.AssociatedBuffer = SEQFILE_REC;
            SEQ_FILE.RecordLength = 120;
        }
        #endregion

        #region Constructors
        public SWEXF237_fd(SWEXF237_ws ws)
            : base()
        {
            this.WS = ws;
            Initialize();

        }
        #endregion
    }
    #endregion File Section Class
    #region Working Storage Class
    internal class SWEXF237_ws : PredefinedRecordBase
    {
        #region Name constants
        /// <summary>
        /// Name constants.
        /// </summary>
        internal static class Names
        {
            internal const string WorkingStorage = "SWEXF237_ws_WorkingStorage";
            internal const string WS_FILE_STATUS = "WS_FILE_STATUS";
            internal const string WS_WORK_REC = "WS_WORK_REC";
            internal const string WS_TOT_COLL = "WS_TOT_COLL";
            internal const string WS_BAL_OWED = "WS_BAL_OWED";
            internal const string WS_INT_OWED = "WS_INT_OWED";
            internal const string WS_TOT_OS_BAL = "WS_TOT_OS_BAL";
            internal const string WS_PERCENT = "WS_PERCENT";
            internal const string WS_PRIOR_RECOV = "WS_PRIOR_RECOV";
            internal const string WS_OB_CODE = "WS_OB_CODE";
            internal const string WS_NEW_DEBT_CNT = "WS_NEW_DEBT_CNT";
            internal const string WS_NEW_DEBT_TOT = "WS_NEW_DEBT_TOT";
        }
        #endregion

        #region Direct-access element properties
        public IField WS_FILE_STATUS { get { return GetElementByName<IField>(Names.WS_FILE_STATUS); } }
        public IGroup WS_WORK_REC { get { return GetElementByName<IGroup>(Names.WS_WORK_REC); } }
        public IField WS_TOT_COLL { get { return GetElementByName<IField>(Names.WS_TOT_COLL); } }
        public IField WS_BAL_OWED { get { return GetElementByName<IField>(Names.WS_BAL_OWED); } }
        public IField WS_INT_OWED { get { return GetElementByName<IField>(Names.WS_INT_OWED); } }
        public IField WS_TOT_OS_BAL { get { return GetElementByName<IField>(Names.WS_TOT_OS_BAL); } }
        public IField WS_PERCENT { get { return GetElementByName<IField>(Names.WS_PERCENT); } }
        public IField WS_PRIOR_RECOV { get { return GetElementByName<IField>(Names.WS_PRIOR_RECOV); } }
        public IField WS_OB_CODE { get { return GetElementByName<IField>(Names.WS_OB_CODE); } }
        public IField WS_NEW_DEBT_CNT { get { return GetElementByName<IField>(Names.WS_NEW_DEBT_CNT); } }
        public IField WS_NEW_DEBT_TOT { get { return GetElementByName<IField>(Names.WS_NEW_DEBT_TOT); } }

        #endregion

        #region Data structure definition
        /// <summary>
        /// Defines the entirety of the WorkingStorage IRecord structure as described by the Ateras.Framework.Buffer API.
        /// </summary>
        /// <param name="recordDef">The IStructureDefinition object to be used in defining the record structure.</param>
        protected override void DefineRecordStructure(IStructureDefinition recordDef)
        {
            recordDef.CreateNewFillerField(FieldType.String, 27, "WORKING STORAGE STARTS HERE");
            recordDef.CreateNewField(Names.WS_FILE_STATUS, FieldType.String, 2);

            recordDef.CreateNewGroup(Names.WS_WORK_REC, (WS_WORK_REC) =>
           {
               WS_WORK_REC.CreateNewField(Names.WS_TOT_COLL, FieldType.SignedNumeric, 15, null, 2);
               WS_WORK_REC.CreateNewField(Names.WS_BAL_OWED, FieldType.SignedNumeric, 15, null, 2);
               WS_WORK_REC.CreateNewField(Names.WS_INT_OWED, FieldType.SignedNumeric, 15, null, 2);
               WS_WORK_REC.CreateNewField(Names.WS_TOT_OS_BAL, FieldType.SignedNumeric, 15, null, 2);
               WS_WORK_REC.CreateNewField(Names.WS_PERCENT, FieldType.SignedNumeric, 11, null, 2);
               WS_WORK_REC.CreateNewField(Names.WS_PRIOR_RECOV, FieldType.SignedNumeric, 15, null, 2);
               WS_WORK_REC.CreateNewField(Names.WS_OB_CODE, FieldType.String, 7);
               WS_WORK_REC.CreateNewField(Names.WS_NEW_DEBT_CNT, FieldType.SignedNumeric, 9);
               WS_WORK_REC.CreateNewField(Names.WS_NEW_DEBT_TOT, FieldType.SignedNumeric, 15, null, 2);
               WS_WORK_REC.CreateNewFillerField(3, FillWith.Hashes);
           });
            recordDef.CreateNewFillerField(FieldType.String, 25, "WORKING STORAGE ENDS HERE");

        }

        protected override string GetRecordName()
        {
            return Names.WorkingStorage;
        }
        #endregion

    }
    #endregion Working Storage Class

    #region Linkage Section Class
    internal class SWEXF237_ls : PredefinedRecordBase
    {
        #region Name constants
        /// <summary>
        /// Name constants.
        /// </summary>
        internal static class Names
        {
            internal const string LinkageSection = "SWEXF237_ls_LinkageSection";
            internal const string TI_RUNTIME_PARM1 = "TI_RUNTIME_PARM1";
            internal const string TI_RUNTIME_PARM2 = "TI_RUNTIME_PARM2";
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
            internal const string PSTEP_USE_FAILURE = "PSTEP_USE_FAILURE";
            internal const string LAST_STATUS = "LAST_STATUS";
            internal const string DB_ERROR_FL_LS = "DB_ERROR_FL_LS";
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
            internal const string MESSAGE_TABLNK_OUT_NAME = "MESSAGE_TABLNK_OUT_NAME";
            internal const string TRANSLATE_TABLNK_OUT_NAME = "TRANSLATE_TABLNK_OUT_NAME";
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
            internal const string LOAD_MODULNK_OUT_NAME = "LOAD_MODULNK_OUT_NAME";
            internal const string INSTRUMENT_CODE = "INSTRUMENT_CODE";
            internal const string TX_RETRY_LIMIT = "TX_RETRY_LIMIT";
            internal const string TX_TIMEOUT = "TX_TIMEOUT";
            internal const string PSMGR_EXTRA_ERRINFO = "PSMGR_EXTRA_ERRINFO";
            internal const string ERRINFO_BUF_SIZE = "ERRINFO_BUF_SIZE";
            internal const string ERRINFO_MSG_SIZE = "ERRINFO_MSG_SIZE";
            internal const string ERRINFO_BUF_ADDR = "ERRINFO_BUF_ADDR";
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
            internal const string LS_IMP_HI_DTE_V1 = "LS_IMP_HI_DTE_V1";
            internal const string LS_IN_HI_DTE_WRK_AREA_ET = "LS_IN_HI_DTE_WRK_AREA_ET";
            internal const string LS_IN_DTE_01MS = "LS_IN_DTE_01MS";
            internal const string LS_IN_DTE_01XX = "LS_IN_DTE_01XX";
            internal const string LS_IN_DTE_01 = "LS_IN_DTE_01";
            internal const string LS_IMP_LO_DTE_V2 = "LS_IMP_LO_DTE_V2";
            internal const string LS_IN_LO_DTE_WRK_AREA_ET = "LS_IN_LO_DTE_WRK_AREA_ET";
            internal const string LS_IN_DTE_02MS = "LS_IN_DTE_02MS";
            internal const string LS_IN_DTE_02XX = "LS_IN_DTE_02XX";
            internal const string LS_IN_DTE_02 = "LS_IN_DTE_02";
            internal const string LS_IMP_RPT_LIT_V3 = "LS_IMP_RPT_LIT_V3";
            internal const string LS_IN_TXT_WRK_AREA_ET = "LS_IN_TXT_WRK_AREA_ET";
            internal const string LS_IN_TXT10_03MS = "LS_IN_TXT10_03MS";
            internal const string LS_IN_TXT10_03XX = "LS_IN_TXT10_03XX";
            internal const string LS_IMP_V4 = "LS_IMP_V4";
            internal const string LS_IN_RPT_PARMS_ET = "LS_IN_RPT_PARMS_ET";
            internal const string LS_IN_PARM1_04MS = "LS_IN_PARM1_04MS";
            internal const string LS_IN_PARM1_04XX = "LS_IN_PARM1_04XX";
            internal const string IO_CONTROL_CD = "IO_CONTROL_CD";
            internal const string LS_IN_PARM2_05MS = "LS_IN_PARM2_05MS";
            internal const string LS_IN_PARM2_05XX = "LS_IN_PARM2_05XX";
            internal const string LS_IMP_TOT_COLL_V5 = "LS_IMP_TOT_COLL_V5";
            internal const string LS_IN_IEF_SUPPLIED_ET = "LS_IN_IEF_SUPPLIED_ET";
            internal const string LS_IN_TOT_CURR_05MS = "LS_IN_TOT_CURR_05MS";
            internal const string LS_IN_TOT_CURR_05XX = "LS_IN_TOT_CURR_05XX";
            internal const string LS_IN_TOT_CURR_05 = "LS_IN_TOT_CURR_05";
            internal const string LS_IMP_BAL_OWED_V6 = "LS_IMP_BAL_OWED_V6";
            internal const string LS_IN_IEF1_SUPPLIED_ET = "LS_IN_IEF1_SUPPLIED_ET";
            internal const string LS_IN_TOT_CURR_06MS = "LS_IN_TOT_CURR_06MS";
            internal const string LS_IN_TOT_CURR_06XX = "LS_IN_TOT_CURR_06XX";
            internal const string LS_IN_TOT_CURR_06 = "LS_IN_TOT_CURR_06";
            internal const string LS_IMP_INT_OWED_V7 = "LS_IMP_INT_OWED_V7";
            internal const string LS_IN_IEF2_SUPPLIED_ET = "LS_IN_IEF2_SUPPLIED_ET";
            internal const string LS_IN_TOT_CURR_07MS = "LS_IN_TOT_CURR_07MS";
            internal const string LS_IN_TOT_CURR_07XX = "LS_IN_TOT_CURR_07XX";
            internal const string LS_IN_TOT_CURR_07 = "LS_IN_TOT_CURR_07";
            internal const string LS_IMP_TOT_OS_BAL_V8 = "LS_IMP_TOT_OS_BAL_V8";
            internal const string LS_IN_IEF3_SUPPLIED_ET = "LS_IN_IEF3_SUPPLIED_ET";
            internal const string LS_IN_TOT_CURR_08MS = "LS_IN_TOT_CURR_08MS";
            internal const string LS_IN_TOT_CURR_08XX = "LS_IN_TOT_CURR_08XX";
            internal const string LS_IN_TOT_CURR_08 = "LS_IN_TOT_CURR_08";
            internal const string LS_IMP_PRCNT_V9 = "LS_IMP_PRCNT_V9";
            internal const string LS_IN_IEF4_SUPPLIED_ET = "LS_IN_IEF4_SUPPLIED_ET";
            internal const string LS_IN_PERCNT_09MS = "LS_IN_PERCNT_09MS";
            internal const string LS_IN_PERCNT_09XX = "LS_IN_PERCNT_09XX";
            internal const string LS_IN_PERCNT_09 = "LS_IN_PERCNT_09";
            internal const string LS_IMP_PRIOR_RECOV_D_V10 = "LS_IMP_PRIOR_RECOV_D_V10";
            internal const string LS_IN_IEF5_SUPPLIED_ET = "LS_IN_IEF5_SUPPLIED_ET";
            internal const string LS_IN_TOT_CURR_10MS = "LS_IN_TOT_CURR_10MS";
            internal const string LS_IN_TOT_CURR_10XX = "LS_IN_TOT_CURR_10XX";
            internal const string LS_IN_TOT_CURR_10 = "LS_IN_TOT_CURR_10";
            internal const string LS_IMP_V11 = "LS_IMP_V11";
            internal const string LS_IN_OBL_TYPE_ET = "LS_IN_OBL_TYPE_ET";
            internal const string LS_IN_CODE_11MS = "LS_IN_CODE_11MS";
            internal const string LS_IN_CODE_11XX = "LS_IN_CODE_11XX";
            internal const string LS_IMP_NEW_DEBTS_V12 = "LS_IMP_NEW_DEBTS_V12";
            internal const string LS_IN_IEF6_SUPPLIED_ET = "LS_IN_IEF6_SUPPLIED_ET";
            internal const string LS_IN_CNT_12MS = "LS_IN_CNT_12MS";
            internal const string LS_IN_CNT_12XX = "LS_IN_CNT_12XX";
            internal const string LS_IN_CNT_12 = "LS_IN_CNT_12";
            internal const string LS_IN_TOT_CURR_14MS = "LS_IN_TOT_CURR_14MS";
            internal const string LS_IN_TOT_CURR_14XX = "LS_IN_TOT_CURR_14XX";
            internal const string LS_IN_TOT_CURR_14 = "LS_IN_TOT_CURR_14";
            internal const string LS_EXP_V13 = "LS_EXP_V13";
            internal const string LS_OUT_RPT_PARMS_ET = "LS_OUT_RPT_PARMS_ET";
            internal const string LS_OUT_PARM1_15MS = "LS_OUT_PARM1_15MS";
            internal const string LS_OUT_PARM1_15XX = "LS_OUT_PARM1_15XX";
            internal const string LS_RETURN_CD = "LS_RETURN_CD";
            internal const string LS_OUT_PARM2_16MS = "LS_OUT_PARM2_16MS";
            internal const string LS_OUT_PARM2_16XX = "LS_OUT_PARM2_16XX";
        }
        #endregion

        #region Direct-access element properties
        public IField TI_RUNTIME_PARM1 { get { return GetElementByName<IField>(Names.TI_RUNTIME_PARM1); } }
        public IField TI_RUNTIME_PARM2 { get { return GetElementByName<IField>(Names.TI_RUNTIME_PARM2); } }
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
        public ICheckField PSTEP_USE_FAILURE { get { return GetElementByName<ICheckField>(Names.PSTEP_USE_FAILURE); } }
        public IField LAST_STATUS { get { return GetElementByName<IField>(Names.LAST_STATUS); } }
        public ICheckField DB_ERROR_FL_LS { get { return GetElementByName<ICheckField>(Names.DB_ERROR_FL_LS); } }
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
        public IField MESSAGE_TABLNK_OUT_NAME { get { return GetElementByName<IField>(Names.MESSAGE_TABLNK_OUT_NAME); } }
        public IField TRANSLATE_TABLNK_OUT_NAME { get { return GetElementByName<IField>(Names.TRANSLATE_TABLNK_OUT_NAME); } }
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
        public IField LOAD_MODULNK_OUT_NAME { get { return GetElementByName<IField>(Names.LOAD_MODULNK_OUT_NAME); } }
        public IField INSTRUMENT_CODE { get { return GetElementByName<IField>(Names.INSTRUMENT_CODE); } }
        public IField TX_RETRY_LIMIT { get { return GetElementByName<IField>(Names.TX_RETRY_LIMIT); } }
        public IField TX_TIMEOUT { get { return GetElementByName<IField>(Names.TX_TIMEOUT); } }
        public IGroup PSMGR_EXTRA_ERRINFO { get { return GetElementByName<IGroup>(Names.PSMGR_EXTRA_ERRINFO); } }
        public IField ERRINFO_BUF_SIZE { get { return GetElementByName<IField>(Names.ERRINFO_BUF_SIZE); } }
        public IField ERRINFO_MSG_SIZE { get { return GetElementByName<IField>(Names.ERRINFO_MSG_SIZE); } }
        public IField ERRINFO_BUF_ADDR { get { return GetElementByName<IField>(Names.ERRINFO_BUF_ADDR); } }
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
        public IGroup LS_IMP_HI_DTE_V1 { get { return GetElementByName<IGroup>(Names.LS_IMP_HI_DTE_V1); } }
        public IGroup LS_IN_HI_DTE_WRK_AREA_ET { get { return GetElementByName<IGroup>(Names.LS_IN_HI_DTE_WRK_AREA_ET); } }
        public IField LS_IN_DTE_01MS { get { return GetElementByName<IField>(Names.LS_IN_DTE_01MS); } }
        public IGroup LS_IN_DTE_01XX { get { return GetElementByName<IGroup>(Names.LS_IN_DTE_01XX); } }
        public IField LS_IN_DTE_01 { get { return GetElementByName<IField>(Names.LS_IN_DTE_01); } }
        public IGroup LS_IMP_LO_DTE_V2 { get { return GetElementByName<IGroup>(Names.LS_IMP_LO_DTE_V2); } }
        public IGroup LS_IN_LO_DTE_WRK_AREA_ET { get { return GetElementByName<IGroup>(Names.LS_IN_LO_DTE_WRK_AREA_ET); } }
        public IField LS_IN_DTE_02MS { get { return GetElementByName<IField>(Names.LS_IN_DTE_02MS); } }
        public IGroup LS_IN_DTE_02XX { get { return GetElementByName<IGroup>(Names.LS_IN_DTE_02XX); } }
        public IField LS_IN_DTE_02 { get { return GetElementByName<IField>(Names.LS_IN_DTE_02); } }
        public IGroup LS_IMP_RPT_LIT_V3 { get { return GetElementByName<IGroup>(Names.LS_IMP_RPT_LIT_V3); } }
        public IGroup LS_IN_TXT_WRK_AREA_ET { get { return GetElementByName<IGroup>(Names.LS_IN_TXT_WRK_AREA_ET); } }
        public IField LS_IN_TXT10_03MS { get { return GetElementByName<IField>(Names.LS_IN_TXT10_03MS); } }
        public IField LS_IN_TXT10_03XX { get { return GetElementByName<IField>(Names.LS_IN_TXT10_03XX); } }
        public IGroup LS_IMP_V4 { get { return GetElementByName<IGroup>(Names.LS_IMP_V4); } }
        public IGroup LS_IN_RPT_PARMS_ET { get { return GetElementByName<IGroup>(Names.LS_IN_RPT_PARMS_ET); } }
        public IField LS_IN_PARM1_04MS { get { return GetElementByName<IField>(Names.LS_IN_PARM1_04MS); } }
        public IGroup LS_IN_PARM1_04XX { get { return GetElementByName<IGroup>(Names.LS_IN_PARM1_04XX); } }
        public IField IO_CONTROL_CD { get { return GetElementByName<IField>(Names.IO_CONTROL_CD); } }
        public IField LS_IN_PARM2_05MS { get { return GetElementByName<IField>(Names.LS_IN_PARM2_05MS); } }
        public IField LS_IN_PARM2_05XX { get { return GetElementByName<IField>(Names.LS_IN_PARM2_05XX); } }
        public IGroup LS_IMP_TOT_COLL_V5 { get { return GetElementByName<IGroup>(Names.LS_IMP_TOT_COLL_V5); } }
        public IGroup LS_IN_IEF_SUPPLIED_ET { get { return GetElementByName<IGroup>(Names.LS_IN_IEF_SUPPLIED_ET); } }
        public IField LS_IN_TOT_CURR_05MS { get { return GetElementByName<IField>(Names.LS_IN_TOT_CURR_05MS); } }
        public IGroup LS_IN_TOT_CURR_05XX { get { return GetElementByName<IGroup>(Names.LS_IN_TOT_CURR_05XX); } }
        public IField LS_IN_TOT_CURR_05 { get { return GetElementByName<IField>(Names.LS_IN_TOT_CURR_05); } }
        public IGroup LS_IMP_BAL_OWED_V6 { get { return GetElementByName<IGroup>(Names.LS_IMP_BAL_OWED_V6); } }
        public IGroup LS_IN_IEF1_SUPPLIED_ET { get { return GetElementByName<IGroup>(Names.LS_IN_IEF1_SUPPLIED_ET); } }
        public IField LS_IN_TOT_CURR_06MS { get { return GetElementByName<IField>(Names.LS_IN_TOT_CURR_06MS); } }
        public IGroup LS_IN_TOT_CURR_06XX { get { return GetElementByName<IGroup>(Names.LS_IN_TOT_CURR_06XX); } }
        public IField LS_IN_TOT_CURR_06 { get { return GetElementByName<IField>(Names.LS_IN_TOT_CURR_06); } }
        public IGroup LS_IMP_INT_OWED_V7 { get { return GetElementByName<IGroup>(Names.LS_IMP_INT_OWED_V7); } }
        public IGroup LS_IN_IEF2_SUPPLIED_ET { get { return GetElementByName<IGroup>(Names.LS_IN_IEF2_SUPPLIED_ET); } }
        public IField LS_IN_TOT_CURR_07MS { get { return GetElementByName<IField>(Names.LS_IN_TOT_CURR_07MS); } }
        public IGroup LS_IN_TOT_CURR_07XX { get { return GetElementByName<IGroup>(Names.LS_IN_TOT_CURR_07XX); } }
        public IField LS_IN_TOT_CURR_07 { get { return GetElementByName<IField>(Names.LS_IN_TOT_CURR_07); } }
        public IGroup LS_IMP_TOT_OS_BAL_V8 { get { return GetElementByName<IGroup>(Names.LS_IMP_TOT_OS_BAL_V8); } }
        public IGroup LS_IN_IEF3_SUPPLIED_ET { get { return GetElementByName<IGroup>(Names.LS_IN_IEF3_SUPPLIED_ET); } }
        public IField LS_IN_TOT_CURR_08MS { get { return GetElementByName<IField>(Names.LS_IN_TOT_CURR_08MS); } }
        public IGroup LS_IN_TOT_CURR_08XX { get { return GetElementByName<IGroup>(Names.LS_IN_TOT_CURR_08XX); } }
        public IField LS_IN_TOT_CURR_08 { get { return GetElementByName<IField>(Names.LS_IN_TOT_CURR_08); } }
        public IGroup LS_IMP_PRCNT_V9 { get { return GetElementByName<IGroup>(Names.LS_IMP_PRCNT_V9); } }
        public IGroup LS_IN_IEF4_SUPPLIED_ET { get { return GetElementByName<IGroup>(Names.LS_IN_IEF4_SUPPLIED_ET); } }
        public IField LS_IN_PERCNT_09MS { get { return GetElementByName<IField>(Names.LS_IN_PERCNT_09MS); } }
        public IGroup LS_IN_PERCNT_09XX { get { return GetElementByName<IGroup>(Names.LS_IN_PERCNT_09XX); } }
        public IField LS_IN_PERCNT_09 { get { return GetElementByName<IField>(Names.LS_IN_PERCNT_09); } }
        public IGroup LS_IMP_PRIOR_RECOV_D_V10 { get { return GetElementByName<IGroup>(Names.LS_IMP_PRIOR_RECOV_D_V10); } }
        public IGroup LS_IN_IEF5_SUPPLIED_ET { get { return GetElementByName<IGroup>(Names.LS_IN_IEF5_SUPPLIED_ET); } }
        public IField LS_IN_TOT_CURR_10MS { get { return GetElementByName<IField>(Names.LS_IN_TOT_CURR_10MS); } }
        public IGroup LS_IN_TOT_CURR_10XX { get { return GetElementByName<IGroup>(Names.LS_IN_TOT_CURR_10XX); } }
        public IField LS_IN_TOT_CURR_10 { get { return GetElementByName<IField>(Names.LS_IN_TOT_CURR_10); } }
        public IGroup LS_IMP_V11 { get { return GetElementByName<IGroup>(Names.LS_IMP_V11); } }
        public IGroup LS_IN_OBL_TYPE_ET { get { return GetElementByName<IGroup>(Names.LS_IN_OBL_TYPE_ET); } }
        public IField LS_IN_CODE_11MS { get { return GetElementByName<IField>(Names.LS_IN_CODE_11MS); } }
        public IField LS_IN_CODE_11XX { get { return GetElementByName<IField>(Names.LS_IN_CODE_11XX); } }
        public IGroup LS_IMP_NEW_DEBTS_V12 { get { return GetElementByName<IGroup>(Names.LS_IMP_NEW_DEBTS_V12); } }
        public IGroup LS_IN_IEF6_SUPPLIED_ET { get { return GetElementByName<IGroup>(Names.LS_IN_IEF6_SUPPLIED_ET); } }
        public IField LS_IN_CNT_12MS { get { return GetElementByName<IField>(Names.LS_IN_CNT_12MS); } }
        public IGroup LS_IN_CNT_12XX { get { return GetElementByName<IGroup>(Names.LS_IN_CNT_12XX); } }
        public IField LS_IN_CNT_12 { get { return GetElementByName<IField>(Names.LS_IN_CNT_12); } }
        public IField LS_IN_TOT_CURR_14MS { get { return GetElementByName<IField>(Names.LS_IN_TOT_CURR_14MS); } }
        public IGroup LS_IN_TOT_CURR_14XX { get { return GetElementByName<IGroup>(Names.LS_IN_TOT_CURR_14XX); } }
        public IField LS_IN_TOT_CURR_14 { get { return GetElementByName<IField>(Names.LS_IN_TOT_CURR_14); } }
        public IGroup LS_EXP_V13 { get { return GetElementByName<IGroup>(Names.LS_EXP_V13); } }
        public IGroup LS_OUT_RPT_PARMS_ET { get { return GetElementByName<IGroup>(Names.LS_OUT_RPT_PARMS_ET); } }
        public IField LS_OUT_PARM1_15MS { get { return GetElementByName<IField>(Names.LS_OUT_PARM1_15MS); } }
        public IGroup LS_OUT_PARM1_15XX { get { return GetElementByName<IGroup>(Names.LS_OUT_PARM1_15XX); } }
        public IField LS_RETURN_CD { get { return GetElementByName<IField>(Names.LS_RETURN_CD); } }
        public IField LS_OUT_PARM2_16MS { get { return GetElementByName<IField>(Names.LS_OUT_PARM2_16MS); } }
        public IField LS_OUT_PARM2_16XX { get { return GetElementByName<IField>(Names.LS_OUT_PARM2_16XX); } }

        #endregion

        #region Data structure definition
        /// <summary>
        /// Defines the entirety of the LinkageSection IRecord structure as described by the Ateras.Framework.Buffer API.
        /// </summary>
        /// <param name="recordDef">The IStructureDefinition object to be used in defining the record structure.</param>
        protected override void DefineRecordStructure(IStructureDefinition recordDef)
        {
            recordDef.CreateNewField(Names.TI_RUNTIME_PARM1, FieldType.String, 1);
            recordDef.CreateNewField(Names.TI_RUNTIME_PARM2, FieldType.String, 1);

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
                       .NewCheckField(Names.PSTEP_USE_FAILURE, "PU")
                       ;
                   PSMGR_DASG_DATA.CreateNewField(Names.LAST_STATUS, FieldType.String, 2)
                       .NewCheckField(Names.DB_ERROR_FL_LS, "DB")
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
                   PSMGR_TIRDATE_CMCB.CreateNewGroupRedefine("FILLER_d8", PSMGR_TIRDATE_TSTAMP_local, (FILLER_d8) =>
                   {
                       FILLER_d8.CreateNewField(Names.PSMGR_TIRDATE_DATE_Z, FieldType.UnsignedNumeric, 8);
                       FILLER_d8.CreateNewField(Names.PSMGR_TIRDATE_TIME_Z, FieldType.UnsignedNumeric, 8);
                       FILLER_d8.CreateNewFillerField(4, FillWith.Hashes);
                   });
                   PSMGR_TIRDATE_CMCB.CreateNewFillerField(96, FillWith.Hashes);
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
                   PSMGR_ACTIVE_DIALECT.CreateNewField(Names.MESSAGE_TABLNK_OUT_NAME, FieldType.String, 8);
                   PSMGR_ACTIVE_DIALECT.CreateNewField(Names.TRANSLATE_TABLNK_OUT_NAME, FieldType.String, 8);
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
               GLOBDATA.CreateNewField(Names.LOAD_MODULNK_OUT_NAME, FieldType.String, 8);
               GLOBDATA.CreateNewField(Names.INSTRUMENT_CODE, FieldType.CompInt, 9);
               GLOBDATA.CreateNewField(Names.TX_RETRY_LIMIT, FieldType.CompInt, 9);
               GLOBDATA.CreateNewField(Names.TX_TIMEOUT, FieldType.CompInt, 9);
               GLOBDATA.CreateNewGroup(Names.PSMGR_EXTRA_ERRINFO, (PSMGR_EXTRA_ERRINFO) =>
               {
                   PSMGR_EXTRA_ERRINFO.CreateNewField(Names.ERRINFO_BUF_SIZE, FieldType.CompInt, 9);
                   PSMGR_EXTRA_ERRINFO.CreateNewField(Names.ERRINFO_MSG_SIZE, FieldType.CompInt, 9);
                   PSMGR_EXTRA_ERRINFO.CreateNewField(Names.ERRINFO_BUF_ADDR, FieldType.String, 16);
               });
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

            recordDef.CreateNewGroup(Names.LS_IMP_HI_DTE_V1, (LS_IMP_HI_DTE_V1) =>
           {
               LS_IMP_HI_DTE_V1.CreateNewGroup(Names.LS_IN_HI_DTE_WRK_AREA_ET, (LS_IN_HI_DTE_WRK_AREA_ET) =>
               {
                   LS_IN_HI_DTE_WRK_AREA_ET.CreateNewField(Names.LS_IN_DTE_01MS, FieldType.String, 1);
                   LS_IN_HI_DTE_WRK_AREA_ET.CreateNewGroup(Names.LS_IN_DTE_01XX, (LS_IN_DTE_01XX) =>
                   {
                       LS_IN_DTE_01XX.CreateNewField(Names.LS_IN_DTE_01, FieldType.SignedNumeric, 8);
                   });
               });
           });

            recordDef.CreateNewGroup(Names.LS_IMP_LO_DTE_V2, (LS_IMP_LO_DTE_V2) =>
           {
               LS_IMP_LO_DTE_V2.CreateNewGroup(Names.LS_IN_LO_DTE_WRK_AREA_ET, (LS_IN_LO_DTE_WRK_AREA_ET) =>
               {
                   LS_IN_LO_DTE_WRK_AREA_ET.CreateNewField(Names.LS_IN_DTE_02MS, FieldType.String, 1);
                   LS_IN_LO_DTE_WRK_AREA_ET.CreateNewGroup(Names.LS_IN_DTE_02XX, (LS_IN_DTE_02XX) =>
                   {
                       LS_IN_DTE_02XX.CreateNewField(Names.LS_IN_DTE_02, FieldType.SignedNumeric, 8);
                   });
               });
           });

            recordDef.CreateNewGroup(Names.LS_IMP_RPT_LIT_V3, (LS_IMP_RPT_LIT_V3) =>
           {
               LS_IMP_RPT_LIT_V3.CreateNewGroup(Names.LS_IN_TXT_WRK_AREA_ET, (LS_IN_TXT_WRK_AREA_ET) =>
               {
                   LS_IN_TXT_WRK_AREA_ET.CreateNewField(Names.LS_IN_TXT10_03MS, FieldType.String, 1);
                   LS_IN_TXT_WRK_AREA_ET.CreateNewField(Names.LS_IN_TXT10_03XX, FieldType.String, 10);
               });
           });

            recordDef.CreateNewGroup(Names.LS_IMP_V4, (LS_IMP_V4) =>
           {
               LS_IMP_V4.CreateNewGroup(Names.LS_IN_RPT_PARMS_ET, (LS_IN_RPT_PARMS_ET) =>
               {
                   LS_IN_RPT_PARMS_ET.CreateNewField(Names.LS_IN_PARM1_04MS, FieldType.String, 1);
                   LS_IN_RPT_PARMS_ET.CreateNewGroup(Names.LS_IN_PARM1_04XX, (LS_IN_PARM1_04XX) =>
                   {
                       LS_IN_PARM1_04XX.CreateNewField(Names.IO_CONTROL_CD, FieldType.String, 2);
                   });
                   LS_IN_RPT_PARMS_ET.CreateNewField(Names.LS_IN_PARM2_05MS, FieldType.String, 1);
                   LS_IN_RPT_PARMS_ET.CreateNewField(Names.LS_IN_PARM2_05XX, FieldType.String, 2);
               });
           });

            recordDef.CreateNewGroup(Names.LS_IMP_TOT_COLL_V5, (LS_IMP_TOT_COLL_V5) =>
           {
               LS_IMP_TOT_COLL_V5.CreateNewGroup(Names.LS_IN_IEF_SUPPLIED_ET, (LS_IN_IEF_SUPPLIED_ET) =>
               {
                   LS_IN_IEF_SUPPLIED_ET.CreateNewField(Names.LS_IN_TOT_CURR_05MS, FieldType.String, 1);
                   LS_IN_IEF_SUPPLIED_ET.CreateNewGroup(Names.LS_IN_TOT_CURR_05XX, (LS_IN_TOT_CURR_05XX) =>
                   {
                       LS_IN_TOT_CURR_05XX.CreateNewField(Names.LS_IN_TOT_CURR_05, FieldType.SignedNumeric, 15, null, 2);
                   });
               });
           });

            recordDef.CreateNewGroup(Names.LS_IMP_BAL_OWED_V6, (LS_IMP_BAL_OWED_V6) =>
           {
               LS_IMP_BAL_OWED_V6.CreateNewGroup(Names.LS_IN_IEF1_SUPPLIED_ET, (LS_IN_IEF1_SUPPLIED_ET) =>
               {
                   LS_IN_IEF1_SUPPLIED_ET.CreateNewField(Names.LS_IN_TOT_CURR_06MS, FieldType.String, 1);
                   LS_IN_IEF1_SUPPLIED_ET.CreateNewGroup(Names.LS_IN_TOT_CURR_06XX, (LS_IN_TOT_CURR_06XX) =>
                   {
                       LS_IN_TOT_CURR_06XX.CreateNewField(Names.LS_IN_TOT_CURR_06, FieldType.SignedNumeric, 15, null, 2);
                   });
               });
           });

            recordDef.CreateNewGroup(Names.LS_IMP_INT_OWED_V7, (LS_IMP_INT_OWED_V7) =>
           {
               LS_IMP_INT_OWED_V7.CreateNewGroup(Names.LS_IN_IEF2_SUPPLIED_ET, (LS_IN_IEF2_SUPPLIED_ET) =>
               {
                   LS_IN_IEF2_SUPPLIED_ET.CreateNewField(Names.LS_IN_TOT_CURR_07MS, FieldType.String, 1);
                   LS_IN_IEF2_SUPPLIED_ET.CreateNewGroup(Names.LS_IN_TOT_CURR_07XX, (LS_IN_TOT_CURR_07XX) =>
                   {
                       LS_IN_TOT_CURR_07XX.CreateNewField(Names.LS_IN_TOT_CURR_07, FieldType.SignedNumeric, 15, null, 2);
                   });
               });
           });

            recordDef.CreateNewGroup(Names.LS_IMP_TOT_OS_BAL_V8, (LS_IMP_TOT_OS_BAL_V8) =>
           {
               LS_IMP_TOT_OS_BAL_V8.CreateNewGroup(Names.LS_IN_IEF3_SUPPLIED_ET, (LS_IN_IEF3_SUPPLIED_ET) =>
               {
                   LS_IN_IEF3_SUPPLIED_ET.CreateNewField(Names.LS_IN_TOT_CURR_08MS, FieldType.String, 1);
                   LS_IN_IEF3_SUPPLIED_ET.CreateNewGroup(Names.LS_IN_TOT_CURR_08XX, (LS_IN_TOT_CURR_08XX) =>
                   {
                       LS_IN_TOT_CURR_08XX.CreateNewField(Names.LS_IN_TOT_CURR_08, FieldType.SignedNumeric, 15, null, 2);
                   });
               });
           });

            recordDef.CreateNewGroup(Names.LS_IMP_PRCNT_V9, (LS_IMP_PRCNT_V9) =>
           {
               LS_IMP_PRCNT_V9.CreateNewGroup(Names.LS_IN_IEF4_SUPPLIED_ET, (LS_IN_IEF4_SUPPLIED_ET) =>
               {
                   LS_IN_IEF4_SUPPLIED_ET.CreateNewField(Names.LS_IN_PERCNT_09MS, FieldType.String, 1);
                   LS_IN_IEF4_SUPPLIED_ET.CreateNewGroup(Names.LS_IN_PERCNT_09XX, (LS_IN_PERCNT_09XX) =>
                   {
                       LS_IN_PERCNT_09XX.CreateNewField(Names.LS_IN_PERCNT_09, FieldType.SignedNumeric, 11, null, 2);
                   });
               });
           });

            recordDef.CreateNewGroup(Names.LS_IMP_PRIOR_RECOV_D_V10, (LS_IMP_PRIOR_RECOV_D_V10) =>
           {
               LS_IMP_PRIOR_RECOV_D_V10.CreateNewGroup(Names.LS_IN_IEF5_SUPPLIED_ET, (LS_IN_IEF5_SUPPLIED_ET) =>
               {
                   LS_IN_IEF5_SUPPLIED_ET.CreateNewField(Names.LS_IN_TOT_CURR_10MS, FieldType.String, 1);
                   LS_IN_IEF5_SUPPLIED_ET.CreateNewGroup(Names.LS_IN_TOT_CURR_10XX, (LS_IN_TOT_CURR_10XX) =>
                   {
                       LS_IN_TOT_CURR_10XX.CreateNewField(Names.LS_IN_TOT_CURR_10, FieldType.SignedNumeric, 15, null, 2);
                   });
               });
           });

            recordDef.CreateNewGroup(Names.LS_IMP_V11, (LS_IMP_V11) =>
           {
               LS_IMP_V11.CreateNewGroup(Names.LS_IN_OBL_TYPE_ET, (LS_IN_OBL_TYPE_ET) =>
               {
                   LS_IN_OBL_TYPE_ET.CreateNewField(Names.LS_IN_CODE_11MS, FieldType.String, 1);
                   LS_IN_OBL_TYPE_ET.CreateNewField(Names.LS_IN_CODE_11XX, FieldType.String, 7);
               });
           });

            recordDef.CreateNewGroup(Names.LS_IMP_NEW_DEBTS_V12, (LS_IMP_NEW_DEBTS_V12) =>
           {
               LS_IMP_NEW_DEBTS_V12.CreateNewGroup(Names.LS_IN_IEF6_SUPPLIED_ET, (LS_IN_IEF6_SUPPLIED_ET) =>
               {
                   LS_IN_IEF6_SUPPLIED_ET.CreateNewField(Names.LS_IN_CNT_12MS, FieldType.String, 1);
                   LS_IN_IEF6_SUPPLIED_ET.CreateNewGroup(Names.LS_IN_CNT_12XX, (LS_IN_CNT_12XX) =>
                   {
                       LS_IN_CNT_12XX.CreateNewField(Names.LS_IN_CNT_12, FieldType.SignedNumeric, 9);
                   });
                   LS_IN_IEF6_SUPPLIED_ET.CreateNewField(Names.LS_IN_TOT_CURR_14MS, FieldType.String, 1);
                   LS_IN_IEF6_SUPPLIED_ET.CreateNewGroup(Names.LS_IN_TOT_CURR_14XX, (LS_IN_TOT_CURR_14XX) =>
                   {
                       LS_IN_TOT_CURR_14XX.CreateNewField(Names.LS_IN_TOT_CURR_14, FieldType.SignedNumeric, 15, null, 2);
                   });
               });
           });

            recordDef.CreateNewGroup(Names.LS_EXP_V13, (LS_EXP_V13) =>
           {
               LS_EXP_V13.CreateNewGroup(Names.LS_OUT_RPT_PARMS_ET, (LS_OUT_RPT_PARMS_ET) =>
               {
                   LS_OUT_RPT_PARMS_ET.CreateNewField(Names.LS_OUT_PARM1_15MS, FieldType.String, 1);
                   LS_OUT_RPT_PARMS_ET.CreateNewGroup(Names.LS_OUT_PARM1_15XX, (LS_OUT_PARM1_15XX) =>
                   {
                       LS_OUT_PARM1_15XX.CreateNewField(Names.LS_RETURN_CD, FieldType.String, 2);
                   });
                   LS_OUT_RPT_PARMS_ET.CreateNewField(Names.LS_OUT_PARM2_16MS, FieldType.String, 1);
                   LS_OUT_RPT_PARMS_ET.CreateNewField(Names.LS_OUT_PARM2_16XX, FieldType.String, 2);
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
            SetPassedParm(TI_RUNTIME_PARM1, args, 0);
            SetPassedParm(TI_RUNTIME_PARM2, args, 1);
            SetPassedParm(GLOBDATA, args, 2);
            SetPassedParm(LS_IMP_HI_DTE_V1, args, 3);
            SetPassedParm(LS_IMP_LO_DTE_V2, args, 4);
            SetPassedParm(LS_IMP_RPT_LIT_V3, args, 5);
            SetPassedParm(LS_IMP_V4, args, 6);
            SetPassedParm(LS_IMP_TOT_COLL_V5, args, 7);
            SetPassedParm(LS_IMP_BAL_OWED_V6, args, 8);
            SetPassedParm(LS_IMP_INT_OWED_V7, args, 9);
            SetPassedParm(LS_IMP_TOT_OS_BAL_V8, args, 10);
            SetPassedParm(LS_IMP_PRCNT_V9, args, 11);
            SetPassedParm(LS_IMP_PRIOR_RECOV_D_V10, args, 12);
            SetPassedParm(LS_IMP_V11, args, 13);
            SetPassedParm(LS_IMP_NEW_DEBTS_V12, args, 14);
            SetPassedParm(LS_EXP_V13, args, 15);
        }


        public void UpdateReturnParameters(object[] args)
        {
            SetReturnParm(TI_RUNTIME_PARM1, args, 0);
            SetReturnParm(TI_RUNTIME_PARM2, args, 1);
            SetReturnParm(GLOBDATA, args, 2);
            SetReturnParm(LS_IMP_HI_DTE_V1, args, 3);
            SetReturnParm(LS_IMP_LO_DTE_V2, args, 4);
            SetReturnParm(LS_IMP_RPT_LIT_V3, args, 5);
            SetReturnParm(LS_IMP_V4, args, 6);
            SetReturnParm(LS_IMP_TOT_COLL_V5, args, 7);
            SetReturnParm(LS_IMP_BAL_OWED_V6, args, 8);
            SetReturnParm(LS_IMP_INT_OWED_V7, args, 9);
            SetReturnParm(LS_IMP_TOT_OS_BAL_V8, args, 10);
            SetReturnParm(LS_IMP_PRCNT_V9, args, 11);
            SetReturnParm(LS_IMP_PRIOR_RECOV_D_V10, args, 12);
            SetReturnParm(LS_IMP_V11, args, 13);
            SetReturnParm(LS_IMP_NEW_DEBTS_V12, args, 14);
            SetReturnParm(LS_EXP_V13, args, 15);
        }
    }
    #endregion Linkage Section Class

    #region Business Logic Class
    public class SWEXF237 : EABBase
    {

        #region Public Constructors
        public SWEXF237()
            : base()
        {
            this.ProgramName.SetValue("SWEXF237");

            WS = new SWEXF237_ws();
            FD = new SWEXF237_fd(WS);
            LS = new SWEXF237_ls();
        }

        #endregion

        #region Private Fields


        //==== Working Storage Data Class ========================================
        private SWEXF237_ws WS;

        //==== File Data Class ========================================
        private SWEXF237_fd FD;

        //==== Linkage Section Data Class ========================================
        private SWEXF237_ls LS;
        #endregion

        #region Public Methods
        //========================================================================
        //==== RunMain Entry Point Method ========================================
        //========================================================================
        public override int ExecuteMain(params object[] args)                                              //COBOL==> PROCEDURE DIVISION USING TI-RUNTIME-PARM1 , TI-RUNTIME-PARM2 , GLOBDATA , LS-IMP-HI-DTE-V1 , LS-IMP-LO-DTE-V2 , LS-IMP-RPT-LIT-V3 , LS-IMP-V4 , LS-IMP-TOT-COLL-V5 , LS-IMP-BAL-OWED-V6 , LS-IMP-INT-OWED-V7 , LS-IMP-TOT-OS-BAL-V8 , LS-IMP-PRCNT-V9 , LS-IMP-PRIOR-RECOV-D-V10 , LS-IMP-V11 , LS-IMP-NEW-DEBTS-V12 , LS-EXP-V13.
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
            M_A000_MAIN_LINE(returnMethod);
        }
        /// <summary>
        /// Method M_A000_MAIN_LINE
        /// </summary>
        private void M_A000_MAIN_LINE(string returnMethod = "")
        {
            //COMMENT:  THIS PARAGRAPH CONTROLS THE MAIN PROCESSING OF THE PROGRAM
            M_B000_INIT_FIELDS("M_B000_INIT_FIELDS_EXIT"); if (Control.ExitProgram) { return; }                   //COBOL==> PERFORM B000-INIT-FIELDS THRU B000-INIT-FIELDS-EXIT.
                                                                                                                  // EvaluateList !LS.IO_CONTROL_CD!                                                                  //COBOL==> EVALUATE IO-CONTROL-CD
            if ((LS.IO_CONTROL_CD.IsEqualTo("OF")))                                                             //COBOL==> WHEN 'OF'
            {
                FD.SEQ_FILE.OpenFile(FileAccessMode.Write);                                                         //COBOL==> OPEN OUTPUT SEQ-FILE
            }                                                                                                //COBOL==> WHEN 'GR'
            else
            if ((LS.IO_CONTROL_CD.IsEqualTo("GR")))
            {
                M_B100_SETUP_REC("M_B100_SETUP_REC_EXIT"); if (Control.ExitProgram) { return; }                       //COBOL==> PERFORM B100-SETUP-REC THRU B100-SETUP-REC-EXIT
                FD.SEQ_FILE.WriteLine(WS.WS_WORK_REC.AsBytes);                                                      //COBOL==> WRITE SEQFILE-REC FROM WS-WORK-REC
            }                                                                                                //COBOL==> WHEN 'CF'
            else
            if ((LS.IO_CONTROL_CD.IsEqualTo("CF")))
            {
                FD.SEQ_FILE.CloseFile();                                                                            //COBOL==> CLOSE SEQ-FILE
            }                                                                                                   //COBOL==> END-EVALUATE.
            if (WS.WS_FILE_STATUS.IsEqualTo("00"))                                                              //COBOL==> IF WS-FILE-STATUS = '00'
            {
                LS.LS_RETURN_CD.SetValueWithSpaces();                                                               //COBOL==> MOVE SPACES TO LS-RETURN-CD
            }                                                                                                   //COBOL==> ELSE
            else
            {
                LS.LS_RETURN_CD.SetValue(WS.WS_FILE_STATUS);                                                        //COBOL==> MOVE WS-FILE-STATUS TO LS-RETURN-CD
            }                                                                                                   //COBOL==> END-IF.
            Control.ExitProgram = true; return;                                                                 //COBOL==> GOBACK.
        }
        /// <summary>
        /// Method M_A000_MAIN_LINE_EXIT
        /// </summary>
        private void M_A000_MAIN_LINE_EXIT(string returnMethod = "")
        {
            if (returnMethod == "M_A000_MAIN_LINE_EXIT") { return; }                                            //COBOL==> EXIT.
            if (returnMethod != "" && returnMethod != "M_A000_MAIN_LINE_EXIT") { M_B000_INIT_FIELDS(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_B000_INIT_FIELDS
        /// </summary>
        private void M_B000_INIT_FIELDS(string returnMethod = "")
        {
            //COMMENT:   INITIALIZE - INPUT ATTRIBUTES, IF THEY HAVE INVALID VALUES
            //COMMENT:   INITIALIZE - OUTPUT ATTRIBUTES ALWAYS
            //COMMENT:  VALIDATE NUMERIC FIELDS
            if (!(LS.LS_IN_DTE_01.IsNumericValue()))                                                           //COBOL==> IF LS-IN-DTE-01 IS NOT NUMERIC
            {
                LS.LS_IN_DTE_01.SetValueWithZeroes();                                                               //COBOL==> MOVE ZEROS TO LS-IN-DTE-01
            }                                                                                                   //COBOL==> END-IF.
            if (!(LS.LS_IN_DTE_02.IsNumericValue()))                                                           //COBOL==> IF LS-IN-DTE-02 IS NOT NUMERIC
            {
                LS.LS_IN_DTE_02.SetValueWithZeroes();                                                               //COBOL==> MOVE ZEROS TO LS-IN-DTE-02
            }                                                                                                   //COBOL==> END-IF.
            if (!(LS.LS_IN_TOT_CURR_05.IsNumericValue()))                                                      //COBOL==> IF LS-IN-TOT-CURR-05 IS NOT NUMERIC
            {
                LS.LS_IN_TOT_CURR_05.SetValueWithZeroes();                                                          //COBOL==> MOVE ZEROS TO LS-IN-TOT-CURR-05
            }                                                                                                   //COBOL==> END-IF.
            if (!(LS.LS_IN_TOT_CURR_06.IsNumericValue()))                                                      //COBOL==> IF LS-IN-TOT-CURR-06 IS NOT NUMERIC
            {
                LS.LS_IN_TOT_CURR_06.SetValueWithZeroes();                                                          //COBOL==> MOVE ZEROS TO LS-IN-TOT-CURR-06
            }                                                                                                   //COBOL==> END-IF.
            if (!(LS.LS_IN_TOT_CURR_07.IsNumericValue()))                                                      //COBOL==> IF LS-IN-TOT-CURR-07 IS NOT NUMERIC
            {
                LS.LS_IN_TOT_CURR_07.SetValueWithZeroes();                                                          //COBOL==> MOVE ZEROS TO LS-IN-TOT-CURR-07
            }                                                                                                   //COBOL==> END-IF.
            if (!(LS.LS_IN_TOT_CURR_08.IsNumericValue()))                                                      //COBOL==> IF LS-IN-TOT-CURR-08 IS NOT NUMERIC
            {
                LS.LS_IN_TOT_CURR_08.SetValueWithZeroes();                                                          //COBOL==> MOVE ZEROS TO LS-IN-TOT-CURR-08
            }                                                                                                   //COBOL==> END-IF.
            if (!(LS.LS_IN_PERCNT_09.IsNumericValue()))                                                        //COBOL==> IF LS-IN-PERCNT-09 IS NOT NUMERIC
            {
                LS.LS_IN_PERCNT_09.SetValueWithZeroes();                                                            //COBOL==> MOVE ZEROS TO LS-IN-PERCNT-09
            }                                                                                                   //COBOL==> END-IF.
            if (!(LS.LS_IN_TOT_CURR_10.IsNumericValue()))                                                      //COBOL==> IF LS-IN-TOT-CURR-10 IS NOT NUMERIC
            {
                LS.LS_IN_TOT_CURR_10.SetValueWithZeroes();                                                          //COBOL==> MOVE ZEROS TO LS-IN-TOT-CURR-10
            }                                                                                                   //COBOL==> END-IF.
            if (!(LS.LS_IN_CNT_12.IsNumericValue()))                                                           //COBOL==> IF LS-IN-CNT-12 IS NOT NUMERIC
            {
                LS.LS_IN_CNT_12.SetValueWithZeroes();                                                               //COBOL==> MOVE ZEROS TO LS-IN-CNT-12
            }                                                                                                   //COBOL==> END-IF.
            if (!(LS.LS_IN_TOT_CURR_14.IsNumericValue()))                                                      //COBOL==> IF LS-IN-TOT-CURR-14 IS NOT NUMERIC
            {
                LS.LS_IN_TOT_CURR_14.SetValueWithZeroes();                                                          //COBOL==> MOVE ZEROS TO LS-IN-TOT-CURR-14
            }                                                                                                   //COBOL==> END-IF.
                                                                                                                //COMMENT:  VALIDATE TEXT FIELDS
            if ((LS.LS_IN_TXT10_03XX.IsEqualTo(HIGH_VALUES))
             || (LS.LS_IN_TXT10_03XX.IsEqualTo(LOW_VALUES)))  //COBOL==> IF LS-IN-TXT10-03XX = HIGH-VALUES OR LS-IN-TXT10-03XX = LOW-VALUES
            {
                LS.LS_IN_TXT10_03XX.SetValueWithSpaces();                                                           //COBOL==> MOVE SPACES TO LS-IN-TXT10-03XX
            }                                                                                                   //COBOL==> END-IF.
            if ((LS.LS_IN_PARM1_04XX.IsEqualTo(HIGH_VALUES))
             || (LS.LS_IN_PARM1_04XX.IsEqualTo(LOW_VALUES)))  //COBOL==> IF LS-IN-PARM1-04XX = HIGH-VALUES OR LS-IN-PARM1-04XX = LOW-VALUES
            {
                LS.LS_IN_PARM1_04XX.SetValueWithSpaces();                                                           //COBOL==> MOVE SPACES TO LS-IN-PARM1-04XX
            }                                                                                                   //COBOL==> END-IF.
            if ((LS.LS_IN_PARM2_05XX.IsEqualTo(HIGH_VALUES))
             || (LS.LS_IN_PARM2_05XX.IsEqualTo(LOW_VALUES)))  //COBOL==> IF LS-IN-PARM2-05XX = HIGH-VALUES OR LS-IN-PARM2-05XX = LOW-VALUES
            {
                LS.LS_IN_PARM2_05XX.SetValueWithSpaces();                                                           //COBOL==> MOVE SPACES TO LS-IN-PARM2-05XX
            }                                                                                                   //COBOL==> END-IF.
            if ((LS.LS_IN_CODE_11XX.IsEqualTo(HIGH_VALUES))
             || (LS.LS_IN_CODE_11XX.IsEqualTo(LOW_VALUES)))  //COBOL==> IF LS-IN-CODE-11XX = HIGH-VALUES OR LS-IN-CODE-11XX = LOW-VALUES
            {
                LS.LS_IN_CODE_11XX.SetValueWithSpaces();                                                            //COBOL==> MOVE SPACES TO LS-IN-CODE-11XX
            }                                                                                                   //COBOL==> END-IF.
            LS.LS_OUT_PARM1_15XX.SetValueWithSpaces();                                                          //COBOL==> MOVE SPACES TO LS-OUT-PARM1-15XX.
            LS.LS_OUT_PARM2_16XX.SetValueWithSpaces();                                                          //COBOL==> MOVE SPACES TO LS-OUT-PARM2-16XX.
            if (returnMethod != "" && returnMethod != "M_B000_INIT_FIELDS") { M_B000_INIT_FIELDS_EXIT(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_B000_INIT_FIELDS_EXIT
        /// </summary>
        private void M_B000_INIT_FIELDS_EXIT(string returnMethod = "")
        {
            if (returnMethod == "M_B000_INIT_FIELDS_EXIT") { return; }                                          //COBOL==> EXIT.
            if (returnMethod != "" && returnMethod != "M_B000_INIT_FIELDS_EXIT") { M_B100_SETUP_REC(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_B100_SETUP_REC
        /// </summary>
        private void M_B100_SETUP_REC(string returnMethod = "")
        {
            //COMMENT:  MOVE THE LINKAGE VALUES TO THE WORK RECORD
            WS.WS_TOT_COLL.SetValue(LS.LS_IN_TOT_CURR_05);                                                      //COBOL==> MOVE LS-IN-TOT-CURR-05 TO WS-TOT-COLL.
            WS.WS_BAL_OWED.SetValue(LS.LS_IN_TOT_CURR_06);                                                      //COBOL==> MOVE LS-IN-TOT-CURR-06 TO WS-BAL-OWED.
            WS.WS_INT_OWED.SetValue(LS.LS_IN_TOT_CURR_07);                                                      //COBOL==> MOVE LS-IN-TOT-CURR-07 TO WS-INT-OWED.
            WS.WS_TOT_OS_BAL.SetValue(LS.LS_IN_TOT_CURR_08);                                                    //COBOL==> MOVE LS-IN-TOT-CURR-08 TO WS-TOT-OS-BAL.
            WS.WS_PERCENT.SetValue(LS.LS_IN_PERCNT_09);                                                         //COBOL==> MOVE LS-IN-PERCNT-09 TO WS-PERCENT.
            WS.WS_PRIOR_RECOV.SetValue(LS.LS_IN_TOT_CURR_10);                                                   //COBOL==> MOVE LS-IN-TOT-CURR-10 TO WS-PRIOR-RECOV.
            WS.WS_OB_CODE.SetValue(LS.LS_IN_CODE_11XX);                                                         //COBOL==> MOVE LS-IN-CODE-11XX TO WS-OB-CODE.
            WS.WS_NEW_DEBT_CNT.SetValue(LS.LS_IN_CNT_12);                                                       //COBOL==> MOVE LS-IN-CNT-12 TO WS-NEW-DEBT-CNT.
            WS.WS_NEW_DEBT_TOT.SetValue(LS.LS_IN_TOT_CURR_14);                                                  //COBOL==> MOVE LS-IN-TOT-CURR-14 TO WS-NEW-DEBT-TOT.
            if (returnMethod != "" && returnMethod != "M_B100_SETUP_REC") { M_B100_SETUP_REC_EXIT(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_B100_SETUP_REC_EXIT
        /// </summary>
        private void M_B100_SETUP_REC_EXIT(string returnMethod = "")
        {
            if (returnMethod == "M_B100_SETUP_REC_EXIT") { return; }                                            //COBOL==> EXIT.
        }
        #endregion
    }
    #endregion
}
