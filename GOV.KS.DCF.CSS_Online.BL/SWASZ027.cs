#region Comments
/* Conversion Comments
   ************************************************************
   **   MODERN SYSTEMS INC.  COPYRIGHT 2000-2022
   **   DB-SHUTTLE COBOL to C# Conversion
   ************************************************************
   ** INIT   *  INITIAL VERSION   *  2022-01-14 12:46:13 PM
   **        *   FROM COBOL PGM   :  SWASZ027
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
using MDSY.Framework.Core;
using System;
#endregion

namespace GOV.KS.DCF.CSS.Online.BL
{
    #region Working Storage Class
    internal class SWASZ027_ws : PredefinedRecordBase
    {
        #region Name constants
        /// <summary>
        /// Name constants.
        /// </summary>
        internal static class Names
        {
            internal const string WorkingStorage = "SWASZ027_ws_WorkingStorage";
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
            internal const string MODULE_VARIABLES = "MODULE_VARIABLES";
            internal const string MV_LEAP_YEAR = "MV_LEAP_YEAR";
            internal const string MV_JULIAN_DATE = "MV_JULIAN_DATE";
            internal const string MV_JULIAN_YY = "MV_JULIAN_YY";
            internal const string MV_JULIAN_DDD = "MV_JULIAN_DDD";
            internal const string MV_JULIAN_Y1 = "MV_JULIAN_Y1";
            internal const string MV_JULIAN_Y2 = "MV_JULIAN_Y2";
        }
        #endregion

        #region Direct-access element properties
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
        public IGroup MODULE_VARIABLES { get { return GetElementByName<IGroup>(Names.MODULE_VARIABLES); } }
        public IField MV_LEAP_YEAR { get { return GetElementByName<IField>(Names.MV_LEAP_YEAR); } }
        public IField MV_JULIAN_DATE { get { return GetElementByName<IField>(Names.MV_JULIAN_DATE); } }
        public IField MV_JULIAN_YY { get { return GetElementByName<IField>(Names.MV_JULIAN_YY); } }
        public IField MV_JULIAN_DDD { get { return GetElementByName<IField>(Names.MV_JULIAN_DDD); } }
        public IField MV_JULIAN_Y1 { get { return GetElementByName<IField>(Names.MV_JULIAN_Y1); } }
        public IField MV_JULIAN_Y2 { get { return GetElementByName<IField>(Names.MV_JULIAN_Y2); } }

        #endregion

        #region Data structure definition
        /// <summary>
        /// Defines the entirety of the WorkingStorage IRecord structure as described by the Ateras.Framework.Buffer API.
        /// </summary>
        /// <param name="recordDef">The IStructureDefinition object to be used in defining the record structure.</param>
        protected override void DefineRecordStructure(IStructureDefinition recordDef)
        {

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

            recordDef.CreateNewGroup(Names.MODULE_VARIABLES, (MODULE_VARIABLES) =>
           {
               MODULE_VARIABLES.CreateNewField(Names.MV_LEAP_YEAR, FieldType.String, 1);

               IField MV_JULIAN_DATE_local = MODULE_VARIABLES.CreateNewField(Names.MV_JULIAN_DATE, FieldType.UnsignedNumeric, 5);
               MODULE_VARIABLES.CreateNewGroupRedefine("FILLER", MV_JULIAN_DATE_local, (FILLER) =>
               {
                   FILLER.CreateNewField(Names.MV_JULIAN_YY, FieldType.UnsignedNumeric, 2);
                   FILLER.CreateNewField(Names.MV_JULIAN_DDD, FieldType.UnsignedNumeric, 3);
               });
               MODULE_VARIABLES.CreateNewGroupRedefine("FILLER_d2", MV_JULIAN_DATE_local, (FILLER_d2) =>
               {
                   FILLER_d2.CreateNewField(Names.MV_JULIAN_Y1, FieldType.UnsignedNumeric, 1);
                   FILLER_d2.CreateNewField(Names.MV_JULIAN_Y2, FieldType.UnsignedNumeric, 1);
               });
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
    internal class SWASZ027_ls : PredefinedRecordBase
    {
        #region Name constants
        /// <summary>
        /// Name constants.
        /// </summary>
        internal static class Names
        {
            internal const string LinkageSection = "SWASZ027_ls_LinkageSection";
            internal const string PV_JULIAN_DATE = "PV_JULIAN_DATE";
            internal const string PV_DB_DATE = "PV_DB_DATE";
            internal const string PV_DB_CC = "PV_DB_CC";
            internal const string PV_DB_YY = "PV_DB_YY";
            internal const string PV_DB_MM = "PV_DB_MM";
            internal const string PV_DB_DD = "PV_DB_DD";
        }
        #endregion

        #region Direct-access element properties
        public IField PV_JULIAN_DATE { get { return GetElementByName<IField>(Names.PV_JULIAN_DATE); } }
        public IGroup PV_DB_DATE { get { return GetElementByName<IGroup>(Names.PV_DB_DATE); } }
        public IField PV_DB_CC { get { return GetElementByName<IField>(Names.PV_DB_CC); } }
        public IField PV_DB_YY { get { return GetElementByName<IField>(Names.PV_DB_YY); } }
        public IField PV_DB_MM { get { return GetElementByName<IField>(Names.PV_DB_MM); } }
        public IField PV_DB_DD { get { return GetElementByName<IField>(Names.PV_DB_DD); } }

        #endregion

        #region Data structure definition
        /// <summary>
        /// Defines the entirety of the LinkageSection IRecord structure as described by the Ateras.Framework.Buffer API.
        /// </summary>
        /// <param name="recordDef">The IStructureDefinition object to be used in defining the record structure.</param>
        protected override void DefineRecordStructure(IStructureDefinition recordDef)
        {
            recordDef.CreateNewField(Names.PV_JULIAN_DATE, FieldType.PackedDecimal, 7);

            recordDef.CreateNewGroup(Names.PV_DB_DATE, (PV_DB_DATE) =>
           {
               PV_DB_DATE.CreateNewField(Names.PV_DB_CC, FieldType.UnsignedNumeric, 2);
               PV_DB_DATE.CreateNewField(Names.PV_DB_YY, FieldType.UnsignedNumeric, 2);
               PV_DB_DATE.CreateNewField(Names.PV_DB_MM, FieldType.UnsignedNumeric, 2);
               PV_DB_DATE.CreateNewField(Names.PV_DB_DD, FieldType.UnsignedNumeric, 2);
           });

        }

        protected override string GetRecordName()
        {
            return Names.LinkageSection;
        }
        #endregion

        public void SetPassedParameters(object[] args)
        {
            SetPassedParm(PV_JULIAN_DATE, args, 0);
            SetPassedParm(PV_DB_DATE, args, 1);
        }


        public void UpdateReturnParameters(object[] args)
        {
            SetReturnParm(PV_JULIAN_DATE, args, 0);
            SetReturnParm(PV_DB_DATE, args, 1);
        }
    }
    #endregion Linkage Section Class

    #region Business Logic Class
    public class SWASZ027 : BatchBase
    {

        #region Public Constructors
        public SWASZ027()
            : base()
        {
            this.ProgramName.SetValue("SWASZ027");

            WS = new SWASZ027_ws();
            LS = new SWASZ027_ls();
        }

        #endregion

        #region Private Fields


        //==== Working Storage Data Class ========================================
        private SWASZ027_ws WS;

        //==== Linkage Section Data Class ========================================
        private SWASZ027_ls LS;
        #endregion

        #region Public Methods
        //========================================================================
        //==== RunMain Entry Point Method ========================================
        //========================================================================
        public override int ExecuteMain(params object[] args)                                              //COBOL==> PROCEDURE DIVISION USING PV-JULIAN-DATE PV-DB-DATE.
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
            M_0000_FORMAT_DATE(returnMethod);
        }
        /// <summary>
        /// Method M_0000_FORMAT_DATE
        /// </summary>
        private void M_0000_FORMAT_DATE(string returnMethod = "")
        {
            //COMMENT: ***
            //COMMENT: *** FORMAT JULIAN DATE (YYDDD) TO DATABASE DATE (YYYYMMDD)
            //COMMENT: ***
            //COMMENT: *** THIS ROUTINE WOULD BE EASILY ACHIEVED BY USING AN ARRAY
            //COMMENT: *** EXCEPT THAT MORE WORKING STORAGE WOULD BE REQUIRED.
            //COMMENT: *** VS-COBOL-II WILL TREAT THIS PROGRAM AS RE-ENTRANT SO
            //COMMENT: *** THE LESS WORKING STORAGE THE BETTER.  SINCE THIS MODULE
            //COMMENT: *** IS INCLUDED INTO A CONTROL ROUTINE WHICH EVERY PROGRAM
            //COMMENT: *** IN THE SYSTEM USES EACH TERMINAL USER GETS A COPY OF THIS
            //COMMENT: *** MODULES WORKING STORAGE.  THIS MAKES THE ACTUAL WORKING
            //COMMENT: *** STORAGE REQUIREMENTS OF THIS MODULE EQUAL TO ITS WORKING
            //COMMENT: *** STORAGE SIZE TIMES THE NUMBER OF TERMINAL USERS.
            //COMMENT: ***
            WS.MV_JULIAN_DATE.SetValue(LS.PV_JULIAN_DATE);                                                      //COBOL==> MOVE PV-JULIAN-DATE TO MV-JULIAN-DATE.
                                                                                                                //COMMENT: *****************************************************************
                                                                                                                //COMMENT: CTA Y2K TSCTA47 03/19/98 09:16:11                               *
                                                                                                                //COMMENT:   THE FOLLOWING LINE WAS COMMENTED OUT TO ACCOMMODATE YEAR 2000 *
                                                                                                                //COMMENT:   CONVERSIONS                                                   *
                                                                                                                //COMMENT: *****************************************************************
                                                                                                                //COMMENT: *   MOVE     19      TO PV-DB-CC.                              **
                                                                                                                //COMMENT: *****************************************************************
                                                                                                                //COMMENT: CTA Y2K TSCTA47 03/19/98 09:17:34                               *
                                                                                                                //COMMENT:   THE FOLLOWING THREE LINES WERE INSERTED TO BETTER             *
                                                                                                                //COMMENT:   ACCOMMODATE YEAR 2000 CONVERSIONS.                            *
                                                                                                                //COMMENT: *****************************************************************
            WS.Y2K_JUL_IN.SetValue(WS.MV_JULIAN_DATE);                                                          //COBOL==> MOVE MV-JULIAN-DATE TO Y2K-JUL-IN.
            M_Z930_JULIAN_ROUTINE("M_Z930_JULIAN_ROUTINE_EXIT"); if (Control.ExitProgram) { return; }             //COBOL==> PERFORM Z930-JULIAN-ROUTINE THRU Z930-JULIAN-ROUTINE-EXIT.
            LS.PV_DB_CC.SetValue(WS.Y2K_JUL_CC);                                                                //COBOL==> MOVE Y2K-JUL-CC TO PV-DB-CC.
            LS.PV_DB_YY.SetValue(WS.MV_JULIAN_YY);                                                              //COBOL==> MOVE MV-JULIAN-YY TO PV-DB-YY.
                                                                                                                //COMMENT:     --------- JANUARY -----------
            if (WS.MV_JULIAN_DDD.IsGreaterThan(31))                                                             //COBOL==> IF MV-JULIAN-DDD > 31
            {
                WS.MV_JULIAN_DDD.SetValue(WS.MV_JULIAN_DDD.AsInt() - 31);                                           //COBOL==> SUBTRACT 31 FROM MV-JULIAN-DDD
            }                                                                                                   //COBOL==> ELSE
            else
            {
                LS.PV_DB_MM.SetValue(01);                                                                           //COBOL==> MOVE 01 TO PV-DB-MM
                LS.PV_DB_DD.SetValue(WS.MV_JULIAN_DDD);                                                             //COBOL==> MOVE MV-JULIAN-DDD TO PV-DB-DD
                M_0000_EXIT(CheckGotoReturn(returnMethod)); return;                                                 //COBOL==> GO TO 0000-EXIT.
            }
            M_2000_DETERMINE_LEAP_YEAR("M_2000_EXIT"); if (Control.ExitProgram) { return; }                       //COBOL==> PERFORM 2000-DETERMINE-LEAP-YEAR THRU 2000-EXIT.
                                                                                                                  //COMMENT:     --------- FEBRUARY ----------
            if (WS.MV_LEAP_YEAR.IsEqualTo("Y"))                                                                 //COBOL==> IF MV-LEAP-YEAR = 'Y'
            {
                if (WS.MV_JULIAN_DDD.IsGreaterThan(29))                                                             //COBOL==> IF MV-JULIAN-DDD > 29
                {
                    WS.MV_JULIAN_DDD.SetValue(WS.MV_JULIAN_DDD.AsInt() - 29);                                           //COBOL==> SUBTRACT 29 FROM MV-JULIAN-DDD
                }                                                                                                   //COBOL==> ELSE
                else
                {
                    LS.PV_DB_MM.SetValue(02);                                                                           //COBOL==> MOVE 02 TO PV-DB-MM
                    LS.PV_DB_DD.SetValue(WS.MV_JULIAN_DDD);                                                             //COBOL==> MOVE MV-JULIAN-DDD TO PV-DB-DD
                    M_0000_EXIT(CheckGotoReturn(returnMethod)); return;                                                 //COBOL==> GO TO 0000-EXIT
                }                                                                                                   //COBOL==> ELSE
            }
            else
            {
                if (WS.MV_JULIAN_DDD.IsGreaterThan(28))                                                             //COBOL==> IF MV-JULIAN-DDD > 28
                {
                    WS.MV_JULIAN_DDD.SetValue(WS.MV_JULIAN_DDD.AsInt() - 28);                                           //COBOL==> SUBTRACT 28 FROM MV-JULIAN-DDD
                }                                                                                                   //COBOL==> ELSE
                else
                {
                    LS.PV_DB_MM.SetValue(02);                                                                           //COBOL==> MOVE 02 TO PV-DB-MM
                    LS.PV_DB_DD.SetValue(WS.MV_JULIAN_DDD);                                                             //COBOL==> MOVE MV-JULIAN-DDD TO PV-DB-DD
                    M_0000_EXIT(CheckGotoReturn(returnMethod)); return;                                                 //COBOL==> GO TO 0000-EXIT.
                }
            }
            //COMMENT:     --------- MARCH -------------
            if (WS.MV_JULIAN_DDD.IsGreaterThan(31))                                                             //COBOL==> IF MV-JULIAN-DDD > 31
            {
                WS.MV_JULIAN_DDD.SetValue(WS.MV_JULIAN_DDD.AsInt() - 31);                                           //COBOL==> SUBTRACT 31 FROM MV-JULIAN-DDD
            }                                                                                                   //COBOL==> ELSE
            else
            {
                LS.PV_DB_MM.SetValue(03);                                                                           //COBOL==> MOVE 03 TO PV-DB-MM
                LS.PV_DB_DD.SetValue(WS.MV_JULIAN_DDD);                                                             //COBOL==> MOVE MV-JULIAN-DDD TO PV-DB-DD
                M_0000_EXIT(CheckGotoReturn(returnMethod)); return;                                                 //COBOL==> GO TO 0000-EXIT.
            }
            //COMMENT:     --------- APRIL -------------
            if (WS.MV_JULIAN_DDD.IsGreaterThan(30))                                                             //COBOL==> IF MV-JULIAN-DDD > 30
            {
                WS.MV_JULIAN_DDD.SetValue(WS.MV_JULIAN_DDD.AsInt() - 30);                                           //COBOL==> SUBTRACT 30 FROM MV-JULIAN-DDD
            }                                                                                                   //COBOL==> ELSE
            else
            {
                LS.PV_DB_MM.SetValue(04);                                                                           //COBOL==> MOVE 04 TO PV-DB-MM
                LS.PV_DB_DD.SetValue(WS.MV_JULIAN_DDD);                                                             //COBOL==> MOVE MV-JULIAN-DDD TO PV-DB-DD
                M_0000_EXIT(CheckGotoReturn(returnMethod)); return;                                                 //COBOL==> GO TO 0000-EXIT.
            }
            //COMMENT:     --------- MAY ---------------
            if (WS.MV_JULIAN_DDD.IsGreaterThan(31))                                                             //COBOL==> IF MV-JULIAN-DDD > 31
            {
                WS.MV_JULIAN_DDD.SetValue(WS.MV_JULIAN_DDD.AsInt() - 31);                                           //COBOL==> SUBTRACT 31 FROM MV-JULIAN-DDD
            }                                                                                                   //COBOL==> ELSE
            else
            {
                LS.PV_DB_MM.SetValue(05);                                                                           //COBOL==> MOVE 05 TO PV-DB-MM
                LS.PV_DB_DD.SetValue(WS.MV_JULIAN_DDD);                                                             //COBOL==> MOVE MV-JULIAN-DDD TO PV-DB-DD
                M_0000_EXIT(CheckGotoReturn(returnMethod)); return;                                                 //COBOL==> GO TO 0000-EXIT.
            }
            //COMMENT:     --------- JUNE --------------
            if (WS.MV_JULIAN_DDD.IsGreaterThan(30))                                                             //COBOL==> IF MV-JULIAN-DDD > 30
            {
                WS.MV_JULIAN_DDD.SetValue(WS.MV_JULIAN_DDD.AsInt() - 30);                                           //COBOL==> SUBTRACT 30 FROM MV-JULIAN-DDD
            }                                                                                                   //COBOL==> ELSE
            else
            {
                LS.PV_DB_MM.SetValue(06);                                                                           //COBOL==> MOVE 06 TO PV-DB-MM
                LS.PV_DB_DD.SetValue(WS.MV_JULIAN_DDD);                                                             //COBOL==> MOVE MV-JULIAN-DDD TO PV-DB-DD
                M_0000_EXIT(CheckGotoReturn(returnMethod)); return;                                                 //COBOL==> GO TO 0000-EXIT.
            }
            //COMMENT:     --------- JULY --------------
            if (WS.MV_JULIAN_DDD.IsGreaterThan(31))                                                             //COBOL==> IF MV-JULIAN-DDD > 31
            {
                WS.MV_JULIAN_DDD.SetValue(WS.MV_JULIAN_DDD.AsInt() - 31);                                           //COBOL==> SUBTRACT 31 FROM MV-JULIAN-DDD
            }                                                                                                   //COBOL==> ELSE
            else
            {
                LS.PV_DB_MM.SetValue(07);                                                                           //COBOL==> MOVE 07 TO PV-DB-MM
                LS.PV_DB_DD.SetValue(WS.MV_JULIAN_DDD);                                                             //COBOL==> MOVE MV-JULIAN-DDD TO PV-DB-DD
                M_0000_EXIT(CheckGotoReturn(returnMethod)); return;                                                 //COBOL==> GO TO 0000-EXIT.
            }
            //COMMENT:     --------- AUGUST ------------
            if (WS.MV_JULIAN_DDD.IsGreaterThan(31))                                                             //COBOL==> IF MV-JULIAN-DDD > 31
            {
                WS.MV_JULIAN_DDD.SetValue(WS.MV_JULIAN_DDD.AsInt() - 31);                                           //COBOL==> SUBTRACT 31 FROM MV-JULIAN-DDD
            }                                                                                                   //COBOL==> ELSE
            else
            {
                LS.PV_DB_MM.SetValue(08);                                                                           //COBOL==> MOVE 08 TO PV-DB-MM
                LS.PV_DB_DD.SetValue(WS.MV_JULIAN_DDD);                                                             //COBOL==> MOVE MV-JULIAN-DDD TO PV-DB-DD
                M_0000_EXIT(CheckGotoReturn(returnMethod)); return;                                                 //COBOL==> GO TO 0000-EXIT.
            }
            //COMMENT:     --------- SEPTEMBER ---------
            if (WS.MV_JULIAN_DDD.IsGreaterThan(30))                                                             //COBOL==> IF MV-JULIAN-DDD > 30
            {
                WS.MV_JULIAN_DDD.SetValue(WS.MV_JULIAN_DDD.AsInt() - 30);                                           //COBOL==> SUBTRACT 30 FROM MV-JULIAN-DDD
            }                                                                                                   //COBOL==> ELSE
            else
            {
                LS.PV_DB_MM.SetValue(09);                                                                           //COBOL==> MOVE 09 TO PV-DB-MM
                LS.PV_DB_DD.SetValue(WS.MV_JULIAN_DDD);                                                             //COBOL==> MOVE MV-JULIAN-DDD TO PV-DB-DD
                M_0000_EXIT(CheckGotoReturn(returnMethod)); return;                                                 //COBOL==> GO TO 0000-EXIT.
            }
            //COMMENT:     --------- OCTOBER -----------
            if (WS.MV_JULIAN_DDD.IsGreaterThan(31))                                                             //COBOL==> IF MV-JULIAN-DDD > 31
            {
                WS.MV_JULIAN_DDD.SetValue(WS.MV_JULIAN_DDD.AsInt() - 31);                                           //COBOL==> SUBTRACT 31 FROM MV-JULIAN-DDD
            }                                                                                                   //COBOL==> ELSE
            else
            {
                LS.PV_DB_MM.SetValue(10);                                                                           //COBOL==> MOVE 10 TO PV-DB-MM
                LS.PV_DB_DD.SetValue(WS.MV_JULIAN_DDD);                                                             //COBOL==> MOVE MV-JULIAN-DDD TO PV-DB-DD
                M_0000_EXIT(CheckGotoReturn(returnMethod)); return;                                                 //COBOL==> GO TO 0000-EXIT.
            }
            //COMMENT:     --------- NOVEMBER ----------
            if (WS.MV_JULIAN_DDD.IsGreaterThan(30))                                                             //COBOL==> IF MV-JULIAN-DDD > 30
            {
                WS.MV_JULIAN_DDD.SetValue(WS.MV_JULIAN_DDD.AsInt() - 30);                                           //COBOL==> SUBTRACT 30 FROM MV-JULIAN-DDD
            }                                                                                                   //COBOL==> ELSE
            else
            {
                LS.PV_DB_MM.SetValue(11);                                                                           //COBOL==> MOVE 11 TO PV-DB-MM
                LS.PV_DB_DD.SetValue(WS.MV_JULIAN_DDD);                                                             //COBOL==> MOVE MV-JULIAN-DDD TO PV-DB-DD
                M_0000_EXIT(CheckGotoReturn(returnMethod)); return;                                                 //COBOL==> GO TO 0000-EXIT.
            }
            //COMMENT:     --------- DECEMBER ----------
            if (WS.MV_JULIAN_DDD.IsGreaterThan(31))                                                             //COBOL==> IF MV-JULIAN-DDD > 31
            {
                WS.MV_JULIAN_DDD.SetValue(WS.MV_JULIAN_DDD.AsInt() - 31);                                           //COBOL==> SUBTRACT 31 FROM MV-JULIAN-DDD
            }                                                                                                   //COBOL==> ELSE
            else
            {
                LS.PV_DB_MM.SetValue(12);                                                                           //COBOL==> MOVE 12 TO PV-DB-MM
                LS.PV_DB_DD.SetValue(WS.MV_JULIAN_DDD);                                                             //COBOL==> MOVE MV-JULIAN-DDD TO PV-DB-DD
                M_0000_EXIT(CheckGotoReturn(returnMethod)); return;                                                 //COBOL==> GO TO 0000-EXIT.
            }
            if (returnMethod != "" && returnMethod != "M_0000_FORMAT_DATE") { M_0000_EXIT(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_0000_EXIT
        /// </summary>
        private void M_0000_EXIT(string returnMethod = "")
        {
            Control.ExitProgram = true; return;                                                                 //COBOL==> GOBACK.
        }
        /// <summary>
        /// Method M_2000_DETERMINE_LEAP_YEAR
        /// </summary>
        private void M_2000_DETERMINE_LEAP_YEAR(string returnMethod = "")
        {
            WS.MV_LEAP_YEAR.SetValue("N");                                                                      //COBOL==> MOVE 'N' TO MV-LEAP-YEAR.
            if (((((WS.MV_JULIAN_Y1.IsEqualTo(1))
             || (WS.MV_JULIAN_Y1.IsEqualTo(3)))
             || (WS.MV_JULIAN_Y1.IsEqualTo(5)))
             || (WS.MV_JULIAN_Y1.IsEqualTo(7)))
             || (WS.MV_JULIAN_Y1.IsEqualTo(9)))  //COBOL==> IF MV-JULIAN-Y1 = 1 OR 3 OR 5 OR 7 OR 9
            {
                if ((WS.MV_JULIAN_Y2.IsEqualTo(2))
             || (WS.MV_JULIAN_Y2.IsEqualTo(6)))               //COBOL==> IF MV-JULIAN-Y2 = 2 OR 6
                {
                    WS.MV_LEAP_YEAR.SetValue("Y");                                                                      //COBOL==> MOVE 'Y' TO MV-LEAP-YEAR
                }                                                                                                   //COBOL==> ELSE
                else
                {
                    goto EndOfSentence_1;                                                                               //COBOL==> NEXT SENTENCE
                }                                                                                                   //COBOL==> ELSE
            }
            else
            {
                if (((WS.MV_JULIAN_Y2.IsEqualTo(0))
             || (WS.MV_JULIAN_Y2.IsEqualTo(4)))
             || (WS.MV_JULIAN_Y2.IsEqualTo(8)))  //COBOL==> IF MV-JULIAN-Y2 = 0 OR 4 OR 8
                {
                    WS.MV_LEAP_YEAR.SetValue("Y");                                                                      //COBOL==> MOVE 'Y' TO MV-LEAP-YEAR.
                }
            }
        EndOfSentence_1:;
            if (returnMethod != "" && returnMethod != "M_2000_DETERMINE_LEAP_YEAR") { M_2000_EXIT(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_2000_EXIT
        /// </summary>
        private void M_2000_EXIT(string returnMethod = "")
        {
            if (returnMethod != "" && returnMethod != "M_2000_EXIT") { M_Z900_CCFY_ROUTINE(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_Z900_CCFY_ROUTINE
        /// </summary>
        /// <remarks>
        ///COMMENT: *****************************************************************
        ///COMMENT: CTA Y2K TSCTA47 03/19/98 10:09:18                               *
        ///COMMENT:  THE FOLLOWING INCLUDE STATEMENT WAS INSERTED TO ACCOMMODATE    *
        ///COMMENT:  YEAR 2000 CONVERSIONS.                                         *
        ///COMMENT: *****************************************************************
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
