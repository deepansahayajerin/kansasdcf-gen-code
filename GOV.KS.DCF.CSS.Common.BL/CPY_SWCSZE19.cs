// ***************************************************************
// **   ATERAS INC.  COPYRIGHT 2000-2022
// **   DB-SHUTTLE COBOL Copybook to C# Conversion
// ***************************************************************
// ** MOD ID * DESC                   *   DATE
// ***************************************************************
// ** INIT   *  INITIAL VERSION       *  2022-01-14 12:45:54 PM
// **        *   FROM COBOL COPYBOOK  :  SWCSZE19
// **        *   FROM CANISTER        :  SR.CAECSES.PROD.LIBR.SOURCE.PDS
// **        *   SOURCE TYPE          :  COBOL COPYBOOK
// ***************************************************************
// ***************************************************************
using MDSY.Framework.Buffer;
using MDSY.Framework.Buffer.BaseClasses;
using MDSY.Framework.Buffer.Common;
using MDSY.Framework.Buffer.Interfaces;

namespace GOV.KS.DCF.CSS.Common.BL
{
    public class CPY_SWCSZE19 : PredefinedRecordBase
    {
        #region Name constants
        /// <summary>
        /// Name constants.
        /// </summary>
        internal static class Names
        {
            internal const string CPY_SWCSZE19 = "CPY_SWCSZE19";
            internal const string EXTFILE_STAT = "EXTFILE_STAT";
            internal const string WS_MISC = "WS_MISC";
            internal const string WS_ENTRY = "WS_ENTRY";
            internal const string WS_RECORD_COUNT = "WS_RECORD_COUNT";
            internal const string WS_EXTERNAL_FPLS_REQUEST = "WS_EXTERNAL_FPLS_REQUEST";
            internal const string SPACES_1_0002 = "SPACES_1_0002";
            internal const string STATE_ABBR_0002 = "STATE_ABBR_0002";
            internal const string STATION_NUMBER_0002 = "STATION_NUMBER_0002";
            internal const string SPACES_2_0002 = "SPACES_2_0002";
            internal const string TRANSACTION_TYPE_0002 = "TRANSACTION_TYPE_0002";
            internal const string SSN_0002 = "SSN_0002";
            internal const string AP_CSE_PERSON_NUMBER_0002 = "AP_CSE_PERSON_NUMBER_0002";
            internal const string FPLS_LOCATE_REQUEST_IDENT_0003 = "FPLS_LOCATE_REQUEST_IDENT_0003";
            internal const string LOCAL_CODE_0003 = "LOCAL_CODE_0003";
            internal const string USERS_FIELD_0003 = "USERS_FIELD_0003";
            internal const string TYPE_OF_CASE_0003 = "TYPE_OF_CASE_0003";
            internal const string AP_FIRST_NAME_0003 = "AP_FIRST_NAME_0003";
            internal const string AP_MIDDLE_NAME_0003 = "AP_MIDDLE_NAME_0003";
            internal const string AP_FIRST_LAST_NAME_0003 = "AP_FIRST_LAST_NAME_0003";
            internal const string AP_SECOND_LAST_NAME_0003 = "AP_SECOND_LAST_NAME_0003";
            internal const string AP_THIRD_LAST_NAME_0003 = "AP_THIRD_LAST_NAME_0003";
            internal const string AP_DATE_OF_BIRTH_MONTH_0003 = "AP_DATE_OF_BIRTH_MONTH_0003";
            internal const string AP_DATE_OF_BIRTH_DAY_0003 = "AP_DATE_OF_BIRTH_DAY_0003";
            internal const string AP_DATE_OF_BIRTH_YEAR_0003 = "AP_DATE_OF_BIRTH_YEAR_0003";
            internal const string SEX_0003 = "SEX_0003";
            internal const string COLLECT_ALL_RESPONSES_TOG_0004 = "COLLECT_ALL_RESPONSES_TOG_0004";
            internal const string SPACES_3_0004 = "SPACES_3_0004";
            internal const string SEND_REQUEST_TO_0004 = "SEND_REQUEST_TO_0004";
            internal const string TRANSACTION_ERROR_0004 = "TRANSACTION_ERROR_0004";
            internal const string SPACES_4_0004 = "SPACES_4_0004";
            internal const string AP_CITY_OF_BIRTH_0004 = "AP_CITY_OF_BIRTH_0004";
            internal const string AP_STATE_OR_COUNTRY_OF_BI_0005 = "AP_STATE_OR_COUNTRY_OF_BI_0005";
            internal const string APS_FATHERS_FIRST_NAME_0005 = "APS_FATHERS_FIRST_NAME_0005";
            internal const string APS_FATHERS_MI_0005 = "APS_FATHERS_MI_0005";
            internal const string APS_FATHERS_LAST_NAME_0005 = "APS_FATHERS_LAST_NAME_0005";
            internal const string APS_MOTHERS_FIRST_NAME_0005 = "APS_MOTHERS_FIRST_NAME_0005";
            internal const string APS_MOTHERS_MI_0005 = "APS_MOTHERS_MI_0005";
            internal const string APS_MOTHERS_MAIDEN_NAME_0006 = "APS_MOTHERS_MAIDEN_NAME_0006";
            internal const string CP_SSN_0006 = "CP_SSN_0006";
        }
        #endregion

        #region Direct-access element properties
        public IField EXTFILE_STAT { get { return GetExternalElementByName<IField>(Names.EXTFILE_STAT); } }
        public IGroup WS_MISC { get { return GetElementByName<IGroup>(Names.WS_MISC); } }
        public IField WS_ENTRY { get { return GetElementByName<IField>(Names.WS_ENTRY); } }
        public IField WS_RECORD_COUNT { get { return GetElementByName<IField>(Names.WS_RECORD_COUNT); } }
        public IGroup WS_EXTERNAL_FPLS_REQUEST { get { return GetElementByName<IGroup>(Names.WS_EXTERNAL_FPLS_REQUEST); } }
        public IField SPACES_1_0002 { get { return GetElementByName<IField>(Names.SPACES_1_0002); } }
        public IField STATE_ABBR_0002 { get { return GetElementByName<IField>(Names.STATE_ABBR_0002); } }
        public IField STATION_NUMBER_0002 { get { return GetElementByName<IField>(Names.STATION_NUMBER_0002); } }
        public IField SPACES_2_0002 { get { return GetElementByName<IField>(Names.SPACES_2_0002); } }
        public IField TRANSACTION_TYPE_0002 { get { return GetElementByName<IField>(Names.TRANSACTION_TYPE_0002); } }
        public IField SSN_0002 { get { return GetElementByName<IField>(Names.SSN_0002); } }
        public IField AP_CSE_PERSON_NUMBER_0002 { get { return GetElementByName<IField>(Names.AP_CSE_PERSON_NUMBER_0002); } }
        public IField FPLS_LOCATE_REQUEST_IDENT_0003 { get { return GetElementByName<IField>(Names.FPLS_LOCATE_REQUEST_IDENT_0003); } }
        public IField LOCAL_CODE_0003 { get { return GetElementByName<IField>(Names.LOCAL_CODE_0003); } }
        public IField USERS_FIELD_0003 { get { return GetElementByName<IField>(Names.USERS_FIELD_0003); } }
        public IField TYPE_OF_CASE_0003 { get { return GetElementByName<IField>(Names.TYPE_OF_CASE_0003); } }
        public IField AP_FIRST_NAME_0003 { get { return GetElementByName<IField>(Names.AP_FIRST_NAME_0003); } }
        public IField AP_MIDDLE_NAME_0003 { get { return GetElementByName<IField>(Names.AP_MIDDLE_NAME_0003); } }
        public IField AP_FIRST_LAST_NAME_0003 { get { return GetElementByName<IField>(Names.AP_FIRST_LAST_NAME_0003); } }
        public IField AP_SECOND_LAST_NAME_0003 { get { return GetElementByName<IField>(Names.AP_SECOND_LAST_NAME_0003); } }
        public IField AP_THIRD_LAST_NAME_0003 { get { return GetElementByName<IField>(Names.AP_THIRD_LAST_NAME_0003); } }
        public IField AP_DATE_OF_BIRTH_MONTH_0003 { get { return GetElementByName<IField>(Names.AP_DATE_OF_BIRTH_MONTH_0003); } }
        public IField AP_DATE_OF_BIRTH_DAY_0003 { get { return GetElementByName<IField>(Names.AP_DATE_OF_BIRTH_DAY_0003); } }
        public IField AP_DATE_OF_BIRTH_YEAR_0003 { get { return GetElementByName<IField>(Names.AP_DATE_OF_BIRTH_YEAR_0003); } }
        public IField SEX_0003 { get { return GetElementByName<IField>(Names.SEX_0003); } }
        public IField COLLECT_ALL_RESPONSES_TOG_0004 { get { return GetElementByName<IField>(Names.COLLECT_ALL_RESPONSES_TOG_0004); } }
        public IField SPACES_3_0004 { get { return GetElementByName<IField>(Names.SPACES_3_0004); } }
        public IField SEND_REQUEST_TO_0004 { get { return GetElementByName<IField>(Names.SEND_REQUEST_TO_0004); } }
        public IField TRANSACTION_ERROR_0004 { get { return GetElementByName<IField>(Names.TRANSACTION_ERROR_0004); } }
        public IField SPACES_4_0004 { get { return GetElementByName<IField>(Names.SPACES_4_0004); } }
        public IField AP_CITY_OF_BIRTH_0004 { get { return GetElementByName<IField>(Names.AP_CITY_OF_BIRTH_0004); } }
        public IField AP_STATE_OR_COUNTRY_OF_BI_0005 { get { return GetElementByName<IField>(Names.AP_STATE_OR_COUNTRY_OF_BI_0005); } }
        public IField APS_FATHERS_FIRST_NAME_0005 { get { return GetElementByName<IField>(Names.APS_FATHERS_FIRST_NAME_0005); } }
        public IField APS_FATHERS_MI_0005 { get { return GetElementByName<IField>(Names.APS_FATHERS_MI_0005); } }
        public IField APS_FATHERS_LAST_NAME_0005 { get { return GetElementByName<IField>(Names.APS_FATHERS_LAST_NAME_0005); } }
        public IField APS_MOTHERS_FIRST_NAME_0005 { get { return GetElementByName<IField>(Names.APS_MOTHERS_FIRST_NAME_0005); } }
        public IField APS_MOTHERS_MI_0005 { get { return GetElementByName<IField>(Names.APS_MOTHERS_MI_0005); } }
        public IField APS_MOTHERS_MAIDEN_NAME_0006 { get { return GetElementByName<IField>(Names.APS_MOTHERS_MAIDEN_NAME_0006); } }
        public IField CP_SSN_0006 { get { return GetElementByName<IField>(Names.CP_SSN_0006); } }

        #endregion

        #region Data structure definition
        /// <summary>
        /// Defines the entirety of the CPY_SWCSZE19 IRecord structure as described by the Ateras.Framework.Buffer API.
        /// </summary>
        /// <param name="recordDef">The IStructureDefinition object to be used in defining the record structure.</param>
        protected override void DefineRecordStructure(IStructureDefinition recordDef)
        {
            WsExternals.Instance.CreateNewField(Names.EXTFILE_STAT, FieldType.UnsignedNumeric, 2);

            recordDef.CreateNewGroup(Names.WS_MISC, (WS_MISC) =>
           {
               WS_MISC.CreateNewField(Names.WS_ENTRY, FieldType.String, 40, "SWEXEE04 WORKING STORAGE STARTS HERE");
               WS_MISC.CreateNewField(Names.WS_RECORD_COUNT, FieldType.UnsignedNumeric, 7, ZEROES);
           });

            recordDef.CreateNewGroup(Names.WS_EXTERNAL_FPLS_REQUEST, (WS_EXTERNAL_FPLS_REQUEST) =>
           {
               WS_EXTERNAL_FPLS_REQUEST.CreateNewField(Names.SPACES_1_0002, FieldType.String, 16);
               WS_EXTERNAL_FPLS_REQUEST.CreateNewField(Names.STATE_ABBR_0002, FieldType.String, 2);
               WS_EXTERNAL_FPLS_REQUEST.CreateNewField(Names.STATION_NUMBER_0002, FieldType.String, 2);
               WS_EXTERNAL_FPLS_REQUEST.CreateNewField(Names.SPACES_2_0002, FieldType.String, 10);
               WS_EXTERNAL_FPLS_REQUEST.CreateNewField(Names.TRANSACTION_TYPE_0002, FieldType.String, 1);
               WS_EXTERNAL_FPLS_REQUEST.CreateNewField(Names.SSN_0002, FieldType.String, 9);
               WS_EXTERNAL_FPLS_REQUEST.CreateNewField(Names.AP_CSE_PERSON_NUMBER_0002, FieldType.String, 10);
               WS_EXTERNAL_FPLS_REQUEST.CreateNewField(Names.FPLS_LOCATE_REQUEST_IDENT_0003, FieldType.UnsignedNumeric, 5);
               WS_EXTERNAL_FPLS_REQUEST.CreateNewField(Names.LOCAL_CODE_0003, FieldType.String, 3);
               WS_EXTERNAL_FPLS_REQUEST.CreateNewField(Names.USERS_FIELD_0003, FieldType.String, 7);
               WS_EXTERNAL_FPLS_REQUEST.CreateNewField(Names.TYPE_OF_CASE_0003, FieldType.String, 1);
               WS_EXTERNAL_FPLS_REQUEST.CreateNewField(Names.AP_FIRST_NAME_0003, FieldType.String, 16);
               WS_EXTERNAL_FPLS_REQUEST.CreateNewField(Names.AP_MIDDLE_NAME_0003, FieldType.String, 16);
               WS_EXTERNAL_FPLS_REQUEST.CreateNewField(Names.AP_FIRST_LAST_NAME_0003, FieldType.String, 20);
               WS_EXTERNAL_FPLS_REQUEST.CreateNewField(Names.AP_SECOND_LAST_NAME_0003, FieldType.String, 20);
               WS_EXTERNAL_FPLS_REQUEST.CreateNewField(Names.AP_THIRD_LAST_NAME_0003, FieldType.String, 20);
               WS_EXTERNAL_FPLS_REQUEST.CreateNewField(Names.AP_DATE_OF_BIRTH_MONTH_0003, FieldType.UnsignedNumeric, 2);
               WS_EXTERNAL_FPLS_REQUEST.CreateNewField(Names.AP_DATE_OF_BIRTH_DAY_0003, FieldType.UnsignedNumeric, 2);
               WS_EXTERNAL_FPLS_REQUEST.CreateNewField(Names.AP_DATE_OF_BIRTH_YEAR_0003, FieldType.UnsignedNumeric, 2);
               WS_EXTERNAL_FPLS_REQUEST.CreateNewField(Names.SEX_0003, FieldType.String, 1);
               WS_EXTERNAL_FPLS_REQUEST.CreateNewField(Names.COLLECT_ALL_RESPONSES_TOG_0004, FieldType.String, 1);
               WS_EXTERNAL_FPLS_REQUEST.CreateNewField(Names.SPACES_3_0004, FieldType.String, 12);
               WS_EXTERNAL_FPLS_REQUEST.CreateNewField(Names.SEND_REQUEST_TO_0004, FieldType.String, 45);
               WS_EXTERNAL_FPLS_REQUEST.CreateNewField(Names.TRANSACTION_ERROR_0004, FieldType.String, 10);
               WS_EXTERNAL_FPLS_REQUEST.CreateNewField(Names.SPACES_4_0004, FieldType.String, 14);
               WS_EXTERNAL_FPLS_REQUEST.CreateNewField(Names.AP_CITY_OF_BIRTH_0004, FieldType.String, 16);
               WS_EXTERNAL_FPLS_REQUEST.CreateNewField(Names.AP_STATE_OR_COUNTRY_OF_BI_0005, FieldType.String, 3);
               WS_EXTERNAL_FPLS_REQUEST.CreateNewField(Names.APS_FATHERS_FIRST_NAME_0005, FieldType.String, 13);
               WS_EXTERNAL_FPLS_REQUEST.CreateNewField(Names.APS_FATHERS_MI_0005, FieldType.String, 1);
               WS_EXTERNAL_FPLS_REQUEST.CreateNewField(Names.APS_FATHERS_LAST_NAME_0005, FieldType.String, 16);
               WS_EXTERNAL_FPLS_REQUEST.CreateNewField(Names.APS_MOTHERS_FIRST_NAME_0005, FieldType.String, 13);
               WS_EXTERNAL_FPLS_REQUEST.CreateNewField(Names.APS_MOTHERS_MI_0005, FieldType.String, 1);
               WS_EXTERNAL_FPLS_REQUEST.CreateNewField(Names.APS_MOTHERS_MAIDEN_NAME_0006, FieldType.String, 16);
               WS_EXTERNAL_FPLS_REQUEST.CreateNewField(Names.CP_SSN_0006, FieldType.String, 9);
           });

        }

        protected override string GetRecordName()
        {
            return Names.CPY_SWCSZE19;
        }
        #endregion


        #region Public Constructors

        public CPY_SWCSZE19(IRecord recordBuffer, bool isNewCopy)
            : base()
        {
            if (isNewCopy || recordBuffer.AsBytes() == null)
                this.Record.ResetToInitialValue();
            else
                this.Record.AssignFrom(recordBuffer.AsBytes());
        }
        public CPY_SWCSZE19()
            : base()
        {

            this.Record.ResetToInitialValue();
        }
        #endregion
    }

}
