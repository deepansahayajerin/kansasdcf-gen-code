#region Comments
/* Conversion Comments
   ************************************************************
   **   MODERN SYSTEMS INC.  COPYRIGHT 2000-2022
   **   DB-SHUTTLE COBOL to C# Conversion
   ************************************************************
   ** INIT   *  INITIAL VERSION   *  2022-01-14 12:46:22 PM
   **        *   FROM COBOL PGM   :  SWASZ052
   **        *   FROM CANISTER    :  SR.CAECSES.PROD.LIBR.SOURCE.PDS
   ************************************************************ */

/* Original Program Identification Comments
   DATE-COMPILED.
   
*/
#endregion
#region Using Directives
using MDSY.Framework.Buffer;
using MDSY.Framework.Buffer.BaseClasses;
using MDSY.Framework.Buffer.Common;
using MDSY.Framework.Buffer.Interfaces;
using MDSY.Framework.Control.CICS;
using MDSY.Framework.Core;
using System;
#endregion

namespace GOV.KS.DCF.CSS.Online.BL
{
    #region Working Storage Class
    internal class SWASZ052_ws : PredefinedRecordBase
    {
        #region Name constants
        /// <summary>
        /// Name constants.
        /// </summary>
        internal static class Names
        {
            internal const string WorkingStorage = "SWASZ052_ws_WorkingStorage";
            internal const string WS_WORKING_STORAGE = "WS_WORKING_STORAGE";
            internal const string CONTROL_BLOCK = "CONTROL_BLOCK";
            internal const string COMMAND_CODE = "COMMAND_CODE";
            internal const string COMMAND_ID = "COMMAND_ID";
            internal const string FILE_NUMBER = "FILE_NUMBER";
            internal const string RESPONSE_CODE = "RESPONSE_CODE";
            internal const string ISN = "ISN";
            internal const string ISN_LOWER_LIMIT = "ISN_LOWER_LIMIT";
            internal const string ISN_QUANTITY = "ISN_QUANTITY";
            internal const string FORMAT_BUFFER_LENGTH = "FORMAT_BUFFER_LENGTH";
            internal const string RECORD_BUFFER_LENGTH = "RECORD_BUFFER_LENGTH";
            internal const string SEARCH_BUFFER_LENGTH = "SEARCH_BUFFER_LENGTH";
            internal const string VALUE_BUFFER_LENGTH = "VALUE_BUFFER_LENGTH";
            internal const string ISN_BUFFER_LENGTH = "ISN_BUFFER_LENGTH";
            internal const string COMMAND_OPTION_1 = "COMMAND_OPTION_1";
            internal const string COMMAND_OPTION_2 = "COMMAND_OPTION_2";
            internal const string ADDITIONS_1 = "ADDITIONS_1";
            internal const string ADDITIONS_2 = "ADDITIONS_2";
            internal const string ADDITIONS_3 = "ADDITIONS_3";
            internal const string ADDITIONS_4 = "ADDITIONS_4";
            internal const string COMMAND_TIME = "COMMAND_TIME";
            internal const string USER_AREA = "USER_AREA";
            internal const string MODULE_CONSTANTS = "MODULE_CONSTANTS";
            internal const string MC_THIS_PROGRAM = "MC_THIS_PROGRAM";
            internal const string Y2K_YYMMDD_IN = "Y2K_YYMMDD_IN";
            internal const string Y2K_YY_IN = "Y2K_YY_IN";
            internal const string Y2K_MM_IN = "Y2K_MM_IN";
            internal const string Y2K_DD_IN = "Y2K_DD_IN";
            internal const string Y2K_YYMMDD_IN_N = "Y2K_YYMMDD_IN_N";
            internal const string Y2K_YY_IN_N = "Y2K_YY_IN_N";
            internal const string Y2K_MM_IN_N = "Y2K_MM_IN_N";
            internal const string Y2K_DD_IN_N = "Y2K_DD_IN_N";
            internal const string Y2K_CENTURY_YYMMDD = "Y2K_CENTURY_YYMMDD";
            internal const string Y2K_CENT_CC = "Y2K_CENT_CC";
            internal const string Y2K_CENT_YYMMDD = "Y2K_CENT_YYMMDD";
            internal const string Y2K_CENT_YY = "Y2K_CENT_YY";
            internal const string Y2K_CENT_MM = "Y2K_CENT_MM";
            internal const string Y2K_CENT_DD = "Y2K_CENT_DD";
            internal const string Y2K_CENTURY_YYMMDD_N = "Y2K_CENTURY_YYMMDD_N";
            internal const string Y2K_CENT_CC_N = "Y2K_CENT_CC_N";
            internal const string Y2K_CENT_YYMMDD_N = "Y2K_CENT_YYMMDD_N";
            internal const string Y2K_CENT_YY_N = "Y2K_CENT_YY_N";
            internal const string Y2K_CENT_MM_N = "Y2K_CENT_MM_N";
            internal const string Y2K_CENT_DD_N = "Y2K_CENT_DD_N";
            internal const string Y2K_MMDDYY_IN = "Y2K_MMDDYY_IN";
            internal const string Y2K_IN_MM = "Y2K_IN_MM";
            internal const string Y2K_IN_DD = "Y2K_IN_DD";
            internal const string Y2K_IN_YY = "Y2K_IN_YY";
            internal const string Y2K_MMDDYY_IN_N = "Y2K_MMDDYY_IN_N";
            internal const string Y2K_IN_MM_N = "Y2K_IN_MM_N";
            internal const string Y2K_IN_DD_N = "Y2K_IN_DD_N";
            internal const string Y2K_IN_YY_N = "Y2K_IN_YY_N";
            internal const string Y2K_CENTURY_MMDDYY = "Y2K_CENTURY_MMDDYY";
            internal const string Y2K_CDATE_MM = "Y2K_CDATE_MM";
            internal const string Y2K_CDATE_DD = "Y2K_CDATE_DD";
            internal const string Y2K_CDATE_CC = "Y2K_CDATE_CC";
            internal const string Y2K_CDATE_YY = "Y2K_CDATE_YY";
            internal const string Y2K_CENTURY_MMDDYY_N = "Y2K_CENTURY_MMDDYY_N";
            internal const string Y2K_CDATE_MM_N = "Y2K_CDATE_MM_N";
            internal const string Y2K_CDATE_DD_N = "Y2K_CDATE_DD_N";
            internal const string Y2K_CDATE_CC_N = "Y2K_CDATE_CC_N";
            internal const string Y2K_CDATE_YY_N = "Y2K_CDATE_YY_N";
            internal const string Y2K_MMYY_IN = "Y2K_MMYY_IN";
            internal const string Y2K_IN_MON = "Y2K_IN_MON";
            internal const string Y2K_IN_YEAR = "Y2K_IN_YEAR";
            internal const string Y2K_MMYY_IN_N = "Y2K_MMYY_IN_N";
            internal const string Y2K_IN_MON_N = "Y2K_IN_MON_N";
            internal const string Y2K_IN_YEAR_N = "Y2K_IN_YEAR_N";
            internal const string Y2K_CENTURY_MMYY = "Y2K_CENTURY_MMYY";
            internal const string Y2K_CENTRY_MM = "Y2K_CENTRY_MM";
            internal const string Y2K_CENTRY_CC = "Y2K_CENTRY_CC";
            internal const string Y2K_CENTRY_YY = "Y2K_CENTRY_YY";
            internal const string Y2K_CENTURY_MMYY_N = "Y2K_CENTURY_MMYY_N";
            internal const string Y2K_CENTRY_MM_N = "Y2K_CENTRY_MM_N";
            internal const string Y2K_CENTRY_CC_N = "Y2K_CENTRY_CC_N";
            internal const string Y2K_CENTRY_YY_N = "Y2K_CENTRY_YY_N";
            internal const string Y2K_JUL_IN = "Y2K_JUL_IN";
            internal const string Y2K_JUL_YY_IN = "Y2K_JUL_YY_IN";
            internal const string Y2K_JUL_DDD_IN = "Y2K_JUL_DDD_IN";
            internal const string Y2K_JUL_IN_N = "Y2K_JUL_IN_N";
            internal const string Y2K_JUL_YY_IN_N = "Y2K_JUL_YY_IN_N";
            internal const string Y2K_JUL_DDD_IN_N = "Y2K_JUL_DDD_IN_N";
            internal const string Y2K_JUL_CENTURY = "Y2K_JUL_CENTURY";
            internal const string Y2K_JUL_CC = "Y2K_JUL_CC";
            internal const string Y2K_JUL_CCL5 = "Y2K_JUL_CCL5";
            internal const string Y2K_JUL_CCYY = "Y2K_JUL_CCYY";
            internal const string Y2K_JUL_CCDD = "Y2K_JUL_CCDD";
            internal const string Y2K_JUL_CENTURY_N = "Y2K_JUL_CENTURY_N";
            internal const string Y2K_JUL_CC_N = "Y2K_JUL_CC_N";
            internal const string Y2K_JUL_CCL5_N = "Y2K_JUL_CCL5_N";
            internal const string Y2K_JUL_CCYY_N = "Y2K_JUL_CCYY_N";
            internal const string Y2K_JUL_CCDD_N = "Y2K_JUL_CCDD_N";
            internal const string Y2K_FY_YY_IN = "Y2K_FY_YY_IN";
            internal const string Y2K_FY_IN = "Y2K_FY_IN";
            internal const string Y2K_FY_YY_IN_N = "Y2K_FY_YY_IN_N";
            internal const string Y2K_FY_IN_N = "Y2K_FY_IN_N";
            internal const string Y2K_CENTURY_FY = "Y2K_CENTURY_FY";
            internal const string Y2K_FY_CENT_CC = "Y2K_FY_CENT_CC";
            internal const string Y2K_FY_CENT_YY = "Y2K_FY_CENT_YY";
            internal const string Y2K_CENTURY_FY_N = "Y2K_CENTURY_FY_N";
            internal const string Y2K_FY_CENT_CC_N = "Y2K_FY_CENT_CC_N";
            internal const string Y2K_FY_CENT_YY_N = "Y2K_FY_CENT_YY_N";
            internal const string Y2K_CONSTANTS = "Y2K_CONSTANTS";
            internal const string ANCHOR_48 = "ANCHOR_48";
            internal const string CENTURY_19 = "CENTURY_19";
            internal const string CENTURY_20 = "CENTURY_20";
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
        }
        #endregion

        #region Direct-access element properties
        public IField WS_WORKING_STORAGE { get { return GetElementByName<IField>(Names.WS_WORKING_STORAGE); } }
        public IGroup CONTROL_BLOCK { get { return GetElementByName<IGroup>(Names.CONTROL_BLOCK); } }
        public IField COMMAND_CODE { get { return GetElementByName<IField>(Names.COMMAND_CODE); } }
        public IField COMMAND_ID { get { return GetElementByName<IField>(Names.COMMAND_ID); } }
        public IField FILE_NUMBER { get { return GetElementByName<IField>(Names.FILE_NUMBER); } }
        public IField RESPONSE_CODE { get { return GetElementByName<IField>(Names.RESPONSE_CODE); } }
        public IField ISN { get { return GetElementByName<IField>(Names.ISN); } }
        public IField ISN_LOWER_LIMIT { get { return GetElementByName<IField>(Names.ISN_LOWER_LIMIT); } }
        public IField ISN_QUANTITY { get { return GetElementByName<IField>(Names.ISN_QUANTITY); } }
        public IField FORMAT_BUFFER_LENGTH { get { return GetElementByName<IField>(Names.FORMAT_BUFFER_LENGTH); } }
        public IField RECORD_BUFFER_LENGTH { get { return GetElementByName<IField>(Names.RECORD_BUFFER_LENGTH); } }
        public IField SEARCH_BUFFER_LENGTH { get { return GetElementByName<IField>(Names.SEARCH_BUFFER_LENGTH); } }
        public IField VALUE_BUFFER_LENGTH { get { return GetElementByName<IField>(Names.VALUE_BUFFER_LENGTH); } }
        public IField ISN_BUFFER_LENGTH { get { return GetElementByName<IField>(Names.ISN_BUFFER_LENGTH); } }
        public IField COMMAND_OPTION_1 { get { return GetElementByName<IField>(Names.COMMAND_OPTION_1); } }
        public IField COMMAND_OPTION_2 { get { return GetElementByName<IField>(Names.COMMAND_OPTION_2); } }
        public IField ADDITIONS_1 { get { return GetElementByName<IField>(Names.ADDITIONS_1); } }
        public IField ADDITIONS_2 { get { return GetElementByName<IField>(Names.ADDITIONS_2); } }
        public IField ADDITIONS_3 { get { return GetElementByName<IField>(Names.ADDITIONS_3); } }
        public IField ADDITIONS_4 { get { return GetElementByName<IField>(Names.ADDITIONS_4); } }
        public IField COMMAND_TIME { get { return GetElementByName<IField>(Names.COMMAND_TIME); } }
        public IField USER_AREA { get { return GetElementByName<IField>(Names.USER_AREA); } }
        public IGroup MODULE_CONSTANTS { get { return GetElementByName<IGroup>(Names.MODULE_CONSTANTS); } }
        public IField MC_THIS_PROGRAM { get { return GetElementByName<IField>(Names.MC_THIS_PROGRAM); } }
        public IGroup Y2K_YYMMDD_IN { get { return GetElementByName<IGroup>(Names.Y2K_YYMMDD_IN); } }
        public IField Y2K_YY_IN { get { return GetElementByName<IField>(Names.Y2K_YY_IN); } }
        public IField Y2K_MM_IN { get { return GetElementByName<IField>(Names.Y2K_MM_IN); } }
        public IField Y2K_DD_IN { get { return GetElementByName<IField>(Names.Y2K_DD_IN); } }
        public IGroup Y2K_YYMMDD_IN_N { get { return GetElementByName<IGroup>(Names.Y2K_YYMMDD_IN_N); } }
        public IField Y2K_YY_IN_N { get { return GetElementByName<IField>(Names.Y2K_YY_IN_N); } }
        public IField Y2K_MM_IN_N { get { return GetElementByName<IField>(Names.Y2K_MM_IN_N); } }
        public IField Y2K_DD_IN_N { get { return GetElementByName<IField>(Names.Y2K_DD_IN_N); } }
        public IGroup Y2K_CENTURY_YYMMDD { get { return GetElementByName<IGroup>(Names.Y2K_CENTURY_YYMMDD); } }
        public IField Y2K_CENT_CC { get { return GetElementByName<IField>(Names.Y2K_CENT_CC); } }
        public IGroup Y2K_CENT_YYMMDD { get { return GetElementByName<IGroup>(Names.Y2K_CENT_YYMMDD); } }
        public IField Y2K_CENT_YY { get { return GetElementByName<IField>(Names.Y2K_CENT_YY); } }
        public IField Y2K_CENT_MM { get { return GetElementByName<IField>(Names.Y2K_CENT_MM); } }
        public IField Y2K_CENT_DD { get { return GetElementByName<IField>(Names.Y2K_CENT_DD); } }
        public IGroup Y2K_CENTURY_YYMMDD_N { get { return GetElementByName<IGroup>(Names.Y2K_CENTURY_YYMMDD_N); } }
        public IField Y2K_CENT_CC_N { get { return GetElementByName<IField>(Names.Y2K_CENT_CC_N); } }
        public IGroup Y2K_CENT_YYMMDD_N { get { return GetElementByName<IGroup>(Names.Y2K_CENT_YYMMDD_N); } }
        public IField Y2K_CENT_YY_N { get { return GetElementByName<IField>(Names.Y2K_CENT_YY_N); } }
        public IField Y2K_CENT_MM_N { get { return GetElementByName<IField>(Names.Y2K_CENT_MM_N); } }
        public IField Y2K_CENT_DD_N { get { return GetElementByName<IField>(Names.Y2K_CENT_DD_N); } }
        public IGroup Y2K_MMDDYY_IN { get { return GetElementByName<IGroup>(Names.Y2K_MMDDYY_IN); } }
        public IField Y2K_IN_MM { get { return GetElementByName<IField>(Names.Y2K_IN_MM); } }
        public IField Y2K_IN_DD { get { return GetElementByName<IField>(Names.Y2K_IN_DD); } }
        public IField Y2K_IN_YY { get { return GetElementByName<IField>(Names.Y2K_IN_YY); } }
        public IGroup Y2K_MMDDYY_IN_N { get { return GetElementByName<IGroup>(Names.Y2K_MMDDYY_IN_N); } }
        public IField Y2K_IN_MM_N { get { return GetElementByName<IField>(Names.Y2K_IN_MM_N); } }
        public IField Y2K_IN_DD_N { get { return GetElementByName<IField>(Names.Y2K_IN_DD_N); } }
        public IField Y2K_IN_YY_N { get { return GetElementByName<IField>(Names.Y2K_IN_YY_N); } }
        public IGroup Y2K_CENTURY_MMDDYY { get { return GetElementByName<IGroup>(Names.Y2K_CENTURY_MMDDYY); } }
        public IField Y2K_CDATE_MM { get { return GetElementByName<IField>(Names.Y2K_CDATE_MM); } }
        public IField Y2K_CDATE_DD { get { return GetElementByName<IField>(Names.Y2K_CDATE_DD); } }
        public IField Y2K_CDATE_CC { get { return GetElementByName<IField>(Names.Y2K_CDATE_CC); } }
        public IField Y2K_CDATE_YY { get { return GetElementByName<IField>(Names.Y2K_CDATE_YY); } }
        public IGroup Y2K_CENTURY_MMDDYY_N { get { return GetElementByName<IGroup>(Names.Y2K_CENTURY_MMDDYY_N); } }
        public IField Y2K_CDATE_MM_N { get { return GetElementByName<IField>(Names.Y2K_CDATE_MM_N); } }
        public IField Y2K_CDATE_DD_N { get { return GetElementByName<IField>(Names.Y2K_CDATE_DD_N); } }
        public IField Y2K_CDATE_CC_N { get { return GetElementByName<IField>(Names.Y2K_CDATE_CC_N); } }
        public IField Y2K_CDATE_YY_N { get { return GetElementByName<IField>(Names.Y2K_CDATE_YY_N); } }
        public IGroup Y2K_MMYY_IN { get { return GetElementByName<IGroup>(Names.Y2K_MMYY_IN); } }
        public IField Y2K_IN_MON { get { return GetElementByName<IField>(Names.Y2K_IN_MON); } }
        public IField Y2K_IN_YEAR { get { return GetElementByName<IField>(Names.Y2K_IN_YEAR); } }
        public IGroup Y2K_MMYY_IN_N { get { return GetElementByName<IGroup>(Names.Y2K_MMYY_IN_N); } }
        public IField Y2K_IN_MON_N { get { return GetElementByName<IField>(Names.Y2K_IN_MON_N); } }
        public IField Y2K_IN_YEAR_N { get { return GetElementByName<IField>(Names.Y2K_IN_YEAR_N); } }
        public IGroup Y2K_CENTURY_MMYY { get { return GetElementByName<IGroup>(Names.Y2K_CENTURY_MMYY); } }
        public IField Y2K_CENTRY_MM { get { return GetElementByName<IField>(Names.Y2K_CENTRY_MM); } }
        public IField Y2K_CENTRY_CC { get { return GetElementByName<IField>(Names.Y2K_CENTRY_CC); } }
        public IField Y2K_CENTRY_YY { get { return GetElementByName<IField>(Names.Y2K_CENTRY_YY); } }
        public IGroup Y2K_CENTURY_MMYY_N { get { return GetElementByName<IGroup>(Names.Y2K_CENTURY_MMYY_N); } }
        public IField Y2K_CENTRY_MM_N { get { return GetElementByName<IField>(Names.Y2K_CENTRY_MM_N); } }
        public IField Y2K_CENTRY_CC_N { get { return GetElementByName<IField>(Names.Y2K_CENTRY_CC_N); } }
        public IField Y2K_CENTRY_YY_N { get { return GetElementByName<IField>(Names.Y2K_CENTRY_YY_N); } }
        public IGroup Y2K_JUL_IN { get { return GetElementByName<IGroup>(Names.Y2K_JUL_IN); } }
        public IField Y2K_JUL_YY_IN { get { return GetElementByName<IField>(Names.Y2K_JUL_YY_IN); } }
        public IField Y2K_JUL_DDD_IN { get { return GetElementByName<IField>(Names.Y2K_JUL_DDD_IN); } }
        public IGroup Y2K_JUL_IN_N { get { return GetElementByName<IGroup>(Names.Y2K_JUL_IN_N); } }
        public IField Y2K_JUL_YY_IN_N { get { return GetElementByName<IField>(Names.Y2K_JUL_YY_IN_N); } }
        public IField Y2K_JUL_DDD_IN_N { get { return GetElementByName<IField>(Names.Y2K_JUL_DDD_IN_N); } }
        public IGroup Y2K_JUL_CENTURY { get { return GetElementByName<IGroup>(Names.Y2K_JUL_CENTURY); } }
        public IField Y2K_JUL_CC { get { return GetElementByName<IField>(Names.Y2K_JUL_CC); } }
        public IGroup Y2K_JUL_CCL5 { get { return GetElementByName<IGroup>(Names.Y2K_JUL_CCL5); } }
        public IField Y2K_JUL_CCYY { get { return GetElementByName<IField>(Names.Y2K_JUL_CCYY); } }
        public IField Y2K_JUL_CCDD { get { return GetElementByName<IField>(Names.Y2K_JUL_CCDD); } }
        public IGroup Y2K_JUL_CENTURY_N { get { return GetElementByName<IGroup>(Names.Y2K_JUL_CENTURY_N); } }
        public IField Y2K_JUL_CC_N { get { return GetElementByName<IField>(Names.Y2K_JUL_CC_N); } }
        public IGroup Y2K_JUL_CCL5_N { get { return GetElementByName<IGroup>(Names.Y2K_JUL_CCL5_N); } }
        public IField Y2K_JUL_CCYY_N { get { return GetElementByName<IField>(Names.Y2K_JUL_CCYY_N); } }
        public IField Y2K_JUL_CCDD_N { get { return GetElementByName<IField>(Names.Y2K_JUL_CCDD_N); } }
        public IGroup Y2K_FY_YY_IN { get { return GetElementByName<IGroup>(Names.Y2K_FY_YY_IN); } }
        public IField Y2K_FY_IN { get { return GetElementByName<IField>(Names.Y2K_FY_IN); } }
        public IGroup Y2K_FY_YY_IN_N { get { return GetElementByName<IGroup>(Names.Y2K_FY_YY_IN_N); } }
        public IField Y2K_FY_IN_N { get { return GetElementByName<IField>(Names.Y2K_FY_IN_N); } }
        public IGroup Y2K_CENTURY_FY { get { return GetElementByName<IGroup>(Names.Y2K_CENTURY_FY); } }
        public IField Y2K_FY_CENT_CC { get { return GetElementByName<IField>(Names.Y2K_FY_CENT_CC); } }
        public IField Y2K_FY_CENT_YY { get { return GetElementByName<IField>(Names.Y2K_FY_CENT_YY); } }
        public IGroup Y2K_CENTURY_FY_N { get { return GetElementByName<IGroup>(Names.Y2K_CENTURY_FY_N); } }
        public IField Y2K_FY_CENT_CC_N { get { return GetElementByName<IField>(Names.Y2K_FY_CENT_CC_N); } }
        public IField Y2K_FY_CENT_YY_N { get { return GetElementByName<IField>(Names.Y2K_FY_CENT_YY_N); } }
        public IGroup Y2K_CONSTANTS { get { return GetElementByName<IGroup>(Names.Y2K_CONSTANTS); } }
        public IField ANCHOR_48 { get { return GetElementByName<IField>(Names.ANCHOR_48); } }
        public IField CENTURY_19 { get { return GetElementByName<IField>(Names.CENTURY_19); } }
        public IField CENTURY_20 { get { return GetElementByName<IField>(Names.CENTURY_20); } }
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

        #endregion

        #region Data structure definition
        /// <summary>
        /// Defines the entirety of the WorkingStorage IRecord structure as described by the Ateras.Framework.Buffer API.
        /// </summary>
        /// <param name="recordDef">The IStructureDefinition object to be used in defining the record structure.</param>
        protected override void DefineRecordStructure(IStructureDefinition recordDef)
        {
            recordDef.CreateNewField(Names.WS_WORKING_STORAGE, FieldType.String, 12, "W/S SWASZ052");

            recordDef.CreateNewGroup(Names.CONTROL_BLOCK, (CONTROL_BLOCK) =>
           {
               CONTROL_BLOCK.CreateNewFillerField(FieldType.String, 2, "AP");
               CONTROL_BLOCK.CreateNewField(Names.COMMAND_CODE, FieldType.String, 2, "RC");
               CONTROL_BLOCK.CreateNewField(Names.COMMAND_ID, FieldType.CompInt, 8, +0);
               CONTROL_BLOCK.CreateNewField(Names.FILE_NUMBER, FieldType.CompShort, 4, +0);
               CONTROL_BLOCK.CreateNewField(Names.RESPONSE_CODE, FieldType.CompShort, 4, +0);
               CONTROL_BLOCK.CreateNewField(Names.ISN, FieldType.CompInt, 8, +0);
               CONTROL_BLOCK.CreateNewField(Names.ISN_LOWER_LIMIT, FieldType.CompInt, 8, +0);
               CONTROL_BLOCK.CreateNewField(Names.ISN_QUANTITY, FieldType.CompInt, 8, +0);
               CONTROL_BLOCK.CreateNewField(Names.FORMAT_BUFFER_LENGTH, FieldType.CompShort, 4, +0);
               CONTROL_BLOCK.CreateNewField(Names.RECORD_BUFFER_LENGTH, FieldType.CompShort, 4, +0);
               CONTROL_BLOCK.CreateNewField(Names.SEARCH_BUFFER_LENGTH, FieldType.CompShort, 4, +0);
               CONTROL_BLOCK.CreateNewField(Names.VALUE_BUFFER_LENGTH, FieldType.CompShort, 4, +0);
               CONTROL_BLOCK.CreateNewField(Names.ISN_BUFFER_LENGTH, FieldType.CompShort, 4, +0);
               CONTROL_BLOCK.CreateNewField(Names.COMMAND_OPTION_1, FieldType.String, 1, SPACE);
               CONTROL_BLOCK.CreateNewField(Names.COMMAND_OPTION_2, FieldType.String, 1, SPACE);
               CONTROL_BLOCK.CreateNewField(Names.ADDITIONS_1, FieldType.String, 8, SPACES);
               CONTROL_BLOCK.CreateNewField(Names.ADDITIONS_2, FieldType.String, 4, SPACES);
               CONTROL_BLOCK.CreateNewField(Names.ADDITIONS_3, FieldType.String, 8, SPACES);
               CONTROL_BLOCK.CreateNewField(Names.ADDITIONS_4, FieldType.String, 8, SPACES);
               CONTROL_BLOCK.CreateNewFillerField(FieldType.String, 8, SPACES);
               CONTROL_BLOCK.CreateNewField(Names.COMMAND_TIME, FieldType.CompInt, 8, +0);
               CONTROL_BLOCK.CreateNewField(Names.USER_AREA, FieldType.String, 4, SPACES);
           });

            recordDef.CreateNewGroup(Names.MODULE_CONSTANTS, (MODULE_CONSTANTS) =>
           {
               MODULE_CONSTANTS.CreateNewField(Names.MC_THIS_PROGRAM, FieldType.String, 8, "SWASZ052");
           });

            IGroup Y2K_YYMMDD_IN_local = (IGroup)recordDef.CreateNewGroup(Names.Y2K_YYMMDD_IN, (Y2K_YYMMDD_IN) =>
           {
               Y2K_YYMMDD_IN.CreateNewField(Names.Y2K_YY_IN, FieldType.String, 2, FillWith.HighValues);
               Y2K_YYMMDD_IN.CreateNewField(Names.Y2K_MM_IN, FieldType.String, 2, FillWith.HighValues);
               Y2K_YYMMDD_IN.CreateNewField(Names.Y2K_DD_IN, FieldType.String, 2, FillWith.HighValues);
           });
            recordDef.CreateNewGroupRedefine(Names.Y2K_YYMMDD_IN_N, Y2K_YYMMDD_IN_local, (Y2K_YYMMDD_IN_N) =>
            {
                Y2K_YYMMDD_IN_N.CreateNewField(Names.Y2K_YY_IN_N, FieldType.UnsignedNumeric, 2);
                Y2K_YYMMDD_IN_N.CreateNewField(Names.Y2K_MM_IN_N, FieldType.UnsignedNumeric, 2);
                Y2K_YYMMDD_IN_N.CreateNewField(Names.Y2K_DD_IN_N, FieldType.UnsignedNumeric, 2);
            });

            IGroup Y2K_CENTURY_YYMMDD_local = (IGroup)recordDef.CreateNewGroup(Names.Y2K_CENTURY_YYMMDD, (Y2K_CENTURY_YYMMDD) =>
           {
               Y2K_CENTURY_YYMMDD.CreateNewField(Names.Y2K_CENT_CC, FieldType.String, 2, FillWith.HighValues);
               Y2K_CENTURY_YYMMDD.CreateNewGroup(Names.Y2K_CENT_YYMMDD, (Y2K_CENT_YYMMDD) =>
               {
                   Y2K_CENT_YYMMDD.CreateNewField(Names.Y2K_CENT_YY, FieldType.String, 2, FillWith.HighValues);
                   Y2K_CENT_YYMMDD.CreateNewField(Names.Y2K_CENT_MM, FieldType.String, 2, FillWith.HighValues);
                   Y2K_CENT_YYMMDD.CreateNewField(Names.Y2K_CENT_DD, FieldType.String, 2, FillWith.HighValues);
               });
           });
            recordDef.CreateNewGroupRedefine(Names.Y2K_CENTURY_YYMMDD_N, Y2K_CENTURY_YYMMDD_local, (Y2K_CENTURY_YYMMDD_N) =>
            {
                Y2K_CENTURY_YYMMDD_N.CreateNewField(Names.Y2K_CENT_CC_N, FieldType.UnsignedNumeric, 2);
                Y2K_CENTURY_YYMMDD_N.CreateNewGroup(Names.Y2K_CENT_YYMMDD_N, (Y2K_CENT_YYMMDD_N) =>
                {
                    Y2K_CENT_YYMMDD_N.CreateNewField(Names.Y2K_CENT_YY_N, FieldType.UnsignedNumeric, 2);
                    Y2K_CENT_YYMMDD_N.CreateNewField(Names.Y2K_CENT_MM_N, FieldType.UnsignedNumeric, 2);
                    Y2K_CENT_YYMMDD_N.CreateNewField(Names.Y2K_CENT_DD_N, FieldType.UnsignedNumeric, 2);
                });
            });

            IGroup Y2K_MMDDYY_IN_local = (IGroup)recordDef.CreateNewGroup(Names.Y2K_MMDDYY_IN, (Y2K_MMDDYY_IN) =>
           {
               Y2K_MMDDYY_IN.CreateNewField(Names.Y2K_IN_MM, FieldType.String, 2, FillWith.HighValues);
               Y2K_MMDDYY_IN.CreateNewField(Names.Y2K_IN_DD, FieldType.String, 2, FillWith.HighValues);
               Y2K_MMDDYY_IN.CreateNewField(Names.Y2K_IN_YY, FieldType.String, 2, FillWith.HighValues);
           });
            recordDef.CreateNewGroupRedefine(Names.Y2K_MMDDYY_IN_N, Y2K_MMDDYY_IN_local, (Y2K_MMDDYY_IN_N) =>
            {
                Y2K_MMDDYY_IN_N.CreateNewField(Names.Y2K_IN_MM_N, FieldType.UnsignedNumeric, 2);
                Y2K_MMDDYY_IN_N.CreateNewField(Names.Y2K_IN_DD_N, FieldType.UnsignedNumeric, 2);
                Y2K_MMDDYY_IN_N.CreateNewField(Names.Y2K_IN_YY_N, FieldType.UnsignedNumeric, 2);
            });

            IGroup Y2K_CENTURY_MMDDYY_local = (IGroup)recordDef.CreateNewGroup(Names.Y2K_CENTURY_MMDDYY, (Y2K_CENTURY_MMDDYY) =>
           {
               Y2K_CENTURY_MMDDYY.CreateNewField(Names.Y2K_CDATE_MM, FieldType.String, 2, FillWith.HighValues);
               Y2K_CENTURY_MMDDYY.CreateNewField(Names.Y2K_CDATE_DD, FieldType.String, 2, FillWith.HighValues);
               Y2K_CENTURY_MMDDYY.CreateNewField(Names.Y2K_CDATE_CC, FieldType.String, 2, FillWith.HighValues);
               Y2K_CENTURY_MMDDYY.CreateNewField(Names.Y2K_CDATE_YY, FieldType.String, 2, FillWith.HighValues);
           });
            recordDef.CreateNewGroupRedefine(Names.Y2K_CENTURY_MMDDYY_N, Y2K_CENTURY_MMDDYY_local, (Y2K_CENTURY_MMDDYY_N) =>
            {
                Y2K_CENTURY_MMDDYY_N.CreateNewField(Names.Y2K_CDATE_MM_N, FieldType.UnsignedNumeric, 2);
                Y2K_CENTURY_MMDDYY_N.CreateNewField(Names.Y2K_CDATE_DD_N, FieldType.UnsignedNumeric, 2);
                Y2K_CENTURY_MMDDYY_N.CreateNewField(Names.Y2K_CDATE_CC_N, FieldType.UnsignedNumeric, 2);
                Y2K_CENTURY_MMDDYY_N.CreateNewField(Names.Y2K_CDATE_YY_N, FieldType.UnsignedNumeric, 2);
            });

            IGroup Y2K_MMYY_IN_local = (IGroup)recordDef.CreateNewGroup(Names.Y2K_MMYY_IN, (Y2K_MMYY_IN) =>
           {
               Y2K_MMYY_IN.CreateNewField(Names.Y2K_IN_MON, FieldType.String, 2, FillWith.HighValues);
               Y2K_MMYY_IN.CreateNewField(Names.Y2K_IN_YEAR, FieldType.String, 2, FillWith.HighValues);
           });
            recordDef.CreateNewGroupRedefine(Names.Y2K_MMYY_IN_N, Y2K_MMYY_IN_local, (Y2K_MMYY_IN_N) =>
            {
                Y2K_MMYY_IN_N.CreateNewField(Names.Y2K_IN_MON_N, FieldType.UnsignedNumeric, 2);
                Y2K_MMYY_IN_N.CreateNewField(Names.Y2K_IN_YEAR_N, FieldType.UnsignedNumeric, 2);
            });

            IGroup Y2K_CENTURY_MMYY_local = (IGroup)recordDef.CreateNewGroup(Names.Y2K_CENTURY_MMYY, (Y2K_CENTURY_MMYY) =>
           {
               Y2K_CENTURY_MMYY.CreateNewField(Names.Y2K_CENTRY_MM, FieldType.String, 2, FillWith.HighValues);
               Y2K_CENTURY_MMYY.CreateNewField(Names.Y2K_CENTRY_CC, FieldType.String, 2, FillWith.HighValues);
               Y2K_CENTURY_MMYY.CreateNewField(Names.Y2K_CENTRY_YY, FieldType.String, 2, FillWith.HighValues);
           });
            recordDef.CreateNewGroupRedefine(Names.Y2K_CENTURY_MMYY_N, Y2K_CENTURY_MMYY_local, (Y2K_CENTURY_MMYY_N) =>
            {
                Y2K_CENTURY_MMYY_N.CreateNewField(Names.Y2K_CENTRY_MM_N, FieldType.UnsignedNumeric, 2);
                Y2K_CENTURY_MMYY_N.CreateNewField(Names.Y2K_CENTRY_CC_N, FieldType.UnsignedNumeric, 2);
                Y2K_CENTURY_MMYY_N.CreateNewField(Names.Y2K_CENTRY_YY_N, FieldType.UnsignedNumeric, 2);
            });

            IGroup Y2K_JUL_IN_local = (IGroup)recordDef.CreateNewGroup(Names.Y2K_JUL_IN, (Y2K_JUL_IN) =>
           {
               Y2K_JUL_IN.CreateNewField(Names.Y2K_JUL_YY_IN, FieldType.String, 2, FillWith.HighValues);
               Y2K_JUL_IN.CreateNewField(Names.Y2K_JUL_DDD_IN, FieldType.String, 3, FillWith.HighValues);
           });
            recordDef.CreateNewGroupRedefine(Names.Y2K_JUL_IN_N, Y2K_JUL_IN_local, (Y2K_JUL_IN_N) =>
            {
                Y2K_JUL_IN_N.CreateNewField(Names.Y2K_JUL_YY_IN_N, FieldType.UnsignedNumeric, 2);
                Y2K_JUL_IN_N.CreateNewField(Names.Y2K_JUL_DDD_IN_N, FieldType.UnsignedNumeric, 3);
            });

            IGroup Y2K_JUL_CENTURY_local = (IGroup)recordDef.CreateNewGroup(Names.Y2K_JUL_CENTURY, (Y2K_JUL_CENTURY) =>
           {
               Y2K_JUL_CENTURY.CreateNewField(Names.Y2K_JUL_CC, FieldType.String, 2, FillWith.HighValues);
               Y2K_JUL_CENTURY.CreateNewGroup(Names.Y2K_JUL_CCL5, (Y2K_JUL_CCL5) =>
               {
                   Y2K_JUL_CCL5.CreateNewField(Names.Y2K_JUL_CCYY, FieldType.String, 2, FillWith.HighValues);
                   Y2K_JUL_CCL5.CreateNewField(Names.Y2K_JUL_CCDD, FieldType.String, 3, FillWith.HighValues);
               });
           });
            recordDef.CreateNewGroupRedefine(Names.Y2K_JUL_CENTURY_N, Y2K_JUL_CENTURY_local, (Y2K_JUL_CENTURY_N) =>
            {
                Y2K_JUL_CENTURY_N.CreateNewField(Names.Y2K_JUL_CC_N, FieldType.UnsignedNumeric, 2);
                Y2K_JUL_CENTURY_N.CreateNewGroup(Names.Y2K_JUL_CCL5_N, (Y2K_JUL_CCL5_N) =>
                {
                    Y2K_JUL_CCL5_N.CreateNewField(Names.Y2K_JUL_CCYY_N, FieldType.UnsignedNumeric, 2);
                    Y2K_JUL_CCL5_N.CreateNewField(Names.Y2K_JUL_CCDD_N, FieldType.UnsignedNumeric, 3);
                });
            });

            IGroup Y2K_FY_YY_IN_local = (IGroup)recordDef.CreateNewGroup(Names.Y2K_FY_YY_IN, (Y2K_FY_YY_IN) =>
           {
               Y2K_FY_YY_IN.CreateNewField(Names.Y2K_FY_IN, FieldType.String, 2, FillWith.HighValues);
           });
            recordDef.CreateNewGroupRedefine(Names.Y2K_FY_YY_IN_N, Y2K_FY_YY_IN_local, (Y2K_FY_YY_IN_N) =>
            {
                Y2K_FY_YY_IN_N.CreateNewField(Names.Y2K_FY_IN_N, FieldType.UnsignedNumeric, 2);
            });

            IGroup Y2K_CENTURY_FY_local = (IGroup)recordDef.CreateNewGroup(Names.Y2K_CENTURY_FY, (Y2K_CENTURY_FY) =>
           {
               Y2K_CENTURY_FY.CreateNewField(Names.Y2K_FY_CENT_CC, FieldType.String, 2, FillWith.HighValues);
               Y2K_CENTURY_FY.CreateNewField(Names.Y2K_FY_CENT_YY, FieldType.String, 2, FillWith.HighValues);
           });
            recordDef.CreateNewGroupRedefine(Names.Y2K_CENTURY_FY_N, Y2K_CENTURY_FY_local, (Y2K_CENTURY_FY_N) =>
            {
                Y2K_CENTURY_FY_N.CreateNewField(Names.Y2K_FY_CENT_CC_N, FieldType.UnsignedNumeric, 2);
                Y2K_CENTURY_FY_N.CreateNewField(Names.Y2K_FY_CENT_YY_N, FieldType.UnsignedNumeric, 2);
            });

            recordDef.CreateNewGroup(Names.Y2K_CONSTANTS, (Y2K_CONSTANTS) =>
           {
               Y2K_CONSTANTS.CreateNewField(Names.ANCHOR_48, FieldType.String, 2, "48");
               Y2K_CONSTANTS.CreateNewField(Names.CENTURY_19, FieldType.String, 2, "19");
               Y2K_CONSTANTS.CreateNewField(Names.CENTURY_20, FieldType.String, 2, "20");
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
               SYSTEM_CONSTANTS.CreateNewField(Names.SRMODLNK, FieldType.String, 8, "SWASZ052");
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
    internal class SWASZ052_ls : PredefinedRecordBase
    {
        #region Name constants
        /// <summary>
        /// Name constants.
        /// </summary>
        internal static class Names
        {
            internal const string LinkageSection = "SWASZ052_ls_LinkageSection";
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
               DFHCOMMAREA.CreateNewGroupRedefine("FILLER_d3", CA_CURRENT_DATE_local, (FILLER_d3) =>
               {
                   FILLER_d3.CreateNewField(Names.CA_CURRENT_CC, FieldType.UnsignedNumeric, 2);
                   FILLER_d3.CreateNewField(Names.CA_CURRENT_YY, FieldType.UnsignedNumeric, 2);
                   FILLER_d3.CreateNewGroup(Names.CA_CURRENT_MMDD, (CA_CURRENT_MMDD) =>
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
                   TWA_ADABAS_PARMS.CreateNewFieldArray("FILLER_d6", 7, FieldType.CompInt, 4);
               });
               TWA.CreateNewGroupRedefine(Names.TWA_CICS_PARMS, TWA_ADABAS_PARMS_local, (TWA_CICS_PARMS) =>
               {
                   TWA_CICS_PARMS.CreateNewField(Names.TWA_PROGRAM_ID, FieldType.String, 8);
                   TWA_CICS_PARMS.CreateNewGroup(Names.TWA_ADDR_LIST, (TWA_ADDR_LIST) =>
                   {
                       TWA_ADDR_LIST.CreateNewFieldArray("FILLER_d7", 5, FieldType.CompInt, 4);
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
    public class SWASZ052 : OnlineProgramBase
    {

        #region Public Constructors
        public SWASZ052()
            : base()
        {
            SetUpProgram();
        }

        public SWASZ052(OnlineControl controlData) : base(controlData)
        {
            SetUpProgram();
        }

        private void SetUpProgram()
        {
            this.ProgramName = "SWASZ052";

            WS = new SWASZ052_ws();
            LS = new SWASZ052_ls();
        }

        #endregion

        #region Private Fields


        //==== Working Storage Data Class ========================================
        private SWASZ052_ws WS;

        //==== Linkage Section Data Class ========================================
        private SWASZ052_ls LS;
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
            LS.TWA.SetValueAll(HIGH_VALUES);                                                                    //COBOL==> MOVE HIGH-VALUES TO TWA.
            SetHandleCondtions(HandleCondition.ERROR, "M_SZ912_CICS_ABEND");                                    //COBOL==> EXEC CICS HANDLE CONDITION ERROR ( SZ912-CICS-ABEND ) END-EXEC.
                                                                                                                // Execute Procedure Division Logic
            M_0000_MAIN_LOGIC(returnMethod);
        }
        /// <summary>
        /// Method M_0000_MAIN_LOGIC
        /// </summary>
        private void M_0000_MAIN_LOGIC(string returnMethod = "")
        {
            Control.Call("ADASTWA", LS.TWA, WS.CONTROL_BLOCK); if (Control.ExitProgram) return;                //COBOL==> CALL 'ADASTWA' USING TWA CONTROL-BLOCK.
            Control.Call(WS.SRADALNK.AsString(), LS.DFHCOMMAREA, LS.TWA); if (Control.ExitProgram) return;     //COBOL==> CALL SRADALNK USING DFHEIBLK DFHCOMMAREA TWA
                                                                                                               //COMMENT: ----------------------------------------------------------------*
                                                                                                               //COMMENT:  CTA MODIFICATION 10:00:01 AM. MARCH 19, 1998                   *
                                                                                                               //COMMENT: ----------------------------------------------------------------*
            WS.Y2K_YY_IN.SetValue(LS.CA_CURRENT_YY);                                                            //COBOL==> MOVE CA-CURRENT-YY TO Y2K-YY-IN.
            WS.Y2K_MM_IN.SetValue(LS.CA_CURRENT_MM);                                                            //COBOL==> MOVE CA-CURRENT-MM TO Y2K-MM-IN.
            WS.Y2K_DD_IN.SetValue(LS.CA_CURRENT_DD);                                                            //COBOL==> MOVE CA-CURRENT-DD TO Y2K-DD-IN.
            M_Z910_YYMMDD_ROUTINE("M_Z910_YYMMDD_ROUTINE_EXIT"); if (Control.ExitProgram) { return; }             //COBOL==> PERFORM Z910-YYMMDD-ROUTINE THRU Z910-YYMMDD-ROUTINE-EXIT.
            LS.CA_CURRENT_CC.SetValue(WS.Y2K_CENT_CC);                                                          //COBOL==> MOVE Y2K-CENT-CC TO CA-CURRENT-CC.
            if (WS.RESPONSE_CODE.IsGreaterThan(ZEROS))                                                          //COBOL==> IF RESPONSE-CODE > ZERO
            {
                LS.CA_ADA_RESPONSE_CODE.SetValue(WS.RESPONSE_CODE);                                                 //COBOL==> MOVE RESPONSE-CODE TO CA-ADA-RESPONSE-CODE
                M_8000_ADABAS_ABEND("M_8000_EXIT"); if (Control.ExitProgram) { return; }                              //COBOL==> PERFORM 8000-ADABAS-ABEND THRU 8000-EXIT.
            }
            if (returnMethod != "" && returnMethod != "M_0000_MAIN_LOGIC") { M_0000_EXIT(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_0000_EXIT
        /// </summary>
        private void M_0000_EXIT(string returnMethod = "")
        {
            Control.Return(LS); return;                                                                         //COBOL==> EXEC CICS RETURN END-EXEC.
            Control.ExitProgram = true; return;                                                                 //COBOL==> GOBACK.
        }
        /// <summary>
        /// Method M_8000_ADABAS_ABEND
        /// </summary>
        private void M_8000_ADABAS_ABEND(string returnMethod = "")
        {
            LS.CA_THIS_PROGRAM.SetValue(WS.MC_THIS_PROGRAM);                                                    //COBOL==> MOVE MC-THIS-PROGRAM TO CA-THIS-PROGRAM.
            LS.CA_ABEND_TYPE.SetValue(WS.SC_ADABAS_ERROR);                                                      //COBOL==> MOVE SC-ADABAS-ERROR TO CA-ABEND-TYPE.
            LS.CA_ABEND_LINE.SetValue("@SYSTEM RELEASE.");                                                      //COBOL==> MOVE '@SYSTEM RELEASE.' TO CA-ABEND-LINE.
            LS.CA_ADA_CALL_SEQ.SetValue("1ST CALL");                                                            //COBOL==> MOVE '1ST CALL' TO CA-ADA-CALL-SEQ.
            M_SZ912_ERROR_PROGRAM(CheckGotoReturn(returnMethod)); return;                                       //COBOL==> GO TO SZ912-ERROR-PROGRAM.
        }
        /// <summary>
        /// Method M_8000_EXIT
        /// </summary>
        private void M_8000_EXIT(string returnMethod = "")
        {
            if (returnMethod != "" && returnMethod != "M_8000_EXIT") { M_SZ912_CICS_ABEND(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_SZ912_CICS_ABEND
        /// </summary>
        /// <remarks>
        ///COMMENT: **** START DOCUMENTATION ****************************************
        ///COMMENT: *                                                              **
        ///COMMENT: *    SYSTEM:  CAECSES  - AUTOMATED ELIGIBILITY                 **
        ///COMMENT: *                                                              **
        ///COMMENT: *    PROGRAM: SWASZ912 - CICS ABEND                            **
        ///COMMENT: *                                                              **
        ///COMMENT: *    DESCRIPTION:                                              **
        ///COMMENT: *        CICS ABEND                                            **
        ///COMMENT: *                                                              **
        ///COMMENT: *    PROCESSING:                                               **
        ///COMMENT: *        THIS MODULE FORMATS THE ERROR PARMETERS AND TRANSFERS **
        ///COMMENT: *        TO THE ERROR PROGRAM (SWASS910).                      **
        ///COMMENT: *                                                              **
        ///COMMENT: *    LINK MODULES:                                             **
        ///COMMENT: *         MODULE      DESCRIPTION                              **
        ///COMMENT: *                                                              **
        ///COMMENT: *    CREATED BY SHL SYSTEMHOUSE, 04/20/1988                    **
        ///COMMENT: *                                                              **
        ///COMMENT: **** END DOCUMENTATION ******************************************
        ///COMMENT: **** START MAINTENANCE LOG ************ PROGRAM SWASZ912 ********
        ///COMMENT: *                                                              **
        ///COMMENT: *    MAINTENANCE LOG                                           **
        ///COMMENT: *        AUTHOR     DATE    CHG REQ #  DESCRIPTION             **
        ///COMMENT: *                                                              **
        ///COMMENT: **** END MAINTENANCE LOG ****************************************
        /// </remarks>
        private void M_SZ912_CICS_ABEND(string returnMethod = "")
        {
            LS.CA_THIS_PROGRAM.SetValue(WS.MC_THIS_PROGRAM);                                                    //COBOL==> MOVE MC-THIS-PROGRAM TO CA-THIS-PROGRAM.
            LS.CA_ABEND_TYPE.SetValue(WS.SC_CICS_ERROR);                                                        //COBOL==> MOVE SC-CICS-ERROR TO CA-ABEND-TYPE.
                                                                                                                //COMMENT:      MOVE DFHEIV0         TO CA-ABEND-LINE.
            LS.CA_CICS_RESPONSE_CODE.SetValue(Control.EIBRCODE);                                                //COBOL==> MOVE EIBRCODE TO CA-CICS-RESPONSE-CODE.
            LS.CA_CICS_FUNCTION_CODE.SetValue(Control.EIBFN);                                                   //COBOL==> MOVE EIBFN TO CA-CICS-FUNCTION-CODE.
            LS.CA_CICS_RESOURCE_NAME.SetValue(Control.EIBRSRCE);                                                //COBOL==> MOVE EIBRSRCE TO CA-CICS-RESOURCE-NAME.
            SetHandleCondtions(HandleCondition.ERROR, "M_");                                                    //COBOL==> EXEC CICS HANDLE CONDITION ERROR END-EXEC.
            if (returnMethod != "" && returnMethod != "M_SZ912_CICS_ABEND") { M_SZ912_ERROR_PROGRAM(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_SZ912_ERROR_PROGRAM
        /// </summary>
        private void M_SZ912_ERROR_PROGRAM(string returnMethod = "")
        {
            Control.Transfer(WS.SC_ERROR_PROGRAM, LS.DFHCOMMAREA, WS.SC_COMMAREA_LENGTH.AsInt()); return;       //COBOL==> EXEC CICS XCTL PROGRAM ( SC-ERROR-PROGRAM ) COMMAREA ( DFHCOMMAREA ) LENGTH ( SC-COMMAREA-LENGTH ) END-EXEC.
        }
        /// <summary>
        /// Method M_SZ912_EXIT
        /// </summary>
        private void M_SZ912_EXIT(string returnMethod = "")
        {
            if (returnMethod != "" && returnMethod != "M_SZ912_EXIT") { M_Z900_CCFY_ROUTINE(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_Z900_CCFY_ROUTINE
        /// </summary>
        /// <remarks>
        ///COMMENT: ----------------------------------------------------------------*
        ///COMMENT:  CTA MODIFICATION                                               *
        ///COMMENT: ----------------------------------------------------------------*
        ///COMMENT: **** START DOCUMENTATION ****************************************
        ///COMMENT: *****************************************************************
        ///COMMENT: *    CREATED BY CTA, INC. 4-18-98                              **
        ///COMMENT: *       PROJECT 960770 - YEAR 2000 COMPLIANCE PROJECT          **
        ///COMMENT: *****************************************************************
        ///COMMENT: *                                                              **
        ///COMMENT: *    PROGRAM: SWY2KDTO - INCLUDE MODULE FOR PROCEDURE DIVISION **
        ///COMMENT: *                        FOR Y2K DATE (CENTURY) CONVERSION     **
        ///COMMENT: *                        ROUTINES                              **
        ///COMMENT: *  CLONE OF SWY2KDTC EXCEPT USES SINGLE QUOTES FOR ONLINE CICS **
        ///COMMENT: *                                                              **
        ///COMMENT: *    SYSTEM:  ALL SRS LEGACY MAINFRAME COBOL SYSTEMS           **
        ///COMMENT: *                                                              **
        ///COMMENT: *    DESCRIPTION: THIS INCLUDE MODULE IS TO BE USED WHEN DATE  **
        ///COMMENT: *                 CONVERSION ROUTINES ARE NEEDED TO INSERT     **
        ///COMMENT: *                 THE CENTURY IN DATES CONTAINING ONLY 2-DIGIT **
        ///COMMENT: *                 YEARS.  THIS MODULE MUST BE INCLUDED NEAR THE**
        ///COMMENT: *                 END OF THE PROCEDURE DIVISION.
        ///COMMENT: *
        ///COMMENT: *                 SWY2KWSC MUST ALSO BE INCLUDED IN WORKING    **
        ///COMMENT: *                 STORAGE.  THOSE WORKING STORAGE DEFINITIONS  **
        ///COMMENT: *                 PROVIDE DATA NAMES USED IN THESE LOGIC       **
        ///COMMENT: *                 ROUTINES.                                    **
        ///COMMENT: *                                                              **
        ///COMMENT: *    PROCESSING                                                **
        ///COMMENT: *        WHEN DATES HAVING ONLY A TWO DIGIT YEAR NEED TO BE    **
        ///COMMENT: *        CONVERTED TO A 4-DIGIT YEAR, INCLUDE THIS MODULE IN   **
        ///COMMENT: *        THE PROCEDURE DIVISION AND SWY2KWS IN WORKING STORAGE.**
        ///COMMENT: *        ALL ENHANCEMENTS TO SYSTEMS MUST USE 4-DIGIT YEAR     **
        ///COMMENT: *                                                              **
        ///COMMENT: *        THE CONVERSION ROUTINES USE A WINDOWING APPROACH TO   **
        ///COMMENT: *        DETERMINE WHAT THE CENTURY IS.  THE WINDOWING USES    **
        ///COMMENT: *        AN ANCHOR (PIVOT) YEAR TO DETERMINE WHAT THE CENTURY  **
        ///COMMENT: *        FOR A GIVEN DATE SHOULD BE.  REVIEW THE LOGIC IN      **
        ///COMMENT: *        INCLUDE MODULE SWY2KDTC TO SEE WHAT THIS ANCHOR YEAR  **
        ///COMMENT: *        IS. IF THE YEAR IS LESS THAN THE ANCHOR YEAR, THEN    **
        ///COMMENT: *        THE CENTURY IS SET TO 20, OTHERWISE IT IS SET TO 19.  **
        ///COMMENT: *        THE ANCHOR YEAR (PIVOT) IS '48'.
        ///COMMENT: *                                                              **
        ///COMMENT: *        THE CONVERSION ROUTINES HANDLE FOUR TYPES OF DATES,   **
        ///COMMENT: *        INCLUDING FISCAL YEAR DATES, JULIAN DATES, AND BOTH   **
        ///COMMENT: *        FORMS OF GREGORIAN DATES, YYMMDD AND MMDDYY.          **
        ///COMMENT: *                                                              **
        ///COMMENT: *        ALL CONVERSION ROUTINES                               **
        ///COMMENT: *        IF DATE IS NOT NUMERIC - EXIT ROUTINE. THE INPUT      **
        ///COMMENT: *        DATA REMAINS THE SAME AND WILL PROCESS THRU THE DATA  **
        ///COMMENT: *        WITHOUT ANY CHANGES.                                  **
        ///COMMENT: *        THE CENTURY IS ADDED ONLY TO NUMERIC DATA FOR FURTHER **
        ///COMMENT: *        PROCESSING.                                           **
        ///COMMENT: *                                                              **
        ///COMMENT: *        RULES FOR CODING: EACH TYPE OF DATE HAS SEPARATE      **
        ///COMMENT: *        PARAGRAPHS THAT MUST BE PERFORMED AS FOLLOWS:         **
        ///COMMENT: *                                                              **
        ///COMMENT: *        FISCAL YEAR DATES:                                    **
        ///COMMENT: *           MOVE THE DATE IN THE FORM OF YY TO Y2K-FY-IN       **
        ///COMMENT: *           PERFORM Z900-CCFY-ROUTINE THRU                     **
        ///COMMENT: *                       Z900-CCFY-ROUTINE-EXIT                 **
        ///COMMENT: *           THE DATE WILL BE RETURNED IN Y2K-CENTURY-FY        **
        ///COMMENT: *           IN THE FORM OF CCYY.                               **
        ///COMMENT: *                                                              **
        ///COMMENT: *        YYMMDD DATE FORMATS:                                  **
        ///COMMENT: *           MOVE THE DATE TO Y2K-YYMMDD-IN                     **
        ///COMMENT: *           PERFORM Z910-YYMMDD-ROUTINE THRU                   **
        ///COMMENT: *                      Z910-YYMMDD-ROUTINE-EXIT                **
        ///COMMENT: *           THE DATE WILL BE RETURNED IN Y2K-CENTURY-YYMMDD    **
        ///COMMENT: *           IN THE FORM OF CCYYMMDD                            **
        ///COMMENT: *                                                              **
        ///COMMENT: *        MMDDYY DATE FORMATS:                                  **
        ///COMMENT: *           MOVE THE DATE TO Y2K-MMDDYY-IN                     **
        ///COMMENT: *           PERFORM Z920-MMDDYY-ROUTINE THRU                   **
        ///COMMENT: *                      Z920-MMDDYY-ROUTINE-EXIT                **
        ///COMMENT: *           THE DATE WILL BE RETURNED IN Y2K-CENTURY-MMDDYY    **
        ///COMMENT: *           IN THE FORM OF MMDDCCYY                            **
        ///COMMENT: *                                                              **
        ///COMMENT: *        CCDDD  DATE FORMATS:                                  **
        ///COMMENT: *           MOVE THE DATE TO Y2K-JULIAN-IN                     **
        ///COMMENT: *           PERFORM Z930-JULIAN-ROUTINE THRU                   **
        ///COMMENT: *                      Z930-JULIAN-ROUTINE-EXIT                **
        ///COMMENT: *           THE DATE WILL BE RETURNED IN Y2K-JUL-CENTURY       **
        ///COMMENT: *           IN THE FORM OF CCDDD                               **
        ///COMMENT: *                                                              **
        ///COMMENT: *        MMYY DATE FORMATS:                                    **
        ///COMMENT: *           MOVE THE DATE TO Y2K-MMYY-IN                       **
        ///COMMENT: *           PERFORM Z940-MMYY-ROUTINE THRU                     **
        ///COMMENT: *                      Z940-MMYY-ROUTINE-EXIT                  **
        ///COMMENT: *           THE DATE WILL BE RETURNED IN Y2K-CENTURY-MMYY      **
        ///COMMENT: *           IN THE FORM OF MMCCYY                              **
        ///COMMENT: *                                                              **
        ///COMMENT: **** END DOCUMENTATION ******************************************
        ///COMMENT: *****************************************************************
        ///COMMENT: **** START MAINTENANCE LOG ************ PROGRAM SWY2KDTC ********
        ///COMMENT: *                                                              **
        ///COMMENT: *    MAINTENANCE LOG                                           **
        ///COMMENT: *        AUTHOR     DATE    CHG REQ #  DESCRIPTION             **
        ///COMMENT: *                                                              **
        ///COMMENT: **** END MAINTENANCE LOG ****************************************
        ///COMMENT: ----------------------------------------------------------------*
        ///COMMENT:   FISCAL YEAR DATE CONVERSION ROUTINE:  YY TO CCYY              *
        ///COMMENT: ----------------------------------------------------------------*
        /// </remarks>
        private void M_Z900_CCFY_ROUTINE(string returnMethod = "")
        {
            if (!(WS.Y2K_FY_IN.IsNumericValue()))                                                              //COBOL==> IF Y2K-FY-IN NOT NUMERIC
            {
                M_Z900_CCFY_ROUTINE_EXIT(CheckGotoReturn(returnMethod)); return;                                    //COBOL==> GO TO Z900-CCFY-ROUTINE-EXIT
            }                                                                                                   //COBOL==> END-IF
            if (WS.Y2K_FY_IN.IsLessThan(WS.ANCHOR_48))                                                          //COBOL==> IF Y2K-FY-IN < ANCHOR-48
            {
                WS.Y2K_FY_CENT_CC.SetValue(WS.CENTURY_20);                                                          //COBOL==> MOVE CENTURY-20 TO Y2K-FY-CENT-CC
            }                                                                                                   //COBOL==> ELSE
            else
            {
                WS.Y2K_FY_CENT_CC.SetValue(WS.CENTURY_19);                                                          //COBOL==> MOVE CENTURY-19 TO Y2K-FY-CENT-CC
            }                                                                                                   //COBOL==> END-IF
            WS.Y2K_FY_CENT_YY.SetValue(WS.Y2K_FY_IN);                                                           //COBOL==> MOVE Y2K-FY-IN TO Y2K-FY-CENT-YY
            WS.Y2K_FY_IN.ResetToInitialValue();                                                                 //COBOL==> INITIALIZE Y2K-FY-IN .
            if (returnMethod != "" && returnMethod != "M_Z900_CCFY_ROUTINE") { M_Z900_CCFY_ROUTINE_EXIT(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_Z900_CCFY_ROUTINE_EXIT
        /// </summary>
        private void M_Z900_CCFY_ROUTINE_EXIT(string returnMethod = "")
        {
            if (returnMethod == "M_Z900_CCFY_ROUTINE_EXIT") { return; }                                         //COBOL==> EXIT.
            if (returnMethod != "" && returnMethod != "M_Z900_CCFY_ROUTINE_EXIT") { M_Z910_YYMMDD_ROUTINE(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_Z910_YYMMDD_ROUTINE
        /// </summary>
        /// <remarks>
        ///COMMENT: ----------------------------------------------------------------*
        ///COMMENT:   DATE CONVERSION ROUTINE: YYMMDD TO CCYYMMDD                   *
        ///COMMENT: ----------------------------------------------------------------*
        /// </remarks>
        private void M_Z910_YYMMDD_ROUTINE(string returnMethod = "")
        {
            if (!(WS.Y2K_YYMMDD_IN.IsNumericValue()))                                                          //COBOL==> IF Y2K-YYMMDD-IN NOT NUMERIC
            {
                M_Z910_YYMMDD_ROUTINE_EXIT(CheckGotoReturn(returnMethod)); return;                                  //COBOL==> GO TO Z910-YYMMDD-ROUTINE-EXIT
            }                                                                                                   //COBOL==> END-IF
            WS.Y2K_CENT_YYMMDD.SetValue(WS.Y2K_YYMMDD_IN);                                                      //COBOL==> MOVE Y2K-YYMMDD-IN TO Y2K-CENT-YYMMDD
            if ((((WS.Y2K_YY_IN.IsEqualTo(0))
             && (WS.Y2K_MM_IN.IsEqualTo(0)))
             && (WS.Y2K_DD_IN.IsEqualTo(0)))
             || (((WS.Y2K_YY_IN.IsEqualTo("99"))
             && (WS.Y2K_MM_IN.IsEqualTo("99")))
             && (WS.Y2K_DD_IN.IsEqualTo("99"))))  //COBOL==> IF ( ( Y2K-YY-IN = ZERO AND Y2K-MM-IN = ZERO AND Y2K-DD-IN = ZERO ) OR ( Y2K-YY-IN = '99' AND Y2K-MM-IN = '99' AND Y2K-DD-IN = '99' ) )
            {
                WS.Y2K_CENT_CC.SetValueWithZeroes();                                                                //COBOL==> MOVE ZEROS TO Y2K-CENT-CC
            }                                                                                                   //COBOL==> ELSE
            else
            {
                if (WS.Y2K_YY_IN.IsLessThan(WS.ANCHOR_48))                                                          //COBOL==> IF Y2K-YY-IN < ANCHOR-48
                {
                    WS.Y2K_CENT_CC.SetValue(WS.CENTURY_20);                                                             //COBOL==> MOVE CENTURY-20 TO Y2K-CENT-CC
                }                                                                                                   //COBOL==> ELSE
                else
                {
                    WS.Y2K_CENT_CC.SetValue(WS.CENTURY_19);                                                             //COBOL==> MOVE CENTURY-19 TO Y2K-CENT-CC
                }                                                                                                   //COBOL==> END-IF
            }                                                                                                   //COBOL==> END-IF
            WS.Y2K_YYMMDD_IN.ResetToInitialValue();                                                             //COBOL==> INITIALIZE Y2K-YYMMDD-IN .
            if (returnMethod != "" && returnMethod != "M_Z910_YYMMDD_ROUTINE") { M_Z910_YYMMDD_ROUTINE_EXIT(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_Z910_YYMMDD_ROUTINE_EXIT
        /// </summary>
        private void M_Z910_YYMMDD_ROUTINE_EXIT(string returnMethod = "")
        {
            if (returnMethod == "M_Z910_YYMMDD_ROUTINE_EXIT") { return; }                                       //COBOL==> EXIT.
            if (returnMethod != "" && returnMethod != "M_Z910_YYMMDD_ROUTINE_EXIT") { M_Z920_MMDDYY_ROUTINE(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_Z920_MMDDYY_ROUTINE
        /// </summary>
        /// <remarks>
        ///COMMENT: ----------------------------------------------------------------*
        ///COMMENT:   DATE CONVERSION ROUTINE: MMDDYY TO MMDDCCYY                   *
        ///COMMENT: ----------------------------------------------------------------*
        /// </remarks>
        private void M_Z920_MMDDYY_ROUTINE(string returnMethod = "")
        {
            WS.Y2K_CDATE_MM.SetValue(WS.Y2K_IN_MM);                                                             //COBOL==> MOVE Y2K-IN-MM TO Y2K-CDATE-MM
            WS.Y2K_CDATE_DD.SetValue(WS.Y2K_IN_DD);                                                             //COBOL==> MOVE Y2K-IN-DD TO Y2K-CDATE-DD
            WS.Y2K_CDATE_YY.SetValue(WS.Y2K_IN_YY);                                                             //COBOL==> MOVE Y2K-IN-YY TO Y2K-CDATE-YY
            if (!(WS.Y2K_MMDDYY_IN.IsNumericValue()))                                                          //COBOL==> IF Y2K-MMDDYY-IN NOT NUMERIC
            {
                M_Z920_MMDDYY_ROUTINE_EXIT(CheckGotoReturn(returnMethod)); return;                                  //COBOL==> GO TO Z920-MMDDYY-ROUTINE-EXIT
            }                                                                                                   //COBOL==> END-IF
            if ((((WS.Y2K_MM_IN.IsEqualTo(0))
             && (WS.Y2K_DD_IN.IsEqualTo(0)))
             && (WS.Y2K_YY_IN.IsEqualTo(0)))
             || (((WS.Y2K_MM_IN.IsEqualTo("99"))
             && (WS.Y2K_DD_IN.IsEqualTo("99")))
             && (WS.Y2K_YY_IN.IsEqualTo("99"))))  //COBOL==> IF ( ( Y2K-MM-IN = ZERO AND Y2K-DD-IN = ZERO AND Y2K-YY-IN = ZERO ) OR ( Y2K-MM-IN = '99' AND Y2K-DD-IN = '99' AND Y2K-YY-IN = '99' ) )
            {
                WS.Y2K_CDATE_CC.SetValueWithZeroes();                                                               //COBOL==> MOVE ZEROS TO Y2K-CDATE-CC
            }                                                                                                   //COBOL==> ELSE
            else
            {
                if (WS.Y2K_IN_YY.IsLessThan(WS.ANCHOR_48))                                                          //COBOL==> IF Y2K-IN-YY < ANCHOR-48
                {
                    WS.Y2K_CDATE_CC.SetValue(WS.CENTURY_20);                                                            //COBOL==> MOVE CENTURY-20 TO Y2K-CDATE-CC
                }                                                                                                   //COBOL==> ELSE
                else
                {
                    WS.Y2K_CDATE_CC.SetValue(WS.CENTURY_19);                                                            //COBOL==> MOVE CENTURY-19 TO Y2K-CDATE-CC
                }                                                                                                   //COBOL==> END-IF
            }                                                                                                   //COBOL==> END-IF
            WS.Y2K_MMDDYY_IN.ResetToInitialValue();                                                             //COBOL==> INITIALIZE Y2K-MMDDYY-IN .
            if (returnMethod != "" && returnMethod != "M_Z920_MMDDYY_ROUTINE") { M_Z920_MMDDYY_ROUTINE_EXIT(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_Z920_MMDDYY_ROUTINE_EXIT
        /// </summary>
        private void M_Z920_MMDDYY_ROUTINE_EXIT(string returnMethod = "")
        {
            if (returnMethod == "M_Z920_MMDDYY_ROUTINE_EXIT") { return; }                                       //COBOL==> EXIT.
            if (returnMethod != "" && returnMethod != "M_Z920_MMDDYY_ROUTINE_EXIT") { M_Z930_JULIAN_ROUTINE(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_Z930_JULIAN_ROUTINE
        /// </summary>
        /// <remarks>
        ///COMMENT: ----------------------------------------------------------------*
        ///COMMENT:   JULIAN DATE CONVERSION ROUTINE: YYDDD TO CCYYDDD
        ///COMMENT: ----------------------------------------------------------------*
        /// </remarks>
        private void M_Z930_JULIAN_ROUTINE(string returnMethod = "")
        {
            WS.Y2K_JUL_CCL5.SetValue(WS.Y2K_JUL_IN);                                                            //COBOL==> MOVE Y2K-JUL-IN TO Y2K-JUL-CCL5
            if (!(WS.Y2K_JUL_IN.IsNumericValue()))                                                             //COBOL==> IF Y2K-JUL-IN NOT NUMERIC
            {
                M_Z930_JULIAN_ROUTINE_EXIT(CheckGotoReturn(returnMethod)); return;                                  //COBOL==> GO TO Z930-JULIAN-ROUTINE-EXIT
            }                                                                                                   //COBOL==> END-IF
            if (WS.Y2K_JUL_DDD_IN.IsEqualTo(0))                                                                 //COBOL==> IF Y2K-JUL-DDD-IN = ZERO
            {
                WS.Y2K_JUL_CC.SetValueWithZeroes();                                                                 //COBOL==> MOVE ZEROS TO Y2K-JUL-CC
            }                                                                                                   //COBOL==> ELSE
            else
            {
                if (WS.Y2K_JUL_YY_IN.IsLessThan(WS.ANCHOR_48))                                                      //COBOL==> IF Y2K-JUL-YY-IN < ANCHOR-48
                {
                    WS.Y2K_JUL_CC.SetValue(WS.CENTURY_20);                                                              //COBOL==> MOVE CENTURY-20 TO Y2K-JUL-CC
                }                                                                                                   //COBOL==> ELSE
                else
                {
                    WS.Y2K_JUL_CC.SetValue(WS.CENTURY_19);                                                              //COBOL==> MOVE CENTURY-19 TO Y2K-JUL-CC
                }                                                                                                   //COBOL==> END-IF
            }                                                                                                   //COBOL==> END-IF
            WS.Y2K_JUL_IN.ResetToInitialValue();                                                                //COBOL==> INITIALIZE Y2K-JUL-IN .
            if (returnMethod != "" && returnMethod != "M_Z930_JULIAN_ROUTINE") { M_Z930_JULIAN_ROUTINE_EXIT(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_Z930_JULIAN_ROUTINE_EXIT
        /// </summary>
        private void M_Z930_JULIAN_ROUTINE_EXIT(string returnMethod = "")
        {
            if (returnMethod == "M_Z930_JULIAN_ROUTINE_EXIT") { return; }                                       //COBOL==> EXIT.
            if (returnMethod != "" && returnMethod != "M_Z930_JULIAN_ROUTINE_EXIT") { M_Z940_MMYY_ROUTINE(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_Z940_MMYY_ROUTINE
        /// </summary>
        /// <remarks>
        ///COMMENT: ----------------------------------------------------------------*
        ///COMMENT:   DATE CONVERSION ROUTINE: MMYY TO MMCCYY                       *
        ///COMMENT: ----------------------------------------------------------------*
        /// </remarks>
        private void M_Z940_MMYY_ROUTINE(string returnMethod = "")
        {
            WS.Y2K_CENTRY_MM.SetValue(WS.Y2K_IN_MON);                                                           //COBOL==> MOVE Y2K-IN-MON TO Y2K-CENTRY-MM
            WS.Y2K_CENTRY_YY.SetValue(WS.Y2K_IN_YEAR);                                                          //COBOL==> MOVE Y2K-IN-YEAR TO Y2K-CENTRY-YY
            if (!(WS.Y2K_MMYY_IN.IsNumericValue()))                                                            //COBOL==> IF Y2K-MMYY-IN NOT NUMERIC
            {
                M_Z940_MMYY_ROUTINE_EXIT(CheckGotoReturn(returnMethod)); return;                                    //COBOL==> GO TO Z940-MMYY-ROUTINE-EXIT
            }                                                                                                   //COBOL==> END-IF
            if (((WS.Y2K_IN_MON.IsEqualTo(0))
             && (WS.Y2K_IN_YEAR.IsEqualTo(0)))
             || ((WS.Y2K_IN_MON.IsEqualTo("99"))
             && (WS.Y2K_IN_YEAR.IsEqualTo("99"))))  //COBOL==> IF ( ( Y2K-IN-MON = ZERO AND Y2K-IN-YEAR = ZERO ) OR ( Y2K-IN-MON = '99' AND Y2K-IN-YEAR = '99' ) )
            {
                WS.Y2K_CENTRY_CC.SetValueWithZeroes();                                                              //COBOL==> MOVE ZEROS TO Y2K-CENTRY-CC
            }                                                                                                   //COBOL==> ELSE
            else
            {
                if (WS.Y2K_IN_YEAR.IsLessThan(WS.ANCHOR_48))                                                        //COBOL==> IF Y2K-IN-YEAR < ANCHOR-48
                {
                    WS.Y2K_CENTRY_CC.SetValue(WS.CENTURY_20);                                                           //COBOL==> MOVE CENTURY-20 TO Y2K-CENTRY-CC
                }                                                                                                   //COBOL==> ELSE
                else
                {
                    WS.Y2K_CENTRY_CC.SetValue(WS.CENTURY_19);                                                           //COBOL==> MOVE CENTURY-19 TO Y2K-CENTRY-CC
                }                                                                                                   //COBOL==> END-IF
            }                                                                                                   //COBOL==> END-IF
            WS.Y2K_MMYY_IN.ResetToInitialValue();                                                               //COBOL==> INITIALIZE Y2K-MMYY-IN .
            if (returnMethod != "" && returnMethod != "M_Z940_MMYY_ROUTINE") { M_Z940_MMYY_ROUTINE_EXIT(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_Z940_MMYY_ROUTINE_EXIT
        /// </summary>
        private void M_Z940_MMYY_ROUTINE_EXIT(string returnMethod = "")
        {
            if (returnMethod == "M_Z940_MMYY_ROUTINE_EXIT") { return; }                                         //COBOL==> EXIT.
        }
        #endregion
    }
    #endregion
}
