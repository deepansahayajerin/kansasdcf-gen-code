#region Comments
/* Conversion Comments
   ************************************************************
   **   MODERN SYSTEMS INC.  COPYRIGHT 2000-2022
   **   DB-SHUTTLE COBOL to C# Conversion
   ************************************************************
   ** INIT   *  INITIAL VERSION   *  2022-01-14 12:45:59 PM
   **        *   FROM COBOL PGM   :  SWASS915
   **        *   FROM CANISTER    :  SR.CAECSES.PROD.LIBR.SOURCE.PDS
   ************************************************************ */

/* Original Program Identification Comments
   DATE-COMPILED.
   
   **** START DOCUMENTATION ****************************************
   *                                                              **
   *    SYSTEM:  CAECSES  - AUTOMATED ELIGIBILITY                 **
   *                                                              **
   *    PROGRAM: SWASS915 - PRINT BUG SCREEN (REMOTE)             **
   *                                                              **
   *                                                              **
   *    PROCESSING                                                **
   *        THIS PROGRAM IS STARTED BY THE BUG PROGRAM            **
   *        (SWASS910).  THE BUG SCREEN INFORMATION IS PASSED     **
   *        TO THIS PROGRAM AND IS THEN PRINTED OUT TO A          **
   *        CENTRAL PRINTER.                                      **
   *                                                              **
   *    SCREEN(S) GENERATED:                                      **
   *        SCREEN    DESCRIPTION                                 **
   *                                                              **
   *                                                              **
   *    TABLE(S) ACCESSED:                                        **
   *        TABLE #   DESCRIPTION                                 **
   *                                                              **
   *                                                              **
   *    DATABASE FILE(S) AND QUEUE(S):                            **
   *      FILE                  INPUT  UPDATE  ADD  DELETE        **
   *                                                              **
   *                                                              **
   *    COPY MODULES:                                             **
   *         MODULE      DESCRIPTION                              **
   *                                                              **
   *                                                              **
   *    LINK MODULES:                                             **
   *         MODULE      DESCRIPTION                              **
   *                                                              **
   *                                                              **
   *    CREATED BY SHL SYSTEMHOUSE, 04/22/1988                    **
   *                                                              **
   **** END DOCUMENTATION ******************************************
   
   
   **** START MAINTENANCE LOG ************ PROGRAM SWASS915 ********
   *                                                              **
   *    MAINTENANCE LOG                                           **
   *        AUTHOR     DATE    CHG REQ #  DESCRIPTION             **
   *                                                              **
   **** END MAINTENANCE LOG ****************************************
   
*/
#endregion
#region Using Directives
using MDSY.Framework.Buffer;
using MDSY.Framework.Buffer.BaseClasses;
using MDSY.Framework.Buffer.Common;
using MDSY.Framework.Buffer.Interfaces;
using MDSY.Framework.Control.CICS;
using MDSY.Framework.Interfaces;
using System;
#endregion

namespace GOV.KS.DCF.CSS.Online.BL
{
    #region Working Storage Class
    internal class SWASS915_ws : PredefinedRecordBase
    {
        #region Name constants
        /// <summary>
        /// Name constants.
        /// </summary>
        internal static class Names
        {
            internal const string WorkingStorage = "SWASS915_ws_WorkingStorage";
            internal const string WS_WORKING_STORAGE = "WS_WORKING_STORAGE";
            internal const string MODULE_CONSTANTS = "MODULE_CONSTANTS";
            internal const string MC_THIS_TRANSACTION = "MC_THIS_TRANSACTION";
            internal const string MC_THIS_PROGRAM = "MC_THIS_PROGRAM";
            internal const string MC_TITLE_LENGTH = "MC_TITLE_LENGTH";
            internal const string MC_DATA_LENGTH = "MC_DATA_LENGTH";
            internal const string MC_LOGO_LENGTH = "MC_LOGO_LENGTH";
            internal const string MC_PARAMETER_LENGTH = "MC_PARAMETER_LENGTH";
            internal const string MC_NL = "MC_NL";
            internal const string MC_NEW_LINE = "MC_NEW_LINE";
            internal const string MC_FF = "MC_FF";
            internal const string MC_FORMFEED = "MC_FORMFEED";
            internal const string MC_EOM = "MC_EOM";
            internal const string MC_END_OF_MESSAGE = "MC_END_OF_MESSAGE";
            internal const string BUG_PRINT_TITLE = "BUG_PRINT_TITLE";
            internal const string BUG_PRINT_LINE_1 = "BUG_PRINT_LINE_1";
            internal const string BUG_FF010 = "BUG_FF010";
            internal const string BUG_NL010 = "BUG_NL010";
            internal const string BUG_PRINT_LINE_2 = "BUG_PRINT_LINE_2";
            internal const string BUG_DATE = "BUG_DATE";
            internal const string BUG_TIME = "BUG_TIME";
            internal const string BUG_NL020 = "BUG_NL020";
            internal const string BUG_NL030 = "BUG_NL030";
            internal const string BUG_DATA_SECTION = "BUG_DATA_SECTION";
            internal const string BUG_DATA_LINE_1 = "BUG_DATA_LINE_1";
            internal const string BUG_PGM_NAME = "BUG_PGM_NAME";
            internal const string BUG_NL040 = "BUG_NL040";
            internal const string BUG_DATA_LINE_2 = "BUG_DATA_LINE_2";
            internal const string BUG_COMMAREA_DUMP1 = "BUG_COMMAREA_DUMP1";
            internal const string BUG_NL050 = "BUG_NL050";
            internal const string BUG_DATA_LINE_3 = "BUG_DATA_LINE_3";
            internal const string BUG_ABEND_TYPE = "BUG_ABEND_TYPE";
            internal const string BUG_COMMAREA_DUMP2 = "BUG_COMMAREA_DUMP2";
            internal const string BUG_NL060 = "BUG_NL060";
            internal const string BUG_DATA_LINE_4 = "BUG_DATA_LINE_4";
            internal const string BUG_COMMAREA_DUMP3 = "BUG_COMMAREA_DUMP3";
            internal const string BUG_NL070 = "BUG_NL070";
            internal const string BUG_DATA_LINE_5 = "BUG_DATA_LINE_5";
            internal const string BUG_CALL_TYPE = "BUG_CALL_TYPE";
            internal const string BUG_COMMAREA_DUMP4 = "BUG_COMMAREA_DUMP4";
            internal const string BUG_NL080 = "BUG_NL080";
            internal const string BUG_DATA_LINE_6 = "BUG_DATA_LINE_6";
            internal const string BUG_SEQ_NUMBER = "BUG_SEQ_NUMBER";
            internal const string BUG_COMMAREA_DUMP5 = "BUG_COMMAREA_DUMP5";
            internal const string BUG_NL090 = "BUG_NL090";
            internal const string BUG_DATA_LINE_7 = "BUG_DATA_LINE_7";
            internal const string BUG_RESPONSE_CODE = "BUG_RESPONSE_CODE";
            internal const string BUG_COMMAREA_DUMP6 = "BUG_COMMAREA_DUMP6";
            internal const string BUG_NL100 = "BUG_NL100";
            internal const string BUG_DATA_LINE_8 = "BUG_DATA_LINE_8";
            internal const string BUG_TYPE_DESC = "BUG_TYPE_DESC";
            internal const string BUG_ERROR_TYPE = "BUG_ERROR_TYPE";
            internal const string BUG_NL110 = "BUG_NL110";
            internal const string BUG_DATA_LINE_9 = "BUG_DATA_LINE_9";
            internal const string BUG_TRMID = "BUG_TRMID";
            internal const string BUG_NL120 = "BUG_NL120";
            internal const string BUG_DATA_LINE_10 = "BUG_DATA_LINE_10";
            internal const string BUG_TRNSID = "BUG_TRNSID";
            internal const string BUG_NL125 = "BUG_NL125";
            internal const string BUG_LOGO_SECTION = "BUG_LOGO_SECTION";
            internal const string BUG_LOGO_LINE_1 = "BUG_LOGO_LINE_1";
            internal const string BUG_NL130 = "BUG_NL130";
            internal const string BUG_LOGO_LINE_2 = "BUG_LOGO_LINE_2";
            internal const string BUG_NL140 = "BUG_NL140";
            internal const string BUG_LOGO_LINE_3 = "BUG_LOGO_LINE_3";
            internal const string BUG_NL150 = "BUG_NL150";
            internal const string BUG_LOGO_LINE_4 = "BUG_LOGO_LINE_4";
            internal const string BUG_NL160 = "BUG_NL160";
            internal const string BUG_LOGO_LINE_5 = "BUG_LOGO_LINE_5";
            internal const string BUG_NL170 = "BUG_NL170";
            internal const string BUG_LOGO_LINE_6 = "BUG_LOGO_LINE_6";
            internal const string BUG_NL180 = "BUG_NL180";
            internal const string BUG_LOGO_LINE_7 = "BUG_LOGO_LINE_7";
            internal const string BUG_NL190 = "BUG_NL190";
            internal const string BUG_LOGO_LINE_8 = "BUG_LOGO_LINE_8";
            internal const string BUG_NL200 = "BUG_NL200";
            internal const string BUG_LOGO_LINE_9 = "BUG_LOGO_LINE_9";
            internal const string BUG_NL210 = "BUG_NL210";
            internal const string BUG_LOGO_LINE_10 = "BUG_LOGO_LINE_10";
            internal const string BUG_NL220 = "BUG_NL220";
            internal const string BUG_LOGO_LINE_11 = "BUG_LOGO_LINE_11";
            internal const string BUG_NL230 = "BUG_NL230";
            internal const string BUG_LOGO_LINE_12 = "BUG_LOGO_LINE_12";
            internal const string BUG_FF020 = "BUG_FF020";
            internal const string MODULE_VARIABLES = "MODULE_VARIABLES";
            internal const string MV_SENDING_LINE = "MV_SENDING_LINE";
            internal const string MV_LINE_LENGTH = "MV_LINE_LENGTH";
            internal const string MV_ONLINE_STANDARD = "MV_ONLINE_STANDARD";
            internal const string MV_CHANGED = "MV_CHANGED";
            internal const string MV_ERR_SEVERITY = "MV_ERR_SEVERITY";
            internal const string MV_PROGRAM = "MV_PROGRAM";
            internal const string MV_SAVE_CA_PARAMETERS = "MV_SAVE_CA_PARAMETERS";
            internal const string MV_ERR_MSG = "MV_ERR_MSG";
            internal const string MV_ERR_TYPE = "MV_ERR_TYPE";
            internal const string MV_ERR_TEXT = "MV_ERR_TEXT";
            internal const string MV_SAVE_SCREEN_QID = "MV_SAVE_SCREEN_QID";
            internal const string MV_SCREEN_TERMID = "MV_SCREEN_TERMID";
            internal const string MV_ORIG_SCREEN_QID = "MV_ORIG_SCREEN_QID";
            internal const string MV_ORIG_SCREEN_TERMID = "MV_ORIG_SCREEN_TERMID";
            internal const string MV_SZ908_CICS_TIME = "MV_SZ908_CICS_TIME";
            internal const string MV_SZ908_CICS_HH = "MV_SZ908_CICS_HH";
            internal const string MV_SZ908_CICS_MM = "MV_SZ908_CICS_MM";
            internal const string MV_SZ908_SCREEN_TIME = "MV_SZ908_SCREEN_TIME";
            internal const string MV_SZ908_SCREEN_HH = "MV_SZ908_SCREEN_HH";
            internal const string MV_SZ908_SCREEN_MM = "MV_SZ908_SCREEN_MM";
            internal const string MV_SZ908_SCREEN_DATE = "MV_SZ908_SCREEN_DATE";
            internal const string MV_SZ908_SCREEN_MMDD = "MV_SZ908_SCREEN_MMDD";
            internal const string MV_SZ908_SCREEN_YY = "MV_SZ908_SCREEN_YY";
            internal const string SYSTEM_CONSTANTS = "SYSTEM_CONSTANTS";
            internal const string SC_ADABAS_ERROR = "SC_ADABAS_ERROR";
            internal const string SC_SYSTEM_ERROR = "SC_SYSTEM_ERROR";
            internal const string SC_BRIGHT_PRO = "SC_BRIGHT_PRO";
            internal const string SC_BRIGHT_UNPRO = "SC_BRIGHT_UNPRO";
            internal const string SC_BRIGHT_UNPRO_NUM = "SC_BRIGHT_UNPRO_NUM";
            internal const string SC_WARNING = "SC_WARNING";
            internal const string SC_ERROR = "SC_ERROR";
            internal const string SC_SEVERE = "SC_SEVERE";
            internal const string SC_INFORMATION = "SC_INFORMATION";
            internal const string SC_CICS_ERROR = "SC_CICS_ERROR";
            internal const string SC_ISN_NOT_FOUND = "SC_ISN_NOT_FOUND";
            internal const string SC_CLEAR_KEY = "SC_CLEAR_KEY";
            internal const string SC_COMMAREA_LENGTH = "SC_COMMAREA_LENGTH";
            internal const string SC_ENTER_KEY = "SC_ENTER_KEY";
            internal const string SC_CZ_PGM = "SC_CZ_PGM";
            internal const string SC_SZ_PGM = "SC_SZ_PGM";
            internal const string SC_ERROR_PROGRAM = "SC_ERROR_PROGRAM";
            internal const string SC_HELP_PROGRAM = "SC_HELP_PROGRAM";
            internal const string SC_HELP_TRANSACTION = "SC_HELP_TRANSACTION";
            internal const string SC_NO = "SC_NO";
            internal const string SC_NORMAL_PRO = "SC_NORMAL_PRO";
            internal const string SC_NORMAL_PRO_NUM = "SC_NORMAL_PRO_NUM";
            internal const string SC_NORMAL_UNPRO = "SC_NORMAL_UNPRO";
            internal const string SC_NORMAL_UNPRO_NUM = "SC_NORMAL_UNPRO_NUM";
            internal const string SC_PF1_KEY = "SC_PF1_KEY";
            internal const string SC_PF2_KEY = "SC_PF2_KEY";
            internal const string SC_PF3_KEY = "SC_PF3_KEY";
            internal const string SC_PF4_KEY = "SC_PF4_KEY";
            internal const string SC_PF5_KEY = "SC_PF5_KEY";
            internal const string SC_PF6_KEY = "SC_PF6_KEY";
            internal const string SC_PF7_KEY = "SC_PF7_KEY";
            internal const string SC_PF8_KEY = "SC_PF8_KEY";
            internal const string SC_PF9_KEY = "SC_PF9_KEY";
            internal const string SC_PF10_KEY = "SC_PF10_KEY";
            internal const string SC_PF11_KEY = "SC_PF11_KEY";
            internal const string SC_PF12_KEY = "SC_PF12_KEY";
            internal const string SC_QUEUE_ITEM = "SC_QUEUE_ITEM";
            internal const string SC_SET_CURSOR = "SC_SET_CURSOR";
            internal const string SC_YES = "SC_YES";
            internal const string SC_MARK_UNCHANGED = "SC_MARK_UNCHANGED";
            internal const string SC_MARK_CHANGE = "SC_MARK_CHANGE";
            internal const string SC_MARK_OUTPUT = "SC_MARK_OUTPUT";
            internal const string SC_MARK_ERROR = "SC_MARK_ERROR";
            internal const string SC_MARK_ERROR_NUM = "SC_MARK_ERROR_NUM";
            internal const string SC_MARK_WARNING = "SC_MARK_WARNING";
            internal const string SC_MARK_WARNING_NUM = "SC_MARK_WARNING_NUM";
            internal const string SC_MARK_MERGE_ONLY = "SC_MARK_MERGE_ONLY";
            internal const string SRADALNK = "SRADALNK";
            internal const string SRMODLNK = "SRMODLNK";
            internal const string MV_START_DATA = "MV_START_DATA";
            internal const string MV_START_DATE = "MV_START_DATE";
            internal const string MV_START_TRMID = "MV_START_TRMID";
            internal const string MV_START_TRNSID = "MV_START_TRNSID";
            internal const string MV_START_PGM_NAME = "MV_START_PGM_NAME";
            internal const string MV_START_ABEND_TYPE = "MV_START_ABEND_TYPE";
            internal const string MV_START_CALL_TYPE = "MV_START_CALL_TYPE";
            internal const string MV_START_SEQ_NUMBER = "MV_START_SEQ_NUMBER";
            internal const string MV_START_RESPONSE_CODE = "MV_START_RESPONSE_CODE";
            internal const string MV_START_TYPE_DESC = "MV_START_TYPE_DESC";
            internal const string MV_START_ERROR_TYPE = "MV_START_ERROR_TYPE";
            internal const string MV_START_COMMAREA_DUMP1 = "MV_START_COMMAREA_DUMP1";
            internal const string MV_START_COMMAREA_DUMP2 = "MV_START_COMMAREA_DUMP2";
            internal const string MV_START_COMMAREA_DUMP3 = "MV_START_COMMAREA_DUMP3";
            internal const string MV_START_COMMAREA_DUMP4 = "MV_START_COMMAREA_DUMP4";
            internal const string MV_START_COMMAREA_DUMP5 = "MV_START_COMMAREA_DUMP5";
            internal const string MV_START_COMMAREA_DUMP6 = "MV_START_COMMAREA_DUMP6";
            internal const string MV_START_LENGTH = "MV_START_LENGTH";
            internal const string MV_START_TERMID = "MV_START_TERMID";
        }
        #endregion

        #region Direct-access element properties
        public IField WS_WORKING_STORAGE { get { return GetElementByName<IField>(Names.WS_WORKING_STORAGE); } }
        public IGroup MODULE_CONSTANTS { get { return GetElementByName<IGroup>(Names.MODULE_CONSTANTS); } }
        public IField MC_THIS_TRANSACTION { get { return GetElementByName<IField>(Names.MC_THIS_TRANSACTION); } }
        public IField MC_THIS_PROGRAM { get { return GetElementByName<IField>(Names.MC_THIS_PROGRAM); } }
        public IField MC_TITLE_LENGTH { get { return GetElementByName<IField>(Names.MC_TITLE_LENGTH); } }
        public IField MC_DATA_LENGTH { get { return GetElementByName<IField>(Names.MC_DATA_LENGTH); } }
        public IField MC_LOGO_LENGTH { get { return GetElementByName<IField>(Names.MC_LOGO_LENGTH); } }
        public IField MC_PARAMETER_LENGTH { get { return GetElementByName<IField>(Names.MC_PARAMETER_LENGTH); } }
        public IField MC_NL { get { return GetElementByName<IField>(Names.MC_NL); } }
        public IField MC_NEW_LINE { get { return GetElementByName<IField>(Names.MC_NEW_LINE); } }
        public IField MC_FF { get { return GetElementByName<IField>(Names.MC_FF); } }
        public IField MC_FORMFEED { get { return GetElementByName<IField>(Names.MC_FORMFEED); } }
        public IField MC_EOM { get { return GetElementByName<IField>(Names.MC_EOM); } }
        public IField MC_END_OF_MESSAGE { get { return GetElementByName<IField>(Names.MC_END_OF_MESSAGE); } }
        public IGroup BUG_PRINT_TITLE { get { return GetElementByName<IGroup>(Names.BUG_PRINT_TITLE); } }
        public IGroup BUG_PRINT_LINE_1 { get { return GetElementByName<IGroup>(Names.BUG_PRINT_LINE_1); } }
        public IField BUG_FF010 { get { return GetElementByName<IField>(Names.BUG_FF010); } }
        public IField BUG_NL010 { get { return GetElementByName<IField>(Names.BUG_NL010); } }
        public IGroup BUG_PRINT_LINE_2 { get { return GetElementByName<IGroup>(Names.BUG_PRINT_LINE_2); } }
        public IField BUG_DATE { get { return GetElementByName<IField>(Names.BUG_DATE); } }
        public IField BUG_TIME { get { return GetElementByName<IField>(Names.BUG_TIME); } }
        public IField BUG_NL020 { get { return GetElementByName<IField>(Names.BUG_NL020); } }
        public IField BUG_NL030 { get { return GetElementByName<IField>(Names.BUG_NL030); } }
        public IGroup BUG_DATA_SECTION { get { return GetElementByName<IGroup>(Names.BUG_DATA_SECTION); } }
        public IGroup BUG_DATA_LINE_1 { get { return GetElementByName<IGroup>(Names.BUG_DATA_LINE_1); } }
        public IField BUG_PGM_NAME { get { return GetElementByName<IField>(Names.BUG_PGM_NAME); } }
        public IField BUG_NL040 { get { return GetElementByName<IField>(Names.BUG_NL040); } }
        public IGroup BUG_DATA_LINE_2 { get { return GetElementByName<IGroup>(Names.BUG_DATA_LINE_2); } }
        public IField BUG_COMMAREA_DUMP1 { get { return GetElementByName<IField>(Names.BUG_COMMAREA_DUMP1); } }
        public IField BUG_NL050 { get { return GetElementByName<IField>(Names.BUG_NL050); } }
        public IGroup BUG_DATA_LINE_3 { get { return GetElementByName<IGroup>(Names.BUG_DATA_LINE_3); } }
        public IField BUG_ABEND_TYPE { get { return GetElementByName<IField>(Names.BUG_ABEND_TYPE); } }
        public IField BUG_COMMAREA_DUMP2 { get { return GetElementByName<IField>(Names.BUG_COMMAREA_DUMP2); } }
        public IField BUG_NL060 { get { return GetElementByName<IField>(Names.BUG_NL060); } }
        public IGroup BUG_DATA_LINE_4 { get { return GetElementByName<IGroup>(Names.BUG_DATA_LINE_4); } }
        public IField BUG_COMMAREA_DUMP3 { get { return GetElementByName<IField>(Names.BUG_COMMAREA_DUMP3); } }
        public IField BUG_NL070 { get { return GetElementByName<IField>(Names.BUG_NL070); } }
        public IGroup BUG_DATA_LINE_5 { get { return GetElementByName<IGroup>(Names.BUG_DATA_LINE_5); } }
        public IField BUG_CALL_TYPE { get { return GetElementByName<IField>(Names.BUG_CALL_TYPE); } }
        public IField BUG_COMMAREA_DUMP4 { get { return GetElementByName<IField>(Names.BUG_COMMAREA_DUMP4); } }
        public IField BUG_NL080 { get { return GetElementByName<IField>(Names.BUG_NL080); } }
        public IGroup BUG_DATA_LINE_6 { get { return GetElementByName<IGroup>(Names.BUG_DATA_LINE_6); } }
        public IField BUG_SEQ_NUMBER { get { return GetElementByName<IField>(Names.BUG_SEQ_NUMBER); } }
        public IField BUG_COMMAREA_DUMP5 { get { return GetElementByName<IField>(Names.BUG_COMMAREA_DUMP5); } }
        public IField BUG_NL090 { get { return GetElementByName<IField>(Names.BUG_NL090); } }
        public IGroup BUG_DATA_LINE_7 { get { return GetElementByName<IGroup>(Names.BUG_DATA_LINE_7); } }
        public IField BUG_RESPONSE_CODE { get { return GetElementByName<IField>(Names.BUG_RESPONSE_CODE); } }
        public IField BUG_COMMAREA_DUMP6 { get { return GetElementByName<IField>(Names.BUG_COMMAREA_DUMP6); } }
        public IField BUG_NL100 { get { return GetElementByName<IField>(Names.BUG_NL100); } }
        public IGroup BUG_DATA_LINE_8 { get { return GetElementByName<IGroup>(Names.BUG_DATA_LINE_8); } }
        public IField BUG_TYPE_DESC { get { return GetElementByName<IField>(Names.BUG_TYPE_DESC); } }
        public IField BUG_ERROR_TYPE { get { return GetElementByName<IField>(Names.BUG_ERROR_TYPE); } }
        public IField BUG_NL110 { get { return GetElementByName<IField>(Names.BUG_NL110); } }
        public IGroup BUG_DATA_LINE_9 { get { return GetElementByName<IGroup>(Names.BUG_DATA_LINE_9); } }
        public IField BUG_TRMID { get { return GetElementByName<IField>(Names.BUG_TRMID); } }
        public IField BUG_NL120 { get { return GetElementByName<IField>(Names.BUG_NL120); } }
        public IGroup BUG_DATA_LINE_10 { get { return GetElementByName<IGroup>(Names.BUG_DATA_LINE_10); } }
        public IField BUG_TRNSID { get { return GetElementByName<IField>(Names.BUG_TRNSID); } }
        public IField BUG_NL125 { get { return GetElementByName<IField>(Names.BUG_NL125); } }
        public IGroup BUG_LOGO_SECTION { get { return GetElementByName<IGroup>(Names.BUG_LOGO_SECTION); } }
        public IGroup BUG_LOGO_LINE_1 { get { return GetElementByName<IGroup>(Names.BUG_LOGO_LINE_1); } }
        public IField BUG_NL130 { get { return GetElementByName<IField>(Names.BUG_NL130); } }
        public IGroup BUG_LOGO_LINE_2 { get { return GetElementByName<IGroup>(Names.BUG_LOGO_LINE_2); } }
        public IField BUG_NL140 { get { return GetElementByName<IField>(Names.BUG_NL140); } }
        public IGroup BUG_LOGO_LINE_3 { get { return GetElementByName<IGroup>(Names.BUG_LOGO_LINE_3); } }
        public IField BUG_NL150 { get { return GetElementByName<IField>(Names.BUG_NL150); } }
        public IGroup BUG_LOGO_LINE_4 { get { return GetElementByName<IGroup>(Names.BUG_LOGO_LINE_4); } }
        public IField BUG_NL160 { get { return GetElementByName<IField>(Names.BUG_NL160); } }
        public IGroup BUG_LOGO_LINE_5 { get { return GetElementByName<IGroup>(Names.BUG_LOGO_LINE_5); } }
        public IField BUG_NL170 { get { return GetElementByName<IField>(Names.BUG_NL170); } }
        public IGroup BUG_LOGO_LINE_6 { get { return GetElementByName<IGroup>(Names.BUG_LOGO_LINE_6); } }
        public IField BUG_NL180 { get { return GetElementByName<IField>(Names.BUG_NL180); } }
        public IGroup BUG_LOGO_LINE_7 { get { return GetElementByName<IGroup>(Names.BUG_LOGO_LINE_7); } }
        public IField BUG_NL190 { get { return GetElementByName<IField>(Names.BUG_NL190); } }
        public IGroup BUG_LOGO_LINE_8 { get { return GetElementByName<IGroup>(Names.BUG_LOGO_LINE_8); } }
        public IField BUG_NL200 { get { return GetElementByName<IField>(Names.BUG_NL200); } }
        public IGroup BUG_LOGO_LINE_9 { get { return GetElementByName<IGroup>(Names.BUG_LOGO_LINE_9); } }
        public IField BUG_NL210 { get { return GetElementByName<IField>(Names.BUG_NL210); } }
        public IGroup BUG_LOGO_LINE_10 { get { return GetElementByName<IGroup>(Names.BUG_LOGO_LINE_10); } }
        public IField BUG_NL220 { get { return GetElementByName<IField>(Names.BUG_NL220); } }
        public IGroup BUG_LOGO_LINE_11 { get { return GetElementByName<IGroup>(Names.BUG_LOGO_LINE_11); } }
        public IField BUG_NL230 { get { return GetElementByName<IField>(Names.BUG_NL230); } }
        public IGroup BUG_LOGO_LINE_12 { get { return GetElementByName<IGroup>(Names.BUG_LOGO_LINE_12); } }
        public IField BUG_FF020 { get { return GetElementByName<IField>(Names.BUG_FF020); } }
        public IGroup MODULE_VARIABLES { get { return GetElementByName<IGroup>(Names.MODULE_VARIABLES); } }
        public IField MV_SENDING_LINE { get { return GetElementByName<IField>(Names.MV_SENDING_LINE); } }
        public IField MV_LINE_LENGTH { get { return GetElementByName<IField>(Names.MV_LINE_LENGTH); } }
        public IGroup MV_ONLINE_STANDARD { get { return GetElementByName<IGroup>(Names.MV_ONLINE_STANDARD); } }
        public IField MV_CHANGED { get { return GetElementByName<IField>(Names.MV_CHANGED); } }
        public IField MV_ERR_SEVERITY { get { return GetElementByName<IField>(Names.MV_ERR_SEVERITY); } }
        public IField MV_PROGRAM { get { return GetElementByName<IField>(Names.MV_PROGRAM); } }
        public IField MV_SAVE_CA_PARAMETERS { get { return GetElementByName<IField>(Names.MV_SAVE_CA_PARAMETERS); } }
        public IGroup MV_ERR_MSG { get { return GetElementByName<IGroup>(Names.MV_ERR_MSG); } }
        public IField MV_ERR_TYPE { get { return GetElementByName<IField>(Names.MV_ERR_TYPE); } }
        public IField MV_ERR_TEXT { get { return GetElementByName<IField>(Names.MV_ERR_TEXT); } }
        public IGroup MV_SAVE_SCREEN_QID { get { return GetElementByName<IGroup>(Names.MV_SAVE_SCREEN_QID); } }
        public IField MV_SCREEN_TERMID { get { return GetElementByName<IField>(Names.MV_SCREEN_TERMID); } }
        public IGroup MV_ORIG_SCREEN_QID { get { return GetElementByName<IGroup>(Names.MV_ORIG_SCREEN_QID); } }
        public IField MV_ORIG_SCREEN_TERMID { get { return GetElementByName<IField>(Names.MV_ORIG_SCREEN_TERMID); } }
        public IField MV_SZ908_CICS_TIME { get { return GetElementByName<IField>(Names.MV_SZ908_CICS_TIME); } }
        public IField MV_SZ908_CICS_HH { get { return GetElementByName<IField>(Names.MV_SZ908_CICS_HH); } }
        public IField MV_SZ908_CICS_MM { get { return GetElementByName<IField>(Names.MV_SZ908_CICS_MM); } }
        public IGroup MV_SZ908_SCREEN_TIME { get { return GetElementByName<IGroup>(Names.MV_SZ908_SCREEN_TIME); } }
        public IField MV_SZ908_SCREEN_HH { get { return GetElementByName<IField>(Names.MV_SZ908_SCREEN_HH); } }
        public IField MV_SZ908_SCREEN_MM { get { return GetElementByName<IField>(Names.MV_SZ908_SCREEN_MM); } }
        public IGroup MV_SZ908_SCREEN_DATE { get { return GetElementByName<IGroup>(Names.MV_SZ908_SCREEN_DATE); } }
        public IField MV_SZ908_SCREEN_MMDD { get { return GetElementByName<IField>(Names.MV_SZ908_SCREEN_MMDD); } }
        public IField MV_SZ908_SCREEN_YY { get { return GetElementByName<IField>(Names.MV_SZ908_SCREEN_YY); } }
        public IGroup SYSTEM_CONSTANTS { get { return GetElementByName<IGroup>(Names.SYSTEM_CONSTANTS); } }
        public IField SC_ADABAS_ERROR { get { return GetElementByName<IField>(Names.SC_ADABAS_ERROR); } }
        public IField SC_SYSTEM_ERROR { get { return GetElementByName<IField>(Names.SC_SYSTEM_ERROR); } }
        public IField SC_BRIGHT_PRO { get { return GetElementByName<IField>(Names.SC_BRIGHT_PRO); } }
        public IField SC_BRIGHT_UNPRO { get { return GetElementByName<IField>(Names.SC_BRIGHT_UNPRO); } }
        public IField SC_BRIGHT_UNPRO_NUM { get { return GetElementByName<IField>(Names.SC_BRIGHT_UNPRO_NUM); } }
        public IField SC_WARNING { get { return GetElementByName<IField>(Names.SC_WARNING); } }
        public IField SC_ERROR { get { return GetElementByName<IField>(Names.SC_ERROR); } }
        public IField SC_SEVERE { get { return GetElementByName<IField>(Names.SC_SEVERE); } }
        public IField SC_INFORMATION { get { return GetElementByName<IField>(Names.SC_INFORMATION); } }
        public IField SC_CICS_ERROR { get { return GetElementByName<IField>(Names.SC_CICS_ERROR); } }
        public IField SC_ISN_NOT_FOUND { get { return GetElementByName<IField>(Names.SC_ISN_NOT_FOUND); } }
        public IField SC_CLEAR_KEY { get { return GetElementByName<IField>(Names.SC_CLEAR_KEY); } }
        public IField SC_COMMAREA_LENGTH { get { return GetElementByName<IField>(Names.SC_COMMAREA_LENGTH); } }
        public IField SC_ENTER_KEY { get { return GetElementByName<IField>(Names.SC_ENTER_KEY); } }
        public IField SC_CZ_PGM { get { return GetElementByName<IField>(Names.SC_CZ_PGM); } }
        public IField SC_SZ_PGM { get { return GetElementByName<IField>(Names.SC_SZ_PGM); } }
        public IField SC_ERROR_PROGRAM { get { return GetElementByName<IField>(Names.SC_ERROR_PROGRAM); } }
        public IField SC_HELP_PROGRAM { get { return GetElementByName<IField>(Names.SC_HELP_PROGRAM); } }
        public IField SC_HELP_TRANSACTION { get { return GetElementByName<IField>(Names.SC_HELP_TRANSACTION); } }
        public IField SC_NO { get { return GetElementByName<IField>(Names.SC_NO); } }
        public IField SC_NORMAL_PRO { get { return GetElementByName<IField>(Names.SC_NORMAL_PRO); } }
        public IField SC_NORMAL_PRO_NUM { get { return GetElementByName<IField>(Names.SC_NORMAL_PRO_NUM); } }
        public IField SC_NORMAL_UNPRO { get { return GetElementByName<IField>(Names.SC_NORMAL_UNPRO); } }
        public IField SC_NORMAL_UNPRO_NUM { get { return GetElementByName<IField>(Names.SC_NORMAL_UNPRO_NUM); } }
        public IField SC_PF1_KEY { get { return GetElementByName<IField>(Names.SC_PF1_KEY); } }
        public IField SC_PF2_KEY { get { return GetElementByName<IField>(Names.SC_PF2_KEY); } }
        public IField SC_PF3_KEY { get { return GetElementByName<IField>(Names.SC_PF3_KEY); } }
        public IField SC_PF4_KEY { get { return GetElementByName<IField>(Names.SC_PF4_KEY); } }
        public IField SC_PF5_KEY { get { return GetElementByName<IField>(Names.SC_PF5_KEY); } }
        public IField SC_PF6_KEY { get { return GetElementByName<IField>(Names.SC_PF6_KEY); } }
        public IField SC_PF7_KEY { get { return GetElementByName<IField>(Names.SC_PF7_KEY); } }
        public IField SC_PF8_KEY { get { return GetElementByName<IField>(Names.SC_PF8_KEY); } }
        public IField SC_PF9_KEY { get { return GetElementByName<IField>(Names.SC_PF9_KEY); } }
        public IField SC_PF10_KEY { get { return GetElementByName<IField>(Names.SC_PF10_KEY); } }
        public IField SC_PF11_KEY { get { return GetElementByName<IField>(Names.SC_PF11_KEY); } }
        public IField SC_PF12_KEY { get { return GetElementByName<IField>(Names.SC_PF12_KEY); } }
        public IField SC_QUEUE_ITEM { get { return GetElementByName<IField>(Names.SC_QUEUE_ITEM); } }
        public IField SC_SET_CURSOR { get { return GetElementByName<IField>(Names.SC_SET_CURSOR); } }
        public IField SC_YES { get { return GetElementByName<IField>(Names.SC_YES); } }
        public IField SC_MARK_UNCHANGED { get { return GetElementByName<IField>(Names.SC_MARK_UNCHANGED); } }
        public IField SC_MARK_CHANGE { get { return GetElementByName<IField>(Names.SC_MARK_CHANGE); } }
        public IField SC_MARK_OUTPUT { get { return GetElementByName<IField>(Names.SC_MARK_OUTPUT); } }
        public IField SC_MARK_ERROR { get { return GetElementByName<IField>(Names.SC_MARK_ERROR); } }
        public IField SC_MARK_ERROR_NUM { get { return GetElementByName<IField>(Names.SC_MARK_ERROR_NUM); } }
        public IField SC_MARK_WARNING { get { return GetElementByName<IField>(Names.SC_MARK_WARNING); } }
        public IField SC_MARK_WARNING_NUM { get { return GetElementByName<IField>(Names.SC_MARK_WARNING_NUM); } }
        public IField SC_MARK_MERGE_ONLY { get { return GetElementByName<IField>(Names.SC_MARK_MERGE_ONLY); } }
        public IField SRADALNK { get { return GetElementByName<IField>(Names.SRADALNK); } }
        public IField SRMODLNK { get { return GetElementByName<IField>(Names.SRMODLNK); } }
        public IGroup MV_START_DATA { get { return GetElementByName<IGroup>(Names.MV_START_DATA); } }
        public IField MV_START_DATE { get { return GetElementByName<IField>(Names.MV_START_DATE); } }
        public IField MV_START_TRMID { get { return GetElementByName<IField>(Names.MV_START_TRMID); } }
        public IField MV_START_TRNSID { get { return GetElementByName<IField>(Names.MV_START_TRNSID); } }
        public IField MV_START_PGM_NAME { get { return GetElementByName<IField>(Names.MV_START_PGM_NAME); } }
        public IField MV_START_ABEND_TYPE { get { return GetElementByName<IField>(Names.MV_START_ABEND_TYPE); } }
        public IField MV_START_CALL_TYPE { get { return GetElementByName<IField>(Names.MV_START_CALL_TYPE); } }
        public IField MV_START_SEQ_NUMBER { get { return GetElementByName<IField>(Names.MV_START_SEQ_NUMBER); } }
        public IField MV_START_RESPONSE_CODE { get { return GetElementByName<IField>(Names.MV_START_RESPONSE_CODE); } }
        public IField MV_START_TYPE_DESC { get { return GetElementByName<IField>(Names.MV_START_TYPE_DESC); } }
        public IField MV_START_ERROR_TYPE { get { return GetElementByName<IField>(Names.MV_START_ERROR_TYPE); } }
        public IField MV_START_COMMAREA_DUMP1 { get { return GetElementByName<IField>(Names.MV_START_COMMAREA_DUMP1); } }
        public IField MV_START_COMMAREA_DUMP2 { get { return GetElementByName<IField>(Names.MV_START_COMMAREA_DUMP2); } }
        public IField MV_START_COMMAREA_DUMP3 { get { return GetElementByName<IField>(Names.MV_START_COMMAREA_DUMP3); } }
        public IField MV_START_COMMAREA_DUMP4 { get { return GetElementByName<IField>(Names.MV_START_COMMAREA_DUMP4); } }
        public IField MV_START_COMMAREA_DUMP5 { get { return GetElementByName<IField>(Names.MV_START_COMMAREA_DUMP5); } }
        public IField MV_START_COMMAREA_DUMP6 { get { return GetElementByName<IField>(Names.MV_START_COMMAREA_DUMP6); } }
        public IField MV_START_LENGTH { get { return GetElementByName<IField>(Names.MV_START_LENGTH); } }
        public IField MV_START_TERMID { get { return GetElementByName<IField>(Names.MV_START_TERMID); } }

        #endregion

        #region Data structure definition
        /// <summary>
        /// Defines the entirety of the WorkingStorage IRecord structure as described by the Ateras.Framework.Buffer API.
        /// </summary>
        /// <param name="recordDef">The IStructureDefinition object to be used in defining the record structure.</param>
        protected override void DefineRecordStructure(IStructureDefinition recordDef)
        {
            recordDef.CreateNewField(Names.WS_WORKING_STORAGE, FieldType.String, 12, "W/S SWASS915");

            recordDef.CreateNewGroup(Names.MODULE_CONSTANTS, (MODULE_CONSTANTS) =>
           {
               MODULE_CONSTANTS.CreateNewField(Names.MC_THIS_TRANSACTION, FieldType.String, 4, "SRXE");
               MODULE_CONSTANTS.CreateNewField(Names.MC_THIS_PROGRAM, FieldType.String, 8, "SWASS915");
               MODULE_CONSTANTS.CreateNewField(Names.MC_TITLE_LENGTH, FieldType.CompShort, 4, +147);
               MODULE_CONSTANTS.CreateNewField(Names.MC_DATA_LENGTH, FieldType.CompShort, 4, +741);
               MODULE_CONSTANTS.CreateNewField(Names.MC_LOGO_LENGTH, FieldType.CompShort, 4, +809);
               MODULE_CONSTANTS.CreateNewField(Names.MC_PARAMETER_LENGTH, FieldType.CompShort, 4, +12);

               IField MC_NL_local = MODULE_CONSTANTS.CreateNewField(Names.MC_NL, FieldType.CompShort, 2, 21);
               MODULE_CONSTANTS.CreateNewGroupRedefine("FILLER", MC_NL_local, (FILLER) =>
               {
                   FILLER.CreateNewFillerField(1, FillWith.Hashes);
                   FILLER.CreateNewField(Names.MC_NEW_LINE, FieldType.String, 1);
               });

               IField MC_FF_local = MODULE_CONSTANTS.CreateNewField(Names.MC_FF, FieldType.CompShort, 2, 12);
               MODULE_CONSTANTS.CreateNewGroupRedefine("FILLER_d3", MC_FF_local, (FILLER_d3) =>
               {
                   FILLER_d3.CreateNewFillerField(1, FillWith.Hashes);
                   FILLER_d3.CreateNewField(Names.MC_FORMFEED, FieldType.String, 1);
               });

               IField MC_EOM_local = MODULE_CONSTANTS.CreateNewField(Names.MC_EOM, FieldType.CompShort, 2, 25);
               MODULE_CONSTANTS.CreateNewGroupRedefine("FILLER_d5", MC_EOM_local, (FILLER_d5) =>
               {
                   FILLER_d5.CreateNewFillerField(1, FillWith.Hashes);
                   FILLER_d5.CreateNewField(Names.MC_END_OF_MESSAGE, FieldType.String, 1);
               });
           });

            recordDef.CreateNewGroup(Names.BUG_PRINT_TITLE, (BUG_PRINT_TITLE) =>
           {
               BUG_PRINT_TITLE.CreateNewGroup(Names.BUG_PRINT_LINE_1, (BUG_PRINT_LINE_1) =>
               {
                   BUG_PRINT_LINE_1.CreateNewField(Names.BUG_FF010, FieldType.String, 1);
                   BUG_PRINT_LINE_1.CreateNewFillerField(FieldType.String, 17, SPACES);
                   BUG_PRINT_LINE_1.CreateNewFillerField(FieldType.String, 47, "* * * * *   B U G   P R I N T O U T   * * * * *");
                   BUG_PRINT_LINE_1.CreateNewField(Names.BUG_NL010, FieldType.String, 1);
               });
               BUG_PRINT_TITLE.CreateNewGroup(Names.BUG_PRINT_LINE_2, (BUG_PRINT_LINE_2) =>
               {
                   BUG_PRINT_LINE_2.CreateNewFillerField(FieldType.String, 66, SPACES);
                   BUG_PRINT_LINE_2.CreateNewField(Names.BUG_DATE, FieldType.String, 6);
                   BUG_PRINT_LINE_2.CreateNewFillerField(FieldType.String, 2, SPACES);
                   BUG_PRINT_LINE_2.CreateNewField(Names.BUG_TIME, FieldType.String, 5);
                   BUG_PRINT_LINE_2.CreateNewField(Names.BUG_NL020, FieldType.String, 1);
                   BUG_PRINT_LINE_2.CreateNewField(Names.BUG_NL030, FieldType.String, 1);
               });
           });

            recordDef.CreateNewGroup(Names.BUG_DATA_SECTION, (BUG_DATA_SECTION) =>
           {
               BUG_DATA_SECTION.CreateNewGroup(Names.BUG_DATA_LINE_1, (BUG_DATA_LINE_1) =>
               {
                   BUG_DATA_LINE_1.CreateNewFillerField(FieldType.String, 17, " PROGRAM NUMBER: ");
                   BUG_DATA_LINE_1.CreateNewField(Names.BUG_PGM_NAME, FieldType.String, 8);
                   BUG_DATA_LINE_1.CreateNewFillerField(FieldType.String, 4, SPACE);
                   BUG_DATA_LINE_1.CreateNewFillerField(FieldType.String, 50, "....+....1....+.. COMMAREA DUMP ..+....4....+....5");
                   BUG_DATA_LINE_1.CreateNewField(Names.BUG_NL040, FieldType.String, 1);
               });
               BUG_DATA_SECTION.CreateNewGroup(Names.BUG_DATA_LINE_2, (BUG_DATA_LINE_2) =>
               {
                   BUG_DATA_LINE_2.CreateNewFillerField(FieldType.String, 29, SPACE);
                   BUG_DATA_LINE_2.CreateNewField(Names.BUG_COMMAREA_DUMP1, FieldType.String, 50);
                   BUG_DATA_LINE_2.CreateNewField(Names.BUG_NL050, FieldType.String, 1);
               });
               BUG_DATA_SECTION.CreateNewGroup(Names.BUG_DATA_LINE_3, (BUG_DATA_LINE_3) =>
               {
                   BUG_DATA_LINE_3.CreateNewFillerField(FieldType.String, 13, " ABEND TYPE: ");
                   BUG_DATA_LINE_3.CreateNewField(Names.BUG_ABEND_TYPE, FieldType.String, 6);
                   BUG_DATA_LINE_3.CreateNewFillerField(FieldType.String, 10, SPACE);
                   BUG_DATA_LINE_3.CreateNewField(Names.BUG_COMMAREA_DUMP2, FieldType.String, 50);
                   BUG_DATA_LINE_3.CreateNewField(Names.BUG_NL060, FieldType.String, 1);
               });
               BUG_DATA_SECTION.CreateNewGroup(Names.BUG_DATA_LINE_4, (BUG_DATA_LINE_4) =>
               {
                   BUG_DATA_LINE_4.CreateNewFillerField(FieldType.String, 29, SPACE);
                   BUG_DATA_LINE_4.CreateNewField(Names.BUG_COMMAREA_DUMP3, FieldType.String, 50);
                   BUG_DATA_LINE_4.CreateNewField(Names.BUG_NL070, FieldType.String, 1);
               });
               BUG_DATA_SECTION.CreateNewGroup(Names.BUG_DATA_LINE_5, (BUG_DATA_LINE_5) =>
               {
                   BUG_DATA_LINE_5.CreateNewFillerField(FieldType.String, 7, " CALL: ");
                   BUG_DATA_LINE_5.CreateNewField(Names.BUG_CALL_TYPE, FieldType.String, 21);
                   BUG_DATA_LINE_5.CreateNewFillerField(FieldType.String, 1, SPACE);
                   BUG_DATA_LINE_5.CreateNewField(Names.BUG_COMMAREA_DUMP4, FieldType.String, 50);
                   BUG_DATA_LINE_5.CreateNewField(Names.BUG_NL080, FieldType.String, 1);
               });
               BUG_DATA_SECTION.CreateNewGroup(Names.BUG_DATA_LINE_6, (BUG_DATA_LINE_6) =>
               {
                   BUG_DATA_LINE_6.CreateNewFillerField(FieldType.String, 7, " LINE: ");
                   BUG_DATA_LINE_6.CreateNewField(Names.BUG_SEQ_NUMBER, FieldType.String, 8);
                   BUG_DATA_LINE_6.CreateNewFillerField(FieldType.String, 14, SPACE);
                   BUG_DATA_LINE_6.CreateNewField(Names.BUG_COMMAREA_DUMP5, FieldType.String, 50);
                   BUG_DATA_LINE_6.CreateNewField(Names.BUG_NL090, FieldType.String, 1);
               });
               BUG_DATA_SECTION.CreateNewGroup(Names.BUG_DATA_LINE_7, (BUG_DATA_LINE_7) =>
               {
                   BUG_DATA_LINE_7.CreateNewFillerField(FieldType.String, 7, " RESP: ");
                   BUG_DATA_LINE_7.CreateNewField(Names.BUG_RESPONSE_CODE, FieldType.String, 12);
                   BUG_DATA_LINE_7.CreateNewFillerField(FieldType.String, 10, SPACE);
                   BUG_DATA_LINE_7.CreateNewField(Names.BUG_COMMAREA_DUMP6, FieldType.String, 50);
                   BUG_DATA_LINE_7.CreateNewField(Names.BUG_NL100, FieldType.String, 1);
               });
               BUG_DATA_SECTION.CreateNewGroup(Names.BUG_DATA_LINE_8, (BUG_DATA_LINE_8) =>
               {
                   BUG_DATA_LINE_8.CreateNewFillerField(FieldType.String, 1, SPACE);
                   BUG_DATA_LINE_8.CreateNewField(Names.BUG_TYPE_DESC, FieldType.String, 6);
                   BUG_DATA_LINE_8.CreateNewField(Names.BUG_ERROR_TYPE, FieldType.String, 8);
                   BUG_DATA_LINE_8.CreateNewFillerField(FieldType.String, 14, SPACE);
                   BUG_DATA_LINE_8.CreateNewFillerField(FieldType.String, 50, "....+....1....+....2....+....3....+....4....+....5");
                   BUG_DATA_LINE_8.CreateNewField(Names.BUG_NL110, FieldType.String, 1);
               });
               BUG_DATA_SECTION.CreateNewGroup(Names.BUG_DATA_LINE_9, (BUG_DATA_LINE_9) =>
               {
                   BUG_DATA_LINE_9.CreateNewFillerField(FieldType.String, 17, " TERMINAL ID:    ");
                   BUG_DATA_LINE_9.CreateNewField(Names.BUG_TRMID, FieldType.String, 4);
                   BUG_DATA_LINE_9.CreateNewField(Names.BUG_NL120, FieldType.String, 1);
               });
               BUG_DATA_SECTION.CreateNewGroup(Names.BUG_DATA_LINE_10, (BUG_DATA_LINE_10) =>
               {
                   BUG_DATA_LINE_10.CreateNewFillerField(FieldType.String, 17, " TRANSACTION ID: ");
                   BUG_DATA_LINE_10.CreateNewField(Names.BUG_TRNSID, FieldType.String, 4);
                   BUG_DATA_LINE_10.CreateNewFillerField(FieldType.String, 26, SPACE);
                   BUG_DATA_LINE_10.CreateNewFillerField(FieldType.String, 31, "@");
                   BUG_DATA_LINE_10.CreateNewField(Names.BUG_NL125, FieldType.String, 1);
               });
           });

            recordDef.CreateNewGroup(Names.BUG_LOGO_SECTION, (BUG_LOGO_SECTION) =>
           {
               BUG_LOGO_SECTION.CreateNewGroup(Names.BUG_LOGO_LINE_1, (BUG_LOGO_LINE_1) =>
               {
                   BUG_LOGO_LINE_1.CreateNewFillerField(FieldType.String, 49, SPACE);
                   BUG_LOGO_LINE_1.CreateNewFillerField(FieldType.String, 27, "@");
                   BUG_LOGO_LINE_1.CreateNewField(Names.BUG_NL130, FieldType.String, 1);
               });
               BUG_LOGO_SECTION.CreateNewGroup(Names.BUG_LOGO_LINE_2, (BUG_LOGO_LINE_2) =>
               {
                   BUG_LOGO_LINE_2.CreateNewFillerField(FieldType.String, 29, SPACE);
                   BUG_LOGO_LINE_2.CreateNewFillerField(FieldType.String, 14, "\"TOTO, I DON\"T");
                   BUG_LOGO_LINE_2.CreateNewFillerField(FieldType.String, 8, SPACE);
                   BUG_LOGO_LINE_2.CreateNewFillerField(FieldType.String, 21, "@");
                   BUG_LOGO_LINE_2.CreateNewField(Names.BUG_NL140, FieldType.String, 1);
               });
               BUG_LOGO_SECTION.CreateNewGroup(Names.BUG_LOGO_LINE_3, (BUG_LOGO_LINE_3) =>
               {
                   BUG_LOGO_LINE_3.CreateNewFillerField(FieldType.String, 19, "        T  O  T  O ");
                   BUG_LOGO_LINE_3.CreateNewFillerField(FieldType.String, 10, SPACE);
                   BUG_LOGO_LINE_3.CreateNewFillerField(FieldType.String, 14, "THINK WE\"RE IN");
                   BUG_LOGO_LINE_3.CreateNewFillerField(FieldType.String, 12, SPACE);
                   BUG_LOGO_LINE_3.CreateNewFillerField(FieldType.String, 15, "@");
                   BUG_LOGO_LINE_3.CreateNewField(Names.BUG_NL150, FieldType.String, 1);
               });
               BUG_LOGO_SECTION.CreateNewGroup(Names.BUG_LOGO_LINE_4, (BUG_LOGO_LINE_4) =>
               {
                   BUG_LOGO_LINE_4.CreateNewFillerField(FieldType.String, 26, " -------------------------");
                   BUG_LOGO_LINE_4.CreateNewFillerField(FieldType.String, 23, "  CAECSES ANYMORE !!\"");
                   BUG_LOGO_LINE_4.CreateNewFillerField(FieldType.String, 11, SPACE);
                   BUG_LOGO_LINE_4.CreateNewFillerField(FieldType.String, 9, "@");
                   BUG_LOGO_LINE_4.CreateNewField(Names.BUG_NL160, FieldType.String, 1);
               });
               BUG_LOGO_SECTION.CreateNewGroup(Names.BUG_LOGO_LINE_5, (BUG_LOGO_LINE_5) =>
               {
                   BUG_LOGO_LINE_5.CreateNewFillerField(FieldType.String, 26, " PLEASE SEND THIS PRINTOUT");
                   BUG_LOGO_LINE_5.CreateNewFillerField(FieldType.String, 35, SPACE);
                   BUG_LOGO_LINE_5.CreateNewFillerField(FieldType.String, 8, "@");
                   BUG_LOGO_LINE_5.CreateNewField(Names.BUG_NL170, FieldType.String, 1);
               });
               BUG_LOGO_SECTION.CreateNewGroup(Names.BUG_LOGO_LINE_6, (BUG_LOGO_LINE_6) =>
               {
                   BUG_LOGO_LINE_6.CreateNewFillerField(FieldType.String, 26, "  TO YOUR SYSTEMS SUPPORT ");
                   BUG_LOGO_LINE_6.CreateNewFillerField(FieldType.String, 13, SPACE);
                   BUG_LOGO_LINE_6.CreateNewFillerField(FieldType.String, 1, "X");
                   BUG_LOGO_LINE_6.CreateNewFillerField(FieldType.String, 22, SPACE);
                   BUG_LOGO_LINE_6.CreateNewFillerField(FieldType.String, 8, "@");
                   BUG_LOGO_LINE_6.CreateNewField(Names.BUG_NL180, FieldType.String, 1);
               });
               BUG_LOGO_SECTION.CreateNewGroup(Names.BUG_LOGO_LINE_7, (BUG_LOGO_LINE_7) =>
               {
                   BUG_LOGO_LINE_7.CreateNewFillerField(FieldType.String, 26, "           GROUP.         ");
                   BUG_LOGO_LINE_7.CreateNewFillerField(FieldType.String, 19, "    X         X0XXX");
                   BUG_LOGO_LINE_7.CreateNewFillerField(FieldType.String, 18, SPACE);
                   BUG_LOGO_LINE_7.CreateNewFillerField(FieldType.String, 7, "@");
                   BUG_LOGO_LINE_7.CreateNewField(Names.BUG_NL190, FieldType.String, 1);
               });
               BUG_LOGO_SECTION.CreateNewGroup(Names.BUG_LOGO_LINE_8, (BUG_LOGO_LINE_8) =>
               {
                   BUG_LOGO_LINE_8.CreateNewFillerField(FieldType.String, 26, " -------------------------");
                   BUG_LOGO_LINE_8.CreateNewFillerField(FieldType.String, 19, "     X        XXXXX");
                   BUG_LOGO_LINE_8.CreateNewFillerField(FieldType.String, 15, SPACE);
                   BUG_LOGO_LINE_8.CreateNewFillerField(FieldType.String, 7, "@");
                   BUG_LOGO_LINE_8.CreateNewField(Names.BUG_NL200, FieldType.String, 1);
               });
               BUG_LOGO_SECTION.CreateNewGroup(Names.BUG_LOGO_LINE_9, (BUG_LOGO_LINE_9) =>
               {
                   BUG_LOGO_LINE_9.CreateNewFillerField(FieldType.String, 32, SPACE);
                   BUG_LOGO_LINE_9.CreateNewFillerField(FieldType.String, 10, "XXXXXXXXXX");
                   BUG_LOGO_LINE_9.CreateNewFillerField(FieldType.String, 15, SPACE);
                   BUG_LOGO_LINE_9.CreateNewFillerField(FieldType.String, 3, "@");
                   BUG_LOGO_LINE_9.CreateNewField(Names.BUG_NL210, FieldType.String, 1);
               });
               BUG_LOGO_SECTION.CreateNewGroup(Names.BUG_LOGO_LINE_10, (BUG_LOGO_LINE_10) =>
               {
                   BUG_LOGO_LINE_10.CreateNewFillerField(FieldType.String, 32, SPACE);
                   BUG_LOGO_LINE_10.CreateNewFillerField(FieldType.String, 10, "XXXXXXXXXX");
                   BUG_LOGO_LINE_10.CreateNewFillerField(FieldType.String, 14, SPACE);
                   BUG_LOGO_LINE_10.CreateNewFillerField(FieldType.String, 2, "@");
                   BUG_LOGO_LINE_10.CreateNewField(Names.BUG_NL220, FieldType.String, 1);
               });
               BUG_LOGO_SECTION.CreateNewGroup(Names.BUG_LOGO_LINE_11, (BUG_LOGO_LINE_11) =>
               {
                   BUG_LOGO_LINE_11.CreateNewFillerField(FieldType.String, 32, SPACE);
                   BUG_LOGO_LINE_11.CreateNewFillerField(FieldType.String, 10, "X        X");
                   BUG_LOGO_LINE_11.CreateNewFillerField(FieldType.String, 15, SPACE);
                   BUG_LOGO_LINE_11.CreateNewFillerField(FieldType.String, 1, "@");
                   BUG_LOGO_LINE_11.CreateNewField(Names.BUG_NL230, FieldType.String, 1);
               });
               BUG_LOGO_SECTION.CreateNewGroup(Names.BUG_LOGO_LINE_12, (BUG_LOGO_LINE_12) =>
               {
                   BUG_LOGO_LINE_12.CreateNewFillerField(FieldType.String, 57, SPACE);
                   BUG_LOGO_LINE_12.CreateNewFillerField(FieldType.String, 1, "@");
                   BUG_LOGO_LINE_12.CreateNewField(Names.BUG_FF020, FieldType.String, 1);
               });
           });

            recordDef.CreateNewGroup(Names.MODULE_VARIABLES, (MODULE_VARIABLES) =>
           {
               MODULE_VARIABLES.CreateNewField(Names.MV_SENDING_LINE, FieldType.String, 920);
               MODULE_VARIABLES.CreateNewField(Names.MV_LINE_LENGTH, FieldType.CompShort, 4);
           });

            recordDef.CreateNewGroup(Names.MV_ONLINE_STANDARD, (MV_ONLINE_STANDARD) =>
           {
               MV_ONLINE_STANDARD.CreateNewField(Names.MV_CHANGED, FieldType.String, 1, SPACE);
               MV_ONLINE_STANDARD.CreateNewField(Names.MV_ERR_SEVERITY, FieldType.String, 1, SPACE);
               MV_ONLINE_STANDARD.CreateNewField(Names.MV_PROGRAM, FieldType.String, 8, SPACES);
               MV_ONLINE_STANDARD.CreateNewField(Names.MV_SAVE_CA_PARAMETERS, FieldType.String, 500);
               MV_ONLINE_STANDARD.CreateNewGroup(Names.MV_ERR_MSG, (MV_ERR_MSG) =>
               {
                   MV_ERR_MSG.CreateNewField(Names.MV_ERR_TYPE, FieldType.String, 13, SPACES);
                   MV_ERR_MSG.CreateNewField(Names.MV_ERR_TEXT, FieldType.String, 66, SPACES);
               });
               MV_ONLINE_STANDARD.CreateNewGroup(Names.MV_SAVE_SCREEN_QID, (MV_SAVE_SCREEN_QID) =>
               {
                   MV_SAVE_SCREEN_QID.CreateNewField(Names.MV_SCREEN_TERMID, FieldType.String, 4, SPACES);
                   MV_SAVE_SCREEN_QID.CreateNewFillerField(FieldType.String, 4, "SQ01");
               });
               MV_ONLINE_STANDARD.CreateNewGroup(Names.MV_ORIG_SCREEN_QID, (MV_ORIG_SCREEN_QID) =>
               {
                   MV_ORIG_SCREEN_QID.CreateNewField(Names.MV_ORIG_SCREEN_TERMID, FieldType.String, 4, SPACES);
                   MV_ORIG_SCREEN_QID.CreateNewFillerField(FieldType.String, 4, "SQ02");
               });

               IField MV_SZ908_CICS_TIME_local = MV_ONLINE_STANDARD.CreateNewField(Names.MV_SZ908_CICS_TIME, FieldType.UnsignedNumeric, 7, ZEROS);
               MV_ONLINE_STANDARD.CreateNewGroupRedefine("FILLER_d78", MV_SZ908_CICS_TIME_local, (FILLER_d78) =>
               {
                   FILLER_d78.CreateNewFillerField(1, FillWith.Hashes);
                   FILLER_d78.CreateNewField(Names.MV_SZ908_CICS_HH, FieldType.String, 2);
                   FILLER_d78.CreateNewField(Names.MV_SZ908_CICS_MM, FieldType.String, 2);
               });
               MV_ONLINE_STANDARD.CreateNewGroup(Names.MV_SZ908_SCREEN_TIME, (MV_SZ908_SCREEN_TIME) =>
               {
                   MV_SZ908_SCREEN_TIME.CreateNewField(Names.MV_SZ908_SCREEN_HH, FieldType.String, 2, SPACES);
                   MV_SZ908_SCREEN_TIME.CreateNewFillerField(FieldType.String, 1, ":");
                   MV_SZ908_SCREEN_TIME.CreateNewField(Names.MV_SZ908_SCREEN_MM, FieldType.String, 2, SPACES);
               });
               MV_ONLINE_STANDARD.CreateNewGroup(Names.MV_SZ908_SCREEN_DATE, (MV_SZ908_SCREEN_DATE) =>
               {
                   MV_SZ908_SCREEN_DATE.CreateNewField(Names.MV_SZ908_SCREEN_MMDD, FieldType.UnsignedNumeric, 4, ZEROS);
                   MV_SZ908_SCREEN_DATE.CreateNewField(Names.MV_SZ908_SCREEN_YY, FieldType.UnsignedNumeric, 2, ZEROS);
               });
           });

            recordDef.CreateNewGroup(Names.SYSTEM_CONSTANTS, (SYSTEM_CONSTANTS) =>
           {
               SYSTEM_CONSTANTS.CreateNewField(Names.SC_ADABAS_ERROR, FieldType.String, 1, "A");
               SYSTEM_CONSTANTS.CreateNewField(Names.SC_SYSTEM_ERROR, FieldType.String, 1, "S");
               SYSTEM_CONSTANTS.CreateNewField(Names.SC_BRIGHT_PRO, FieldType.String, 1, "8");
               SYSTEM_CONSTANTS.CreateNewField(Names.SC_BRIGHT_UNPRO, FieldType.String, 1, "H");
               SYSTEM_CONSTANTS.CreateNewField(Names.SC_BRIGHT_UNPRO_NUM, FieldType.String, 1, "Q");
               SYSTEM_CONSTANTS.CreateNewField(Names.SC_WARNING, FieldType.String, 1, "2");
               SYSTEM_CONSTANTS.CreateNewField(Names.SC_ERROR, FieldType.String, 1, "3");
               SYSTEM_CONSTANTS.CreateNewField(Names.SC_SEVERE, FieldType.String, 1, "4");
               SYSTEM_CONSTANTS.CreateNewField(Names.SC_INFORMATION, FieldType.String, 1, "1");
               SYSTEM_CONSTANTS.CreateNewField(Names.SC_CICS_ERROR, FieldType.String, 1, "C");
               SYSTEM_CONSTANTS.CreateNewField(Names.SC_ISN_NOT_FOUND, FieldType.CompShort, 4, +113);
               SYSTEM_CONSTANTS.CreateNewField(Names.SC_CLEAR_KEY, FieldType.String, 1, "_");
               SYSTEM_CONSTANTS.CreateNewField(Names.SC_COMMAREA_LENGTH, FieldType.CompShort, 4, +3000);
               SYSTEM_CONSTANTS.CreateNewField(Names.SC_ENTER_KEY, FieldType.String, 1, QUOTE);
               SYSTEM_CONSTANTS.CreateNewField(Names.SC_CZ_PGM, FieldType.String, 8, "SWACZ000");
               SYSTEM_CONSTANTS.CreateNewField(Names.SC_SZ_PGM, FieldType.String, 8, "SWASZ000");
               SYSTEM_CONSTANTS.CreateNewField(Names.SC_ERROR_PROGRAM, FieldType.String, 8, "SWASS910");
               SYSTEM_CONSTANTS.CreateNewField(Names.SC_HELP_PROGRAM, FieldType.String, 8, "SWASH100");
               SYSTEM_CONSTANTS.CreateNewField(Names.SC_HELP_TRANSACTION, FieldType.String, 4, "SRPA");
               SYSTEM_CONSTANTS.CreateNewField(Names.SC_NO, FieldType.String, 1, "N");
               SYSTEM_CONSTANTS.CreateNewField(Names.SC_NORMAL_PRO, FieldType.String, 1, "0");
               SYSTEM_CONSTANTS.CreateNewField(Names.SC_NORMAL_PRO_NUM, FieldType.String, 1, "4");
               SYSTEM_CONSTANTS.CreateNewField(Names.SC_NORMAL_UNPRO, FieldType.String, 1, "D");
               SYSTEM_CONSTANTS.CreateNewField(Names.SC_NORMAL_UNPRO_NUM, FieldType.String, 1, "M");
               SYSTEM_CONSTANTS.CreateNewField(Names.SC_PF1_KEY, FieldType.String, 1, "1");
               SYSTEM_CONSTANTS.CreateNewField(Names.SC_PF2_KEY, FieldType.String, 1, "2");
               SYSTEM_CONSTANTS.CreateNewField(Names.SC_PF3_KEY, FieldType.String, 1, "3");
               SYSTEM_CONSTANTS.CreateNewField(Names.SC_PF4_KEY, FieldType.String, 1, "4");
               SYSTEM_CONSTANTS.CreateNewField(Names.SC_PF5_KEY, FieldType.String, 1, "5");
               SYSTEM_CONSTANTS.CreateNewField(Names.SC_PF6_KEY, FieldType.String, 1, "6");
               SYSTEM_CONSTANTS.CreateNewField(Names.SC_PF7_KEY, FieldType.String, 1, "7");
               SYSTEM_CONSTANTS.CreateNewField(Names.SC_PF8_KEY, FieldType.String, 1, "8");
               SYSTEM_CONSTANTS.CreateNewField(Names.SC_PF9_KEY, FieldType.String, 1, "9");
               SYSTEM_CONSTANTS.CreateNewField(Names.SC_PF10_KEY, FieldType.String, 1, ":");
               SYSTEM_CONSTANTS.CreateNewField(Names.SC_PF11_KEY, FieldType.String, 1, "#");
               SYSTEM_CONSTANTS.CreateNewField(Names.SC_PF12_KEY, FieldType.String, 1, "@");
               SYSTEM_CONSTANTS.CreateNewField(Names.SC_QUEUE_ITEM, FieldType.CompShort, 4, +1);
               SYSTEM_CONSTANTS.CreateNewField(Names.SC_SET_CURSOR, FieldType.CompShort, 4, -1);
               SYSTEM_CONSTANTS.CreateNewField(Names.SC_YES, FieldType.String, 1, "Y");
               SYSTEM_CONSTANTS.CreateNewField(Names.SC_MARK_UNCHANGED, FieldType.CompShort, 4, -2);
               SYSTEM_CONSTANTS.CreateNewField(Names.SC_MARK_CHANGE, FieldType.CompShort, 4, -3);
               SYSTEM_CONSTANTS.CreateNewField(Names.SC_MARK_OUTPUT, FieldType.CompShort, 4, -4);
               SYSTEM_CONSTANTS.CreateNewField(Names.SC_MARK_ERROR, FieldType.CompShort, 4, -5);
               SYSTEM_CONSTANTS.CreateNewField(Names.SC_MARK_ERROR_NUM, FieldType.CompShort, 4, -6);
               SYSTEM_CONSTANTS.CreateNewField(Names.SC_MARK_WARNING, FieldType.CompShort, 4, -7);
               SYSTEM_CONSTANTS.CreateNewField(Names.SC_MARK_WARNING_NUM, FieldType.CompShort, 4, -8);
               SYSTEM_CONSTANTS.CreateNewField(Names.SC_MARK_MERGE_ONLY, FieldType.CompShort, 4, -9);
               SYSTEM_CONSTANTS.CreateNewField(Names.SRADALNK, FieldType.String, 8, "SWASZ990");
               SYSTEM_CONSTANTS.CreateNewField(Names.SRMODLNK, FieldType.String, 8, "SWASS915");
           });

            recordDef.CreateNewGroup(Names.MV_START_DATA, (MV_START_DATA) =>
           {
               MV_START_DATA.CreateNewField(Names.MV_START_DATE, FieldType.String, 6);
               MV_START_DATA.CreateNewField(Names.MV_START_TRMID, FieldType.String, 4);
               MV_START_DATA.CreateNewField(Names.MV_START_TRNSID, FieldType.String, 4);
               MV_START_DATA.CreateNewField(Names.MV_START_PGM_NAME, FieldType.String, 8);
               MV_START_DATA.CreateNewField(Names.MV_START_ABEND_TYPE, FieldType.String, 6);
               MV_START_DATA.CreateNewField(Names.MV_START_CALL_TYPE, FieldType.String, 21);
               MV_START_DATA.CreateNewField(Names.MV_START_SEQ_NUMBER, FieldType.String, 8);
               MV_START_DATA.CreateNewField(Names.MV_START_RESPONSE_CODE, FieldType.String, 12);
               MV_START_DATA.CreateNewField(Names.MV_START_TYPE_DESC, FieldType.String, 5);
               MV_START_DATA.CreateNewField(Names.MV_START_ERROR_TYPE, FieldType.String, 8);
               MV_START_DATA.CreateNewField(Names.MV_START_COMMAREA_DUMP1, FieldType.String, 50);
               MV_START_DATA.CreateNewField(Names.MV_START_COMMAREA_DUMP2, FieldType.String, 50);
               MV_START_DATA.CreateNewField(Names.MV_START_COMMAREA_DUMP3, FieldType.String, 50);
               MV_START_DATA.CreateNewField(Names.MV_START_COMMAREA_DUMP4, FieldType.String, 50);
               MV_START_DATA.CreateNewField(Names.MV_START_COMMAREA_DUMP5, FieldType.String, 50);
               MV_START_DATA.CreateNewField(Names.MV_START_COMMAREA_DUMP6, FieldType.String, 50);
           });
            recordDef.CreateNewField(Names.MV_START_LENGTH, FieldType.CompShort, 4, +382);
            recordDef.CreateNewField(Names.MV_START_TERMID, FieldType.String, 4);

        }

        protected override string GetRecordName()
        {
            return Names.WorkingStorage;
        }
        #endregion

    }
    #endregion Working Storage Class

    #region Linkage Section Class
    internal class SWASS915_ls : PredefinedRecordBase
    {
        #region Name constants
        /// <summary>
        /// Name constants.
        /// </summary>
        internal static class Names
        {
            internal const string LinkageSection = "SWASS915_ls_LinkageSection";
            internal const string DFHCOMMAREA = "DFHCOMMAREA";
            internal const string CA_SECURITY_KEY = "CA_SECURITY_KEY";
            internal const string CA_UPDATE_ALLOWED = "CA_UPDATE_ALLOWED";
            internal const string CA_USER_SHORT_NAME = "CA_USER_SHORT_NAME";
            internal const string CA_PEN = "CA_PEN";
            internal const string CA_MAIN_MENU = "CA_MAIN_MENU";
            internal const string CA_PREV_MENU = "CA_PREV_MENU";
            internal const string CA_MENU_SELECTION = "CA_MENU_SELECTION";
            internal const string CA_ERR_SEVERITY = "CA_ERR_SEVERITY";
            internal const string CA_NEXT_PROGRAM = "CA_NEXT_PROGRAM";
            internal const string CA_THIS_PROGRAM = "CA_THIS_PROGRAM";
            internal const string CA_NEXT_SCREEN_ID = "CA_NEXT_SCREEN_ID";
            internal const string CA_THIS_SCREEN_ID = "CA_THIS_SCREEN_ID";
            internal const string CA_CLIENT_NUMBER = "CA_CLIENT_NUMBER";
            internal const string CA_CAECSES_CLIENT = "CA_CAECSES_CLIENT";
            internal const string CA_CASE_NAME = "CA_CASE_NAME";
            internal const string CA_CASE_NUMBER = "CA_CASE_NUMBER";
            internal const string CA_PROGRAM_TYPE = "CA_PROGRAM_TYPE";
            internal const string CA_DOCUMENT_ID = "CA_DOCUMENT_ID";
            internal const string CA_BENEFIT_MONTH = "CA_BENEFIT_MONTH";
            internal const string CA_BUDGETTING_METHOD = "CA_BUDGETTING_METHOD";
            internal const string CA_CASELOAD_ID = "CA_CASELOAD_ID";
            internal const string CA_CASELOAD_NUMBER = "CA_CASELOAD_NUMBER";
            internal const string CA_UNIT = "CA_UNIT";
            internal const string CA_SECTION = "CA_SECTION";
            internal const string CA_RECOUPMENT_NUMBER = "CA_RECOUPMENT_NUMBER";
            internal const string CA_SECURITY_POINTER = "CA_SECURITY_POINTER";
            internal const string CA_SECURITY_PROFILE = "CA_SECURITY_PROFILE";
            internal const string CA_ADABAS_PASSWORD = "CA_ADABAS_PASSWORD";
            internal const string CA_REVIEWEE_PEN = "CA_REVIEWEE_PEN";
            internal const string CA_REVIEWER_PEN = "CA_REVIEWER_PEN";
            internal const string EISDATE = "EISDATE";
            internal const string CA_ENVIRONMENT = "CA_ENVIRONMENT";
            internal const string CA_QC_REVIEW_NUMBER = "CA_QC_REVIEW_NUMBER";
            internal const string CA_EXP_DESIGNATOR = "CA_EXP_DESIGNATOR";
            internal const string CA_CONTROL_CASE = "CA_CONTROL_CASE";
            internal const string CA_NOT_CONTROL_CASE = "CA_NOT_CONTROL_CASE";
            internal const string CA_EXP_CASE = "CA_EXP_CASE";
            internal const string CA_OTHER_CASE = "CA_OTHER_CASE";
            internal const string CA_CURRENT_DATE = "CA_CURRENT_DATE";
            internal const string CA_CURRENT_CC = "CA_CURRENT_CC";
            internal const string CA_CURRENT_YY = "CA_CURRENT_YY";
            internal const string CA_CURRENT_MMDD = "CA_CURRENT_MMDD";
            internal const string CA_CURRENT_MM = "CA_CURRENT_MM";
            internal const string CA_CURRENT_DD = "CA_CURRENT_DD";
            internal const string CA_RESTART_PROGRAM = "CA_RESTART_PROGRAM";
            internal const string CA_BEN_MO_CHG_IND = "CA_BEN_MO_CHG_IND";
            internal const string CA_SAVE_UPDATE_ALLOWED = "CA_SAVE_UPDATE_ALLOWED";
            internal const string CA_VTAM_PRINTER_ID = "CA_VTAM_PRINTER_ID";
            internal const string CA_VTAM_PRINTER_ID_1_4 = "CA_VTAM_PRINTER_ID_1_4";
            internal const string CA_VTAM_PRINTER_ID_5_8 = "CA_VTAM_PRINTER_ID_5_8";
            internal const string CA_MAP_SAVE_AREA = "CA_MAP_SAVE_AREA";
            internal const string CA_CZ610_HH_CLIENTS = "CA_CZ610_HH_CLIENTS";
            internal const string CA_SAVE_UPDATE_ALLOWED_N = "CA_SAVE_UPDATE_ALLOWED_N";
            internal const string CA_FIRST_TIME = "CA_FIRST_TIME";
            internal const string CA_ABEND_INFO_AREA = "CA_ABEND_INFO_AREA";
            internal const string CA_INFO_POINTR = "CA_INFO_POINTR";
            internal const string CA_INFO_ABEND_DATA = "CA_INFO_ABEND_DATA";
            internal const string CA_PARAMETERS = "CA_PARAMETERS";
            internal const string CA_ERROR_PARAMETERS = "CA_ERROR_PARAMETERS";
            internal const string CA_ERR_TEXT = "CA_ERR_TEXT";
            internal const string CA_ABEND_PARAMETERS = "CA_ABEND_PARAMETERS";
            internal const string CA_ABEND_TYPE = "CA_ABEND_TYPE";
            internal const string CA_ABEND_LINE = "CA_ABEND_LINE";
            internal const string CA_ADA_CALL_SEQ = "CA_ADA_CALL_SEQ";
            internal const string CA_ADA_RESPONSE_CODE = "CA_ADA_RESPONSE_CODE";
            internal const string CA_CICS_FUNCTION_CODE = "CA_CICS_FUNCTION_CODE";
            internal const string CA_CICS_RESOURCE_NAME = "CA_CICS_RESOURCE_NAME";
            internal const string CA_CICS_RESPONSE_CODE = "CA_CICS_RESPONSE_CODE";
            internal const string TWA = "TWA";
            internal const string TWA_ADABAS_PARMS = "TWA_ADABAS_PARMS";
            internal const string TWA_CICS_PARMS = "TWA_CICS_PARMS";
            internal const string TWA_PROGRAM_ID = "TWA_PROGRAM_ID";
            internal const string TWA_ADDR_LIST = "TWA_ADDR_LIST";
        }
        #endregion

        #region Direct-access element properties
        public IGroup DFHCOMMAREA { get { return GetElementByName<IGroup>(Names.DFHCOMMAREA); } }
        public IField CA_SECURITY_KEY { get { return GetElementByName<IField>(Names.CA_SECURITY_KEY); } }
        public IField CA_UPDATE_ALLOWED { get { return GetElementByName<IField>(Names.CA_UPDATE_ALLOWED); } }
        public IField CA_USER_SHORT_NAME { get { return GetElementByName<IField>(Names.CA_USER_SHORT_NAME); } }
        public IField CA_PEN { get { return GetElementByName<IField>(Names.CA_PEN); } }
        public IField CA_MAIN_MENU { get { return GetElementByName<IField>(Names.CA_MAIN_MENU); } }
        public IField CA_PREV_MENU { get { return GetElementByName<IField>(Names.CA_PREV_MENU); } }
        public IField CA_MENU_SELECTION { get { return GetElementByName<IField>(Names.CA_MENU_SELECTION); } }
        public IField CA_ERR_SEVERITY { get { return GetElementByName<IField>(Names.CA_ERR_SEVERITY); } }
        public IField CA_NEXT_PROGRAM { get { return GetElementByName<IField>(Names.CA_NEXT_PROGRAM); } }
        public IField CA_THIS_PROGRAM { get { return GetElementByName<IField>(Names.CA_THIS_PROGRAM); } }
        public IField CA_NEXT_SCREEN_ID { get { return GetElementByName<IField>(Names.CA_NEXT_SCREEN_ID); } }
        public IField CA_THIS_SCREEN_ID { get { return GetElementByName<IField>(Names.CA_THIS_SCREEN_ID); } }
        public IField CA_CLIENT_NUMBER { get { return GetElementByName<IField>(Names.CA_CLIENT_NUMBER); } }
        public IField CA_CAECSES_CLIENT { get { return GetElementByName<IField>(Names.CA_CAECSES_CLIENT); } }
        public IField CA_CASE_NAME { get { return GetElementByName<IField>(Names.CA_CASE_NAME); } }
        public IField CA_CASE_NUMBER { get { return GetElementByName<IField>(Names.CA_CASE_NUMBER); } }
        public IField CA_PROGRAM_TYPE { get { return GetElementByName<IField>(Names.CA_PROGRAM_TYPE); } }
        public IField CA_DOCUMENT_ID { get { return GetElementByName<IField>(Names.CA_DOCUMENT_ID); } }
        public IField CA_BENEFIT_MONTH { get { return GetElementByName<IField>(Names.CA_BENEFIT_MONTH); } }
        public IField CA_BUDGETTING_METHOD { get { return GetElementByName<IField>(Names.CA_BUDGETTING_METHOD); } }
        public IGroup CA_CASELOAD_ID { get { return GetElementByName<IGroup>(Names.CA_CASELOAD_ID); } }
        public IField CA_CASELOAD_NUMBER { get { return GetElementByName<IField>(Names.CA_CASELOAD_NUMBER); } }
        public IField CA_UNIT { get { return GetElementByName<IField>(Names.CA_UNIT); } }
        public IField CA_SECTION { get { return GetElementByName<IField>(Names.CA_SECTION); } }
        public IField CA_RECOUPMENT_NUMBER { get { return GetElementByName<IField>(Names.CA_RECOUPMENT_NUMBER); } }
        public IField CA_SECURITY_POINTER { get { return GetElementByName<IField>(Names.CA_SECURITY_POINTER); } }
        public IField CA_SECURITY_PROFILE { get { return GetElementByName<IField>(Names.CA_SECURITY_PROFILE); } }
        public IField CA_ADABAS_PASSWORD { get { return GetElementByName<IField>(Names.CA_ADABAS_PASSWORD); } }
        public IField CA_REVIEWEE_PEN { get { return GetElementByName<IField>(Names.CA_REVIEWEE_PEN); } }
        public IField CA_REVIEWER_PEN { get { return GetElementByName<IField>(Names.CA_REVIEWER_PEN); } }
        public IField EISDATE { get { return GetElementByName<IField>(Names.EISDATE); } }
        public IField CA_ENVIRONMENT { get { return GetElementByName<IField>(Names.CA_ENVIRONMENT); } }
        public IField CA_QC_REVIEW_NUMBER { get { return GetElementByName<IField>(Names.CA_QC_REVIEW_NUMBER); } }
        public IField CA_EXP_DESIGNATOR { get { return GetElementByName<IField>(Names.CA_EXP_DESIGNATOR); } }
        public ICheckField CA_CONTROL_CASE { get { return GetElementByName<ICheckField>(Names.CA_CONTROL_CASE); } }
        public ICheckField CA_NOT_CONTROL_CASE { get { return GetElementByName<ICheckField>(Names.CA_NOT_CONTROL_CASE); } }
        public ICheckField CA_EXP_CASE { get { return GetElementByName<ICheckField>(Names.CA_EXP_CASE); } }
        public ICheckField CA_OTHER_CASE { get { return GetElementByName<ICheckField>(Names.CA_OTHER_CASE); } }
        public IField CA_CURRENT_DATE { get { return GetElementByName<IField>(Names.CA_CURRENT_DATE); } }
        public IField CA_CURRENT_CC { get { return GetElementByName<IField>(Names.CA_CURRENT_CC); } }
        public IField CA_CURRENT_YY { get { return GetElementByName<IField>(Names.CA_CURRENT_YY); } }
        public IGroup CA_CURRENT_MMDD { get { return GetElementByName<IGroup>(Names.CA_CURRENT_MMDD); } }
        public IField CA_CURRENT_MM { get { return GetElementByName<IField>(Names.CA_CURRENT_MM); } }
        public IField CA_CURRENT_DD { get { return GetElementByName<IField>(Names.CA_CURRENT_DD); } }
        public IField CA_RESTART_PROGRAM { get { return GetElementByName<IField>(Names.CA_RESTART_PROGRAM); } }
        public IField CA_BEN_MO_CHG_IND { get { return GetElementByName<IField>(Names.CA_BEN_MO_CHG_IND); } }
        public IField CA_SAVE_UPDATE_ALLOWED { get { return GetElementByName<IField>(Names.CA_SAVE_UPDATE_ALLOWED); } }
        public IGroup CA_VTAM_PRINTER_ID { get { return GetElementByName<IGroup>(Names.CA_VTAM_PRINTER_ID); } }
        public IField CA_VTAM_PRINTER_ID_1_4 { get { return GetElementByName<IField>(Names.CA_VTAM_PRINTER_ID_1_4); } }
        public IField CA_VTAM_PRINTER_ID_5_8 { get { return GetElementByName<IField>(Names.CA_VTAM_PRINTER_ID_5_8); } }
        public IField CA_MAP_SAVE_AREA { get { return GetElementByName<IField>(Names.CA_MAP_SAVE_AREA); } }
        public IField CA_CZ610_HH_CLIENTS { get { return GetElementByName<IField>(Names.CA_CZ610_HH_CLIENTS); } }
        public IField CA_SAVE_UPDATE_ALLOWED_N { get { return GetElementByName<IField>(Names.CA_SAVE_UPDATE_ALLOWED_N); } }
        public IField CA_FIRST_TIME { get { return GetElementByName<IField>(Names.CA_FIRST_TIME); } }
        public IGroup CA_ABEND_INFO_AREA { get { return GetElementByName<IGroup>(Names.CA_ABEND_INFO_AREA); } }
        public IField CA_INFO_POINTR { get { return GetElementByName<IField>(Names.CA_INFO_POINTR); } }
        public IField CA_INFO_ABEND_DATA { get { return GetElementByName<IField>(Names.CA_INFO_ABEND_DATA); } }
        public IField CA_PARAMETERS { get { return GetElementByName<IField>(Names.CA_PARAMETERS); } }
        public IGroup CA_ERROR_PARAMETERS { get { return GetElementByName<IGroup>(Names.CA_ERROR_PARAMETERS); } }
        public IField CA_ERR_TEXT { get { return GetElementByName<IField>(Names.CA_ERR_TEXT); } }
        public IGroup CA_ABEND_PARAMETERS { get { return GetElementByName<IGroup>(Names.CA_ABEND_PARAMETERS); } }
        public IField CA_ABEND_TYPE { get { return GetElementByName<IField>(Names.CA_ABEND_TYPE); } }
        public IField CA_ABEND_LINE { get { return GetElementByName<IField>(Names.CA_ABEND_LINE); } }
        public IField CA_ADA_CALL_SEQ { get { return GetElementByName<IField>(Names.CA_ADA_CALL_SEQ); } }
        public IField CA_ADA_RESPONSE_CODE { get { return GetElementByName<IField>(Names.CA_ADA_RESPONSE_CODE); } }
        public IField CA_CICS_FUNCTION_CODE { get { return GetElementByName<IField>(Names.CA_CICS_FUNCTION_CODE); } }
        public IField CA_CICS_RESOURCE_NAME { get { return GetElementByName<IField>(Names.CA_CICS_RESOURCE_NAME); } }
        public IField CA_CICS_RESPONSE_CODE { get { return GetElementByName<IField>(Names.CA_CICS_RESPONSE_CODE); } }
        public IGroup TWA { get { return GetElementByName<IGroup>(Names.TWA); } }
        public IGroup TWA_ADABAS_PARMS { get { return GetElementByName<IGroup>(Names.TWA_ADABAS_PARMS); } }
        public IGroup TWA_CICS_PARMS { get { return GetElementByName<IGroup>(Names.TWA_CICS_PARMS); } }
        public IField TWA_PROGRAM_ID { get { return GetElementByName<IField>(Names.TWA_PROGRAM_ID); } }
        public IGroup TWA_ADDR_LIST { get { return GetElementByName<IGroup>(Names.TWA_ADDR_LIST); } }

        #endregion

        #region Data structure definition
        /// <summary>
        /// Defines the entirety of the LinkageSection IRecord structure as described by the Ateras.Framework.Buffer API.
        /// </summary>
        /// <param name="recordDef">The IStructureDefinition object to be used in defining the record structure.</param>
        protected override void DefineRecordStructure(IStructureDefinition recordDef)
        {

            recordDef.CreateNewGroup(Names.DFHCOMMAREA, (DFHCOMMAREA) =>
           {
               DFHCOMMAREA.CreateNewField(Names.CA_SECURITY_KEY, FieldType.String, 8);
               DFHCOMMAREA.CreateNewField(Names.CA_UPDATE_ALLOWED, FieldType.String, 1);
               DFHCOMMAREA.CreateNewField(Names.CA_USER_SHORT_NAME, FieldType.String, 12);
               DFHCOMMAREA.CreateNewField(Names.CA_PEN, FieldType.String, 4);
               DFHCOMMAREA.CreateNewField(Names.CA_MAIN_MENU, FieldType.String, 8);
               DFHCOMMAREA.CreateNewField(Names.CA_PREV_MENU, FieldType.String, 8);
               DFHCOMMAREA.CreateNewField(Names.CA_MENU_SELECTION, FieldType.String, 2);
               DFHCOMMAREA.CreateNewField(Names.CA_ERR_SEVERITY, FieldType.String, 1);
               DFHCOMMAREA.CreateNewField(Names.CA_NEXT_PROGRAM, FieldType.String, 8);
               DFHCOMMAREA.CreateNewField(Names.CA_THIS_PROGRAM, FieldType.String, 8);
               DFHCOMMAREA.CreateNewField(Names.CA_NEXT_SCREEN_ID, FieldType.String, 4);
               DFHCOMMAREA.CreateNewField(Names.CA_THIS_SCREEN_ID, FieldType.String, 4);
               DFHCOMMAREA.CreateNewField(Names.CA_CLIENT_NUMBER, FieldType.String, 10);
               DFHCOMMAREA.CreateNewField(Names.CA_CAECSES_CLIENT, FieldType.String, 1);
               DFHCOMMAREA.CreateNewField(Names.CA_CASE_NAME, FieldType.String, 32);
               DFHCOMMAREA.CreateNewField(Names.CA_CASE_NUMBER, FieldType.String, 8);
               DFHCOMMAREA.CreateNewField(Names.CA_PROGRAM_TYPE, FieldType.String, 2);
               DFHCOMMAREA.CreateNewField(Names.CA_DOCUMENT_ID, FieldType.String, 10);
               DFHCOMMAREA.CreateNewField(Names.CA_BENEFIT_MONTH, FieldType.UnsignedNumeric, 6);
               DFHCOMMAREA.CreateNewField(Names.CA_BUDGETTING_METHOD, FieldType.String, 1);
               DFHCOMMAREA.CreateNewGroup(Names.CA_CASELOAD_ID, (CA_CASELOAD_ID) =>
               {
                   CA_CASELOAD_ID.CreateNewField(Names.CA_CASELOAD_NUMBER, FieldType.UnsignedNumeric, 2);
                   CA_CASELOAD_ID.CreateNewField(Names.CA_UNIT, FieldType.String, 1);
                   CA_CASELOAD_ID.CreateNewField(Names.CA_SECTION, FieldType.UnsignedNumeric, 3);
               });
               DFHCOMMAREA.CreateNewField(Names.CA_RECOUPMENT_NUMBER, FieldType.UnsignedNumeric, 3);
               DFHCOMMAREA.CreateNewField(Names.CA_SECURITY_POINTER, FieldType.ReferencePointer, 4);
               DFHCOMMAREA.CreateNewField(Names.CA_SECURITY_PROFILE, FieldType.String, 8);
               DFHCOMMAREA.CreateNewField(Names.CA_ADABAS_PASSWORD, FieldType.String, 8);
               DFHCOMMAREA.CreateNewField(Names.CA_REVIEWEE_PEN, FieldType.String, 4);
               DFHCOMMAREA.CreateNewField(Names.CA_REVIEWER_PEN, FieldType.String, 4);
               DFHCOMMAREA.CreateNewField(Names.EISDATE, FieldType.PackedDecimal, 7);
               DFHCOMMAREA.CreateNewField(Names.CA_ENVIRONMENT, FieldType.String, 1);
               DFHCOMMAREA.CreateNewField(Names.CA_QC_REVIEW_NUMBER, FieldType.UnsignedPackedDecimal, 6);
               DFHCOMMAREA.CreateNewField(Names.CA_EXP_DESIGNATOR, FieldType.String, 1)
                   .NewCheckField(Names.CA_CONTROL_CASE, "C")
                   .NewCheckField(Names.CA_NOT_CONTROL_CASE, "E", "O", SPACE)
                   .NewCheckField(Names.CA_EXP_CASE, "E")
                   .NewCheckField(Names.CA_OTHER_CASE, "O", SPACE)
                   ;

               IField CA_CURRENT_DATE_local = DFHCOMMAREA.CreateNewField(Names.CA_CURRENT_DATE, FieldType.UnsignedNumeric, 8);
               DFHCOMMAREA.CreateNewGroupRedefine("FILLER_d81", CA_CURRENT_DATE_local, (FILLER_d81) =>
               {
                   FILLER_d81.CreateNewField(Names.CA_CURRENT_CC, FieldType.UnsignedNumeric, 2);
                   FILLER_d81.CreateNewField(Names.CA_CURRENT_YY, FieldType.UnsignedNumeric, 2);
                   FILLER_d81.CreateNewGroup(Names.CA_CURRENT_MMDD, (CA_CURRENT_MMDD) =>
                   {
                       CA_CURRENT_MMDD.CreateNewField(Names.CA_CURRENT_MM, FieldType.UnsignedNumeric, 2);
                       CA_CURRENT_MMDD.CreateNewField(Names.CA_CURRENT_DD, FieldType.UnsignedNumeric, 2);
                   });
               });
               DFHCOMMAREA.CreateNewField(Names.CA_RESTART_PROGRAM, FieldType.String, 1);
               DFHCOMMAREA.CreateNewField(Names.CA_BEN_MO_CHG_IND, FieldType.String, 1);
               DFHCOMMAREA.CreateNewField(Names.CA_SAVE_UPDATE_ALLOWED, FieldType.String, 1);
               DFHCOMMAREA.CreateNewGroup(Names.CA_VTAM_PRINTER_ID, (CA_VTAM_PRINTER_ID) =>
               {
                   CA_VTAM_PRINTER_ID.CreateNewField(Names.CA_VTAM_PRINTER_ID_1_4, FieldType.String, 4);
                   CA_VTAM_PRINTER_ID.CreateNewField(Names.CA_VTAM_PRINTER_ID_5_8, FieldType.String, 4);
               });
               DFHCOMMAREA.CreateNewField(Names.CA_MAP_SAVE_AREA, FieldType.String, 2000);
               DFHCOMMAREA.CreateNewField(Names.CA_CZ610_HH_CLIENTS, FieldType.String, 2);
               DFHCOMMAREA.CreateNewField(Names.CA_SAVE_UPDATE_ALLOWED_N, FieldType.String, 1);
               DFHCOMMAREA.CreateNewField(Names.CA_FIRST_TIME, FieldType.String, 1);
               DFHCOMMAREA.CreateNewFillerField(242, FillWith.Hashes);
               DFHCOMMAREA.CreateNewGroup(Names.CA_ABEND_INFO_AREA, (CA_ABEND_INFO_AREA) =>
               {
                   CA_ABEND_INFO_AREA.CreateNewField(Names.CA_INFO_POINTR, FieldType.String, 20);
                   CA_ABEND_INFO_AREA.CreateNewField(Names.CA_INFO_ABEND_DATA, FieldType.String, 30);
               });

               IField CA_PARAMETERS_local = DFHCOMMAREA.CreateNewField(Names.CA_PARAMETERS, FieldType.String, 500);
               DFHCOMMAREA.CreateNewGroupRedefine(Names.CA_ERROR_PARAMETERS, CA_PARAMETERS_local, (CA_ERROR_PARAMETERS) =>
               {
                   CA_ERROR_PARAMETERS.CreateNewField(Names.CA_ERR_TEXT, FieldType.String, 66);
               });
               DFHCOMMAREA.CreateNewGroupRedefine(Names.CA_ABEND_PARAMETERS, CA_PARAMETERS_local, (CA_ABEND_PARAMETERS) =>
               {
                   CA_ABEND_PARAMETERS.CreateNewFillerField(100, FillWith.Hashes);
                   CA_ABEND_PARAMETERS.CreateNewField(Names.CA_ABEND_TYPE, FieldType.String, 1);
                   CA_ABEND_PARAMETERS.CreateNewField(Names.CA_ABEND_LINE, FieldType.String, 32);
                   CA_ABEND_PARAMETERS.CreateNewField(Names.CA_ADA_CALL_SEQ, FieldType.String, 8);
                   CA_ABEND_PARAMETERS.CreateNewField(Names.CA_ADA_RESPONSE_CODE, FieldType.CompShort, 4);
                   CA_ABEND_PARAMETERS.CreateNewField(Names.CA_CICS_FUNCTION_CODE, FieldType.String, 2);
                   CA_ABEND_PARAMETERS.CreateNewField(Names.CA_CICS_RESOURCE_NAME, FieldType.String, 8);
                   CA_ABEND_PARAMETERS.CreateNewField(Names.CA_CICS_RESPONSE_CODE, FieldType.String, 6);
               });
           });

            recordDef.CreateNewGroup(Names.TWA, (TWA) =>
           {
               IGroup TWA_ADABAS_PARMS_local = (IGroup)TWA.CreateNewGroup(Names.TWA_ADABAS_PARMS, (TWA_ADABAS_PARMS) =>
               {
                   TWA_ADABAS_PARMS.CreateNewFieldArray("FILLER_d84", 7, FieldType.CompInt, 4);
               });
               TWA.CreateNewGroupRedefine(Names.TWA_CICS_PARMS, TWA_ADABAS_PARMS_local, (TWA_CICS_PARMS) =>
               {
                   TWA_CICS_PARMS.CreateNewField(Names.TWA_PROGRAM_ID, FieldType.String, 8);
                   TWA_CICS_PARMS.CreateNewGroup(Names.TWA_ADDR_LIST, (TWA_ADDR_LIST) =>
                   {
                       TWA_ADDR_LIST.CreateNewFieldArray("FILLER_d85", 5, FieldType.CompInt, 4);
                   });
               });
           });

        }

        protected override string GetRecordName()
        {
            return Names.LinkageSection;
        }
        #endregion

    }
    #endregion Linkage Section Class

    #region Business Logic Class
    public class SWASS915 : OnlineProgramBase
    {

        #region Public Constructors
        public SWASS915()
            : base()
        {
            SetUpProgram();
        }

        public SWASS915(OnlineControl controlData) : base(controlData)
        {
            SetUpProgram();
        }

        private void SetUpProgram()
        {
            this.ProgramName = "SWASS915";

            WS = new SWASS915_ws();
            LS = new SWASS915_ls();
        }

        #endregion

        #region Private Fields


        //==== Working Storage Data Class ========================================
        private SWASS915_ws WS;

        //==== Linkage Section Data Class ========================================
        private SWASS915_ls LS;
        #endregion

        #region Public Methods
        //========================================================================
        //==== RunMain Entry Point Method ========================================
        //========================================================================
        public override int ExecuteMain()                                                                  //COBOL==> PROCEDURE DIVISION.
        {
            try
            {
                WS.Initialize();
                SetData();
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

        private void SetData()
        {
            if (Control.DFHCOMMAREA != null)
                LS.DFHCOMMAREA.AssignFrom(Control.DFHCOMMAREA);
            else
                LS.InitializeWithLowValues();
            WS.InitializeWithLowValues();
        }

        private void RunMain()
        {
            string returnMethod = "Main";
            //COMMENT: *** MAIN LOGIC
            LS.TWA.SetValueAll(HIGH_VALUES);                                                                    //COBOL==> MOVE HIGH-VALUES TO TWA.
            M_0100_RETRIEVE_PARAMETER("M_0100_EXIT"); if (Control.ExitProgram) { return; }                        //COBOL==> PERFORM 0100-RETRIEVE-PARAMETER THRU 0100-EXIT.
            M_0150_INIT_CONTROL_CHARS("M_0150_EXIT"); if (Control.ExitProgram) { return; }                        //COBOL==> PERFORM 0150-INIT-CONTROL-CHARS THRU 0150-EXIT.
            M_0200_FORMAT_AND_PRINT("M_0200_EXIT"); if (Control.ExitProgram) { return; }                          //COBOL==> PERFORM 0200-FORMAT-AND-PRINT THRU 0200-EXIT.
            Control.Return(LS); return;                                                                         //COBOL==> EXEC CICS RETURN END-EXEC.
            Control.ExitProgram = true; return;                                                                 //COBOL==> GOBACK.
        }
        /// <summary>
        /// Method M_0100_RETRIEVE_PARAMETER
        /// </summary>
        /// <remarks>
        ///COMMENT: *** RETRIEVE THE CASE NUMBER PROVIDED BY THE INITIATING TASK
        /// </remarks>
        private void M_0100_RETRIEVE_PARAMETER(string returnMethod = "")
        {
            ReceiveData(WS.MV_START_DATA, WS.MV_START_LENGTH);                                                  //COBOL==> EXEC CICS RETRIEVE INTO ( MV-START-DATA ) LENGTH ( MV-START-LENGTH ) END-EXEC.
            if (returnMethod != "" && returnMethod != "M_0100_RETRIEVE_PARAMETER") { M_0100_EXIT(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_0100_EXIT
        /// </summary>
        private void M_0100_EXIT(string returnMethod = "")
        {
            if (returnMethod == "M_0100_EXIT") { return; }                                                      //COBOL==> EXIT.
            if (returnMethod != "" && returnMethod != "M_0100_EXIT") { M_0150_INIT_CONTROL_CHARS(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_0150_INIT_CONTROL_CHARS
        /// </summary>
        /// <remarks>
        ///COMMENT: *** SET VALUES FOR CONTROL CHARS - NL, FF, EOM.
        /// </remarks>
        private void M_0150_INIT_CONTROL_CHARS(string returnMethod = "")
        {
            WS.BUG_NL010.SetValue(WS.MC_NEW_LINE);                                                              //COBOL==> MOVE MC-NEW-LINE TO BUG-NL010 BUG-NL020 BUG-NL030 BUG-NL040 BUG-NL050 BUG-NL060 BUG-NL070 BUG-NL080 BUG-NL090 BUG-NL100 BUG-NL110 BUG-NL120 BUG-NL125 BUG-NL130 BUG-NL140 BUG-NL150 BUG-NL160 BUG-NL170 BUG-NL180 BUG-NL190 BUG-NL200 BUG-NL210 BUG-NL220 BUG-NL230.
            WS.BUG_NL020.SetValue(WS.MC_NEW_LINE);
            WS.BUG_NL030.SetValue(WS.MC_NEW_LINE);
            WS.BUG_NL040.SetValue(WS.MC_NEW_LINE);
            WS.BUG_NL050.SetValue(WS.MC_NEW_LINE);
            WS.BUG_NL060.SetValue(WS.MC_NEW_LINE);
            WS.BUG_NL070.SetValue(WS.MC_NEW_LINE);
            WS.BUG_NL080.SetValue(WS.MC_NEW_LINE);
            WS.BUG_NL090.SetValue(WS.MC_NEW_LINE);
            WS.BUG_NL100.SetValue(WS.MC_NEW_LINE);
            WS.BUG_NL110.SetValue(WS.MC_NEW_LINE);
            WS.BUG_NL120.SetValue(WS.MC_NEW_LINE);
            WS.BUG_NL125.SetValue(WS.MC_NEW_LINE);
            WS.BUG_NL130.SetValue(WS.MC_NEW_LINE);
            WS.BUG_NL140.SetValue(WS.MC_NEW_LINE);
            WS.BUG_NL150.SetValue(WS.MC_NEW_LINE);
            WS.BUG_NL160.SetValue(WS.MC_NEW_LINE);
            WS.BUG_NL170.SetValue(WS.MC_NEW_LINE);
            WS.BUG_NL180.SetValue(WS.MC_NEW_LINE);
            WS.BUG_NL190.SetValue(WS.MC_NEW_LINE);
            WS.BUG_NL200.SetValue(WS.MC_NEW_LINE);
            WS.BUG_NL210.SetValue(WS.MC_NEW_LINE);
            WS.BUG_NL220.SetValue(WS.MC_NEW_LINE);
            WS.BUG_NL230.SetValue(WS.MC_NEW_LINE);
            WS.BUG_FF010.SetValue(WS.MC_FORMFEED);                                                              //COBOL==> MOVE MC-FORMFEED TO BUG-FF010 BUG-FF020.
            WS.BUG_FF020.SetValue(WS.MC_FORMFEED);
            if (returnMethod != "" && returnMethod != "M_0150_INIT_CONTROL_CHARS") { M_0150_EXIT(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_0150_EXIT
        /// </summary>
        private void M_0150_EXIT(string returnMethod = "")
        {
            if (returnMethod == "M_0150_EXIT") { return; }                                                      //COBOL==> EXIT.
            if (returnMethod != "" && returnMethod != "M_0150_EXIT") { M_0200_FORMAT_AND_PRINT(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_0200_FORMAT_AND_PRINT
        /// </summary>
        /// <remarks>
        ///COMMENT: *** SEND REPORT TITLE
        /// </remarks>
        private void M_0200_FORMAT_AND_PRINT(string returnMethod = "")
        {
            WS.MV_SZ908_CICS_TIME.SetValue(Control.EIBTIME);                                                    //COBOL==> MOVE EIBTIME TO MV-SZ908-CICS-TIME
            WS.MV_SZ908_SCREEN_HH.SetValue(WS.MV_SZ908_CICS_HH);                                                //COBOL==> MOVE MV-SZ908-CICS-HH TO MV-SZ908-SCREEN-HH
            WS.MV_SZ908_SCREEN_MM.SetValue(WS.MV_SZ908_CICS_MM);                                                //COBOL==> MOVE MV-SZ908-CICS-MM TO MV-SZ908-SCREEN-MM
            WS.BUG_TIME.SetValue(WS.MV_SZ908_SCREEN_TIME);                                                      //COBOL==> MOVE MV-SZ908-SCREEN-TIME TO BUG-TIME
            WS.BUG_DATE.SetValue(WS.MV_START_DATE);                                                             //COBOL==> MOVE MV-START-DATE TO BUG-DATE
            WS.BUG_TRMID.SetValue(WS.MV_START_TRMID);                                                           //COBOL==> MOVE MV-START-TRMID TO BUG-TRMID
            WS.BUG_TRNSID.SetValue(WS.MV_START_TRNSID);                                                         //COBOL==> MOVE MV-START-TRNSID TO BUG-TRNSID
            WS.BUG_PGM_NAME.SetValue(WS.MV_START_PGM_NAME);                                                     //COBOL==> MOVE MV-START-PGM-NAME TO BUG-PGM-NAME
            WS.BUG_ABEND_TYPE.SetValue(WS.MV_START_ABEND_TYPE);                                                 //COBOL==> MOVE MV-START-ABEND-TYPE TO BUG-ABEND-TYPE
            WS.BUG_CALL_TYPE.SetValue(WS.MV_START_CALL_TYPE);                                                   //COBOL==> MOVE MV-START-CALL-TYPE TO BUG-CALL-TYPE
            WS.BUG_SEQ_NUMBER.SetValue(WS.MV_START_SEQ_NUMBER);                                                 //COBOL==> MOVE MV-START-SEQ-NUMBER TO BUG-SEQ-NUMBER
            WS.BUG_RESPONSE_CODE.SetValue(WS.MV_START_RESPONSE_CODE);                                           //COBOL==> MOVE MV-START-RESPONSE-CODE TO BUG-RESPONSE-CODE
            WS.BUG_TYPE_DESC.SetValue(WS.MV_START_TYPE_DESC);                                                   //COBOL==> MOVE MV-START-TYPE-DESC TO BUG-TYPE-DESC
            WS.BUG_ERROR_TYPE.SetValue(WS.MV_START_ERROR_TYPE);                                                 //COBOL==> MOVE MV-START-ERROR-TYPE TO BUG-ERROR-TYPE
            WS.BUG_COMMAREA_DUMP1.SetValue(WS.MV_START_COMMAREA_DUMP1);                                         //COBOL==> MOVE MV-START-COMMAREA-DUMP1 TO BUG-COMMAREA-DUMP1
            WS.BUG_COMMAREA_DUMP2.SetValue(WS.MV_START_COMMAREA_DUMP2);                                         //COBOL==> MOVE MV-START-COMMAREA-DUMP2 TO BUG-COMMAREA-DUMP2
            WS.BUG_COMMAREA_DUMP3.SetValue(WS.MV_START_COMMAREA_DUMP3);                                         //COBOL==> MOVE MV-START-COMMAREA-DUMP3 TO BUG-COMMAREA-DUMP3
            WS.BUG_COMMAREA_DUMP4.SetValue(WS.MV_START_COMMAREA_DUMP4);                                         //COBOL==> MOVE MV-START-COMMAREA-DUMP4 TO BUG-COMMAREA-DUMP4
            WS.BUG_COMMAREA_DUMP5.SetValue(WS.MV_START_COMMAREA_DUMP5);                                         //COBOL==> MOVE MV-START-COMMAREA-DUMP5 TO BUG-COMMAREA-DUMP5
            WS.BUG_COMMAREA_DUMP6.SetValue(WS.MV_START_COMMAREA_DUMP6);                                         //COBOL==> MOVE MV-START-COMMAREA-DUMP6 TO BUG-COMMAREA-DUMP6 .
            WS.MV_SENDING_LINE.SetValue(WS.BUG_PRINT_TITLE);                                                    //COBOL==> MOVE BUG-PRINT-TITLE TO MV-SENDING-LINE
            WS.MV_LINE_LENGTH.SetValue(WS.MC_TITLE_LENGTH);                                                     //COBOL==> MOVE MC-TITLE-LENGTH TO MV-LINE-LENGTH
            M_0400_SEND_REPORT_LINE("M_0400_EXIT"); if (Control.ExitProgram) { return; }                          //COBOL==> PERFORM 0400-SEND-REPORT-LINE THRU 0400-EXIT.
            WS.MV_SENDING_LINE.SetValue(WS.BUG_DATA_SECTION);                                                   //COBOL==> MOVE BUG-DATA-SECTION TO MV-SENDING-LINE
            WS.MV_LINE_LENGTH.SetValue(WS.MC_DATA_LENGTH);                                                      //COBOL==> MOVE MC-DATA-LENGTH TO MV-LINE-LENGTH
            M_0400_SEND_REPORT_LINE("M_0400_EXIT"); if (Control.ExitProgram) { return; }                          //COBOL==> PERFORM 0400-SEND-REPORT-LINE THRU 0400-EXIT.
            WS.MV_SENDING_LINE.SetValue(WS.BUG_LOGO_SECTION);                                                   //COBOL==> MOVE BUG-LOGO-SECTION TO MV-SENDING-LINE
            WS.MV_LINE_LENGTH.SetValue(WS.MC_LOGO_LENGTH);                                                      //COBOL==> MOVE MC-LOGO-LENGTH TO MV-LINE-LENGTH
            M_0400_SEND_REPORT_LINE("M_0400_EXIT"); if (Control.ExitProgram) { return; }                          //COBOL==> PERFORM 0400-SEND-REPORT-LINE THRU 0400-EXIT.
            if (returnMethod != "" && returnMethod != "M_0200_FORMAT_AND_PRINT") { M_0200_EXIT(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_0200_EXIT
        /// </summary>
        private void M_0200_EXIT(string returnMethod = "")
        {
            if (returnMethod == "M_0200_EXIT") { return; }                                                      //COBOL==> EXIT.
            if (returnMethod != "" && returnMethod != "M_0200_EXIT") { M_0400_SEND_REPORT_LINE(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_0400_SEND_REPORT_LINE
        /// </summary>
        /// <remarks>
        ///COMMENT: *** SEND 1 LINE OF TEXT TO THE PRINTER
        /// </remarks>
        private void M_0400_SEND_REPORT_LINE(string returnMethod = "")
        {
            Map.SendText(WS.MV_SENDING_LINE, WS.MV_LINE_LENGTH.LengthInBuffer, SendOption.Erase); if (CheckHandleConditions(returnMethod)) { return; }  //COBOL==> EXEC CICS SEND TEXT FROM ( MV-SENDING-LINE ) LENGTH ( MV-LINE-LENGTH ) NOEDIT PRINT ERASE END-EXEC.
            WS.MV_SENDING_LINE.SetValueWithSpaces();                                                            //COBOL==> MOVE SPACES TO MV-SENDING-LINE
            WS.MV_LINE_LENGTH.SetValueWithZeroes();                                                             //COBOL==> MOVE ZEROS TO MV-LINE-LENGTH.
            if (returnMethod != "" && returnMethod != "M_0400_SEND_REPORT_LINE") { M_0400_EXIT(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_0400_EXIT
        /// </summary>
        private void M_0400_EXIT(string returnMethod = "")
        {
            if (returnMethod == "M_0400_EXIT") { return; }                                                      //COBOL==> EXIT.
        }
        #endregion
    }
    #endregion
}
