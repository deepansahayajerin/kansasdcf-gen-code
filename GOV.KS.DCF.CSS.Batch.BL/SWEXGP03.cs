#region Comments
/* Conversion Comments
   ************************************************************
   **   MODERN SYSTEMS INC.  COPYRIGHT 2000-2022
   **   DB-SHUTTLE COBOL to C# Conversion
   ************************************************************
   ** INIT   *  INITIAL VERSION   *  2022-03-02 04:48:27 PM
   **        *   FROM COBOL PGM   :  SWEXGP03
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
using GOV.KS.DCF.CSS.Common.BL;
#endregion

namespace GOV.KS.DCF.CSS.Batch.BL
{
    #region File Section Class
    internal class SWEXGP03_fd : PredefinedRecordBase
    {
        #region Name constants
        /// <summary>
        /// Name constants.
        /// </summary>
        internal static class Names
        {
            internal const string FileSection = "SWEXGP03_fd_FileSection";
            internal const string REPTOUT = "REPTOUT";
            internal const string HEADINGS = "HEADINGS";
            internal const string DETAILS = "DETAILS";
        }
        #endregion

        #region Direct-access element properties
        public IFileLink REPTOUT { get; set; }
        public IField HEADINGS { get { return GetElementByName<IField>(Names.HEADINGS); } }
        public IField DETAILS { get { return GetElementByName<IField>(Names.DETAILS); } }

        #endregion

        #region Data structure definition
        /// <summary>
        /// Defines the entirety of the FileSection IRecord structure as described by the Ateras.Framework.Buffer API.
        /// </summary>
        /// <param name="recordDef">The IStructureDefinition object to be used in defining the record structure.</param>
        protected override void DefineRecordStructure(IStructureDefinition recordDef)
        {
            recordDef.CreateNewField(Names.HEADINGS, FieldType.String, 133);
            recordDef.CreateNewField(Names.DETAILS, FieldType.String, 133);

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

            REPTOUT = FileHandler.GetFile("UT_S_RPT03");
            REPTOUT.AssociatedBuffer = HEADINGS;
            REPTOUT.RecordLength = 133;
        }
        #endregion

        #region Constructors
        public SWEXGP03_fd()
            : base()
        {
            Initialize();

        }
        #endregion
    }
    #endregion File Section Class
    #region Working Storage Class
    internal class SWEXGP03_ws : PredefinedRecordBase
    {
        #region Name constants
        /// <summary>
        /// Name constants.
        /// </summary>
        internal static class Names
        {
            internal const string WorkingStorage = "SWEXGP03_ws_WorkingStorage";
            internal const string WS_PAGE_NO = "WS_PAGE_NO";
            internal const string WS_LINES_PER_PAGE = "WS_LINES_PER_PAGE";
            internal const string WS_LINE_COUNT = "WS_LINE_COUNT";
            internal const string WS_LINES_REMAIN = "WS_LINES_REMAIN";
            internal const string WS_POSITION = "WS_POSITION";
            internal const string RETURN_HEADING1 = "RETURN_HEADING1";
            internal const string RETURN_HEADING2 = "RETURN_HEADING2";
            internal const string RETURN_HEADING3 = "RETURN_HEADING3";
            internal const string WS_BLANK_LINE = "WS_BLANK_LINE";
            internal const string WS_DETAIL_LINE = "WS_DETAIL_LINE";
            internal const string WS_DETAIL_CC = "WS_DETAIL_CC";
            internal const string WS_DETAIL_BODY = "WS_DETAIL_BODY";
        }
        #endregion

        #region Direct-access element properties
        public IField WS_PAGE_NO { get { return GetElementByName<IField>(Names.WS_PAGE_NO); } }
        public IField WS_LINES_PER_PAGE { get { return GetElementByName<IField>(Names.WS_LINES_PER_PAGE); } }
        public IField WS_LINE_COUNT { get { return GetElementByName<IField>(Names.WS_LINE_COUNT); } }
        public IField WS_LINES_REMAIN { get { return GetElementByName<IField>(Names.WS_LINES_REMAIN); } }
        public IField WS_POSITION { get { return GetElementByName<IField>(Names.WS_POSITION); } }
        public IField RETURN_HEADING1 { get { return GetElementByName<IField>(Names.RETURN_HEADING1); } }
        public IField RETURN_HEADING2 { get { return GetElementByName<IField>(Names.RETURN_HEADING2); } }
        public IField RETURN_HEADING3 { get { return GetElementByName<IField>(Names.RETURN_HEADING3); } }
        public IField WS_BLANK_LINE { get { return GetElementByName<IField>(Names.WS_BLANK_LINE); } }
        public IGroup WS_DETAIL_LINE { get { return GetElementByName<IGroup>(Names.WS_DETAIL_LINE); } }
        public IField WS_DETAIL_CC { get { return GetElementByName<IField>(Names.WS_DETAIL_CC); } }
        public IField WS_DETAIL_BODY { get { return GetElementByName<IField>(Names.WS_DETAIL_BODY); } }

        #endregion

        #region Data structure definition
        /// <summary>
        /// Defines the entirety of the WorkingStorage IRecord structure as described by the Ateras.Framework.Buffer API.
        /// </summary>
        /// <param name="recordDef">The IStructureDefinition object to be used in defining the record structure.</param>
        protected override void DefineRecordStructure(IStructureDefinition recordDef)
        {
            recordDef.CreateNewField(Names.WS_PAGE_NO, FieldType.SignedNumeric, 9, +0);
            recordDef.CreateNewField(Names.WS_LINES_PER_PAGE, FieldType.SignedNumeric, 2, +55);
            recordDef.CreateNewField(Names.WS_LINE_COUNT, FieldType.SignedNumeric, 2, +0);
            recordDef.CreateNewField(Names.WS_LINES_REMAIN, FieldType.SignedNumeric, 2, +0);
            recordDef.CreateNewField(Names.WS_POSITION, FieldType.SignedNumeric, 1, +0);
            recordDef.CreateNewField(Names.RETURN_HEADING1, FieldType.String, 133);
            recordDef.CreateNewField(Names.RETURN_HEADING2, FieldType.String, 133);
            recordDef.CreateNewField(Names.RETURN_HEADING3, FieldType.String, 133);
            recordDef.CreateNewField(Names.WS_BLANK_LINE, FieldType.String, 133, SPACES);

            recordDef.CreateNewGroup(Names.WS_DETAIL_LINE, (WS_DETAIL_LINE) =>
           {
               WS_DETAIL_LINE.CreateNewField(Names.WS_DETAIL_CC, FieldType.String, 1, SPACES);
               WS_DETAIL_LINE.CreateNewField(Names.WS_DETAIL_BODY, FieldType.String, 132, SPACES);
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
    internal class SWEXGP03_ls : PredefinedRecordBase
    {
        #region Name constants
        /// <summary>
        /// Name constants.
        /// </summary>
        internal static class Names
        {
            internal const string LinkageSection = "SWEXGP03_ls_LinkageSection";
            internal const string W_IA = "W_IA";
            internal const string IMPORT_0001EV = "IMPORT_0001EV";
            internal const string BB_FILE_0001ET = "BB_FILE_0001ET";
            internal const string ACTION_0001MS = "ACTION_0001MS";
            internal const string ACTION_0001 = "ACTION_0001";
            internal const string ACTION_0001XX = "ACTION_0001XX";
            internal const string W_IB = "W_IB";
            internal const string IMPORT_0002EV = "IMPORT_0002EV";
            internal const string CL_EAB_REPORT_SEND_0002ET = "CL_EAB_REPORT_SEND_0002ET";
            internal const string REPORT_NUMBER_0002MS = "REPORT_NUMBER_0002MS";
            internal const string REPORT_NUMBER_0002 = "REPORT_NUMBER_0002";
            internal const string REPORT_NUMBER_0002XX = "REPORT_NUMBER_0002XX";
            internal const string COMMAND_0002MS = "COMMAND_0002MS";
            internal const string COMMAND_0002 = "COMMAND_0002";
            internal const string COMMAND_0002XX = "COMMAND_0002XX";
            internal const string BLANK_LINE_AFTER_HEADIN_0003MS = "BLANK_LINE_AFTER_HEADIN_0003MS";
            internal const string BLANK_LINE_AFTER_HEADING_0003 = "BLANK_LINE_AFTER_HEADING_0003";
            internal const string BLANK_LINE_AFTER_HEADIN_0003XX = "BLANK_LINE_AFTER_HEADIN_0003XX";
            internal const string BLANK_LINE_AFTER_COL_HE_0004MS = "BLANK_LINE_AFTER_COL_HE_0004MS";
            internal const string BLANK_LINE_AFTER_COL_HEAD_0004 = "BLANK_LINE_AFTER_COL_HEAD_0004";
            internal const string BLANK_LINE_AFTER_COL_HE_0004XX = "BLANK_LINE_AFTER_COL_HE_0004XX";
            internal const string BLANK_LINE_BEFORE_FOOTE_0005MS = "BLANK_LINE_BEFORE_FOOTE_0005MS";
            internal const string BLANK_LINE_BEFORE_FOOTERS_0005 = "BLANK_LINE_BEFORE_FOOTERS_0005";
            internal const string BLANK_LINE_BEFORE_FOOTE_0005XX = "BLANK_LINE_BEFORE_FOOTE_0005XX";
            internal const string NUMBER_OF_COL_HEADINGS_0005MS = "NUMBER_OF_COL_HEADINGS_0005MS";
            internal const string NUMBER_OF_COL_HEADINGS_0005 = "NUMBER_OF_COL_HEADINGS_0005";
            internal const string NUMBER_OF_COL_HEADINGS_0005XX = "NUMBER_OF_COL_HEADINGS_0005XX";
            internal const string NUMBER_OF_FOOTERS_0005MS = "NUMBER_OF_FOOTERS_0005MS";
            internal const string NUMBER_OF_FOOTERS_0005 = "NUMBER_OF_FOOTERS_0005";
            internal const string NUMBER_OF_FOOTERS_0005XX = "NUMBER_OF_FOOTERS_0005XX";
            internal const string OVERRIDE_PAGE_NO_0005MS = "OVERRIDE_PAGE_NO_0005MS";
            internal const string OVERRIDE_PAGE_NO_0005 = "OVERRIDE_PAGE_NO_0005";
            internal const string OVERRIDE_PAGE_NO_0005XX = "OVERRIDE_PAGE_NO_0005XX";
            internal const string OVERRIDE_LINES_PER_PAGE_0006MS = "OVERRIDE_LINES_PER_PAGE_0006MS";
            internal const string OVERRIDE_LINES_PER_PAGE_0006 = "OVERRIDE_LINES_PER_PAGE_0006";
            internal const string OVERRIDE_LINES_PER_PAGE_0006XX = "OVERRIDE_LINES_PER_PAGE_0006XX";
            internal const string OVERRIDE_CARRIAGE_CONTR_0007MS = "OVERRIDE_CARRIAGE_CONTR_0007MS";
            internal const string OVERRIDE_CARRIAGE_CONTROL_0007 = "OVERRIDE_CARRIAGE_CONTROL_0007";
            internal const string OVERRIDE_CARRIAGE_CONTR_0007XX = "OVERRIDE_CARRIAGE_CONTR_0007XX";
            internal const string PERIOD_ENDING_DATE_0007MS = "PERIOD_ENDING_DATE_0007MS";
            internal const string PERIOD_ENDING_DATE_0007 = "PERIOD_ENDING_DATE_0007";
            internal const string PERIOD_ENDING_DATE_0007XX = "PERIOD_ENDING_DATE_0007XX";
            internal const string REPORT_NO_PART1_0007MS = "REPORT_NO_PART1_0007MS";
            internal const string REPORT_NO_PART1_0007 = "REPORT_NO_PART1_0007";
            internal const string REPORT_NO_PART1_0007XX = "REPORT_NO_PART1_0007XX";
            internal const string REPORT_NO_PART2_0007MS = "REPORT_NO_PART2_0007MS";
            internal const string REPORT_NO_PART2_0007 = "REPORT_NO_PART2_0007";
            internal const string REPORT_NO_PART2_0007XX = "REPORT_NO_PART2_0007XX";
            internal const string RUN_DATE_0007MS = "RUN_DATE_0007MS";
            internal const string RUN_DATE_0007 = "RUN_DATE_0007";
            internal const string RUN_DATE_0007XX = "RUN_DATE_0007XX";
            internal const string RUN_TIME_0007MS = "RUN_TIME_0007MS";
            internal const string RUN_TIME_0007 = "RUN_TIME_0007";
            internal const string RUN_TIME_0007XX = "RUN_TIME_0007XX";
            internal const string RPT_HEADING_1_0007MS = "RPT_HEADING_1_0007MS";
            internal const string RPT_HEADING_1_0007 = "RPT_HEADING_1_0007";
            internal const string RPT_HEADING_1_0007XX = "RPT_HEADING_1_0007XX";
            internal const string RPT_HEADING_2_0007MS = "RPT_HEADING_2_0007MS";
            internal const string RPT_HEADING_2_0007 = "RPT_HEADING_2_0007";
            internal const string RPT_HEADING_2_0007XX = "RPT_HEADING_2_0007XX";
            internal const string RPT_HEADING_3_0007MS = "RPT_HEADING_3_0007MS";
            internal const string RPT_HEADING_3_0007 = "RPT_HEADING_3_0007";
            internal const string RPT_HEADING_3_0007XX = "RPT_HEADING_3_0007XX";
            internal const string COL_HEADING_1_0007MS = "COL_HEADING_1_0007MS";
            internal const string COL_HEADING_1_0007 = "COL_HEADING_1_0007";
            internal const string COL_HEADING_1_0007XX = "COL_HEADING_1_0007XX";
            internal const string COL_HEADING_2_0007MS = "COL_HEADING_2_0007MS";
            internal const string COL_HEADING_2_0007 = "COL_HEADING_2_0007";
            internal const string COL_HEADING_2_0007XX = "COL_HEADING_2_0007XX";
            internal const string COL_HEADING_3_0007MS = "COL_HEADING_3_0007MS";
            internal const string COL_HEADING_3_0007 = "COL_HEADING_3_0007";
            internal const string COL_HEADING_3_0007XX = "COL_HEADING_3_0007XX";
            internal const string RPT_DETAIL_0007MS = "RPT_DETAIL_0007MS";
            internal const string RPT_DETAIL_0007 = "RPT_DETAIL_0007";
            internal const string RPT_DETAIL_0007XX = "RPT_DETAIL_0007XX";
            internal const string RPT_FOOTER_1_0007MS = "RPT_FOOTER_1_0007MS";
            internal const string RPT_FOOTER_1_0007 = "RPT_FOOTER_1_0007";
            internal const string RPT_FOOTER_1_0007XX = "RPT_FOOTER_1_0007XX";
            internal const string RPT_FOOTER_2_0007MS = "RPT_FOOTER_2_0007MS";
            internal const string RPT_FOOTER_2_0007 = "RPT_FOOTER_2_0007";
            internal const string RPT_FOOTER_2_0007XX = "RPT_FOOTER_2_0007XX";
            internal const string RPT_FOOTER_3_0007MS = "RPT_FOOTER_3_0007MS";
            internal const string RPT_FOOTER_3_0007 = "RPT_FOOTER_3_0007";
            internal const string RPT_FOOTER_3_0007XX = "RPT_FOOTER_3_0007XX";
            internal const string W_OA = "W_OA";
            internal const string EXPORT_0008EV = "EXPORT_0008EV";
            internal const string CL_EAB_REPORT_RETURN_0008ET = "CL_EAB_REPORT_RETURN_0008ET";
            internal const string PAGE_NUMBER_0008MS = "PAGE_NUMBER_0008MS";
            internal const string PAGE_NUMBER_0008 = "PAGE_NUMBER_0008";
            internal const string PAGE_NUMBER_0008XX = "PAGE_NUMBER_0008XX";
            internal const string LINE_NUMBER_0008MS = "LINE_NUMBER_0008MS";
            internal const string LINE_NUMBER_0008 = "LINE_NUMBER_0008";
            internal const string LINE_NUMBER_0008XX = "LINE_NUMBER_0008XX";
            internal const string LINES_REMAINING_0008MS = "LINES_REMAINING_0008MS";
            internal const string LINES_REMAINING_0008 = "LINES_REMAINING_0008";
            internal const string LINES_REMAINING_0008XX = "LINES_REMAINING_0008XX";
            internal const string W_OB = "W_OB";
            internal const string EXPORT_0009EV = "EXPORT_0009EV";
            internal const string BB_FILE_0009ET = "BB_FILE_0009ET";
            internal const string STATUS_0009MS = "STATUS_0009MS";
            internal const string STATUS_0009 = "STATUS_0009";
            internal const string STATUS_0009XX = "STATUS_0009XX";
        }
        #endregion

        #region Direct-access element properties
        public IGroup W_IA { get { return GetElementByName<IGroup>(Names.W_IA); } }
        public IGroup IMPORT_0001EV { get { return GetElementByName<IGroup>(Names.IMPORT_0001EV); } }
        public IGroup BB_FILE_0001ET { get { return GetElementByName<IGroup>(Names.BB_FILE_0001ET); } }
        public IField ACTION_0001MS { get { return GetElementByName<IField>(Names.ACTION_0001MS); } }
        public IField ACTION_0001 { get { return GetElementByName<IField>(Names.ACTION_0001); } }
        public IField ACTION_0001XX { get { return GetElementByName<IField>(Names.ACTION_0001XX); } }
        public IGroup W_IB { get { return GetElementByName<IGroup>(Names.W_IB); } }
        public IGroup IMPORT_0002EV { get { return GetElementByName<IGroup>(Names.IMPORT_0002EV); } }
        public IGroup CL_EAB_REPORT_SEND_0002ET { get { return GetElementByName<IGroup>(Names.CL_EAB_REPORT_SEND_0002ET); } }
        public IField REPORT_NUMBER_0002MS { get { return GetElementByName<IField>(Names.REPORT_NUMBER_0002MS); } }
        public IField REPORT_NUMBER_0002 { get { return GetElementByName<IField>(Names.REPORT_NUMBER_0002); } }
        public IField REPORT_NUMBER_0002XX { get { return GetElementByName<IField>(Names.REPORT_NUMBER_0002XX); } }
        public IField COMMAND_0002MS { get { return GetElementByName<IField>(Names.COMMAND_0002MS); } }
        public IField COMMAND_0002 { get { return GetElementByName<IField>(Names.COMMAND_0002); } }
        public IField COMMAND_0002XX { get { return GetElementByName<IField>(Names.COMMAND_0002XX); } }
        public IField BLANK_LINE_AFTER_HEADIN_0003MS { get { return GetElementByName<IField>(Names.BLANK_LINE_AFTER_HEADIN_0003MS); } }
        public IField BLANK_LINE_AFTER_HEADING_0003 { get { return GetElementByName<IField>(Names.BLANK_LINE_AFTER_HEADING_0003); } }
        public IField BLANK_LINE_AFTER_HEADIN_0003XX { get { return GetElementByName<IField>(Names.BLANK_LINE_AFTER_HEADIN_0003XX); } }
        public IField BLANK_LINE_AFTER_COL_HE_0004MS { get { return GetElementByName<IField>(Names.BLANK_LINE_AFTER_COL_HE_0004MS); } }
        public IField BLANK_LINE_AFTER_COL_HEAD_0004 { get { return GetElementByName<IField>(Names.BLANK_LINE_AFTER_COL_HEAD_0004); } }
        public IField BLANK_LINE_AFTER_COL_HE_0004XX { get { return GetElementByName<IField>(Names.BLANK_LINE_AFTER_COL_HE_0004XX); } }
        public IField BLANK_LINE_BEFORE_FOOTE_0005MS { get { return GetElementByName<IField>(Names.BLANK_LINE_BEFORE_FOOTE_0005MS); } }
        public IField BLANK_LINE_BEFORE_FOOTERS_0005 { get { return GetElementByName<IField>(Names.BLANK_LINE_BEFORE_FOOTERS_0005); } }
        public IField BLANK_LINE_BEFORE_FOOTE_0005XX { get { return GetElementByName<IField>(Names.BLANK_LINE_BEFORE_FOOTE_0005XX); } }
        public IField NUMBER_OF_COL_HEADINGS_0005MS { get { return GetElementByName<IField>(Names.NUMBER_OF_COL_HEADINGS_0005MS); } }
        public IField NUMBER_OF_COL_HEADINGS_0005 { get { return GetElementByName<IField>(Names.NUMBER_OF_COL_HEADINGS_0005); } }
        public IField NUMBER_OF_COL_HEADINGS_0005XX { get { return GetElementByName<IField>(Names.NUMBER_OF_COL_HEADINGS_0005XX); } }
        public IField NUMBER_OF_FOOTERS_0005MS { get { return GetElementByName<IField>(Names.NUMBER_OF_FOOTERS_0005MS); } }
        public IField NUMBER_OF_FOOTERS_0005 { get { return GetElementByName<IField>(Names.NUMBER_OF_FOOTERS_0005); } }
        public IField NUMBER_OF_FOOTERS_0005XX { get { return GetElementByName<IField>(Names.NUMBER_OF_FOOTERS_0005XX); } }
        public IField OVERRIDE_PAGE_NO_0005MS { get { return GetElementByName<IField>(Names.OVERRIDE_PAGE_NO_0005MS); } }
        public IField OVERRIDE_PAGE_NO_0005 { get { return GetElementByName<IField>(Names.OVERRIDE_PAGE_NO_0005); } }
        public IField OVERRIDE_PAGE_NO_0005XX { get { return GetElementByName<IField>(Names.OVERRIDE_PAGE_NO_0005XX); } }
        public IField OVERRIDE_LINES_PER_PAGE_0006MS { get { return GetElementByName<IField>(Names.OVERRIDE_LINES_PER_PAGE_0006MS); } }
        public IField OVERRIDE_LINES_PER_PAGE_0006 { get { return GetElementByName<IField>(Names.OVERRIDE_LINES_PER_PAGE_0006); } }
        public IField OVERRIDE_LINES_PER_PAGE_0006XX { get { return GetElementByName<IField>(Names.OVERRIDE_LINES_PER_PAGE_0006XX); } }
        public IField OVERRIDE_CARRIAGE_CONTR_0007MS { get { return GetElementByName<IField>(Names.OVERRIDE_CARRIAGE_CONTR_0007MS); } }
        public IField OVERRIDE_CARRIAGE_CONTROL_0007 { get { return GetElementByName<IField>(Names.OVERRIDE_CARRIAGE_CONTROL_0007); } }
        public IField OVERRIDE_CARRIAGE_CONTR_0007XX { get { return GetElementByName<IField>(Names.OVERRIDE_CARRIAGE_CONTR_0007XX); } }
        public IField PERIOD_ENDING_DATE_0007MS { get { return GetElementByName<IField>(Names.PERIOD_ENDING_DATE_0007MS); } }
        public IField PERIOD_ENDING_DATE_0007 { get { return GetElementByName<IField>(Names.PERIOD_ENDING_DATE_0007); } }
        public IField PERIOD_ENDING_DATE_0007XX { get { return GetElementByName<IField>(Names.PERIOD_ENDING_DATE_0007XX); } }
        public IField REPORT_NO_PART1_0007MS { get { return GetElementByName<IField>(Names.REPORT_NO_PART1_0007MS); } }
        public IField REPORT_NO_PART1_0007 { get { return GetElementByName<IField>(Names.REPORT_NO_PART1_0007); } }
        public IField REPORT_NO_PART1_0007XX { get { return GetElementByName<IField>(Names.REPORT_NO_PART1_0007XX); } }
        public IField REPORT_NO_PART2_0007MS { get { return GetElementByName<IField>(Names.REPORT_NO_PART2_0007MS); } }
        public IField REPORT_NO_PART2_0007 { get { return GetElementByName<IField>(Names.REPORT_NO_PART2_0007); } }
        public IField REPORT_NO_PART2_0007XX { get { return GetElementByName<IField>(Names.REPORT_NO_PART2_0007XX); } }
        public IField RUN_DATE_0007MS { get { return GetElementByName<IField>(Names.RUN_DATE_0007MS); } }
        public IField RUN_DATE_0007 { get { return GetElementByName<IField>(Names.RUN_DATE_0007); } }
        public IField RUN_DATE_0007XX { get { return GetElementByName<IField>(Names.RUN_DATE_0007XX); } }
        public IField RUN_TIME_0007MS { get { return GetElementByName<IField>(Names.RUN_TIME_0007MS); } }
        public IField RUN_TIME_0007 { get { return GetElementByName<IField>(Names.RUN_TIME_0007); } }
        public IField RUN_TIME_0007XX { get { return GetElementByName<IField>(Names.RUN_TIME_0007XX); } }
        public IField RPT_HEADING_1_0007MS { get { return GetElementByName<IField>(Names.RPT_HEADING_1_0007MS); } }
        public IField RPT_HEADING_1_0007 { get { return GetElementByName<IField>(Names.RPT_HEADING_1_0007); } }
        public IField RPT_HEADING_1_0007XX { get { return GetElementByName<IField>(Names.RPT_HEADING_1_0007XX); } }
        public IField RPT_HEADING_2_0007MS { get { return GetElementByName<IField>(Names.RPT_HEADING_2_0007MS); } }
        public IField RPT_HEADING_2_0007 { get { return GetElementByName<IField>(Names.RPT_HEADING_2_0007); } }
        public IField RPT_HEADING_2_0007XX { get { return GetElementByName<IField>(Names.RPT_HEADING_2_0007XX); } }
        public IField RPT_HEADING_3_0007MS { get { return GetElementByName<IField>(Names.RPT_HEADING_3_0007MS); } }
        public IField RPT_HEADING_3_0007 { get { return GetElementByName<IField>(Names.RPT_HEADING_3_0007); } }
        public IField RPT_HEADING_3_0007XX { get { return GetElementByName<IField>(Names.RPT_HEADING_3_0007XX); } }
        public IField COL_HEADING_1_0007MS { get { return GetElementByName<IField>(Names.COL_HEADING_1_0007MS); } }
        public IField COL_HEADING_1_0007 { get { return GetElementByName<IField>(Names.COL_HEADING_1_0007); } }
        public IField COL_HEADING_1_0007XX { get { return GetElementByName<IField>(Names.COL_HEADING_1_0007XX); } }
        public IField COL_HEADING_2_0007MS { get { return GetElementByName<IField>(Names.COL_HEADING_2_0007MS); } }
        public IField COL_HEADING_2_0007 { get { return GetElementByName<IField>(Names.COL_HEADING_2_0007); } }
        public IField COL_HEADING_2_0007XX { get { return GetElementByName<IField>(Names.COL_HEADING_2_0007XX); } }
        public IField COL_HEADING_3_0007MS { get { return GetElementByName<IField>(Names.COL_HEADING_3_0007MS); } }
        public IField COL_HEADING_3_0007 { get { return GetElementByName<IField>(Names.COL_HEADING_3_0007); } }
        public IField COL_HEADING_3_0007XX { get { return GetElementByName<IField>(Names.COL_HEADING_3_0007XX); } }
        public IField RPT_DETAIL_0007MS { get { return GetElementByName<IField>(Names.RPT_DETAIL_0007MS); } }
        public IField RPT_DETAIL_0007 { get { return GetElementByName<IField>(Names.RPT_DETAIL_0007); } }
        public IField RPT_DETAIL_0007XX { get { return GetElementByName<IField>(Names.RPT_DETAIL_0007XX); } }
        public IField RPT_FOOTER_1_0007MS { get { return GetElementByName<IField>(Names.RPT_FOOTER_1_0007MS); } }
        public IField RPT_FOOTER_1_0007 { get { return GetElementByName<IField>(Names.RPT_FOOTER_1_0007); } }
        public IField RPT_FOOTER_1_0007XX { get { return GetElementByName<IField>(Names.RPT_FOOTER_1_0007XX); } }
        public IField RPT_FOOTER_2_0007MS { get { return GetElementByName<IField>(Names.RPT_FOOTER_2_0007MS); } }
        public IField RPT_FOOTER_2_0007 { get { return GetElementByName<IField>(Names.RPT_FOOTER_2_0007); } }
        public IField RPT_FOOTER_2_0007XX { get { return GetElementByName<IField>(Names.RPT_FOOTER_2_0007XX); } }
        public IField RPT_FOOTER_3_0007MS { get { return GetElementByName<IField>(Names.RPT_FOOTER_3_0007MS); } }
        public IField RPT_FOOTER_3_0007 { get { return GetElementByName<IField>(Names.RPT_FOOTER_3_0007); } }
        public IField RPT_FOOTER_3_0007XX { get { return GetElementByName<IField>(Names.RPT_FOOTER_3_0007XX); } }
        public IGroup W_OA { get { return GetElementByName<IGroup>(Names.W_OA); } }
        public IGroup EXPORT_0008EV { get { return GetElementByName<IGroup>(Names.EXPORT_0008EV); } }
        public IGroup CL_EAB_REPORT_RETURN_0008ET { get { return GetElementByName<IGroup>(Names.CL_EAB_REPORT_RETURN_0008ET); } }
        public IField PAGE_NUMBER_0008MS { get { return GetElementByName<IField>(Names.PAGE_NUMBER_0008MS); } }
        public IField PAGE_NUMBER_0008 { get { return GetElementByName<IField>(Names.PAGE_NUMBER_0008); } }
        public IField PAGE_NUMBER_0008XX { get { return GetElementByName<IField>(Names.PAGE_NUMBER_0008XX); } }
        public IField LINE_NUMBER_0008MS { get { return GetElementByName<IField>(Names.LINE_NUMBER_0008MS); } }
        public IField LINE_NUMBER_0008 { get { return GetElementByName<IField>(Names.LINE_NUMBER_0008); } }
        public IField LINE_NUMBER_0008XX { get { return GetElementByName<IField>(Names.LINE_NUMBER_0008XX); } }
        public IField LINES_REMAINING_0008MS { get { return GetElementByName<IField>(Names.LINES_REMAINING_0008MS); } }
        public IField LINES_REMAINING_0008 { get { return GetElementByName<IField>(Names.LINES_REMAINING_0008); } }
        public IField LINES_REMAINING_0008XX { get { return GetElementByName<IField>(Names.LINES_REMAINING_0008XX); } }
        public IGroup W_OB { get { return GetElementByName<IGroup>(Names.W_OB); } }
        public IGroup EXPORT_0009EV { get { return GetElementByName<IGroup>(Names.EXPORT_0009EV); } }
        public IGroup BB_FILE_0009ET { get { return GetElementByName<IGroup>(Names.BB_FILE_0009ET); } }
        public IField STATUS_0009MS { get { return GetElementByName<IField>(Names.STATUS_0009MS); } }
        public IField STATUS_0009 { get { return GetElementByName<IField>(Names.STATUS_0009); } }
        public IField STATUS_0009XX { get { return GetElementByName<IField>(Names.STATUS_0009XX); } }

        #endregion

        #region Data structure definition
        /// <summary>
        /// Defines the entirety of the LinkageSection IRecord structure as described by the Ateras.Framework.Buffer API.
        /// </summary>
        /// <param name="recordDef">The IStructureDefinition object to be used in defining the record structure.</param>
        protected override void DefineRecordStructure(IStructureDefinition recordDef)
        {

            recordDef.CreateNewGroup(Names.W_IA, (W_IA) =>
           {
               W_IA.CreateNewGroup(Names.IMPORT_0001EV, (IMPORT_0001EV) =>
               {
                   IMPORT_0001EV.CreateNewGroup(Names.BB_FILE_0001ET, (BB_FILE_0001ET) =>
                   {
                       BB_FILE_0001ET.CreateNewField(Names.ACTION_0001MS, FieldType.String, 1);

                       IField ACTION_0001_local = BB_FILE_0001ET.CreateNewField(Names.ACTION_0001, FieldType.String, 8);
                       BB_FILE_0001ET.CreateNewFieldRedefine(Names.ACTION_0001XX, FieldType.String, ACTION_0001_local, 8);
                   });
               });
           });

            recordDef.CreateNewGroup(Names.W_IB, (W_IB) =>
           {
               W_IB.CreateNewGroup(Names.IMPORT_0002EV, (IMPORT_0002EV) =>
               {
                   IMPORT_0002EV.CreateNewGroup(Names.CL_EAB_REPORT_SEND_0002ET, (CL_EAB_REPORT_SEND_0002ET) =>
                   {
                       CL_EAB_REPORT_SEND_0002ET.CreateNewField(Names.REPORT_NUMBER_0002MS, FieldType.String, 1);

                       IField REPORT_NUMBER_0002_local = CL_EAB_REPORT_SEND_0002ET.CreateNewField(Names.REPORT_NUMBER_0002, FieldType.SignedNumeric, 2);
                       CL_EAB_REPORT_SEND_0002ET.CreateNewFieldRedefine(Names.REPORT_NUMBER_0002XX, FieldType.String, REPORT_NUMBER_0002_local, 2);
                       CL_EAB_REPORT_SEND_0002ET.CreateNewField(Names.COMMAND_0002MS, FieldType.String, 1);

                       IField COMMAND_0002_local = CL_EAB_REPORT_SEND_0002ET.CreateNewField(Names.COMMAND_0002, FieldType.String, 7);
                       CL_EAB_REPORT_SEND_0002ET.CreateNewFieldRedefine(Names.COMMAND_0002XX, FieldType.String, COMMAND_0002_local, 7);
                       CL_EAB_REPORT_SEND_0002ET.CreateNewField(Names.BLANK_LINE_AFTER_HEADIN_0003MS, FieldType.String, 1);

                       IField BLANK_LINE_AFTER_HEADING_0003_local = CL_EAB_REPORT_SEND_0002ET.CreateNewField(Names.BLANK_LINE_AFTER_HEADING_0003, FieldType.String, 1);
                       CL_EAB_REPORT_SEND_0002ET.CreateNewFieldRedefine(Names.BLANK_LINE_AFTER_HEADIN_0003XX, FieldType.String, BLANK_LINE_AFTER_HEADING_0003_local, 1);
                       CL_EAB_REPORT_SEND_0002ET.CreateNewField(Names.BLANK_LINE_AFTER_COL_HE_0004MS, FieldType.String, 1);

                       IField BLANK_LINE_AFTER_COL_HEAD_0004_local = CL_EAB_REPORT_SEND_0002ET.CreateNewField(Names.BLANK_LINE_AFTER_COL_HEAD_0004, FieldType.String, 1);
                       CL_EAB_REPORT_SEND_0002ET.CreateNewFieldRedefine(Names.BLANK_LINE_AFTER_COL_HE_0004XX, FieldType.String, BLANK_LINE_AFTER_COL_HEAD_0004_local, 1);
                       CL_EAB_REPORT_SEND_0002ET.CreateNewField(Names.BLANK_LINE_BEFORE_FOOTE_0005MS, FieldType.String, 1);

                       IField BLANK_LINE_BEFORE_FOOTERS_0005_local = CL_EAB_REPORT_SEND_0002ET.CreateNewField(Names.BLANK_LINE_BEFORE_FOOTERS_0005, FieldType.String, 1);
                       CL_EAB_REPORT_SEND_0002ET.CreateNewFieldRedefine(Names.BLANK_LINE_BEFORE_FOOTE_0005XX, FieldType.String, BLANK_LINE_BEFORE_FOOTERS_0005_local, 1);
                       CL_EAB_REPORT_SEND_0002ET.CreateNewField(Names.NUMBER_OF_COL_HEADINGS_0005MS, FieldType.String, 1);

                       IField NUMBER_OF_COL_HEADINGS_0005_local = CL_EAB_REPORT_SEND_0002ET.CreateNewField(Names.NUMBER_OF_COL_HEADINGS_0005, FieldType.SignedNumeric, 1);
                       CL_EAB_REPORT_SEND_0002ET.CreateNewFieldRedefine(Names.NUMBER_OF_COL_HEADINGS_0005XX, FieldType.String, NUMBER_OF_COL_HEADINGS_0005_local, 1);
                       CL_EAB_REPORT_SEND_0002ET.CreateNewField(Names.NUMBER_OF_FOOTERS_0005MS, FieldType.String, 1);

                       IField NUMBER_OF_FOOTERS_0005_local = CL_EAB_REPORT_SEND_0002ET.CreateNewField(Names.NUMBER_OF_FOOTERS_0005, FieldType.SignedNumeric, 1);
                       CL_EAB_REPORT_SEND_0002ET.CreateNewFieldRedefine(Names.NUMBER_OF_FOOTERS_0005XX, FieldType.String, NUMBER_OF_FOOTERS_0005_local, 1);
                       CL_EAB_REPORT_SEND_0002ET.CreateNewField(Names.OVERRIDE_PAGE_NO_0005MS, FieldType.String, 1);

                       IField OVERRIDE_PAGE_NO_0005_local = CL_EAB_REPORT_SEND_0002ET.CreateNewField(Names.OVERRIDE_PAGE_NO_0005, FieldType.SignedNumeric, 9);
                       CL_EAB_REPORT_SEND_0002ET.CreateNewFieldRedefine(Names.OVERRIDE_PAGE_NO_0005XX, FieldType.String, OVERRIDE_PAGE_NO_0005_local, 9);
                       CL_EAB_REPORT_SEND_0002ET.CreateNewField(Names.OVERRIDE_LINES_PER_PAGE_0006MS, FieldType.String, 1);

                       IField OVERRIDE_LINES_PER_PAGE_0006_local = CL_EAB_REPORT_SEND_0002ET.CreateNewField(Names.OVERRIDE_LINES_PER_PAGE_0006, FieldType.String, 2);
                       CL_EAB_REPORT_SEND_0002ET.CreateNewFieldRedefine(Names.OVERRIDE_LINES_PER_PAGE_0006XX, FieldType.String, OVERRIDE_LINES_PER_PAGE_0006_local, 2);
                       CL_EAB_REPORT_SEND_0002ET.CreateNewField(Names.OVERRIDE_CARRIAGE_CONTR_0007MS, FieldType.String, 1);

                       IField OVERRIDE_CARRIAGE_CONTROL_0007_local = CL_EAB_REPORT_SEND_0002ET.CreateNewField(Names.OVERRIDE_CARRIAGE_CONTROL_0007, FieldType.String, 1);
                       CL_EAB_REPORT_SEND_0002ET.CreateNewFieldRedefine(Names.OVERRIDE_CARRIAGE_CONTR_0007XX, FieldType.String, OVERRIDE_CARRIAGE_CONTROL_0007_local, 1);
                       CL_EAB_REPORT_SEND_0002ET.CreateNewField(Names.PERIOD_ENDING_DATE_0007MS, FieldType.String, 1);

                       IField PERIOD_ENDING_DATE_0007_local = CL_EAB_REPORT_SEND_0002ET.CreateNewField(Names.PERIOD_ENDING_DATE_0007, FieldType.SignedNumeric, 8);
                       CL_EAB_REPORT_SEND_0002ET.CreateNewFieldRedefine(Names.PERIOD_ENDING_DATE_0007XX, FieldType.String, PERIOD_ENDING_DATE_0007_local, 8);
                       CL_EAB_REPORT_SEND_0002ET.CreateNewField(Names.REPORT_NO_PART1_0007MS, FieldType.String, 1);

                       IField REPORT_NO_PART1_0007_local = CL_EAB_REPORT_SEND_0002ET.CreateNewField(Names.REPORT_NO_PART1_0007, FieldType.String, 8);
                       CL_EAB_REPORT_SEND_0002ET.CreateNewFieldRedefine(Names.REPORT_NO_PART1_0007XX, FieldType.String, REPORT_NO_PART1_0007_local, 8);
                       CL_EAB_REPORT_SEND_0002ET.CreateNewField(Names.REPORT_NO_PART2_0007MS, FieldType.String, 1);

                       IField REPORT_NO_PART2_0007_local = CL_EAB_REPORT_SEND_0002ET.CreateNewField(Names.REPORT_NO_PART2_0007, FieldType.String, 2);
                       CL_EAB_REPORT_SEND_0002ET.CreateNewFieldRedefine(Names.REPORT_NO_PART2_0007XX, FieldType.String, REPORT_NO_PART2_0007_local, 2);
                       CL_EAB_REPORT_SEND_0002ET.CreateNewField(Names.RUN_DATE_0007MS, FieldType.String, 1);

                       IField RUN_DATE_0007_local = CL_EAB_REPORT_SEND_0002ET.CreateNewField(Names.RUN_DATE_0007, FieldType.SignedNumeric, 8);
                       CL_EAB_REPORT_SEND_0002ET.CreateNewFieldRedefine(Names.RUN_DATE_0007XX, FieldType.String, RUN_DATE_0007_local, 8);
                       CL_EAB_REPORT_SEND_0002ET.CreateNewField(Names.RUN_TIME_0007MS, FieldType.String, 1);

                       IField RUN_TIME_0007_local = CL_EAB_REPORT_SEND_0002ET.CreateNewField(Names.RUN_TIME_0007, FieldType.SignedNumeric, 6);
                       CL_EAB_REPORT_SEND_0002ET.CreateNewFieldRedefine(Names.RUN_TIME_0007XX, FieldType.String, RUN_TIME_0007_local, 6);
                       CL_EAB_REPORT_SEND_0002ET.CreateNewField(Names.RPT_HEADING_1_0007MS, FieldType.String, 1);

                       IField RPT_HEADING_1_0007_local = CL_EAB_REPORT_SEND_0002ET.CreateNewField(Names.RPT_HEADING_1_0007, FieldType.String, 80);
                       CL_EAB_REPORT_SEND_0002ET.CreateNewFieldRedefine(Names.RPT_HEADING_1_0007XX, FieldType.String, RPT_HEADING_1_0007_local, 80);
                       CL_EAB_REPORT_SEND_0002ET.CreateNewField(Names.RPT_HEADING_2_0007MS, FieldType.String, 1);

                       IField RPT_HEADING_2_0007_local = CL_EAB_REPORT_SEND_0002ET.CreateNewField(Names.RPT_HEADING_2_0007, FieldType.String, 80);
                       CL_EAB_REPORT_SEND_0002ET.CreateNewFieldRedefine(Names.RPT_HEADING_2_0007XX, FieldType.String, RPT_HEADING_2_0007_local, 80);
                       CL_EAB_REPORT_SEND_0002ET.CreateNewField(Names.RPT_HEADING_3_0007MS, FieldType.String, 1);

                       IField RPT_HEADING_3_0007_local = CL_EAB_REPORT_SEND_0002ET.CreateNewField(Names.RPT_HEADING_3_0007, FieldType.String, 80);
                       CL_EAB_REPORT_SEND_0002ET.CreateNewFieldRedefine(Names.RPT_HEADING_3_0007XX, FieldType.String, RPT_HEADING_3_0007_local, 80);
                       CL_EAB_REPORT_SEND_0002ET.CreateNewField(Names.COL_HEADING_1_0007MS, FieldType.String, 1);

                       IField COL_HEADING_1_0007_local = CL_EAB_REPORT_SEND_0002ET.CreateNewField(Names.COL_HEADING_1_0007, FieldType.String, 132);
                       CL_EAB_REPORT_SEND_0002ET.CreateNewFieldRedefine(Names.COL_HEADING_1_0007XX, FieldType.String, COL_HEADING_1_0007_local, 132);
                       CL_EAB_REPORT_SEND_0002ET.CreateNewField(Names.COL_HEADING_2_0007MS, FieldType.String, 1);

                       IField COL_HEADING_2_0007_local = CL_EAB_REPORT_SEND_0002ET.CreateNewField(Names.COL_HEADING_2_0007, FieldType.String, 132);
                       CL_EAB_REPORT_SEND_0002ET.CreateNewFieldRedefine(Names.COL_HEADING_2_0007XX, FieldType.String, COL_HEADING_2_0007_local, 132);
                       CL_EAB_REPORT_SEND_0002ET.CreateNewField(Names.COL_HEADING_3_0007MS, FieldType.String, 1);

                       IField COL_HEADING_3_0007_local = CL_EAB_REPORT_SEND_0002ET.CreateNewField(Names.COL_HEADING_3_0007, FieldType.String, 132);
                       CL_EAB_REPORT_SEND_0002ET.CreateNewFieldRedefine(Names.COL_HEADING_3_0007XX, FieldType.String, COL_HEADING_3_0007_local, 132);
                       CL_EAB_REPORT_SEND_0002ET.CreateNewField(Names.RPT_DETAIL_0007MS, FieldType.String, 1);

                       IField RPT_DETAIL_0007_local = CL_EAB_REPORT_SEND_0002ET.CreateNewField(Names.RPT_DETAIL_0007, FieldType.String, 132);
                       CL_EAB_REPORT_SEND_0002ET.CreateNewFieldRedefine(Names.RPT_DETAIL_0007XX, FieldType.String, RPT_DETAIL_0007_local, 132);
                       CL_EAB_REPORT_SEND_0002ET.CreateNewField(Names.RPT_FOOTER_1_0007MS, FieldType.String, 1);

                       IField RPT_FOOTER_1_0007_local = CL_EAB_REPORT_SEND_0002ET.CreateNewField(Names.RPT_FOOTER_1_0007, FieldType.String, 132);
                       CL_EAB_REPORT_SEND_0002ET.CreateNewFieldRedefine(Names.RPT_FOOTER_1_0007XX, FieldType.String, RPT_FOOTER_1_0007_local, 132);
                       CL_EAB_REPORT_SEND_0002ET.CreateNewField(Names.RPT_FOOTER_2_0007MS, FieldType.String, 1);

                       IField RPT_FOOTER_2_0007_local = CL_EAB_REPORT_SEND_0002ET.CreateNewField(Names.RPT_FOOTER_2_0007, FieldType.String, 132);
                       CL_EAB_REPORT_SEND_0002ET.CreateNewFieldRedefine(Names.RPT_FOOTER_2_0007XX, FieldType.String, RPT_FOOTER_2_0007_local, 132);
                       CL_EAB_REPORT_SEND_0002ET.CreateNewField(Names.RPT_FOOTER_3_0007MS, FieldType.String, 1);

                       IField RPT_FOOTER_3_0007_local = CL_EAB_REPORT_SEND_0002ET.CreateNewField(Names.RPT_FOOTER_3_0007, FieldType.String, 132);
                       CL_EAB_REPORT_SEND_0002ET.CreateNewFieldRedefine(Names.RPT_FOOTER_3_0007XX, FieldType.String, RPT_FOOTER_3_0007_local, 132);
                   });
               });
           });

            recordDef.CreateNewGroup(Names.W_OA, (W_OA) =>
           {
               W_OA.CreateNewGroup(Names.EXPORT_0008EV, (EXPORT_0008EV) =>
               {
                   EXPORT_0008EV.CreateNewGroup(Names.CL_EAB_REPORT_RETURN_0008ET, (CL_EAB_REPORT_RETURN_0008ET) =>
                   {
                       CL_EAB_REPORT_RETURN_0008ET.CreateNewField(Names.PAGE_NUMBER_0008MS, FieldType.String, 1);

                       IField PAGE_NUMBER_0008_local = CL_EAB_REPORT_RETURN_0008ET.CreateNewField(Names.PAGE_NUMBER_0008, FieldType.SignedNumeric, 9);
                       CL_EAB_REPORT_RETURN_0008ET.CreateNewFieldRedefine(Names.PAGE_NUMBER_0008XX, FieldType.String, PAGE_NUMBER_0008_local, 9);
                       CL_EAB_REPORT_RETURN_0008ET.CreateNewField(Names.LINE_NUMBER_0008MS, FieldType.String, 1);

                       IField LINE_NUMBER_0008_local = CL_EAB_REPORT_RETURN_0008ET.CreateNewField(Names.LINE_NUMBER_0008, FieldType.SignedNumeric, 2);
                       CL_EAB_REPORT_RETURN_0008ET.CreateNewFieldRedefine(Names.LINE_NUMBER_0008XX, FieldType.String, LINE_NUMBER_0008_local, 2);
                       CL_EAB_REPORT_RETURN_0008ET.CreateNewField(Names.LINES_REMAINING_0008MS, FieldType.String, 1);

                       IField LINES_REMAINING_0008_local = CL_EAB_REPORT_RETURN_0008ET.CreateNewField(Names.LINES_REMAINING_0008, FieldType.SignedNumeric, 2);
                       CL_EAB_REPORT_RETURN_0008ET.CreateNewFieldRedefine(Names.LINES_REMAINING_0008XX, FieldType.String, LINES_REMAINING_0008_local, 2);
                   });
               });
           });

            recordDef.CreateNewGroup(Names.W_OB, (W_OB) =>
           {
               W_OB.CreateNewGroup(Names.EXPORT_0009EV, (EXPORT_0009EV) =>
               {
                   EXPORT_0009EV.CreateNewGroup(Names.BB_FILE_0009ET, (BB_FILE_0009ET) =>
                   {
                       BB_FILE_0009ET.CreateNewField(Names.STATUS_0009MS, FieldType.String, 1);

                       IField STATUS_0009_local = BB_FILE_0009ET.CreateNewField(Names.STATUS_0009, FieldType.String, 8);
                       BB_FILE_0009ET.CreateNewFieldRedefine(Names.STATUS_0009XX, FieldType.String, STATUS_0009_local, 8);
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
            SetPassedParm(W_IB, args, 1);
            SetPassedParm(W_OA, args, 2);
            SetPassedParm(W_OB, args, 3);
        }


        public void UpdateReturnParameters(object[] args)
        {
            SetReturnParm(W_IA, args, 0);
            SetReturnParm(W_IB, args, 1);
            SetReturnParm(W_OA, args, 2);
            SetReturnParm(W_OB, args, 3);
        }
    }
    #endregion Linkage Section Class

    #region Business Logic Class
    public class SWEXGP03 : EABBase
    {

        #region Public Constructors
        public SWEXGP03()
            : base()
        {
            this.ProgramName.SetValue("SWEXGP03");

            WS = new SWEXGP03_ws();
            FD = new SWEXGP03_fd();
            LS = new SWEXGP03_ls();
        }

        #endregion

        #region Private Fields


        //==== Working Storage Data Class ========================================
        private SWEXGP03_ws WS;

        //==== File Data Class ========================================
        private SWEXGP03_fd FD;

        //==== Linkage Section Data Class ========================================
        private SWEXGP03_ls LS;
        #endregion

        #region Public Methods
        //========================================================================
        //==== RunMain Entry Point Method ========================================
        //========================================================================
        public override int ExecuteMain(params object[] args)                                              //COBOL==> PROCEDURE DIVISION USING W-IA , W-IB , W-OA , W-OB.
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
            M_MAIN_0341837336(returnMethod);
        }
        /// <summary>
        /// Method M_MAIN_0341837336
        /// </summary>
        private void M_MAIN_0341837336(string returnMethod = "")
        {
            M_PARA_0341837336("M_PARA_0341837336_EXIT"); if (Control.ExitProgram) { return; }                     //COBOL==> PERFORM PARA-0341837336 THRU PARA-0341837336-EXIT
            Control.ExitProgram = true; return;                                                                 //COBOL==> GOBACK.
        }
        /// <summary>
        /// Method M_PARA_0341837336
        /// </summary>
        private void M_PARA_0341837336(string returnMethod = "")
        {
            //COMMENT:  * * * * * * * * * * * * * * * * * * * * * *
            //COMMENT:    USER-WRITTEN CODE SHOULD BE INSERTED HERE
            //COMMENT:  * * * * * * * * * * * * * * * * * * * * * *
            // EvaluateList !LS.ACTION_0001!                                                                    //COBOL==> EVALUATE ACTION-0001
            if ((LS.ACTION_0001.IsEqualTo("OPEN")))                                                             //COBOL==> WHEN 'OPEN'
            {
                M_PARA_OPEN("M_PARA_OPEN_EXIT"); if (Control.ExitProgram) { return; }                                 //COBOL==> PERFORM PARA-OPEN THRU PARA-OPEN-EXIT
            }                                                                                                //COBOL==> WHEN 'CLOSE'
            else
            if ((LS.ACTION_0001.IsEqualTo("CLOSE")))
            {
                M_PARA_CLOSE("M_PARA_CLOSE_EXIT"); if (Control.ExitProgram) { return; }                               //COBOL==> PERFORM PARA-CLOSE THRU PARA-CLOSE-EXIT
            }                                                                                                //COBOL==> WHEN 'WRITE'
            else
            if ((LS.ACTION_0001.IsEqualTo("WRITE")))
            {
                M_PARA_MAIN("M_PARA_MAIN_EXIT"); if (Control.ExitProgram) { return; }                                 //COBOL==> PERFORM PARA-MAIN THRU PARA-MAIN-EXIT
            }                                                                                                //COBOL==> WHEN OTHER
            else
            {
                LS.STATUS_0009.SetValue("ABEND");                                                                   //COBOL==> MOVE 'ABEND' TO STATUS-0009 .
            }
            if (returnMethod != "" && returnMethod != "M_PARA_0341837336") { M_PARA_0341837336_EXIT(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_PARA_0341837336_EXIT
        /// </summary>
        private void M_PARA_0341837336_EXIT(string returnMethod = "")
        {
            if (returnMethod == "M_PARA_0341837336_EXIT") { return; }                                           //COBOL==> EXIT.
            if (returnMethod != "" && returnMethod != "M_PARA_0341837336_EXIT") { M_PARA_MAIN(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_PARA_MAIN
        /// </summary>
        private void M_PARA_MAIN(string returnMethod = "")
        {
            // EvaluateList !LS.COMMAND_0002!                                                                   //COBOL==> EVALUATE COMMAND-0002
            if ((LS.COMMAND_0002.IsEqualTo("REFRESH")))                                                         //COBOL==> WHEN 'REFRESH'
            {
                WS.WS_PAGE_NO.SetValue(LS.OVERRIDE_PAGE_NO_0005);                                                   //COBOL==> MOVE OVERRIDE-PAGE-NO-0005 TO WS-PAGE-NO
                if (LS.OVERRIDE_LINES_PER_PAGE_0006.IsGreaterThan(ZEROS))                                           //COBOL==> IF OVERRIDE-LINES-PER-PAGE-0006 GREATER THAN ZERO
                {
                    WS.WS_LINES_PER_PAGE.SetValue(LS.OVERRIDE_LINES_PER_PAGE_0006);                                     //COBOL==> MOVE OVERRIDE-LINES-PER-PAGE-0006 TO WS-LINES-PER-PAGE
                }                                                                                                   //COBOL==> END-IF
                M_PARA_HEADINGS("M_PARA_HEADINGS_EXIT"); if (Control.ExitProgram) { return; }                         //COBOL==> PERFORM PARA-HEADINGS THRU PARA-HEADINGS-EXIT
            }                                                                                                //COBOL==> WHEN 'HEADING'
            else
            if ((LS.COMMAND_0002.IsEqualTo("HEADING")))
            {
                M_PARA_HEADINGS("M_PARA_HEADINGS_EXIT"); if (Control.ExitProgram) { return; }                         //COBOL==> PERFORM PARA-HEADINGS THRU PARA-HEADINGS-EXIT
            }                                                                                                //COBOL==> WHEN 'DETAIL'
            else
            if ((LS.COMMAND_0002.IsEqualTo("DETAIL")))
            {
                M_PARA_DETAIL("M_PARA_DETAIL_EXIT"); if (Control.ExitProgram) { return; }                             //COBOL==> PERFORM PARA-DETAIL THRU PARA-DETAIL-EXIT
            }                                                                                                //COBOL==> WHEN 'CLOSING'
            else
            if ((LS.COMMAND_0002.IsEqualTo("CLOSING")))
            {
                M_PARA_CLOSING("M_PARA_CLOSING_EXIT"); if (Control.ExitProgram) { return; }                           //COBOL==> PERFORM PARA-CLOSING THRU PARA-CLOSING-EXIT
                if (LS.NUMBER_OF_FOOTERS_0005.IsGreaterThan(ZEROS))                                                 //COBOL==> IF NUMBER-OF-FOOTERS-0005 GREATER THAN ZERO
                {
                    M_PARA_POSITION("M_PARA_POSITION_EXIT"); if (Control.ExitProgram) { return; }                         //COBOL==> PERFORM PARA-POSITION THRU PARA-POSITION-EXIT
                    M_PARA_FOOTERS("M_PARA_FOOTERS_EXIT"); if (Control.ExitProgram) { return; }                           //COBOL==> PERFORM PARA-FOOTERS THRU PARA-FOOTERS-EXIT
                }                                                                                                   //COBOL==> END-IF
            }                                                                                                //COBOL==> WHEN 'FOOTERS'
            else
            if ((LS.COMMAND_0002.IsEqualTo("FOOTERS")))
            {
                if (LS.NUMBER_OF_FOOTERS_0005.IsGreaterThan(ZEROS))                                                 //COBOL==> IF NUMBER-OF-FOOTERS-0005 GREATER THAN ZERO
                {
                    M_PARA_POSITION("M_PARA_POSITION_EXIT"); if (Control.ExitProgram) { return; }                         //COBOL==> PERFORM PARA-POSITION THRU PARA-POSITION-EXIT
                    M_PARA_FOOTERS("M_PARA_FOOTERS_EXIT"); if (Control.ExitProgram) { return; }                           //COBOL==> PERFORM PARA-FOOTERS THRU PARA-FOOTERS-EXIT
                }                                                                                                   //COBOL==> END-IF
            }                                                                                                //COBOL==> WHEN OTHER
            else
            {
                LS.STATUS_0009.SetValue("ABEND");                                                                   //COBOL==> MOVE 'ABEND' TO STATUS-0009.
            }
            if (returnMethod != "" && returnMethod != "M_PARA_MAIN") { M_PARA_MAIN_EXIT(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_PARA_MAIN_EXIT
        /// </summary>
        private void M_PARA_MAIN_EXIT(string returnMethod = "")
        {
            if (returnMethod == "M_PARA_MAIN_EXIT") { return; }                                                 //COBOL==> EXIT.
            if (returnMethod != "" && returnMethod != "M_PARA_MAIN_EXIT") { M_PARA_DETAIL(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_PARA_DETAIL
        /// </summary>
        private void M_PARA_DETAIL(string returnMethod = "")
        {
            WS.WS_DETAIL_BODY.SetValue(LS.RPT_DETAIL_0007);                                                     //COBOL==> MOVE RPT-DETAIL-0007 TO WS-DETAIL-BODY.
            WS.WS_DETAIL_CC.SetValueWithSpaces();                                                               //COBOL==> MOVE SPACE TO WS-DETAIL-CC.
            FD.REPTOUT.WriteLinePrinter(WS.WS_DETAIL_LINE.AsString(), PrinterControl.LINEBREAK, 0, 1);             //COBOL==> WRITE DETAILS FROM WS-DETAIL-LINE AFTER ADVANCING 1 LINE.
            WS.WS_LINE_COUNT.Add(+1);                                                                           //COBOL==> ADD +1 TO WS-LINE-COUNT.
            WS.WS_LINES_REMAIN.SetValue(WS.WS_LINES_PER_PAGE.AsInt() - WS.WS_LINE_COUNT.AsInt());               //COBOL==> SUBTRACT WS-LINE-COUNT FROM WS-LINES-PER-PAGE GIVING WS-LINES-REMAIN.
            LS.PAGE_NUMBER_0008.SetValue(WS.WS_PAGE_NO);                                                        //COBOL==> MOVE WS-PAGE-NO TO PAGE-NUMBER-0008.
            LS.LINE_NUMBER_0008.SetValue(WS.WS_LINE_COUNT);                                                     //COBOL==> MOVE WS-LINE-COUNT TO LINE-NUMBER-0008.
            LS.LINES_REMAINING_0008.SetValue(WS.WS_LINES_REMAIN);                                               //COBOL==> MOVE WS-LINES-REMAIN TO LINES-REMAINING-0008.
            LS.STATUS_0009.SetValue("OK");                                                                      //COBOL==> MOVE 'OK' TO STATUS-0009.
                                                                                                                // EvaluateList !LS.NUMBER_OF_FOOTERS_0005!                                                         //COBOL==> EVALUATE NUMBER-OF-FOOTERS-0005
            if ((LS.NUMBER_OF_FOOTERS_0005.IsZeroes()))                                                         //COBOL==> WHEN 0
            {
                if (WS.WS_LINES_REMAIN.IsEqualTo(0))                                                                //COBOL==> IF WS-LINES-REMAIN EQUAL 0
                {
                    M_PARA_HEADINGS("M_PARA_HEADINGS_EXIT"); if (Control.ExitProgram) { return; }                         //COBOL==> PERFORM PARA-HEADINGS THRU PARA-HEADINGS-EXIT
                }                                                                                                   //COBOL==> END-IF
            }                                                                                                   //COBOL==> END-EVALUATE.
            if (LS.BLANK_LINE_BEFORE_FOOTERS_0005.IsEqualTo("Y"))                                               //COBOL==> IF BLANK-LINE-BEFORE-FOOTERS-0005 EQUAL 'Y'
            {
                WS.WS_LINES_REMAIN.SetValue(WS.WS_LINES_REMAIN.AsInt() - +1);                                       //COBOL==> SUBTRACT +1 FROM WS-LINES-REMAIN.
            }
            // EvaluateList !LS.NUMBER_OF_FOOTERS_0005!                                                         //COBOL==> EVALUATE NUMBER-OF-FOOTERS-0005
            if ((LS.NUMBER_OF_FOOTERS_0005.IsEqualTo(1)))                                                       //COBOL==> WHEN 1
            {
                if (WS.WS_LINES_REMAIN.IsEqualTo(+1))                                                               //COBOL==> IF WS-LINES-REMAIN EQUAL +1
                {
                    M_PARA_FOOTERS("M_PARA_FOOTERS_EXIT"); if (Control.ExitProgram) { return; }                           //COBOL==> PERFORM PARA-FOOTERS THRU PARA-FOOTERS-EXIT
                    M_PARA_HEADINGS("M_PARA_HEADINGS_EXIT"); if (Control.ExitProgram) { return; }                         //COBOL==> PERFORM PARA-HEADINGS THRU PARA-HEADINGS-EXIT
                }                                                                                                   //COBOL==> END-IF
            }                                                                                                //COBOL==> WHEN 2
            else
            if ((LS.NUMBER_OF_FOOTERS_0005.IsEqualTo(2)))
            {
                if (WS.WS_LINES_REMAIN.IsEqualTo(+2))                                                               //COBOL==> IF WS-LINES-REMAIN EQUAL +2
                {
                    M_PARA_FOOTERS("M_PARA_FOOTERS_EXIT"); if (Control.ExitProgram) { return; }                           //COBOL==> PERFORM PARA-FOOTERS THRU PARA-FOOTERS-EXIT
                    M_PARA_HEADINGS("M_PARA_HEADINGS_EXIT"); if (Control.ExitProgram) { return; }                         //COBOL==> PERFORM PARA-HEADINGS THRU PARA-HEADINGS-EXIT
                }                                                                                                   //COBOL==> END-IF
            }                                                                                                //COBOL==> WHEN 3
            else
            if ((LS.NUMBER_OF_FOOTERS_0005.IsEqualTo(3)))
            {
                if (WS.WS_LINES_REMAIN.IsEqualTo(+3))                                                               //COBOL==> IF WS-LINES-REMAIN EQUAL +3
                {
                    M_PARA_FOOTERS("M_PARA_FOOTERS_EXIT"); if (Control.ExitProgram) { return; }                           //COBOL==> PERFORM PARA-FOOTERS THRU PARA-FOOTERS-EXIT
                    M_PARA_HEADINGS("M_PARA_HEADINGS_EXIT"); if (Control.ExitProgram) { return; }                         //COBOL==> PERFORM PARA-HEADINGS THRU PARA-HEADINGS-EXIT
                }                                                                                                   //COBOL==> END-IF
            }                                                                                                   //COBOL==> END-EVALUATE.
            if (returnMethod != "" && returnMethod != "M_PARA_DETAIL") { M_PARA_DETAIL_EXIT(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_PARA_DETAIL_EXIT
        /// </summary>
        private void M_PARA_DETAIL_EXIT(string returnMethod = "")
        {
            if (returnMethod == "M_PARA_DETAIL_EXIT") { return; }                                               //COBOL==> EXIT.
            if (returnMethod != "" && returnMethod != "M_PARA_DETAIL_EXIT") { M_PARA_HEADINGS(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_PARA_HEADINGS
        /// </summary>
        private void M_PARA_HEADINGS(string returnMethod = "")
        {
            WS.WS_PAGE_NO.Add(1);                                                                               //COBOL==> ADD 1 TO WS-PAGE-NO.
            LS.OVERRIDE_PAGE_NO_0005.SetValue(WS.WS_PAGE_NO);                                                   //COBOL==> MOVE WS-PAGE-NO TO OVERRIDE-PAGE-NO-0005.
            Control.Call("SWEXGW97", LS.W_IA, LS.W_IB, WS.RETURN_HEADING1, WS.RETURN_HEADING2, WS.RETURN_HEADING3); if (Control.ExitProgram) return;  //COBOL==> CALL 'SWEXGW97' USING W-IA , W-IB , RETURN-HEADING1 RETURN-HEADING2 RETURN-HEADING3.
            FD.REPTOUT.WriteLinePrinter(WS.RETURN_HEADING1.AsString(), PrinterControl.PAGEBREAK, 0, 1);            //COBOL==> WRITE HEADINGS FROM RETURN-HEADING1 AFTER ADVANCING PAGE.
            FD.REPTOUT.WriteLinePrinter(WS.RETURN_HEADING2.AsString(), PrinterControl.LINEBREAK, 0, 1);            //COBOL==> WRITE HEADINGS FROM RETURN-HEADING2 AFTER ADVANCING 1 LINE.
            FD.REPTOUT.WriteLinePrinter(WS.RETURN_HEADING3.AsString(), PrinterControl.LINEBREAK, 0, 1);            //COBOL==> WRITE HEADINGS FROM RETURN-HEADING3 AFTER ADVANCING 1 LINE.
            WS.WS_LINE_COUNT.SetValue(3);                                                                       //COBOL==> MOVE 3 TO WS-LINE-COUNT.
            if (LS.BLANK_LINE_AFTER_HEADING_0003.IsEqualTo("Y"))                                                //COBOL==> IF BLANK-LINE-AFTER-HEADING-0003 EQUAL 'Y'
            {
                FD.REPTOUT.WriteLinePrinter(WS.WS_BLANK_LINE.AsString(), PrinterControl.LINEBREAK, 0, 1);              //COBOL==> WRITE DETAILS FROM WS-BLANK-LINE AFTER ADVANCING 1 LINE
                WS.WS_LINE_COUNT.Add(1);                                                                            //COBOL==> ADD 1 TO WS-LINE-COUNT.
            }
            // EvaluateList !LS.NUMBER_OF_COL_HEADINGS_0005!                                                    //COBOL==> EVALUATE NUMBER-OF-COL-HEADINGS-0005
            if ((LS.NUMBER_OF_COL_HEADINGS_0005.IsEqualTo(1)))                                                  //COBOL==> WHEN 1
            {
                WS.WS_DETAIL_BODY.SetValue(LS.COL_HEADING_1_0007);                                                  //COBOL==> MOVE COL-HEADING-1-0007 TO WS-DETAIL-BODY
                WS.WS_DETAIL_CC.SetValueWithSpaces();                                                               //COBOL==> MOVE SPACE TO WS-DETAIL-CC
                FD.REPTOUT.WriteLinePrinter(WS.WS_DETAIL_LINE.AsString(), PrinterControl.LINEBREAK, 0, 1);             //COBOL==> WRITE DETAILS FROM WS-DETAIL-LINE AFTER ADVANCING 1 LINE
                WS.WS_LINE_COUNT.Add(1);                                                                            //COBOL==> ADD 1 TO WS-LINE-COUNT
            }                                                                                                //COBOL==> WHEN 2
            else
            if ((LS.NUMBER_OF_COL_HEADINGS_0005.IsEqualTo(2)))
            {
                WS.WS_DETAIL_BODY.SetValue(LS.COL_HEADING_1_0007);                                                  //COBOL==> MOVE COL-HEADING-1-0007 TO WS-DETAIL-BODY
                WS.WS_DETAIL_CC.SetValueWithSpaces();                                                               //COBOL==> MOVE SPACE TO WS-DETAIL-CC
                FD.REPTOUT.WriteLinePrinter(WS.WS_DETAIL_LINE.AsString(), PrinterControl.LINEBREAK, 0, 1);             //COBOL==> WRITE DETAILS FROM WS-DETAIL-LINE AFTER ADVANCING 1 LINE
                WS.WS_DETAIL_BODY.SetValue(LS.COL_HEADING_2_0007);                                                  //COBOL==> MOVE COL-HEADING-2-0007 TO WS-DETAIL-BODY
                WS.WS_DETAIL_CC.SetValueWithSpaces();                                                               //COBOL==> MOVE SPACE TO WS-DETAIL-CC
                FD.REPTOUT.WriteLinePrinter(WS.WS_DETAIL_LINE.AsString(), PrinterControl.LINEBREAK, 0, 1);             //COBOL==> WRITE DETAILS FROM WS-DETAIL-LINE AFTER ADVANCING 1 LINE
                WS.WS_LINE_COUNT.Add(2);                                                                            //COBOL==> ADD 2 TO WS-LINE-COUNT
            }                                                                                                //COBOL==> WHEN 3
            else
            if ((LS.NUMBER_OF_COL_HEADINGS_0005.IsEqualTo(3)))
            {
                WS.WS_DETAIL_BODY.SetValue(LS.COL_HEADING_1_0007);                                                  //COBOL==> MOVE COL-HEADING-1-0007 TO WS-DETAIL-BODY
                WS.WS_DETAIL_CC.SetValueWithSpaces();                                                               //COBOL==> MOVE SPACE TO WS-DETAIL-CC
                FD.REPTOUT.WriteLinePrinter(WS.WS_DETAIL_LINE.AsString(), PrinterControl.LINEBREAK, 0, 1);             //COBOL==> WRITE DETAILS FROM WS-DETAIL-LINE AFTER ADVANCING 1 LINE
                WS.WS_DETAIL_BODY.SetValue(LS.COL_HEADING_2_0007);                                                  //COBOL==> MOVE COL-HEADING-2-0007 TO WS-DETAIL-BODY
                WS.WS_DETAIL_CC.SetValueWithSpaces();                                                               //COBOL==> MOVE SPACE TO WS-DETAIL-CC
                FD.REPTOUT.WriteLinePrinter(WS.WS_DETAIL_LINE.AsString(), PrinterControl.LINEBREAK, 0, 1);             //COBOL==> WRITE DETAILS FROM WS-DETAIL-LINE AFTER ADVANCING 1 LINE
                WS.WS_DETAIL_BODY.SetValue(LS.COL_HEADING_3_0007);                                                  //COBOL==> MOVE COL-HEADING-3-0007 TO WS-DETAIL-BODY
                WS.WS_DETAIL_CC.SetValueWithSpaces();                                                               //COBOL==> MOVE SPACE TO WS-DETAIL-CC
                FD.REPTOUT.WriteLinePrinter(WS.WS_DETAIL_LINE.AsString(), PrinterControl.LINEBREAK, 0, 1);             //COBOL==> WRITE DETAILS FROM WS-DETAIL-LINE AFTER ADVANCING 1 LINE
                WS.WS_LINE_COUNT.Add(3);                                                                            //COBOL==> ADD 3 TO WS-LINE-COUNT
            }                                                                                                   //COBOL==> END-EVALUATE.
            if (LS.BLANK_LINE_AFTER_COL_HEAD_0004.IsEqualTo("Y"))                                               //COBOL==> IF BLANK-LINE-AFTER-COL-HEAD-0004 EQUAL 'Y'
            {
                FD.REPTOUT.WriteLinePrinter(WS.WS_BLANK_LINE.AsString(), PrinterControl.LINEBREAK, 0, 1);              //COBOL==> WRITE DETAILS FROM WS-BLANK-LINE AFTER ADVANCING 1 LINE
                WS.WS_LINE_COUNT.Add(1);                                                                            //COBOL==> ADD 1 TO WS-LINE-COUNT.
            }
            LS.PAGE_NUMBER_0008.SetValue(WS.WS_PAGE_NO);                                                        //COBOL==> MOVE WS-PAGE-NO TO PAGE-NUMBER-0008.
            LS.LINE_NUMBER_0008.SetValue(WS.WS_LINE_COUNT);                                                     //COBOL==> MOVE WS-LINE-COUNT TO LINE-NUMBER-0008.
            WS.WS_LINES_REMAIN.SetValue(WS.WS_LINES_PER_PAGE.AsInt() - WS.WS_LINE_COUNT.AsInt());               //COBOL==> SUBTRACT WS-LINE-COUNT FROM WS-LINES-PER-PAGE GIVING WS-LINES-REMAIN.
            LS.LINES_REMAINING_0008.SetValue(WS.WS_LINES_REMAIN);                                               //COBOL==> MOVE WS-LINES-REMAIN TO LINES-REMAINING-0008.
            LS.STATUS_0009.SetValue("OK");                                                                      //COBOL==> MOVE 'OK' TO STATUS-0009.
            if (returnMethod != "" && returnMethod != "M_PARA_HEADINGS") { M_PARA_HEADINGS_EXIT(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_PARA_HEADINGS_EXIT
        /// </summary>
        private void M_PARA_HEADINGS_EXIT(string returnMethod = "")
        {
            if (returnMethod == "M_PARA_HEADINGS_EXIT") { return; }                                             //COBOL==> EXIT.
            if (returnMethod != "" && returnMethod != "M_PARA_HEADINGS_EXIT") { M_PARA_CLOSING(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_PARA_CLOSING
        /// </summary>
        private void M_PARA_CLOSING(string returnMethod = "")
        {
            WS.WS_DETAIL_BODY.SetValue("END OF REPORT");                                                        //COBOL==> MOVE 'END OF REPORT' TO WS-DETAIL-BODY.
            WS.WS_DETAIL_CC.SetValueWithSpaces();                                                               //COBOL==> MOVE SPACE TO WS-DETAIL-CC.
            FD.REPTOUT.WriteLinePrinter(WS.WS_DETAIL_LINE.AsString(), PrinterControl.LINEBREAK, 0, 1);             //COBOL==> WRITE DETAILS FROM WS-DETAIL-LINE AFTER ADVANCING 1 LINE.
            WS.WS_LINE_COUNT.Add(+1);                                                                           //COBOL==> ADD +1 TO WS-LINE-COUNT.
            WS.WS_LINES_REMAIN.SetValue(WS.WS_LINES_PER_PAGE.AsInt() - WS.WS_LINE_COUNT.AsInt());               //COBOL==> SUBTRACT WS-LINE-COUNT FROM WS-LINES-PER-PAGE GIVING WS-LINES-REMAIN.
            LS.PAGE_NUMBER_0008.SetValue(WS.WS_PAGE_NO);                                                        //COBOL==> MOVE WS-PAGE-NO TO PAGE-NUMBER-0008.
            LS.LINE_NUMBER_0008.SetValue(WS.WS_LINE_COUNT);                                                     //COBOL==> MOVE WS-LINE-COUNT TO LINE-NUMBER-0008.
            LS.LINES_REMAINING_0008.SetValue(WS.WS_LINES_REMAIN);                                               //COBOL==> MOVE WS-LINES-REMAIN TO LINES-REMAINING-0008.
            LS.STATUS_0009.SetValue("OK");                                                                      //COBOL==> MOVE 'OK' TO STATUS-0009.
            if (returnMethod != "" && returnMethod != "M_PARA_CLOSING") { M_PARA_CLOSING_EXIT(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_PARA_CLOSING_EXIT
        /// </summary>
        private void M_PARA_CLOSING_EXIT(string returnMethod = "")
        {
            if (returnMethod == "M_PARA_CLOSING_EXIT") { return; }                                              //COBOL==> EXIT.
            if (returnMethod != "" && returnMethod != "M_PARA_CLOSING_EXIT") { M_PARA_FOOTERS(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_PARA_FOOTERS
        /// </summary>
        private void M_PARA_FOOTERS(string returnMethod = "")
        {
            if (LS.BLANK_LINE_BEFORE_FOOTERS_0005.IsEqualTo("Y"))                                               //COBOL==> IF BLANK-LINE-BEFORE-FOOTERS-0005 EQUAL 'Y'
            {
                FD.REPTOUT.WriteLinePrinter(WS.WS_BLANK_LINE.AsString(), PrinterControl.LINEBREAK, 0, 1);              //COBOL==> WRITE DETAILS FROM WS-BLANK-LINE AFTER ADVANCING 1 LINE.
            }
            // EvaluateList !LS.NUMBER_OF_FOOTERS_0005!                                                         //COBOL==> EVALUATE NUMBER-OF-FOOTERS-0005
            if ((LS.NUMBER_OF_FOOTERS_0005.IsEqualTo(1)))                                                       //COBOL==> WHEN 1
            {
                WS.WS_DETAIL_BODY.SetValue(LS.RPT_FOOTER_1_0007);                                                   //COBOL==> MOVE RPT-FOOTER-1-0007 TO WS-DETAIL-BODY
                WS.WS_DETAIL_CC.SetValueWithSpaces();                                                               //COBOL==> MOVE SPACE TO WS-DETAIL-CC
                FD.REPTOUT.WriteLinePrinter(WS.WS_DETAIL_LINE.AsString(), PrinterControl.LINEBREAK, 0, 1);             //COBOL==> WRITE DETAILS FROM WS-DETAIL-LINE AFTER ADVANCING 1 LINE
            }                                                                                                //COBOL==> WHEN 2
            else
            if ((LS.NUMBER_OF_FOOTERS_0005.IsEqualTo(2)))
            {
                WS.WS_DETAIL_BODY.SetValue(LS.RPT_FOOTER_1_0007);                                                   //COBOL==> MOVE RPT-FOOTER-1-0007 TO WS-DETAIL-BODY
                WS.WS_DETAIL_CC.SetValueWithSpaces();                                                               //COBOL==> MOVE SPACE TO WS-DETAIL-CC
                FD.REPTOUT.WriteLinePrinter(WS.WS_DETAIL_LINE.AsString(), PrinterControl.LINEBREAK, 0, 1);             //COBOL==> WRITE DETAILS FROM WS-DETAIL-LINE AFTER ADVANCING 1 LINE
                WS.WS_DETAIL_BODY.SetValue(LS.RPT_FOOTER_2_0007);                                                   //COBOL==> MOVE RPT-FOOTER-2-0007 TO WS-DETAIL-BODY
                WS.WS_DETAIL_CC.SetValueWithSpaces();                                                               //COBOL==> MOVE SPACE TO WS-DETAIL-CC
                FD.REPTOUT.WriteLinePrinter(WS.WS_DETAIL_LINE.AsString(), PrinterControl.LINEBREAK, 0, 1);             //COBOL==> WRITE DETAILS FROM WS-DETAIL-LINE AFTER ADVANCING 1 LINE
            }                                                                                                //COBOL==> WHEN 3
            else
            if ((LS.NUMBER_OF_FOOTERS_0005.IsEqualTo(3)))
            {
                WS.WS_DETAIL_BODY.SetValue(LS.RPT_FOOTER_1_0007);                                                   //COBOL==> MOVE RPT-FOOTER-1-0007 TO WS-DETAIL-BODY
                WS.WS_DETAIL_CC.SetValueWithSpaces();                                                               //COBOL==> MOVE SPACE TO WS-DETAIL-CC
                FD.REPTOUT.WriteLinePrinter(WS.WS_DETAIL_LINE.AsString(), PrinterControl.LINEBREAK, 0, 1);             //COBOL==> WRITE DETAILS FROM WS-DETAIL-LINE AFTER ADVANCING 1 LINE
                WS.WS_DETAIL_BODY.SetValue(LS.RPT_FOOTER_2_0007);                                                   //COBOL==> MOVE RPT-FOOTER-2-0007 TO WS-DETAIL-BODY
                WS.WS_DETAIL_CC.SetValueWithSpaces();                                                               //COBOL==> MOVE SPACE TO WS-DETAIL-CC
                FD.REPTOUT.WriteLinePrinter(WS.WS_DETAIL_LINE.AsString(), PrinterControl.LINEBREAK, 0, 1);             //COBOL==> WRITE DETAILS FROM WS-DETAIL-LINE AFTER ADVANCING 1 LINE
                WS.WS_DETAIL_BODY.SetValue(LS.RPT_FOOTER_3_0007);                                                   //COBOL==> MOVE RPT-FOOTER-3-0007 TO WS-DETAIL-BODY
                WS.WS_DETAIL_CC.SetValueWithSpaces();                                                               //COBOL==> MOVE SPACE TO WS-DETAIL-CC
                FD.REPTOUT.WriteLinePrinter(WS.WS_DETAIL_LINE.AsString(), PrinterControl.LINEBREAK, 0, 1);             //COBOL==> WRITE DETAILS FROM WS-DETAIL-LINE AFTER ADVANCING 1 LINE
            }                                                                                                   //COBOL==> END-EVALUATE.
            M_PARA_HEADINGS("M_PARA_HEADINGS_EXIT"); if (Control.ExitProgram) { return; }                         //COBOL==> PERFORM PARA-HEADINGS THRU PARA-HEADINGS-EXIT.
            if (returnMethod != "" && returnMethod != "M_PARA_FOOTERS") { M_PARA_FOOTERS_EXIT(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_PARA_FOOTERS_EXIT
        /// </summary>
        private void M_PARA_FOOTERS_EXIT(string returnMethod = "")
        {
            if (returnMethod == "M_PARA_FOOTERS_EXIT") { return; }                                              //COBOL==> EXIT.
            if (returnMethod != "" && returnMethod != "M_PARA_FOOTERS_EXIT") { M_PARA_POSITION(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_PARA_POSITION
        /// </summary>
        private void M_PARA_POSITION(string returnMethod = "")
        {
            WS.WS_POSITION.SetValueWithZeroes();                                                                //COBOL==> MOVE ZERO TO WS-POSITION.
            if (LS.BLANK_LINE_BEFORE_FOOTERS_0005.IsEqualTo("Y"))                                               //COBOL==> IF BLANK-LINE-BEFORE-FOOTERS-0005 EQUAL 'Y'
            {
                WS.WS_POSITION.Add(+1);                                                                             //COBOL==> ADD +1 TO WS-POSITION.
            }
            // EvaluateList !LS.NUMBER_OF_FOOTERS_0005!                                                         //COBOL==> EVALUATE NUMBER-OF-FOOTERS-0005
            if ((LS.NUMBER_OF_FOOTERS_0005.IsEqualTo(1)))                                                       //COBOL==> WHEN 1
            {
                WS.WS_POSITION.Add(+1);                                                                             //COBOL==> ADD +1 TO WS-POSITION
            }                                                                                                //COBOL==> WHEN 2
            else
            if ((LS.NUMBER_OF_FOOTERS_0005.IsEqualTo(2)))
            {
                WS.WS_POSITION.Add(+2);                                                                             //COBOL==> ADD +2 TO WS-POSITION
            }                                                                                                //COBOL==> WHEN 3
            else
            if ((LS.NUMBER_OF_FOOTERS_0005.IsEqualTo(3)))
            {
                WS.WS_POSITION.Add(+3);                                                                             //COBOL==> ADD +3 TO WS-POSITION
            }                                                                                                   //COBOL==> END-EVALUATE.
            while (!(WS.WS_LINES_REMAIN.IsLessThanOrEqualTo(WS.WS_POSITION)))                                   //COBOL==> PERFORM PARA-BLANK THRU PARA-BLANK-EXIT UNTIL WS-LINES-REMAIN LESS THAN OR EQUAL WS-POSITION.
            {
                M_PARA_BLANK("M_PARA_BLANK_EXIT"); if (Control.ExitProgram) { return; }
            }
            if (returnMethod != "" && returnMethod != "M_PARA_POSITION") { M_PARA_POSITION_EXIT(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_PARA_POSITION_EXIT
        /// </summary>
        private void M_PARA_POSITION_EXIT(string returnMethod = "")
        {
            if (returnMethod == "M_PARA_POSITION_EXIT") { return; }                                             //COBOL==> EXIT.
            if (returnMethod != "" && returnMethod != "M_PARA_POSITION_EXIT") { M_PARA_BLANK(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_PARA_BLANK
        /// </summary>
        private void M_PARA_BLANK(string returnMethod = "")
        {
            FD.REPTOUT.WriteLinePrinter(WS.WS_BLANK_LINE.AsString(), PrinterControl.LINEBREAK, 0, 1);              //COBOL==> WRITE DETAILS FROM WS-BLANK-LINE AFTER ADVANCING 1 LINE.
            WS.WS_LINE_COUNT.Add(+1);                                                                           //COBOL==> ADD +1 TO WS-LINE-COUNT.
            WS.WS_LINES_REMAIN.SetValue(WS.WS_LINES_PER_PAGE.AsInt() - WS.WS_LINE_COUNT.AsInt());               //COBOL==> SUBTRACT WS-LINE-COUNT FROM WS-LINES-PER-PAGE GIVING WS-LINES-REMAIN.
            if (returnMethod != "" && returnMethod != "M_PARA_BLANK") { M_PARA_BLANK_EXIT(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_PARA_BLANK_EXIT
        /// </summary>
        private void M_PARA_BLANK_EXIT(string returnMethod = "")
        {
            if (returnMethod == "M_PARA_BLANK_EXIT") { return; }                                                //COBOL==> EXIT.
            if (returnMethod != "" && returnMethod != "M_PARA_BLANK_EXIT") { M_PARA_OPEN(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_PARA_OPEN
        /// </summary>
        private void M_PARA_OPEN(string returnMethod = "")
        {
            FD.REPTOUT.OpenFile(FileAccessMode.Write);                                                          //COBOL==> OPEN OUTPUT REPTOUT.
            LS.STATUS_0009.SetValue("OK");                                                                      //COBOL==> MOVE 'OK' TO STATUS-0009.
            if (returnMethod != "" && returnMethod != "M_PARA_OPEN") { M_PARA_OPEN_EXIT(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_PARA_OPEN_EXIT
        /// </summary>
        private void M_PARA_OPEN_EXIT(string returnMethod = "")
        {
            if (returnMethod == "M_PARA_OPEN_EXIT") { return; }                                                 //COBOL==> EXIT.
            if (returnMethod != "" && returnMethod != "M_PARA_OPEN_EXIT") { M_PARA_CLOSE(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_PARA_CLOSE
        /// </summary>
        private void M_PARA_CLOSE(string returnMethod = "")
        {
            FD.REPTOUT.CloseFile();                                                                             //COBOL==> CLOSE REPTOUT.
            LS.STATUS_0009.SetValue("OK");                                                                      //COBOL==> MOVE 'OK' TO STATUS-0009.
            if (returnMethod != "" && returnMethod != "M_PARA_CLOSE") { M_PARA_CLOSE_EXIT(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_PARA_CLOSE_EXIT
        /// </summary>
        private void M_PARA_CLOSE_EXIT(string returnMethod = "")
        {
            if (returnMethod == "M_PARA_CLOSE_EXIT") { return; }                                                //COBOL==> EXIT.
        }
        #endregion
    }
    #endregion
}
