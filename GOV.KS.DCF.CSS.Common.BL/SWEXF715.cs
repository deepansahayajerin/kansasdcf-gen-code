#region Comments
/* Conversion Comments
   ************************************************************
   **   MODERN SYSTEMS INC.  COPYRIGHT 2000-2021
   **   DB-SHUTTLE COBOL to C# Conversion
   ************************************************************
   ** INIT   *  INITIAL VERSION   *  2021-12-07 03:10:10 PM
   **        *   FROM COBOL PGM   :  SWEXF715
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
    internal class SWEXF715_fd : PredefinedRecordBase
    {
        #region Name constants
        /// <summary>
        /// Name constants.
        /// </summary>
        internal static class Names
        {
            internal const string FileSection = "SWEXF715_fd_FileSection";
            internal const string SEQ_FILE = "SEQ_FILE";
            internal const string SEQFILE_REC = "SEQFILE_REC";
        }
        #endregion

        #region Direct-access element properties
        public IFileLink SEQ_FILE { get; set; }
        public IField SEQFILE_REC { get { return GetElementByName<IField>(Names.SEQFILE_REC); } }


        internal SWEXF715_ws WS;
        #endregion

        #region Data structure definition
        /// <summary>
        /// Defines the entirety of the FileSection IRecord structure as described by the Ateras.Framework.Buffer API.
        /// </summary>
        /// <param name="recordDef">The IStructureDefinition object to be used in defining the record structure.</param>
        protected override void DefineRecordStructure(IStructureDefinition recordDef)
        {
            recordDef.CreateNewField(Names.SEQFILE_REC, FieldType.String, 401);

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

            SEQ_FILE = FileHandler.GetFile("CASEEXTR");
            SEQ_FILE.StatusField = WS.WS_FILE_STATUS;
            SEQ_FILE.AssociatedBuffer = SEQFILE_REC;
            SEQ_FILE.RecordLength = 401;
        }
        #endregion

        #region Constructors
        public SWEXF715_fd(SWEXF715_ws ws)
            : base()
        {
            this.WS = ws;
            Initialize();

        }
        #endregion
    }
    #endregion File Section Class
    #region Working Storage Class
    internal class SWEXF715_ws : PredefinedRecordBase
    {
        #region Name constants
        /// <summary>
        /// Name constants.
        /// </summary>
        internal static class Names
        {
            internal const string WorkingStorage = "SWEXF715_ws_WorkingStorage";
            internal const string WS_FILE_STATUS = "WS_FILE_STATUS";
            internal const string WS_SEQFILE_REC = "WS_SEQFILE_REC";
            internal const string WS1_DTL_FOR_LN_X = "WS1_DTL_FOR_LN_X";
            internal const string WS16_C_NBR_X = "WS16_C_NBR_X";
            internal const string WS26_C_STAT_X = "WS26_C_STAT_X";
            internal const string WS27_C_STAT_DT_X = "WS27_C_STAT_DT_X";
            internal const string WS27_C_STAT_DT_9 = "WS27_C_STAT_DT_9";
            internal const string WS35_C_OPN_DT_X = "WS35_C_OPN_DT_X";
            internal const string WS35_C_OPN_DT_9 = "WS35_C_OPN_DT_9";
            internal const string WS43_CR_ID_X = "WS43_CR_ID_X";
            internal const string WS43_CR_ID_9 = "WS43_CR_ID_9";
            internal const string WS46_CR_TYP_X = "WS46_CR_TYP_X";
            internal const string WS48_CR_STRT_DT_X = "WS48_CR_STRT_DT_X";
            internal const string WS48_CR_STRT_DT_9 = "WS48_CR_STRT_DT_9";
            internal const string WS56_CR_END_DT_X = "WS56_CR_END_DT_X";
            internal const string WS56_CR_END_DT_9 = "WS56_CR_END_DT_9";
            internal const string WS64_CP_TYP_X = "WS64_CP_TYP_X";
            internal const string WS65_CP_NBR_X = "WS65_CP_NBR_X";
            internal const string WS75_PP_CRTD_TMST_X = "WS75_PP_CRTD_TMST_X";
            internal const string WS95_PP_EFF_DT_X = "WS95_PP_EFF_DT_X";
            internal const string WS95_PP_EFF_DT_9 = "WS95_PP_EFF_DT_9";
            internal const string WS103_PP_DISC_DT_X = "WS103_PP_DISC_DT_X";
            internal const string WS103_PP_DISC_DT_9 = "WS103_PP_DISC_DT_9";
            internal const string WS111_P_CD_X = "WS111_P_CD_X";
            internal const string WS114_P_EFF_DT_X = "WS114_P_EFF_DT_X";
            internal const string WS114_P_EFF_DT_9 = "WS114_P_EFF_DT_9";
            internal const string WS122_P_DISC_DT_X = "WS122_P_DISC_DT_X";
            internal const string WS122_P_DISC_DT_9 = "WS122_P_DISC_DT_9";
            internal const string WS130_LACR_CRTD_TS_X = "WS130_LACR_CRTD_TS_X";
            internal const string WS150_LA_ID_X = "WS150_LA_ID_X";
            internal const string WS150_LA_ID_9 = "WS150_LA_ID_9";
            internal const string WS159_LA_ACT_TKN_X = "WS159_LA_ACT_TKN_X";
            internal const string WS189_LA_CRTD_TSTA_X = "WS189_LA_CRTD_TSTA_X";
            internal const string WS209_LA_FLD_DT_X = "WS209_LA_FLD_DT_X";
            internal const string WS209_LA_FLD_DT_9 = "WS209_LA_FLD_DT_9";
            internal const string WS217_LAD_NBR_X = "WS217_LAD_NBR_X";
            internal const string WS217_LAD_NBR_9 = "WS217_LAD_NBR_9";
            internal const string WS219_LAD_DTL_TYP_X = "WS219_LAD_DTL_TYP_X";
            internal const string WS220_LAD_CRTD_TST_X = "WS220_LAD_CRTD_TST_X";
            internal const string WS240_LAD_NON_FIN_OBL_X = "WS240_LAD_NON_FIN_OBL_X";
            internal const string WS244_OT_CD_X = "WS244_OT_CD_X";
            internal const string WS251_OT_CLS_X = "WS251_OT_CLS_X";
            internal const string WS252_DD_DUE_DT_X = "WS252_DD_DUE_DT_X";
            internal const string WS252_DD_DUE_DT_9 = "WS252_DD_DUE_DT_9";
            internal const string WS260_DD_BAL_DUE_X = "WS260_DD_BAL_DUE_X";
            internal const string WS260_DD_BAL_DUE_9 = "WS260_DD_BAL_DUE_9";
            internal const string WS269_DD_INT_BAL_X = "WS269_DD_INT_BAL_X";
            internal const string WS269_DD_INT_BAL_9 = "WS269_DD_INT_BAL_9";
            internal const string WS275_DD_CRTD_TMST_X = "WS275_DD_CRTD_TMST_X";
            internal const string WS295_CPA_TYP_X = "WS295_CPA_TYP_X";
            internal const string WS296_CPA_CRTD_TMS_X = "WS296_CPA_CRTD_TMS_X";
            internal const string WS316_OB_TRN_ID_X = "WS316_OB_TRN_ID_X";
            internal const string WS316_OB_TRN_ID_9 = "WS316_OB_TRN_ID_9";
            internal const string WS325_OB_TRN_TYP_X = "WS325_OB_TRN_TYP_X";
            internal const string WS327_OB_TRN_CRTD_X = "WS327_OB_TRN_CRTD_X";
            internal const string WS347_OB_ID_X = "WS347_OB_ID_X";
            internal const string WS347_OB_ID_9 = "WS347_OB_ID_9";
            internal const string WS350_OB_CRTD_TMST_X = "WS350_OB_CRTD_TMST_X";
            internal const string WS370_COLL_ID_X = "WS370_COLL_ID_X";
            internal const string WS370_COLL_ID_9 = "WS370_COLL_ID_9";
            internal const string WS379_COLL_APPLD_TO_X = "WS379_COLL_APPLD_TO_X";
            internal const string WS380_COLL_ADJ_I_X = "WS380_COLL_ADJ_I_X";
            internal const string WS381_COLL_CONC_X = "WS381_COLL_CONC_X";
            internal const string WS382_COLL_CRTD_TM_X = "WS382_COLL_CRTD_TM_X";
        }
        #endregion

        #region Direct-access element properties
        public IField WS_FILE_STATUS { get { return GetElementByName<IField>(Names.WS_FILE_STATUS); } }
        public IGroup WS_SEQFILE_REC { get { return GetElementByName<IGroup>(Names.WS_SEQFILE_REC); } }
        public IField WS1_DTL_FOR_LN_X { get { return GetElementByName<IField>(Names.WS1_DTL_FOR_LN_X); } }
        public IField WS16_C_NBR_X { get { return GetElementByName<IField>(Names.WS16_C_NBR_X); } }
        public IField WS26_C_STAT_X { get { return GetElementByName<IField>(Names.WS26_C_STAT_X); } }
        public IGroup WS27_C_STAT_DT_X { get { return GetElementByName<IGroup>(Names.WS27_C_STAT_DT_X); } }
        public IField WS27_C_STAT_DT_9 { get { return GetElementByName<IField>(Names.WS27_C_STAT_DT_9); } }
        public IGroup WS35_C_OPN_DT_X { get { return GetElementByName<IGroup>(Names.WS35_C_OPN_DT_X); } }
        public IField WS35_C_OPN_DT_9 { get { return GetElementByName<IField>(Names.WS35_C_OPN_DT_9); } }
        public IGroup WS43_CR_ID_X { get { return GetElementByName<IGroup>(Names.WS43_CR_ID_X); } }
        public IField WS43_CR_ID_9 { get { return GetElementByName<IField>(Names.WS43_CR_ID_9); } }
        public IField WS46_CR_TYP_X { get { return GetElementByName<IField>(Names.WS46_CR_TYP_X); } }
        public IGroup WS48_CR_STRT_DT_X { get { return GetElementByName<IGroup>(Names.WS48_CR_STRT_DT_X); } }
        public IField WS48_CR_STRT_DT_9 { get { return GetElementByName<IField>(Names.WS48_CR_STRT_DT_9); } }
        public IGroup WS56_CR_END_DT_X { get { return GetElementByName<IGroup>(Names.WS56_CR_END_DT_X); } }
        public IField WS56_CR_END_DT_9 { get { return GetElementByName<IField>(Names.WS56_CR_END_DT_9); } }
        public IField WS64_CP_TYP_X { get { return GetElementByName<IField>(Names.WS64_CP_TYP_X); } }
        public IField WS65_CP_NBR_X { get { return GetElementByName<IField>(Names.WS65_CP_NBR_X); } }
        public IField WS75_PP_CRTD_TMST_X { get { return GetElementByName<IField>(Names.WS75_PP_CRTD_TMST_X); } }
        public IGroup WS95_PP_EFF_DT_X { get { return GetElementByName<IGroup>(Names.WS95_PP_EFF_DT_X); } }
        public IField WS95_PP_EFF_DT_9 { get { return GetElementByName<IField>(Names.WS95_PP_EFF_DT_9); } }
        public IGroup WS103_PP_DISC_DT_X { get { return GetElementByName<IGroup>(Names.WS103_PP_DISC_DT_X); } }
        public IField WS103_PP_DISC_DT_9 { get { return GetElementByName<IField>(Names.WS103_PP_DISC_DT_9); } }
        public IField WS111_P_CD_X { get { return GetElementByName<IField>(Names.WS111_P_CD_X); } }
        public IGroup WS114_P_EFF_DT_X { get { return GetElementByName<IGroup>(Names.WS114_P_EFF_DT_X); } }
        public IField WS114_P_EFF_DT_9 { get { return GetElementByName<IField>(Names.WS114_P_EFF_DT_9); } }
        public IGroup WS122_P_DISC_DT_X { get { return GetElementByName<IGroup>(Names.WS122_P_DISC_DT_X); } }
        public IField WS122_P_DISC_DT_9 { get { return GetElementByName<IField>(Names.WS122_P_DISC_DT_9); } }
        public IField WS130_LACR_CRTD_TS_X { get { return GetElementByName<IField>(Names.WS130_LACR_CRTD_TS_X); } }
        public IGroup WS150_LA_ID_X { get { return GetElementByName<IGroup>(Names.WS150_LA_ID_X); } }
        public IField WS150_LA_ID_9 { get { return GetElementByName<IField>(Names.WS150_LA_ID_9); } }
        public IField WS159_LA_ACT_TKN_X { get { return GetElementByName<IField>(Names.WS159_LA_ACT_TKN_X); } }
        public IField WS189_LA_CRTD_TSTA_X { get { return GetElementByName<IField>(Names.WS189_LA_CRTD_TSTA_X); } }
        public IGroup WS209_LA_FLD_DT_X { get { return GetElementByName<IGroup>(Names.WS209_LA_FLD_DT_X); } }
        public IField WS209_LA_FLD_DT_9 { get { return GetElementByName<IField>(Names.WS209_LA_FLD_DT_9); } }
        public IGroup WS217_LAD_NBR_X { get { return GetElementByName<IGroup>(Names.WS217_LAD_NBR_X); } }
        public IField WS217_LAD_NBR_9 { get { return GetElementByName<IField>(Names.WS217_LAD_NBR_9); } }
        public IField WS219_LAD_DTL_TYP_X { get { return GetElementByName<IField>(Names.WS219_LAD_DTL_TYP_X); } }
        public IField WS220_LAD_CRTD_TST_X { get { return GetElementByName<IField>(Names.WS220_LAD_CRTD_TST_X); } }
        public IField WS240_LAD_NON_FIN_OBL_X { get { return GetElementByName<IField>(Names.WS240_LAD_NON_FIN_OBL_X); } }
        public IField WS244_OT_CD_X { get { return GetElementByName<IField>(Names.WS244_OT_CD_X); } }
        public IField WS251_OT_CLS_X { get { return GetElementByName<IField>(Names.WS251_OT_CLS_X); } }
        public IGroup WS252_DD_DUE_DT_X { get { return GetElementByName<IGroup>(Names.WS252_DD_DUE_DT_X); } }
        public IField WS252_DD_DUE_DT_9 { get { return GetElementByName<IField>(Names.WS252_DD_DUE_DT_9); } }
        public IGroup WS260_DD_BAL_DUE_X { get { return GetElementByName<IGroup>(Names.WS260_DD_BAL_DUE_X); } }
        public IField WS260_DD_BAL_DUE_9 { get { return GetElementByName<IField>(Names.WS260_DD_BAL_DUE_9); } }
        public IGroup WS269_DD_INT_BAL_X { get { return GetElementByName<IGroup>(Names.WS269_DD_INT_BAL_X); } }
        public IField WS269_DD_INT_BAL_9 { get { return GetElementByName<IField>(Names.WS269_DD_INT_BAL_9); } }
        public IField WS275_DD_CRTD_TMST_X { get { return GetElementByName<IField>(Names.WS275_DD_CRTD_TMST_X); } }
        public IField WS295_CPA_TYP_X { get { return GetElementByName<IField>(Names.WS295_CPA_TYP_X); } }
        public IField WS296_CPA_CRTD_TMS_X { get { return GetElementByName<IField>(Names.WS296_CPA_CRTD_TMS_X); } }
        public IGroup WS316_OB_TRN_ID_X { get { return GetElementByName<IGroup>(Names.WS316_OB_TRN_ID_X); } }
        public IField WS316_OB_TRN_ID_9 { get { return GetElementByName<IField>(Names.WS316_OB_TRN_ID_9); } }
        public IField WS325_OB_TRN_TYP_X { get { return GetElementByName<IField>(Names.WS325_OB_TRN_TYP_X); } }
        public IField WS327_OB_TRN_CRTD_X { get { return GetElementByName<IField>(Names.WS327_OB_TRN_CRTD_X); } }
        public IGroup WS347_OB_ID_X { get { return GetElementByName<IGroup>(Names.WS347_OB_ID_X); } }
        public IField WS347_OB_ID_9 { get { return GetElementByName<IField>(Names.WS347_OB_ID_9); } }
        public IField WS350_OB_CRTD_TMST_X { get { return GetElementByName<IField>(Names.WS350_OB_CRTD_TMST_X); } }
        public IGroup WS370_COLL_ID_X { get { return GetElementByName<IGroup>(Names.WS370_COLL_ID_X); } }
        public IField WS370_COLL_ID_9 { get { return GetElementByName<IField>(Names.WS370_COLL_ID_9); } }
        public IField WS379_COLL_APPLD_TO_X { get { return GetElementByName<IField>(Names.WS379_COLL_APPLD_TO_X); } }
        public IField WS380_COLL_ADJ_I_X { get { return GetElementByName<IField>(Names.WS380_COLL_ADJ_I_X); } }
        public IField WS381_COLL_CONC_X { get { return GetElementByName<IField>(Names.WS381_COLL_CONC_X); } }
        public IField WS382_COLL_CRTD_TM_X { get { return GetElementByName<IField>(Names.WS382_COLL_CRTD_TM_X); } }

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

            recordDef.CreateNewGroup(Names.WS_SEQFILE_REC, (WS_SEQFILE_REC) =>
           {
               WS_SEQFILE_REC.CreateNewField(Names.WS1_DTL_FOR_LN_X, FieldType.String, 15);
               WS_SEQFILE_REC.CreateNewField(Names.WS16_C_NBR_X, FieldType.String, 10);
               WS_SEQFILE_REC.CreateNewField(Names.WS26_C_STAT_X, FieldType.String, 1);
               WS_SEQFILE_REC.CreateNewGroup(Names.WS27_C_STAT_DT_X, (WS27_C_STAT_DT_X) =>
               {
                   WS27_C_STAT_DT_X.CreateNewField(Names.WS27_C_STAT_DT_9, FieldType.SignedNumeric, 8);
               });
               WS_SEQFILE_REC.CreateNewGroup(Names.WS35_C_OPN_DT_X, (WS35_C_OPN_DT_X) =>
               {
                   WS35_C_OPN_DT_X.CreateNewField(Names.WS35_C_OPN_DT_9, FieldType.SignedNumeric, 8);
               });
               WS_SEQFILE_REC.CreateNewGroup(Names.WS43_CR_ID_X, (WS43_CR_ID_X) =>
               {
                   WS43_CR_ID_X.CreateNewField(Names.WS43_CR_ID_9, FieldType.SignedNumeric, 3);
               });
               WS_SEQFILE_REC.CreateNewField(Names.WS46_CR_TYP_X, FieldType.String, 2);
               WS_SEQFILE_REC.CreateNewGroup(Names.WS48_CR_STRT_DT_X, (WS48_CR_STRT_DT_X) =>
               {
                   WS48_CR_STRT_DT_X.CreateNewField(Names.WS48_CR_STRT_DT_9, FieldType.SignedNumeric, 8);
               });
               WS_SEQFILE_REC.CreateNewGroup(Names.WS56_CR_END_DT_X, (WS56_CR_END_DT_X) =>
               {
                   WS56_CR_END_DT_X.CreateNewField(Names.WS56_CR_END_DT_9, FieldType.SignedNumeric, 8);
               });
               WS_SEQFILE_REC.CreateNewField(Names.WS64_CP_TYP_X, FieldType.String, 1);
               WS_SEQFILE_REC.CreateNewField(Names.WS65_CP_NBR_X, FieldType.String, 10);
               WS_SEQFILE_REC.CreateNewField(Names.WS75_PP_CRTD_TMST_X, FieldType.String, 20);
               WS_SEQFILE_REC.CreateNewGroup(Names.WS95_PP_EFF_DT_X, (WS95_PP_EFF_DT_X) =>
               {
                   WS95_PP_EFF_DT_X.CreateNewField(Names.WS95_PP_EFF_DT_9, FieldType.SignedNumeric, 8);
               });
               WS_SEQFILE_REC.CreateNewGroup(Names.WS103_PP_DISC_DT_X, (WS103_PP_DISC_DT_X) =>
               {
                   WS103_PP_DISC_DT_X.CreateNewField(Names.WS103_PP_DISC_DT_9, FieldType.SignedNumeric, 8);
               });
               WS_SEQFILE_REC.CreateNewField(Names.WS111_P_CD_X, FieldType.String, 3);
               WS_SEQFILE_REC.CreateNewGroup(Names.WS114_P_EFF_DT_X, (WS114_P_EFF_DT_X) =>
               {
                   WS114_P_EFF_DT_X.CreateNewField(Names.WS114_P_EFF_DT_9, FieldType.SignedNumeric, 8);
               });
               WS_SEQFILE_REC.CreateNewGroup(Names.WS122_P_DISC_DT_X, (WS122_P_DISC_DT_X) =>
               {
                   WS122_P_DISC_DT_X.CreateNewField(Names.WS122_P_DISC_DT_9, FieldType.SignedNumeric, 8);
               });
               WS_SEQFILE_REC.CreateNewField(Names.WS130_LACR_CRTD_TS_X, FieldType.String, 20);
               WS_SEQFILE_REC.CreateNewGroup(Names.WS150_LA_ID_X, (WS150_LA_ID_X) =>
               {
                   WS150_LA_ID_X.CreateNewField(Names.WS150_LA_ID_9, FieldType.SignedNumeric, 9);
               });
               WS_SEQFILE_REC.CreateNewField(Names.WS159_LA_ACT_TKN_X, FieldType.String, 30);
               WS_SEQFILE_REC.CreateNewField(Names.WS189_LA_CRTD_TSTA_X, FieldType.String, 20);
               WS_SEQFILE_REC.CreateNewGroup(Names.WS209_LA_FLD_DT_X, (WS209_LA_FLD_DT_X) =>
               {
                   WS209_LA_FLD_DT_X.CreateNewField(Names.WS209_LA_FLD_DT_9, FieldType.SignedNumeric, 8);
               });
               WS_SEQFILE_REC.CreateNewGroup(Names.WS217_LAD_NBR_X, (WS217_LAD_NBR_X) =>
               {
                   WS217_LAD_NBR_X.CreateNewField(Names.WS217_LAD_NBR_9, FieldType.SignedNumeric, 2);
               });
               WS_SEQFILE_REC.CreateNewField(Names.WS219_LAD_DTL_TYP_X, FieldType.String, 1);
               WS_SEQFILE_REC.CreateNewField(Names.WS220_LAD_CRTD_TST_X, FieldType.String, 20);
               WS_SEQFILE_REC.CreateNewField(Names.WS240_LAD_NON_FIN_OBL_X, FieldType.String, 4);
               WS_SEQFILE_REC.CreateNewField(Names.WS244_OT_CD_X, FieldType.String, 7);
               WS_SEQFILE_REC.CreateNewField(Names.WS251_OT_CLS_X, FieldType.String, 1);
               WS_SEQFILE_REC.CreateNewGroup(Names.WS252_DD_DUE_DT_X, (WS252_DD_DUE_DT_X) =>
               {
                   WS252_DD_DUE_DT_X.CreateNewField(Names.WS252_DD_DUE_DT_9, FieldType.SignedNumeric, 8);
               });
               WS_SEQFILE_REC.CreateNewGroup(Names.WS260_DD_BAL_DUE_X, (WS260_DD_BAL_DUE_X) =>
               {
                   WS260_DD_BAL_DUE_X.CreateNewField(Names.WS260_DD_BAL_DUE_9, FieldType.SignedNumeric, 9, null, 2);
               });
               WS_SEQFILE_REC.CreateNewGroup(Names.WS269_DD_INT_BAL_X, (WS269_DD_INT_BAL_X) =>
               {
                   WS269_DD_INT_BAL_X.CreateNewField(Names.WS269_DD_INT_BAL_9, FieldType.SignedNumeric, 6, null, 2);
               });
               WS_SEQFILE_REC.CreateNewField(Names.WS275_DD_CRTD_TMST_X, FieldType.String, 20);
               WS_SEQFILE_REC.CreateNewField(Names.WS295_CPA_TYP_X, FieldType.String, 1);
               WS_SEQFILE_REC.CreateNewField(Names.WS296_CPA_CRTD_TMS_X, FieldType.String, 20);
               WS_SEQFILE_REC.CreateNewGroup(Names.WS316_OB_TRN_ID_X, (WS316_OB_TRN_ID_X) =>
               {
                   WS316_OB_TRN_ID_X.CreateNewField(Names.WS316_OB_TRN_ID_9, FieldType.SignedNumeric, 9);
               });
               WS_SEQFILE_REC.CreateNewField(Names.WS325_OB_TRN_TYP_X, FieldType.String, 2);
               WS_SEQFILE_REC.CreateNewField(Names.WS327_OB_TRN_CRTD_X, FieldType.String, 20);
               WS_SEQFILE_REC.CreateNewGroup(Names.WS347_OB_ID_X, (WS347_OB_ID_X) =>
               {
                   WS347_OB_ID_X.CreateNewField(Names.WS347_OB_ID_9, FieldType.SignedNumeric, 3);
               });
               WS_SEQFILE_REC.CreateNewField(Names.WS350_OB_CRTD_TMST_X, FieldType.String, 20);
               WS_SEQFILE_REC.CreateNewGroup(Names.WS370_COLL_ID_X, (WS370_COLL_ID_X) =>
               {
                   WS370_COLL_ID_X.CreateNewField(Names.WS370_COLL_ID_9, FieldType.SignedNumeric, 9);
               });
               WS_SEQFILE_REC.CreateNewField(Names.WS379_COLL_APPLD_TO_X, FieldType.String, 1);
               WS_SEQFILE_REC.CreateNewField(Names.WS380_COLL_ADJ_I_X, FieldType.String, 1);
               WS_SEQFILE_REC.CreateNewField(Names.WS381_COLL_CONC_X, FieldType.String, 1);
               WS_SEQFILE_REC.CreateNewField(Names.WS382_COLL_CRTD_TM_X, FieldType.String, 20);
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
    internal class SWEXF715_ls : PredefinedRecordBase
    {
        #region Name constants
        /// <summary>
        /// Name constants.
        /// </summary>
        internal static class Names
        {
            internal const string LinkageSection = "SWEXF715_ls_LinkageSection";
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
            internal const string LSI_V1 = "LSI_V1";
            internal const string LSI_CASE_VER_EXTR_ET = "LSI_CASE_VER_EXTR_ET";
            internal const string LSI_DTL_FOR_LN_01MS = "LSI_DTL_FOR_LN_01MS";
            internal const string LSI_DTL_FOR_LN_01 = "LSI_DTL_FOR_LN_01";
            internal const string LSI_DTL_FOR_LN_01XX = "LSI_DTL_FOR_LN_01XX";
            internal const string LSI_C_NBR_02MS = "LSI_C_NBR_02MS";
            internal const string LSI_C_NBR_02 = "LSI_C_NBR_02";
            internal const string LSI_C_NBR_02XX = "LSI_C_NBR_02XX";
            internal const string LSI_C_STAT_03MS = "LSI_C_STAT_03MS";
            internal const string LSI_C_STAT_03 = "LSI_C_STAT_03";
            internal const string LSI_C_STAT_03XX = "LSI_C_STAT_03XX";
            internal const string LSI_C_STAT_DT_04MS = "LSI_C_STAT_DT_04MS";
            internal const string LSI_C_STAT_DT_04 = "LSI_C_STAT_DT_04";
            internal const string LSI_C_STAT_DT_04XX = "LSI_C_STAT_DT_04XX";
            internal const string LSI_C_OPN_DT_05MS = "LSI_C_OPN_DT_05MS";
            internal const string LSI_C_OPN_DT_05 = "LSI_C_OPN_DT_05";
            internal const string LSI_C_OPN_DT_05XX = "LSI_C_OPN_DT_05XX";
            internal const string LSI_CR_ID_06MS = "LSI_CR_ID_06MS";
            internal const string LSI_CR_ID_06 = "LSI_CR_ID_06";
            internal const string LSI_CR_ID_06XX = "LSI_CR_ID_06XX";
            internal const string LSI_CR_TYP_07MS = "LSI_CR_TYP_07MS";
            internal const string LSI_CR_TYP_07 = "LSI_CR_TYP_07";
            internal const string LSI_CR_TYP_07XX = "LSI_CR_TYP_07XX";
            internal const string LSI_CR_STRT_DT_08MS = "LSI_CR_STRT_DT_08MS";
            internal const string LSI_CR_STRT_DT_08 = "LSI_CR_STRT_DT_08";
            internal const string LSI_CR_STRT_DT_08XX = "LSI_CR_STRT_DT_08XX";
            internal const string LSI_CR_END_DT_09MS = "LSI_CR_END_DT_09MS";
            internal const string LSI_CR_END_DT_09 = "LSI_CR_END_DT_09";
            internal const string LSI_CR_END_DT_09XX = "LSI_CR_END_DT_09XX";
            internal const string LSI_CP_TYP_10MS = "LSI_CP_TYP_10MS";
            internal const string LSI_CP_TYP_10 = "LSI_CP_TYP_10";
            internal const string LSI_CP_TYP_10XX = "LSI_CP_TYP_10XX";
            internal const string LSI_CP_NBR_11MS = "LSI_CP_NBR_11MS";
            internal const string LSI_CP_NBR_11 = "LSI_CP_NBR_11";
            internal const string LSI_CP_NBR_11XX = "LSI_CP_NBR_11XX";
            internal const string LSI_PP_CRTD_TMST_12MS = "LSI_PP_CRTD_TMST_12MS";
            internal const string LSI_PP_CRTD_TMST_12 = "LSI_PP_CRTD_TMST_12";
            internal const string LSI_PP_CRTD_TMST_12XX = "LSI_PP_CRTD_TMST_12XX";
            internal const string LSI_PP_EFF_DT_13MS = "LSI_PP_EFF_DT_13MS";
            internal const string LSI_PP_EFF_DT_13 = "LSI_PP_EFF_DT_13";
            internal const string LSI_PP_EFF_DT_13XX = "LSI_PP_EFF_DT_13XX";
            internal const string LSI_PP_DISC_DT_14MS = "LSI_PP_DISC_DT_14MS";
            internal const string LSI_PP_DISC_DT_14 = "LSI_PP_DISC_DT_14";
            internal const string LSI_PP_DISC_DT_14XX = "LSI_PP_DISC_DT_14XX";
            internal const string LSI_P_CD_15MS = "LSI_P_CD_15MS";
            internal const string LSI_P_CD_15 = "LSI_P_CD_15";
            internal const string LSI_P_CD_15XX = "LSI_P_CD_15XX";
            internal const string LSI_P_EFF_DT_16MS = "LSI_P_EFF_DT_16MS";
            internal const string LSI_P_EFF_DT_16 = "LSI_P_EFF_DT_16";
            internal const string LSI_P_EFF_DT_16XX = "LSI_P_EFF_DT_16XX";
            internal const string LSI_P_DISC_DT_17MS = "LSI_P_DISC_DT_17MS";
            internal const string LSI_P_DISC_DT_17 = "LSI_P_DISC_DT_17";
            internal const string LSI_P_DISC_DT_17XX = "LSI_P_DISC_DT_17XX";
            internal const string LSI_LACR_CRTD_TMST_18MS = "LSI_LACR_CRTD_TMST_18MS";
            internal const string LSI_LACR_CRTD_TMST_18 = "LSI_LACR_CRTD_TMST_18";
            internal const string LSI_LACR_CRTD_TMST_18XX = "LSI_LACR_CRTD_TMST_18XX";
            internal const string LSI_LA_ID_19MS = "LSI_LA_ID_19MS";
            internal const string LSI_LA_ID_19 = "LSI_LA_ID_19";
            internal const string LSI_LA_ID_19XX = "LSI_LA_ID_19XX";
            internal const string LSI_LA_ACT_TKN_20MS = "LSI_LA_ACT_TKN_20MS";
            internal const string LSI_LA_ACT_TKN_20 = "LSI_LA_ACT_TKN_20";
            internal const string LSI_LA_ACT_TKN_20XX = "LSI_LA_ACT_TKN_20XX";
            internal const string LSI_LA_CRTD_TMST_21MS = "LSI_LA_CRTD_TMST_21MS";
            internal const string LSI_LA_CRTD_TMST_21 = "LSI_LA_CRTD_TMST_21";
            internal const string LSI_LA_CRTD_TMST_21XX = "LSI_LA_CRTD_TMST_21XX";
            internal const string LSI_LA_FLD_DT_22MS = "LSI_LA_FLD_DT_22MS";
            internal const string LSI_LA_FLD_DT_22 = "LSI_LA_FLD_DT_22";
            internal const string LSI_LA_FLD_DT_22XX = "LSI_LA_FLD_DT_22XX";
            internal const string LSI_LAD_NBR_23MS = "LSI_LAD_NBR_23MS";
            internal const string LSI_LAD_NBR_23 = "LSI_LAD_NBR_23";
            internal const string LSI_LAD_NBR_23XX = "LSI_LAD_NBR_23XX";
            internal const string LSI_LAD_DTL_TYP_24MS = "LSI_LAD_DTL_TYP_24MS";
            internal const string LSI_LAD_DTL_TYP_24 = "LSI_LAD_DTL_TYP_24";
            internal const string LSI_LAD_DTL_TYP_24XX = "LSI_LAD_DTL_TYP_24XX";
            internal const string LSI_LAD_CRTD_TMST_25MS = "LSI_LAD_CRTD_TMST_25MS";
            internal const string LSI_LAD_CRTD_TMST_25 = "LSI_LAD_CRTD_TMST_25";
            internal const string LSI_LAD_CRTD_TMST_25XX = "LSI_LAD_CRTD_TMST_25XX";
            internal const string LSI_LAD_NON_FIN_OB_TYP_26MS = "LSI_LAD_NON_FIN_OB_TYP_26MS";
            internal const string LSI_LAD_NON_FIN_OB_TYP_26 = "LSI_LAD_NON_FIN_OB_TYP_26";
            internal const string LSI_LAD_NON_FIN_OB_TYP_26XX = "LSI_LAD_NON_FIN_OB_TYP_26XX";
            internal const string LSI_OT_CD_27MS = "LSI_OT_CD_27MS";
            internal const string LSI_OT_CD_27 = "LSI_OT_CD_27";
            internal const string LSI_OT_CD_27XX = "LSI_OT_CD_27XX";
            internal const string LSI_OT_CLS_28MS = "LSI_OT_CLS_28MS";
            internal const string LSI_OT_CLS_28 = "LSI_OT_CLS_28";
            internal const string LSI_OT_CLS_28XX = "LSI_OT_CLS_28XX";
            internal const string LSI_DD_DUE_DT_29MS = "LSI_DD_DUE_DT_29MS";
            internal const string LSI_DD_DUE_DT_29 = "LSI_DD_DUE_DT_29";
            internal const string LSI_DD_DUE_DT_29XX = "LSI_DD_DUE_DT_29XX";
            internal const string LSI_DD_BAL_DUE_AMT_30MS = "LSI_DD_BAL_DUE_AMT_30MS";
            internal const string LSI_DD_BAL_DUE_AMT_30 = "LSI_DD_BAL_DUE_AMT_30";
            internal const string LSI_DD_BAL_DUE_AMT_30XX = "LSI_DD_BAL_DUE_AMT_30XX";
            internal const string LSI_DD_INT_BAL_DUE_31MS = "LSI_DD_INT_BAL_DUE_31MS";
            internal const string LSI_DD_INT_BAL_DUE_31 = "LSI_DD_INT_BAL_DUE_31";
            internal const string LSI_DD_INT_BAL_DUE_31XX = "LSI_DD_INT_BAL_DUE_31XX";
            internal const string LSI_DD_CRTD_TMST_32MS = "LSI_DD_CRTD_TMST_32MS";
            internal const string LSI_DD_CRTD_TMST_32 = "LSI_DD_CRTD_TMST_32";
            internal const string LSI_DD_CRTD_TMST_32XX = "LSI_DD_CRTD_TMST_32XX";
            internal const string LSI_CPA_TYP_33MS = "LSI_CPA_TYP_33MS";
            internal const string LSI_CPA_TYP_33 = "LSI_CPA_TYP_33";
            internal const string LSI_CPA_TYP_33XX = "LSI_CPA_TYP_33XX";
            internal const string LSI_CPA_CRTD_TMST_34MS = "LSI_CPA_CRTD_TMST_34MS";
            internal const string LSI_CPA_CRTD_TMST_34 = "LSI_CPA_CRTD_TMST_34";
            internal const string LSI_CPA_CRTD_TMST_34XX = "LSI_CPA_CRTD_TMST_34XX";
            internal const string LSI_OB_TRN_ID_35MS = "LSI_OB_TRN_ID_35MS";
            internal const string LSI_OB_TRN_ID_35 = "LSI_OB_TRN_ID_35";
            internal const string LSI_OB_TRN_ID_35XX = "LSI_OB_TRN_ID_35XX";
            internal const string LSI_OB_TRN_TYP_36MS = "LSI_OB_TRN_TYP_36MS";
            internal const string LSI_OB_TRN_TYP_36 = "LSI_OB_TRN_TYP_36";
            internal const string LSI_OB_TRN_TYP_36XX = "LSI_OB_TRN_TYP_36XX";
            internal const string LSI_OB_TRN_CRTD_TMST_37MS = "LSI_OB_TRN_CRTD_TMST_37MS";
            internal const string LSI_OB_TRN_CRTD_TMST_37 = "LSI_OB_TRN_CRTD_TMST_37";
            internal const string LSI_OB_TRN_CRTD_TMST_37XX = "LSI_OB_TRN_CRTD_TMST_37XX";
            internal const string LSI_OB_ID_38MS = "LSI_OB_ID_38MS";
            internal const string LSI_OB_ID_38 = "LSI_OB_ID_38";
            internal const string LSI_OB_ID_38XX = "LSI_OB_ID_38XX";
            internal const string LSI_OB_CRTD_TMST_39MS = "LSI_OB_CRTD_TMST_39MS";
            internal const string LSI_OB_CRTD_TMST_39 = "LSI_OB_CRTD_TMST_39";
            internal const string LSI_OB_CRTD_TMST_39XX = "LSI_OB_CRTD_TMST_39XX";
            internal const string LSI_COLL_ID_40MS = "LSI_COLL_ID_40MS";
            internal const string LSI_COLL_ID_40 = "LSI_COLL_ID_40";
            internal const string LSI_COLL_ID_40XX = "LSI_COLL_ID_40XX";
            internal const string LSI_COLL_APPLD_TO_CD_41MS = "LSI_COLL_APPLD_TO_CD_41MS";
            internal const string LSI_COLL_APPLD_TO_CD_41 = "LSI_COLL_APPLD_TO_CD_41";
            internal const string LSI_COLL_APPLD_TO_CD_41XX = "LSI_COLL_APPLD_TO_CD_41XX";
            internal const string LSI_COLL_ADJ_IND_42MS = "LSI_COLL_ADJ_IND_42MS";
            internal const string LSI_COLL_ADJ_IND_42 = "LSI_COLL_ADJ_IND_42";
            internal const string LSI_COLL_ADJ_IND_42XX = "LSI_COLL_ADJ_IND_42XX";
            internal const string LSI_COLL_CONC_IND_43MS = "LSI_COLL_CONC_IND_43MS";
            internal const string LSI_COLL_CONC_IND_43 = "LSI_COLL_CONC_IND_43";
            internal const string LSI_COLL_CONC_IND_43XX = "LSI_COLL_CONC_IND_43XX";
            internal const string LSI_COLL_CRTD_TMST_44MS = "LSI_COLL_CRTD_TMST_44MS";
            internal const string LSI_COLL_CRTD_TMST_44 = "LSI_COLL_CRTD_TMST_44";
            internal const string LSI_COLL_CRTD_TMST_44XX = "LSI_COLL_CRTD_TMST_44XX";
            internal const string LSI_V2 = "LSI_V2";
            internal const string LSI_RPT_PARMS_ET = "LSI_RPT_PARMS_ET";
            internal const string LSI_PARM1_45MS = "LSI_PARM1_45MS";
            internal const string LSI_PARM1_45 = "LSI_PARM1_45";
            internal const string LSI_PARM1_45XX = "LSI_PARM1_45XX";
            internal const string IO_CONTROL_CD = "IO_CONTROL_CD";
            internal const string LSI_PARM2_46MS = "LSI_PARM2_46MS";
            internal const string LSI_PARM2_46 = "LSI_PARM2_46";
            internal const string LSI_PARM2_46XX = "LSI_PARM2_46XX";
            internal const string LS_RUNTIME_RPT_TYP_CD = "LS_RUNTIME_RPT_TYP_CD";
            internal const string LSE_V3 = "LSE_V3";
            internal const string LSE_RPT_PARMS_ET = "LSE_RPT_PARMS_ET";
            internal const string LSE_PARM1_47MS = "LSE_PARM1_47MS";
            internal const string LSE_PARM1_47 = "LSE_PARM1_47";
            internal const string LSE_PARM1_47XX = "LSE_PARM1_47XX";
            internal const string LS_RETURN_CD = "LS_RETURN_CD";
            internal const string LSE_PARM2_48MS = "LSE_PARM2_48MS";
            internal const string LSE_PARM2_48 = "LSE_PARM2_48";
            internal const string LSE_PARM2_48XX = "LSE_PARM2_48XX";
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
        public IGroup LSI_V1 { get { return GetElementByName<IGroup>(Names.LSI_V1); } }
        public IGroup LSI_CASE_VER_EXTR_ET { get { return GetElementByName<IGroup>(Names.LSI_CASE_VER_EXTR_ET); } }
        public IField LSI_DTL_FOR_LN_01MS { get { return GetElementByName<IField>(Names.LSI_DTL_FOR_LN_01MS); } }
        public IField LSI_DTL_FOR_LN_01 { get { return GetElementByName<IField>(Names.LSI_DTL_FOR_LN_01); } }
        public IField LSI_DTL_FOR_LN_01XX { get { return GetElementByName<IField>(Names.LSI_DTL_FOR_LN_01XX); } }
        public IField LSI_C_NBR_02MS { get { return GetElementByName<IField>(Names.LSI_C_NBR_02MS); } }
        public IField LSI_C_NBR_02 { get { return GetElementByName<IField>(Names.LSI_C_NBR_02); } }
        public IField LSI_C_NBR_02XX { get { return GetElementByName<IField>(Names.LSI_C_NBR_02XX); } }
        public IField LSI_C_STAT_03MS { get { return GetElementByName<IField>(Names.LSI_C_STAT_03MS); } }
        public IField LSI_C_STAT_03 { get { return GetElementByName<IField>(Names.LSI_C_STAT_03); } }
        public IField LSI_C_STAT_03XX { get { return GetElementByName<IField>(Names.LSI_C_STAT_03XX); } }
        public IField LSI_C_STAT_DT_04MS { get { return GetElementByName<IField>(Names.LSI_C_STAT_DT_04MS); } }
        public IField LSI_C_STAT_DT_04 { get { return GetElementByName<IField>(Names.LSI_C_STAT_DT_04); } }
        public IField LSI_C_STAT_DT_04XX { get { return GetElementByName<IField>(Names.LSI_C_STAT_DT_04XX); } }
        public IField LSI_C_OPN_DT_05MS { get { return GetElementByName<IField>(Names.LSI_C_OPN_DT_05MS); } }
        public IField LSI_C_OPN_DT_05 { get { return GetElementByName<IField>(Names.LSI_C_OPN_DT_05); } }
        public IField LSI_C_OPN_DT_05XX { get { return GetElementByName<IField>(Names.LSI_C_OPN_DT_05XX); } }
        public IField LSI_CR_ID_06MS { get { return GetElementByName<IField>(Names.LSI_CR_ID_06MS); } }
        public IField LSI_CR_ID_06 { get { return GetElementByName<IField>(Names.LSI_CR_ID_06); } }
        public IField LSI_CR_ID_06XX { get { return GetElementByName<IField>(Names.LSI_CR_ID_06XX); } }
        public IField LSI_CR_TYP_07MS { get { return GetElementByName<IField>(Names.LSI_CR_TYP_07MS); } }
        public IField LSI_CR_TYP_07 { get { return GetElementByName<IField>(Names.LSI_CR_TYP_07); } }
        public IField LSI_CR_TYP_07XX { get { return GetElementByName<IField>(Names.LSI_CR_TYP_07XX); } }
        public IField LSI_CR_STRT_DT_08MS { get { return GetElementByName<IField>(Names.LSI_CR_STRT_DT_08MS); } }
        public IField LSI_CR_STRT_DT_08 { get { return GetElementByName<IField>(Names.LSI_CR_STRT_DT_08); } }
        public IField LSI_CR_STRT_DT_08XX { get { return GetElementByName<IField>(Names.LSI_CR_STRT_DT_08XX); } }
        public IField LSI_CR_END_DT_09MS { get { return GetElementByName<IField>(Names.LSI_CR_END_DT_09MS); } }
        public IField LSI_CR_END_DT_09 { get { return GetElementByName<IField>(Names.LSI_CR_END_DT_09); } }
        public IField LSI_CR_END_DT_09XX { get { return GetElementByName<IField>(Names.LSI_CR_END_DT_09XX); } }
        public IField LSI_CP_TYP_10MS { get { return GetElementByName<IField>(Names.LSI_CP_TYP_10MS); } }
        public IField LSI_CP_TYP_10 { get { return GetElementByName<IField>(Names.LSI_CP_TYP_10); } }
        public IField LSI_CP_TYP_10XX { get { return GetElementByName<IField>(Names.LSI_CP_TYP_10XX); } }
        public IField LSI_CP_NBR_11MS { get { return GetElementByName<IField>(Names.LSI_CP_NBR_11MS); } }
        public IField LSI_CP_NBR_11 { get { return GetElementByName<IField>(Names.LSI_CP_NBR_11); } }
        public IField LSI_CP_NBR_11XX { get { return GetElementByName<IField>(Names.LSI_CP_NBR_11XX); } }
        public IField LSI_PP_CRTD_TMST_12MS { get { return GetElementByName<IField>(Names.LSI_PP_CRTD_TMST_12MS); } }
        public IField LSI_PP_CRTD_TMST_12 { get { return GetElementByName<IField>(Names.LSI_PP_CRTD_TMST_12); } }
        public IField LSI_PP_CRTD_TMST_12XX { get { return GetElementByName<IField>(Names.LSI_PP_CRTD_TMST_12XX); } }
        public IField LSI_PP_EFF_DT_13MS { get { return GetElementByName<IField>(Names.LSI_PP_EFF_DT_13MS); } }
        public IField LSI_PP_EFF_DT_13 { get { return GetElementByName<IField>(Names.LSI_PP_EFF_DT_13); } }
        public IField LSI_PP_EFF_DT_13XX { get { return GetElementByName<IField>(Names.LSI_PP_EFF_DT_13XX); } }
        public IField LSI_PP_DISC_DT_14MS { get { return GetElementByName<IField>(Names.LSI_PP_DISC_DT_14MS); } }
        public IField LSI_PP_DISC_DT_14 { get { return GetElementByName<IField>(Names.LSI_PP_DISC_DT_14); } }
        public IField LSI_PP_DISC_DT_14XX { get { return GetElementByName<IField>(Names.LSI_PP_DISC_DT_14XX); } }
        public IField LSI_P_CD_15MS { get { return GetElementByName<IField>(Names.LSI_P_CD_15MS); } }
        public IField LSI_P_CD_15 { get { return GetElementByName<IField>(Names.LSI_P_CD_15); } }
        public IField LSI_P_CD_15XX { get { return GetElementByName<IField>(Names.LSI_P_CD_15XX); } }
        public IField LSI_P_EFF_DT_16MS { get { return GetElementByName<IField>(Names.LSI_P_EFF_DT_16MS); } }
        public IField LSI_P_EFF_DT_16 { get { return GetElementByName<IField>(Names.LSI_P_EFF_DT_16); } }
        public IField LSI_P_EFF_DT_16XX { get { return GetElementByName<IField>(Names.LSI_P_EFF_DT_16XX); } }
        public IField LSI_P_DISC_DT_17MS { get { return GetElementByName<IField>(Names.LSI_P_DISC_DT_17MS); } }
        public IField LSI_P_DISC_DT_17 { get { return GetElementByName<IField>(Names.LSI_P_DISC_DT_17); } }
        public IField LSI_P_DISC_DT_17XX { get { return GetElementByName<IField>(Names.LSI_P_DISC_DT_17XX); } }
        public IField LSI_LACR_CRTD_TMST_18MS { get { return GetElementByName<IField>(Names.LSI_LACR_CRTD_TMST_18MS); } }
        public IField LSI_LACR_CRTD_TMST_18 { get { return GetElementByName<IField>(Names.LSI_LACR_CRTD_TMST_18); } }
        public IField LSI_LACR_CRTD_TMST_18XX { get { return GetElementByName<IField>(Names.LSI_LACR_CRTD_TMST_18XX); } }
        public IField LSI_LA_ID_19MS { get { return GetElementByName<IField>(Names.LSI_LA_ID_19MS); } }
        public IField LSI_LA_ID_19 { get { return GetElementByName<IField>(Names.LSI_LA_ID_19); } }
        public IField LSI_LA_ID_19XX { get { return GetElementByName<IField>(Names.LSI_LA_ID_19XX); } }
        public IField LSI_LA_ACT_TKN_20MS { get { return GetElementByName<IField>(Names.LSI_LA_ACT_TKN_20MS); } }
        public IField LSI_LA_ACT_TKN_20 { get { return GetElementByName<IField>(Names.LSI_LA_ACT_TKN_20); } }
        public IField LSI_LA_ACT_TKN_20XX { get { return GetElementByName<IField>(Names.LSI_LA_ACT_TKN_20XX); } }
        public IField LSI_LA_CRTD_TMST_21MS { get { return GetElementByName<IField>(Names.LSI_LA_CRTD_TMST_21MS); } }
        public IField LSI_LA_CRTD_TMST_21 { get { return GetElementByName<IField>(Names.LSI_LA_CRTD_TMST_21); } }
        public IField LSI_LA_CRTD_TMST_21XX { get { return GetElementByName<IField>(Names.LSI_LA_CRTD_TMST_21XX); } }
        public IField LSI_LA_FLD_DT_22MS { get { return GetElementByName<IField>(Names.LSI_LA_FLD_DT_22MS); } }
        public IField LSI_LA_FLD_DT_22 { get { return GetElementByName<IField>(Names.LSI_LA_FLD_DT_22); } }
        public IField LSI_LA_FLD_DT_22XX { get { return GetElementByName<IField>(Names.LSI_LA_FLD_DT_22XX); } }
        public IField LSI_LAD_NBR_23MS { get { return GetElementByName<IField>(Names.LSI_LAD_NBR_23MS); } }
        public IField LSI_LAD_NBR_23 { get { return GetElementByName<IField>(Names.LSI_LAD_NBR_23); } }
        public IField LSI_LAD_NBR_23XX { get { return GetElementByName<IField>(Names.LSI_LAD_NBR_23XX); } }
        public IField LSI_LAD_DTL_TYP_24MS { get { return GetElementByName<IField>(Names.LSI_LAD_DTL_TYP_24MS); } }
        public IField LSI_LAD_DTL_TYP_24 { get { return GetElementByName<IField>(Names.LSI_LAD_DTL_TYP_24); } }
        public IField LSI_LAD_DTL_TYP_24XX { get { return GetElementByName<IField>(Names.LSI_LAD_DTL_TYP_24XX); } }
        public IField LSI_LAD_CRTD_TMST_25MS { get { return GetElementByName<IField>(Names.LSI_LAD_CRTD_TMST_25MS); } }
        public IField LSI_LAD_CRTD_TMST_25 { get { return GetElementByName<IField>(Names.LSI_LAD_CRTD_TMST_25); } }
        public IField LSI_LAD_CRTD_TMST_25XX { get { return GetElementByName<IField>(Names.LSI_LAD_CRTD_TMST_25XX); } }
        public IField LSI_LAD_NON_FIN_OB_TYP_26MS { get { return GetElementByName<IField>(Names.LSI_LAD_NON_FIN_OB_TYP_26MS); } }
        public IField LSI_LAD_NON_FIN_OB_TYP_26 { get { return GetElementByName<IField>(Names.LSI_LAD_NON_FIN_OB_TYP_26); } }
        public IField LSI_LAD_NON_FIN_OB_TYP_26XX { get { return GetElementByName<IField>(Names.LSI_LAD_NON_FIN_OB_TYP_26XX); } }
        public IField LSI_OT_CD_27MS { get { return GetElementByName<IField>(Names.LSI_OT_CD_27MS); } }
        public IField LSI_OT_CD_27 { get { return GetElementByName<IField>(Names.LSI_OT_CD_27); } }
        public IField LSI_OT_CD_27XX { get { return GetElementByName<IField>(Names.LSI_OT_CD_27XX); } }
        public IField LSI_OT_CLS_28MS { get { return GetElementByName<IField>(Names.LSI_OT_CLS_28MS); } }
        public IField LSI_OT_CLS_28 { get { return GetElementByName<IField>(Names.LSI_OT_CLS_28); } }
        public IField LSI_OT_CLS_28XX { get { return GetElementByName<IField>(Names.LSI_OT_CLS_28XX); } }
        public IField LSI_DD_DUE_DT_29MS { get { return GetElementByName<IField>(Names.LSI_DD_DUE_DT_29MS); } }
        public IField LSI_DD_DUE_DT_29 { get { return GetElementByName<IField>(Names.LSI_DD_DUE_DT_29); } }
        public IField LSI_DD_DUE_DT_29XX { get { return GetElementByName<IField>(Names.LSI_DD_DUE_DT_29XX); } }
        public IField LSI_DD_BAL_DUE_AMT_30MS { get { return GetElementByName<IField>(Names.LSI_DD_BAL_DUE_AMT_30MS); } }
        public IField LSI_DD_BAL_DUE_AMT_30 { get { return GetElementByName<IField>(Names.LSI_DD_BAL_DUE_AMT_30); } }
        public IField LSI_DD_BAL_DUE_AMT_30XX { get { return GetElementByName<IField>(Names.LSI_DD_BAL_DUE_AMT_30XX); } }
        public IField LSI_DD_INT_BAL_DUE_31MS { get { return GetElementByName<IField>(Names.LSI_DD_INT_BAL_DUE_31MS); } }
        public IField LSI_DD_INT_BAL_DUE_31 { get { return GetElementByName<IField>(Names.LSI_DD_INT_BAL_DUE_31); } }
        public IField LSI_DD_INT_BAL_DUE_31XX { get { return GetElementByName<IField>(Names.LSI_DD_INT_BAL_DUE_31XX); } }
        public IField LSI_DD_CRTD_TMST_32MS { get { return GetElementByName<IField>(Names.LSI_DD_CRTD_TMST_32MS); } }
        public IField LSI_DD_CRTD_TMST_32 { get { return GetElementByName<IField>(Names.LSI_DD_CRTD_TMST_32); } }
        public IField LSI_DD_CRTD_TMST_32XX { get { return GetElementByName<IField>(Names.LSI_DD_CRTD_TMST_32XX); } }
        public IField LSI_CPA_TYP_33MS { get { return GetElementByName<IField>(Names.LSI_CPA_TYP_33MS); } }
        public IField LSI_CPA_TYP_33 { get { return GetElementByName<IField>(Names.LSI_CPA_TYP_33); } }
        public IField LSI_CPA_TYP_33XX { get { return GetElementByName<IField>(Names.LSI_CPA_TYP_33XX); } }
        public IField LSI_CPA_CRTD_TMST_34MS { get { return GetElementByName<IField>(Names.LSI_CPA_CRTD_TMST_34MS); } }
        public IField LSI_CPA_CRTD_TMST_34 { get { return GetElementByName<IField>(Names.LSI_CPA_CRTD_TMST_34); } }
        public IField LSI_CPA_CRTD_TMST_34XX { get { return GetElementByName<IField>(Names.LSI_CPA_CRTD_TMST_34XX); } }
        public IField LSI_OB_TRN_ID_35MS { get { return GetElementByName<IField>(Names.LSI_OB_TRN_ID_35MS); } }
        public IField LSI_OB_TRN_ID_35 { get { return GetElementByName<IField>(Names.LSI_OB_TRN_ID_35); } }
        public IField LSI_OB_TRN_ID_35XX { get { return GetElementByName<IField>(Names.LSI_OB_TRN_ID_35XX); } }
        public IField LSI_OB_TRN_TYP_36MS { get { return GetElementByName<IField>(Names.LSI_OB_TRN_TYP_36MS); } }
        public IField LSI_OB_TRN_TYP_36 { get { return GetElementByName<IField>(Names.LSI_OB_TRN_TYP_36); } }
        public IField LSI_OB_TRN_TYP_36XX { get { return GetElementByName<IField>(Names.LSI_OB_TRN_TYP_36XX); } }
        public IField LSI_OB_TRN_CRTD_TMST_37MS { get { return GetElementByName<IField>(Names.LSI_OB_TRN_CRTD_TMST_37MS); } }
        public IField LSI_OB_TRN_CRTD_TMST_37 { get { return GetElementByName<IField>(Names.LSI_OB_TRN_CRTD_TMST_37); } }
        public IField LSI_OB_TRN_CRTD_TMST_37XX { get { return GetElementByName<IField>(Names.LSI_OB_TRN_CRTD_TMST_37XX); } }
        public IField LSI_OB_ID_38MS { get { return GetElementByName<IField>(Names.LSI_OB_ID_38MS); } }
        public IField LSI_OB_ID_38 { get { return GetElementByName<IField>(Names.LSI_OB_ID_38); } }
        public IField LSI_OB_ID_38XX { get { return GetElementByName<IField>(Names.LSI_OB_ID_38XX); } }
        public IField LSI_OB_CRTD_TMST_39MS { get { return GetElementByName<IField>(Names.LSI_OB_CRTD_TMST_39MS); } }
        public IField LSI_OB_CRTD_TMST_39 { get { return GetElementByName<IField>(Names.LSI_OB_CRTD_TMST_39); } }
        public IField LSI_OB_CRTD_TMST_39XX { get { return GetElementByName<IField>(Names.LSI_OB_CRTD_TMST_39XX); } }
        public IField LSI_COLL_ID_40MS { get { return GetElementByName<IField>(Names.LSI_COLL_ID_40MS); } }
        public IField LSI_COLL_ID_40 { get { return GetElementByName<IField>(Names.LSI_COLL_ID_40); } }
        public IField LSI_COLL_ID_40XX { get { return GetElementByName<IField>(Names.LSI_COLL_ID_40XX); } }
        public IField LSI_COLL_APPLD_TO_CD_41MS { get { return GetElementByName<IField>(Names.LSI_COLL_APPLD_TO_CD_41MS); } }
        public IField LSI_COLL_APPLD_TO_CD_41 { get { return GetElementByName<IField>(Names.LSI_COLL_APPLD_TO_CD_41); } }
        public IField LSI_COLL_APPLD_TO_CD_41XX { get { return GetElementByName<IField>(Names.LSI_COLL_APPLD_TO_CD_41XX); } }
        public IField LSI_COLL_ADJ_IND_42MS { get { return GetElementByName<IField>(Names.LSI_COLL_ADJ_IND_42MS); } }
        public IField LSI_COLL_ADJ_IND_42 { get { return GetElementByName<IField>(Names.LSI_COLL_ADJ_IND_42); } }
        public IField LSI_COLL_ADJ_IND_42XX { get { return GetElementByName<IField>(Names.LSI_COLL_ADJ_IND_42XX); } }
        public IField LSI_COLL_CONC_IND_43MS { get { return GetElementByName<IField>(Names.LSI_COLL_CONC_IND_43MS); } }
        public IField LSI_COLL_CONC_IND_43 { get { return GetElementByName<IField>(Names.LSI_COLL_CONC_IND_43); } }
        public IField LSI_COLL_CONC_IND_43XX { get { return GetElementByName<IField>(Names.LSI_COLL_CONC_IND_43XX); } }
        public IField LSI_COLL_CRTD_TMST_44MS { get { return GetElementByName<IField>(Names.LSI_COLL_CRTD_TMST_44MS); } }
        public IField LSI_COLL_CRTD_TMST_44 { get { return GetElementByName<IField>(Names.LSI_COLL_CRTD_TMST_44); } }
        public IField LSI_COLL_CRTD_TMST_44XX { get { return GetElementByName<IField>(Names.LSI_COLL_CRTD_TMST_44XX); } }
        public IGroup LSI_V2 { get { return GetElementByName<IGroup>(Names.LSI_V2); } }
        public IGroup LSI_RPT_PARMS_ET { get { return GetElementByName<IGroup>(Names.LSI_RPT_PARMS_ET); } }
        public IField LSI_PARM1_45MS { get { return GetElementByName<IField>(Names.LSI_PARM1_45MS); } }
        public IField LSI_PARM1_45 { get { return GetElementByName<IField>(Names.LSI_PARM1_45); } }
        public IField LSI_PARM1_45XX { get { return GetElementByName<IField>(Names.LSI_PARM1_45XX); } }
        public IField IO_CONTROL_CD { get { return GetElementByName<IField>(Names.IO_CONTROL_CD); } }
        public IField LSI_PARM2_46MS { get { return GetElementByName<IField>(Names.LSI_PARM2_46MS); } }
        public IField LSI_PARM2_46 { get { return GetElementByName<IField>(Names.LSI_PARM2_46); } }
        public IField LSI_PARM2_46XX { get { return GetElementByName<IField>(Names.LSI_PARM2_46XX); } }
        public IField LS_RUNTIME_RPT_TYP_CD { get { return GetElementByName<IField>(Names.LS_RUNTIME_RPT_TYP_CD); } }
        public IGroup LSE_V3 { get { return GetElementByName<IGroup>(Names.LSE_V3); } }
        public IGroup LSE_RPT_PARMS_ET { get { return GetElementByName<IGroup>(Names.LSE_RPT_PARMS_ET); } }
        public IField LSE_PARM1_47MS { get { return GetElementByName<IField>(Names.LSE_PARM1_47MS); } }
        public IField LSE_PARM1_47 { get { return GetElementByName<IField>(Names.LSE_PARM1_47); } }
        public IField LSE_PARM1_47XX { get { return GetElementByName<IField>(Names.LSE_PARM1_47XX); } }
        public IField LS_RETURN_CD { get { return GetElementByName<IField>(Names.LS_RETURN_CD); } }
        public IField LSE_PARM2_48MS { get { return GetElementByName<IField>(Names.LSE_PARM2_48MS); } }
        public IField LSE_PARM2_48 { get { return GetElementByName<IField>(Names.LSE_PARM2_48); } }
        public IField LSE_PARM2_48XX { get { return GetElementByName<IField>(Names.LSE_PARM2_48XX); } }

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
                   PSMGR_TIRDATE_CMCB.CreateNewGroupRedefine("FILLER_d7", PSMGR_TIRDATE_TSTAMP_local, (FILLER_d7) =>
                   {
                       FILLER_d7.CreateNewField(Names.PSMGR_TIRDATE_DATE_Z, FieldType.UnsignedNumeric, 8);
                       FILLER_d7.CreateNewField(Names.PSMGR_TIRDATE_TIME_Z, FieldType.UnsignedNumeric, 8);
                       FILLER_d7.CreateNewFillerField(4, FillWith.Hashes);
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

            recordDef.CreateNewGroup(Names.LSI_V1, (LSI_V1) =>
           {
               LSI_V1.CreateNewGroup(Names.LSI_CASE_VER_EXTR_ET, (LSI_CASE_VER_EXTR_ET) =>
               {
                   LSI_CASE_VER_EXTR_ET.CreateNewField(Names.LSI_DTL_FOR_LN_01MS, FieldType.String, 1);

                   IField LSI_DTL_FOR_LN_01_local = LSI_CASE_VER_EXTR_ET.CreateNewField(Names.LSI_DTL_FOR_LN_01, FieldType.String, 15);
                   LSI_CASE_VER_EXTR_ET.CreateNewFieldRedefine(Names.LSI_DTL_FOR_LN_01XX, FieldType.String, LSI_DTL_FOR_LN_01_local, 15);
                   LSI_CASE_VER_EXTR_ET.CreateNewField(Names.LSI_C_NBR_02MS, FieldType.String, 1);

                   IField LSI_C_NBR_02_local = LSI_CASE_VER_EXTR_ET.CreateNewField(Names.LSI_C_NBR_02, FieldType.String, 10);
                   LSI_CASE_VER_EXTR_ET.CreateNewFieldRedefine(Names.LSI_C_NBR_02XX, FieldType.String, LSI_C_NBR_02_local, 10);
                   LSI_CASE_VER_EXTR_ET.CreateNewField(Names.LSI_C_STAT_03MS, FieldType.String, 1);

                   IField LSI_C_STAT_03_local = LSI_CASE_VER_EXTR_ET.CreateNewField(Names.LSI_C_STAT_03, FieldType.String, 1);
                   LSI_CASE_VER_EXTR_ET.CreateNewFieldRedefine(Names.LSI_C_STAT_03XX, FieldType.String, LSI_C_STAT_03_local, 1);
                   LSI_CASE_VER_EXTR_ET.CreateNewField(Names.LSI_C_STAT_DT_04MS, FieldType.String, 1);

                   IField LSI_C_STAT_DT_04_local = LSI_CASE_VER_EXTR_ET.CreateNewField(Names.LSI_C_STAT_DT_04, FieldType.SignedNumeric, 8);
                   LSI_CASE_VER_EXTR_ET.CreateNewFieldRedefine(Names.LSI_C_STAT_DT_04XX, FieldType.String, LSI_C_STAT_DT_04_local, 8);
                   LSI_CASE_VER_EXTR_ET.CreateNewField(Names.LSI_C_OPN_DT_05MS, FieldType.String, 1);

                   IField LSI_C_OPN_DT_05_local = LSI_CASE_VER_EXTR_ET.CreateNewField(Names.LSI_C_OPN_DT_05, FieldType.SignedNumeric, 8);
                   LSI_CASE_VER_EXTR_ET.CreateNewFieldRedefine(Names.LSI_C_OPN_DT_05XX, FieldType.String, LSI_C_OPN_DT_05_local, 8);
                   LSI_CASE_VER_EXTR_ET.CreateNewField(Names.LSI_CR_ID_06MS, FieldType.String, 1);

                   IField LSI_CR_ID_06_local = LSI_CASE_VER_EXTR_ET.CreateNewField(Names.LSI_CR_ID_06, FieldType.SignedNumeric, 3);
                   LSI_CASE_VER_EXTR_ET.CreateNewFieldRedefine(Names.LSI_CR_ID_06XX, FieldType.String, LSI_CR_ID_06_local, 3);
                   LSI_CASE_VER_EXTR_ET.CreateNewField(Names.LSI_CR_TYP_07MS, FieldType.String, 1);

                   IField LSI_CR_TYP_07_local = LSI_CASE_VER_EXTR_ET.CreateNewField(Names.LSI_CR_TYP_07, FieldType.String, 2);
                   LSI_CASE_VER_EXTR_ET.CreateNewFieldRedefine(Names.LSI_CR_TYP_07XX, FieldType.String, LSI_CR_TYP_07_local, 2);
                   LSI_CASE_VER_EXTR_ET.CreateNewField(Names.LSI_CR_STRT_DT_08MS, FieldType.String, 1);

                   IField LSI_CR_STRT_DT_08_local = LSI_CASE_VER_EXTR_ET.CreateNewField(Names.LSI_CR_STRT_DT_08, FieldType.SignedNumeric, 8);
                   LSI_CASE_VER_EXTR_ET.CreateNewFieldRedefine(Names.LSI_CR_STRT_DT_08XX, FieldType.String, LSI_CR_STRT_DT_08_local, 8);
                   LSI_CASE_VER_EXTR_ET.CreateNewField(Names.LSI_CR_END_DT_09MS, FieldType.String, 1);

                   IField LSI_CR_END_DT_09_local = LSI_CASE_VER_EXTR_ET.CreateNewField(Names.LSI_CR_END_DT_09, FieldType.SignedNumeric, 8);
                   LSI_CASE_VER_EXTR_ET.CreateNewFieldRedefine(Names.LSI_CR_END_DT_09XX, FieldType.String, LSI_CR_END_DT_09_local, 8);
                   LSI_CASE_VER_EXTR_ET.CreateNewField(Names.LSI_CP_TYP_10MS, FieldType.String, 1);

                   IField LSI_CP_TYP_10_local = LSI_CASE_VER_EXTR_ET.CreateNewField(Names.LSI_CP_TYP_10, FieldType.String, 1);
                   LSI_CASE_VER_EXTR_ET.CreateNewFieldRedefine(Names.LSI_CP_TYP_10XX, FieldType.String, LSI_CP_TYP_10_local, 1);
                   LSI_CASE_VER_EXTR_ET.CreateNewField(Names.LSI_CP_NBR_11MS, FieldType.String, 1);

                   IField LSI_CP_NBR_11_local = LSI_CASE_VER_EXTR_ET.CreateNewField(Names.LSI_CP_NBR_11, FieldType.String, 10);
                   LSI_CASE_VER_EXTR_ET.CreateNewFieldRedefine(Names.LSI_CP_NBR_11XX, FieldType.String, LSI_CP_NBR_11_local, 10);
                   LSI_CASE_VER_EXTR_ET.CreateNewField(Names.LSI_PP_CRTD_TMST_12MS, FieldType.String, 1);

                   IField LSI_PP_CRTD_TMST_12_local = LSI_CASE_VER_EXTR_ET.CreateNewField(Names.LSI_PP_CRTD_TMST_12, FieldType.String, 20);
                   LSI_CASE_VER_EXTR_ET.CreateNewFieldRedefine(Names.LSI_PP_CRTD_TMST_12XX, FieldType.String, LSI_PP_CRTD_TMST_12_local, 20);
                   LSI_CASE_VER_EXTR_ET.CreateNewField(Names.LSI_PP_EFF_DT_13MS, FieldType.String, 1);

                   IField LSI_PP_EFF_DT_13_local = LSI_CASE_VER_EXTR_ET.CreateNewField(Names.LSI_PP_EFF_DT_13, FieldType.SignedNumeric, 8);
                   LSI_CASE_VER_EXTR_ET.CreateNewFieldRedefine(Names.LSI_PP_EFF_DT_13XX, FieldType.String, LSI_PP_EFF_DT_13_local, 8);
                   LSI_CASE_VER_EXTR_ET.CreateNewField(Names.LSI_PP_DISC_DT_14MS, FieldType.String, 1);

                   IField LSI_PP_DISC_DT_14_local = LSI_CASE_VER_EXTR_ET.CreateNewField(Names.LSI_PP_DISC_DT_14, FieldType.SignedNumeric, 8);
                   LSI_CASE_VER_EXTR_ET.CreateNewFieldRedefine(Names.LSI_PP_DISC_DT_14XX, FieldType.String, LSI_PP_DISC_DT_14_local, 8);
                   LSI_CASE_VER_EXTR_ET.CreateNewField(Names.LSI_P_CD_15MS, FieldType.String, 1);

                   IField LSI_P_CD_15_local = LSI_CASE_VER_EXTR_ET.CreateNewField(Names.LSI_P_CD_15, FieldType.String, 3);
                   LSI_CASE_VER_EXTR_ET.CreateNewFieldRedefine(Names.LSI_P_CD_15XX, FieldType.String, LSI_P_CD_15_local, 3);
                   LSI_CASE_VER_EXTR_ET.CreateNewField(Names.LSI_P_EFF_DT_16MS, FieldType.String, 1);

                   IField LSI_P_EFF_DT_16_local = LSI_CASE_VER_EXTR_ET.CreateNewField(Names.LSI_P_EFF_DT_16, FieldType.SignedNumeric, 8);
                   LSI_CASE_VER_EXTR_ET.CreateNewFieldRedefine(Names.LSI_P_EFF_DT_16XX, FieldType.String, LSI_P_EFF_DT_16_local, 8);
                   LSI_CASE_VER_EXTR_ET.CreateNewField(Names.LSI_P_DISC_DT_17MS, FieldType.String, 1);

                   IField LSI_P_DISC_DT_17_local = LSI_CASE_VER_EXTR_ET.CreateNewField(Names.LSI_P_DISC_DT_17, FieldType.SignedNumeric, 8);
                   LSI_CASE_VER_EXTR_ET.CreateNewFieldRedefine(Names.LSI_P_DISC_DT_17XX, FieldType.String, LSI_P_DISC_DT_17_local, 8);
                   LSI_CASE_VER_EXTR_ET.CreateNewField(Names.LSI_LACR_CRTD_TMST_18MS, FieldType.String, 1);

                   IField LSI_LACR_CRTD_TMST_18_local = LSI_CASE_VER_EXTR_ET.CreateNewField(Names.LSI_LACR_CRTD_TMST_18, FieldType.String, 20);
                   LSI_CASE_VER_EXTR_ET.CreateNewFieldRedefine(Names.LSI_LACR_CRTD_TMST_18XX, FieldType.String, LSI_LACR_CRTD_TMST_18_local, 20);
                   LSI_CASE_VER_EXTR_ET.CreateNewField(Names.LSI_LA_ID_19MS, FieldType.String, 1);

                   IField LSI_LA_ID_19_local = LSI_CASE_VER_EXTR_ET.CreateNewField(Names.LSI_LA_ID_19, FieldType.SignedNumeric, 9);
                   LSI_CASE_VER_EXTR_ET.CreateNewFieldRedefine(Names.LSI_LA_ID_19XX, FieldType.String, LSI_LA_ID_19_local, 9);
                   LSI_CASE_VER_EXTR_ET.CreateNewField(Names.LSI_LA_ACT_TKN_20MS, FieldType.String, 1);

                   IField LSI_LA_ACT_TKN_20_local = LSI_CASE_VER_EXTR_ET.CreateNewField(Names.LSI_LA_ACT_TKN_20, FieldType.String, 30);
                   LSI_CASE_VER_EXTR_ET.CreateNewFieldRedefine(Names.LSI_LA_ACT_TKN_20XX, FieldType.String, LSI_LA_ACT_TKN_20_local, 30);
                   LSI_CASE_VER_EXTR_ET.CreateNewField(Names.LSI_LA_CRTD_TMST_21MS, FieldType.String, 1);

                   IField LSI_LA_CRTD_TMST_21_local = LSI_CASE_VER_EXTR_ET.CreateNewField(Names.LSI_LA_CRTD_TMST_21, FieldType.String, 20);
                   LSI_CASE_VER_EXTR_ET.CreateNewFieldRedefine(Names.LSI_LA_CRTD_TMST_21XX, FieldType.String, LSI_LA_CRTD_TMST_21_local, 20);
                   LSI_CASE_VER_EXTR_ET.CreateNewField(Names.LSI_LA_FLD_DT_22MS, FieldType.String, 1);

                   IField LSI_LA_FLD_DT_22_local = LSI_CASE_VER_EXTR_ET.CreateNewField(Names.LSI_LA_FLD_DT_22, FieldType.SignedNumeric, 8);
                   LSI_CASE_VER_EXTR_ET.CreateNewFieldRedefine(Names.LSI_LA_FLD_DT_22XX, FieldType.String, LSI_LA_FLD_DT_22_local, 8);
                   LSI_CASE_VER_EXTR_ET.CreateNewField(Names.LSI_LAD_NBR_23MS, FieldType.String, 1);

                   IField LSI_LAD_NBR_23_local = LSI_CASE_VER_EXTR_ET.CreateNewField(Names.LSI_LAD_NBR_23, FieldType.SignedNumeric, 2);
                   LSI_CASE_VER_EXTR_ET.CreateNewFieldRedefine(Names.LSI_LAD_NBR_23XX, FieldType.String, LSI_LAD_NBR_23_local, 2);
                   LSI_CASE_VER_EXTR_ET.CreateNewField(Names.LSI_LAD_DTL_TYP_24MS, FieldType.String, 1);

                   IField LSI_LAD_DTL_TYP_24_local = LSI_CASE_VER_EXTR_ET.CreateNewField(Names.LSI_LAD_DTL_TYP_24, FieldType.String, 1);
                   LSI_CASE_VER_EXTR_ET.CreateNewFieldRedefine(Names.LSI_LAD_DTL_TYP_24XX, FieldType.String, LSI_LAD_DTL_TYP_24_local, 1);
                   LSI_CASE_VER_EXTR_ET.CreateNewField(Names.LSI_LAD_CRTD_TMST_25MS, FieldType.String, 1);

                   IField LSI_LAD_CRTD_TMST_25_local = LSI_CASE_VER_EXTR_ET.CreateNewField(Names.LSI_LAD_CRTD_TMST_25, FieldType.String, 20);
                   LSI_CASE_VER_EXTR_ET.CreateNewFieldRedefine(Names.LSI_LAD_CRTD_TMST_25XX, FieldType.String, LSI_LAD_CRTD_TMST_25_local, 20);
                   LSI_CASE_VER_EXTR_ET.CreateNewField(Names.LSI_LAD_NON_FIN_OB_TYP_26MS, FieldType.String, 1);

                   IField LSI_LAD_NON_FIN_OB_TYP_26_local = LSI_CASE_VER_EXTR_ET.CreateNewField(Names.LSI_LAD_NON_FIN_OB_TYP_26, FieldType.String, 4);
                   LSI_CASE_VER_EXTR_ET.CreateNewFieldRedefine(Names.LSI_LAD_NON_FIN_OB_TYP_26XX, FieldType.String, LSI_LAD_NON_FIN_OB_TYP_26_local, 4);
                   LSI_CASE_VER_EXTR_ET.CreateNewField(Names.LSI_OT_CD_27MS, FieldType.String, 1);

                   IField LSI_OT_CD_27_local = LSI_CASE_VER_EXTR_ET.CreateNewField(Names.LSI_OT_CD_27, FieldType.String, 7);
                   LSI_CASE_VER_EXTR_ET.CreateNewFieldRedefine(Names.LSI_OT_CD_27XX, FieldType.String, LSI_OT_CD_27_local, 7);
                   LSI_CASE_VER_EXTR_ET.CreateNewField(Names.LSI_OT_CLS_28MS, FieldType.String, 1);

                   IField LSI_OT_CLS_28_local = LSI_CASE_VER_EXTR_ET.CreateNewField(Names.LSI_OT_CLS_28, FieldType.String, 1);
                   LSI_CASE_VER_EXTR_ET.CreateNewFieldRedefine(Names.LSI_OT_CLS_28XX, FieldType.String, LSI_OT_CLS_28_local, 1);
                   LSI_CASE_VER_EXTR_ET.CreateNewField(Names.LSI_DD_DUE_DT_29MS, FieldType.String, 1);

                   IField LSI_DD_DUE_DT_29_local = LSI_CASE_VER_EXTR_ET.CreateNewField(Names.LSI_DD_DUE_DT_29, FieldType.SignedNumeric, 8);
                   LSI_CASE_VER_EXTR_ET.CreateNewFieldRedefine(Names.LSI_DD_DUE_DT_29XX, FieldType.String, LSI_DD_DUE_DT_29_local, 8);
                   LSI_CASE_VER_EXTR_ET.CreateNewField(Names.LSI_DD_BAL_DUE_AMT_30MS, FieldType.String, 1);

                   IField LSI_DD_BAL_DUE_AMT_30_local = LSI_CASE_VER_EXTR_ET.CreateNewField(Names.LSI_DD_BAL_DUE_AMT_30, FieldType.SignedNumeric, 9, null, 2);
                   LSI_CASE_VER_EXTR_ET.CreateNewFieldRedefine(Names.LSI_DD_BAL_DUE_AMT_30XX, FieldType.String, LSI_DD_BAL_DUE_AMT_30_local, 9);
                   LSI_CASE_VER_EXTR_ET.CreateNewField(Names.LSI_DD_INT_BAL_DUE_31MS, FieldType.String, 1);

                   IField LSI_DD_INT_BAL_DUE_31_local = LSI_CASE_VER_EXTR_ET.CreateNewField(Names.LSI_DD_INT_BAL_DUE_31, FieldType.SignedNumeric, 6, null, 2);
                   LSI_CASE_VER_EXTR_ET.CreateNewFieldRedefine(Names.LSI_DD_INT_BAL_DUE_31XX, FieldType.String, LSI_DD_INT_BAL_DUE_31_local, 6);
                   LSI_CASE_VER_EXTR_ET.CreateNewField(Names.LSI_DD_CRTD_TMST_32MS, FieldType.String, 1);

                   IField LSI_DD_CRTD_TMST_32_local = LSI_CASE_VER_EXTR_ET.CreateNewField(Names.LSI_DD_CRTD_TMST_32, FieldType.String, 20);
                   LSI_CASE_VER_EXTR_ET.CreateNewFieldRedefine(Names.LSI_DD_CRTD_TMST_32XX, FieldType.String, LSI_DD_CRTD_TMST_32_local, 20);
                   LSI_CASE_VER_EXTR_ET.CreateNewField(Names.LSI_CPA_TYP_33MS, FieldType.String, 1);

                   IField LSI_CPA_TYP_33_local = LSI_CASE_VER_EXTR_ET.CreateNewField(Names.LSI_CPA_TYP_33, FieldType.String, 1);
                   LSI_CASE_VER_EXTR_ET.CreateNewFieldRedefine(Names.LSI_CPA_TYP_33XX, FieldType.String, LSI_CPA_TYP_33_local, 1);
                   LSI_CASE_VER_EXTR_ET.CreateNewField(Names.LSI_CPA_CRTD_TMST_34MS, FieldType.String, 1);

                   IField LSI_CPA_CRTD_TMST_34_local = LSI_CASE_VER_EXTR_ET.CreateNewField(Names.LSI_CPA_CRTD_TMST_34, FieldType.String, 20);
                   LSI_CASE_VER_EXTR_ET.CreateNewFieldRedefine(Names.LSI_CPA_CRTD_TMST_34XX, FieldType.String, LSI_CPA_CRTD_TMST_34_local, 20);
                   LSI_CASE_VER_EXTR_ET.CreateNewField(Names.LSI_OB_TRN_ID_35MS, FieldType.String, 1);

                   IField LSI_OB_TRN_ID_35_local = LSI_CASE_VER_EXTR_ET.CreateNewField(Names.LSI_OB_TRN_ID_35, FieldType.SignedNumeric, 9);
                   LSI_CASE_VER_EXTR_ET.CreateNewFieldRedefine(Names.LSI_OB_TRN_ID_35XX, FieldType.String, LSI_OB_TRN_ID_35_local, 9);
                   LSI_CASE_VER_EXTR_ET.CreateNewField(Names.LSI_OB_TRN_TYP_36MS, FieldType.String, 1);

                   IField LSI_OB_TRN_TYP_36_local = LSI_CASE_VER_EXTR_ET.CreateNewField(Names.LSI_OB_TRN_TYP_36, FieldType.String, 2);
                   LSI_CASE_VER_EXTR_ET.CreateNewFieldRedefine(Names.LSI_OB_TRN_TYP_36XX, FieldType.String, LSI_OB_TRN_TYP_36_local, 2);
                   LSI_CASE_VER_EXTR_ET.CreateNewField(Names.LSI_OB_TRN_CRTD_TMST_37MS, FieldType.String, 1);

                   IField LSI_OB_TRN_CRTD_TMST_37_local = LSI_CASE_VER_EXTR_ET.CreateNewField(Names.LSI_OB_TRN_CRTD_TMST_37, FieldType.String, 20);
                   LSI_CASE_VER_EXTR_ET.CreateNewFieldRedefine(Names.LSI_OB_TRN_CRTD_TMST_37XX, FieldType.String, LSI_OB_TRN_CRTD_TMST_37_local, 20);
                   LSI_CASE_VER_EXTR_ET.CreateNewField(Names.LSI_OB_ID_38MS, FieldType.String, 1);

                   IField LSI_OB_ID_38_local = LSI_CASE_VER_EXTR_ET.CreateNewField(Names.LSI_OB_ID_38, FieldType.SignedNumeric, 3);
                   LSI_CASE_VER_EXTR_ET.CreateNewFieldRedefine(Names.LSI_OB_ID_38XX, FieldType.String, LSI_OB_ID_38_local, 3);
                   LSI_CASE_VER_EXTR_ET.CreateNewField(Names.LSI_OB_CRTD_TMST_39MS, FieldType.String, 1);

                   IField LSI_OB_CRTD_TMST_39_local = LSI_CASE_VER_EXTR_ET.CreateNewField(Names.LSI_OB_CRTD_TMST_39, FieldType.String, 20);
                   LSI_CASE_VER_EXTR_ET.CreateNewFieldRedefine(Names.LSI_OB_CRTD_TMST_39XX, FieldType.String, LSI_OB_CRTD_TMST_39_local, 20);
                   LSI_CASE_VER_EXTR_ET.CreateNewField(Names.LSI_COLL_ID_40MS, FieldType.String, 1);

                   IField LSI_COLL_ID_40_local = LSI_CASE_VER_EXTR_ET.CreateNewField(Names.LSI_COLL_ID_40, FieldType.SignedNumeric, 9);
                   LSI_CASE_VER_EXTR_ET.CreateNewFieldRedefine(Names.LSI_COLL_ID_40XX, FieldType.String, LSI_COLL_ID_40_local, 9);
                   LSI_CASE_VER_EXTR_ET.CreateNewField(Names.LSI_COLL_APPLD_TO_CD_41MS, FieldType.String, 1);

                   IField LSI_COLL_APPLD_TO_CD_41_local = LSI_CASE_VER_EXTR_ET.CreateNewField(Names.LSI_COLL_APPLD_TO_CD_41, FieldType.String, 1);
                   LSI_CASE_VER_EXTR_ET.CreateNewFieldRedefine(Names.LSI_COLL_APPLD_TO_CD_41XX, FieldType.String, LSI_COLL_APPLD_TO_CD_41_local, 1);
                   LSI_CASE_VER_EXTR_ET.CreateNewField(Names.LSI_COLL_ADJ_IND_42MS, FieldType.String, 1);

                   IField LSI_COLL_ADJ_IND_42_local = LSI_CASE_VER_EXTR_ET.CreateNewField(Names.LSI_COLL_ADJ_IND_42, FieldType.String, 1);
                   LSI_CASE_VER_EXTR_ET.CreateNewFieldRedefine(Names.LSI_COLL_ADJ_IND_42XX, FieldType.String, LSI_COLL_ADJ_IND_42_local, 1);
                   LSI_CASE_VER_EXTR_ET.CreateNewField(Names.LSI_COLL_CONC_IND_43MS, FieldType.String, 1);

                   IField LSI_COLL_CONC_IND_43_local = LSI_CASE_VER_EXTR_ET.CreateNewField(Names.LSI_COLL_CONC_IND_43, FieldType.String, 1);
                   LSI_CASE_VER_EXTR_ET.CreateNewFieldRedefine(Names.LSI_COLL_CONC_IND_43XX, FieldType.String, LSI_COLL_CONC_IND_43_local, 1);
                   LSI_CASE_VER_EXTR_ET.CreateNewField(Names.LSI_COLL_CRTD_TMST_44MS, FieldType.String, 1);

                   IField LSI_COLL_CRTD_TMST_44_local = LSI_CASE_VER_EXTR_ET.CreateNewField(Names.LSI_COLL_CRTD_TMST_44, FieldType.String, 20);
                   LSI_CASE_VER_EXTR_ET.CreateNewFieldRedefine(Names.LSI_COLL_CRTD_TMST_44XX, FieldType.String, LSI_COLL_CRTD_TMST_44_local, 20);
               });
           });

            recordDef.CreateNewGroup(Names.LSI_V2, (LSI_V2) =>
           {
               LSI_V2.CreateNewGroup(Names.LSI_RPT_PARMS_ET, (LSI_RPT_PARMS_ET) =>
               {
                   LSI_RPT_PARMS_ET.CreateNewField(Names.LSI_PARM1_45MS, FieldType.String, 1);

                   IField LSI_PARM1_45_local = LSI_RPT_PARMS_ET.CreateNewField(Names.LSI_PARM1_45, FieldType.String, 2);
                   LSI_RPT_PARMS_ET.CreateNewFieldRedefine(Names.LSI_PARM1_45XX, FieldType.String, LSI_PARM1_45_local, 2);
                   LSI_RPT_PARMS_ET.CreateNewFieldRedefine(Names.IO_CONTROL_CD, FieldType.String, LSI_PARM1_45_local, 2);
                   LSI_RPT_PARMS_ET.CreateNewField(Names.LSI_PARM2_46MS, FieldType.String, 1);

                   IField LSI_PARM2_46_local = LSI_RPT_PARMS_ET.CreateNewField(Names.LSI_PARM2_46, FieldType.String, 2);
                   LSI_RPT_PARMS_ET.CreateNewFieldRedefine(Names.LSI_PARM2_46XX, FieldType.String, LSI_PARM2_46_local, 2);
                   LSI_RPT_PARMS_ET.CreateNewFieldRedefine(Names.LS_RUNTIME_RPT_TYP_CD, FieldType.String, LSI_PARM2_46_local, 2);
               });
           });

            recordDef.CreateNewGroup(Names.LSE_V3, (LSE_V3) =>
           {
               LSE_V3.CreateNewGroup(Names.LSE_RPT_PARMS_ET, (LSE_RPT_PARMS_ET) =>
               {
                   LSE_RPT_PARMS_ET.CreateNewField(Names.LSE_PARM1_47MS, FieldType.String, 1);

                   IField LSE_PARM1_47_local = LSE_RPT_PARMS_ET.CreateNewField(Names.LSE_PARM1_47, FieldType.String, 2);
                   LSE_RPT_PARMS_ET.CreateNewFieldRedefine(Names.LSE_PARM1_47XX, FieldType.String, LSE_PARM1_47_local, 2);
                   LSE_RPT_PARMS_ET.CreateNewFieldRedefine(Names.LS_RETURN_CD, FieldType.String, LSE_PARM1_47_local, 2);
                   LSE_RPT_PARMS_ET.CreateNewField(Names.LSE_PARM2_48MS, FieldType.String, 1);

                   IField LSE_PARM2_48_local = LSE_RPT_PARMS_ET.CreateNewField(Names.LSE_PARM2_48, FieldType.String, 2);
                   LSE_RPT_PARMS_ET.CreateNewFieldRedefine(Names.LSE_PARM2_48XX, FieldType.String, LSE_PARM2_48_local, 2);
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
            SetPassedParm(LSI_V1, args, 3);
            SetPassedParm(LSI_V2, args, 4);
            SetPassedParm(LSE_V3, args, 5);
        }


        public void UpdateReturnParameters(object[] args)
        {
            SetReturnParm(TI_RUNTIME_PARM1, args, 0);
            SetReturnParm(TI_RUNTIME_PARM2, args, 1);
            SetReturnParm(GLOBDATA, args, 2);
            SetReturnParm(LSI_V1, args, 3);
            SetReturnParm(LSI_V2, args, 4);
            SetReturnParm(LSE_V3, args, 5);
        }
    }
    #endregion Linkage Section Class

    #region Business Logic Class
    public class SWEXF715 : EABBase
    {

        #region Public Constructors
        public SWEXF715()
            : base()
        {
            this.ProgramName.SetValue("SWEXF715");

            WS = new SWEXF715_ws();
            FD = new SWEXF715_fd(WS);
            LS = new SWEXF715_ls();
        }

        #endregion

        #region Private Fields


        //==== Working Storage Data Class ========================================
        private SWEXF715_ws WS;

        //==== File Data Class ========================================
        private SWEXF715_fd FD;

        //==== Linkage Section Data Class ========================================
        private SWEXF715_ls LS;
        #endregion

        #region Public Methods
        //========================================================================
        //==== RunMain Entry Point Method ========================================
        //========================================================================
        public override int ExecuteMain(params object[] args)                                              //COBOL==> PROCEDURE DIVISION USING TI-RUNTIME-PARM1 , TI-RUNTIME-PARM2 , GLOBDATA , LSI-V1 , LSI-V2 , LSE-V3.
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
                FD.SEQ_FILE.WriteLine(WS.WS_SEQFILE_REC.AsBytes);                                                   //COBOL==> WRITE SEQFILE-REC FROM WS-SEQFILE-REC
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
            if ((LS.LSI_DTL_FOR_LN_01XX.IsEqualTo(HIGH_VALUES))
             || (LS.LSI_DTL_FOR_LN_01XX.IsEqualTo(LOW_VALUES)))  //COBOL==> IF LSI-DTL-FOR-LN-01XX = HIGH-VALUES OR LSI-DTL-FOR-LN-01XX = LOW-VALUES
            {
                LS.LSI_DTL_FOR_LN_01.SetValueWithSpaces();                                                          //COBOL==> MOVE SPACES TO LSI-DTL-FOR-LN-01
            }                                                                                                   //COBOL==> END-IF.
            if ((LS.LSI_C_NBR_02XX.IsEqualTo(HIGH_VALUES))
             || (LS.LSI_C_NBR_02XX.IsEqualTo(LOW_VALUES)))  //COBOL==> IF LSI-C-NBR-02XX = HIGH-VALUES OR LSI-C-NBR-02XX = LOW-VALUES
            {
                LS.LSI_C_NBR_02.SetValueWithSpaces();                                                               //COBOL==> MOVE SPACES TO LSI-C-NBR-02
            }                                                                                                   //COBOL==> END-IF.
            if ((LS.LSI_C_STAT_03XX.IsEqualTo(HIGH_VALUES))
             || (LS.LSI_C_STAT_03XX.IsEqualTo(LOW_VALUES)))  //COBOL==> IF LSI-C-STAT-03XX = HIGH-VALUES OR LSI-C-STAT-03XX = LOW-VALUES
            {
                LS.LSI_C_STAT_03.SetValueWithSpaces();                                                              //COBOL==> MOVE SPACES TO LSI-C-STAT-03
            }                                                                                                   //COBOL==> END-IF.
            if (!(LS.LSI_C_STAT_DT_04.IsNumericValue()))                                                       //COBOL==> IF LSI-C-STAT-DT-04 IS NOT NUMERIC
            {
                LS.LSI_C_STAT_DT_04.SetValueWithZeroes();                                                           //COBOL==> MOVE ZEROS TO LSI-C-STAT-DT-04
            }                                                                                                   //COBOL==> END-IF.
            if (!(LS.LSI_C_OPN_DT_05.IsNumericValue()))                                                        //COBOL==> IF LSI-C-OPN-DT-05 IS NOT NUMERIC
            {
                LS.LSI_C_OPN_DT_05.SetValueWithZeroes();                                                            //COBOL==> MOVE ZEROS TO LSI-C-OPN-DT-05
            }                                                                                                   //COBOL==> END-IF.
            if (!(LS.LSI_CR_ID_06.IsNumericValue()))                                                           //COBOL==> IF LSI-CR-ID-06 IS NOT NUMERIC
            {
                LS.LSI_CR_ID_06.SetValueWithZeroes();                                                               //COBOL==> MOVE ZEROS TO LSI-CR-ID-06
            }                                                                                                   //COBOL==> END-IF.
            if ((LS.LSI_CR_TYP_07XX.IsEqualTo(HIGH_VALUES))
             || (LS.LSI_CR_TYP_07XX.IsEqualTo(LOW_VALUES)))  //COBOL==> IF LSI-CR-TYP-07XX = HIGH-VALUES OR LSI-CR-TYP-07XX = LOW-VALUES
            {
                LS.LSI_CR_TYP_07.SetValueWithSpaces();                                                              //COBOL==> MOVE SPACES TO LSI-CR-TYP-07
            }                                                                                                   //COBOL==> END-IF.
            if (!(LS.LSI_CR_STRT_DT_08.IsNumericValue()))                                                      //COBOL==> IF LSI-CR-STRT-DT-08 IS NOT NUMERIC
            {
                LS.LSI_CR_STRT_DT_08.SetValueWithZeroes();                                                          //COBOL==> MOVE ZEROS TO LSI-CR-STRT-DT-08
            }                                                                                                   //COBOL==> END-IF.
            if (!(LS.LSI_CR_END_DT_09.IsNumericValue()))                                                       //COBOL==> IF LSI-CR-END-DT-09 IS NOT NUMERIC
            {
                LS.LSI_CR_END_DT_09.SetValueWithZeroes();                                                           //COBOL==> MOVE ZEROS TO LSI-CR-END-DT-09
            }                                                                                                   //COBOL==> END-IF.
            if ((LS.LSI_CP_TYP_10XX.IsEqualTo(HIGH_VALUES))
             || (LS.LSI_CP_TYP_10XX.IsEqualTo(LOW_VALUES)))  //COBOL==> IF LSI-CP-TYP-10XX = HIGH-VALUES OR LSI-CP-TYP-10XX = LOW-VALUES
            {
                LS.LSI_CP_TYP_10.SetValueWithSpaces();                                                              //COBOL==> MOVE SPACES TO LSI-CP-TYP-10
            }                                                                                                   //COBOL==> END-IF.
            if ((LS.LSI_CP_NBR_11XX.IsEqualTo(HIGH_VALUES))
             || (LS.LSI_CP_NBR_11XX.IsEqualTo(LOW_VALUES)))  //COBOL==> IF LSI-CP-NBR-11XX = HIGH-VALUES OR LSI-CP-NBR-11XX = LOW-VALUES
            {
                LS.LSI_CP_NBR_11.SetValueWithSpaces();                                                              //COBOL==> MOVE SPACES TO LSI-CP-NBR-11
            }                                                                                                   //COBOL==> END-IF.
            if ((LS.LSI_PP_CRTD_TMST_12XX.IsEqualTo(HIGH_VALUES))
             || (LS.LSI_PP_CRTD_TMST_12XX.IsEqualTo(LOW_VALUES)))  //COBOL==> IF LSI-PP-CRTD-TMST-12XX = HIGH-VALUES OR LSI-PP-CRTD-TMST-12XX = LOW-VALUES
            {
                LS.LSI_PP_CRTD_TMST_12.SetValueWithSpaces();                                                        //COBOL==> MOVE SPACES TO LSI-PP-CRTD-TMST-12
            }                                                                                                   //COBOL==> END-IF.
            if (!(LS.LSI_PP_EFF_DT_13.IsNumericValue()))                                                       //COBOL==> IF LSI-PP-EFF-DT-13 IS NOT NUMERIC
            {
                LS.LSI_PP_EFF_DT_13.SetValueWithZeroes();                                                           //COBOL==> MOVE ZEROS TO LSI-PP-EFF-DT-13
            }                                                                                                   //COBOL==> END-IF.
            if (!(LS.LSI_PP_DISC_DT_14.IsNumericValue()))                                                      //COBOL==> IF LSI-PP-DISC-DT-14 IS NOT NUMERIC
            {
                LS.LSI_PP_DISC_DT_14.SetValueWithZeroes();                                                          //COBOL==> MOVE ZEROS TO LSI-PP-DISC-DT-14
            }                                                                                                   //COBOL==> END-IF.
            if ((LS.LSI_P_CD_15XX.IsEqualTo(HIGH_VALUES))
             || (LS.LSI_P_CD_15XX.IsEqualTo(LOW_VALUES)))  //COBOL==> IF LSI-P-CD-15XX = HIGH-VALUES OR LSI-P-CD-15XX = LOW-VALUES
            {
                LS.LSI_P_CD_15.SetValueWithSpaces();                                                                //COBOL==> MOVE SPACES TO LSI-P-CD-15
            }                                                                                                   //COBOL==> END-IF.
            if (!(LS.LSI_P_EFF_DT_16.IsNumericValue()))                                                        //COBOL==> IF LSI-P-EFF-DT-16 IS NOT NUMERIC
            {
                LS.LSI_P_EFF_DT_16.SetValueWithZeroes();                                                            //COBOL==> MOVE ZEROS TO LSI-P-EFF-DT-16
            }                                                                                                   //COBOL==> END-IF.
            if (!(LS.LSI_P_DISC_DT_17.IsNumericValue()))                                                       //COBOL==> IF LSI-P-DISC-DT-17 IS NOT NUMERIC
            {
                LS.LSI_P_DISC_DT_17.SetValueWithZeroes();                                                           //COBOL==> MOVE ZEROS TO LSI-P-DISC-DT-17
            }                                                                                                   //COBOL==> END-IF.
            if ((LS.LSI_LACR_CRTD_TMST_18XX.IsEqualTo(HIGH_VALUES))
             || (LS.LSI_LACR_CRTD_TMST_18XX.IsEqualTo(LOW_VALUES)))  //COBOL==> IF LSI-LACR-CRTD-TMST-18XX = HIGH-VALUES OR LSI-LACR-CRTD-TMST-18XX = LOW-VALUES
            {
                LS.LSI_LACR_CRTD_TMST_18.SetValueWithSpaces();                                                      //COBOL==> MOVE SPACES TO LSI-LACR-CRTD-TMST-18
            }                                                                                                   //COBOL==> END-IF.
            if (!(LS.LSI_LA_ID_19.IsNumericValue()))                                                           //COBOL==> IF LSI-LA-ID-19 IS NOT NUMERIC
            {
                LS.LSI_LA_ID_19.SetValueWithZeroes();                                                               //COBOL==> MOVE ZEROS TO LSI-LA-ID-19
            }                                                                                                   //COBOL==> END-IF.
            if ((LS.LSI_LA_ACT_TKN_20XX.IsEqualTo(HIGH_VALUES))
             || (LS.LSI_LA_ACT_TKN_20XX.IsEqualTo(LOW_VALUES)))  //COBOL==> IF LSI-LA-ACT-TKN-20XX = HIGH-VALUES OR LSI-LA-ACT-TKN-20XX = LOW-VALUES
            {
                LS.LSI_LA_ACT_TKN_20.SetValueWithSpaces();                                                          //COBOL==> MOVE SPACES TO LSI-LA-ACT-TKN-20
            }                                                                                                   //COBOL==> END-IF.
            if ((LS.LSI_LA_CRTD_TMST_21XX.IsEqualTo(HIGH_VALUES))
             || (LS.LSI_LA_CRTD_TMST_21XX.IsEqualTo(LOW_VALUES)))  //COBOL==> IF LSI-LA-CRTD-TMST-21XX = HIGH-VALUES OR LSI-LA-CRTD-TMST-21XX = LOW-VALUES
            {
                LS.LSI_LA_CRTD_TMST_21.SetValueWithSpaces();                                                        //COBOL==> MOVE SPACES TO LSI-LA-CRTD-TMST-21
            }                                                                                                   //COBOL==> END-IF.
            if (!(LS.LSI_LA_FLD_DT_22.IsNumericValue()))                                                       //COBOL==> IF LSI-LA-FLD-DT-22 IS NOT NUMERIC
            {
                LS.LSI_LA_FLD_DT_22.SetValueWithZeroes();                                                           //COBOL==> MOVE ZEROS TO LSI-LA-FLD-DT-22
            }                                                                                                   //COBOL==> END-IF.
            if (!(LS.LSI_LAD_NBR_23.IsNumericValue()))                                                         //COBOL==> IF LSI-LAD-NBR-23 IS NOT NUMERIC
            {
                LS.LSI_LAD_NBR_23.SetValueWithZeroes();                                                             //COBOL==> MOVE ZEROS TO LSI-LAD-NBR-23
            }                                                                                                   //COBOL==> END-IF.
            if ((LS.LSI_LAD_DTL_TYP_24XX.IsEqualTo(HIGH_VALUES))
             || (LS.LSI_LAD_DTL_TYP_24XX.IsEqualTo(LOW_VALUES)))  //COBOL==> IF LSI-LAD-DTL-TYP-24XX = HIGH-VALUES OR LSI-LAD-DTL-TYP-24XX = LOW-VALUES
            {
                LS.LSI_LAD_DTL_TYP_24.SetValueWithSpaces();                                                         //COBOL==> MOVE SPACES TO LSI-LAD-DTL-TYP-24
            }                                                                                                   //COBOL==> END-IF.
            if ((LS.LSI_LAD_CRTD_TMST_25XX.IsEqualTo(HIGH_VALUES))
             || (LS.LSI_LAD_CRTD_TMST_25XX.IsEqualTo(LOW_VALUES)))  //COBOL==> IF LSI-LAD-CRTD-TMST-25XX = HIGH-VALUES OR LSI-LAD-CRTD-TMST-25XX = LOW-VALUES
            {
                LS.LSI_LAD_CRTD_TMST_25.SetValueWithSpaces();                                                       //COBOL==> MOVE SPACES TO LSI-LAD-CRTD-TMST-25
            }                                                                                                   //COBOL==> END-IF.
            if ((LS.LSI_LAD_NON_FIN_OB_TYP_26XX.IsEqualTo(HIGH_VALUES))
             || (LS.LSI_LAD_NON_FIN_OB_TYP_26XX.IsEqualTo(LOW_VALUES)))  //COBOL==> IF LSI-LAD-NON-FIN-OB-TYP-26XX = HIGH-VALUES OR LSI-LAD-NON-FIN-OB-TYP-26XX = LOW-VALUES
            {
                LS.LSI_LAD_NON_FIN_OB_TYP_26.SetValueWithSpaces();                                                  //COBOL==> MOVE SPACES TO LSI-LAD-NON-FIN-OB-TYP-26
            }                                                                                                   //COBOL==> END-IF.
            if ((LS.LSI_OT_CD_27XX.IsEqualTo(HIGH_VALUES))
             || (LS.LSI_OT_CD_27XX.IsEqualTo(LOW_VALUES)))  //COBOL==> IF LSI-OT-CD-27XX = HIGH-VALUES OR LSI-OT-CD-27XX = LOW-VALUES
            {
                LS.LSI_OT_CD_27.SetValueWithSpaces();                                                               //COBOL==> MOVE SPACES TO LSI-OT-CD-27
            }                                                                                                   //COBOL==> END-IF.
            if ((LS.LSI_OT_CLS_28XX.IsEqualTo(HIGH_VALUES))
             || (LS.LSI_OT_CLS_28XX.IsEqualTo(LOW_VALUES)))  //COBOL==> IF LSI-OT-CLS-28XX = HIGH-VALUES OR LSI-OT-CLS-28XX = LOW-VALUES
            {
                LS.LSI_OT_CLS_28.SetValueWithSpaces();                                                              //COBOL==> MOVE SPACES TO LSI-OT-CLS-28
            }                                                                                                   //COBOL==> END-IF.
            if (!(LS.LSI_DD_DUE_DT_29.IsNumericValue()))                                                       //COBOL==> IF LSI-DD-DUE-DT-29 IS NOT NUMERIC
            {
                LS.LSI_DD_DUE_DT_29.SetValueWithZeroes();                                                           //COBOL==> MOVE ZEROS TO LSI-DD-DUE-DT-29
            }                                                                                                   //COBOL==> END-IF.
            if (!(LS.LSI_DD_BAL_DUE_AMT_30.IsNumericValue()))                                                  //COBOL==> IF LSI-DD-BAL-DUE-AMT-30 IS NOT NUMERIC
            {
                LS.LSI_DD_BAL_DUE_AMT_30.SetValueWithZeroes();                                                      //COBOL==> MOVE ZEROS TO LSI-DD-BAL-DUE-AMT-30
            }                                                                                                   //COBOL==> END-IF.
            if (!(LS.LSI_DD_INT_BAL_DUE_31.IsNumericValue()))                                                  //COBOL==> IF LSI-DD-INT-BAL-DUE-31 IS NOT NUMERIC
            {
                LS.LSI_DD_INT_BAL_DUE_31.SetValueWithZeroes();                                                      //COBOL==> MOVE ZEROS TO LSI-DD-INT-BAL-DUE-31
            }                                                                                                   //COBOL==> END-IF.
            if ((LS.LSI_DD_CRTD_TMST_32XX.IsEqualTo(HIGH_VALUES))
             || (LS.LSI_DD_CRTD_TMST_32XX.IsEqualTo(LOW_VALUES)))  //COBOL==> IF LSI-DD-CRTD-TMST-32XX = HIGH-VALUES OR LSI-DD-CRTD-TMST-32XX = LOW-VALUES
            {
                LS.LSI_DD_CRTD_TMST_32.SetValueWithSpaces();                                                        //COBOL==> MOVE SPACES TO LSI-DD-CRTD-TMST-32
            }                                                                                                   //COBOL==> END-IF.
            if ((LS.LSI_CPA_TYP_33XX.IsEqualTo(HIGH_VALUES))
             || (LS.LSI_CPA_TYP_33XX.IsEqualTo(LOW_VALUES)))  //COBOL==> IF LSI-CPA-TYP-33XX = HIGH-VALUES OR LSI-CPA-TYP-33XX = LOW-VALUES
            {
                LS.LSI_CPA_TYP_33.SetValueWithSpaces();                                                             //COBOL==> MOVE SPACES TO LSI-CPA-TYP-33
            }                                                                                                   //COBOL==> END-IF.
            if ((LS.LSI_CPA_CRTD_TMST_34XX.IsEqualTo(HIGH_VALUES))
             || (LS.LSI_CPA_CRTD_TMST_34XX.IsEqualTo(LOW_VALUES)))  //COBOL==> IF LSI-CPA-CRTD-TMST-34XX = HIGH-VALUES OR LSI-CPA-CRTD-TMST-34XX = LOW-VALUES
            {
                LS.LSI_CPA_CRTD_TMST_34.SetValueWithSpaces();                                                       //COBOL==> MOVE SPACES TO LSI-CPA-CRTD-TMST-34
            }                                                                                                   //COBOL==> END-IF.
            if (!(LS.LSI_OB_TRN_ID_35.IsNumericValue()))                                                       //COBOL==> IF LSI-OB-TRN-ID-35 IS NOT NUMERIC
            {
                LS.LSI_OB_TRN_ID_35.SetValueWithZeroes();                                                           //COBOL==> MOVE ZEROS TO LSI-OB-TRN-ID-35
            }                                                                                                   //COBOL==> END-IF.
            if ((LS.LSI_OB_TRN_TYP_36XX.IsEqualTo(HIGH_VALUES))
             || (LS.LSI_OB_TRN_TYP_36XX.IsEqualTo(LOW_VALUES)))  //COBOL==> IF LSI-OB-TRN-TYP-36XX = HIGH-VALUES OR LSI-OB-TRN-TYP-36XX = LOW-VALUES
            {
                LS.LSI_OB_TRN_TYP_36.SetValueWithSpaces();                                                          //COBOL==> MOVE SPACES TO LSI-OB-TRN-TYP-36
            }                                                                                                   //COBOL==> END-IF.
            if ((LS.LSI_OB_TRN_CRTD_TMST_37XX.IsEqualTo(HIGH_VALUES))
             || (LS.LSI_OB_TRN_CRTD_TMST_37XX.IsEqualTo(LOW_VALUES)))  //COBOL==> IF LSI-OB-TRN-CRTD-TMST-37XX = HIGH-VALUES OR LSI-OB-TRN-CRTD-TMST-37XX = LOW-VALUES
            {
                LS.LSI_OB_TRN_CRTD_TMST_37.SetValueWithSpaces();                                                    //COBOL==> MOVE SPACES TO LSI-OB-TRN-CRTD-TMST-37
            }                                                                                                   //COBOL==> END-IF.
            if (!(LS.LSI_OB_ID_38.IsNumericValue()))                                                           //COBOL==> IF LSI-OB-ID-38 IS NOT NUMERIC
            {
                LS.LSI_OB_ID_38.SetValueWithZeroes();                                                               //COBOL==> MOVE ZEROS TO LSI-OB-ID-38
            }                                                                                                   //COBOL==> END-IF.
            if ((LS.LSI_OB_CRTD_TMST_39XX.IsEqualTo(HIGH_VALUES))
             || (LS.LSI_OB_CRTD_TMST_39XX.IsEqualTo(LOW_VALUES)))  //COBOL==> IF LSI-OB-CRTD-TMST-39XX = HIGH-VALUES OR LSI-OB-CRTD-TMST-39XX = LOW-VALUES
            {
                LS.LSI_OB_CRTD_TMST_39.SetValueWithSpaces();                                                        //COBOL==> MOVE SPACES TO LSI-OB-CRTD-TMST-39
            }                                                                                                   //COBOL==> END-IF.
            if (!(LS.LSI_COLL_ID_40.IsNumericValue()))                                                         //COBOL==> IF LSI-COLL-ID-40 IS NOT NUMERIC
            {
                LS.LSI_COLL_ID_40.SetValueWithZeroes();                                                             //COBOL==> MOVE ZEROS TO LSI-COLL-ID-40
            }                                                                                                   //COBOL==> END-IF.
            if ((LS.LSI_COLL_APPLD_TO_CD_41XX.IsEqualTo(HIGH_VALUES))
             || (LS.LSI_COLL_APPLD_TO_CD_41XX.IsEqualTo(LOW_VALUES)))  //COBOL==> IF LSI-COLL-APPLD-TO-CD-41XX = HIGH-VALUES OR LSI-COLL-APPLD-TO-CD-41XX = LOW-VALUES
            {
                LS.LSI_COLL_APPLD_TO_CD_41.SetValueWithSpaces();                                                    //COBOL==> MOVE SPACES TO LSI-COLL-APPLD-TO-CD-41
            }                                                                                                   //COBOL==> END-IF.
            if ((LS.LSI_COLL_ADJ_IND_42XX.IsEqualTo(HIGH_VALUES))
             || (LS.LSI_COLL_ADJ_IND_42XX.IsEqualTo(LOW_VALUES)))  //COBOL==> IF LSI-COLL-ADJ-IND-42XX = HIGH-VALUES OR LSI-COLL-ADJ-IND-42XX = LOW-VALUES
            {
                LS.LSI_COLL_ADJ_IND_42.SetValueWithSpaces();                                                        //COBOL==> MOVE SPACES TO LSI-COLL-ADJ-IND-42
            }                                                                                                   //COBOL==> END-IF.
            if ((LS.LSI_COLL_CONC_IND_43XX.IsEqualTo(HIGH_VALUES))
             || (LS.LSI_COLL_CONC_IND_43XX.IsEqualTo(LOW_VALUES)))  //COBOL==> IF LSI-COLL-CONC-IND-43XX = HIGH-VALUES OR LSI-COLL-CONC-IND-43XX = LOW-VALUES
            {
                LS.LSI_COLL_CONC_IND_43.SetValueWithSpaces();                                                       //COBOL==> MOVE SPACES TO LSI-COLL-CONC-IND-43
            }                                                                                                   //COBOL==> END-IF.
            if ((LS.LSI_COLL_CRTD_TMST_44XX.IsEqualTo(HIGH_VALUES))
             || (LS.LSI_COLL_CRTD_TMST_44XX.IsEqualTo(LOW_VALUES)))  //COBOL==> IF LSI-COLL-CRTD-TMST-44XX = HIGH-VALUES OR LSI-COLL-CRTD-TMST-44XX = LOW-VALUES
            {
                LS.LSI_COLL_CRTD_TMST_44.SetValueWithSpaces();                                                      //COBOL==> MOVE SPACES TO LSI-COLL-CRTD-TMST-44
            }                                                                                                   //COBOL==> END-IF.
            if ((LS.LSI_PARM1_45XX.IsEqualTo(HIGH_VALUES))
             || (LS.LSI_PARM1_45XX.IsEqualTo(LOW_VALUES)))  //COBOL==> IF LSI-PARM1-45XX = HIGH-VALUES OR LSI-PARM1-45XX = LOW-VALUES
            {
                LS.LSI_PARM1_45.SetValueWithSpaces();                                                               //COBOL==> MOVE SPACES TO LSI-PARM1-45
            }                                                                                                   //COBOL==> END-IF.
            if ((LS.LSI_PARM2_46XX.IsEqualTo(HIGH_VALUES))
             || (LS.LSI_PARM2_46XX.IsEqualTo(LOW_VALUES)))  //COBOL==> IF LSI-PARM2-46XX = HIGH-VALUES OR LSI-PARM2-46XX = LOW-VALUES
            {
                LS.LSI_PARM2_46.SetValueWithSpaces();                                                               //COBOL==> MOVE SPACES TO LSI-PARM2-46
            }                                                                                                   //COBOL==> END-IF.
            if ((LS.LSE_PARM1_47XX.IsEqualTo(HIGH_VALUES))
             || (LS.LSE_PARM1_47XX.IsEqualTo(LOW_VALUES)))  //COBOL==> IF LSE-PARM1-47XX = HIGH-VALUES OR LSE-PARM1-47XX = LOW-VALUES
            {
                LS.LSE_PARM1_47.SetValueWithSpaces();                                                               //COBOL==> MOVE SPACES TO LSE-PARM1-47
            }                                                                                                   //COBOL==> END-IF.
            if ((LS.LSE_PARM2_48XX.IsEqualTo(HIGH_VALUES))
             || (LS.LSE_PARM2_48XX.IsEqualTo(LOW_VALUES)))  //COBOL==> IF LSE-PARM2-48XX = HIGH-VALUES OR LSE-PARM2-48XX = LOW-VALUES
            {
                LS.LSE_PARM2_48.SetValueWithSpaces();                                                               //COBOL==> MOVE SPACES TO LSE-PARM2-48
            }                                                                                                   //COBOL==> END-IF.
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
            WS.WS1_DTL_FOR_LN_X.SetValue(LS.LSI_DTL_FOR_LN_01);                                                 //COBOL==> MOVE LSI-DTL-FOR-LN-01 TO WS1-DTL-FOR-LN-X.
            WS.WS16_C_NBR_X.SetValue(LS.LSI_C_NBR_02);                                                          //COBOL==> MOVE LSI-C-NBR-02 TO WS16-C-NBR-X.
            WS.WS26_C_STAT_X.SetValue(LS.LSI_C_STAT_03);                                                        //COBOL==> MOVE LSI-C-STAT-03 TO WS26-C-STAT-X.
            WS.WS27_C_STAT_DT_9.SetValue(LS.LSI_C_STAT_DT_04);                                                  //COBOL==> MOVE LSI-C-STAT-DT-04 TO WS27-C-STAT-DT-9.
            WS.WS35_C_OPN_DT_9.SetValue(LS.LSI_C_OPN_DT_05);                                                    //COBOL==> MOVE LSI-C-OPN-DT-05 TO WS35-C-OPN-DT-9.
            WS.WS43_CR_ID_9.SetValue(LS.LSI_CR_ID_06);                                                          //COBOL==> MOVE LSI-CR-ID-06 TO WS43-CR-ID-9.
            WS.WS46_CR_TYP_X.SetValue(LS.LSI_CR_TYP_07);                                                        //COBOL==> MOVE LSI-CR-TYP-07 TO WS46-CR-TYP-X.
            WS.WS48_CR_STRT_DT_9.SetValue(LS.LSI_CR_STRT_DT_08);                                                //COBOL==> MOVE LSI-CR-STRT-DT-08 TO WS48-CR-STRT-DT-9.
            WS.WS56_CR_END_DT_9.SetValue(LS.LSI_CR_END_DT_09);                                                  //COBOL==> MOVE LSI-CR-END-DT-09 TO WS56-CR-END-DT-9.
            WS.WS64_CP_TYP_X.SetValue(LS.LSI_CP_TYP_10);                                                        //COBOL==> MOVE LSI-CP-TYP-10 TO WS64-CP-TYP-X.
            WS.WS65_CP_NBR_X.SetValue(LS.LSI_CP_NBR_11);                                                        //COBOL==> MOVE LSI-CP-NBR-11 TO WS65-CP-NBR-X.
            WS.WS75_PP_CRTD_TMST_X.SetValue(LS.LSI_PP_CRTD_TMST_12);                                            //COBOL==> MOVE LSI-PP-CRTD-TMST-12 TO WS75-PP-CRTD-TMST-X.
            WS.WS95_PP_EFF_DT_9.SetValue(LS.LSI_PP_EFF_DT_13);                                                  //COBOL==> MOVE LSI-PP-EFF-DT-13 TO WS95-PP-EFF-DT-9.
            WS.WS103_PP_DISC_DT_9.SetValue(LS.LSI_PP_DISC_DT_14);                                               //COBOL==> MOVE LSI-PP-DISC-DT-14 TO WS103-PP-DISC-DT-9.
            WS.WS111_P_CD_X.SetValue(LS.LSI_P_CD_15);                                                           //COBOL==> MOVE LSI-P-CD-15 TO WS111-P-CD-X.
            WS.WS114_P_EFF_DT_9.SetValue(LS.LSI_P_EFF_DT_16);                                                   //COBOL==> MOVE LSI-P-EFF-DT-16 TO WS114-P-EFF-DT-9.
            WS.WS122_P_DISC_DT_9.SetValue(LS.LSI_P_DISC_DT_17);                                                 //COBOL==> MOVE LSI-P-DISC-DT-17 TO WS122-P-DISC-DT-9.
            WS.WS130_LACR_CRTD_TS_X.SetValue(LS.LSI_LACR_CRTD_TMST_18);                                         //COBOL==> MOVE LSI-LACR-CRTD-TMST-18 TO WS130-LACR-CRTD-TS-X.
            WS.WS150_LA_ID_9.SetValue(LS.LSI_LA_ID_19);                                                         //COBOL==> MOVE LSI-LA-ID-19 TO WS150-LA-ID-9.
            WS.WS159_LA_ACT_TKN_X.SetValue(LS.LSI_LA_ACT_TKN_20);                                               //COBOL==> MOVE LSI-LA-ACT-TKN-20 TO WS159-LA-ACT-TKN-X.
            WS.WS189_LA_CRTD_TSTA_X.SetValue(LS.LSI_LA_CRTD_TMST_21);                                           //COBOL==> MOVE LSI-LA-CRTD-TMST-21 TO WS189-LA-CRTD-TSTA-X.
            WS.WS209_LA_FLD_DT_9.SetValue(LS.LSI_LA_FLD_DT_22);                                                 //COBOL==> MOVE LSI-LA-FLD-DT-22 TO WS209-LA-FLD-DT-9.
            WS.WS217_LAD_NBR_9.SetValue(LS.LSI_LAD_NBR_23);                                                     //COBOL==> MOVE LSI-LAD-NBR-23 TO WS217-LAD-NBR-9.
            WS.WS219_LAD_DTL_TYP_X.SetValue(LS.LSI_LAD_DTL_TYP_24);                                             //COBOL==> MOVE LSI-LAD-DTL-TYP-24 TO WS219-LAD-DTL-TYP-X.
            WS.WS220_LAD_CRTD_TST_X.SetValue(LS.LSI_LAD_CRTD_TMST_25);                                          //COBOL==> MOVE LSI-LAD-CRTD-TMST-25 TO WS220-LAD-CRTD-TST-X.
            WS.WS240_LAD_NON_FIN_OBL_X.SetValue(LS.LSI_LAD_NON_FIN_OB_TYP_26);                                  //COBOL==> MOVE LSI-LAD-NON-FIN-OB-TYP-26 TO WS240-LAD-NON-FIN-OBL-X.
            WS.WS244_OT_CD_X.SetValue(LS.LSI_OT_CD_27);                                                         //COBOL==> MOVE LSI-OT-CD-27 TO WS244-OT-CD-X.
            WS.WS251_OT_CLS_X.SetValue(LS.LSI_OT_CLS_28);                                                       //COBOL==> MOVE LSI-OT-CLS-28 TO WS251-OT-CLS-X.
            WS.WS252_DD_DUE_DT_9.SetValue(LS.LSI_DD_DUE_DT_29);                                                 //COBOL==> MOVE LSI-DD-DUE-DT-29 TO WS252-DD-DUE-DT-9.
            WS.WS260_DD_BAL_DUE_9.SetValue(LS.LSI_DD_BAL_DUE_AMT_30);                                           //COBOL==> MOVE LSI-DD-BAL-DUE-AMT-30 TO WS260-DD-BAL-DUE-9.
            WS.WS269_DD_INT_BAL_9.SetValue(LS.LSI_DD_INT_BAL_DUE_31);                                           //COBOL==> MOVE LSI-DD-INT-BAL-DUE-31 TO WS269-DD-INT-BAL-9.
            WS.WS275_DD_CRTD_TMST_X.SetValue(LS.LSI_DD_CRTD_TMST_32);                                           //COBOL==> MOVE LSI-DD-CRTD-TMST-32 TO WS275-DD-CRTD-TMST-X.
            WS.WS295_CPA_TYP_X.SetValue(LS.LSI_CPA_TYP_33);                                                     //COBOL==> MOVE LSI-CPA-TYP-33 TO WS295-CPA-TYP-X.
            WS.WS296_CPA_CRTD_TMS_X.SetValue(LS.LSI_CPA_CRTD_TMST_34);                                          //COBOL==> MOVE LSI-CPA-CRTD-TMST-34 TO WS296-CPA-CRTD-TMS-X.
            WS.WS316_OB_TRN_ID_9.SetValue(LS.LSI_OB_TRN_ID_35);                                                 //COBOL==> MOVE LSI-OB-TRN-ID-35 TO WS316-OB-TRN-ID-9.
            WS.WS325_OB_TRN_TYP_X.SetValue(LS.LSI_OB_TRN_TYP_36);                                               //COBOL==> MOVE LSI-OB-TRN-TYP-36 TO WS325-OB-TRN-TYP-X.
            WS.WS327_OB_TRN_CRTD_X.SetValue(LS.LSI_OB_TRN_CRTD_TMST_37);                                        //COBOL==> MOVE LSI-OB-TRN-CRTD-TMST-37 TO WS327-OB-TRN-CRTD-X.
            WS.WS347_OB_ID_9.SetValue(LS.LSI_OB_ID_38);                                                         //COBOL==> MOVE LSI-OB-ID-38 TO WS347-OB-ID-9.
            WS.WS350_OB_CRTD_TMST_X.SetValue(LS.LSI_OB_CRTD_TMST_39);                                           //COBOL==> MOVE LSI-OB-CRTD-TMST-39 TO WS350-OB-CRTD-TMST-X.
            WS.WS370_COLL_ID_9.SetValue(LS.LSI_COLL_ID_40);                                                     //COBOL==> MOVE LSI-COLL-ID-40 TO WS370-COLL-ID-9.
            WS.WS379_COLL_APPLD_TO_X.SetValue(LS.LSI_COLL_APPLD_TO_CD_41);                                      //COBOL==> MOVE LSI-COLL-APPLD-TO-CD-41 TO WS379-COLL-APPLD-TO-X.
            WS.WS380_COLL_ADJ_I_X.SetValue(LS.LSI_COLL_ADJ_IND_42);                                             //COBOL==> MOVE LSI-COLL-ADJ-IND-42 TO WS380-COLL-ADJ-I-X.
            WS.WS381_COLL_CONC_X.SetValue(LS.LSI_COLL_CONC_IND_43);                                             //COBOL==> MOVE LSI-COLL-CONC-IND-43 TO WS381-COLL-CONC-X.
            WS.WS382_COLL_CRTD_TM_X.SetValue(LS.LSI_COLL_CRTD_TMST_44);                                         //COBOL==> MOVE LSI-COLL-CRTD-TMST-44 TO WS382-COLL-CRTD-TM-X.
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
