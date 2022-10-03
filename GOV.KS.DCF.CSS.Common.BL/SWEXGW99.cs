#region Comments
/* Conversion Comments
   ************************************************************
   **   MODERN SYSTEMS INC.  COPYRIGHT 2000-2022
   **   DB-SHUTTLE COBOL to C# Conversion
   ************************************************************
   ** INIT   *  INITIAL VERSION   *  2022-03-02 04:49:22 PM
   **        *   FROM COBOL PGM   :  SWEXGW99
   **        *   FROM CANISTER    :  SR.CAECSES.PROD.LIBR.SOURCE.PDS
   ************************************************************ */

/* Original Program Identification Comments
*/
#endregion
#region Using Directives
using MDSY.Framework.Buffer;
using MDSY.Framework.Buffer.BaseClasses;
using MDSY.Framework.Buffer.Common;
using MDSY.Framework.Buffer.Interfaces;
using MDSY.Framework.Core;
using System;
#endregion

namespace GOV.KS.DCF.CSS.Common.BL
{
    #region Working Storage Class
    internal class SWEXGW99_ws : PredefinedRecordBase
    {
        #region Name constants
        /// <summary>
        /// Name constants.
        /// </summary>
        internal static class Names
        {
            internal const string WorkingStorage = "SWEXGW99_ws_WorkingStorage";
        }
        #endregion

        #region Direct-access element properties

        #endregion

        #region Data structure definition
        /// <summary>
        /// Defines the entirety of the WorkingStorage IRecord structure as described by the Ateras.Framework.Buffer API.
        /// </summary>
        /// <param name="recordDef">The IStructureDefinition object to be used in defining the record structure.</param>
        protected override void DefineRecordStructure(IStructureDefinition recordDef)
        {

        }

        protected override string GetRecordName()
        {
            return Names.WorkingStorage;
        }
        #endregion

    }
    #endregion Working Storage Class

    #region Linkage Section Class
    internal class SWEXGW99_ls : PredefinedRecordBase
    {
        #region Name constants
        /// <summary>
        /// Name constants.
        /// </summary>
        internal static class Names
        {
            internal const string LinkageSection = "SWEXGW99_ls_LinkageSection";
            internal const string W_IA = "W_IA";
            internal const string W_ONE = "W_ONE";
            internal const string IMPORT_0001EV = "IMPORT_0001EV";
            internal const string BB_FILE_0001ET = "BB_FILE_0001ET";
            internal const string ACTION_0001MS = "ACTION_0001MS";
            internal const string ACTION_0001 = "ACTION_0001";
            internal const string ACTION_0001XX = "ACTION_0001XX";
            internal const string W_IB = "W_IB";
            internal const string W_TWO = "W_TWO";
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
            internal const string W_THREE = "W_THREE";
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
            internal const string W_FOUR = "W_FOUR";
            internal const string EXPORT_0009EV = "EXPORT_0009EV";
            internal const string BB_FILE_0009ET = "BB_FILE_0009ET";
            internal const string STATUS_0009MS = "STATUS_0009MS";
            internal const string STATUS_0009 = "STATUS_0009";
            internal const string STATUS_0009XX = "STATUS_0009XX";
        }
        #endregion

        #region Direct-access element properties
        public IGroup W_IA { get { return GetElementByName<IGroup>(Names.W_IA); } }
        public IGroup W_ONE { get { return GetElementByName<IGroup>(Names.W_ONE); } }
        public IGroup IMPORT_0001EV { get { return GetElementByName<IGroup>(Names.IMPORT_0001EV); } }
        public IGroup BB_FILE_0001ET { get { return GetElementByName<IGroup>(Names.BB_FILE_0001ET); } }
        public IField ACTION_0001MS { get { return GetElementByName<IField>(Names.ACTION_0001MS); } }
        public IField ACTION_0001 { get { return GetElementByName<IField>(Names.ACTION_0001); } }
        public IField ACTION_0001XX { get { return GetElementByName<IField>(Names.ACTION_0001XX); } }
        public IGroup W_IB { get { return GetElementByName<IGroup>(Names.W_IB); } }
        public IGroup W_TWO { get { return GetElementByName<IGroup>(Names.W_TWO); } }
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
        public IGroup W_THREE { get { return GetElementByName<IGroup>(Names.W_THREE); } }
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
        public IGroup W_FOUR { get { return GetElementByName<IGroup>(Names.W_FOUR); } }
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
               W_IA.CreateNewGroup(Names.W_ONE, (W_ONE) =>
               {
                   W_ONE.CreateNewGroup(Names.IMPORT_0001EV, (IMPORT_0001EV) =>
                   {
                       IMPORT_0001EV.CreateNewGroup(Names.BB_FILE_0001ET, (BB_FILE_0001ET) =>
                       {
                           BB_FILE_0001ET.CreateNewField(Names.ACTION_0001MS, FieldType.String, 1);

                           IField ACTION_0001_local = BB_FILE_0001ET.CreateNewField(Names.ACTION_0001, FieldType.String, 8);
                           BB_FILE_0001ET.CreateNewFieldRedefine(Names.ACTION_0001XX, FieldType.String, ACTION_0001_local, 8);
                       });
                   });
               });
           });

            recordDef.CreateNewGroup(Names.W_IB, (W_IB) =>
           {
               W_IB.CreateNewGroup(Names.W_TWO, (W_TWO) =>
               {
                   W_TWO.CreateNewGroup(Names.IMPORT_0002EV, (IMPORT_0002EV) =>
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
           });

            recordDef.CreateNewGroup(Names.W_OA, (W_OA) =>
           {
               W_OA.CreateNewGroup(Names.W_THREE, (W_THREE) =>
               {
                   W_THREE.CreateNewGroup(Names.EXPORT_0008EV, (EXPORT_0008EV) =>
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
           });

            recordDef.CreateNewGroup(Names.W_OB, (W_OB) =>
           {
               W_OB.CreateNewGroup(Names.W_FOUR, (W_FOUR) =>
               {
                   W_FOUR.CreateNewGroup(Names.EXPORT_0009EV, (EXPORT_0009EV) =>
                   {
                       EXPORT_0009EV.CreateNewGroup(Names.BB_FILE_0009ET, (BB_FILE_0009ET) =>
                       {
                           BB_FILE_0009ET.CreateNewField(Names.STATUS_0009MS, FieldType.String, 1);

                           IField STATUS_0009_local = BB_FILE_0009ET.CreateNewField(Names.STATUS_0009, FieldType.String, 8);
                           BB_FILE_0009ET.CreateNewFieldRedefine(Names.STATUS_0009XX, FieldType.String, STATUS_0009_local, 8);
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
    public class SWEXGW99 : EABBase
    {

        #region Public Constructors
        public SWEXGW99()
            : base()
        {
            this.ProgramName.SetValue("SWEXGW99");

            WS = new SWEXGW99_ws();
            LS = new SWEXGW99_ls();
        }

        #endregion

        #region Private Fields


        //==== Working Storage Data Class ========================================
        private SWEXGW99_ws WS;

        //==== Linkage Section Data Class ========================================
        private SWEXGW99_ls LS;
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
            // EvaluateList !LS.REPORT_NUMBER_0002!                                                             //COBOL==> EVALUATE REPORT-NUMBER-0002
            if ((LS.REPORT_NUMBER_0002.IsEqualTo(1)))                                                           //COBOL==> WHEN 1
            {
                Control.Call("SWEXGP01", LS.W_IA, LS.W_IB, LS.W_OA, LS.W_OB); if (Control.ExitProgram) return;     //COBOL==> CALL 'SWEXGP01' USING W-IA , W-IB , W-OA , W-OB
            }                                                                                                //COBOL==> WHEN 2
            else
            if ((LS.REPORT_NUMBER_0002.IsEqualTo(2)))
            {
                Control.Call("SWEXGP02", LS.W_IA, LS.W_IB, LS.W_OA, LS.W_OB); if (Control.ExitProgram) return;     //COBOL==> CALL 'SWEXGP02' USING W-IA , W-IB , W-OA , W-OB
            }                                                                                                //COBOL==> WHEN 3
            else
            if ((LS.REPORT_NUMBER_0002.IsEqualTo(3)))
            {
                Control.Call("SWEXGP03", LS.W_IA, LS.W_IB, LS.W_OA, LS.W_OB); if (Control.ExitProgram) return;     //COBOL==> CALL 'SWEXGP03' USING W-IA , W-IB , W-OA , W-OB
            }                                                                                                //COBOL==> WHEN 4
            else
            if ((LS.REPORT_NUMBER_0002.IsEqualTo(4)))
            {
                Control.Call("SWEXGP04", LS.W_IA, LS.W_IB, LS.W_OA, LS.W_OB); if (Control.ExitProgram) return;     //COBOL==> CALL 'SWEXGP04' USING W-IA , W-IB , W-OA , W-OB
            }                                                                                                //COBOL==> WHEN 5
            else
            if ((LS.REPORT_NUMBER_0002.IsEqualTo(5)))
            {
                Control.Call("SWEXGP05", LS.W_IA, LS.W_IB, LS.W_OA, LS.W_OB); if (Control.ExitProgram) return;     //COBOL==> CALL 'SWEXGP05' USING W-IA , W-IB , W-OA , W-OB
            }                                                                                                //COBOL==> WHEN 6
            else
            if ((LS.REPORT_NUMBER_0002.IsEqualTo(6)))
            {
                Control.Call("SWEXGP06", LS.W_IA, LS.W_IB, LS.W_OA, LS.W_OB); if (Control.ExitProgram) return;     //COBOL==> CALL 'SWEXGP06' USING W-IA , W-IB , W-OA , W-OB
            }                                                                                                //COBOL==> WHEN 7
            else
            if ((LS.REPORT_NUMBER_0002.IsEqualTo(7)))
            {
                Control.Call("SWEXGP07", LS.W_IA, LS.W_IB, LS.W_OA, LS.W_OB); if (Control.ExitProgram) return;     //COBOL==> CALL 'SWEXGP07' USING W-IA , W-IB , W-OA , W-OB
            }                                                                                                //COBOL==> WHEN 8
            else
            if ((LS.REPORT_NUMBER_0002.IsEqualTo(8)))
            {
                Control.Call("SWEXGP08", LS.W_IA, LS.W_IB, LS.W_OA, LS.W_OB); if (Control.ExitProgram) return;     //COBOL==> CALL 'SWEXGP08' USING W-IA , W-IB , W-OA , W-OB
            }                                                                                                //COBOL==> WHEN 9
            else
            if ((LS.REPORT_NUMBER_0002.IsEqualTo(9)))
            {
                Control.Call("SWEXGP09", LS.W_IA, LS.W_IB, LS.W_OA, LS.W_OB); if (Control.ExitProgram) return;     //COBOL==> CALL 'SWEXGP09' USING W-IA , W-IB , W-OA , W-OB
            }                                                                                                //COBOL==> WHEN 10
            else
            if ((LS.REPORT_NUMBER_0002.IsEqualTo(10)))
            {
                Control.Call("SWEXGP10", LS.W_IA, LS.W_IB, LS.W_OA, LS.W_OB); if (Control.ExitProgram) return;     //COBOL==> CALL 'SWEXGP10' USING W-IA , W-IB , W-OA , W-OB
                                                                                                                   //COMMENT:       WHEN 11
                                                                                                                   //COMMENT:         CALL 'SWEXGP11' USING W-IA, W-IB, W-OA, W-OB
                                                                                                                   //COMMENT:       WHEN 12
                                                                                                                   //COMMENT:         CALL 'SWEXGP12' USING W-IA, W-IB, W-OA, W-OB
                                                                                                                   //COMMENT:       WHEN 13
                                                                                                                   //COMMENT:         CALL 'SWEXGP13' USING W-IA, W-IB, W-OA, W-OB
                                                                                                                   //COMMENT:       WHEN 14
                                                                                                                   //COMMENT:         CALL 'SWEXGP14' USING W-IA, W-IB, W-OA, W-OB
                                                                                                                   //COMMENT:       WHEN 15
                                                                                                                   //COMMENT:         CALL 'SWEXGP15' USING W-IA, W-IB, W-OA, W-OB
                                                                                                                   //COMMENT:       WHEN 16
                                                                                                                   //COMMENT:         CALL 'SWEXGP16' USING W-IA, W-IB, W-OA, W-OB
                                                                                                                   //COMMENT:       WHEN 17
                                                                                                                   //COMMENT:         CALL 'SWEXGP17' USING W-IA, W-IB, W-OA, W-OB
                                                                                                                   //COMMENT:       WHEN 18
                                                                                                                   //COMMENT:         CALL 'SWEXGP18' USING W-IA, W-IB, W-OA, W-OB
                                                                                                                   //COMMENT:       WHEN 19
                                                                                                                   //COMMENT:         CALL 'SWEXGP19' USING W-IA, W-IB, W-OA, W-OB
                                                                                                                   //COMMENT:       WHEN 20
                                                                                                                   //COMMENT:         CALL 'SWEXGP20' USING W-IA, W-IB, W-OA, W-OB
                                                                                                                   //COMMENT:       WHEN 21
                                                                                                                   //COMMENT:         CALL 'SWEXGP21' USING W-IA, W-IB, W-OA, W-OB
                                                                                                                   //COMMENT:       WHEN 22
                                                                                                                   //COMMENT:         CALL 'SWEXGP22' USING W-IA, W-IB, W-OA, W-OB
                                                                                                                   //COMMENT:       WHEN 23
                                                                                                                   //COMMENT:         CALL 'SWEXGP23' USING W-IA, W-IB, W-OA, W-OB
                                                                                                                   //COMMENT:       WHEN 24
                                                                                                                   //COMMENT:         CALL 'SWEXGP24' USING W-IA, W-IB, W-OA, W-OB
                                                                                                                   //COMMENT:       WHEN 25
                                                                                                                   //COMMENT:         CALL 'SWEXGP25' USING W-IA, W-IB, W-OA, W-OB
                                                                                                                   //COMMENT:       WHEN 26
                                                                                                                   //COMMENT:         CALL 'SWEXGP26' USING W-IA, W-IB, W-OA, W-OB
                                                                                                                   //COMMENT:       WHEN 27
                                                                                                                   //COMMENT:         CALL 'SWEXGP27' USING W-IA, W-IB, W-OA, W-OB
                                                                                                                   //COMMENT:       WHEN 28
                                                                                                                   //COMMENT:         CALL 'SWEXGP28' USING W-IA, W-IB, W-OA, W-OB
                                                                                                                   //COMMENT:       WHEN 29
                                                                                                                   //COMMENT:         CALL 'SWEXGP29' USING W-IA, W-IB, W-OA, W-OB
            }                                                                                                //COBOL==> WHEN 98
            else
            if ((LS.REPORT_NUMBER_0002.IsEqualTo(98)))
            {
                Control.Call("SWEXGP98", LS.W_IA, LS.W_IB, LS.W_OA, LS.W_OB); if (Control.ExitProgram) return;     //COBOL==> CALL 'SWEXGP98' USING W-IA , W-IB , W-OA , W-OB
            }                                                                                                //COBOL==> WHEN 99
            else
            if ((LS.REPORT_NUMBER_0002.IsEqualTo(99)))
            {
                Control.Call("SWEXGP99", LS.W_IA, LS.W_IB, LS.W_OA, LS.W_OB); if (Control.ExitProgram) return;     //COBOL==> CALL 'SWEXGP99' USING W-IA , W-IB , W-OA , W-OB
            }                                                                                                //COBOL==> WHEN OTHER
            else
            {
                LS.STATUS_0009.SetValue("ABEND");                                                                   //COBOL==> MOVE 'ABEND' TO STATUS-0009.
            }
            if (returnMethod != "" && returnMethod != "M_PARA_0341837336") { M_PARA_0341837336_EXIT(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_PARA_0341837336_EXIT
        /// </summary>
        private void M_PARA_0341837336_EXIT(string returnMethod = "")
        {
            if (returnMethod == "M_PARA_0341837336_EXIT") { return; }                                           //COBOL==> EXIT.
        }
        #endregion
    }
    #endregion
}
