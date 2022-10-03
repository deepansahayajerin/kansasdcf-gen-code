#region Comments
/* Conversion Comments
   ************************************************************
   **   MODERN SYSTEMS INC.  COPYRIGHT 2000-2021
   **   DB-SHUTTLE COBOL to C# Conversion
   ************************************************************
   ** INIT   *  INITIAL VERSION   *  2021-12-07 03:10:00 PM
   **        *   FROM COBOL PGM   :  SWEXF710
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
    internal class SWEXF710_fd : PredefinedRecordBase
    {
        #region Name constants
        /// <summary>
        /// Name constants.
        /// </summary>
        internal static class Names
        {
            internal const string FileSection = "SWEXF710_fd_FileSection";
            internal const string SEQ_FILE = "SEQ_FILE";
            internal const string SEQFILE_REC = "SEQFILE_REC";
        }
        #endregion

        #region Direct-access element properties
        public IFileLink SEQ_FILE { get; set; }
        public IField SEQFILE_REC { get { return GetElementByName<IField>(Names.SEQFILE_REC); } }


        internal SWEXF710_ws WS;
        #endregion

        #region Data structure definition
        /// <summary>
        /// Defines the entirety of the FileSection IRecord structure as described by the Ateras.Framework.Buffer API.
        /// </summary>
        /// <param name="recordDef">The IStructureDefinition object to be used in defining the record structure.</param>
        protected override void DefineRecordStructure(IStructureDefinition recordDef)
        {
            recordDef.CreateNewField(Names.SEQFILE_REC, FieldType.String, 751);

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
            SEQ_FILE.RecordLength = 751;
        }
        #endregion

        #region Constructors
        public SWEXF710_fd(SWEXF710_ws ws)
            : base()
        {
            this.WS = ws;
            Initialize();

        }
        #endregion
    }
    #endregion File Section Class
    #region Working Storage Class
    internal class SWEXF710_ws : PredefinedRecordBase
    {
        #region Name constants
        /// <summary>
        /// Name constants.
        /// </summary>
        internal static class Names
        {
            internal const string WorkingStorage = "SWEXF710_ws_WorkingStorage";
            internal const string WS_FILE_STATUS = "WS_FILE_STATUS";
            internal const string WS_SEQFILE_REC = "WS_SEQFILE_REC";
            internal const string WS_SUBRPT_CD = "WS_SUBRPT_CD";
            internal const string WS_CUR_L1_CNT_01 = "WS_CUR_L1_CNT_01";
            internal const string WS_FMR_L1_CNT_02 = "WS_FMR_L1_CNT_02";
            internal const string WS_NVR_L1_CNT_03 = "WS_NVR_L1_CNT_03";
            internal const string WS_CUR_L1A_CNT_04 = "WS_CUR_L1A_CNT_04";
            internal const string WS_FMR_L1A_CNT_05 = "WS_FMR_L1A_CNT_05";
            internal const string WS_NVR_L1A_CNT_06 = "WS_NVR_L1A_CNT_06";
            internal const string WS_CUR_L1B_CNT_07 = "WS_CUR_L1B_CNT_07";
            internal const string WS_FMR_L1B_CNT_08 = "WS_FMR_L1B_CNT_08";
            internal const string WS_NVR_L1B_CNT_09 = "WS_NVR_L1B_CNT_09";
            internal const string WS_NVR_L1C_CNT_10 = "WS_NVR_L1C_CNT_10";
            internal const string WS_CUR_L2_CNT_11 = "WS_CUR_L2_CNT_11";
            internal const string WS_FMR_L2_CNT_12 = "WS_FMR_L2_CNT_12";
            internal const string WS_NVR_L2_CNT_13 = "WS_NVR_L2_CNT_13";
            internal const string WS_CUR_L2A_CNT_14 = "WS_CUR_L2A_CNT_14";
            internal const string WS_FMR_L2A_CNT_15 = "WS_FMR_L2A_CNT_15";
            internal const string WS_NVR_L2A_CNT_16 = "WS_NVR_L2A_CNT_16";
            internal const string WS_CUR_L2B_CNT_17 = "WS_CUR_L2B_CNT_17";
            internal const string WS_FMR_L2B_CNT_18 = "WS_FMR_L2B_CNT_18";
            internal const string WS_NVR_L2B_CNT_19 = "WS_NVR_L2B_CNT_19";
            internal const string WS_CUR_L2C_CNT_20 = "WS_CUR_L2C_CNT_20";
            internal const string WS_FMR_L2C_CNT_21 = "WS_FMR_L2C_CNT_21";
            internal const string WS_NVR_L2C_CNT_22 = "WS_NVR_L2C_CNT_22";
            internal const string WS_NVR_L2D_CNT_23 = "WS_NVR_L2D_CNT_23";
            internal const string WS_CUR_L3_CNT_24 = "WS_CUR_L3_CNT_24";
            internal const string WS_FMR_L3_CNT_25 = "WS_FMR_L3_CNT_25";
            internal const string WS_NVR_L3_CNT_26 = "WS_NVR_L3_CNT_26";
            internal const string WS_TOT_L4_CNT_27 = "WS_TOT_L4_CNT_27";
            internal const string WS_TOT_L5_CNT_28 = "WS_TOT_L5_CNT_28";
            internal const string WS_TOT_L6_CNT_29 = "WS_TOT_L6_CNT_29";
            internal const string WS_TOT_L7_CNT_30 = "WS_TOT_L7_CNT_30";
            internal const string WS_TOT_L8_CNT_31 = "WS_TOT_L8_CNT_31";
            internal const string WS_TOT_L9_CNT_32 = "WS_TOT_L9_CNT_32";
            internal const string WS_TOT_L10_CNT_33 = "WS_TOT_L10_CNT_33";
            internal const string WS_CUR_L12_CNT_34 = "WS_CUR_L12_CNT_34";
            internal const string WS_FMR_L12_CNT_35 = "WS_FMR_L12_CNT_35";
            internal const string WS_NVR_L12_CNT_36 = "WS_NVR_L12_CNT_36";
            internal const string WS_CUR_L13_CNT_37 = "WS_CUR_L13_CNT_37";
            internal const string WS_FMR_L13_CNT_38 = "WS_FMR_L13_CNT_38";
            internal const string WS_NVR_L13_CNT_39 = "WS_NVR_L13_CNT_39";
            internal const string WS_TOT_L14_CNT_40 = "WS_TOT_L14_CNT_40";
            internal const string WS_CUR_L16_CNT_41 = "WS_CUR_L16_CNT_41";
            internal const string WS_FMR_L16_CNT_42 = "WS_FMR_L16_CNT_42";
            internal const string WS_NVR_L16_CNT_43 = "WS_NVR_L16_CNT_43";
            internal const string WS_CUR_L17_CNT_44 = "WS_CUR_L17_CNT_44";
            internal const string WS_FMR_L17_CNT_45 = "WS_FMR_L17_CNT_45";
            internal const string WS_NVR_L17_CNT_46 = "WS_NVR_L17_CNT_46";
            internal const string WS_CUR_L18_CNT_47 = "WS_CUR_L18_CNT_47";
            internal const string WS_FMR_L18_CNT_48 = "WS_FMR_L18_CNT_48";
            internal const string WS_NVR_L18_CNT_49 = "WS_NVR_L18_CNT_49";
            internal const string WS_CUR_L18A_CNT_50 = "WS_CUR_L18A_CNT_50";
            internal const string WS_FMR_L18A_CNT_51 = "WS_FMR_L18A_CNT_51";
            internal const string WS_NVR_L18A_CNT_52 = "WS_NVR_L18A_CNT_52";
            internal const string WS_CUR_L19_CNT_53 = "WS_CUR_L19_CNT_53";
            internal const string WS_FMR_L19_CNT_54 = "WS_FMR_L19_CNT_54";
            internal const string WS_NVR_L19_CNT_55 = "WS_NVR_L19_CNT_55";
            internal const string WS_CUR_L20_CNT_56 = "WS_CUR_L20_CNT_56";
            internal const string WS_FMR_L20_CNT_57 = "WS_FMR_L20_CNT_57";
            internal const string WS_NVR_L20_CNT_58 = "WS_NVR_L20_CNT_58";
            internal const string WS_TOT_L21_CNT_59 = "WS_TOT_L21_CNT_59";
            internal const string WS_TOT_L22_CNT_60 = "WS_TOT_L22_CNT_60";
            internal const string WS_TOT_L23_CNT_61 = "WS_TOT_L23_CNT_61";
            internal const string WS_CUR_L24_CNT_62 = "WS_CUR_L24_CNT_62";
            internal const string WS_FMR_L24_CNT_63 = "WS_FMR_L24_CNT_63";
            internal const string WS_NVR_L24_CNT_64 = "WS_NVR_L24_CNT_64";
            internal const string WS_CUR_L25_CNT_65 = "WS_CUR_L25_CNT_65";
            internal const string WS_FMR_L25_CNT_66 = "WS_FMR_L25_CNT_66";
            internal const string WS_NVR_L25_CNT_67 = "WS_NVR_L25_CNT_67";
            internal const string WS_CUR_L26_CNT_68 = "WS_CUR_L26_CNT_68";
            internal const string WS_FMR_L26_CNT_69 = "WS_FMR_L26_CNT_69";
            internal const string WS_NVR_L26_CNT_70 = "WS_NVR_L26_CNT_70";
            internal const string WS_CUR_L27_CNT_71 = "WS_CUR_L27_CNT_71";
            internal const string WS_FMR_L27_CNT_72 = "WS_FMR_L27_CNT_72";
            internal const string WS_NVR_L27_CNT_73 = "WS_NVR_L27_CNT_73";
            internal const string WS_TOT_L28_CNT_74 = "WS_TOT_L28_CNT_74";
            internal const string WS_TOT_L29_CNT_75 = "WS_TOT_L29_CNT_75";
            internal const string WS_TOT_L30_CNT_76 = "WS_TOT_L30_CNT_76";
            internal const string WS_TOT_L31_CNT_77 = "WS_TOT_L31_CNT_77";
            internal const string WS_TOT_L32_CNT_78 = "WS_TOT_L32_CNT_78";
            internal const string WS_CUR_L38_CNT_79 = "WS_CUR_L38_CNT_79";
            internal const string WS_CUR_L39_CNT_80 = "WS_CUR_L39_CNT_80";
            internal const string WS_TOT_L40_CNT_81 = "WS_TOT_L40_CNT_81";
            internal const string WS_TOT_L41_CNT_82 = "WS_TOT_L41_CNT_82";
            internal const string WS_TOT_L42_CNT_83 = "WS_TOT_L42_CNT_83";
        }
        #endregion

        #region Direct-access element properties
        public IField WS_FILE_STATUS { get { return GetElementByName<IField>(Names.WS_FILE_STATUS); } }
        public IGroup WS_SEQFILE_REC { get { return GetElementByName<IGroup>(Names.WS_SEQFILE_REC); } }
        public IField WS_SUBRPT_CD { get { return GetElementByName<IField>(Names.WS_SUBRPT_CD); } }
        public IField WS_CUR_L1_CNT_01 { get { return GetElementByName<IField>(Names.WS_CUR_L1_CNT_01); } }
        public IField WS_FMR_L1_CNT_02 { get { return GetElementByName<IField>(Names.WS_FMR_L1_CNT_02); } }
        public IField WS_NVR_L1_CNT_03 { get { return GetElementByName<IField>(Names.WS_NVR_L1_CNT_03); } }
        public IField WS_CUR_L1A_CNT_04 { get { return GetElementByName<IField>(Names.WS_CUR_L1A_CNT_04); } }
        public IField WS_FMR_L1A_CNT_05 { get { return GetElementByName<IField>(Names.WS_FMR_L1A_CNT_05); } }
        public IField WS_NVR_L1A_CNT_06 { get { return GetElementByName<IField>(Names.WS_NVR_L1A_CNT_06); } }
        public IField WS_CUR_L1B_CNT_07 { get { return GetElementByName<IField>(Names.WS_CUR_L1B_CNT_07); } }
        public IField WS_FMR_L1B_CNT_08 { get { return GetElementByName<IField>(Names.WS_FMR_L1B_CNT_08); } }
        public IField WS_NVR_L1B_CNT_09 { get { return GetElementByName<IField>(Names.WS_NVR_L1B_CNT_09); } }
        public IField WS_NVR_L1C_CNT_10 { get { return GetElementByName<IField>(Names.WS_NVR_L1C_CNT_10); } }
        public IField WS_CUR_L2_CNT_11 { get { return GetElementByName<IField>(Names.WS_CUR_L2_CNT_11); } }
        public IField WS_FMR_L2_CNT_12 { get { return GetElementByName<IField>(Names.WS_FMR_L2_CNT_12); } }
        public IField WS_NVR_L2_CNT_13 { get { return GetElementByName<IField>(Names.WS_NVR_L2_CNT_13); } }
        public IField WS_CUR_L2A_CNT_14 { get { return GetElementByName<IField>(Names.WS_CUR_L2A_CNT_14); } }
        public IField WS_FMR_L2A_CNT_15 { get { return GetElementByName<IField>(Names.WS_FMR_L2A_CNT_15); } }
        public IField WS_NVR_L2A_CNT_16 { get { return GetElementByName<IField>(Names.WS_NVR_L2A_CNT_16); } }
        public IField WS_CUR_L2B_CNT_17 { get { return GetElementByName<IField>(Names.WS_CUR_L2B_CNT_17); } }
        public IField WS_FMR_L2B_CNT_18 { get { return GetElementByName<IField>(Names.WS_FMR_L2B_CNT_18); } }
        public IField WS_NVR_L2B_CNT_19 { get { return GetElementByName<IField>(Names.WS_NVR_L2B_CNT_19); } }
        public IField WS_CUR_L2C_CNT_20 { get { return GetElementByName<IField>(Names.WS_CUR_L2C_CNT_20); } }
        public IField WS_FMR_L2C_CNT_21 { get { return GetElementByName<IField>(Names.WS_FMR_L2C_CNT_21); } }
        public IField WS_NVR_L2C_CNT_22 { get { return GetElementByName<IField>(Names.WS_NVR_L2C_CNT_22); } }
        public IField WS_NVR_L2D_CNT_23 { get { return GetElementByName<IField>(Names.WS_NVR_L2D_CNT_23); } }
        public IField WS_CUR_L3_CNT_24 { get { return GetElementByName<IField>(Names.WS_CUR_L3_CNT_24); } }
        public IField WS_FMR_L3_CNT_25 { get { return GetElementByName<IField>(Names.WS_FMR_L3_CNT_25); } }
        public IField WS_NVR_L3_CNT_26 { get { return GetElementByName<IField>(Names.WS_NVR_L3_CNT_26); } }
        public IField WS_TOT_L4_CNT_27 { get { return GetElementByName<IField>(Names.WS_TOT_L4_CNT_27); } }
        public IField WS_TOT_L5_CNT_28 { get { return GetElementByName<IField>(Names.WS_TOT_L5_CNT_28); } }
        public IField WS_TOT_L6_CNT_29 { get { return GetElementByName<IField>(Names.WS_TOT_L6_CNT_29); } }
        public IField WS_TOT_L7_CNT_30 { get { return GetElementByName<IField>(Names.WS_TOT_L7_CNT_30); } }
        public IField WS_TOT_L8_CNT_31 { get { return GetElementByName<IField>(Names.WS_TOT_L8_CNT_31); } }
        public IField WS_TOT_L9_CNT_32 { get { return GetElementByName<IField>(Names.WS_TOT_L9_CNT_32); } }
        public IField WS_TOT_L10_CNT_33 { get { return GetElementByName<IField>(Names.WS_TOT_L10_CNT_33); } }
        public IField WS_CUR_L12_CNT_34 { get { return GetElementByName<IField>(Names.WS_CUR_L12_CNT_34); } }
        public IField WS_FMR_L12_CNT_35 { get { return GetElementByName<IField>(Names.WS_FMR_L12_CNT_35); } }
        public IField WS_NVR_L12_CNT_36 { get { return GetElementByName<IField>(Names.WS_NVR_L12_CNT_36); } }
        public IField WS_CUR_L13_CNT_37 { get { return GetElementByName<IField>(Names.WS_CUR_L13_CNT_37); } }
        public IField WS_FMR_L13_CNT_38 { get { return GetElementByName<IField>(Names.WS_FMR_L13_CNT_38); } }
        public IField WS_NVR_L13_CNT_39 { get { return GetElementByName<IField>(Names.WS_NVR_L13_CNT_39); } }
        public IField WS_TOT_L14_CNT_40 { get { return GetElementByName<IField>(Names.WS_TOT_L14_CNT_40); } }
        public IField WS_CUR_L16_CNT_41 { get { return GetElementByName<IField>(Names.WS_CUR_L16_CNT_41); } }
        public IField WS_FMR_L16_CNT_42 { get { return GetElementByName<IField>(Names.WS_FMR_L16_CNT_42); } }
        public IField WS_NVR_L16_CNT_43 { get { return GetElementByName<IField>(Names.WS_NVR_L16_CNT_43); } }
        public IField WS_CUR_L17_CNT_44 { get { return GetElementByName<IField>(Names.WS_CUR_L17_CNT_44); } }
        public IField WS_FMR_L17_CNT_45 { get { return GetElementByName<IField>(Names.WS_FMR_L17_CNT_45); } }
        public IField WS_NVR_L17_CNT_46 { get { return GetElementByName<IField>(Names.WS_NVR_L17_CNT_46); } }
        public IField WS_CUR_L18_CNT_47 { get { return GetElementByName<IField>(Names.WS_CUR_L18_CNT_47); } }
        public IField WS_FMR_L18_CNT_48 { get { return GetElementByName<IField>(Names.WS_FMR_L18_CNT_48); } }
        public IField WS_NVR_L18_CNT_49 { get { return GetElementByName<IField>(Names.WS_NVR_L18_CNT_49); } }
        public IField WS_CUR_L18A_CNT_50 { get { return GetElementByName<IField>(Names.WS_CUR_L18A_CNT_50); } }
        public IField WS_FMR_L18A_CNT_51 { get { return GetElementByName<IField>(Names.WS_FMR_L18A_CNT_51); } }
        public IField WS_NVR_L18A_CNT_52 { get { return GetElementByName<IField>(Names.WS_NVR_L18A_CNT_52); } }
        public IField WS_CUR_L19_CNT_53 { get { return GetElementByName<IField>(Names.WS_CUR_L19_CNT_53); } }
        public IField WS_FMR_L19_CNT_54 { get { return GetElementByName<IField>(Names.WS_FMR_L19_CNT_54); } }
        public IField WS_NVR_L19_CNT_55 { get { return GetElementByName<IField>(Names.WS_NVR_L19_CNT_55); } }
        public IField WS_CUR_L20_CNT_56 { get { return GetElementByName<IField>(Names.WS_CUR_L20_CNT_56); } }
        public IField WS_FMR_L20_CNT_57 { get { return GetElementByName<IField>(Names.WS_FMR_L20_CNT_57); } }
        public IField WS_NVR_L20_CNT_58 { get { return GetElementByName<IField>(Names.WS_NVR_L20_CNT_58); } }
        public IField WS_TOT_L21_CNT_59 { get { return GetElementByName<IField>(Names.WS_TOT_L21_CNT_59); } }
        public IField WS_TOT_L22_CNT_60 { get { return GetElementByName<IField>(Names.WS_TOT_L22_CNT_60); } }
        public IField WS_TOT_L23_CNT_61 { get { return GetElementByName<IField>(Names.WS_TOT_L23_CNT_61); } }
        public IField WS_CUR_L24_CNT_62 { get { return GetElementByName<IField>(Names.WS_CUR_L24_CNT_62); } }
        public IField WS_FMR_L24_CNT_63 { get { return GetElementByName<IField>(Names.WS_FMR_L24_CNT_63); } }
        public IField WS_NVR_L24_CNT_64 { get { return GetElementByName<IField>(Names.WS_NVR_L24_CNT_64); } }
        public IField WS_CUR_L25_CNT_65 { get { return GetElementByName<IField>(Names.WS_CUR_L25_CNT_65); } }
        public IField WS_FMR_L25_CNT_66 { get { return GetElementByName<IField>(Names.WS_FMR_L25_CNT_66); } }
        public IField WS_NVR_L25_CNT_67 { get { return GetElementByName<IField>(Names.WS_NVR_L25_CNT_67); } }
        public IField WS_CUR_L26_CNT_68 { get { return GetElementByName<IField>(Names.WS_CUR_L26_CNT_68); } }
        public IField WS_FMR_L26_CNT_69 { get { return GetElementByName<IField>(Names.WS_FMR_L26_CNT_69); } }
        public IField WS_NVR_L26_CNT_70 { get { return GetElementByName<IField>(Names.WS_NVR_L26_CNT_70); } }
        public IField WS_CUR_L27_CNT_71 { get { return GetElementByName<IField>(Names.WS_CUR_L27_CNT_71); } }
        public IField WS_FMR_L27_CNT_72 { get { return GetElementByName<IField>(Names.WS_FMR_L27_CNT_72); } }
        public IField WS_NVR_L27_CNT_73 { get { return GetElementByName<IField>(Names.WS_NVR_L27_CNT_73); } }
        public IField WS_TOT_L28_CNT_74 { get { return GetElementByName<IField>(Names.WS_TOT_L28_CNT_74); } }
        public IField WS_TOT_L29_CNT_75 { get { return GetElementByName<IField>(Names.WS_TOT_L29_CNT_75); } }
        public IField WS_TOT_L30_CNT_76 { get { return GetElementByName<IField>(Names.WS_TOT_L30_CNT_76); } }
        public IField WS_TOT_L31_CNT_77 { get { return GetElementByName<IField>(Names.WS_TOT_L31_CNT_77); } }
        public IField WS_TOT_L32_CNT_78 { get { return GetElementByName<IField>(Names.WS_TOT_L32_CNT_78); } }
        public IField WS_CUR_L38_CNT_79 { get { return GetElementByName<IField>(Names.WS_CUR_L38_CNT_79); } }
        public IField WS_CUR_L39_CNT_80 { get { return GetElementByName<IField>(Names.WS_CUR_L39_CNT_80); } }
        public IField WS_TOT_L40_CNT_81 { get { return GetElementByName<IField>(Names.WS_TOT_L40_CNT_81); } }
        public IField WS_TOT_L41_CNT_82 { get { return GetElementByName<IField>(Names.WS_TOT_L41_CNT_82); } }
        public IField WS_TOT_L42_CNT_83 { get { return GetElementByName<IField>(Names.WS_TOT_L42_CNT_83); } }

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
               WS_SEQFILE_REC.CreateNewField(Names.WS_SUBRPT_CD, FieldType.String, 4);
               WS_SEQFILE_REC.CreateNewField(Names.WS_CUR_L1_CNT_01, FieldType.SignedNumeric, 9);
               WS_SEQFILE_REC.CreateNewField(Names.WS_FMR_L1_CNT_02, FieldType.SignedNumeric, 9);
               WS_SEQFILE_REC.CreateNewField(Names.WS_NVR_L1_CNT_03, FieldType.SignedNumeric, 9);
               WS_SEQFILE_REC.CreateNewField(Names.WS_CUR_L1A_CNT_04, FieldType.SignedNumeric, 9);
               WS_SEQFILE_REC.CreateNewField(Names.WS_FMR_L1A_CNT_05, FieldType.SignedNumeric, 9);
               WS_SEQFILE_REC.CreateNewField(Names.WS_NVR_L1A_CNT_06, FieldType.SignedNumeric, 9);
               WS_SEQFILE_REC.CreateNewField(Names.WS_CUR_L1B_CNT_07, FieldType.SignedNumeric, 9);
               WS_SEQFILE_REC.CreateNewField(Names.WS_FMR_L1B_CNT_08, FieldType.SignedNumeric, 9);
               WS_SEQFILE_REC.CreateNewField(Names.WS_NVR_L1B_CNT_09, FieldType.SignedNumeric, 9);
               WS_SEQFILE_REC.CreateNewField(Names.WS_NVR_L1C_CNT_10, FieldType.SignedNumeric, 9);
               WS_SEQFILE_REC.CreateNewField(Names.WS_CUR_L2_CNT_11, FieldType.SignedNumeric, 9);
               WS_SEQFILE_REC.CreateNewField(Names.WS_FMR_L2_CNT_12, FieldType.SignedNumeric, 9);
               WS_SEQFILE_REC.CreateNewField(Names.WS_NVR_L2_CNT_13, FieldType.SignedNumeric, 9);
               WS_SEQFILE_REC.CreateNewField(Names.WS_CUR_L2A_CNT_14, FieldType.SignedNumeric, 9);
               WS_SEQFILE_REC.CreateNewField(Names.WS_FMR_L2A_CNT_15, FieldType.SignedNumeric, 9);
               WS_SEQFILE_REC.CreateNewField(Names.WS_NVR_L2A_CNT_16, FieldType.SignedNumeric, 9);
               WS_SEQFILE_REC.CreateNewField(Names.WS_CUR_L2B_CNT_17, FieldType.SignedNumeric, 9);
               WS_SEQFILE_REC.CreateNewField(Names.WS_FMR_L2B_CNT_18, FieldType.SignedNumeric, 9);
               WS_SEQFILE_REC.CreateNewField(Names.WS_NVR_L2B_CNT_19, FieldType.SignedNumeric, 9);
               WS_SEQFILE_REC.CreateNewField(Names.WS_CUR_L2C_CNT_20, FieldType.SignedNumeric, 9);
               WS_SEQFILE_REC.CreateNewField(Names.WS_FMR_L2C_CNT_21, FieldType.SignedNumeric, 9);
               WS_SEQFILE_REC.CreateNewField(Names.WS_NVR_L2C_CNT_22, FieldType.SignedNumeric, 9);
               WS_SEQFILE_REC.CreateNewField(Names.WS_NVR_L2D_CNT_23, FieldType.SignedNumeric, 9);
               WS_SEQFILE_REC.CreateNewField(Names.WS_CUR_L3_CNT_24, FieldType.SignedNumeric, 9);
               WS_SEQFILE_REC.CreateNewField(Names.WS_FMR_L3_CNT_25, FieldType.SignedNumeric, 9);
               WS_SEQFILE_REC.CreateNewField(Names.WS_NVR_L3_CNT_26, FieldType.SignedNumeric, 9);
               WS_SEQFILE_REC.CreateNewField(Names.WS_TOT_L4_CNT_27, FieldType.SignedNumeric, 9);
               WS_SEQFILE_REC.CreateNewField(Names.WS_TOT_L5_CNT_28, FieldType.SignedNumeric, 9);
               WS_SEQFILE_REC.CreateNewField(Names.WS_TOT_L6_CNT_29, FieldType.SignedNumeric, 9);
               WS_SEQFILE_REC.CreateNewField(Names.WS_TOT_L7_CNT_30, FieldType.SignedNumeric, 9);
               WS_SEQFILE_REC.CreateNewField(Names.WS_TOT_L8_CNT_31, FieldType.SignedNumeric, 9);
               WS_SEQFILE_REC.CreateNewField(Names.WS_TOT_L9_CNT_32, FieldType.SignedNumeric, 9);
               WS_SEQFILE_REC.CreateNewField(Names.WS_TOT_L10_CNT_33, FieldType.SignedNumeric, 9);
               WS_SEQFILE_REC.CreateNewField(Names.WS_CUR_L12_CNT_34, FieldType.SignedNumeric, 9);
               WS_SEQFILE_REC.CreateNewField(Names.WS_FMR_L12_CNT_35, FieldType.SignedNumeric, 9);
               WS_SEQFILE_REC.CreateNewField(Names.WS_NVR_L12_CNT_36, FieldType.SignedNumeric, 9);
               WS_SEQFILE_REC.CreateNewField(Names.WS_CUR_L13_CNT_37, FieldType.SignedNumeric, 9);
               WS_SEQFILE_REC.CreateNewField(Names.WS_FMR_L13_CNT_38, FieldType.SignedNumeric, 9);
               WS_SEQFILE_REC.CreateNewField(Names.WS_NVR_L13_CNT_39, FieldType.SignedNumeric, 9);
               WS_SEQFILE_REC.CreateNewField(Names.WS_TOT_L14_CNT_40, FieldType.SignedNumeric, 9);
               WS_SEQFILE_REC.CreateNewField(Names.WS_CUR_L16_CNT_41, FieldType.SignedNumeric, 9);
               WS_SEQFILE_REC.CreateNewField(Names.WS_FMR_L16_CNT_42, FieldType.SignedNumeric, 9);
               WS_SEQFILE_REC.CreateNewField(Names.WS_NVR_L16_CNT_43, FieldType.SignedNumeric, 9);
               WS_SEQFILE_REC.CreateNewField(Names.WS_CUR_L17_CNT_44, FieldType.SignedNumeric, 9);
               WS_SEQFILE_REC.CreateNewField(Names.WS_FMR_L17_CNT_45, FieldType.SignedNumeric, 9);
               WS_SEQFILE_REC.CreateNewField(Names.WS_NVR_L17_CNT_46, FieldType.SignedNumeric, 9);
               WS_SEQFILE_REC.CreateNewField(Names.WS_CUR_L18_CNT_47, FieldType.SignedNumeric, 9);
               WS_SEQFILE_REC.CreateNewField(Names.WS_FMR_L18_CNT_48, FieldType.SignedNumeric, 9);
               WS_SEQFILE_REC.CreateNewField(Names.WS_NVR_L18_CNT_49, FieldType.SignedNumeric, 9);
               WS_SEQFILE_REC.CreateNewField(Names.WS_CUR_L18A_CNT_50, FieldType.SignedNumeric, 9);
               WS_SEQFILE_REC.CreateNewField(Names.WS_FMR_L18A_CNT_51, FieldType.SignedNumeric, 9);
               WS_SEQFILE_REC.CreateNewField(Names.WS_NVR_L18A_CNT_52, FieldType.SignedNumeric, 9);
               WS_SEQFILE_REC.CreateNewField(Names.WS_CUR_L19_CNT_53, FieldType.SignedNumeric, 9);
               WS_SEQFILE_REC.CreateNewField(Names.WS_FMR_L19_CNT_54, FieldType.SignedNumeric, 9);
               WS_SEQFILE_REC.CreateNewField(Names.WS_NVR_L19_CNT_55, FieldType.SignedNumeric, 9);
               WS_SEQFILE_REC.CreateNewField(Names.WS_CUR_L20_CNT_56, FieldType.SignedNumeric, 9);
               WS_SEQFILE_REC.CreateNewField(Names.WS_FMR_L20_CNT_57, FieldType.SignedNumeric, 9);
               WS_SEQFILE_REC.CreateNewField(Names.WS_NVR_L20_CNT_58, FieldType.SignedNumeric, 9);
               WS_SEQFILE_REC.CreateNewField(Names.WS_TOT_L21_CNT_59, FieldType.SignedNumeric, 9);
               WS_SEQFILE_REC.CreateNewField(Names.WS_TOT_L22_CNT_60, FieldType.SignedNumeric, 9);
               WS_SEQFILE_REC.CreateNewField(Names.WS_TOT_L23_CNT_61, FieldType.SignedNumeric, 9);
               WS_SEQFILE_REC.CreateNewField(Names.WS_CUR_L24_CNT_62, FieldType.SignedNumeric, 9);
               WS_SEQFILE_REC.CreateNewField(Names.WS_FMR_L24_CNT_63, FieldType.SignedNumeric, 9);
               WS_SEQFILE_REC.CreateNewField(Names.WS_NVR_L24_CNT_64, FieldType.SignedNumeric, 9);
               WS_SEQFILE_REC.CreateNewField(Names.WS_CUR_L25_CNT_65, FieldType.SignedNumeric, 9);
               WS_SEQFILE_REC.CreateNewField(Names.WS_FMR_L25_CNT_66, FieldType.SignedNumeric, 9);
               WS_SEQFILE_REC.CreateNewField(Names.WS_NVR_L25_CNT_67, FieldType.SignedNumeric, 9);
               WS_SEQFILE_REC.CreateNewField(Names.WS_CUR_L26_CNT_68, FieldType.SignedNumeric, 9);
               WS_SEQFILE_REC.CreateNewField(Names.WS_FMR_L26_CNT_69, FieldType.SignedNumeric, 9);
               WS_SEQFILE_REC.CreateNewField(Names.WS_NVR_L26_CNT_70, FieldType.SignedNumeric, 9);
               WS_SEQFILE_REC.CreateNewField(Names.WS_CUR_L27_CNT_71, FieldType.SignedNumeric, 9);
               WS_SEQFILE_REC.CreateNewField(Names.WS_FMR_L27_CNT_72, FieldType.SignedNumeric, 9);
               WS_SEQFILE_REC.CreateNewField(Names.WS_NVR_L27_CNT_73, FieldType.SignedNumeric, 9);
               WS_SEQFILE_REC.CreateNewField(Names.WS_TOT_L28_CNT_74, FieldType.SignedNumeric, 9);
               WS_SEQFILE_REC.CreateNewField(Names.WS_TOT_L29_CNT_75, FieldType.SignedNumeric, 9);
               WS_SEQFILE_REC.CreateNewField(Names.WS_TOT_L30_CNT_76, FieldType.SignedNumeric, 9);
               WS_SEQFILE_REC.CreateNewField(Names.WS_TOT_L31_CNT_77, FieldType.SignedNumeric, 9);
               WS_SEQFILE_REC.CreateNewField(Names.WS_TOT_L32_CNT_78, FieldType.SignedNumeric, 9);
               WS_SEQFILE_REC.CreateNewField(Names.WS_CUR_L38_CNT_79, FieldType.SignedNumeric, 9);
               WS_SEQFILE_REC.CreateNewField(Names.WS_CUR_L39_CNT_80, FieldType.SignedNumeric, 9);
               WS_SEQFILE_REC.CreateNewField(Names.WS_TOT_L40_CNT_81, FieldType.SignedNumeric, 9);
               WS_SEQFILE_REC.CreateNewField(Names.WS_TOT_L41_CNT_82, FieldType.SignedNumeric, 9);
               WS_SEQFILE_REC.CreateNewField(Names.WS_TOT_L42_CNT_83, FieldType.SignedNumeric, 9);
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
    internal class SWEXF710_ls : PredefinedRecordBase
    {
        #region Name constants
        /// <summary>
        /// Name constants.
        /// </summary>
        internal static class Names
        {
            internal const string LinkageSection = "SWEXF710_ls_LinkageSection";
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
            internal const string LSI_1_CURRENT_V1 = "LSI_1_CURRENT_V1";
            internal const string LSI_IEF_SUPPLIED_V1_ET = "LSI_IEF_SUPPLIED_V1_ET";
            internal const string LSI_CUR_L1_CNT_01MS = "LSI_CUR_L1_CNT_01MS";
            internal const string LSI_CUR_L1_CNT_01 = "LSI_CUR_L1_CNT_01";
            internal const string LSI_CUR_L1_CNT_01XX = "LSI_CUR_L1_CNT_01XX";
            internal const string LSI_1_FORMER_V2 = "LSI_1_FORMER_V2";
            internal const string LSI_IEF_SUPPLIED_V2_ET = "LSI_IEF_SUPPLIED_V2_ET";
            internal const string LSI_FMR_L1_CNT_02MS = "LSI_FMR_L1_CNT_02MS";
            internal const string LSI_FMR_L1_CNT_02 = "LSI_FMR_L1_CNT_02";
            internal const string LSI_FMR_L1_CNT_02XX = "LSI_FMR_L1_CNT_02XX";
            internal const string LSI_1_NEVER_V3 = "LSI_1_NEVER_V3";
            internal const string LSI_IEF_SUPPLIED_V3_ET = "LSI_IEF_SUPPLIED_V3_ET";
            internal const string LSI_NVR_L1_CNT_03MS = "LSI_NVR_L1_CNT_03MS";
            internal const string LSI_NVR_L1_CNT_03 = "LSI_NVR_L1_CNT_03";
            internal const string LSI_NVR_L1_CNT_03XX = "LSI_NVR_L1_CNT_03XX";
            internal const string LSI_1A_CURRENT_V4 = "LSI_1A_CURRENT_V4";
            internal const string LSI_IEF_SUPPLIED_V4_ET = "LSI_IEF_SUPPLIED_V4_ET";
            internal const string LSI_CUR_L1A_CNT_04MS = "LSI_CUR_L1A_CNT_04MS";
            internal const string LSI_CUR_L1A_CNT_04 = "LSI_CUR_L1A_CNT_04";
            internal const string LSI_CUR_L1A_CNT_04XX = "LSI_CUR_L1A_CNT_04XX";
            internal const string LSI_1A_FORMER_V5 = "LSI_1A_FORMER_V5";
            internal const string LSI_IEF_SUPPLIED_V5_ET = "LSI_IEF_SUPPLIED_V5_ET";
            internal const string LSI_FMR_L1A_CNT_05MS = "LSI_FMR_L1A_CNT_05MS";
            internal const string LSI_FMR_L1A_CNT_05 = "LSI_FMR_L1A_CNT_05";
            internal const string LSI_FMR_L1A_CNT_05XX = "LSI_FMR_L1A_CNT_05XX";
            internal const string LSI_1A_NEVER_V6 = "LSI_1A_NEVER_V6";
            internal const string LSI_IEF_SUPPLIED_V6_ET = "LSI_IEF_SUPPLIED_V6_ET";
            internal const string LSI_NVR_L1A_CNT_06MS = "LSI_NVR_L1A_CNT_06MS";
            internal const string LSI_NVR_L1A_CNT_06 = "LSI_NVR_L1A_CNT_06";
            internal const string LSI_NVR_L1A_CNT_06XX = "LSI_NVR_L1A_CNT_06XX";
            internal const string LSI_1B_CURRENT_V7 = "LSI_1B_CURRENT_V7";
            internal const string LSI_IEF_SUPPLIED_V7_ET = "LSI_IEF_SUPPLIED_V7_ET";
            internal const string LSI_CUR_L1B_CNT_07MS = "LSI_CUR_L1B_CNT_07MS";
            internal const string LSI_CUR_L1B_CNT_07 = "LSI_CUR_L1B_CNT_07";
            internal const string LSI_CUR_L1B_CNT_07XX = "LSI_CUR_L1B_CNT_07XX";
            internal const string LSI_1B_FORMER_V8 = "LSI_1B_FORMER_V8";
            internal const string LSI_IEF_SUPPLIED_V8_ET = "LSI_IEF_SUPPLIED_V8_ET";
            internal const string LSI_FMR_L1B_CNT_08MS = "LSI_FMR_L1B_CNT_08MS";
            internal const string LSI_FMR_L1B_CNT_08 = "LSI_FMR_L1B_CNT_08";
            internal const string LSI_FMR_L1B_CNT_08XX = "LSI_FMR_L1B_CNT_08XX";
            internal const string LSI_1B_NEVER_V9 = "LSI_1B_NEVER_V9";
            internal const string LSI_IEF_SUPPLIED_V9_ET = "LSI_IEF_SUPPLIED_V9_ET";
            internal const string LSI_NVR_L1B_CNT_09MS = "LSI_NVR_L1B_CNT_09MS";
            internal const string LSI_NVR_L1B_CNT_09 = "LSI_NVR_L1B_CNT_09";
            internal const string LSI_NVR_L1B_CNT_09XX = "LSI_NVR_L1B_CNT_09XX";
            internal const string LSI_1C_NEVER_V10 = "LSI_1C_NEVER_V10";
            internal const string LSI_IEF_SUPPLIED_V10_ET = "LSI_IEF_SUPPLIED_V10_ET";
            internal const string LSI_NVR_L1C_CNT_10MS = "LSI_NVR_L1C_CNT_10MS";
            internal const string LSI_NVR_L1C_CNT_10 = "LSI_NVR_L1C_CNT_10";
            internal const string LSI_NVR_L1C_CNT_10XX = "LSI_NVR_L1C_CNT_10XX";
            internal const string LSI_2_CURRENT_V11 = "LSI_2_CURRENT_V11";
            internal const string LSI_IEF_SUPPLIED_V11_ET = "LSI_IEF_SUPPLIED_V11_ET";
            internal const string LSI_CUR_L2_CNT_11MS = "LSI_CUR_L2_CNT_11MS";
            internal const string LSI_CUR_L2_CNT_11 = "LSI_CUR_L2_CNT_11";
            internal const string LSI_CUR_L2_CNT_11XX = "LSI_CUR_L2_CNT_11XX";
            internal const string LSI_2_FORMER_V12 = "LSI_2_FORMER_V12";
            internal const string LSI_IEF_SUPPLIED_V12_ET = "LSI_IEF_SUPPLIED_V12_ET";
            internal const string LSI_FMR_L2_CNT_12MS = "LSI_FMR_L2_CNT_12MS";
            internal const string LSI_FMR_L2_CNT_12 = "LSI_FMR_L2_CNT_12";
            internal const string LSI_FMR_L2_CNT_12XX = "LSI_FMR_L2_CNT_12XX";
            internal const string LSI_2_NEVER_V13 = "LSI_2_NEVER_V13";
            internal const string LSI_IEF_SUPPLIED_V13_ET = "LSI_IEF_SUPPLIED_V13_ET";
            internal const string LSI_NVR_L2_CNT_13MS = "LSI_NVR_L2_CNT_13MS";
            internal const string LSI_NVR_L2_CNT_13 = "LSI_NVR_L2_CNT_13";
            internal const string LSI_NVR_L2_CNT_13XX = "LSI_NVR_L2_CNT_13XX";
            internal const string LSI_2A_CURRENT_V14 = "LSI_2A_CURRENT_V14";
            internal const string LSI_IEF_SUPPLIED_V14_ET = "LSI_IEF_SUPPLIED_V14_ET";
            internal const string LSI_CUR_L2A_CNT_14MS = "LSI_CUR_L2A_CNT_14MS";
            internal const string LSI_CUR_L2A_CNT_14 = "LSI_CUR_L2A_CNT_14";
            internal const string LSI_CUR_L2A_CNT_14XX = "LSI_CUR_L2A_CNT_14XX";
            internal const string LSI_2A_FORMER_V15 = "LSI_2A_FORMER_V15";
            internal const string LSI_IEF_SUPPLIED_V15_ET = "LSI_IEF_SUPPLIED_V15_ET";
            internal const string LSI_FMR_L2A_CNT_15MS = "LSI_FMR_L2A_CNT_15MS";
            internal const string LSI_FMR_L2A_CNT_15 = "LSI_FMR_L2A_CNT_15";
            internal const string LSI_FMR_L2A_CNT_15XX = "LSI_FMR_L2A_CNT_15XX";
            internal const string LSI_2A_NEVER_V16 = "LSI_2A_NEVER_V16";
            internal const string LSI_IEF_SUPPLIED_V16_ET = "LSI_IEF_SUPPLIED_V16_ET";
            internal const string LSI_NVR_L2A_CNT_16MS = "LSI_NVR_L2A_CNT_16MS";
            internal const string LSI_NVR_L2A_CNT_16 = "LSI_NVR_L2A_CNT_16";
            internal const string LSI_NVR_L2A_CNT_16XX = "LSI_NVR_L2A_CNT_16XX";
            internal const string LSI_2B_CURRENT_V17 = "LSI_2B_CURRENT_V17";
            internal const string LSI_IEF_SUPPLIED_V17_ET = "LSI_IEF_SUPPLIED_V17_ET";
            internal const string LSI_CUR_L2B_CNT_17MS = "LSI_CUR_L2B_CNT_17MS";
            internal const string LSI_CUR_L2B_CNT_17 = "LSI_CUR_L2B_CNT_17";
            internal const string LSI_CUR_L2B_CNT_17XX = "LSI_CUR_L2B_CNT_17XX";
            internal const string LSI_2B_FORMER_V18 = "LSI_2B_FORMER_V18";
            internal const string LSI_IEF_SUPPLIED_V18_ET = "LSI_IEF_SUPPLIED_V18_ET";
            internal const string LSI_FMR_L2B_CNT_18MS = "LSI_FMR_L2B_CNT_18MS";
            internal const string LSI_FMR_L2B_CNT_18 = "LSI_FMR_L2B_CNT_18";
            internal const string LSI_FMR_L2B_CNT_18XX = "LSI_FMR_L2B_CNT_18XX";
            internal const string LSI_2B_NEVER_V19 = "LSI_2B_NEVER_V19";
            internal const string LSI_IEF_SUPPLIED_V19_ET = "LSI_IEF_SUPPLIED_V19_ET";
            internal const string LSI_NVR_L2B_CNT_19MS = "LSI_NVR_L2B_CNT_19MS";
            internal const string LSI_NVR_L2B_CNT_19 = "LSI_NVR_L2B_CNT_19";
            internal const string LSI_NVR_L2B_CNT_19XX = "LSI_NVR_L2B_CNT_19XX";
            internal const string LSI_2C_CURRENT_V20 = "LSI_2C_CURRENT_V20";
            internal const string LSI_IEF_SUPPLIED_V20_ET = "LSI_IEF_SUPPLIED_V20_ET";
            internal const string LSI_CUR_L2C_CNT_20MS = "LSI_CUR_L2C_CNT_20MS";
            internal const string LSI_CUR_L2C_CNT_20 = "LSI_CUR_L2C_CNT_20";
            internal const string LSI_CUR_L2C_CNT_20XX = "LSI_CUR_L2C_CNT_20XX";
            internal const string LSI_2C_FORMER_V21 = "LSI_2C_FORMER_V21";
            internal const string LSI_IEF_SUPPLIED_V21_ET = "LSI_IEF_SUPPLIED_V21_ET";
            internal const string LSI_FMR_L2C_CNT_21MS = "LSI_FMR_L2C_CNT_21MS";
            internal const string LSI_FMR_L2C_CNT_21 = "LSI_FMR_L2C_CNT_21";
            internal const string LSI_FMR_L2C_CNT_21XX = "LSI_FMR_L2C_CNT_21XX";
            internal const string LSI_2C_NEVER_V22 = "LSI_2C_NEVER_V22";
            internal const string LSI_IEF_SUPPLIED_V22_ET = "LSI_IEF_SUPPLIED_V22_ET";
            internal const string LSI_NVR_L2C_CNT_22MS = "LSI_NVR_L2C_CNT_22MS";
            internal const string LSI_NVR_L2C_CNT_22 = "LSI_NVR_L2C_CNT_22";
            internal const string LSI_NVR_L2C_CNT_22XX = "LSI_NVR_L2C_CNT_22XX";
            internal const string LSI_2D_NEVER_V23 = "LSI_2D_NEVER_V23";
            internal const string LSI_IEF_SUPPLIED_V23_ET = "LSI_IEF_SUPPLIED_V23_ET";
            internal const string LSI_NVR_L2D_CNT_23MS = "LSI_NVR_L2D_CNT_23MS";
            internal const string LSI_NVR_L2D_CNT_23 = "LSI_NVR_L2D_CNT_23";
            internal const string LSI_NVR_L2D_CNT_23XX = "LSI_NVR_L2D_CNT_23XX";
            internal const string LSI_3_CURRENT_V24 = "LSI_3_CURRENT_V24";
            internal const string LSI_IEF_SUPPLIED_V24_ET = "LSI_IEF_SUPPLIED_V24_ET";
            internal const string LSI_CUR_L3_CNT_24MS = "LSI_CUR_L3_CNT_24MS";
            internal const string LSI_CUR_L3_CNT_24 = "LSI_CUR_L3_CNT_24";
            internal const string LSI_CUR_L3_CNT_24XX = "LSI_CUR_L3_CNT_24XX";
            internal const string LSI_3_FORMER_V25 = "LSI_3_FORMER_V25";
            internal const string LSI_IEF_SUPPLIED_V25_ET = "LSI_IEF_SUPPLIED_V25_ET";
            internal const string LSI_FMR_L3_CNT_25MS = "LSI_FMR_L3_CNT_25MS";
            internal const string LSI_FMR_L3_CNT_25 = "LSI_FMR_L3_CNT_25";
            internal const string LSI_FMR_L3_CNT_25XX = "LSI_FMR_L3_CNT_25XX";
            internal const string LSI_3_NEVER_V26 = "LSI_3_NEVER_V26";
            internal const string LSI_IEF_SUPPLIED_V26_ET = "LSI_IEF_SUPPLIED_V26_ET";
            internal const string LSI_NVR_L3_CNT_26MS = "LSI_NVR_L3_CNT_26MS";
            internal const string LSI_NVR_L3_CNT_26 = "LSI_NVR_L3_CNT_26";
            internal const string LSI_NVR_L3_CNT_26XX = "LSI_NVR_L3_CNT_26XX";
            internal const string LSI_4_TOTAL_V27 = "LSI_4_TOTAL_V27";
            internal const string LSI_IEF_SUPPLIED_V27_ET = "LSI_IEF_SUPPLIED_V27_ET";
            internal const string LSI_TOT_L4_TOT_L4_CNT_27MS = "LSI_TOT_L4_TOT_L4_CNT_27MS";
            internal const string LSI_TOT_L4_CNT_27 = "LSI_TOT_L4_CNT_27";
            internal const string LSI_TOT_L4_CNT_27XX = "LSI_TOT_L4_CNT_27XX";
            internal const string LSI_5_TOTAL_V28 = "LSI_5_TOTAL_V28";
            internal const string LSI_IEF_SUPPLIED_V28_ET = "LSI_IEF_SUPPLIED_V28_ET";
            internal const string LSI_TOT_L5_CNT_28MS = "LSI_TOT_L5_CNT_28MS";
            internal const string LSI_TOT_L5_CNT_28 = "LSI_TOT_L5_CNT_28";
            internal const string LSI_TOT_L5_CNT_28XX = "LSI_TOT_L5_CNT_28XX";
            internal const string LSI_6_TOTAL_V29 = "LSI_6_TOTAL_V29";
            internal const string LSI_IEF_SUPPLIED_V29_ET = "LSI_IEF_SUPPLIED_V29_ET";
            internal const string LSI_TOT_L6_CNT_29MS = "LSI_TOT_L6_CNT_29MS";
            internal const string LSI_TOT_L6_CNT_29 = "LSI_TOT_L6_CNT_29";
            internal const string LSI_TOT_L6_CNT_29XX = "LSI_TOT_L6_CNT_29XX";
            internal const string LSI_7_TOTAL_V30 = "LSI_7_TOTAL_V30";
            internal const string LSI_IEF_SUPPLIED_V30_ET = "LSI_IEF_SUPPLIED_V30_ET";
            internal const string LSI_TOT_L7_CNT_30MS = "LSI_TOT_L7_CNT_30MS";
            internal const string LSI_TOT_L7_CNT_30 = "LSI_TOT_L7_CNT_30";
            internal const string LSI_TOT_L7_CNT_30XX = "LSI_TOT_L7_CNT_30XX";
            internal const string LSI_8_TOTAL_V31 = "LSI_8_TOTAL_V31";
            internal const string LSI_IEF_SUPPLIED_V31_ET = "LSI_IEF_SUPPLIED_V31_ET";
            internal const string LSI_TOT_L8_CNT_31MS = "LSI_TOT_L8_CNT_31MS";
            internal const string LSI_TOT_L8_CNT_31 = "LSI_TOT_L8_CNT_31";
            internal const string LSI_TOT_L8_CNT_31XX = "LSI_TOT_L8_CNT_31XX";
            internal const string LSI_9_TOTAL_V32 = "LSI_9_TOTAL_V32";
            internal const string LSI_IEF_SUPPLIED_V32_ET = "LSI_IEF_SUPPLIED_V32_ET";
            internal const string LSI_TOT_L9_CNT_32MS = "LSI_TOT_L9_CNT_32MS";
            internal const string LSI_TOT_L9_CNT_32 = "LSI_TOT_L9_CNT_32";
            internal const string LSI_TOT_L9_CNT_32XX = "LSI_TOT_L9_CNT_32XX";
            internal const string LSI_10_TOTAL_V33 = "LSI_10_TOTAL_V33";
            internal const string LSI_IEF_SUPPLIED_V33_ET = "LSI_IEF_SUPPLIED_V33_ET";
            internal const string LSI_TOT_L10_CNT_33MS = "LSI_TOT_L10_CNT_33MS";
            internal const string LSI_TOT_L10_CNT_33 = "LSI_TOT_L10_CNT_33";
            internal const string LSI_TOT_L10_CNT_33XX = "LSI_TOT_L10_CNT_33XX";
            internal const string LSI_12_CURRENT_V34 = "LSI_12_CURRENT_V34";
            internal const string LSI_IEF_SUPPLIED_V34_ET = "LSI_IEF_SUPPLIED_V34_ET";
            internal const string LSI_CUR_L12_CNT_34MS = "LSI_CUR_L12_CNT_34MS";
            internal const string LSI_CUR_L12_CNT_34 = "LSI_CUR_L12_CNT_34";
            internal const string LSI_CUR_L12_CNT_34XX = "LSI_CUR_L12_CNT_34XX";
            internal const string LSI_12_FORMER_V35 = "LSI_12_FORMER_V35";
            internal const string LSI_IEF_SUPPLIED_V35_ET = "LSI_IEF_SUPPLIED_V35_ET";
            internal const string LSI_FMR_L12_CNT_35MS = "LSI_FMR_L12_CNT_35MS";
            internal const string LSI_FMR_L12_CNT_35 = "LSI_FMR_L12_CNT_35";
            internal const string LSI_FMR_L12_CNT_35XX = "LSI_FMR_L12_CNT_35XX";
            internal const string LSI_12_NEVER_V36 = "LSI_12_NEVER_V36";
            internal const string LSI_IEF_SUPPLIED_V36_ET = "LSI_IEF_SUPPLIED_V36_ET";
            internal const string LSI_NVR_L12_CNT_36MS = "LSI_NVR_L12_CNT_36MS";
            internal const string LSI_NVR_L12_CNT_36 = "LSI_NVR_L12_CNT_36";
            internal const string LSI_NVR_L12_CNT_36XX = "LSI_NVR_L12_CNT_36XX";
            internal const string LSI_13_CURRENT_V37 = "LSI_13_CURRENT_V37";
            internal const string LSI_IEF_SUPPLIED_V37_ET = "LSI_IEF_SUPPLIED_V37_ET";
            internal const string LSI_CUR_L13_CNT_37MS = "LSI_CUR_L13_CNT_37MS";
            internal const string LSI_CUR_L13_CNT_37 = "LSI_CUR_L13_CNT_37";
            internal const string LSI_CUR_L13_CNT_37XX = "LSI_CUR_L13_CNT_37XX";
            internal const string LSI_13_FORMER_V38 = "LSI_13_FORMER_V38";
            internal const string LSI_IEF_SUPPLIED_V38_ET = "LSI_IEF_SUPPLIED_V38_ET";
            internal const string LSI_FMR_L13_CNT_38MS = "LSI_FMR_L13_CNT_38MS";
            internal const string LSI_FMR_L13_CNT_38 = "LSI_FMR_L13_CNT_38";
            internal const string LSI_FMR_L13_CNT_38XX = "LSI_FMR_L13_CNT_38XX";
            internal const string LSI_13_NEVER_V39 = "LSI_13_NEVER_V39";
            internal const string LSI_IEF_SUPPLIED_V39_ET = "LSI_IEF_SUPPLIED_V39_ET";
            internal const string LSI_NVR_L13_CNT_39MS = "LSI_NVR_L13_CNT_39MS";
            internal const string LSI_NVR_L13_CNT_39 = "LSI_NVR_L13_CNT_39";
            internal const string LSI_NVR_L13_CNT_39XX = "LSI_NVR_L13_CNT_39XX";
            internal const string LSI_14_TOTAL_V40 = "LSI_14_TOTAL_V40";
            internal const string LSI_IEF_SUPPLIED_V40_ET = "LSI_IEF_SUPPLIED_V40_ET";
            internal const string LSI_TOT_L14_CNT_40MS = "LSI_TOT_L14_CNT_40MS";
            internal const string LSI_TOT_L14_CNT_40 = "LSI_TOT_L14_CNT_40";
            internal const string LSI_TOT_L14_CNT_40XX = "LSI_TOT_L14_CNT_40XX";
            internal const string LSI_16_CURRENT_V41 = "LSI_16_CURRENT_V41";
            internal const string LSI_IEF_SUPPLIED_V41_ET = "LSI_IEF_SUPPLIED_V41_ET";
            internal const string LSI_CUR_L16_CNT_41MS = "LSI_CUR_L16_CNT_41MS";
            internal const string LSI_CUR_L16_CNT_41 = "LSI_CUR_L16_CNT_41";
            internal const string LSI_CUR_L16_CNT_41XX = "LSI_CUR_L16_CNT_41XX";
            internal const string LSI_16_FORMER_V42 = "LSI_16_FORMER_V42";
            internal const string LSI_IEF_SUPPLIED_V42_ET = "LSI_IEF_SUPPLIED_V42_ET";
            internal const string LSI_FMR_L16_CNT_42MS = "LSI_FMR_L16_CNT_42MS";
            internal const string LSI_FMR_L16_CNT_42 = "LSI_FMR_L16_CNT_42";
            internal const string LSI_FMR_L16_CNT_42XX = "LSI_FMR_L16_CNT_42XX";
            internal const string LSI_16_NEVER_V43 = "LSI_16_NEVER_V43";
            internal const string LSI_IEF_SUPPLIED_V43_ET = "LSI_IEF_SUPPLIED_V43_ET";
            internal const string LSI_NVR_L16_CNT_43MS = "LSI_NVR_L16_CNT_43MS";
            internal const string LSI_NVR_L16_CNT_43 = "LSI_NVR_L16_CNT_43";
            internal const string LSI_NVR_L16_CNT_43XX = "LSI_NVR_L16_CNT_43XX";
            internal const string LSI_17_CURRENT_V44 = "LSI_17_CURRENT_V44";
            internal const string LSI_IEF_SUPPLIED_V44_ET = "LSI_IEF_SUPPLIED_V44_ET";
            internal const string LSI_CUR_L17_CNT_44MS = "LSI_CUR_L17_CNT_44MS";
            internal const string LSI_CUR_L17_CNT_44 = "LSI_CUR_L17_CNT_44";
            internal const string LSI_CUR_L17_CNT_44XX = "LSI_CUR_L17_CNT_44XX";
            internal const string LSI_17_FORMER_V45 = "LSI_17_FORMER_V45";
            internal const string LSI_IEF_SUPPLIED_V45_ET = "LSI_IEF_SUPPLIED_V45_ET";
            internal const string LSI_FMR_L17_CNT_45MS = "LSI_FMR_L17_CNT_45MS";
            internal const string LSI_FMR_L17_CNT_45 = "LSI_FMR_L17_CNT_45";
            internal const string LSI_FMR_L17_CNT_45XX = "LSI_FMR_L17_CNT_45XX";
            internal const string LSI_17_NEVER_V46 = "LSI_17_NEVER_V46";
            internal const string LSI_IEF_SUPPLIED_V46_ET = "LSI_IEF_SUPPLIED_V46_ET";
            internal const string LSI_NVR_L17_CNT_46MS = "LSI_NVR_L17_CNT_46MS";
            internal const string LSI_NVR_L17_CNT_46 = "LSI_NVR_L17_CNT_46";
            internal const string LSI_NVR_L17_CNT_46XX = "LSI_NVR_L17_CNT_46XX";
            internal const string LSI_18_CURRENT_V47 = "LSI_18_CURRENT_V47";
            internal const string LSI_IEF_SUPPLIED_V47_ET = "LSI_IEF_SUPPLIED_V47_ET";
            internal const string LSI_CUR_L18_CNT_47MS = "LSI_CUR_L18_CNT_47MS";
            internal const string LSI_CUR_L18_CNT_47 = "LSI_CUR_L18_CNT_47";
            internal const string LSI_CUR_L18_CNT_47XX = "LSI_CUR_L18_CNT_47XX";
            internal const string LSI_18_FORMER_V48 = "LSI_18_FORMER_V48";
            internal const string LSI_IEF_SUPPLIED_V48_ET = "LSI_IEF_SUPPLIED_V48_ET";
            internal const string LSI_FMR_L18_CNT_48MS = "LSI_FMR_L18_CNT_48MS";
            internal const string LSI_FMR_L18_CNT_48 = "LSI_FMR_L18_CNT_48";
            internal const string LSI_FMR_L18_CNT_48XX = "LSI_FMR_L18_CNT_48XX";
            internal const string LSI_18_NEVER_V49 = "LSI_18_NEVER_V49";
            internal const string LSI_IEF_SUPPLIED_V49_ET = "LSI_IEF_SUPPLIED_V49_ET";
            internal const string LSI_NVR_L18_CNT_49MS = "LSI_NVR_L18_CNT_49MS";
            internal const string LSI_NVR_L18_CNT_49 = "LSI_NVR_L18_CNT_49";
            internal const string LSI_NVR_L18_CNT_49XX = "LSI_NVR_L18_CNT_49XX";
            internal const string LSI_18A_CURRENT_V50 = "LSI_18A_CURRENT_V50";
            internal const string LSI_IEF_SUPPLIED_V50_ET = "LSI_IEF_SUPPLIED_V50_ET";
            internal const string LSI_CUR_L18A_CNT_50MS = "LSI_CUR_L18A_CNT_50MS";
            internal const string LSI_CUR_L18A_CNT_50 = "LSI_CUR_L18A_CNT_50";
            internal const string LSI_CUR_L18A_CNT_50XX = "LSI_CUR_L18A_CNT_50XX";
            internal const string LSI_18A_FORMER_V51 = "LSI_18A_FORMER_V51";
            internal const string LSI_IEF_SUPPLIED_V51_ET = "LSI_IEF_SUPPLIED_V51_ET";
            internal const string LSI_FMR_L18A_CNT_51MS = "LSI_FMR_L18A_CNT_51MS";
            internal const string LSI_FMR_L18A_CNT_51 = "LSI_FMR_L18A_CNT_51";
            internal const string LSI_FMR_L18A_CNT_51XX = "LSI_FMR_L18A_CNT_51XX";
            internal const string LSI_18A_NEVER_V52 = "LSI_18A_NEVER_V52";
            internal const string LSI_IEF_SUPPLIED_V52_ET = "LSI_IEF_SUPPLIED_V52_ET";
            internal const string LSI_NVR_L18A_CNT_52MS = "LSI_NVR_L18A_CNT_52MS";
            internal const string LSI_NVR_L18A_CNT_52 = "LSI_NVR_L18A_CNT_52";
            internal const string LSI_NVR_L18A_CNT_52XX = "LSI_NVR_L18A_CNT_52XX";
            internal const string LSI_19_CURRENT_V53 = "LSI_19_CURRENT_V53";
            internal const string LSI_IEF_SUPPLIED_V53_ET = "LSI_IEF_SUPPLIED_V53_ET";
            internal const string LSI_CUR_L19_CNT_53MS = "LSI_CUR_L19_CNT_53MS";
            internal const string LSI_CUR_L19_CNT_53 = "LSI_CUR_L19_CNT_53";
            internal const string LSI_CUR_L19_CNT_53XX = "LSI_CUR_L19_CNT_53XX";
            internal const string LSI_19_FORMER_V54 = "LSI_19_FORMER_V54";
            internal const string LSI_IEF_SUPPLIED_V54_ET = "LSI_IEF_SUPPLIED_V54_ET";
            internal const string LSI_FMR_L19_CNT_54MS = "LSI_FMR_L19_CNT_54MS";
            internal const string LSI_FMR_L19_CNT_54 = "LSI_FMR_L19_CNT_54";
            internal const string LSI_FMR_L19_CNT_54XX = "LSI_FMR_L19_CNT_54XX";
            internal const string LSI_19_NEVER_V55 = "LSI_19_NEVER_V55";
            internal const string LSI_IEF_SUPPLIED_V55_ET = "LSI_IEF_SUPPLIED_V55_ET";
            internal const string LSI_NVR_L19_CNT_55MS = "LSI_NVR_L19_CNT_55MS";
            internal const string LSI_NVR_L19_CNT_55 = "LSI_NVR_L19_CNT_55";
            internal const string LSI_NVR_L19_CNT_55XX = "LSI_NVR_L19_CNT_55XX";
            internal const string LSI_20_CURRENT_V56 = "LSI_20_CURRENT_V56";
            internal const string LSI_IEF_SUPPLIED_V56_ET = "LSI_IEF_SUPPLIED_V56_ET";
            internal const string LSI_CUR_L20_CNT_56MS = "LSI_CUR_L20_CNT_56MS";
            internal const string LSI_CUR_L20_CNT_56 = "LSI_CUR_L20_CNT_56";
            internal const string LSI_CUR_L20_CNT_56XX = "LSI_CUR_L20_CNT_56XX";
            internal const string LSI_20_FORMER_V57 = "LSI_20_FORMER_V57";
            internal const string LSI_IEF_SUPPLIED_V57_ET = "LSI_IEF_SUPPLIED_V57_ET";
            internal const string LSI_FMR_L20_CNT_57MS = "LSI_FMR_L20_CNT_57MS";
            internal const string LSI_FMR_L20_CNT_57 = "LSI_FMR_L20_CNT_57";
            internal const string LSI_FMR_L20_CNT_57XX = "LSI_FMR_L20_CNT_57XX";
            internal const string LSI_20_NEVER_V58 = "LSI_20_NEVER_V58";
            internal const string LSI_IEF_SUPPLIED_V58_ET = "LSI_IEF_SUPPLIED_V58_ET";
            internal const string LSI_NVR_L20_CNT_58MS = "LSI_NVR_L20_CNT_58MS";
            internal const string LSI_NVR_L20_CNT_58 = "LSI_NVR_L20_CNT_58";
            internal const string LSI_NVR_L20_CNT_58XX = "LSI_NVR_L20_CNT_58XX";
            internal const string LSI_21_TOTAL_V59 = "LSI_21_TOTAL_V59";
            internal const string LSI_IEF_SUPPLIED_V59_ET = "LSI_IEF_SUPPLIED_V59_ET";
            internal const string LSI_TOT_L21_CNT_59MS = "LSI_TOT_L21_CNT_59MS";
            internal const string LSI_TOT_L21_CNT_59 = "LSI_TOT_L21_CNT_59";
            internal const string LSI_TOT_L21_CNT_59XX = "LSI_TOT_L21_CNT_59XX";
            internal const string LSI_22_TOTAL_V60 = "LSI_22_TOTAL_V60";
            internal const string LSI_IEF_SUPPLIED_V60_ET = "LSI_IEF_SUPPLIED_V60_ET";
            internal const string LSI_TOT_L22_CNT_60MS = "LSI_TOT_L22_CNT_60MS";
            internal const string LSI_TOT_L22_CNT_60 = "LSI_TOT_L22_CNT_60";
            internal const string LSI_TOT_L22_CNT_60XX = "LSI_TOT_L22_CNT_60XX";
            internal const string LSI_23_TOTAL_V61 = "LSI_23_TOTAL_V61";
            internal const string LSI_IEF_SUPPLIED_V61_ET = "LSI_IEF_SUPPLIED_V61_ET";
            internal const string LSI_TOT_L23_CNT_61MS = "LSI_TOT_L23_CNT_61MS";
            internal const string LSI_TOT_L23_CNT_61 = "LSI_TOT_L23_CNT_61";
            internal const string LSI_TOT_L23_CNT_61XX = "LSI_TOT_L23_CNT_61XX";
            internal const string LSI_24_CURRENT_V62 = "LSI_24_CURRENT_V62";
            internal const string LSI_IEF_SUPPLIED_V62_ET = "LSI_IEF_SUPPLIED_V62_ET";
            internal const string LSI_CUR_L24_CNT_62MS = "LSI_CUR_L24_CNT_62MS";
            internal const string LSI_CUR_L24_CNT_62 = "LSI_CUR_L24_CNT_62";
            internal const string LSI_CUR_L24_CNT_62XX = "LSI_CUR_L24_CNT_62XX";
            internal const string LSI_24_FORMER_V63 = "LSI_24_FORMER_V63";
            internal const string LSI_IEF_SUPPLIED_V63_ET = "LSI_IEF_SUPPLIED_V63_ET";
            internal const string LSI_FMR_L24_CNT_63MS = "LSI_FMR_L24_CNT_63MS";
            internal const string LSI_FMR_L24_CNT_63 = "LSI_FMR_L24_CNT_63";
            internal const string LSI_FMR_L24_CNT_63XX = "LSI_FMR_L24_CNT_63XX";
            internal const string LSI_24_NEVER_V64 = "LSI_24_NEVER_V64";
            internal const string LSI_IEF_SUPPLIED_V64_ET = "LSI_IEF_SUPPLIED_V64_ET";
            internal const string LSI_NVR_L24_CNT_64MS = "LSI_NVR_L24_CNT_64MS";
            internal const string LSI_NVR_L24_CNT_64 = "LSI_NVR_L24_CNT_64";
            internal const string LSI_NVR_L24_CNT_64XX = "LSI_NVR_L24_CNT_64XX";
            internal const string LSI_25_CURRENT_V65 = "LSI_25_CURRENT_V65";
            internal const string LSI_IEF_SUPPLIED_V65_ET = "LSI_IEF_SUPPLIED_V65_ET";
            internal const string LSI_CUR_L25_CNT_65MS = "LSI_CUR_L25_CNT_65MS";
            internal const string LSI_CUR_L25_CNT_65 = "LSI_CUR_L25_CNT_65";
            internal const string LSI_CUR_L25_CNT_65XX = "LSI_CUR_L25_CNT_65XX";
            internal const string LSI_25_FORMER_V66 = "LSI_25_FORMER_V66";
            internal const string LSI_IEF_SUPPLIED_V66_ET = "LSI_IEF_SUPPLIED_V66_ET";
            internal const string LSI_FMR_L25_CNT_66MS = "LSI_FMR_L25_CNT_66MS";
            internal const string LSI_FMR_L25_CNT_66 = "LSI_FMR_L25_CNT_66";
            internal const string LSI_FMR_L25_CNT_66XX = "LSI_FMR_L25_CNT_66XX";
            internal const string LSI_25_NEVER_V67 = "LSI_25_NEVER_V67";
            internal const string LSI_IEF_SUPPLIED_V67_ET = "LSI_IEF_SUPPLIED_V67_ET";
            internal const string LSI_NVR_L25_CNT_67MS = "LSI_NVR_L25_CNT_67MS";
            internal const string LSI_NVR_L25_CNT_67 = "LSI_NVR_L25_CNT_67";
            internal const string LSI_NVR_L25_CNT_67XX = "LSI_NVR_L25_CNT_67XX";
            internal const string LSI_26_CURRENT_V68 = "LSI_26_CURRENT_V68";
            internal const string LSI_IEF_SUPPLIED_V68_ET = "LSI_IEF_SUPPLIED_V68_ET";
            internal const string LSI_CUR_L26_CNT_68MS = "LSI_CUR_L26_CNT_68MS";
            internal const string LSI_CUR_L26_CNT_68 = "LSI_CUR_L26_CNT_68";
            internal const string LSI_CUR_L26_CNT_68XX = "LSI_CUR_L26_CNT_68XX";
            internal const string LSI_26_FORMER_V69 = "LSI_26_FORMER_V69";
            internal const string LSI_IEF_SUPPLIED_V69_ET = "LSI_IEF_SUPPLIED_V69_ET";
            internal const string LSI_FMR_L26_CNT_69MS = "LSI_FMR_L26_CNT_69MS";
            internal const string LSI_FMR_L26_CNT_69 = "LSI_FMR_L26_CNT_69";
            internal const string LSI_FMR_L26_CNT_69XX = "LSI_FMR_L26_CNT_69XX";
            internal const string LSI_26_NEVER_V70 = "LSI_26_NEVER_V70";
            internal const string LSI_IEF_SUPPLIED_V70_ET = "LSI_IEF_SUPPLIED_V70_ET";
            internal const string LSI_NVR_L26_CNT_70MS = "LSI_NVR_L26_CNT_70MS";
            internal const string LSI_NVR_L26_CNT_70 = "LSI_NVR_L26_CNT_70";
            internal const string LSI_NVR_L26_CNT_70XX = "LSI_NVR_L26_CNT_70XX";
            internal const string LSI_27_CURRENT_V71 = "LSI_27_CURRENT_V71";
            internal const string LSI_IEF_SUPPLIED_V71_ET = "LSI_IEF_SUPPLIED_V71_ET";
            internal const string LSI_CUR_L27_CNT_71MS = "LSI_CUR_L27_CNT_71MS";
            internal const string LSI_CUR_L27_CNT_71 = "LSI_CUR_L27_CNT_71";
            internal const string LSI_CUR_L27_CNT_71XX = "LSI_CUR_L27_CNT_71XX";
            internal const string LSI_27_FORMER_V72 = "LSI_27_FORMER_V72";
            internal const string LSI_IEF_SUPPLIED_V72_ET = "LSI_IEF_SUPPLIED_V72_ET";
            internal const string LSI_FMR_L27_CNT_72MS = "LSI_FMR_L27_CNT_72MS";
            internal const string LSI_FMR_L27_CNT_72 = "LSI_FMR_L27_CNT_72";
            internal const string LSI_FMR_L27_CNT_72XX = "LSI_FMR_L27_CNT_72XX";
            internal const string LSI_27_NEVER_V73 = "LSI_27_NEVER_V73";
            internal const string LSI_IEF_SUPPLIED_V73_ET = "LSI_IEF_SUPPLIED_V73_ET";
            internal const string LSI_NVR_L27_CNT_73MS = "LSI_NVR_L27_CNT_73MS";
            internal const string LSI_NVR_L27_CNT_73 = "LSI_NVR_L27_CNT_73";
            internal const string LSI_NVR_L27_CNT_73XX = "LSI_NVR_L27_CNT_73XX";
            internal const string LSI_28_TOTAL_V74 = "LSI_28_TOTAL_V74";
            internal const string LSI_IEF_SUPPLIED_V74_ET = "LSI_IEF_SUPPLIED_V74_ET";
            internal const string LSI_TOT_L28_CNT_74MS = "LSI_TOT_L28_CNT_74MS";
            internal const string LSI_TOT_L28_CNT_74 = "LSI_TOT_L28_CNT_74";
            internal const string LSI_TOT_L28_CNT_74XX = "LSI_TOT_L28_CNT_74XX";
            internal const string LSI_29_TOTAL_V75 = "LSI_29_TOTAL_V75";
            internal const string LSI_IEF_SUPPLIED_V75_ET = "LSI_IEF_SUPPLIED_V75_ET";
            internal const string LSI_TOT_L29_CNT_75MS = "LSI_TOT_L29_CNT_75MS";
            internal const string LSI_TOT_L29_CNT_75 = "LSI_TOT_L29_CNT_75";
            internal const string LSI_TOT_L29_CNT_75XX = "LSI_TOT_L29_CNT_75XX";
            internal const string LSI_30_TOTAL_V76 = "LSI_30_TOTAL_V76";
            internal const string LSI_IEF_SUPPLIED_V76_ET = "LSI_IEF_SUPPLIED_V76_ET";
            internal const string LSI_TOT_L30_CNT_76MS = "LSI_TOT_L30_CNT_76MS";
            internal const string LSI_TOT_L30_CNT_76 = "LSI_TOT_L30_CNT_76";
            internal const string LSI_TOT_L30_CNT_76XX = "LSI_TOT_L30_CNT_76XX";
            internal const string LSI_31_TOTAL_V77 = "LSI_31_TOTAL_V77";
            internal const string LSI_IEF_SUPPLIED_V77_ET = "LSI_IEF_SUPPLIED_V77_ET";
            internal const string LSI_TOT_L31_CNT_77MS = "LSI_TOT_L31_CNT_77MS";
            internal const string LSI_TOT_L31_CNT_77 = "LSI_TOT_L31_CNT_77";
            internal const string LSI_TOT_L31_CNT_77XX = "LSI_TOT_L31_CNT_77XX";
            internal const string LSI_32_TOTAL_V78 = "LSI_32_TOTAL_V78";
            internal const string LSI_IEF_SUPPLIED_V78_ET = "LSI_IEF_SUPPLIED_V78_ET";
            internal const string LSI_TOT_L32_CNT_78MS = "LSI_TOT_L32_CNT_78MS";
            internal const string LSI_TOT_L32_CNT_78 = "LSI_TOT_L32_CNT_78";
            internal const string LSI_TOT_L32_CNT_78XX = "LSI_TOT_L32_CNT_78XX";
            internal const string LSI_38_CURRENT_V79 = "LSI_38_CURRENT_V79";
            internal const string LSI_IEF_SUPPLIED_V79_ET = "LSI_IEF_SUPPLIED_V79_ET";
            internal const string LSI_CUR_L38_CNT_79MS = "LSI_CUR_L38_CNT_79MS";
            internal const string LSI_CUR_L38_CNT_79 = "LSI_CUR_L38_CNT_79";
            internal const string LSI_CUR_L38_CNT_79XX = "LSI_CUR_L38_CNT_79XX";
            internal const string LSI_39_CURRENT_V80 = "LSI_39_CURRENT_V80";
            internal const string LSI_IEF_SUPPLIED_V80_ET = "LSI_IEF_SUPPLIED_V80_ET";
            internal const string LSI_CUR_L39_CNT_80MS = "LSI_CUR_L39_CNT_80MS";
            internal const string LSI_CUR_L39_CNT_80 = "LSI_CUR_L39_CNT_80";
            internal const string LSI_CUR_L39_CNT_80XX = "LSI_CUR_L39_CNT_80XX";
            internal const string LSI_40_TOTAL_V81 = "LSI_40_TOTAL_V81";
            internal const string LSI_IEF_SUPPLIED_V81_ET = "LSI_IEF_SUPPLIED_V81_ET";
            internal const string LSI_TOT_L40_CNT_81MS = "LSI_TOT_L40_CNT_81MS";
            internal const string LSI_TOT_L40_CNT_81 = "LSI_TOT_L40_CNT_81";
            internal const string LSI_TOT_L40_CNT_81XX = "LSI_TOT_L40_CNT_81XX";
            internal const string LSI_41_TOTAL_V82 = "LSI_41_TOTAL_V82";
            internal const string LSI_IEF_SUPPLIED_V82_ET = "LSI_IEF_SUPPLIED_V82_ET";
            internal const string LSI_TOT_L41_CNT_82MS = "LSI_TOT_L41_CNT_82MS";
            internal const string LSI_TOT_L41_CNT_82 = "LSI_TOT_L41_CNT_82";
            internal const string LSI_TOT_L41_CNT_82XX = "LSI_TOT_L41_CNT_82XX";
            internal const string LSI_42_TOTAL_V83 = "LSI_42_TOTAL_V83";
            internal const string LSI_IEF_SUPPLIED_V83_ET = "LSI_IEF_SUPPLIED_V83_ET";
            internal const string LSI_TOT_L42_CNT_83MS = "LSI_TOT_L42_CNT_83MS";
            internal const string LSI_TOT_L42_CNT_83 = "LSI_TOT_L42_CNT_83";
            internal const string LSI_TOT_L42_CNT_83XX = "LSI_TOT_L42_CNT_83XX";
            internal const string LSI_V84 = "LSI_V84";
            internal const string LSI_REPORT_PARMS_V84_ET = "LSI_REPORT_PARMS_V84_ET";
            internal const string LSI_PARM1_84MS = "LSI_PARM1_84MS";
            internal const string LSI_PARM1_84 = "LSI_PARM1_84";
            internal const string LSI_PARM1_84XX = "LSI_PARM1_84XX";
            internal const string IO_CONTROL_CD = "IO_CONTROL_CD";
            internal const string LSI_PARM2_85MS = "LSI_PARM2_85MS";
            internal const string LSI_PARM2_85 = "LSI_PARM2_85";
            internal const string LSI_PARM2_85XX = "LSI_PARM2_85XX";
            internal const string LS_RUNTIME_RPT_TYPE_CD = "LS_RUNTIME_RPT_TYPE_CD";
            internal const string LSI_PARM2_1 = "LSI_PARM2_1";
            internal const string LSI_PARM2_2 = "LSI_PARM2_2";
            internal const string LSI_SUBRPT_CD_86MS = "LSI_SUBRPT_CD_86MS";
            internal const string LSI_SUBRPT_CD_86 = "LSI_SUBRPT_CD_86";
            internal const string LSI_SUBRPT_CD_86XX = "LSI_SUBRPT_CD_86XX";
            internal const string LSE_V85 = "LSE_V85";
            internal const string LSE_REPORT_PARMS_ET = "LSE_REPORT_PARMS_ET";
            internal const string LSE_PARM1_87MS = "LSE_PARM1_87MS";
            internal const string LSE_PARM1_87 = "LSE_PARM1_87";
            internal const string LSE_PARM1_87XX = "LSE_PARM1_87XX";
            internal const string LS_RETURN_CD = "LS_RETURN_CD";
            internal const string LSE_PARM2_88MS = "LSE_PARM2_88MS";
            internal const string LSE_PARM2_88 = "LSE_PARM2_88";
            internal const string LSE_PARM2_88XX = "LSE_PARM2_88XX";
            internal const string LSE_SUBRPT_CD_89MS = "LSE_SUBRPT_CD_89MS";
            internal const string LSE_SUBRPT_CD_89 = "LSE_SUBRPT_CD_89";
            internal const string LSE_SUBRPT_CD_89XX = "LSE_SUBRPT_CD_89XX";
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
        public IGroup LSI_1_CURRENT_V1 { get { return GetElementByName<IGroup>(Names.LSI_1_CURRENT_V1); } }
        public IGroup LSI_IEF_SUPPLIED_V1_ET { get { return GetElementByName<IGroup>(Names.LSI_IEF_SUPPLIED_V1_ET); } }
        public IField LSI_CUR_L1_CNT_01MS { get { return GetElementByName<IField>(Names.LSI_CUR_L1_CNT_01MS); } }
        public IField LSI_CUR_L1_CNT_01 { get { return GetElementByName<IField>(Names.LSI_CUR_L1_CNT_01); } }
        public IField LSI_CUR_L1_CNT_01XX { get { return GetElementByName<IField>(Names.LSI_CUR_L1_CNT_01XX); } }
        public IGroup LSI_1_FORMER_V2 { get { return GetElementByName<IGroup>(Names.LSI_1_FORMER_V2); } }
        public IGroup LSI_IEF_SUPPLIED_V2_ET { get { return GetElementByName<IGroup>(Names.LSI_IEF_SUPPLIED_V2_ET); } }
        public IField LSI_FMR_L1_CNT_02MS { get { return GetElementByName<IField>(Names.LSI_FMR_L1_CNT_02MS); } }
        public IField LSI_FMR_L1_CNT_02 { get { return GetElementByName<IField>(Names.LSI_FMR_L1_CNT_02); } }
        public IField LSI_FMR_L1_CNT_02XX { get { return GetElementByName<IField>(Names.LSI_FMR_L1_CNT_02XX); } }
        public IGroup LSI_1_NEVER_V3 { get { return GetElementByName<IGroup>(Names.LSI_1_NEVER_V3); } }
        public IGroup LSI_IEF_SUPPLIED_V3_ET { get { return GetElementByName<IGroup>(Names.LSI_IEF_SUPPLIED_V3_ET); } }
        public IField LSI_NVR_L1_CNT_03MS { get { return GetElementByName<IField>(Names.LSI_NVR_L1_CNT_03MS); } }
        public IField LSI_NVR_L1_CNT_03 { get { return GetElementByName<IField>(Names.LSI_NVR_L1_CNT_03); } }
        public IField LSI_NVR_L1_CNT_03XX { get { return GetElementByName<IField>(Names.LSI_NVR_L1_CNT_03XX); } }
        public IGroup LSI_1A_CURRENT_V4 { get { return GetElementByName<IGroup>(Names.LSI_1A_CURRENT_V4); } }
        public IGroup LSI_IEF_SUPPLIED_V4_ET { get { return GetElementByName<IGroup>(Names.LSI_IEF_SUPPLIED_V4_ET); } }
        public IField LSI_CUR_L1A_CNT_04MS { get { return GetElementByName<IField>(Names.LSI_CUR_L1A_CNT_04MS); } }
        public IField LSI_CUR_L1A_CNT_04 { get { return GetElementByName<IField>(Names.LSI_CUR_L1A_CNT_04); } }
        public IField LSI_CUR_L1A_CNT_04XX { get { return GetElementByName<IField>(Names.LSI_CUR_L1A_CNT_04XX); } }
        public IGroup LSI_1A_FORMER_V5 { get { return GetElementByName<IGroup>(Names.LSI_1A_FORMER_V5); } }
        public IGroup LSI_IEF_SUPPLIED_V5_ET { get { return GetElementByName<IGroup>(Names.LSI_IEF_SUPPLIED_V5_ET); } }
        public IField LSI_FMR_L1A_CNT_05MS { get { return GetElementByName<IField>(Names.LSI_FMR_L1A_CNT_05MS); } }
        public IField LSI_FMR_L1A_CNT_05 { get { return GetElementByName<IField>(Names.LSI_FMR_L1A_CNT_05); } }
        public IField LSI_FMR_L1A_CNT_05XX { get { return GetElementByName<IField>(Names.LSI_FMR_L1A_CNT_05XX); } }
        public IGroup LSI_1A_NEVER_V6 { get { return GetElementByName<IGroup>(Names.LSI_1A_NEVER_V6); } }
        public IGroup LSI_IEF_SUPPLIED_V6_ET { get { return GetElementByName<IGroup>(Names.LSI_IEF_SUPPLIED_V6_ET); } }
        public IField LSI_NVR_L1A_CNT_06MS { get { return GetElementByName<IField>(Names.LSI_NVR_L1A_CNT_06MS); } }
        public IField LSI_NVR_L1A_CNT_06 { get { return GetElementByName<IField>(Names.LSI_NVR_L1A_CNT_06); } }
        public IField LSI_NVR_L1A_CNT_06XX { get { return GetElementByName<IField>(Names.LSI_NVR_L1A_CNT_06XX); } }
        public IGroup LSI_1B_CURRENT_V7 { get { return GetElementByName<IGroup>(Names.LSI_1B_CURRENT_V7); } }
        public IGroup LSI_IEF_SUPPLIED_V7_ET { get { return GetElementByName<IGroup>(Names.LSI_IEF_SUPPLIED_V7_ET); } }
        public IField LSI_CUR_L1B_CNT_07MS { get { return GetElementByName<IField>(Names.LSI_CUR_L1B_CNT_07MS); } }
        public IField LSI_CUR_L1B_CNT_07 { get { return GetElementByName<IField>(Names.LSI_CUR_L1B_CNT_07); } }
        public IField LSI_CUR_L1B_CNT_07XX { get { return GetElementByName<IField>(Names.LSI_CUR_L1B_CNT_07XX); } }
        public IGroup LSI_1B_FORMER_V8 { get { return GetElementByName<IGroup>(Names.LSI_1B_FORMER_V8); } }
        public IGroup LSI_IEF_SUPPLIED_V8_ET { get { return GetElementByName<IGroup>(Names.LSI_IEF_SUPPLIED_V8_ET); } }
        public IField LSI_FMR_L1B_CNT_08MS { get { return GetElementByName<IField>(Names.LSI_FMR_L1B_CNT_08MS); } }
        public IField LSI_FMR_L1B_CNT_08 { get { return GetElementByName<IField>(Names.LSI_FMR_L1B_CNT_08); } }
        public IField LSI_FMR_L1B_CNT_08XX { get { return GetElementByName<IField>(Names.LSI_FMR_L1B_CNT_08XX); } }
        public IGroup LSI_1B_NEVER_V9 { get { return GetElementByName<IGroup>(Names.LSI_1B_NEVER_V9); } }
        public IGroup LSI_IEF_SUPPLIED_V9_ET { get { return GetElementByName<IGroup>(Names.LSI_IEF_SUPPLIED_V9_ET); } }
        public IField LSI_NVR_L1B_CNT_09MS { get { return GetElementByName<IField>(Names.LSI_NVR_L1B_CNT_09MS); } }
        public IField LSI_NVR_L1B_CNT_09 { get { return GetElementByName<IField>(Names.LSI_NVR_L1B_CNT_09); } }
        public IField LSI_NVR_L1B_CNT_09XX { get { return GetElementByName<IField>(Names.LSI_NVR_L1B_CNT_09XX); } }
        public IGroup LSI_1C_NEVER_V10 { get { return GetElementByName<IGroup>(Names.LSI_1C_NEVER_V10); } }
        public IGroup LSI_IEF_SUPPLIED_V10_ET { get { return GetElementByName<IGroup>(Names.LSI_IEF_SUPPLIED_V10_ET); } }
        public IField LSI_NVR_L1C_CNT_10MS { get { return GetElementByName<IField>(Names.LSI_NVR_L1C_CNT_10MS); } }
        public IField LSI_NVR_L1C_CNT_10 { get { return GetElementByName<IField>(Names.LSI_NVR_L1C_CNT_10); } }
        public IField LSI_NVR_L1C_CNT_10XX { get { return GetElementByName<IField>(Names.LSI_NVR_L1C_CNT_10XX); } }
        public IGroup LSI_2_CURRENT_V11 { get { return GetElementByName<IGroup>(Names.LSI_2_CURRENT_V11); } }
        public IGroup LSI_IEF_SUPPLIED_V11_ET { get { return GetElementByName<IGroup>(Names.LSI_IEF_SUPPLIED_V11_ET); } }
        public IField LSI_CUR_L2_CNT_11MS { get { return GetElementByName<IField>(Names.LSI_CUR_L2_CNT_11MS); } }
        public IField LSI_CUR_L2_CNT_11 { get { return GetElementByName<IField>(Names.LSI_CUR_L2_CNT_11); } }
        public IField LSI_CUR_L2_CNT_11XX { get { return GetElementByName<IField>(Names.LSI_CUR_L2_CNT_11XX); } }
        public IGroup LSI_2_FORMER_V12 { get { return GetElementByName<IGroup>(Names.LSI_2_FORMER_V12); } }
        public IGroup LSI_IEF_SUPPLIED_V12_ET { get { return GetElementByName<IGroup>(Names.LSI_IEF_SUPPLIED_V12_ET); } }
        public IField LSI_FMR_L2_CNT_12MS { get { return GetElementByName<IField>(Names.LSI_FMR_L2_CNT_12MS); } }
        public IField LSI_FMR_L2_CNT_12 { get { return GetElementByName<IField>(Names.LSI_FMR_L2_CNT_12); } }
        public IField LSI_FMR_L2_CNT_12XX { get { return GetElementByName<IField>(Names.LSI_FMR_L2_CNT_12XX); } }
        public IGroup LSI_2_NEVER_V13 { get { return GetElementByName<IGroup>(Names.LSI_2_NEVER_V13); } }
        public IGroup LSI_IEF_SUPPLIED_V13_ET { get { return GetElementByName<IGroup>(Names.LSI_IEF_SUPPLIED_V13_ET); } }
        public IField LSI_NVR_L2_CNT_13MS { get { return GetElementByName<IField>(Names.LSI_NVR_L2_CNT_13MS); } }
        public IField LSI_NVR_L2_CNT_13 { get { return GetElementByName<IField>(Names.LSI_NVR_L2_CNT_13); } }
        public IField LSI_NVR_L2_CNT_13XX { get { return GetElementByName<IField>(Names.LSI_NVR_L2_CNT_13XX); } }
        public IGroup LSI_2A_CURRENT_V14 { get { return GetElementByName<IGroup>(Names.LSI_2A_CURRENT_V14); } }
        public IGroup LSI_IEF_SUPPLIED_V14_ET { get { return GetElementByName<IGroup>(Names.LSI_IEF_SUPPLIED_V14_ET); } }
        public IField LSI_CUR_L2A_CNT_14MS { get { return GetElementByName<IField>(Names.LSI_CUR_L2A_CNT_14MS); } }
        public IField LSI_CUR_L2A_CNT_14 { get { return GetElementByName<IField>(Names.LSI_CUR_L2A_CNT_14); } }
        public IField LSI_CUR_L2A_CNT_14XX { get { return GetElementByName<IField>(Names.LSI_CUR_L2A_CNT_14XX); } }
        public IGroup LSI_2A_FORMER_V15 { get { return GetElementByName<IGroup>(Names.LSI_2A_FORMER_V15); } }
        public IGroup LSI_IEF_SUPPLIED_V15_ET { get { return GetElementByName<IGroup>(Names.LSI_IEF_SUPPLIED_V15_ET); } }
        public IField LSI_FMR_L2A_CNT_15MS { get { return GetElementByName<IField>(Names.LSI_FMR_L2A_CNT_15MS); } }
        public IField LSI_FMR_L2A_CNT_15 { get { return GetElementByName<IField>(Names.LSI_FMR_L2A_CNT_15); } }
        public IField LSI_FMR_L2A_CNT_15XX { get { return GetElementByName<IField>(Names.LSI_FMR_L2A_CNT_15XX); } }
        public IGroup LSI_2A_NEVER_V16 { get { return GetElementByName<IGroup>(Names.LSI_2A_NEVER_V16); } }
        public IGroup LSI_IEF_SUPPLIED_V16_ET { get { return GetElementByName<IGroup>(Names.LSI_IEF_SUPPLIED_V16_ET); } }
        public IField LSI_NVR_L2A_CNT_16MS { get { return GetElementByName<IField>(Names.LSI_NVR_L2A_CNT_16MS); } }
        public IField LSI_NVR_L2A_CNT_16 { get { return GetElementByName<IField>(Names.LSI_NVR_L2A_CNT_16); } }
        public IField LSI_NVR_L2A_CNT_16XX { get { return GetElementByName<IField>(Names.LSI_NVR_L2A_CNT_16XX); } }
        public IGroup LSI_2B_CURRENT_V17 { get { return GetElementByName<IGroup>(Names.LSI_2B_CURRENT_V17); } }
        public IGroup LSI_IEF_SUPPLIED_V17_ET { get { return GetElementByName<IGroup>(Names.LSI_IEF_SUPPLIED_V17_ET); } }
        public IField LSI_CUR_L2B_CNT_17MS { get { return GetElementByName<IField>(Names.LSI_CUR_L2B_CNT_17MS); } }
        public IField LSI_CUR_L2B_CNT_17 { get { return GetElementByName<IField>(Names.LSI_CUR_L2B_CNT_17); } }
        public IField LSI_CUR_L2B_CNT_17XX { get { return GetElementByName<IField>(Names.LSI_CUR_L2B_CNT_17XX); } }
        public IGroup LSI_2B_FORMER_V18 { get { return GetElementByName<IGroup>(Names.LSI_2B_FORMER_V18); } }
        public IGroup LSI_IEF_SUPPLIED_V18_ET { get { return GetElementByName<IGroup>(Names.LSI_IEF_SUPPLIED_V18_ET); } }
        public IField LSI_FMR_L2B_CNT_18MS { get { return GetElementByName<IField>(Names.LSI_FMR_L2B_CNT_18MS); } }
        public IField LSI_FMR_L2B_CNT_18 { get { return GetElementByName<IField>(Names.LSI_FMR_L2B_CNT_18); } }
        public IField LSI_FMR_L2B_CNT_18XX { get { return GetElementByName<IField>(Names.LSI_FMR_L2B_CNT_18XX); } }
        public IGroup LSI_2B_NEVER_V19 { get { return GetElementByName<IGroup>(Names.LSI_2B_NEVER_V19); } }
        public IGroup LSI_IEF_SUPPLIED_V19_ET { get { return GetElementByName<IGroup>(Names.LSI_IEF_SUPPLIED_V19_ET); } }
        public IField LSI_NVR_L2B_CNT_19MS { get { return GetElementByName<IField>(Names.LSI_NVR_L2B_CNT_19MS); } }
        public IField LSI_NVR_L2B_CNT_19 { get { return GetElementByName<IField>(Names.LSI_NVR_L2B_CNT_19); } }
        public IField LSI_NVR_L2B_CNT_19XX { get { return GetElementByName<IField>(Names.LSI_NVR_L2B_CNT_19XX); } }
        public IGroup LSI_2C_CURRENT_V20 { get { return GetElementByName<IGroup>(Names.LSI_2C_CURRENT_V20); } }
        public IGroup LSI_IEF_SUPPLIED_V20_ET { get { return GetElementByName<IGroup>(Names.LSI_IEF_SUPPLIED_V20_ET); } }
        public IField LSI_CUR_L2C_CNT_20MS { get { return GetElementByName<IField>(Names.LSI_CUR_L2C_CNT_20MS); } }
        public IField LSI_CUR_L2C_CNT_20 { get { return GetElementByName<IField>(Names.LSI_CUR_L2C_CNT_20); } }
        public IField LSI_CUR_L2C_CNT_20XX { get { return GetElementByName<IField>(Names.LSI_CUR_L2C_CNT_20XX); } }
        public IGroup LSI_2C_FORMER_V21 { get { return GetElementByName<IGroup>(Names.LSI_2C_FORMER_V21); } }
        public IGroup LSI_IEF_SUPPLIED_V21_ET { get { return GetElementByName<IGroup>(Names.LSI_IEF_SUPPLIED_V21_ET); } }
        public IField LSI_FMR_L2C_CNT_21MS { get { return GetElementByName<IField>(Names.LSI_FMR_L2C_CNT_21MS); } }
        public IField LSI_FMR_L2C_CNT_21 { get { return GetElementByName<IField>(Names.LSI_FMR_L2C_CNT_21); } }
        public IField LSI_FMR_L2C_CNT_21XX { get { return GetElementByName<IField>(Names.LSI_FMR_L2C_CNT_21XX); } }
        public IGroup LSI_2C_NEVER_V22 { get { return GetElementByName<IGroup>(Names.LSI_2C_NEVER_V22); } }
        public IGroup LSI_IEF_SUPPLIED_V22_ET { get { return GetElementByName<IGroup>(Names.LSI_IEF_SUPPLIED_V22_ET); } }
        public IField LSI_NVR_L2C_CNT_22MS { get { return GetElementByName<IField>(Names.LSI_NVR_L2C_CNT_22MS); } }
        public IField LSI_NVR_L2C_CNT_22 { get { return GetElementByName<IField>(Names.LSI_NVR_L2C_CNT_22); } }
        public IField LSI_NVR_L2C_CNT_22XX { get { return GetElementByName<IField>(Names.LSI_NVR_L2C_CNT_22XX); } }
        public IGroup LSI_2D_NEVER_V23 { get { return GetElementByName<IGroup>(Names.LSI_2D_NEVER_V23); } }
        public IGroup LSI_IEF_SUPPLIED_V23_ET { get { return GetElementByName<IGroup>(Names.LSI_IEF_SUPPLIED_V23_ET); } }
        public IField LSI_NVR_L2D_CNT_23MS { get { return GetElementByName<IField>(Names.LSI_NVR_L2D_CNT_23MS); } }
        public IField LSI_NVR_L2D_CNT_23 { get { return GetElementByName<IField>(Names.LSI_NVR_L2D_CNT_23); } }
        public IField LSI_NVR_L2D_CNT_23XX { get { return GetElementByName<IField>(Names.LSI_NVR_L2D_CNT_23XX); } }
        public IGroup LSI_3_CURRENT_V24 { get { return GetElementByName<IGroup>(Names.LSI_3_CURRENT_V24); } }
        public IGroup LSI_IEF_SUPPLIED_V24_ET { get { return GetElementByName<IGroup>(Names.LSI_IEF_SUPPLIED_V24_ET); } }
        public IField LSI_CUR_L3_CNT_24MS { get { return GetElementByName<IField>(Names.LSI_CUR_L3_CNT_24MS); } }
        public IField LSI_CUR_L3_CNT_24 { get { return GetElementByName<IField>(Names.LSI_CUR_L3_CNT_24); } }
        public IField LSI_CUR_L3_CNT_24XX { get { return GetElementByName<IField>(Names.LSI_CUR_L3_CNT_24XX); } }
        public IGroup LSI_3_FORMER_V25 { get { return GetElementByName<IGroup>(Names.LSI_3_FORMER_V25); } }
        public IGroup LSI_IEF_SUPPLIED_V25_ET { get { return GetElementByName<IGroup>(Names.LSI_IEF_SUPPLIED_V25_ET); } }
        public IField LSI_FMR_L3_CNT_25MS { get { return GetElementByName<IField>(Names.LSI_FMR_L3_CNT_25MS); } }
        public IField LSI_FMR_L3_CNT_25 { get { return GetElementByName<IField>(Names.LSI_FMR_L3_CNT_25); } }
        public IField LSI_FMR_L3_CNT_25XX { get { return GetElementByName<IField>(Names.LSI_FMR_L3_CNT_25XX); } }
        public IGroup LSI_3_NEVER_V26 { get { return GetElementByName<IGroup>(Names.LSI_3_NEVER_V26); } }
        public IGroup LSI_IEF_SUPPLIED_V26_ET { get { return GetElementByName<IGroup>(Names.LSI_IEF_SUPPLIED_V26_ET); } }
        public IField LSI_NVR_L3_CNT_26MS { get { return GetElementByName<IField>(Names.LSI_NVR_L3_CNT_26MS); } }
        public IField LSI_NVR_L3_CNT_26 { get { return GetElementByName<IField>(Names.LSI_NVR_L3_CNT_26); } }
        public IField LSI_NVR_L3_CNT_26XX { get { return GetElementByName<IField>(Names.LSI_NVR_L3_CNT_26XX); } }
        public IGroup LSI_4_TOTAL_V27 { get { return GetElementByName<IGroup>(Names.LSI_4_TOTAL_V27); } }
        public IGroup LSI_IEF_SUPPLIED_V27_ET { get { return GetElementByName<IGroup>(Names.LSI_IEF_SUPPLIED_V27_ET); } }
        public IField LSI_TOT_L4_TOT_L4_CNT_27MS { get { return GetElementByName<IField>(Names.LSI_TOT_L4_TOT_L4_CNT_27MS); } }
        public IField LSI_TOT_L4_CNT_27 { get { return GetElementByName<IField>(Names.LSI_TOT_L4_CNT_27); } }
        public IField LSI_TOT_L4_CNT_27XX { get { return GetElementByName<IField>(Names.LSI_TOT_L4_CNT_27XX); } }
        public IGroup LSI_5_TOTAL_V28 { get { return GetElementByName<IGroup>(Names.LSI_5_TOTAL_V28); } }
        public IGroup LSI_IEF_SUPPLIED_V28_ET { get { return GetElementByName<IGroup>(Names.LSI_IEF_SUPPLIED_V28_ET); } }
        public IField LSI_TOT_L5_CNT_28MS { get { return GetElementByName<IField>(Names.LSI_TOT_L5_CNT_28MS); } }
        public IField LSI_TOT_L5_CNT_28 { get { return GetElementByName<IField>(Names.LSI_TOT_L5_CNT_28); } }
        public IField LSI_TOT_L5_CNT_28XX { get { return GetElementByName<IField>(Names.LSI_TOT_L5_CNT_28XX); } }
        public IGroup LSI_6_TOTAL_V29 { get { return GetElementByName<IGroup>(Names.LSI_6_TOTAL_V29); } }
        public IGroup LSI_IEF_SUPPLIED_V29_ET { get { return GetElementByName<IGroup>(Names.LSI_IEF_SUPPLIED_V29_ET); } }
        public IField LSI_TOT_L6_CNT_29MS { get { return GetElementByName<IField>(Names.LSI_TOT_L6_CNT_29MS); } }
        public IField LSI_TOT_L6_CNT_29 { get { return GetElementByName<IField>(Names.LSI_TOT_L6_CNT_29); } }
        public IField LSI_TOT_L6_CNT_29XX { get { return GetElementByName<IField>(Names.LSI_TOT_L6_CNT_29XX); } }
        public IGroup LSI_7_TOTAL_V30 { get { return GetElementByName<IGroup>(Names.LSI_7_TOTAL_V30); } }
        public IGroup LSI_IEF_SUPPLIED_V30_ET { get { return GetElementByName<IGroup>(Names.LSI_IEF_SUPPLIED_V30_ET); } }
        public IField LSI_TOT_L7_CNT_30MS { get { return GetElementByName<IField>(Names.LSI_TOT_L7_CNT_30MS); } }
        public IField LSI_TOT_L7_CNT_30 { get { return GetElementByName<IField>(Names.LSI_TOT_L7_CNT_30); } }
        public IField LSI_TOT_L7_CNT_30XX { get { return GetElementByName<IField>(Names.LSI_TOT_L7_CNT_30XX); } }
        public IGroup LSI_8_TOTAL_V31 { get { return GetElementByName<IGroup>(Names.LSI_8_TOTAL_V31); } }
        public IGroup LSI_IEF_SUPPLIED_V31_ET { get { return GetElementByName<IGroup>(Names.LSI_IEF_SUPPLIED_V31_ET); } }
        public IField LSI_TOT_L8_CNT_31MS { get { return GetElementByName<IField>(Names.LSI_TOT_L8_CNT_31MS); } }
        public IField LSI_TOT_L8_CNT_31 { get { return GetElementByName<IField>(Names.LSI_TOT_L8_CNT_31); } }
        public IField LSI_TOT_L8_CNT_31XX { get { return GetElementByName<IField>(Names.LSI_TOT_L8_CNT_31XX); } }
        public IGroup LSI_9_TOTAL_V32 { get { return GetElementByName<IGroup>(Names.LSI_9_TOTAL_V32); } }
        public IGroup LSI_IEF_SUPPLIED_V32_ET { get { return GetElementByName<IGroup>(Names.LSI_IEF_SUPPLIED_V32_ET); } }
        public IField LSI_TOT_L9_CNT_32MS { get { return GetElementByName<IField>(Names.LSI_TOT_L9_CNT_32MS); } }
        public IField LSI_TOT_L9_CNT_32 { get { return GetElementByName<IField>(Names.LSI_TOT_L9_CNT_32); } }
        public IField LSI_TOT_L9_CNT_32XX { get { return GetElementByName<IField>(Names.LSI_TOT_L9_CNT_32XX); } }
        public IGroup LSI_10_TOTAL_V33 { get { return GetElementByName<IGroup>(Names.LSI_10_TOTAL_V33); } }
        public IGroup LSI_IEF_SUPPLIED_V33_ET { get { return GetElementByName<IGroup>(Names.LSI_IEF_SUPPLIED_V33_ET); } }
        public IField LSI_TOT_L10_CNT_33MS { get { return GetElementByName<IField>(Names.LSI_TOT_L10_CNT_33MS); } }
        public IField LSI_TOT_L10_CNT_33 { get { return GetElementByName<IField>(Names.LSI_TOT_L10_CNT_33); } }
        public IField LSI_TOT_L10_CNT_33XX { get { return GetElementByName<IField>(Names.LSI_TOT_L10_CNT_33XX); } }
        public IGroup LSI_12_CURRENT_V34 { get { return GetElementByName<IGroup>(Names.LSI_12_CURRENT_V34); } }
        public IGroup LSI_IEF_SUPPLIED_V34_ET { get { return GetElementByName<IGroup>(Names.LSI_IEF_SUPPLIED_V34_ET); } }
        public IField LSI_CUR_L12_CNT_34MS { get { return GetElementByName<IField>(Names.LSI_CUR_L12_CNT_34MS); } }
        public IField LSI_CUR_L12_CNT_34 { get { return GetElementByName<IField>(Names.LSI_CUR_L12_CNT_34); } }
        public IField LSI_CUR_L12_CNT_34XX { get { return GetElementByName<IField>(Names.LSI_CUR_L12_CNT_34XX); } }
        public IGroup LSI_12_FORMER_V35 { get { return GetElementByName<IGroup>(Names.LSI_12_FORMER_V35); } }
        public IGroup LSI_IEF_SUPPLIED_V35_ET { get { return GetElementByName<IGroup>(Names.LSI_IEF_SUPPLIED_V35_ET); } }
        public IField LSI_FMR_L12_CNT_35MS { get { return GetElementByName<IField>(Names.LSI_FMR_L12_CNT_35MS); } }
        public IField LSI_FMR_L12_CNT_35 { get { return GetElementByName<IField>(Names.LSI_FMR_L12_CNT_35); } }
        public IField LSI_FMR_L12_CNT_35XX { get { return GetElementByName<IField>(Names.LSI_FMR_L12_CNT_35XX); } }
        public IGroup LSI_12_NEVER_V36 { get { return GetElementByName<IGroup>(Names.LSI_12_NEVER_V36); } }
        public IGroup LSI_IEF_SUPPLIED_V36_ET { get { return GetElementByName<IGroup>(Names.LSI_IEF_SUPPLIED_V36_ET); } }
        public IField LSI_NVR_L12_CNT_36MS { get { return GetElementByName<IField>(Names.LSI_NVR_L12_CNT_36MS); } }
        public IField LSI_NVR_L12_CNT_36 { get { return GetElementByName<IField>(Names.LSI_NVR_L12_CNT_36); } }
        public IField LSI_NVR_L12_CNT_36XX { get { return GetElementByName<IField>(Names.LSI_NVR_L12_CNT_36XX); } }
        public IGroup LSI_13_CURRENT_V37 { get { return GetElementByName<IGroup>(Names.LSI_13_CURRENT_V37); } }
        public IGroup LSI_IEF_SUPPLIED_V37_ET { get { return GetElementByName<IGroup>(Names.LSI_IEF_SUPPLIED_V37_ET); } }
        public IField LSI_CUR_L13_CNT_37MS { get { return GetElementByName<IField>(Names.LSI_CUR_L13_CNT_37MS); } }
        public IField LSI_CUR_L13_CNT_37 { get { return GetElementByName<IField>(Names.LSI_CUR_L13_CNT_37); } }
        public IField LSI_CUR_L13_CNT_37XX { get { return GetElementByName<IField>(Names.LSI_CUR_L13_CNT_37XX); } }
        public IGroup LSI_13_FORMER_V38 { get { return GetElementByName<IGroup>(Names.LSI_13_FORMER_V38); } }
        public IGroup LSI_IEF_SUPPLIED_V38_ET { get { return GetElementByName<IGroup>(Names.LSI_IEF_SUPPLIED_V38_ET); } }
        public IField LSI_FMR_L13_CNT_38MS { get { return GetElementByName<IField>(Names.LSI_FMR_L13_CNT_38MS); } }
        public IField LSI_FMR_L13_CNT_38 { get { return GetElementByName<IField>(Names.LSI_FMR_L13_CNT_38); } }
        public IField LSI_FMR_L13_CNT_38XX { get { return GetElementByName<IField>(Names.LSI_FMR_L13_CNT_38XX); } }
        public IGroup LSI_13_NEVER_V39 { get { return GetElementByName<IGroup>(Names.LSI_13_NEVER_V39); } }
        public IGroup LSI_IEF_SUPPLIED_V39_ET { get { return GetElementByName<IGroup>(Names.LSI_IEF_SUPPLIED_V39_ET); } }
        public IField LSI_NVR_L13_CNT_39MS { get { return GetElementByName<IField>(Names.LSI_NVR_L13_CNT_39MS); } }
        public IField LSI_NVR_L13_CNT_39 { get { return GetElementByName<IField>(Names.LSI_NVR_L13_CNT_39); } }
        public IField LSI_NVR_L13_CNT_39XX { get { return GetElementByName<IField>(Names.LSI_NVR_L13_CNT_39XX); } }
        public IGroup LSI_14_TOTAL_V40 { get { return GetElementByName<IGroup>(Names.LSI_14_TOTAL_V40); } }
        public IGroup LSI_IEF_SUPPLIED_V40_ET { get { return GetElementByName<IGroup>(Names.LSI_IEF_SUPPLIED_V40_ET); } }
        public IField LSI_TOT_L14_CNT_40MS { get { return GetElementByName<IField>(Names.LSI_TOT_L14_CNT_40MS); } }
        public IField LSI_TOT_L14_CNT_40 { get { return GetElementByName<IField>(Names.LSI_TOT_L14_CNT_40); } }
        public IField LSI_TOT_L14_CNT_40XX { get { return GetElementByName<IField>(Names.LSI_TOT_L14_CNT_40XX); } }
        public IGroup LSI_16_CURRENT_V41 { get { return GetElementByName<IGroup>(Names.LSI_16_CURRENT_V41); } }
        public IGroup LSI_IEF_SUPPLIED_V41_ET { get { return GetElementByName<IGroup>(Names.LSI_IEF_SUPPLIED_V41_ET); } }
        public IField LSI_CUR_L16_CNT_41MS { get { return GetElementByName<IField>(Names.LSI_CUR_L16_CNT_41MS); } }
        public IField LSI_CUR_L16_CNT_41 { get { return GetElementByName<IField>(Names.LSI_CUR_L16_CNT_41); } }
        public IField LSI_CUR_L16_CNT_41XX { get { return GetElementByName<IField>(Names.LSI_CUR_L16_CNT_41XX); } }
        public IGroup LSI_16_FORMER_V42 { get { return GetElementByName<IGroup>(Names.LSI_16_FORMER_V42); } }
        public IGroup LSI_IEF_SUPPLIED_V42_ET { get { return GetElementByName<IGroup>(Names.LSI_IEF_SUPPLIED_V42_ET); } }
        public IField LSI_FMR_L16_CNT_42MS { get { return GetElementByName<IField>(Names.LSI_FMR_L16_CNT_42MS); } }
        public IField LSI_FMR_L16_CNT_42 { get { return GetElementByName<IField>(Names.LSI_FMR_L16_CNT_42); } }
        public IField LSI_FMR_L16_CNT_42XX { get { return GetElementByName<IField>(Names.LSI_FMR_L16_CNT_42XX); } }
        public IGroup LSI_16_NEVER_V43 { get { return GetElementByName<IGroup>(Names.LSI_16_NEVER_V43); } }
        public IGroup LSI_IEF_SUPPLIED_V43_ET { get { return GetElementByName<IGroup>(Names.LSI_IEF_SUPPLIED_V43_ET); } }
        public IField LSI_NVR_L16_CNT_43MS { get { return GetElementByName<IField>(Names.LSI_NVR_L16_CNT_43MS); } }
        public IField LSI_NVR_L16_CNT_43 { get { return GetElementByName<IField>(Names.LSI_NVR_L16_CNT_43); } }
        public IField LSI_NVR_L16_CNT_43XX { get { return GetElementByName<IField>(Names.LSI_NVR_L16_CNT_43XX); } }
        public IGroup LSI_17_CURRENT_V44 { get { return GetElementByName<IGroup>(Names.LSI_17_CURRENT_V44); } }
        public IGroup LSI_IEF_SUPPLIED_V44_ET { get { return GetElementByName<IGroup>(Names.LSI_IEF_SUPPLIED_V44_ET); } }
        public IField LSI_CUR_L17_CNT_44MS { get { return GetElementByName<IField>(Names.LSI_CUR_L17_CNT_44MS); } }
        public IField LSI_CUR_L17_CNT_44 { get { return GetElementByName<IField>(Names.LSI_CUR_L17_CNT_44); } }
        public IField LSI_CUR_L17_CNT_44XX { get { return GetElementByName<IField>(Names.LSI_CUR_L17_CNT_44XX); } }
        public IGroup LSI_17_FORMER_V45 { get { return GetElementByName<IGroup>(Names.LSI_17_FORMER_V45); } }
        public IGroup LSI_IEF_SUPPLIED_V45_ET { get { return GetElementByName<IGroup>(Names.LSI_IEF_SUPPLIED_V45_ET); } }
        public IField LSI_FMR_L17_CNT_45MS { get { return GetElementByName<IField>(Names.LSI_FMR_L17_CNT_45MS); } }
        public IField LSI_FMR_L17_CNT_45 { get { return GetElementByName<IField>(Names.LSI_FMR_L17_CNT_45); } }
        public IField LSI_FMR_L17_CNT_45XX { get { return GetElementByName<IField>(Names.LSI_FMR_L17_CNT_45XX); } }
        public IGroup LSI_17_NEVER_V46 { get { return GetElementByName<IGroup>(Names.LSI_17_NEVER_V46); } }
        public IGroup LSI_IEF_SUPPLIED_V46_ET { get { return GetElementByName<IGroup>(Names.LSI_IEF_SUPPLIED_V46_ET); } }
        public IField LSI_NVR_L17_CNT_46MS { get { return GetElementByName<IField>(Names.LSI_NVR_L17_CNT_46MS); } }
        public IField LSI_NVR_L17_CNT_46 { get { return GetElementByName<IField>(Names.LSI_NVR_L17_CNT_46); } }
        public IField LSI_NVR_L17_CNT_46XX { get { return GetElementByName<IField>(Names.LSI_NVR_L17_CNT_46XX); } }
        public IGroup LSI_18_CURRENT_V47 { get { return GetElementByName<IGroup>(Names.LSI_18_CURRENT_V47); } }
        public IGroup LSI_IEF_SUPPLIED_V47_ET { get { return GetElementByName<IGroup>(Names.LSI_IEF_SUPPLIED_V47_ET); } }
        public IField LSI_CUR_L18_CNT_47MS { get { return GetElementByName<IField>(Names.LSI_CUR_L18_CNT_47MS); } }
        public IField LSI_CUR_L18_CNT_47 { get { return GetElementByName<IField>(Names.LSI_CUR_L18_CNT_47); } }
        public IField LSI_CUR_L18_CNT_47XX { get { return GetElementByName<IField>(Names.LSI_CUR_L18_CNT_47XX); } }
        public IGroup LSI_18_FORMER_V48 { get { return GetElementByName<IGroup>(Names.LSI_18_FORMER_V48); } }
        public IGroup LSI_IEF_SUPPLIED_V48_ET { get { return GetElementByName<IGroup>(Names.LSI_IEF_SUPPLIED_V48_ET); } }
        public IField LSI_FMR_L18_CNT_48MS { get { return GetElementByName<IField>(Names.LSI_FMR_L18_CNT_48MS); } }
        public IField LSI_FMR_L18_CNT_48 { get { return GetElementByName<IField>(Names.LSI_FMR_L18_CNT_48); } }
        public IField LSI_FMR_L18_CNT_48XX { get { return GetElementByName<IField>(Names.LSI_FMR_L18_CNT_48XX); } }
        public IGroup LSI_18_NEVER_V49 { get { return GetElementByName<IGroup>(Names.LSI_18_NEVER_V49); } }
        public IGroup LSI_IEF_SUPPLIED_V49_ET { get { return GetElementByName<IGroup>(Names.LSI_IEF_SUPPLIED_V49_ET); } }
        public IField LSI_NVR_L18_CNT_49MS { get { return GetElementByName<IField>(Names.LSI_NVR_L18_CNT_49MS); } }
        public IField LSI_NVR_L18_CNT_49 { get { return GetElementByName<IField>(Names.LSI_NVR_L18_CNT_49); } }
        public IField LSI_NVR_L18_CNT_49XX { get { return GetElementByName<IField>(Names.LSI_NVR_L18_CNT_49XX); } }
        public IGroup LSI_18A_CURRENT_V50 { get { return GetElementByName<IGroup>(Names.LSI_18A_CURRENT_V50); } }
        public IGroup LSI_IEF_SUPPLIED_V50_ET { get { return GetElementByName<IGroup>(Names.LSI_IEF_SUPPLIED_V50_ET); } }
        public IField LSI_CUR_L18A_CNT_50MS { get { return GetElementByName<IField>(Names.LSI_CUR_L18A_CNT_50MS); } }
        public IField LSI_CUR_L18A_CNT_50 { get { return GetElementByName<IField>(Names.LSI_CUR_L18A_CNT_50); } }
        public IField LSI_CUR_L18A_CNT_50XX { get { return GetElementByName<IField>(Names.LSI_CUR_L18A_CNT_50XX); } }
        public IGroup LSI_18A_FORMER_V51 { get { return GetElementByName<IGroup>(Names.LSI_18A_FORMER_V51); } }
        public IGroup LSI_IEF_SUPPLIED_V51_ET { get { return GetElementByName<IGroup>(Names.LSI_IEF_SUPPLIED_V51_ET); } }
        public IField LSI_FMR_L18A_CNT_51MS { get { return GetElementByName<IField>(Names.LSI_FMR_L18A_CNT_51MS); } }
        public IField LSI_FMR_L18A_CNT_51 { get { return GetElementByName<IField>(Names.LSI_FMR_L18A_CNT_51); } }
        public IField LSI_FMR_L18A_CNT_51XX { get { return GetElementByName<IField>(Names.LSI_FMR_L18A_CNT_51XX); } }
        public IGroup LSI_18A_NEVER_V52 { get { return GetElementByName<IGroup>(Names.LSI_18A_NEVER_V52); } }
        public IGroup LSI_IEF_SUPPLIED_V52_ET { get { return GetElementByName<IGroup>(Names.LSI_IEF_SUPPLIED_V52_ET); } }
        public IField LSI_NVR_L18A_CNT_52MS { get { return GetElementByName<IField>(Names.LSI_NVR_L18A_CNT_52MS); } }
        public IField LSI_NVR_L18A_CNT_52 { get { return GetElementByName<IField>(Names.LSI_NVR_L18A_CNT_52); } }
        public IField LSI_NVR_L18A_CNT_52XX { get { return GetElementByName<IField>(Names.LSI_NVR_L18A_CNT_52XX); } }
        public IGroup LSI_19_CURRENT_V53 { get { return GetElementByName<IGroup>(Names.LSI_19_CURRENT_V53); } }
        public IGroup LSI_IEF_SUPPLIED_V53_ET { get { return GetElementByName<IGroup>(Names.LSI_IEF_SUPPLIED_V53_ET); } }
        public IField LSI_CUR_L19_CNT_53MS { get { return GetElementByName<IField>(Names.LSI_CUR_L19_CNT_53MS); } }
        public IField LSI_CUR_L19_CNT_53 { get { return GetElementByName<IField>(Names.LSI_CUR_L19_CNT_53); } }
        public IField LSI_CUR_L19_CNT_53XX { get { return GetElementByName<IField>(Names.LSI_CUR_L19_CNT_53XX); } }
        public IGroup LSI_19_FORMER_V54 { get { return GetElementByName<IGroup>(Names.LSI_19_FORMER_V54); } }
        public IGroup LSI_IEF_SUPPLIED_V54_ET { get { return GetElementByName<IGroup>(Names.LSI_IEF_SUPPLIED_V54_ET); } }
        public IField LSI_FMR_L19_CNT_54MS { get { return GetElementByName<IField>(Names.LSI_FMR_L19_CNT_54MS); } }
        public IField LSI_FMR_L19_CNT_54 { get { return GetElementByName<IField>(Names.LSI_FMR_L19_CNT_54); } }
        public IField LSI_FMR_L19_CNT_54XX { get { return GetElementByName<IField>(Names.LSI_FMR_L19_CNT_54XX); } }
        public IGroup LSI_19_NEVER_V55 { get { return GetElementByName<IGroup>(Names.LSI_19_NEVER_V55); } }
        public IGroup LSI_IEF_SUPPLIED_V55_ET { get { return GetElementByName<IGroup>(Names.LSI_IEF_SUPPLIED_V55_ET); } }
        public IField LSI_NVR_L19_CNT_55MS { get { return GetElementByName<IField>(Names.LSI_NVR_L19_CNT_55MS); } }
        public IField LSI_NVR_L19_CNT_55 { get { return GetElementByName<IField>(Names.LSI_NVR_L19_CNT_55); } }
        public IField LSI_NVR_L19_CNT_55XX { get { return GetElementByName<IField>(Names.LSI_NVR_L19_CNT_55XX); } }
        public IGroup LSI_20_CURRENT_V56 { get { return GetElementByName<IGroup>(Names.LSI_20_CURRENT_V56); } }
        public IGroup LSI_IEF_SUPPLIED_V56_ET { get { return GetElementByName<IGroup>(Names.LSI_IEF_SUPPLIED_V56_ET); } }
        public IField LSI_CUR_L20_CNT_56MS { get { return GetElementByName<IField>(Names.LSI_CUR_L20_CNT_56MS); } }
        public IField LSI_CUR_L20_CNT_56 { get { return GetElementByName<IField>(Names.LSI_CUR_L20_CNT_56); } }
        public IField LSI_CUR_L20_CNT_56XX { get { return GetElementByName<IField>(Names.LSI_CUR_L20_CNT_56XX); } }
        public IGroup LSI_20_FORMER_V57 { get { return GetElementByName<IGroup>(Names.LSI_20_FORMER_V57); } }
        public IGroup LSI_IEF_SUPPLIED_V57_ET { get { return GetElementByName<IGroup>(Names.LSI_IEF_SUPPLIED_V57_ET); } }
        public IField LSI_FMR_L20_CNT_57MS { get { return GetElementByName<IField>(Names.LSI_FMR_L20_CNT_57MS); } }
        public IField LSI_FMR_L20_CNT_57 { get { return GetElementByName<IField>(Names.LSI_FMR_L20_CNT_57); } }
        public IField LSI_FMR_L20_CNT_57XX { get { return GetElementByName<IField>(Names.LSI_FMR_L20_CNT_57XX); } }
        public IGroup LSI_20_NEVER_V58 { get { return GetElementByName<IGroup>(Names.LSI_20_NEVER_V58); } }
        public IGroup LSI_IEF_SUPPLIED_V58_ET { get { return GetElementByName<IGroup>(Names.LSI_IEF_SUPPLIED_V58_ET); } }
        public IField LSI_NVR_L20_CNT_58MS { get { return GetElementByName<IField>(Names.LSI_NVR_L20_CNT_58MS); } }
        public IField LSI_NVR_L20_CNT_58 { get { return GetElementByName<IField>(Names.LSI_NVR_L20_CNT_58); } }
        public IField LSI_NVR_L20_CNT_58XX { get { return GetElementByName<IField>(Names.LSI_NVR_L20_CNT_58XX); } }
        public IGroup LSI_21_TOTAL_V59 { get { return GetElementByName<IGroup>(Names.LSI_21_TOTAL_V59); } }
        public IGroup LSI_IEF_SUPPLIED_V59_ET { get { return GetElementByName<IGroup>(Names.LSI_IEF_SUPPLIED_V59_ET); } }
        public IField LSI_TOT_L21_CNT_59MS { get { return GetElementByName<IField>(Names.LSI_TOT_L21_CNT_59MS); } }
        public IField LSI_TOT_L21_CNT_59 { get { return GetElementByName<IField>(Names.LSI_TOT_L21_CNT_59); } }
        public IField LSI_TOT_L21_CNT_59XX { get { return GetElementByName<IField>(Names.LSI_TOT_L21_CNT_59XX); } }
        public IGroup LSI_22_TOTAL_V60 { get { return GetElementByName<IGroup>(Names.LSI_22_TOTAL_V60); } }
        public IGroup LSI_IEF_SUPPLIED_V60_ET { get { return GetElementByName<IGroup>(Names.LSI_IEF_SUPPLIED_V60_ET); } }
        public IField LSI_TOT_L22_CNT_60MS { get { return GetElementByName<IField>(Names.LSI_TOT_L22_CNT_60MS); } }
        public IField LSI_TOT_L22_CNT_60 { get { return GetElementByName<IField>(Names.LSI_TOT_L22_CNT_60); } }
        public IField LSI_TOT_L22_CNT_60XX { get { return GetElementByName<IField>(Names.LSI_TOT_L22_CNT_60XX); } }
        public IGroup LSI_23_TOTAL_V61 { get { return GetElementByName<IGroup>(Names.LSI_23_TOTAL_V61); } }
        public IGroup LSI_IEF_SUPPLIED_V61_ET { get { return GetElementByName<IGroup>(Names.LSI_IEF_SUPPLIED_V61_ET); } }
        public IField LSI_TOT_L23_CNT_61MS { get { return GetElementByName<IField>(Names.LSI_TOT_L23_CNT_61MS); } }
        public IField LSI_TOT_L23_CNT_61 { get { return GetElementByName<IField>(Names.LSI_TOT_L23_CNT_61); } }
        public IField LSI_TOT_L23_CNT_61XX { get { return GetElementByName<IField>(Names.LSI_TOT_L23_CNT_61XX); } }
        public IGroup LSI_24_CURRENT_V62 { get { return GetElementByName<IGroup>(Names.LSI_24_CURRENT_V62); } }
        public IGroup LSI_IEF_SUPPLIED_V62_ET { get { return GetElementByName<IGroup>(Names.LSI_IEF_SUPPLIED_V62_ET); } }
        public IField LSI_CUR_L24_CNT_62MS { get { return GetElementByName<IField>(Names.LSI_CUR_L24_CNT_62MS); } }
        public IField LSI_CUR_L24_CNT_62 { get { return GetElementByName<IField>(Names.LSI_CUR_L24_CNT_62); } }
        public IField LSI_CUR_L24_CNT_62XX { get { return GetElementByName<IField>(Names.LSI_CUR_L24_CNT_62XX); } }
        public IGroup LSI_24_FORMER_V63 { get { return GetElementByName<IGroup>(Names.LSI_24_FORMER_V63); } }
        public IGroup LSI_IEF_SUPPLIED_V63_ET { get { return GetElementByName<IGroup>(Names.LSI_IEF_SUPPLIED_V63_ET); } }
        public IField LSI_FMR_L24_CNT_63MS { get { return GetElementByName<IField>(Names.LSI_FMR_L24_CNT_63MS); } }
        public IField LSI_FMR_L24_CNT_63 { get { return GetElementByName<IField>(Names.LSI_FMR_L24_CNT_63); } }
        public IField LSI_FMR_L24_CNT_63XX { get { return GetElementByName<IField>(Names.LSI_FMR_L24_CNT_63XX); } }
        public IGroup LSI_24_NEVER_V64 { get { return GetElementByName<IGroup>(Names.LSI_24_NEVER_V64); } }
        public IGroup LSI_IEF_SUPPLIED_V64_ET { get { return GetElementByName<IGroup>(Names.LSI_IEF_SUPPLIED_V64_ET); } }
        public IField LSI_NVR_L24_CNT_64MS { get { return GetElementByName<IField>(Names.LSI_NVR_L24_CNT_64MS); } }
        public IField LSI_NVR_L24_CNT_64 { get { return GetElementByName<IField>(Names.LSI_NVR_L24_CNT_64); } }
        public IField LSI_NVR_L24_CNT_64XX { get { return GetElementByName<IField>(Names.LSI_NVR_L24_CNT_64XX); } }
        public IGroup LSI_25_CURRENT_V65 { get { return GetElementByName<IGroup>(Names.LSI_25_CURRENT_V65); } }
        public IGroup LSI_IEF_SUPPLIED_V65_ET { get { return GetElementByName<IGroup>(Names.LSI_IEF_SUPPLIED_V65_ET); } }
        public IField LSI_CUR_L25_CNT_65MS { get { return GetElementByName<IField>(Names.LSI_CUR_L25_CNT_65MS); } }
        public IField LSI_CUR_L25_CNT_65 { get { return GetElementByName<IField>(Names.LSI_CUR_L25_CNT_65); } }
        public IField LSI_CUR_L25_CNT_65XX { get { return GetElementByName<IField>(Names.LSI_CUR_L25_CNT_65XX); } }
        public IGroup LSI_25_FORMER_V66 { get { return GetElementByName<IGroup>(Names.LSI_25_FORMER_V66); } }
        public IGroup LSI_IEF_SUPPLIED_V66_ET { get { return GetElementByName<IGroup>(Names.LSI_IEF_SUPPLIED_V66_ET); } }
        public IField LSI_FMR_L25_CNT_66MS { get { return GetElementByName<IField>(Names.LSI_FMR_L25_CNT_66MS); } }
        public IField LSI_FMR_L25_CNT_66 { get { return GetElementByName<IField>(Names.LSI_FMR_L25_CNT_66); } }
        public IField LSI_FMR_L25_CNT_66XX { get { return GetElementByName<IField>(Names.LSI_FMR_L25_CNT_66XX); } }
        public IGroup LSI_25_NEVER_V67 { get { return GetElementByName<IGroup>(Names.LSI_25_NEVER_V67); } }
        public IGroup LSI_IEF_SUPPLIED_V67_ET { get { return GetElementByName<IGroup>(Names.LSI_IEF_SUPPLIED_V67_ET); } }
        public IField LSI_NVR_L25_CNT_67MS { get { return GetElementByName<IField>(Names.LSI_NVR_L25_CNT_67MS); } }
        public IField LSI_NVR_L25_CNT_67 { get { return GetElementByName<IField>(Names.LSI_NVR_L25_CNT_67); } }
        public IField LSI_NVR_L25_CNT_67XX { get { return GetElementByName<IField>(Names.LSI_NVR_L25_CNT_67XX); } }
        public IGroup LSI_26_CURRENT_V68 { get { return GetElementByName<IGroup>(Names.LSI_26_CURRENT_V68); } }
        public IGroup LSI_IEF_SUPPLIED_V68_ET { get { return GetElementByName<IGroup>(Names.LSI_IEF_SUPPLIED_V68_ET); } }
        public IField LSI_CUR_L26_CNT_68MS { get { return GetElementByName<IField>(Names.LSI_CUR_L26_CNT_68MS); } }
        public IField LSI_CUR_L26_CNT_68 { get { return GetElementByName<IField>(Names.LSI_CUR_L26_CNT_68); } }
        public IField LSI_CUR_L26_CNT_68XX { get { return GetElementByName<IField>(Names.LSI_CUR_L26_CNT_68XX); } }
        public IGroup LSI_26_FORMER_V69 { get { return GetElementByName<IGroup>(Names.LSI_26_FORMER_V69); } }
        public IGroup LSI_IEF_SUPPLIED_V69_ET { get { return GetElementByName<IGroup>(Names.LSI_IEF_SUPPLIED_V69_ET); } }
        public IField LSI_FMR_L26_CNT_69MS { get { return GetElementByName<IField>(Names.LSI_FMR_L26_CNT_69MS); } }
        public IField LSI_FMR_L26_CNT_69 { get { return GetElementByName<IField>(Names.LSI_FMR_L26_CNT_69); } }
        public IField LSI_FMR_L26_CNT_69XX { get { return GetElementByName<IField>(Names.LSI_FMR_L26_CNT_69XX); } }
        public IGroup LSI_26_NEVER_V70 { get { return GetElementByName<IGroup>(Names.LSI_26_NEVER_V70); } }
        public IGroup LSI_IEF_SUPPLIED_V70_ET { get { return GetElementByName<IGroup>(Names.LSI_IEF_SUPPLIED_V70_ET); } }
        public IField LSI_NVR_L26_CNT_70MS { get { return GetElementByName<IField>(Names.LSI_NVR_L26_CNT_70MS); } }
        public IField LSI_NVR_L26_CNT_70 { get { return GetElementByName<IField>(Names.LSI_NVR_L26_CNT_70); } }
        public IField LSI_NVR_L26_CNT_70XX { get { return GetElementByName<IField>(Names.LSI_NVR_L26_CNT_70XX); } }
        public IGroup LSI_27_CURRENT_V71 { get { return GetElementByName<IGroup>(Names.LSI_27_CURRENT_V71); } }
        public IGroup LSI_IEF_SUPPLIED_V71_ET { get { return GetElementByName<IGroup>(Names.LSI_IEF_SUPPLIED_V71_ET); } }
        public IField LSI_CUR_L27_CNT_71MS { get { return GetElementByName<IField>(Names.LSI_CUR_L27_CNT_71MS); } }
        public IField LSI_CUR_L27_CNT_71 { get { return GetElementByName<IField>(Names.LSI_CUR_L27_CNT_71); } }
        public IField LSI_CUR_L27_CNT_71XX { get { return GetElementByName<IField>(Names.LSI_CUR_L27_CNT_71XX); } }
        public IGroup LSI_27_FORMER_V72 { get { return GetElementByName<IGroup>(Names.LSI_27_FORMER_V72); } }
        public IGroup LSI_IEF_SUPPLIED_V72_ET { get { return GetElementByName<IGroup>(Names.LSI_IEF_SUPPLIED_V72_ET); } }
        public IField LSI_FMR_L27_CNT_72MS { get { return GetElementByName<IField>(Names.LSI_FMR_L27_CNT_72MS); } }
        public IField LSI_FMR_L27_CNT_72 { get { return GetElementByName<IField>(Names.LSI_FMR_L27_CNT_72); } }
        public IField LSI_FMR_L27_CNT_72XX { get { return GetElementByName<IField>(Names.LSI_FMR_L27_CNT_72XX); } }
        public IGroup LSI_27_NEVER_V73 { get { return GetElementByName<IGroup>(Names.LSI_27_NEVER_V73); } }
        public IGroup LSI_IEF_SUPPLIED_V73_ET { get { return GetElementByName<IGroup>(Names.LSI_IEF_SUPPLIED_V73_ET); } }
        public IField LSI_NVR_L27_CNT_73MS { get { return GetElementByName<IField>(Names.LSI_NVR_L27_CNT_73MS); } }
        public IField LSI_NVR_L27_CNT_73 { get { return GetElementByName<IField>(Names.LSI_NVR_L27_CNT_73); } }
        public IField LSI_NVR_L27_CNT_73XX { get { return GetElementByName<IField>(Names.LSI_NVR_L27_CNT_73XX); } }
        public IGroup LSI_28_TOTAL_V74 { get { return GetElementByName<IGroup>(Names.LSI_28_TOTAL_V74); } }
        public IGroup LSI_IEF_SUPPLIED_V74_ET { get { return GetElementByName<IGroup>(Names.LSI_IEF_SUPPLIED_V74_ET); } }
        public IField LSI_TOT_L28_CNT_74MS { get { return GetElementByName<IField>(Names.LSI_TOT_L28_CNT_74MS); } }
        public IField LSI_TOT_L28_CNT_74 { get { return GetElementByName<IField>(Names.LSI_TOT_L28_CNT_74); } }
        public IField LSI_TOT_L28_CNT_74XX { get { return GetElementByName<IField>(Names.LSI_TOT_L28_CNT_74XX); } }
        public IGroup LSI_29_TOTAL_V75 { get { return GetElementByName<IGroup>(Names.LSI_29_TOTAL_V75); } }
        public IGroup LSI_IEF_SUPPLIED_V75_ET { get { return GetElementByName<IGroup>(Names.LSI_IEF_SUPPLIED_V75_ET); } }
        public IField LSI_TOT_L29_CNT_75MS { get { return GetElementByName<IField>(Names.LSI_TOT_L29_CNT_75MS); } }
        public IField LSI_TOT_L29_CNT_75 { get { return GetElementByName<IField>(Names.LSI_TOT_L29_CNT_75); } }
        public IField LSI_TOT_L29_CNT_75XX { get { return GetElementByName<IField>(Names.LSI_TOT_L29_CNT_75XX); } }
        public IGroup LSI_30_TOTAL_V76 { get { return GetElementByName<IGroup>(Names.LSI_30_TOTAL_V76); } }
        public IGroup LSI_IEF_SUPPLIED_V76_ET { get { return GetElementByName<IGroup>(Names.LSI_IEF_SUPPLIED_V76_ET); } }
        public IField LSI_TOT_L30_CNT_76MS { get { return GetElementByName<IField>(Names.LSI_TOT_L30_CNT_76MS); } }
        public IField LSI_TOT_L30_CNT_76 { get { return GetElementByName<IField>(Names.LSI_TOT_L30_CNT_76); } }
        public IField LSI_TOT_L30_CNT_76XX { get { return GetElementByName<IField>(Names.LSI_TOT_L30_CNT_76XX); } }
        public IGroup LSI_31_TOTAL_V77 { get { return GetElementByName<IGroup>(Names.LSI_31_TOTAL_V77); } }
        public IGroup LSI_IEF_SUPPLIED_V77_ET { get { return GetElementByName<IGroup>(Names.LSI_IEF_SUPPLIED_V77_ET); } }
        public IField LSI_TOT_L31_CNT_77MS { get { return GetElementByName<IField>(Names.LSI_TOT_L31_CNT_77MS); } }
        public IField LSI_TOT_L31_CNT_77 { get { return GetElementByName<IField>(Names.LSI_TOT_L31_CNT_77); } }
        public IField LSI_TOT_L31_CNT_77XX { get { return GetElementByName<IField>(Names.LSI_TOT_L31_CNT_77XX); } }
        public IGroup LSI_32_TOTAL_V78 { get { return GetElementByName<IGroup>(Names.LSI_32_TOTAL_V78); } }
        public IGroup LSI_IEF_SUPPLIED_V78_ET { get { return GetElementByName<IGroup>(Names.LSI_IEF_SUPPLIED_V78_ET); } }
        public IField LSI_TOT_L32_CNT_78MS { get { return GetElementByName<IField>(Names.LSI_TOT_L32_CNT_78MS); } }
        public IField LSI_TOT_L32_CNT_78 { get { return GetElementByName<IField>(Names.LSI_TOT_L32_CNT_78); } }
        public IField LSI_TOT_L32_CNT_78XX { get { return GetElementByName<IField>(Names.LSI_TOT_L32_CNT_78XX); } }
        public IGroup LSI_38_CURRENT_V79 { get { return GetElementByName<IGroup>(Names.LSI_38_CURRENT_V79); } }
        public IGroup LSI_IEF_SUPPLIED_V79_ET { get { return GetElementByName<IGroup>(Names.LSI_IEF_SUPPLIED_V79_ET); } }
        public IField LSI_CUR_L38_CNT_79MS { get { return GetElementByName<IField>(Names.LSI_CUR_L38_CNT_79MS); } }
        public IField LSI_CUR_L38_CNT_79 { get { return GetElementByName<IField>(Names.LSI_CUR_L38_CNT_79); } }
        public IField LSI_CUR_L38_CNT_79XX { get { return GetElementByName<IField>(Names.LSI_CUR_L38_CNT_79XX); } }
        public IGroup LSI_39_CURRENT_V80 { get { return GetElementByName<IGroup>(Names.LSI_39_CURRENT_V80); } }
        public IGroup LSI_IEF_SUPPLIED_V80_ET { get { return GetElementByName<IGroup>(Names.LSI_IEF_SUPPLIED_V80_ET); } }
        public IField LSI_CUR_L39_CNT_80MS { get { return GetElementByName<IField>(Names.LSI_CUR_L39_CNT_80MS); } }
        public IField LSI_CUR_L39_CNT_80 { get { return GetElementByName<IField>(Names.LSI_CUR_L39_CNT_80); } }
        public IField LSI_CUR_L39_CNT_80XX { get { return GetElementByName<IField>(Names.LSI_CUR_L39_CNT_80XX); } }
        public IGroup LSI_40_TOTAL_V81 { get { return GetElementByName<IGroup>(Names.LSI_40_TOTAL_V81); } }
        public IGroup LSI_IEF_SUPPLIED_V81_ET { get { return GetElementByName<IGroup>(Names.LSI_IEF_SUPPLIED_V81_ET); } }
        public IField LSI_TOT_L40_CNT_81MS { get { return GetElementByName<IField>(Names.LSI_TOT_L40_CNT_81MS); } }
        public IField LSI_TOT_L40_CNT_81 { get { return GetElementByName<IField>(Names.LSI_TOT_L40_CNT_81); } }
        public IField LSI_TOT_L40_CNT_81XX { get { return GetElementByName<IField>(Names.LSI_TOT_L40_CNT_81XX); } }
        public IGroup LSI_41_TOTAL_V82 { get { return GetElementByName<IGroup>(Names.LSI_41_TOTAL_V82); } }
        public IGroup LSI_IEF_SUPPLIED_V82_ET { get { return GetElementByName<IGroup>(Names.LSI_IEF_SUPPLIED_V82_ET); } }
        public IField LSI_TOT_L41_CNT_82MS { get { return GetElementByName<IField>(Names.LSI_TOT_L41_CNT_82MS); } }
        public IField LSI_TOT_L41_CNT_82 { get { return GetElementByName<IField>(Names.LSI_TOT_L41_CNT_82); } }
        public IField LSI_TOT_L41_CNT_82XX { get { return GetElementByName<IField>(Names.LSI_TOT_L41_CNT_82XX); } }
        public IGroup LSI_42_TOTAL_V83 { get { return GetElementByName<IGroup>(Names.LSI_42_TOTAL_V83); } }
        public IGroup LSI_IEF_SUPPLIED_V83_ET { get { return GetElementByName<IGroup>(Names.LSI_IEF_SUPPLIED_V83_ET); } }
        public IField LSI_TOT_L42_CNT_83MS { get { return GetElementByName<IField>(Names.LSI_TOT_L42_CNT_83MS); } }
        public IField LSI_TOT_L42_CNT_83 { get { return GetElementByName<IField>(Names.LSI_TOT_L42_CNT_83); } }
        public IField LSI_TOT_L42_CNT_83XX { get { return GetElementByName<IField>(Names.LSI_TOT_L42_CNT_83XX); } }
        public IGroup LSI_V84 { get { return GetElementByName<IGroup>(Names.LSI_V84); } }
        public IGroup LSI_REPORT_PARMS_V84_ET { get { return GetElementByName<IGroup>(Names.LSI_REPORT_PARMS_V84_ET); } }
        public IField LSI_PARM1_84MS { get { return GetElementByName<IField>(Names.LSI_PARM1_84MS); } }
        public IField LSI_PARM1_84 { get { return GetElementByName<IField>(Names.LSI_PARM1_84); } }
        public IField LSI_PARM1_84XX { get { return GetElementByName<IField>(Names.LSI_PARM1_84XX); } }
        public IField IO_CONTROL_CD { get { return GetElementByName<IField>(Names.IO_CONTROL_CD); } }
        public IField LSI_PARM2_85MS { get { return GetElementByName<IField>(Names.LSI_PARM2_85MS); } }
        public IField LSI_PARM2_85 { get { return GetElementByName<IField>(Names.LSI_PARM2_85); } }
        public IField LSI_PARM2_85XX { get { return GetElementByName<IField>(Names.LSI_PARM2_85XX); } }
        public IGroup LS_RUNTIME_RPT_TYPE_CD { get { return GetElementByName<IGroup>(Names.LS_RUNTIME_RPT_TYPE_CD); } }
        public IField LSI_PARM2_1 { get { return GetElementByName<IField>(Names.LSI_PARM2_1); } }
        public IField LSI_PARM2_2 { get { return GetElementByName<IField>(Names.LSI_PARM2_2); } }
        public IField LSI_SUBRPT_CD_86MS { get { return GetElementByName<IField>(Names.LSI_SUBRPT_CD_86MS); } }
        public IField LSI_SUBRPT_CD_86 { get { return GetElementByName<IField>(Names.LSI_SUBRPT_CD_86); } }
        public IField LSI_SUBRPT_CD_86XX { get { return GetElementByName<IField>(Names.LSI_SUBRPT_CD_86XX); } }
        public IGroup LSE_V85 { get { return GetElementByName<IGroup>(Names.LSE_V85); } }
        public IGroup LSE_REPORT_PARMS_ET { get { return GetElementByName<IGroup>(Names.LSE_REPORT_PARMS_ET); } }
        public IField LSE_PARM1_87MS { get { return GetElementByName<IField>(Names.LSE_PARM1_87MS); } }
        public IField LSE_PARM1_87 { get { return GetElementByName<IField>(Names.LSE_PARM1_87); } }
        public IField LSE_PARM1_87XX { get { return GetElementByName<IField>(Names.LSE_PARM1_87XX); } }
        public IField LS_RETURN_CD { get { return GetElementByName<IField>(Names.LS_RETURN_CD); } }
        public IField LSE_PARM2_88MS { get { return GetElementByName<IField>(Names.LSE_PARM2_88MS); } }
        public IField LSE_PARM2_88 { get { return GetElementByName<IField>(Names.LSE_PARM2_88); } }
        public IField LSE_PARM2_88XX { get { return GetElementByName<IField>(Names.LSE_PARM2_88XX); } }
        public IField LSE_SUBRPT_CD_89MS { get { return GetElementByName<IField>(Names.LSE_SUBRPT_CD_89MS); } }
        public IField LSE_SUBRPT_CD_89 { get { return GetElementByName<IField>(Names.LSE_SUBRPT_CD_89); } }
        public IField LSE_SUBRPT_CD_89XX { get { return GetElementByName<IField>(Names.LSE_SUBRPT_CD_89XX); } }

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

            recordDef.CreateNewGroup(Names.LSI_1_CURRENT_V1, (LSI_1_CURRENT_V1) =>
           {
               LSI_1_CURRENT_V1.CreateNewGroup(Names.LSI_IEF_SUPPLIED_V1_ET, (LSI_IEF_SUPPLIED_V1_ET) =>
               {
                   LSI_IEF_SUPPLIED_V1_ET.CreateNewField(Names.LSI_CUR_L1_CNT_01MS, FieldType.String, 1);

                   IField LSI_CUR_L1_CNT_01_local = LSI_IEF_SUPPLIED_V1_ET.CreateNewField(Names.LSI_CUR_L1_CNT_01, FieldType.SignedNumeric, 9);
                   LSI_IEF_SUPPLIED_V1_ET.CreateNewFieldRedefine(Names.LSI_CUR_L1_CNT_01XX, FieldType.String, LSI_CUR_L1_CNT_01_local, 9);
               });
           });

            recordDef.CreateNewGroup(Names.LSI_1_FORMER_V2, (LSI_1_FORMER_V2) =>
           {
               LSI_1_FORMER_V2.CreateNewGroup(Names.LSI_IEF_SUPPLIED_V2_ET, (LSI_IEF_SUPPLIED_V2_ET) =>
               {
                   LSI_IEF_SUPPLIED_V2_ET.CreateNewField(Names.LSI_FMR_L1_CNT_02MS, FieldType.String, 1);

                   IField LSI_FMR_L1_CNT_02_local = LSI_IEF_SUPPLIED_V2_ET.CreateNewField(Names.LSI_FMR_L1_CNT_02, FieldType.SignedNumeric, 9);
                   LSI_IEF_SUPPLIED_V2_ET.CreateNewFieldRedefine(Names.LSI_FMR_L1_CNT_02XX, FieldType.String, LSI_FMR_L1_CNT_02_local, 9);
               });
           });

            recordDef.CreateNewGroup(Names.LSI_1_NEVER_V3, (LSI_1_NEVER_V3) =>
           {
               LSI_1_NEVER_V3.CreateNewGroup(Names.LSI_IEF_SUPPLIED_V3_ET, (LSI_IEF_SUPPLIED_V3_ET) =>
               {
                   LSI_IEF_SUPPLIED_V3_ET.CreateNewField(Names.LSI_NVR_L1_CNT_03MS, FieldType.String, 1);

                   IField LSI_NVR_L1_CNT_03_local = LSI_IEF_SUPPLIED_V3_ET.CreateNewField(Names.LSI_NVR_L1_CNT_03, FieldType.SignedNumeric, 9);
                   LSI_IEF_SUPPLIED_V3_ET.CreateNewFieldRedefine(Names.LSI_NVR_L1_CNT_03XX, FieldType.String, LSI_NVR_L1_CNT_03_local, 9);
               });
           });

            recordDef.CreateNewGroup(Names.LSI_1A_CURRENT_V4, (LSI_1A_CURRENT_V4) =>
           {
               LSI_1A_CURRENT_V4.CreateNewGroup(Names.LSI_IEF_SUPPLIED_V4_ET, (LSI_IEF_SUPPLIED_V4_ET) =>
               {
                   LSI_IEF_SUPPLIED_V4_ET.CreateNewField(Names.LSI_CUR_L1A_CNT_04MS, FieldType.String, 1);

                   IField LSI_CUR_L1A_CNT_04_local = LSI_IEF_SUPPLIED_V4_ET.CreateNewField(Names.LSI_CUR_L1A_CNT_04, FieldType.SignedNumeric, 9);
                   LSI_IEF_SUPPLIED_V4_ET.CreateNewFieldRedefine(Names.LSI_CUR_L1A_CNT_04XX, FieldType.String, LSI_CUR_L1A_CNT_04_local, 9);
               });
           });

            recordDef.CreateNewGroup(Names.LSI_1A_FORMER_V5, (LSI_1A_FORMER_V5) =>
           {
               LSI_1A_FORMER_V5.CreateNewGroup(Names.LSI_IEF_SUPPLIED_V5_ET, (LSI_IEF_SUPPLIED_V5_ET) =>
               {
                   LSI_IEF_SUPPLIED_V5_ET.CreateNewField(Names.LSI_FMR_L1A_CNT_05MS, FieldType.String, 1);

                   IField LSI_FMR_L1A_CNT_05_local = LSI_IEF_SUPPLIED_V5_ET.CreateNewField(Names.LSI_FMR_L1A_CNT_05, FieldType.SignedNumeric, 9);
                   LSI_IEF_SUPPLIED_V5_ET.CreateNewFieldRedefine(Names.LSI_FMR_L1A_CNT_05XX, FieldType.String, LSI_FMR_L1A_CNT_05_local, 9);
               });
           });

            recordDef.CreateNewGroup(Names.LSI_1A_NEVER_V6, (LSI_1A_NEVER_V6) =>
           {
               LSI_1A_NEVER_V6.CreateNewGroup(Names.LSI_IEF_SUPPLIED_V6_ET, (LSI_IEF_SUPPLIED_V6_ET) =>
               {
                   LSI_IEF_SUPPLIED_V6_ET.CreateNewField(Names.LSI_NVR_L1A_CNT_06MS, FieldType.String, 1);

                   IField LSI_NVR_L1A_CNT_06_local = LSI_IEF_SUPPLIED_V6_ET.CreateNewField(Names.LSI_NVR_L1A_CNT_06, FieldType.SignedNumeric, 9);
                   LSI_IEF_SUPPLIED_V6_ET.CreateNewFieldRedefine(Names.LSI_NVR_L1A_CNT_06XX, FieldType.String, LSI_NVR_L1A_CNT_06_local, 9);
               });
           });

            recordDef.CreateNewGroup(Names.LSI_1B_CURRENT_V7, (LSI_1B_CURRENT_V7) =>
           {
               LSI_1B_CURRENT_V7.CreateNewGroup(Names.LSI_IEF_SUPPLIED_V7_ET, (LSI_IEF_SUPPLIED_V7_ET) =>
               {
                   LSI_IEF_SUPPLIED_V7_ET.CreateNewField(Names.LSI_CUR_L1B_CNT_07MS, FieldType.String, 1);

                   IField LSI_CUR_L1B_CNT_07_local = LSI_IEF_SUPPLIED_V7_ET.CreateNewField(Names.LSI_CUR_L1B_CNT_07, FieldType.SignedNumeric, 9);
                   LSI_IEF_SUPPLIED_V7_ET.CreateNewFieldRedefine(Names.LSI_CUR_L1B_CNT_07XX, FieldType.String, LSI_CUR_L1B_CNT_07_local, 9);
               });
           });

            recordDef.CreateNewGroup(Names.LSI_1B_FORMER_V8, (LSI_1B_FORMER_V8) =>
           {
               LSI_1B_FORMER_V8.CreateNewGroup(Names.LSI_IEF_SUPPLIED_V8_ET, (LSI_IEF_SUPPLIED_V8_ET) =>
               {
                   LSI_IEF_SUPPLIED_V8_ET.CreateNewField(Names.LSI_FMR_L1B_CNT_08MS, FieldType.String, 1);

                   IField LSI_FMR_L1B_CNT_08_local = LSI_IEF_SUPPLIED_V8_ET.CreateNewField(Names.LSI_FMR_L1B_CNT_08, FieldType.SignedNumeric, 9);
                   LSI_IEF_SUPPLIED_V8_ET.CreateNewFieldRedefine(Names.LSI_FMR_L1B_CNT_08XX, FieldType.String, LSI_FMR_L1B_CNT_08_local, 9);
               });
           });

            recordDef.CreateNewGroup(Names.LSI_1B_NEVER_V9, (LSI_1B_NEVER_V9) =>
           {
               LSI_1B_NEVER_V9.CreateNewGroup(Names.LSI_IEF_SUPPLIED_V9_ET, (LSI_IEF_SUPPLIED_V9_ET) =>
               {
                   LSI_IEF_SUPPLIED_V9_ET.CreateNewField(Names.LSI_NVR_L1B_CNT_09MS, FieldType.String, 1);

                   IField LSI_NVR_L1B_CNT_09_local = LSI_IEF_SUPPLIED_V9_ET.CreateNewField(Names.LSI_NVR_L1B_CNT_09, FieldType.SignedNumeric, 9);
                   LSI_IEF_SUPPLIED_V9_ET.CreateNewFieldRedefine(Names.LSI_NVR_L1B_CNT_09XX, FieldType.String, LSI_NVR_L1B_CNT_09_local, 9);
               });
           });

            recordDef.CreateNewGroup(Names.LSI_1C_NEVER_V10, (LSI_1C_NEVER_V10) =>
           {
               LSI_1C_NEVER_V10.CreateNewGroup(Names.LSI_IEF_SUPPLIED_V10_ET, (LSI_IEF_SUPPLIED_V10_ET) =>
               {
                   LSI_IEF_SUPPLIED_V10_ET.CreateNewField(Names.LSI_NVR_L1C_CNT_10MS, FieldType.String, 1);

                   IField LSI_NVR_L1C_CNT_10_local = LSI_IEF_SUPPLIED_V10_ET.CreateNewField(Names.LSI_NVR_L1C_CNT_10, FieldType.SignedNumeric, 9);
                   LSI_IEF_SUPPLIED_V10_ET.CreateNewFieldRedefine(Names.LSI_NVR_L1C_CNT_10XX, FieldType.String, LSI_NVR_L1C_CNT_10_local, 9);
               });
           });

            recordDef.CreateNewGroup(Names.LSI_2_CURRENT_V11, (LSI_2_CURRENT_V11) =>
           {
               LSI_2_CURRENT_V11.CreateNewGroup(Names.LSI_IEF_SUPPLIED_V11_ET, (LSI_IEF_SUPPLIED_V11_ET) =>
               {
                   LSI_IEF_SUPPLIED_V11_ET.CreateNewField(Names.LSI_CUR_L2_CNT_11MS, FieldType.String, 1);

                   IField LSI_CUR_L2_CNT_11_local = LSI_IEF_SUPPLIED_V11_ET.CreateNewField(Names.LSI_CUR_L2_CNT_11, FieldType.SignedNumeric, 9);
                   LSI_IEF_SUPPLIED_V11_ET.CreateNewFieldRedefine(Names.LSI_CUR_L2_CNT_11XX, FieldType.String, LSI_CUR_L2_CNT_11_local, 9);
               });
           });

            recordDef.CreateNewGroup(Names.LSI_2_FORMER_V12, (LSI_2_FORMER_V12) =>
           {
               LSI_2_FORMER_V12.CreateNewGroup(Names.LSI_IEF_SUPPLIED_V12_ET, (LSI_IEF_SUPPLIED_V12_ET) =>
               {
                   LSI_IEF_SUPPLIED_V12_ET.CreateNewField(Names.LSI_FMR_L2_CNT_12MS, FieldType.String, 1);

                   IField LSI_FMR_L2_CNT_12_local = LSI_IEF_SUPPLIED_V12_ET.CreateNewField(Names.LSI_FMR_L2_CNT_12, FieldType.SignedNumeric, 9);
                   LSI_IEF_SUPPLIED_V12_ET.CreateNewFieldRedefine(Names.LSI_FMR_L2_CNT_12XX, FieldType.String, LSI_FMR_L2_CNT_12_local, 9);
               });
           });

            recordDef.CreateNewGroup(Names.LSI_2_NEVER_V13, (LSI_2_NEVER_V13) =>
           {
               LSI_2_NEVER_V13.CreateNewGroup(Names.LSI_IEF_SUPPLIED_V13_ET, (LSI_IEF_SUPPLIED_V13_ET) =>
               {
                   LSI_IEF_SUPPLIED_V13_ET.CreateNewField(Names.LSI_NVR_L2_CNT_13MS, FieldType.String, 1);

                   IField LSI_NVR_L2_CNT_13_local = LSI_IEF_SUPPLIED_V13_ET.CreateNewField(Names.LSI_NVR_L2_CNT_13, FieldType.SignedNumeric, 9);
                   LSI_IEF_SUPPLIED_V13_ET.CreateNewFieldRedefine(Names.LSI_NVR_L2_CNT_13XX, FieldType.String, LSI_NVR_L2_CNT_13_local, 9);
               });
           });

            recordDef.CreateNewGroup(Names.LSI_2A_CURRENT_V14, (LSI_2A_CURRENT_V14) =>
           {
               LSI_2A_CURRENT_V14.CreateNewGroup(Names.LSI_IEF_SUPPLIED_V14_ET, (LSI_IEF_SUPPLIED_V14_ET) =>
               {
                   LSI_IEF_SUPPLIED_V14_ET.CreateNewField(Names.LSI_CUR_L2A_CNT_14MS, FieldType.String, 1);

                   IField LSI_CUR_L2A_CNT_14_local = LSI_IEF_SUPPLIED_V14_ET.CreateNewField(Names.LSI_CUR_L2A_CNT_14, FieldType.SignedNumeric, 9);
                   LSI_IEF_SUPPLIED_V14_ET.CreateNewFieldRedefine(Names.LSI_CUR_L2A_CNT_14XX, FieldType.String, LSI_CUR_L2A_CNT_14_local, 9);
               });
           });

            recordDef.CreateNewGroup(Names.LSI_2A_FORMER_V15, (LSI_2A_FORMER_V15) =>
           {
               LSI_2A_FORMER_V15.CreateNewGroup(Names.LSI_IEF_SUPPLIED_V15_ET, (LSI_IEF_SUPPLIED_V15_ET) =>
               {
                   LSI_IEF_SUPPLIED_V15_ET.CreateNewField(Names.LSI_FMR_L2A_CNT_15MS, FieldType.String, 1);

                   IField LSI_FMR_L2A_CNT_15_local = LSI_IEF_SUPPLIED_V15_ET.CreateNewField(Names.LSI_FMR_L2A_CNT_15, FieldType.SignedNumeric, 9);
                   LSI_IEF_SUPPLIED_V15_ET.CreateNewFieldRedefine(Names.LSI_FMR_L2A_CNT_15XX, FieldType.String, LSI_FMR_L2A_CNT_15_local, 9);
               });
           });

            recordDef.CreateNewGroup(Names.LSI_2A_NEVER_V16, (LSI_2A_NEVER_V16) =>
           {
               LSI_2A_NEVER_V16.CreateNewGroup(Names.LSI_IEF_SUPPLIED_V16_ET, (LSI_IEF_SUPPLIED_V16_ET) =>
               {
                   LSI_IEF_SUPPLIED_V16_ET.CreateNewField(Names.LSI_NVR_L2A_CNT_16MS, FieldType.String, 1);

                   IField LSI_NVR_L2A_CNT_16_local = LSI_IEF_SUPPLIED_V16_ET.CreateNewField(Names.LSI_NVR_L2A_CNT_16, FieldType.SignedNumeric, 9);
                   LSI_IEF_SUPPLIED_V16_ET.CreateNewFieldRedefine(Names.LSI_NVR_L2A_CNT_16XX, FieldType.String, LSI_NVR_L2A_CNT_16_local, 9);
               });
           });

            recordDef.CreateNewGroup(Names.LSI_2B_CURRENT_V17, (LSI_2B_CURRENT_V17) =>
           {
               LSI_2B_CURRENT_V17.CreateNewGroup(Names.LSI_IEF_SUPPLIED_V17_ET, (LSI_IEF_SUPPLIED_V17_ET) =>
               {
                   LSI_IEF_SUPPLIED_V17_ET.CreateNewField(Names.LSI_CUR_L2B_CNT_17MS, FieldType.String, 1);

                   IField LSI_CUR_L2B_CNT_17_local = LSI_IEF_SUPPLIED_V17_ET.CreateNewField(Names.LSI_CUR_L2B_CNT_17, FieldType.SignedNumeric, 9);
                   LSI_IEF_SUPPLIED_V17_ET.CreateNewFieldRedefine(Names.LSI_CUR_L2B_CNT_17XX, FieldType.String, LSI_CUR_L2B_CNT_17_local, 9);
               });
           });

            recordDef.CreateNewGroup(Names.LSI_2B_FORMER_V18, (LSI_2B_FORMER_V18) =>
           {
               LSI_2B_FORMER_V18.CreateNewGroup(Names.LSI_IEF_SUPPLIED_V18_ET, (LSI_IEF_SUPPLIED_V18_ET) =>
               {
                   LSI_IEF_SUPPLIED_V18_ET.CreateNewField(Names.LSI_FMR_L2B_CNT_18MS, FieldType.String, 1);

                   IField LSI_FMR_L2B_CNT_18_local = LSI_IEF_SUPPLIED_V18_ET.CreateNewField(Names.LSI_FMR_L2B_CNT_18, FieldType.SignedNumeric, 9);
                   LSI_IEF_SUPPLIED_V18_ET.CreateNewFieldRedefine(Names.LSI_FMR_L2B_CNT_18XX, FieldType.String, LSI_FMR_L2B_CNT_18_local, 9);
               });
           });

            recordDef.CreateNewGroup(Names.LSI_2B_NEVER_V19, (LSI_2B_NEVER_V19) =>
           {
               LSI_2B_NEVER_V19.CreateNewGroup(Names.LSI_IEF_SUPPLIED_V19_ET, (LSI_IEF_SUPPLIED_V19_ET) =>
               {
                   LSI_IEF_SUPPLIED_V19_ET.CreateNewField(Names.LSI_NVR_L2B_CNT_19MS, FieldType.String, 1);

                   IField LSI_NVR_L2B_CNT_19_local = LSI_IEF_SUPPLIED_V19_ET.CreateNewField(Names.LSI_NVR_L2B_CNT_19, FieldType.SignedNumeric, 9);
                   LSI_IEF_SUPPLIED_V19_ET.CreateNewFieldRedefine(Names.LSI_NVR_L2B_CNT_19XX, FieldType.String, LSI_NVR_L2B_CNT_19_local, 9);
               });
           });

            recordDef.CreateNewGroup(Names.LSI_2C_CURRENT_V20, (LSI_2C_CURRENT_V20) =>
           {
               LSI_2C_CURRENT_V20.CreateNewGroup(Names.LSI_IEF_SUPPLIED_V20_ET, (LSI_IEF_SUPPLIED_V20_ET) =>
               {
                   LSI_IEF_SUPPLIED_V20_ET.CreateNewField(Names.LSI_CUR_L2C_CNT_20MS, FieldType.String, 1);

                   IField LSI_CUR_L2C_CNT_20_local = LSI_IEF_SUPPLIED_V20_ET.CreateNewField(Names.LSI_CUR_L2C_CNT_20, FieldType.SignedNumeric, 9);
                   LSI_IEF_SUPPLIED_V20_ET.CreateNewFieldRedefine(Names.LSI_CUR_L2C_CNT_20XX, FieldType.String, LSI_CUR_L2C_CNT_20_local, 9);
               });
           });

            recordDef.CreateNewGroup(Names.LSI_2C_FORMER_V21, (LSI_2C_FORMER_V21) =>
           {
               LSI_2C_FORMER_V21.CreateNewGroup(Names.LSI_IEF_SUPPLIED_V21_ET, (LSI_IEF_SUPPLIED_V21_ET) =>
               {
                   LSI_IEF_SUPPLIED_V21_ET.CreateNewField(Names.LSI_FMR_L2C_CNT_21MS, FieldType.String, 1);

                   IField LSI_FMR_L2C_CNT_21_local = LSI_IEF_SUPPLIED_V21_ET.CreateNewField(Names.LSI_FMR_L2C_CNT_21, FieldType.SignedNumeric, 9);
                   LSI_IEF_SUPPLIED_V21_ET.CreateNewFieldRedefine(Names.LSI_FMR_L2C_CNT_21XX, FieldType.String, LSI_FMR_L2C_CNT_21_local, 9);
               });
           });

            recordDef.CreateNewGroup(Names.LSI_2C_NEVER_V22, (LSI_2C_NEVER_V22) =>
           {
               LSI_2C_NEVER_V22.CreateNewGroup(Names.LSI_IEF_SUPPLIED_V22_ET, (LSI_IEF_SUPPLIED_V22_ET) =>
               {
                   LSI_IEF_SUPPLIED_V22_ET.CreateNewField(Names.LSI_NVR_L2C_CNT_22MS, FieldType.String, 1);

                   IField LSI_NVR_L2C_CNT_22_local = LSI_IEF_SUPPLIED_V22_ET.CreateNewField(Names.LSI_NVR_L2C_CNT_22, FieldType.SignedNumeric, 9);
                   LSI_IEF_SUPPLIED_V22_ET.CreateNewFieldRedefine(Names.LSI_NVR_L2C_CNT_22XX, FieldType.String, LSI_NVR_L2C_CNT_22_local, 9);
               });
           });

            recordDef.CreateNewGroup(Names.LSI_2D_NEVER_V23, (LSI_2D_NEVER_V23) =>
           {
               LSI_2D_NEVER_V23.CreateNewGroup(Names.LSI_IEF_SUPPLIED_V23_ET, (LSI_IEF_SUPPLIED_V23_ET) =>
               {
                   LSI_IEF_SUPPLIED_V23_ET.CreateNewField(Names.LSI_NVR_L2D_CNT_23MS, FieldType.String, 1);

                   IField LSI_NVR_L2D_CNT_23_local = LSI_IEF_SUPPLIED_V23_ET.CreateNewField(Names.LSI_NVR_L2D_CNT_23, FieldType.SignedNumeric, 9);
                   LSI_IEF_SUPPLIED_V23_ET.CreateNewFieldRedefine(Names.LSI_NVR_L2D_CNT_23XX, FieldType.String, LSI_NVR_L2D_CNT_23_local, 9);
               });
           });

            recordDef.CreateNewGroup(Names.LSI_3_CURRENT_V24, (LSI_3_CURRENT_V24) =>
           {
               LSI_3_CURRENT_V24.CreateNewGroup(Names.LSI_IEF_SUPPLIED_V24_ET, (LSI_IEF_SUPPLIED_V24_ET) =>
               {
                   LSI_IEF_SUPPLIED_V24_ET.CreateNewField(Names.LSI_CUR_L3_CNT_24MS, FieldType.String, 1);

                   IField LSI_CUR_L3_CNT_24_local = LSI_IEF_SUPPLIED_V24_ET.CreateNewField(Names.LSI_CUR_L3_CNT_24, FieldType.SignedNumeric, 9);
                   LSI_IEF_SUPPLIED_V24_ET.CreateNewFieldRedefine(Names.LSI_CUR_L3_CNT_24XX, FieldType.String, LSI_CUR_L3_CNT_24_local, 9);
               });
           });

            recordDef.CreateNewGroup(Names.LSI_3_FORMER_V25, (LSI_3_FORMER_V25) =>
           {
               LSI_3_FORMER_V25.CreateNewGroup(Names.LSI_IEF_SUPPLIED_V25_ET, (LSI_IEF_SUPPLIED_V25_ET) =>
               {
                   LSI_IEF_SUPPLIED_V25_ET.CreateNewField(Names.LSI_FMR_L3_CNT_25MS, FieldType.String, 1);

                   IField LSI_FMR_L3_CNT_25_local = LSI_IEF_SUPPLIED_V25_ET.CreateNewField(Names.LSI_FMR_L3_CNT_25, FieldType.SignedNumeric, 9);
                   LSI_IEF_SUPPLIED_V25_ET.CreateNewFieldRedefine(Names.LSI_FMR_L3_CNT_25XX, FieldType.String, LSI_FMR_L3_CNT_25_local, 9);
               });
           });

            recordDef.CreateNewGroup(Names.LSI_3_NEVER_V26, (LSI_3_NEVER_V26) =>
           {
               LSI_3_NEVER_V26.CreateNewGroup(Names.LSI_IEF_SUPPLIED_V26_ET, (LSI_IEF_SUPPLIED_V26_ET) =>
               {
                   LSI_IEF_SUPPLIED_V26_ET.CreateNewField(Names.LSI_NVR_L3_CNT_26MS, FieldType.String, 1);

                   IField LSI_NVR_L3_CNT_26_local = LSI_IEF_SUPPLIED_V26_ET.CreateNewField(Names.LSI_NVR_L3_CNT_26, FieldType.SignedNumeric, 9);
                   LSI_IEF_SUPPLIED_V26_ET.CreateNewFieldRedefine(Names.LSI_NVR_L3_CNT_26XX, FieldType.String, LSI_NVR_L3_CNT_26_local, 9);
               });
           });

            recordDef.CreateNewGroup(Names.LSI_4_TOTAL_V27, (LSI_4_TOTAL_V27) =>
           {
               LSI_4_TOTAL_V27.CreateNewGroup(Names.LSI_IEF_SUPPLIED_V27_ET, (LSI_IEF_SUPPLIED_V27_ET) =>
               {
                   LSI_IEF_SUPPLIED_V27_ET.CreateNewField(Names.LSI_TOT_L4_TOT_L4_CNT_27MS, FieldType.String, 1);

                   IField LSI_TOT_L4_CNT_27_local = LSI_IEF_SUPPLIED_V27_ET.CreateNewField(Names.LSI_TOT_L4_CNT_27, FieldType.SignedNumeric, 9);
                   LSI_IEF_SUPPLIED_V27_ET.CreateNewFieldRedefine(Names.LSI_TOT_L4_CNT_27XX, FieldType.String, LSI_TOT_L4_CNT_27_local, 9);
               });
           });

            recordDef.CreateNewGroup(Names.LSI_5_TOTAL_V28, (LSI_5_TOTAL_V28) =>
           {
               LSI_5_TOTAL_V28.CreateNewGroup(Names.LSI_IEF_SUPPLIED_V28_ET, (LSI_IEF_SUPPLIED_V28_ET) =>
               {
                   LSI_IEF_SUPPLIED_V28_ET.CreateNewField(Names.LSI_TOT_L5_CNT_28MS, FieldType.String, 1);

                   IField LSI_TOT_L5_CNT_28_local = LSI_IEF_SUPPLIED_V28_ET.CreateNewField(Names.LSI_TOT_L5_CNT_28, FieldType.SignedNumeric, 9);
                   LSI_IEF_SUPPLIED_V28_ET.CreateNewFieldRedefine(Names.LSI_TOT_L5_CNT_28XX, FieldType.String, LSI_TOT_L5_CNT_28_local, 9);
               });
           });

            recordDef.CreateNewGroup(Names.LSI_6_TOTAL_V29, (LSI_6_TOTAL_V29) =>
           {
               LSI_6_TOTAL_V29.CreateNewGroup(Names.LSI_IEF_SUPPLIED_V29_ET, (LSI_IEF_SUPPLIED_V29_ET) =>
               {
                   LSI_IEF_SUPPLIED_V29_ET.CreateNewField(Names.LSI_TOT_L6_CNT_29MS, FieldType.String, 1);

                   IField LSI_TOT_L6_CNT_29_local = LSI_IEF_SUPPLIED_V29_ET.CreateNewField(Names.LSI_TOT_L6_CNT_29, FieldType.SignedNumeric, 9);
                   LSI_IEF_SUPPLIED_V29_ET.CreateNewFieldRedefine(Names.LSI_TOT_L6_CNT_29XX, FieldType.String, LSI_TOT_L6_CNT_29_local, 9);
               });
           });

            recordDef.CreateNewGroup(Names.LSI_7_TOTAL_V30, (LSI_7_TOTAL_V30) =>
           {
               LSI_7_TOTAL_V30.CreateNewGroup(Names.LSI_IEF_SUPPLIED_V30_ET, (LSI_IEF_SUPPLIED_V30_ET) =>
               {
                   LSI_IEF_SUPPLIED_V30_ET.CreateNewField(Names.LSI_TOT_L7_CNT_30MS, FieldType.String, 1);

                   IField LSI_TOT_L7_CNT_30_local = LSI_IEF_SUPPLIED_V30_ET.CreateNewField(Names.LSI_TOT_L7_CNT_30, FieldType.SignedNumeric, 9);
                   LSI_IEF_SUPPLIED_V30_ET.CreateNewFieldRedefine(Names.LSI_TOT_L7_CNT_30XX, FieldType.String, LSI_TOT_L7_CNT_30_local, 9);
               });
           });

            recordDef.CreateNewGroup(Names.LSI_8_TOTAL_V31, (LSI_8_TOTAL_V31) =>
           {
               LSI_8_TOTAL_V31.CreateNewGroup(Names.LSI_IEF_SUPPLIED_V31_ET, (LSI_IEF_SUPPLIED_V31_ET) =>
               {
                   LSI_IEF_SUPPLIED_V31_ET.CreateNewField(Names.LSI_TOT_L8_CNT_31MS, FieldType.String, 1);

                   IField LSI_TOT_L8_CNT_31_local = LSI_IEF_SUPPLIED_V31_ET.CreateNewField(Names.LSI_TOT_L8_CNT_31, FieldType.SignedNumeric, 9);
                   LSI_IEF_SUPPLIED_V31_ET.CreateNewFieldRedefine(Names.LSI_TOT_L8_CNT_31XX, FieldType.String, LSI_TOT_L8_CNT_31_local, 9);
               });
           });

            recordDef.CreateNewGroup(Names.LSI_9_TOTAL_V32, (LSI_9_TOTAL_V32) =>
           {
               LSI_9_TOTAL_V32.CreateNewGroup(Names.LSI_IEF_SUPPLIED_V32_ET, (LSI_IEF_SUPPLIED_V32_ET) =>
               {
                   LSI_IEF_SUPPLIED_V32_ET.CreateNewField(Names.LSI_TOT_L9_CNT_32MS, FieldType.String, 1);

                   IField LSI_TOT_L9_CNT_32_local = LSI_IEF_SUPPLIED_V32_ET.CreateNewField(Names.LSI_TOT_L9_CNT_32, FieldType.SignedNumeric, 9);
                   LSI_IEF_SUPPLIED_V32_ET.CreateNewFieldRedefine(Names.LSI_TOT_L9_CNT_32XX, FieldType.String, LSI_TOT_L9_CNT_32_local, 9);
               });
           });

            recordDef.CreateNewGroup(Names.LSI_10_TOTAL_V33, (LSI_10_TOTAL_V33) =>
           {
               LSI_10_TOTAL_V33.CreateNewGroup(Names.LSI_IEF_SUPPLIED_V33_ET, (LSI_IEF_SUPPLIED_V33_ET) =>
               {
                   LSI_IEF_SUPPLIED_V33_ET.CreateNewField(Names.LSI_TOT_L10_CNT_33MS, FieldType.String, 1);

                   IField LSI_TOT_L10_CNT_33_local = LSI_IEF_SUPPLIED_V33_ET.CreateNewField(Names.LSI_TOT_L10_CNT_33, FieldType.SignedNumeric, 9);
                   LSI_IEF_SUPPLIED_V33_ET.CreateNewFieldRedefine(Names.LSI_TOT_L10_CNT_33XX, FieldType.String, LSI_TOT_L10_CNT_33_local, 9);
               });
           });

            recordDef.CreateNewGroup(Names.LSI_12_CURRENT_V34, (LSI_12_CURRENT_V34) =>
           {
               LSI_12_CURRENT_V34.CreateNewGroup(Names.LSI_IEF_SUPPLIED_V34_ET, (LSI_IEF_SUPPLIED_V34_ET) =>
               {
                   LSI_IEF_SUPPLIED_V34_ET.CreateNewField(Names.LSI_CUR_L12_CNT_34MS, FieldType.String, 1);

                   IField LSI_CUR_L12_CNT_34_local = LSI_IEF_SUPPLIED_V34_ET.CreateNewField(Names.LSI_CUR_L12_CNT_34, FieldType.SignedNumeric, 9);
                   LSI_IEF_SUPPLIED_V34_ET.CreateNewFieldRedefine(Names.LSI_CUR_L12_CNT_34XX, FieldType.String, LSI_CUR_L12_CNT_34_local, 9);
               });
           });

            recordDef.CreateNewGroup(Names.LSI_12_FORMER_V35, (LSI_12_FORMER_V35) =>
           {
               LSI_12_FORMER_V35.CreateNewGroup(Names.LSI_IEF_SUPPLIED_V35_ET, (LSI_IEF_SUPPLIED_V35_ET) =>
               {
                   LSI_IEF_SUPPLIED_V35_ET.CreateNewField(Names.LSI_FMR_L12_CNT_35MS, FieldType.String, 1);

                   IField LSI_FMR_L12_CNT_35_local = LSI_IEF_SUPPLIED_V35_ET.CreateNewField(Names.LSI_FMR_L12_CNT_35, FieldType.SignedNumeric, 9);
                   LSI_IEF_SUPPLIED_V35_ET.CreateNewFieldRedefine(Names.LSI_FMR_L12_CNT_35XX, FieldType.String, LSI_FMR_L12_CNT_35_local, 9);
               });
           });

            recordDef.CreateNewGroup(Names.LSI_12_NEVER_V36, (LSI_12_NEVER_V36) =>
           {
               LSI_12_NEVER_V36.CreateNewGroup(Names.LSI_IEF_SUPPLIED_V36_ET, (LSI_IEF_SUPPLIED_V36_ET) =>
               {
                   LSI_IEF_SUPPLIED_V36_ET.CreateNewField(Names.LSI_NVR_L12_CNT_36MS, FieldType.String, 1);

                   IField LSI_NVR_L12_CNT_36_local = LSI_IEF_SUPPLIED_V36_ET.CreateNewField(Names.LSI_NVR_L12_CNT_36, FieldType.SignedNumeric, 9);
                   LSI_IEF_SUPPLIED_V36_ET.CreateNewFieldRedefine(Names.LSI_NVR_L12_CNT_36XX, FieldType.String, LSI_NVR_L12_CNT_36_local, 9);
               });
           });

            recordDef.CreateNewGroup(Names.LSI_13_CURRENT_V37, (LSI_13_CURRENT_V37) =>
           {
               LSI_13_CURRENT_V37.CreateNewGroup(Names.LSI_IEF_SUPPLIED_V37_ET, (LSI_IEF_SUPPLIED_V37_ET) =>
               {
                   LSI_IEF_SUPPLIED_V37_ET.CreateNewField(Names.LSI_CUR_L13_CNT_37MS, FieldType.String, 1);

                   IField LSI_CUR_L13_CNT_37_local = LSI_IEF_SUPPLIED_V37_ET.CreateNewField(Names.LSI_CUR_L13_CNT_37, FieldType.SignedNumeric, 9);
                   LSI_IEF_SUPPLIED_V37_ET.CreateNewFieldRedefine(Names.LSI_CUR_L13_CNT_37XX, FieldType.String, LSI_CUR_L13_CNT_37_local, 9);
               });
           });

            recordDef.CreateNewGroup(Names.LSI_13_FORMER_V38, (LSI_13_FORMER_V38) =>
           {
               LSI_13_FORMER_V38.CreateNewGroup(Names.LSI_IEF_SUPPLIED_V38_ET, (LSI_IEF_SUPPLIED_V38_ET) =>
               {
                   LSI_IEF_SUPPLIED_V38_ET.CreateNewField(Names.LSI_FMR_L13_CNT_38MS, FieldType.String, 1);

                   IField LSI_FMR_L13_CNT_38_local = LSI_IEF_SUPPLIED_V38_ET.CreateNewField(Names.LSI_FMR_L13_CNT_38, FieldType.SignedNumeric, 9);
                   LSI_IEF_SUPPLIED_V38_ET.CreateNewFieldRedefine(Names.LSI_FMR_L13_CNT_38XX, FieldType.String, LSI_FMR_L13_CNT_38_local, 9);
               });
           });

            recordDef.CreateNewGroup(Names.LSI_13_NEVER_V39, (LSI_13_NEVER_V39) =>
           {
               LSI_13_NEVER_V39.CreateNewGroup(Names.LSI_IEF_SUPPLIED_V39_ET, (LSI_IEF_SUPPLIED_V39_ET) =>
               {
                   LSI_IEF_SUPPLIED_V39_ET.CreateNewField(Names.LSI_NVR_L13_CNT_39MS, FieldType.String, 1);

                   IField LSI_NVR_L13_CNT_39_local = LSI_IEF_SUPPLIED_V39_ET.CreateNewField(Names.LSI_NVR_L13_CNT_39, FieldType.SignedNumeric, 9);
                   LSI_IEF_SUPPLIED_V39_ET.CreateNewFieldRedefine(Names.LSI_NVR_L13_CNT_39XX, FieldType.String, LSI_NVR_L13_CNT_39_local, 9);
               });
           });

            recordDef.CreateNewGroup(Names.LSI_14_TOTAL_V40, (LSI_14_TOTAL_V40) =>
           {
               LSI_14_TOTAL_V40.CreateNewGroup(Names.LSI_IEF_SUPPLIED_V40_ET, (LSI_IEF_SUPPLIED_V40_ET) =>
               {
                   LSI_IEF_SUPPLIED_V40_ET.CreateNewField(Names.LSI_TOT_L14_CNT_40MS, FieldType.String, 1);

                   IField LSI_TOT_L14_CNT_40_local = LSI_IEF_SUPPLIED_V40_ET.CreateNewField(Names.LSI_TOT_L14_CNT_40, FieldType.SignedNumeric, 9);
                   LSI_IEF_SUPPLIED_V40_ET.CreateNewFieldRedefine(Names.LSI_TOT_L14_CNT_40XX, FieldType.String, LSI_TOT_L14_CNT_40_local, 9);
               });
           });

            recordDef.CreateNewGroup(Names.LSI_16_CURRENT_V41, (LSI_16_CURRENT_V41) =>
           {
               LSI_16_CURRENT_V41.CreateNewGroup(Names.LSI_IEF_SUPPLIED_V41_ET, (LSI_IEF_SUPPLIED_V41_ET) =>
               {
                   LSI_IEF_SUPPLIED_V41_ET.CreateNewField(Names.LSI_CUR_L16_CNT_41MS, FieldType.String, 1);

                   IField LSI_CUR_L16_CNT_41_local = LSI_IEF_SUPPLIED_V41_ET.CreateNewField(Names.LSI_CUR_L16_CNT_41, FieldType.SignedNumeric, 9);
                   LSI_IEF_SUPPLIED_V41_ET.CreateNewFieldRedefine(Names.LSI_CUR_L16_CNT_41XX, FieldType.String, LSI_CUR_L16_CNT_41_local, 9);
               });
           });

            recordDef.CreateNewGroup(Names.LSI_16_FORMER_V42, (LSI_16_FORMER_V42) =>
           {
               LSI_16_FORMER_V42.CreateNewGroup(Names.LSI_IEF_SUPPLIED_V42_ET, (LSI_IEF_SUPPLIED_V42_ET) =>
               {
                   LSI_IEF_SUPPLIED_V42_ET.CreateNewField(Names.LSI_FMR_L16_CNT_42MS, FieldType.String, 1);

                   IField LSI_FMR_L16_CNT_42_local = LSI_IEF_SUPPLIED_V42_ET.CreateNewField(Names.LSI_FMR_L16_CNT_42, FieldType.SignedNumeric, 9);
                   LSI_IEF_SUPPLIED_V42_ET.CreateNewFieldRedefine(Names.LSI_FMR_L16_CNT_42XX, FieldType.String, LSI_FMR_L16_CNT_42_local, 9);
               });
           });

            recordDef.CreateNewGroup(Names.LSI_16_NEVER_V43, (LSI_16_NEVER_V43) =>
           {
               LSI_16_NEVER_V43.CreateNewGroup(Names.LSI_IEF_SUPPLIED_V43_ET, (LSI_IEF_SUPPLIED_V43_ET) =>
               {
                   LSI_IEF_SUPPLIED_V43_ET.CreateNewField(Names.LSI_NVR_L16_CNT_43MS, FieldType.String, 1);

                   IField LSI_NVR_L16_CNT_43_local = LSI_IEF_SUPPLIED_V43_ET.CreateNewField(Names.LSI_NVR_L16_CNT_43, FieldType.SignedNumeric, 9);
                   LSI_IEF_SUPPLIED_V43_ET.CreateNewFieldRedefine(Names.LSI_NVR_L16_CNT_43XX, FieldType.String, LSI_NVR_L16_CNT_43_local, 9);
               });
           });

            recordDef.CreateNewGroup(Names.LSI_17_CURRENT_V44, (LSI_17_CURRENT_V44) =>
           {
               LSI_17_CURRENT_V44.CreateNewGroup(Names.LSI_IEF_SUPPLIED_V44_ET, (LSI_IEF_SUPPLIED_V44_ET) =>
               {
                   LSI_IEF_SUPPLIED_V44_ET.CreateNewField(Names.LSI_CUR_L17_CNT_44MS, FieldType.String, 1);

                   IField LSI_CUR_L17_CNT_44_local = LSI_IEF_SUPPLIED_V44_ET.CreateNewField(Names.LSI_CUR_L17_CNT_44, FieldType.SignedNumeric, 9);
                   LSI_IEF_SUPPLIED_V44_ET.CreateNewFieldRedefine(Names.LSI_CUR_L17_CNT_44XX, FieldType.String, LSI_CUR_L17_CNT_44_local, 9);
               });
           });

            recordDef.CreateNewGroup(Names.LSI_17_FORMER_V45, (LSI_17_FORMER_V45) =>
           {
               LSI_17_FORMER_V45.CreateNewGroup(Names.LSI_IEF_SUPPLIED_V45_ET, (LSI_IEF_SUPPLIED_V45_ET) =>
               {
                   LSI_IEF_SUPPLIED_V45_ET.CreateNewField(Names.LSI_FMR_L17_CNT_45MS, FieldType.String, 1);

                   IField LSI_FMR_L17_CNT_45_local = LSI_IEF_SUPPLIED_V45_ET.CreateNewField(Names.LSI_FMR_L17_CNT_45, FieldType.SignedNumeric, 9);
                   LSI_IEF_SUPPLIED_V45_ET.CreateNewFieldRedefine(Names.LSI_FMR_L17_CNT_45XX, FieldType.String, LSI_FMR_L17_CNT_45_local, 9);
               });
           });

            recordDef.CreateNewGroup(Names.LSI_17_NEVER_V46, (LSI_17_NEVER_V46) =>
           {
               LSI_17_NEVER_V46.CreateNewGroup(Names.LSI_IEF_SUPPLIED_V46_ET, (LSI_IEF_SUPPLIED_V46_ET) =>
               {
                   LSI_IEF_SUPPLIED_V46_ET.CreateNewField(Names.LSI_NVR_L17_CNT_46MS, FieldType.String, 1);

                   IField LSI_NVR_L17_CNT_46_local = LSI_IEF_SUPPLIED_V46_ET.CreateNewField(Names.LSI_NVR_L17_CNT_46, FieldType.SignedNumeric, 9);
                   LSI_IEF_SUPPLIED_V46_ET.CreateNewFieldRedefine(Names.LSI_NVR_L17_CNT_46XX, FieldType.String, LSI_NVR_L17_CNT_46_local, 9);
               });
           });

            recordDef.CreateNewGroup(Names.LSI_18_CURRENT_V47, (LSI_18_CURRENT_V47) =>
           {
               LSI_18_CURRENT_V47.CreateNewGroup(Names.LSI_IEF_SUPPLIED_V47_ET, (LSI_IEF_SUPPLIED_V47_ET) =>
               {
                   LSI_IEF_SUPPLIED_V47_ET.CreateNewField(Names.LSI_CUR_L18_CNT_47MS, FieldType.String, 1);

                   IField LSI_CUR_L18_CNT_47_local = LSI_IEF_SUPPLIED_V47_ET.CreateNewField(Names.LSI_CUR_L18_CNT_47, FieldType.SignedNumeric, 9);
                   LSI_IEF_SUPPLIED_V47_ET.CreateNewFieldRedefine(Names.LSI_CUR_L18_CNT_47XX, FieldType.String, LSI_CUR_L18_CNT_47_local, 9);
               });
           });

            recordDef.CreateNewGroup(Names.LSI_18_FORMER_V48, (LSI_18_FORMER_V48) =>
           {
               LSI_18_FORMER_V48.CreateNewGroup(Names.LSI_IEF_SUPPLIED_V48_ET, (LSI_IEF_SUPPLIED_V48_ET) =>
               {
                   LSI_IEF_SUPPLIED_V48_ET.CreateNewField(Names.LSI_FMR_L18_CNT_48MS, FieldType.String, 1);

                   IField LSI_FMR_L18_CNT_48_local = LSI_IEF_SUPPLIED_V48_ET.CreateNewField(Names.LSI_FMR_L18_CNT_48, FieldType.SignedNumeric, 9);
                   LSI_IEF_SUPPLIED_V48_ET.CreateNewFieldRedefine(Names.LSI_FMR_L18_CNT_48XX, FieldType.String, LSI_FMR_L18_CNT_48_local, 9);
               });
           });

            recordDef.CreateNewGroup(Names.LSI_18_NEVER_V49, (LSI_18_NEVER_V49) =>
           {
               LSI_18_NEVER_V49.CreateNewGroup(Names.LSI_IEF_SUPPLIED_V49_ET, (LSI_IEF_SUPPLIED_V49_ET) =>
               {
                   LSI_IEF_SUPPLIED_V49_ET.CreateNewField(Names.LSI_NVR_L18_CNT_49MS, FieldType.String, 1);

                   IField LSI_NVR_L18_CNT_49_local = LSI_IEF_SUPPLIED_V49_ET.CreateNewField(Names.LSI_NVR_L18_CNT_49, FieldType.SignedNumeric, 9);
                   LSI_IEF_SUPPLIED_V49_ET.CreateNewFieldRedefine(Names.LSI_NVR_L18_CNT_49XX, FieldType.String, LSI_NVR_L18_CNT_49_local, 9);
               });
           });

            recordDef.CreateNewGroup(Names.LSI_18A_CURRENT_V50, (LSI_18A_CURRENT_V50) =>
           {
               LSI_18A_CURRENT_V50.CreateNewGroup(Names.LSI_IEF_SUPPLIED_V50_ET, (LSI_IEF_SUPPLIED_V50_ET) =>
               {
                   LSI_IEF_SUPPLIED_V50_ET.CreateNewField(Names.LSI_CUR_L18A_CNT_50MS, FieldType.String, 1);

                   IField LSI_CUR_L18A_CNT_50_local = LSI_IEF_SUPPLIED_V50_ET.CreateNewField(Names.LSI_CUR_L18A_CNT_50, FieldType.SignedNumeric, 9);
                   LSI_IEF_SUPPLIED_V50_ET.CreateNewFieldRedefine(Names.LSI_CUR_L18A_CNT_50XX, FieldType.String, LSI_CUR_L18A_CNT_50_local, 9);
               });
           });

            recordDef.CreateNewGroup(Names.LSI_18A_FORMER_V51, (LSI_18A_FORMER_V51) =>
           {
               LSI_18A_FORMER_V51.CreateNewGroup(Names.LSI_IEF_SUPPLIED_V51_ET, (LSI_IEF_SUPPLIED_V51_ET) =>
               {
                   LSI_IEF_SUPPLIED_V51_ET.CreateNewField(Names.LSI_FMR_L18A_CNT_51MS, FieldType.String, 1);

                   IField LSI_FMR_L18A_CNT_51_local = LSI_IEF_SUPPLIED_V51_ET.CreateNewField(Names.LSI_FMR_L18A_CNT_51, FieldType.SignedNumeric, 9);
                   LSI_IEF_SUPPLIED_V51_ET.CreateNewFieldRedefine(Names.LSI_FMR_L18A_CNT_51XX, FieldType.String, LSI_FMR_L18A_CNT_51_local, 9);
               });
           });

            recordDef.CreateNewGroup(Names.LSI_18A_NEVER_V52, (LSI_18A_NEVER_V52) =>
           {
               LSI_18A_NEVER_V52.CreateNewGroup(Names.LSI_IEF_SUPPLIED_V52_ET, (LSI_IEF_SUPPLIED_V52_ET) =>
               {
                   LSI_IEF_SUPPLIED_V52_ET.CreateNewField(Names.LSI_NVR_L18A_CNT_52MS, FieldType.String, 1);

                   IField LSI_NVR_L18A_CNT_52_local = LSI_IEF_SUPPLIED_V52_ET.CreateNewField(Names.LSI_NVR_L18A_CNT_52, FieldType.SignedNumeric, 9);
                   LSI_IEF_SUPPLIED_V52_ET.CreateNewFieldRedefine(Names.LSI_NVR_L18A_CNT_52XX, FieldType.String, LSI_NVR_L18A_CNT_52_local, 9);
               });
           });

            recordDef.CreateNewGroup(Names.LSI_19_CURRENT_V53, (LSI_19_CURRENT_V53) =>
           {
               LSI_19_CURRENT_V53.CreateNewGroup(Names.LSI_IEF_SUPPLIED_V53_ET, (LSI_IEF_SUPPLIED_V53_ET) =>
               {
                   LSI_IEF_SUPPLIED_V53_ET.CreateNewField(Names.LSI_CUR_L19_CNT_53MS, FieldType.String, 1);

                   IField LSI_CUR_L19_CNT_53_local = LSI_IEF_SUPPLIED_V53_ET.CreateNewField(Names.LSI_CUR_L19_CNT_53, FieldType.SignedNumeric, 9);
                   LSI_IEF_SUPPLIED_V53_ET.CreateNewFieldRedefine(Names.LSI_CUR_L19_CNT_53XX, FieldType.String, LSI_CUR_L19_CNT_53_local, 9);
               });
           });

            recordDef.CreateNewGroup(Names.LSI_19_FORMER_V54, (LSI_19_FORMER_V54) =>
           {
               LSI_19_FORMER_V54.CreateNewGroup(Names.LSI_IEF_SUPPLIED_V54_ET, (LSI_IEF_SUPPLIED_V54_ET) =>
               {
                   LSI_IEF_SUPPLIED_V54_ET.CreateNewField(Names.LSI_FMR_L19_CNT_54MS, FieldType.String, 1);

                   IField LSI_FMR_L19_CNT_54_local = LSI_IEF_SUPPLIED_V54_ET.CreateNewField(Names.LSI_FMR_L19_CNT_54, FieldType.SignedNumeric, 9);
                   LSI_IEF_SUPPLIED_V54_ET.CreateNewFieldRedefine(Names.LSI_FMR_L19_CNT_54XX, FieldType.String, LSI_FMR_L19_CNT_54_local, 9);
               });
           });

            recordDef.CreateNewGroup(Names.LSI_19_NEVER_V55, (LSI_19_NEVER_V55) =>
           {
               LSI_19_NEVER_V55.CreateNewGroup(Names.LSI_IEF_SUPPLIED_V55_ET, (LSI_IEF_SUPPLIED_V55_ET) =>
               {
                   LSI_IEF_SUPPLIED_V55_ET.CreateNewField(Names.LSI_NVR_L19_CNT_55MS, FieldType.String, 1);

                   IField LSI_NVR_L19_CNT_55_local = LSI_IEF_SUPPLIED_V55_ET.CreateNewField(Names.LSI_NVR_L19_CNT_55, FieldType.SignedNumeric, 9);
                   LSI_IEF_SUPPLIED_V55_ET.CreateNewFieldRedefine(Names.LSI_NVR_L19_CNT_55XX, FieldType.String, LSI_NVR_L19_CNT_55_local, 9);
               });
           });

            recordDef.CreateNewGroup(Names.LSI_20_CURRENT_V56, (LSI_20_CURRENT_V56) =>
           {
               LSI_20_CURRENT_V56.CreateNewGroup(Names.LSI_IEF_SUPPLIED_V56_ET, (LSI_IEF_SUPPLIED_V56_ET) =>
               {
                   LSI_IEF_SUPPLIED_V56_ET.CreateNewField(Names.LSI_CUR_L20_CNT_56MS, FieldType.String, 1);

                   IField LSI_CUR_L20_CNT_56_local = LSI_IEF_SUPPLIED_V56_ET.CreateNewField(Names.LSI_CUR_L20_CNT_56, FieldType.SignedNumeric, 9);
                   LSI_IEF_SUPPLIED_V56_ET.CreateNewFieldRedefine(Names.LSI_CUR_L20_CNT_56XX, FieldType.String, LSI_CUR_L20_CNT_56_local, 9);
               });
           });

            recordDef.CreateNewGroup(Names.LSI_20_FORMER_V57, (LSI_20_FORMER_V57) =>
           {
               LSI_20_FORMER_V57.CreateNewGroup(Names.LSI_IEF_SUPPLIED_V57_ET, (LSI_IEF_SUPPLIED_V57_ET) =>
               {
                   LSI_IEF_SUPPLIED_V57_ET.CreateNewField(Names.LSI_FMR_L20_CNT_57MS, FieldType.String, 1);

                   IField LSI_FMR_L20_CNT_57_local = LSI_IEF_SUPPLIED_V57_ET.CreateNewField(Names.LSI_FMR_L20_CNT_57, FieldType.SignedNumeric, 9);
                   LSI_IEF_SUPPLIED_V57_ET.CreateNewFieldRedefine(Names.LSI_FMR_L20_CNT_57XX, FieldType.String, LSI_FMR_L20_CNT_57_local, 9);
               });
           });

            recordDef.CreateNewGroup(Names.LSI_20_NEVER_V58, (LSI_20_NEVER_V58) =>
           {
               LSI_20_NEVER_V58.CreateNewGroup(Names.LSI_IEF_SUPPLIED_V58_ET, (LSI_IEF_SUPPLIED_V58_ET) =>
               {
                   LSI_IEF_SUPPLIED_V58_ET.CreateNewField(Names.LSI_NVR_L20_CNT_58MS, FieldType.String, 1);

                   IField LSI_NVR_L20_CNT_58_local = LSI_IEF_SUPPLIED_V58_ET.CreateNewField(Names.LSI_NVR_L20_CNT_58, FieldType.SignedNumeric, 9);
                   LSI_IEF_SUPPLIED_V58_ET.CreateNewFieldRedefine(Names.LSI_NVR_L20_CNT_58XX, FieldType.String, LSI_NVR_L20_CNT_58_local, 9);
               });
           });

            recordDef.CreateNewGroup(Names.LSI_21_TOTAL_V59, (LSI_21_TOTAL_V59) =>
           {
               LSI_21_TOTAL_V59.CreateNewGroup(Names.LSI_IEF_SUPPLIED_V59_ET, (LSI_IEF_SUPPLIED_V59_ET) =>
               {
                   LSI_IEF_SUPPLIED_V59_ET.CreateNewField(Names.LSI_TOT_L21_CNT_59MS, FieldType.String, 1);

                   IField LSI_TOT_L21_CNT_59_local = LSI_IEF_SUPPLIED_V59_ET.CreateNewField(Names.LSI_TOT_L21_CNT_59, FieldType.SignedNumeric, 9);
                   LSI_IEF_SUPPLIED_V59_ET.CreateNewFieldRedefine(Names.LSI_TOT_L21_CNT_59XX, FieldType.String, LSI_TOT_L21_CNT_59_local, 9);
               });
           });

            recordDef.CreateNewGroup(Names.LSI_22_TOTAL_V60, (LSI_22_TOTAL_V60) =>
           {
               LSI_22_TOTAL_V60.CreateNewGroup(Names.LSI_IEF_SUPPLIED_V60_ET, (LSI_IEF_SUPPLIED_V60_ET) =>
               {
                   LSI_IEF_SUPPLIED_V60_ET.CreateNewField(Names.LSI_TOT_L22_CNT_60MS, FieldType.String, 1);

                   IField LSI_TOT_L22_CNT_60_local = LSI_IEF_SUPPLIED_V60_ET.CreateNewField(Names.LSI_TOT_L22_CNT_60, FieldType.SignedNumeric, 9);
                   LSI_IEF_SUPPLIED_V60_ET.CreateNewFieldRedefine(Names.LSI_TOT_L22_CNT_60XX, FieldType.String, LSI_TOT_L22_CNT_60_local, 9);
               });
           });

            recordDef.CreateNewGroup(Names.LSI_23_TOTAL_V61, (LSI_23_TOTAL_V61) =>
           {
               LSI_23_TOTAL_V61.CreateNewGroup(Names.LSI_IEF_SUPPLIED_V61_ET, (LSI_IEF_SUPPLIED_V61_ET) =>
               {
                   LSI_IEF_SUPPLIED_V61_ET.CreateNewField(Names.LSI_TOT_L23_CNT_61MS, FieldType.String, 1);

                   IField LSI_TOT_L23_CNT_61_local = LSI_IEF_SUPPLIED_V61_ET.CreateNewField(Names.LSI_TOT_L23_CNT_61, FieldType.SignedNumeric, 9);
                   LSI_IEF_SUPPLIED_V61_ET.CreateNewFieldRedefine(Names.LSI_TOT_L23_CNT_61XX, FieldType.String, LSI_TOT_L23_CNT_61_local, 9);
               });
           });

            recordDef.CreateNewGroup(Names.LSI_24_CURRENT_V62, (LSI_24_CURRENT_V62) =>
           {
               LSI_24_CURRENT_V62.CreateNewGroup(Names.LSI_IEF_SUPPLIED_V62_ET, (LSI_IEF_SUPPLIED_V62_ET) =>
               {
                   LSI_IEF_SUPPLIED_V62_ET.CreateNewField(Names.LSI_CUR_L24_CNT_62MS, FieldType.String, 1);

                   IField LSI_CUR_L24_CNT_62_local = LSI_IEF_SUPPLIED_V62_ET.CreateNewField(Names.LSI_CUR_L24_CNT_62, FieldType.SignedNumeric, 9);
                   LSI_IEF_SUPPLIED_V62_ET.CreateNewFieldRedefine(Names.LSI_CUR_L24_CNT_62XX, FieldType.String, LSI_CUR_L24_CNT_62_local, 9);
               });
           });

            recordDef.CreateNewGroup(Names.LSI_24_FORMER_V63, (LSI_24_FORMER_V63) =>
           {
               LSI_24_FORMER_V63.CreateNewGroup(Names.LSI_IEF_SUPPLIED_V63_ET, (LSI_IEF_SUPPLIED_V63_ET) =>
               {
                   LSI_IEF_SUPPLIED_V63_ET.CreateNewField(Names.LSI_FMR_L24_CNT_63MS, FieldType.String, 1);

                   IField LSI_FMR_L24_CNT_63_local = LSI_IEF_SUPPLIED_V63_ET.CreateNewField(Names.LSI_FMR_L24_CNT_63, FieldType.SignedNumeric, 9);
                   LSI_IEF_SUPPLIED_V63_ET.CreateNewFieldRedefine(Names.LSI_FMR_L24_CNT_63XX, FieldType.String, LSI_FMR_L24_CNT_63_local, 9);
               });
           });

            recordDef.CreateNewGroup(Names.LSI_24_NEVER_V64, (LSI_24_NEVER_V64) =>
           {
               LSI_24_NEVER_V64.CreateNewGroup(Names.LSI_IEF_SUPPLIED_V64_ET, (LSI_IEF_SUPPLIED_V64_ET) =>
               {
                   LSI_IEF_SUPPLIED_V64_ET.CreateNewField(Names.LSI_NVR_L24_CNT_64MS, FieldType.String, 1);

                   IField LSI_NVR_L24_CNT_64_local = LSI_IEF_SUPPLIED_V64_ET.CreateNewField(Names.LSI_NVR_L24_CNT_64, FieldType.SignedNumeric, 9);
                   LSI_IEF_SUPPLIED_V64_ET.CreateNewFieldRedefine(Names.LSI_NVR_L24_CNT_64XX, FieldType.String, LSI_NVR_L24_CNT_64_local, 9);
               });
           });

            recordDef.CreateNewGroup(Names.LSI_25_CURRENT_V65, (LSI_25_CURRENT_V65) =>
           {
               LSI_25_CURRENT_V65.CreateNewGroup(Names.LSI_IEF_SUPPLIED_V65_ET, (LSI_IEF_SUPPLIED_V65_ET) =>
               {
                   LSI_IEF_SUPPLIED_V65_ET.CreateNewField(Names.LSI_CUR_L25_CNT_65MS, FieldType.String, 1);

                   IField LSI_CUR_L25_CNT_65_local = LSI_IEF_SUPPLIED_V65_ET.CreateNewField(Names.LSI_CUR_L25_CNT_65, FieldType.SignedNumeric, 9);
                   LSI_IEF_SUPPLIED_V65_ET.CreateNewFieldRedefine(Names.LSI_CUR_L25_CNT_65XX, FieldType.String, LSI_CUR_L25_CNT_65_local, 9);
               });
           });

            recordDef.CreateNewGroup(Names.LSI_25_FORMER_V66, (LSI_25_FORMER_V66) =>
           {
               LSI_25_FORMER_V66.CreateNewGroup(Names.LSI_IEF_SUPPLIED_V66_ET, (LSI_IEF_SUPPLIED_V66_ET) =>
               {
                   LSI_IEF_SUPPLIED_V66_ET.CreateNewField(Names.LSI_FMR_L25_CNT_66MS, FieldType.String, 1);

                   IField LSI_FMR_L25_CNT_66_local = LSI_IEF_SUPPLIED_V66_ET.CreateNewField(Names.LSI_FMR_L25_CNT_66, FieldType.SignedNumeric, 9);
                   LSI_IEF_SUPPLIED_V66_ET.CreateNewFieldRedefine(Names.LSI_FMR_L25_CNT_66XX, FieldType.String, LSI_FMR_L25_CNT_66_local, 9);
               });
           });

            recordDef.CreateNewGroup(Names.LSI_25_NEVER_V67, (LSI_25_NEVER_V67) =>
           {
               LSI_25_NEVER_V67.CreateNewGroup(Names.LSI_IEF_SUPPLIED_V67_ET, (LSI_IEF_SUPPLIED_V67_ET) =>
               {
                   LSI_IEF_SUPPLIED_V67_ET.CreateNewField(Names.LSI_NVR_L25_CNT_67MS, FieldType.String, 1);

                   IField LSI_NVR_L25_CNT_67_local = LSI_IEF_SUPPLIED_V67_ET.CreateNewField(Names.LSI_NVR_L25_CNT_67, FieldType.SignedNumeric, 9);
                   LSI_IEF_SUPPLIED_V67_ET.CreateNewFieldRedefine(Names.LSI_NVR_L25_CNT_67XX, FieldType.String, LSI_NVR_L25_CNT_67_local, 9);
               });
           });

            recordDef.CreateNewGroup(Names.LSI_26_CURRENT_V68, (LSI_26_CURRENT_V68) =>
           {
               LSI_26_CURRENT_V68.CreateNewGroup(Names.LSI_IEF_SUPPLIED_V68_ET, (LSI_IEF_SUPPLIED_V68_ET) =>
               {
                   LSI_IEF_SUPPLIED_V68_ET.CreateNewField(Names.LSI_CUR_L26_CNT_68MS, FieldType.String, 1);

                   IField LSI_CUR_L26_CNT_68_local = LSI_IEF_SUPPLIED_V68_ET.CreateNewField(Names.LSI_CUR_L26_CNT_68, FieldType.SignedNumeric, 9);
                   LSI_IEF_SUPPLIED_V68_ET.CreateNewFieldRedefine(Names.LSI_CUR_L26_CNT_68XX, FieldType.String, LSI_CUR_L26_CNT_68_local, 9);
               });
           });

            recordDef.CreateNewGroup(Names.LSI_26_FORMER_V69, (LSI_26_FORMER_V69) =>
           {
               LSI_26_FORMER_V69.CreateNewGroup(Names.LSI_IEF_SUPPLIED_V69_ET, (LSI_IEF_SUPPLIED_V69_ET) =>
               {
                   LSI_IEF_SUPPLIED_V69_ET.CreateNewField(Names.LSI_FMR_L26_CNT_69MS, FieldType.String, 1);

                   IField LSI_FMR_L26_CNT_69_local = LSI_IEF_SUPPLIED_V69_ET.CreateNewField(Names.LSI_FMR_L26_CNT_69, FieldType.SignedNumeric, 9);
                   LSI_IEF_SUPPLIED_V69_ET.CreateNewFieldRedefine(Names.LSI_FMR_L26_CNT_69XX, FieldType.String, LSI_FMR_L26_CNT_69_local, 9);
               });
           });

            recordDef.CreateNewGroup(Names.LSI_26_NEVER_V70, (LSI_26_NEVER_V70) =>
           {
               LSI_26_NEVER_V70.CreateNewGroup(Names.LSI_IEF_SUPPLIED_V70_ET, (LSI_IEF_SUPPLIED_V70_ET) =>
               {
                   LSI_IEF_SUPPLIED_V70_ET.CreateNewField(Names.LSI_NVR_L26_CNT_70MS, FieldType.String, 1);

                   IField LSI_NVR_L26_CNT_70_local = LSI_IEF_SUPPLIED_V70_ET.CreateNewField(Names.LSI_NVR_L26_CNT_70, FieldType.SignedNumeric, 9);
                   LSI_IEF_SUPPLIED_V70_ET.CreateNewFieldRedefine(Names.LSI_NVR_L26_CNT_70XX, FieldType.String, LSI_NVR_L26_CNT_70_local, 9);
               });
           });

            recordDef.CreateNewGroup(Names.LSI_27_CURRENT_V71, (LSI_27_CURRENT_V71) =>
           {
               LSI_27_CURRENT_V71.CreateNewGroup(Names.LSI_IEF_SUPPLIED_V71_ET, (LSI_IEF_SUPPLIED_V71_ET) =>
               {
                   LSI_IEF_SUPPLIED_V71_ET.CreateNewField(Names.LSI_CUR_L27_CNT_71MS, FieldType.String, 1);

                   IField LSI_CUR_L27_CNT_71_local = LSI_IEF_SUPPLIED_V71_ET.CreateNewField(Names.LSI_CUR_L27_CNT_71, FieldType.SignedNumeric, 9);
                   LSI_IEF_SUPPLIED_V71_ET.CreateNewFieldRedefine(Names.LSI_CUR_L27_CNT_71XX, FieldType.String, LSI_CUR_L27_CNT_71_local, 9);
               });
           });

            recordDef.CreateNewGroup(Names.LSI_27_FORMER_V72, (LSI_27_FORMER_V72) =>
           {
               LSI_27_FORMER_V72.CreateNewGroup(Names.LSI_IEF_SUPPLIED_V72_ET, (LSI_IEF_SUPPLIED_V72_ET) =>
               {
                   LSI_IEF_SUPPLIED_V72_ET.CreateNewField(Names.LSI_FMR_L27_CNT_72MS, FieldType.String, 1);

                   IField LSI_FMR_L27_CNT_72_local = LSI_IEF_SUPPLIED_V72_ET.CreateNewField(Names.LSI_FMR_L27_CNT_72, FieldType.SignedNumeric, 9);
                   LSI_IEF_SUPPLIED_V72_ET.CreateNewFieldRedefine(Names.LSI_FMR_L27_CNT_72XX, FieldType.String, LSI_FMR_L27_CNT_72_local, 9);
               });
           });

            recordDef.CreateNewGroup(Names.LSI_27_NEVER_V73, (LSI_27_NEVER_V73) =>
           {
               LSI_27_NEVER_V73.CreateNewGroup(Names.LSI_IEF_SUPPLIED_V73_ET, (LSI_IEF_SUPPLIED_V73_ET) =>
               {
                   LSI_IEF_SUPPLIED_V73_ET.CreateNewField(Names.LSI_NVR_L27_CNT_73MS, FieldType.String, 1);

                   IField LSI_NVR_L27_CNT_73_local = LSI_IEF_SUPPLIED_V73_ET.CreateNewField(Names.LSI_NVR_L27_CNT_73, FieldType.SignedNumeric, 9);
                   LSI_IEF_SUPPLIED_V73_ET.CreateNewFieldRedefine(Names.LSI_NVR_L27_CNT_73XX, FieldType.String, LSI_NVR_L27_CNT_73_local, 9);
               });
           });

            recordDef.CreateNewGroup(Names.LSI_28_TOTAL_V74, (LSI_28_TOTAL_V74) =>
           {
               LSI_28_TOTAL_V74.CreateNewGroup(Names.LSI_IEF_SUPPLIED_V74_ET, (LSI_IEF_SUPPLIED_V74_ET) =>
               {
                   LSI_IEF_SUPPLIED_V74_ET.CreateNewField(Names.LSI_TOT_L28_CNT_74MS, FieldType.String, 1);

                   IField LSI_TOT_L28_CNT_74_local = LSI_IEF_SUPPLIED_V74_ET.CreateNewField(Names.LSI_TOT_L28_CNT_74, FieldType.SignedNumeric, 9);
                   LSI_IEF_SUPPLIED_V74_ET.CreateNewFieldRedefine(Names.LSI_TOT_L28_CNT_74XX, FieldType.String, LSI_TOT_L28_CNT_74_local, 9);
               });
           });

            recordDef.CreateNewGroup(Names.LSI_29_TOTAL_V75, (LSI_29_TOTAL_V75) =>
           {
               LSI_29_TOTAL_V75.CreateNewGroup(Names.LSI_IEF_SUPPLIED_V75_ET, (LSI_IEF_SUPPLIED_V75_ET) =>
               {
                   LSI_IEF_SUPPLIED_V75_ET.CreateNewField(Names.LSI_TOT_L29_CNT_75MS, FieldType.String, 1);

                   IField LSI_TOT_L29_CNT_75_local = LSI_IEF_SUPPLIED_V75_ET.CreateNewField(Names.LSI_TOT_L29_CNT_75, FieldType.SignedNumeric, 9);
                   LSI_IEF_SUPPLIED_V75_ET.CreateNewFieldRedefine(Names.LSI_TOT_L29_CNT_75XX, FieldType.String, LSI_TOT_L29_CNT_75_local, 9);
               });
           });

            recordDef.CreateNewGroup(Names.LSI_30_TOTAL_V76, (LSI_30_TOTAL_V76) =>
           {
               LSI_30_TOTAL_V76.CreateNewGroup(Names.LSI_IEF_SUPPLIED_V76_ET, (LSI_IEF_SUPPLIED_V76_ET) =>
               {
                   LSI_IEF_SUPPLIED_V76_ET.CreateNewField(Names.LSI_TOT_L30_CNT_76MS, FieldType.String, 1);

                   IField LSI_TOT_L30_CNT_76_local = LSI_IEF_SUPPLIED_V76_ET.CreateNewField(Names.LSI_TOT_L30_CNT_76, FieldType.SignedNumeric, 9);
                   LSI_IEF_SUPPLIED_V76_ET.CreateNewFieldRedefine(Names.LSI_TOT_L30_CNT_76XX, FieldType.String, LSI_TOT_L30_CNT_76_local, 9);
               });
           });

            recordDef.CreateNewGroup(Names.LSI_31_TOTAL_V77, (LSI_31_TOTAL_V77) =>
           {
               LSI_31_TOTAL_V77.CreateNewGroup(Names.LSI_IEF_SUPPLIED_V77_ET, (LSI_IEF_SUPPLIED_V77_ET) =>
               {
                   LSI_IEF_SUPPLIED_V77_ET.CreateNewField(Names.LSI_TOT_L31_CNT_77MS, FieldType.String, 1);

                   IField LSI_TOT_L31_CNT_77_local = LSI_IEF_SUPPLIED_V77_ET.CreateNewField(Names.LSI_TOT_L31_CNT_77, FieldType.SignedNumeric, 9);
                   LSI_IEF_SUPPLIED_V77_ET.CreateNewFieldRedefine(Names.LSI_TOT_L31_CNT_77XX, FieldType.String, LSI_TOT_L31_CNT_77_local, 9);
               });
           });

            recordDef.CreateNewGroup(Names.LSI_32_TOTAL_V78, (LSI_32_TOTAL_V78) =>
           {
               LSI_32_TOTAL_V78.CreateNewGroup(Names.LSI_IEF_SUPPLIED_V78_ET, (LSI_IEF_SUPPLIED_V78_ET) =>
               {
                   LSI_IEF_SUPPLIED_V78_ET.CreateNewField(Names.LSI_TOT_L32_CNT_78MS, FieldType.String, 1);

                   IField LSI_TOT_L32_CNT_78_local = LSI_IEF_SUPPLIED_V78_ET.CreateNewField(Names.LSI_TOT_L32_CNT_78, FieldType.SignedNumeric, 9);
                   LSI_IEF_SUPPLIED_V78_ET.CreateNewFieldRedefine(Names.LSI_TOT_L32_CNT_78XX, FieldType.String, LSI_TOT_L32_CNT_78_local, 9);
               });
           });

            recordDef.CreateNewGroup(Names.LSI_38_CURRENT_V79, (LSI_38_CURRENT_V79) =>
           {
               LSI_38_CURRENT_V79.CreateNewGroup(Names.LSI_IEF_SUPPLIED_V79_ET, (LSI_IEF_SUPPLIED_V79_ET) =>
               {
                   LSI_IEF_SUPPLIED_V79_ET.CreateNewField(Names.LSI_CUR_L38_CNT_79MS, FieldType.String, 1);

                   IField LSI_CUR_L38_CNT_79_local = LSI_IEF_SUPPLIED_V79_ET.CreateNewField(Names.LSI_CUR_L38_CNT_79, FieldType.SignedNumeric, 9);
                   LSI_IEF_SUPPLIED_V79_ET.CreateNewFieldRedefine(Names.LSI_CUR_L38_CNT_79XX, FieldType.String, LSI_CUR_L38_CNT_79_local, 9);
               });
           });

            recordDef.CreateNewGroup(Names.LSI_39_CURRENT_V80, (LSI_39_CURRENT_V80) =>
           {
               LSI_39_CURRENT_V80.CreateNewGroup(Names.LSI_IEF_SUPPLIED_V80_ET, (LSI_IEF_SUPPLIED_V80_ET) =>
               {
                   LSI_IEF_SUPPLIED_V80_ET.CreateNewField(Names.LSI_CUR_L39_CNT_80MS, FieldType.String, 1);

                   IField LSI_CUR_L39_CNT_80_local = LSI_IEF_SUPPLIED_V80_ET.CreateNewField(Names.LSI_CUR_L39_CNT_80, FieldType.SignedNumeric, 9);
                   LSI_IEF_SUPPLIED_V80_ET.CreateNewFieldRedefine(Names.LSI_CUR_L39_CNT_80XX, FieldType.String, LSI_CUR_L39_CNT_80_local, 9);
               });
           });

            recordDef.CreateNewGroup(Names.LSI_40_TOTAL_V81, (LSI_40_TOTAL_V81) =>
           {
               LSI_40_TOTAL_V81.CreateNewGroup(Names.LSI_IEF_SUPPLIED_V81_ET, (LSI_IEF_SUPPLIED_V81_ET) =>
               {
                   LSI_IEF_SUPPLIED_V81_ET.CreateNewField(Names.LSI_TOT_L40_CNT_81MS, FieldType.String, 1);

                   IField LSI_TOT_L40_CNT_81_local = LSI_IEF_SUPPLIED_V81_ET.CreateNewField(Names.LSI_TOT_L40_CNT_81, FieldType.SignedNumeric, 9);
                   LSI_IEF_SUPPLIED_V81_ET.CreateNewFieldRedefine(Names.LSI_TOT_L40_CNT_81XX, FieldType.String, LSI_TOT_L40_CNT_81_local, 9);
               });
           });

            recordDef.CreateNewGroup(Names.LSI_41_TOTAL_V82, (LSI_41_TOTAL_V82) =>
           {
               LSI_41_TOTAL_V82.CreateNewGroup(Names.LSI_IEF_SUPPLIED_V82_ET, (LSI_IEF_SUPPLIED_V82_ET) =>
               {
                   LSI_IEF_SUPPLIED_V82_ET.CreateNewField(Names.LSI_TOT_L41_CNT_82MS, FieldType.String, 1);

                   IField LSI_TOT_L41_CNT_82_local = LSI_IEF_SUPPLIED_V82_ET.CreateNewField(Names.LSI_TOT_L41_CNT_82, FieldType.SignedNumeric, 9);
                   LSI_IEF_SUPPLIED_V82_ET.CreateNewFieldRedefine(Names.LSI_TOT_L41_CNT_82XX, FieldType.String, LSI_TOT_L41_CNT_82_local, 9);
               });
           });

            recordDef.CreateNewGroup(Names.LSI_42_TOTAL_V83, (LSI_42_TOTAL_V83) =>
           {
               LSI_42_TOTAL_V83.CreateNewGroup(Names.LSI_IEF_SUPPLIED_V83_ET, (LSI_IEF_SUPPLIED_V83_ET) =>
               {
                   LSI_IEF_SUPPLIED_V83_ET.CreateNewField(Names.LSI_TOT_L42_CNT_83MS, FieldType.String, 1);

                   IField LSI_TOT_L42_CNT_83_local = LSI_IEF_SUPPLIED_V83_ET.CreateNewField(Names.LSI_TOT_L42_CNT_83, FieldType.SignedNumeric, 9);
                   LSI_IEF_SUPPLIED_V83_ET.CreateNewFieldRedefine(Names.LSI_TOT_L42_CNT_83XX, FieldType.String, LSI_TOT_L42_CNT_83_local, 9);
               });
           });

            recordDef.CreateNewGroup(Names.LSI_V84, (LSI_V84) =>
           {
               LSI_V84.CreateNewGroup(Names.LSI_REPORT_PARMS_V84_ET, (LSI_REPORT_PARMS_V84_ET) =>
               {
                   LSI_REPORT_PARMS_V84_ET.CreateNewField(Names.LSI_PARM1_84MS, FieldType.String, 1);

                   IField LSI_PARM1_84_local = LSI_REPORT_PARMS_V84_ET.CreateNewField(Names.LSI_PARM1_84, FieldType.String, 2);
                   LSI_REPORT_PARMS_V84_ET.CreateNewFieldRedefine(Names.LSI_PARM1_84XX, FieldType.String, LSI_PARM1_84_local, 2);
                   LSI_REPORT_PARMS_V84_ET.CreateNewFieldRedefine(Names.IO_CONTROL_CD, FieldType.String, LSI_PARM1_84_local, 2);
                   LSI_REPORT_PARMS_V84_ET.CreateNewField(Names.LSI_PARM2_85MS, FieldType.String, 1);

                   IField LSI_PARM2_85_local = LSI_REPORT_PARMS_V84_ET.CreateNewField(Names.LSI_PARM2_85, FieldType.String, 2);
                   LSI_REPORT_PARMS_V84_ET.CreateNewFieldRedefine(Names.LSI_PARM2_85XX, FieldType.String, LSI_PARM2_85_local, 2);
                   LSI_REPORT_PARMS_V84_ET.CreateNewGroupRedefine(Names.LS_RUNTIME_RPT_TYPE_CD, LSI_PARM2_85_local, (LS_RUNTIME_RPT_TYPE_CD) =>
                   {
                       LS_RUNTIME_RPT_TYPE_CD.CreateNewField(Names.LSI_PARM2_1, FieldType.String, 1);
                       LS_RUNTIME_RPT_TYPE_CD.CreateNewField(Names.LSI_PARM2_2, FieldType.String, 1);
                   });
                   LSI_REPORT_PARMS_V84_ET.CreateNewField(Names.LSI_SUBRPT_CD_86MS, FieldType.String, 1);

                   IField LSI_SUBRPT_CD_86_local = LSI_REPORT_PARMS_V84_ET.CreateNewField(Names.LSI_SUBRPT_CD_86, FieldType.String, 4);
                   LSI_REPORT_PARMS_V84_ET.CreateNewFieldRedefine(Names.LSI_SUBRPT_CD_86XX, FieldType.String, LSI_SUBRPT_CD_86_local, 4);
               });
           });

            recordDef.CreateNewGroup(Names.LSE_V85, (LSE_V85) =>
           {
               LSE_V85.CreateNewGroup(Names.LSE_REPORT_PARMS_ET, (LSE_REPORT_PARMS_ET) =>
               {
                   LSE_REPORT_PARMS_ET.CreateNewField(Names.LSE_PARM1_87MS, FieldType.String, 1);

                   IField LSE_PARM1_87_local = LSE_REPORT_PARMS_ET.CreateNewField(Names.LSE_PARM1_87, FieldType.String, 2);
                   LSE_REPORT_PARMS_ET.CreateNewFieldRedefine(Names.LSE_PARM1_87XX, FieldType.String, LSE_PARM1_87_local, 2);
                   LSE_REPORT_PARMS_ET.CreateNewFieldRedefine(Names.LS_RETURN_CD, FieldType.String, LSE_PARM1_87_local, 2);
                   LSE_REPORT_PARMS_ET.CreateNewField(Names.LSE_PARM2_88MS, FieldType.String, 1);

                   IField LSE_PARM2_88_local = LSE_REPORT_PARMS_ET.CreateNewField(Names.LSE_PARM2_88, FieldType.String, 2);
                   LSE_REPORT_PARMS_ET.CreateNewFieldRedefine(Names.LSE_PARM2_88XX, FieldType.String, LSE_PARM2_88_local, 2);
                   LSE_REPORT_PARMS_ET.CreateNewField(Names.LSE_SUBRPT_CD_89MS, FieldType.String, 1);

                   IField LSE_SUBRPT_CD_89_local = LSE_REPORT_PARMS_ET.CreateNewField(Names.LSE_SUBRPT_CD_89, FieldType.String, 4);
                   LSE_REPORT_PARMS_ET.CreateNewFieldRedefine(Names.LSE_SUBRPT_CD_89XX, FieldType.String, LSE_SUBRPT_CD_89_local, 4);
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
            SetPassedParm(LSI_1_CURRENT_V1, args, 3);
            SetPassedParm(LSI_1_FORMER_V2, args, 4);
            SetPassedParm(LSI_1_NEVER_V3, args, 5);
            SetPassedParm(LSI_1A_CURRENT_V4, args, 6);
            SetPassedParm(LSI_1A_FORMER_V5, args, 7);
            SetPassedParm(LSI_1A_NEVER_V6, args, 8);
            SetPassedParm(LSI_1B_CURRENT_V7, args, 9);
            SetPassedParm(LSI_1B_FORMER_V8, args, 10);
            SetPassedParm(LSI_1B_NEVER_V9, args, 11);
            SetPassedParm(LSI_1C_NEVER_V10, args, 12);
            SetPassedParm(LSI_2_CURRENT_V11, args, 13);
            SetPassedParm(LSI_2_FORMER_V12, args, 14);
            SetPassedParm(LSI_2_NEVER_V13, args, 15);
            SetPassedParm(LSI_2A_CURRENT_V14, args, 16);
            SetPassedParm(LSI_2A_FORMER_V15, args, 17);
            SetPassedParm(LSI_2A_NEVER_V16, args, 18);
            SetPassedParm(LSI_2B_CURRENT_V17, args, 19);
            SetPassedParm(LSI_2B_FORMER_V18, args, 20);
            SetPassedParm(LSI_2B_NEVER_V19, args, 21);
            SetPassedParm(LSI_2C_CURRENT_V20, args, 22);
            SetPassedParm(LSI_2C_FORMER_V21, args, 23);
            SetPassedParm(LSI_2C_NEVER_V22, args, 24);
            SetPassedParm(LSI_2D_NEVER_V23, args, 25);
            SetPassedParm(LSI_3_CURRENT_V24, args, 26);
            SetPassedParm(LSI_3_FORMER_V25, args, 27);
            SetPassedParm(LSI_3_NEVER_V26, args, 28);
            SetPassedParm(LSI_4_TOTAL_V27, args, 29);
            SetPassedParm(LSI_5_TOTAL_V28, args, 30);
            SetPassedParm(LSI_6_TOTAL_V29, args, 31);
            SetPassedParm(LSI_7_TOTAL_V30, args, 32);
            SetPassedParm(LSI_8_TOTAL_V31, args, 33);
            SetPassedParm(LSI_9_TOTAL_V32, args, 34);
            SetPassedParm(LSI_10_TOTAL_V33, args, 35);
            SetPassedParm(LSI_12_CURRENT_V34, args, 36);
            SetPassedParm(LSI_12_FORMER_V35, args, 37);
            SetPassedParm(LSI_12_NEVER_V36, args, 38);
            SetPassedParm(LSI_13_CURRENT_V37, args, 39);
            SetPassedParm(LSI_13_FORMER_V38, args, 40);
            SetPassedParm(LSI_13_NEVER_V39, args, 41);
            SetPassedParm(LSI_14_TOTAL_V40, args, 42);
            SetPassedParm(LSI_16_CURRENT_V41, args, 43);
            SetPassedParm(LSI_16_FORMER_V42, args, 44);
            SetPassedParm(LSI_16_NEVER_V43, args, 45);
            SetPassedParm(LSI_17_CURRENT_V44, args, 46);
            SetPassedParm(LSI_17_FORMER_V45, args, 47);
            SetPassedParm(LSI_17_NEVER_V46, args, 48);
            SetPassedParm(LSI_18_CURRENT_V47, args, 49);
            SetPassedParm(LSI_18_FORMER_V48, args, 50);
            SetPassedParm(LSI_18_NEVER_V49, args, 51);
            SetPassedParm(LSI_18A_CURRENT_V50, args, 52);
            SetPassedParm(LSI_18A_FORMER_V51, args, 53);
            SetPassedParm(LSI_18A_NEVER_V52, args, 54);
            SetPassedParm(LSI_19_CURRENT_V53, args, 55);
            SetPassedParm(LSI_19_FORMER_V54, args, 56);
            SetPassedParm(LSI_19_NEVER_V55, args, 57);
            SetPassedParm(LSI_20_CURRENT_V56, args, 58);
            SetPassedParm(LSI_20_FORMER_V57, args, 59);
            SetPassedParm(LSI_20_NEVER_V58, args, 60);
            SetPassedParm(LSI_21_TOTAL_V59, args, 61);
            SetPassedParm(LSI_22_TOTAL_V60, args, 62);
            SetPassedParm(LSI_23_TOTAL_V61, args, 63);
            SetPassedParm(LSI_24_CURRENT_V62, args, 64);
            SetPassedParm(LSI_24_FORMER_V63, args, 65);
            SetPassedParm(LSI_24_NEVER_V64, args, 66);
            SetPassedParm(LSI_25_CURRENT_V65, args, 67);
            SetPassedParm(LSI_25_FORMER_V66, args, 68);
            SetPassedParm(LSI_25_NEVER_V67, args, 69);
            SetPassedParm(LSI_26_CURRENT_V68, args, 70);
            SetPassedParm(LSI_26_FORMER_V69, args, 71);
            SetPassedParm(LSI_26_NEVER_V70, args, 72);
            SetPassedParm(LSI_27_CURRENT_V71, args, 73);
            SetPassedParm(LSI_27_FORMER_V72, args, 74);
            SetPassedParm(LSI_27_NEVER_V73, args, 75);
            SetPassedParm(LSI_28_TOTAL_V74, args, 76);
            SetPassedParm(LSI_29_TOTAL_V75, args, 77);
            SetPassedParm(LSI_30_TOTAL_V76, args, 78);
            SetPassedParm(LSI_31_TOTAL_V77, args, 79);
            SetPassedParm(LSI_32_TOTAL_V78, args, 80);
            SetPassedParm(LSI_38_CURRENT_V79, args, 81);
            SetPassedParm(LSI_39_CURRENT_V80, args, 82);
            SetPassedParm(LSI_40_TOTAL_V81, args, 83);
            SetPassedParm(LSI_41_TOTAL_V82, args, 84);
            SetPassedParm(LSI_42_TOTAL_V83, args, 85);
            SetPassedParm(LSI_V84, args, 86);
            SetPassedParm(LSE_V85, args, 87);
        }


        public void UpdateReturnParameters(object[] args)
        {
            SetReturnParm(TI_RUNTIME_PARM1, args, 0);
            SetReturnParm(TI_RUNTIME_PARM2, args, 1);
            SetReturnParm(GLOBDATA, args, 2);
            SetReturnParm(LSI_1_CURRENT_V1, args, 3);
            SetReturnParm(LSI_1_FORMER_V2, args, 4);
            SetReturnParm(LSI_1_NEVER_V3, args, 5);
            SetReturnParm(LSI_1A_CURRENT_V4, args, 6);
            SetReturnParm(LSI_1A_FORMER_V5, args, 7);
            SetReturnParm(LSI_1A_NEVER_V6, args, 8);
            SetReturnParm(LSI_1B_CURRENT_V7, args, 9);
            SetReturnParm(LSI_1B_FORMER_V8, args, 10);
            SetReturnParm(LSI_1B_NEVER_V9, args, 11);
            SetReturnParm(LSI_1C_NEVER_V10, args, 12);
            SetReturnParm(LSI_2_CURRENT_V11, args, 13);
            SetReturnParm(LSI_2_FORMER_V12, args, 14);
            SetReturnParm(LSI_2_NEVER_V13, args, 15);
            SetReturnParm(LSI_2A_CURRENT_V14, args, 16);
            SetReturnParm(LSI_2A_FORMER_V15, args, 17);
            SetReturnParm(LSI_2A_NEVER_V16, args, 18);
            SetReturnParm(LSI_2B_CURRENT_V17, args, 19);
            SetReturnParm(LSI_2B_FORMER_V18, args, 20);
            SetReturnParm(LSI_2B_NEVER_V19, args, 21);
            SetReturnParm(LSI_2C_CURRENT_V20, args, 22);
            SetReturnParm(LSI_2C_FORMER_V21, args, 23);
            SetReturnParm(LSI_2C_NEVER_V22, args, 24);
            SetReturnParm(LSI_2D_NEVER_V23, args, 25);
            SetReturnParm(LSI_3_CURRENT_V24, args, 26);
            SetReturnParm(LSI_3_FORMER_V25, args, 27);
            SetReturnParm(LSI_3_NEVER_V26, args, 28);
            SetReturnParm(LSI_4_TOTAL_V27, args, 29);
            SetReturnParm(LSI_5_TOTAL_V28, args, 30);
            SetReturnParm(LSI_6_TOTAL_V29, args, 31);
            SetReturnParm(LSI_7_TOTAL_V30, args, 32);
            SetReturnParm(LSI_8_TOTAL_V31, args, 33);
            SetReturnParm(LSI_9_TOTAL_V32, args, 34);
            SetReturnParm(LSI_10_TOTAL_V33, args, 35);
            SetReturnParm(LSI_12_CURRENT_V34, args, 36);
            SetReturnParm(LSI_12_FORMER_V35, args, 37);
            SetReturnParm(LSI_12_NEVER_V36, args, 38);
            SetReturnParm(LSI_13_CURRENT_V37, args, 39);
            SetReturnParm(LSI_13_FORMER_V38, args, 40);
            SetReturnParm(LSI_13_NEVER_V39, args, 41);
            SetReturnParm(LSI_14_TOTAL_V40, args, 42);
            SetReturnParm(LSI_16_CURRENT_V41, args, 43);
            SetReturnParm(LSI_16_FORMER_V42, args, 44);
            SetReturnParm(LSI_16_NEVER_V43, args, 45);
            SetReturnParm(LSI_17_CURRENT_V44, args, 46);
            SetReturnParm(LSI_17_FORMER_V45, args, 47);
            SetReturnParm(LSI_17_NEVER_V46, args, 48);
            SetReturnParm(LSI_18_CURRENT_V47, args, 49);
            SetReturnParm(LSI_18_FORMER_V48, args, 50);
            SetReturnParm(LSI_18_NEVER_V49, args, 51);
            SetReturnParm(LSI_18A_CURRENT_V50, args, 52);
            SetReturnParm(LSI_18A_FORMER_V51, args, 53);
            SetReturnParm(LSI_18A_NEVER_V52, args, 54);
            SetReturnParm(LSI_19_CURRENT_V53, args, 55);
            SetReturnParm(LSI_19_FORMER_V54, args, 56);
            SetReturnParm(LSI_19_NEVER_V55, args, 57);
            SetReturnParm(LSI_20_CURRENT_V56, args, 58);
            SetReturnParm(LSI_20_FORMER_V57, args, 59);
            SetReturnParm(LSI_20_NEVER_V58, args, 60);
            SetReturnParm(LSI_21_TOTAL_V59, args, 61);
            SetReturnParm(LSI_22_TOTAL_V60, args, 62);
            SetReturnParm(LSI_23_TOTAL_V61, args, 63);
            SetReturnParm(LSI_24_CURRENT_V62, args, 64);
            SetReturnParm(LSI_24_FORMER_V63, args, 65);
            SetReturnParm(LSI_24_NEVER_V64, args, 66);
            SetReturnParm(LSI_25_CURRENT_V65, args, 67);
            SetReturnParm(LSI_25_FORMER_V66, args, 68);
            SetReturnParm(LSI_25_NEVER_V67, args, 69);
            SetReturnParm(LSI_26_CURRENT_V68, args, 70);
            SetReturnParm(LSI_26_FORMER_V69, args, 71);
            SetReturnParm(LSI_26_NEVER_V70, args, 72);
            SetReturnParm(LSI_27_CURRENT_V71, args, 73);
            SetReturnParm(LSI_27_FORMER_V72, args, 74);
            SetReturnParm(LSI_27_NEVER_V73, args, 75);
            SetReturnParm(LSI_28_TOTAL_V74, args, 76);
            SetReturnParm(LSI_29_TOTAL_V75, args, 77);
            SetReturnParm(LSI_30_TOTAL_V76, args, 78);
            SetReturnParm(LSI_31_TOTAL_V77, args, 79);
            SetReturnParm(LSI_32_TOTAL_V78, args, 80);
            SetReturnParm(LSI_38_CURRENT_V79, args, 81);
            SetReturnParm(LSI_39_CURRENT_V80, args, 82);
            SetReturnParm(LSI_40_TOTAL_V81, args, 83);
            SetReturnParm(LSI_41_TOTAL_V82, args, 84);
            SetReturnParm(LSI_42_TOTAL_V83, args, 85);
            SetReturnParm(LSI_V84, args, 86);
            SetReturnParm(LSE_V85, args, 87);
        }
    }
    #endregion Linkage Section Class

    #region Business Logic Class
    public class SWEXF710 : EABBase
    {

        #region Public Constructors
        public SWEXF710()
            : base()
        {
            this.ProgramName.SetValue("SWEXF710");

            WS = new SWEXF710_ws();
            FD = new SWEXF710_fd(WS);
            LS = new SWEXF710_ls();
        }

        #endregion

        #region Private Fields


        //==== Working Storage Data Class ========================================
        private SWEXF710_ws WS;

        //==== File Data Class ========================================
        private SWEXF710_fd FD;

        //==== Linkage Section Data Class ========================================
        private SWEXF710_ls LS;
        #endregion

        #region Public Methods
        //========================================================================
        //==== RunMain Entry Point Method ========================================
        //========================================================================
        public override int ExecuteMain(params object[] args)                                              //COBOL==> PROCEDURE DIVISION USING TI-RUNTIME-PARM1 , TI-RUNTIME-PARM2 , GLOBDATA , LSI-1-CURRENT-V1 , LSI-1-FORMER-V2 , LSI-1-NEVER-V3 , LSI-1A-CURRENT-V4 , LSI-1A-FORMER-V5 , LSI-1A-NEVER-V6 , LSI-1B-CURRENT-V7 , LSI-1B-FORMER-V8 , LSI-1B-NEVER-V9 , LSI-1C-NEVER-V10 , LSI-2-CURRENT-V11 , LSI-2-FORMER-V12 , LSI-2-NEVER-V13 , LSI-2A-CURRENT-V14 , LSI-2A-FORMER-V15 , LSI-2A-NEVER-V16 , LSI-2B-CURRENT-V17 , LSI-2B-FORMER-V18 , LSI-2B-NEVER-V19 , LSI-2C-CURRENT-V20 , LSI-2C-FORMER-V21 , LSI-2C-NEVER-V22 , LSI-2D-NEVER-V23 , LSI-3-CURRENT-V24 , LSI-3-FORMER-V25 , LSI-3-NEVER-V26 , LSI-4-TOTAL-V27 , LSI-5-TOTAL-V28 , LSI-6-TOTAL-V29 , LSI-7-TOTAL-V30 , LSI-8-TOTAL-V31 , LSI-9-TOTAL-V32 , LSI-10-TOTAL-V33 , LSI-12-CURRENT-V34 , LSI-12-FORMER-V35 , LSI-12-NEVER-V36 , LSI-13-CURRENT-V37 , LSI-13-FORMER-V38 , LSI-13-NEVER-V39 , LSI-14-TOTAL-V40 , LSI-16-CURRENT-V41 , LSI-16-FORMER-V42 , LSI-16-NEVER-V43 , LSI-17-CURRENT-V44 , LSI-17-FORMER-V45 , LSI-17-NEVER-V46 , LSI-18-CURRENT-V47 , LSI-18-FORMER-V48 , LSI-18-NEVER-V49 , LSI-18A-CURRENT-V50 , LSI-18A-FORMER-V51 , LSI-18A-NEVER-V52 , LSI-19-CURRENT-V53 , LSI-19-FORMER-V54 , LSI-19-NEVER-V55 , LSI-20-CURRENT-V56 , LSI-20-FORMER-V57 , LSI-20-NEVER-V58 , LSI-21-TOTAL-V59 , LSI-22-TOTAL-V60 , LSI-23-TOTAL-V61 , LSI-24-CURRENT-V62 , LSI-24-FORMER-V63 , LSI-24-NEVER-V64 , LSI-25-CURRENT-V65 , LSI-25-FORMER-V66 , LSI-25-NEVER-V67 , LSI-26-CURRENT-V68 , LSI-26-FORMER-V69 , LSI-26-NEVER-V70 , LSI-27-CURRENT-V71 , LSI-27-FORMER-V72 , LSI-27-NEVER-V73 , LSI-28-TOTAL-V74 , LSI-29-TOTAL-V75 , LSI-30-TOTAL-V76 , LSI-31-TOTAL-V77 , LSI-32-TOTAL-V78 , LSI-38-CURRENT-V79 , LSI-39-CURRENT-V80 , LSI-40-TOTAL-V81 , LSI-41-TOTAL-V82 , LSI-42-TOTAL-V83 , LSI-V84 , LSE-V85.
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
            M_MAIN_LINE(returnMethod);
        }
        /// <summary>
        /// Method M_MAIN_LINE
        /// </summary>
        private void M_MAIN_LINE(string returnMethod = "")
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
        /// Method M_MAIN_LINE_EXIT
        /// </summary>
        private void M_MAIN_LINE_EXIT(string returnMethod = "")
        {
            if (returnMethod == "M_MAIN_LINE_EXIT") { return; }                                                 //COBOL==> EXIT.
            if (returnMethod != "" && returnMethod != "M_MAIN_LINE_EXIT") { M_B000_INIT_FIELDS(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_B000_INIT_FIELDS
        /// </summary>
        private void M_B000_INIT_FIELDS(string returnMethod = "")
        {
            if (!(LS.LSI_CUR_L1_CNT_01.IsNumericValue()))                                                      //COBOL==> IF LSI-CUR-L1-CNT-01 IS NOT NUMERIC
            {
                LS.LSI_CUR_L1_CNT_01.SetValueWithZeroes();                                                          //COBOL==> MOVE ZEROS TO LSI-CUR-L1-CNT-01
            }                                                                                                   //COBOL==> END-IF.
            if (!(LS.LSI_FMR_L1_CNT_02.IsNumericValue()))                                                      //COBOL==> IF LSI-FMR-L1-CNT-02 IS NOT NUMERIC
            {
                LS.LSI_FMR_L1_CNT_02.SetValueWithZeroes();                                                          //COBOL==> MOVE ZEROS TO LSI-FMR-L1-CNT-02
            }                                                                                                   //COBOL==> END-IF.
            if (!(LS.LSI_NVR_L1_CNT_03.IsNumericValue()))                                                      //COBOL==> IF LSI-NVR-L1-CNT-03 IS NOT NUMERIC
            {
                LS.LSI_NVR_L1_CNT_03.SetValueWithZeroes();                                                          //COBOL==> MOVE ZEROS TO LSI-NVR-L1-CNT-03
            }                                                                                                   //COBOL==> END-IF.
            if (!(LS.LSI_CUR_L1A_CNT_04.IsNumericValue()))                                                     //COBOL==> IF LSI-CUR-L1A-CNT-04 IS NOT NUMERIC
            {
                LS.LSI_CUR_L1A_CNT_04.SetValueWithZeroes();                                                         //COBOL==> MOVE ZEROS TO LSI-CUR-L1A-CNT-04
            }                                                                                                   //COBOL==> END-IF.
            if (!(LS.LSI_FMR_L1A_CNT_05.IsNumericValue()))                                                     //COBOL==> IF LSI-FMR-L1A-CNT-05 IS NOT NUMERIC
            {
                LS.LSI_FMR_L1A_CNT_05.SetValueWithZeroes();                                                         //COBOL==> MOVE ZEROS TO LSI-FMR-L1A-CNT-05
            }                                                                                                   //COBOL==> END-IF.
            if (!(LS.LSI_NVR_L1A_CNT_06.IsNumericValue()))                                                     //COBOL==> IF LSI-NVR-L1A-CNT-06 IS NOT NUMERIC
            {
                LS.LSI_NVR_L1A_CNT_06.SetValueWithZeroes();                                                         //COBOL==> MOVE ZEROS TO LSI-NVR-L1A-CNT-06
            }                                                                                                   //COBOL==> END-IF.
            if (!(LS.LSI_CUR_L1B_CNT_07.IsNumericValue()))                                                     //COBOL==> IF LSI-CUR-L1B-CNT-07 IS NOT NUMERIC
            {
                LS.LSI_CUR_L1B_CNT_07.SetValueWithZeroes();                                                         //COBOL==> MOVE ZEROS TO LSI-CUR-L1B-CNT-07
            }                                                                                                   //COBOL==> END-IF.
            if (!(LS.LSI_FMR_L1B_CNT_08.IsNumericValue()))                                                     //COBOL==> IF LSI-FMR-L1B-CNT-08 IS NOT NUMERIC
            {
                LS.LSI_FMR_L1B_CNT_08.SetValueWithZeroes();                                                         //COBOL==> MOVE ZEROS TO LSI-FMR-L1B-CNT-08
            }                                                                                                   //COBOL==> END-IF.
            if (!(LS.LSI_NVR_L1B_CNT_09.IsNumericValue()))                                                     //COBOL==> IF LSI-NVR-L1B-CNT-09 IS NOT NUMERIC
            {
                LS.LSI_NVR_L1B_CNT_09.SetValueWithZeroes();                                                         //COBOL==> MOVE ZEROS TO LSI-NVR-L1B-CNT-09
            }                                                                                                   //COBOL==> END-IF.
            if (!(LS.LSI_NVR_L1C_CNT_10.IsNumericValue()))                                                     //COBOL==> IF LSI-NVR-L1C-CNT-10 IS NOT NUMERIC
            {
                LS.LSI_NVR_L1C_CNT_10.SetValueWithZeroes();                                                         //COBOL==> MOVE ZEROS TO LSI-NVR-L1C-CNT-10
            }                                                                                                   //COBOL==> END-IF.
            if (!(LS.LSI_CUR_L2_CNT_11.IsNumericValue()))                                                      //COBOL==> IF LSI-CUR-L2-CNT-11 IS NOT NUMERIC
            {
                LS.LSI_CUR_L2_CNT_11.SetValueWithZeroes();                                                          //COBOL==> MOVE ZEROS TO LSI-CUR-L2-CNT-11
            }                                                                                                   //COBOL==> END-IF.
            if (!(LS.LSI_FMR_L2_CNT_12.IsNumericValue()))                                                      //COBOL==> IF LSI-FMR-L2-CNT-12 IS NOT NUMERIC
            {
                LS.LSI_FMR_L2_CNT_12.SetValueWithZeroes();                                                          //COBOL==> MOVE ZEROS TO LSI-FMR-L2-CNT-12
            }                                                                                                   //COBOL==> END-IF.
            if (!(LS.LSI_NVR_L2_CNT_13.IsNumericValue()))                                                      //COBOL==> IF LSI-NVR-L2-CNT-13 IS NOT NUMERIC
            {
                LS.LSI_NVR_L2_CNT_13.SetValueWithZeroes();                                                          //COBOL==> MOVE ZEROS TO LSI-NVR-L2-CNT-13
            }                                                                                                   //COBOL==> END-IF.
            if (!(LS.LSI_CUR_L2A_CNT_14.IsNumericValue()))                                                     //COBOL==> IF LSI-CUR-L2A-CNT-14 IS NOT NUMERIC
            {
                LS.LSI_CUR_L2A_CNT_14.SetValueWithZeroes();                                                         //COBOL==> MOVE ZEROS TO LSI-CUR-L2A-CNT-14
            }                                                                                                   //COBOL==> END-IF.
            if (!(LS.LSI_FMR_L2A_CNT_15.IsNumericValue()))                                                     //COBOL==> IF LSI-FMR-L2A-CNT-15 IS NOT NUMERIC
            {
                LS.LSI_FMR_L2A_CNT_15.SetValueWithZeroes();                                                         //COBOL==> MOVE ZEROS TO LSI-FMR-L2A-CNT-15
            }                                                                                                   //COBOL==> END-IF.
            if (!(LS.LSI_NVR_L2A_CNT_16.IsNumericValue()))                                                     //COBOL==> IF LSI-NVR-L2A-CNT-16 IS NOT NUMERIC
            {
                LS.LSI_NVR_L2A_CNT_16.SetValueWithZeroes();                                                         //COBOL==> MOVE ZEROS TO LSI-NVR-L2A-CNT-16
            }                                                                                                   //COBOL==> END-IF.
            if (!(LS.LSI_CUR_L2B_CNT_17.IsNumericValue()))                                                     //COBOL==> IF LSI-CUR-L2B-CNT-17 IS NOT NUMERIC
            {
                LS.LSI_CUR_L2B_CNT_17.SetValueWithZeroes();                                                         //COBOL==> MOVE ZEROS TO LSI-CUR-L2B-CNT-17
            }                                                                                                   //COBOL==> END-IF.
            if (!(LS.LSI_FMR_L2B_CNT_18.IsNumericValue()))                                                     //COBOL==> IF LSI-FMR-L2B-CNT-18 IS NOT NUMERIC
            {
                LS.LSI_FMR_L2B_CNT_18.SetValueWithZeroes();                                                         //COBOL==> MOVE ZEROS TO LSI-FMR-L2B-CNT-18
            }                                                                                                   //COBOL==> END-IF.
            if (!(LS.LSI_NVR_L2B_CNT_19.IsNumericValue()))                                                     //COBOL==> IF LSI-NVR-L2B-CNT-19 IS NOT NUMERIC
            {
                LS.LSI_NVR_L2B_CNT_19.SetValueWithZeroes();                                                         //COBOL==> MOVE ZEROS TO LSI-NVR-L2B-CNT-19
            }                                                                                                   //COBOL==> END-IF.
            if (!(LS.LSI_CUR_L2C_CNT_20.IsNumericValue()))                                                     //COBOL==> IF LSI-CUR-L2C-CNT-20 IS NOT NUMERIC
            {
                LS.LSI_CUR_L2C_CNT_20.SetValueWithZeroes();                                                         //COBOL==> MOVE ZEROS TO LSI-CUR-L2C-CNT-20
            }                                                                                                   //COBOL==> END-IF.
            if (!(LS.LSI_FMR_L2C_CNT_21.IsNumericValue()))                                                     //COBOL==> IF LSI-FMR-L2C-CNT-21 IS NOT NUMERIC
            {
                LS.LSI_FMR_L2C_CNT_21.SetValueWithZeroes();                                                         //COBOL==> MOVE ZEROS TO LSI-FMR-L2C-CNT-21
            }                                                                                                   //COBOL==> END-IF.
            if (!(LS.LSI_NVR_L2C_CNT_22.IsNumericValue()))                                                     //COBOL==> IF LSI-NVR-L2C-CNT-22 IS NOT NUMERIC
            {
                LS.LSI_NVR_L2C_CNT_22.SetValueWithZeroes();                                                         //COBOL==> MOVE ZEROS TO LSI-NVR-L2C-CNT-22
            }                                                                                                   //COBOL==> END-IF.
            if (!(LS.LSI_NVR_L2D_CNT_23.IsNumericValue()))                                                     //COBOL==> IF LSI-NVR-L2D-CNT-23 IS NOT NUMERIC
            {
                LS.LSI_NVR_L2D_CNT_23.SetValueWithZeroes();                                                         //COBOL==> MOVE ZEROS TO LSI-NVR-L2D-CNT-23
            }                                                                                                   //COBOL==> END-IF.
            if (!(LS.LSI_CUR_L3_CNT_24.IsNumericValue()))                                                      //COBOL==> IF LSI-CUR-L3-CNT-24 IS NOT NUMERIC
            {
                LS.LSI_CUR_L3_CNT_24.SetValueWithZeroes();                                                          //COBOL==> MOVE ZEROS TO LSI-CUR-L3-CNT-24
            }                                                                                                   //COBOL==> END-IF.
            if (!(LS.LSI_FMR_L3_CNT_25.IsNumericValue()))                                                      //COBOL==> IF LSI-FMR-L3-CNT-25 IS NOT NUMERIC
            {
                LS.LSI_FMR_L3_CNT_25.SetValueWithZeroes();                                                          //COBOL==> MOVE ZEROS TO LSI-FMR-L3-CNT-25
            }                                                                                                   //COBOL==> END-IF.
            if (!(LS.LSI_NVR_L3_CNT_26.IsNumericValue()))                                                      //COBOL==> IF LSI-NVR-L3-CNT-26 IS NOT NUMERIC
            {
                LS.LSI_NVR_L3_CNT_26.SetValueWithZeroes();                                                          //COBOL==> MOVE ZEROS TO LSI-NVR-L3-CNT-26
            }                                                                                                   //COBOL==> END-IF.
            if (!(LS.LSI_TOT_L4_CNT_27.IsNumericValue()))                                                      //COBOL==> IF LSI-TOT-L4-CNT-27 IS NOT NUMERIC
            {
                LS.LSI_TOT_L4_CNT_27.SetValueWithZeroes();                                                          //COBOL==> MOVE ZEROS TO LSI-TOT-L4-CNT-27
            }                                                                                                   //COBOL==> END-IF.
            if (!(LS.LSI_TOT_L5_CNT_28.IsNumericValue()))                                                      //COBOL==> IF LSI-TOT-L5-CNT-28 IS NOT NUMERIC
            {
                LS.LSI_TOT_L5_CNT_28.SetValueWithZeroes();                                                          //COBOL==> MOVE ZEROS TO LSI-TOT-L5-CNT-28
            }                                                                                                   //COBOL==> END-IF.
            if (!(LS.LSI_TOT_L6_CNT_29.IsNumericValue()))                                                      //COBOL==> IF LSI-TOT-L6-CNT-29 IS NOT NUMERIC
            {
                LS.LSI_TOT_L6_CNT_29.SetValueWithZeroes();                                                          //COBOL==> MOVE ZEROS TO LSI-TOT-L6-CNT-29
            }                                                                                                   //COBOL==> END-IF.
            if (!(LS.LSI_TOT_L7_CNT_30.IsNumericValue()))                                                      //COBOL==> IF LSI-TOT-L7-CNT-30 IS NOT NUMERIC
            {
                LS.LSI_TOT_L7_CNT_30.SetValueWithZeroes();                                                          //COBOL==> MOVE ZEROS TO LSI-TOT-L7-CNT-30
            }                                                                                                   //COBOL==> END-IF.
            if (!(LS.LSI_TOT_L8_CNT_31.IsNumericValue()))                                                      //COBOL==> IF LSI-TOT-L8-CNT-31 IS NOT NUMERIC
            {
                LS.LSI_TOT_L8_CNT_31.SetValueWithZeroes();                                                          //COBOL==> MOVE ZEROS TO LSI-TOT-L8-CNT-31
            }                                                                                                   //COBOL==> END-IF.
            if (!(LS.LSI_TOT_L9_CNT_32.IsNumericValue()))                                                      //COBOL==> IF LSI-TOT-L9-CNT-32 IS NOT NUMERIC
            {
                LS.LSI_TOT_L9_CNT_32.SetValueWithZeroes();                                                          //COBOL==> MOVE ZEROS TO LSI-TOT-L9-CNT-32
            }                                                                                                   //COBOL==> END-IF.
            if (!(LS.LSI_TOT_L10_CNT_33.IsNumericValue()))                                                     //COBOL==> IF LSI-TOT-L10-CNT-33 IS NOT NUMERIC
            {
                LS.LSI_TOT_L10_CNT_33.SetValueWithZeroes();                                                         //COBOL==> MOVE ZEROS TO LSI-TOT-L10-CNT-33
            }                                                                                                   //COBOL==> END-IF.
            if (!(LS.LSI_CUR_L12_CNT_34.IsNumericValue()))                                                     //COBOL==> IF LSI-CUR-L12-CNT-34 IS NOT NUMERIC
            {
                LS.LSI_CUR_L12_CNT_34.SetValueWithZeroes();                                                         //COBOL==> MOVE ZEROS TO LSI-CUR-L12-CNT-34
            }                                                                                                   //COBOL==> END-IF.
            if (!(LS.LSI_FMR_L12_CNT_35.IsNumericValue()))                                                     //COBOL==> IF LSI-FMR-L12-CNT-35 IS NOT NUMERIC
            {
                LS.LSI_FMR_L12_CNT_35.SetValueWithZeroes();                                                         //COBOL==> MOVE ZEROS TO LSI-FMR-L12-CNT-35
            }                                                                                                   //COBOL==> END-IF.
            if (!(LS.LSI_NVR_L12_CNT_36.IsNumericValue()))                                                     //COBOL==> IF LSI-NVR-L12-CNT-36 IS NOT NUMERIC
            {
                LS.LSI_NVR_L12_CNT_36.SetValueWithZeroes();                                                         //COBOL==> MOVE ZEROS TO LSI-NVR-L12-CNT-36
            }                                                                                                   //COBOL==> END-IF.
            if (!(LS.LSI_CUR_L13_CNT_37.IsNumericValue()))                                                     //COBOL==> IF LSI-CUR-L13-CNT-37 IS NOT NUMERIC
            {
                LS.LSI_CUR_L13_CNT_37.SetValueWithZeroes();                                                         //COBOL==> MOVE ZEROS TO LSI-CUR-L13-CNT-37
            }                                                                                                   //COBOL==> END-IF.
            if (!(LS.LSI_FMR_L13_CNT_38.IsNumericValue()))                                                     //COBOL==> IF LSI-FMR-L13-CNT-38 IS NOT NUMERIC
            {
                LS.LSI_FMR_L13_CNT_38.SetValueWithZeroes();                                                         //COBOL==> MOVE ZEROS TO LSI-FMR-L13-CNT-38
            }                                                                                                   //COBOL==> END-IF.
            if (!(LS.LSI_NVR_L13_CNT_39.IsNumericValue()))                                                     //COBOL==> IF LSI-NVR-L13-CNT-39 IS NOT NUMERIC
            {
                LS.LSI_NVR_L13_CNT_39.SetValueWithZeroes();                                                         //COBOL==> MOVE ZEROS TO LSI-NVR-L13-CNT-39
            }                                                                                                   //COBOL==> END-IF.
            if (!(LS.LSI_TOT_L14_CNT_40.IsNumericValue()))                                                     //COBOL==> IF LSI-TOT-L14-CNT-40 IS NOT NUMERIC
            {
                LS.LSI_TOT_L14_CNT_40.SetValueWithZeroes();                                                         //COBOL==> MOVE ZEROS TO LSI-TOT-L14-CNT-40
            }                                                                                                   //COBOL==> END-IF.
            if (!(LS.LSI_CUR_L16_CNT_41.IsNumericValue()))                                                     //COBOL==> IF LSI-CUR-L16-CNT-41 IS NOT NUMERIC
            {
                LS.LSI_CUR_L16_CNT_41.SetValueWithZeroes();                                                         //COBOL==> MOVE ZEROS TO LSI-CUR-L16-CNT-41
            }                                                                                                   //COBOL==> END-IF.
            if (!(LS.LSI_FMR_L16_CNT_42.IsNumericValue()))                                                     //COBOL==> IF LSI-FMR-L16-CNT-42 IS NOT NUMERIC
            {
                LS.LSI_FMR_L16_CNT_42.SetValueWithZeroes();                                                         //COBOL==> MOVE ZEROS TO LSI-FMR-L16-CNT-42
            }                                                                                                   //COBOL==> END-IF.
            if (!(LS.LSI_NVR_L16_CNT_43.IsNumericValue()))                                                     //COBOL==> IF LSI-NVR-L16-CNT-43 IS NOT NUMERIC
            {
                LS.LSI_NVR_L16_CNT_43.SetValueWithZeroes();                                                         //COBOL==> MOVE ZEROS TO LSI-NVR-L16-CNT-43
            }                                                                                                   //COBOL==> END-IF.
            if (!(LS.LSI_CUR_L17_CNT_44.IsNumericValue()))                                                     //COBOL==> IF LSI-CUR-L17-CNT-44 IS NOT NUMERIC
            {
                LS.LSI_CUR_L17_CNT_44.SetValueWithZeroes();                                                         //COBOL==> MOVE ZEROS TO LSI-CUR-L17-CNT-44
            }                                                                                                   //COBOL==> END-IF.
            if (!(LS.LSI_FMR_L17_CNT_45.IsNumericValue()))                                                     //COBOL==> IF LSI-FMR-L17-CNT-45 IS NOT NUMERIC
            {
                LS.LSI_FMR_L17_CNT_45.SetValueWithZeroes();                                                         //COBOL==> MOVE ZEROS TO LSI-FMR-L17-CNT-45
            }                                                                                                   //COBOL==> END-IF.
            if (!(LS.LSI_NVR_L17_CNT_46.IsNumericValue()))                                                     //COBOL==> IF LSI-NVR-L17-CNT-46 IS NOT NUMERIC
            {
                LS.LSI_NVR_L17_CNT_46.SetValueWithZeroes();                                                         //COBOL==> MOVE ZEROS TO LSI-NVR-L17-CNT-46
            }                                                                                                   //COBOL==> END-IF.
            if (!(LS.LSI_CUR_L18_CNT_47.IsNumericValue()))                                                     //COBOL==> IF LSI-CUR-L18-CNT-47 IS NOT NUMERIC
            {
                LS.LSI_CUR_L18_CNT_47.SetValueWithZeroes();                                                         //COBOL==> MOVE ZEROS TO LSI-CUR-L18-CNT-47
            }                                                                                                   //COBOL==> END-IF.
            if (!(LS.LSI_FMR_L18_CNT_48.IsNumericValue()))                                                     //COBOL==> IF LSI-FMR-L18-CNT-48 IS NOT NUMERIC
            {
                LS.LSI_FMR_L18_CNT_48.SetValueWithZeroes();                                                         //COBOL==> MOVE ZEROS TO LSI-FMR-L18-CNT-48
            }                                                                                                   //COBOL==> END-IF.
            if (!(LS.LSI_NVR_L18_CNT_49.IsNumericValue()))                                                     //COBOL==> IF LSI-NVR-L18-CNT-49 IS NOT NUMERIC
            {
                LS.LSI_NVR_L18_CNT_49.SetValueWithZeroes();                                                         //COBOL==> MOVE ZEROS TO LSI-NVR-L18-CNT-49
            }                                                                                                   //COBOL==> END-IF.
            if (!(LS.LSI_CUR_L18A_CNT_50.IsNumericValue()))                                                    //COBOL==> IF LSI-CUR-L18A-CNT-50 IS NOT NUMERIC
            {
                LS.LSI_CUR_L18A_CNT_50.SetValueWithZeroes();                                                        //COBOL==> MOVE ZEROS TO LSI-CUR-L18A-CNT-50
            }                                                                                                   //COBOL==> END-IF.
            if (!(LS.LSI_FMR_L18A_CNT_51.IsNumericValue()))                                                    //COBOL==> IF LSI-FMR-L18A-CNT-51 IS NOT NUMERIC
            {
                LS.LSI_FMR_L18A_CNT_51.SetValueWithZeroes();                                                        //COBOL==> MOVE ZEROS TO LSI-FMR-L18A-CNT-51
            }                                                                                                   //COBOL==> END-IF.
            if (!(LS.LSI_NVR_L18A_CNT_52.IsNumericValue()))                                                    //COBOL==> IF LSI-NVR-L18A-CNT-52 IS NOT NUMERIC
            {
                LS.LSI_NVR_L18A_CNT_52.SetValueWithZeroes();                                                        //COBOL==> MOVE ZEROS TO LSI-NVR-L18A-CNT-52
            }                                                                                                   //COBOL==> END-IF.
            if (!(LS.LSI_CUR_L19_CNT_53.IsNumericValue()))                                                     //COBOL==> IF LSI-CUR-L19-CNT-53 IS NOT NUMERIC
            {
                LS.LSI_CUR_L19_CNT_53.SetValueWithZeroes();                                                         //COBOL==> MOVE ZEROS TO LSI-CUR-L19-CNT-53
            }                                                                                                   //COBOL==> END-IF.
            if (!(LS.LSI_FMR_L19_CNT_54.IsNumericValue()))                                                     //COBOL==> IF LSI-FMR-L19-CNT-54 IS NOT NUMERIC
            {
                LS.LSI_FMR_L19_CNT_54.SetValueWithZeroes();                                                         //COBOL==> MOVE ZEROS TO LSI-FMR-L19-CNT-54
            }                                                                                                   //COBOL==> END-IF.
            if (!(LS.LSI_NVR_L19_CNT_55.IsNumericValue()))                                                     //COBOL==> IF LSI-NVR-L19-CNT-55 IS NOT NUMERIC
            {
                LS.LSI_NVR_L19_CNT_55.SetValueWithZeroes();                                                         //COBOL==> MOVE ZEROS TO LSI-NVR-L19-CNT-55
            }                                                                                                   //COBOL==> END-IF.
            if (!(LS.LSI_CUR_L20_CNT_56.IsNumericValue()))                                                     //COBOL==> IF LSI-CUR-L20-CNT-56 IS NOT NUMERIC
            {
                LS.LSI_CUR_L20_CNT_56.SetValueWithZeroes();                                                         //COBOL==> MOVE ZEROS TO LSI-CUR-L20-CNT-56
            }                                                                                                   //COBOL==> END-IF.
            if (!(LS.LSI_FMR_L20_CNT_57.IsNumericValue()))                                                     //COBOL==> IF LSI-FMR-L20-CNT-57 IS NOT NUMERIC
            {
                LS.LSI_FMR_L20_CNT_57.SetValueWithZeroes();                                                         //COBOL==> MOVE ZEROS TO LSI-FMR-L20-CNT-57
            }                                                                                                   //COBOL==> END-IF.
            if (!(LS.LSI_NVR_L20_CNT_58.IsNumericValue()))                                                     //COBOL==> IF LSI-NVR-L20-CNT-58 IS NOT NUMERIC
            {
                LS.LSI_NVR_L20_CNT_58.SetValueWithZeroes();                                                         //COBOL==> MOVE ZEROS TO LSI-NVR-L20-CNT-58
            }                                                                                                   //COBOL==> END-IF.
            if (!(LS.LSI_TOT_L21_CNT_59.IsNumericValue()))                                                     //COBOL==> IF LSI-TOT-L21-CNT-59 IS NOT NUMERIC
            {
                LS.LSI_TOT_L21_CNT_59.SetValueWithZeroes();                                                         //COBOL==> MOVE ZEROS TO LSI-TOT-L21-CNT-59
            }                                                                                                   //COBOL==> END-IF.
            if (!(LS.LSI_TOT_L22_CNT_60.IsNumericValue()))                                                     //COBOL==> IF LSI-TOT-L22-CNT-60 IS NOT NUMERIC
            {
                LS.LSI_TOT_L22_CNT_60.SetValueWithZeroes();                                                         //COBOL==> MOVE ZEROS TO LSI-TOT-L22-CNT-60
            }                                                                                                   //COBOL==> END-IF.
            if (!(LS.LSI_TOT_L23_CNT_61.IsNumericValue()))                                                     //COBOL==> IF LSI-TOT-L23-CNT-61 IS NOT NUMERIC
            {
                LS.LSI_TOT_L23_CNT_61.SetValueWithZeroes();                                                         //COBOL==> MOVE ZEROS TO LSI-TOT-L23-CNT-61
            }                                                                                                   //COBOL==> END-IF.
            if (!(LS.LSI_CUR_L24_CNT_62.IsNumericValue()))                                                     //COBOL==> IF LSI-CUR-L24-CNT-62 IS NOT NUMERIC
            {
                LS.LSI_CUR_L24_CNT_62.SetValueWithZeroes();                                                         //COBOL==> MOVE ZEROS TO LSI-CUR-L24-CNT-62
            }                                                                                                   //COBOL==> END-IF.
            if (!(LS.LSI_FMR_L24_CNT_63.IsNumericValue()))                                                     //COBOL==> IF LSI-FMR-L24-CNT-63 IS NOT NUMERIC
            {
                LS.LSI_FMR_L24_CNT_63.SetValueWithZeroes();                                                         //COBOL==> MOVE ZEROS TO LSI-FMR-L24-CNT-63
            }                                                                                                   //COBOL==> END-IF.
            if (!(LS.LSI_NVR_L24_CNT_64.IsNumericValue()))                                                     //COBOL==> IF LSI-NVR-L24-CNT-64 IS NOT NUMERIC
            {
                LS.LSI_NVR_L24_CNT_64.SetValueWithZeroes();                                                         //COBOL==> MOVE ZEROS TO LSI-NVR-L24-CNT-64
            }                                                                                                   //COBOL==> END-IF.
            if (!(LS.LSI_CUR_L25_CNT_65.IsNumericValue()))                                                     //COBOL==> IF LSI-CUR-L25-CNT-65 IS NOT NUMERIC
            {
                LS.LSI_CUR_L25_CNT_65.SetValueWithZeroes();                                                         //COBOL==> MOVE ZEROS TO LSI-CUR-L25-CNT-65
            }                                                                                                   //COBOL==> END-IF.
            if (!(LS.LSI_FMR_L25_CNT_66.IsNumericValue()))                                                     //COBOL==> IF LSI-FMR-L25-CNT-66 IS NOT NUMERIC
            {
                LS.LSI_FMR_L25_CNT_66.SetValueWithZeroes();                                                         //COBOL==> MOVE ZEROS TO LSI-FMR-L25-CNT-66
            }                                                                                                   //COBOL==> END-IF.
            if (!(LS.LSI_NVR_L25_CNT_67.IsNumericValue()))                                                     //COBOL==> IF LSI-NVR-L25-CNT-67 IS NOT NUMERIC
            {
                LS.LSI_NVR_L25_CNT_67.SetValueWithZeroes();                                                         //COBOL==> MOVE ZEROS TO LSI-NVR-L25-CNT-67
            }                                                                                                   //COBOL==> END-IF.
            if (!(LS.LSI_CUR_L26_CNT_68.IsNumericValue()))                                                     //COBOL==> IF LSI-CUR-L26-CNT-68 IS NOT NUMERIC
            {
                LS.LSI_CUR_L26_CNT_68.SetValueWithZeroes();                                                         //COBOL==> MOVE ZEROS TO LSI-CUR-L26-CNT-68
            }                                                                                                   //COBOL==> END-IF.
            if (!(LS.LSI_FMR_L26_CNT_69.IsNumericValue()))                                                     //COBOL==> IF LSI-FMR-L26-CNT-69 IS NOT NUMERIC
            {
                LS.LSI_FMR_L26_CNT_69.SetValueWithZeroes();                                                         //COBOL==> MOVE ZEROS TO LSI-FMR-L26-CNT-69
            }                                                                                                   //COBOL==> END-IF.
            if (!(LS.LSI_NVR_L26_CNT_70.IsNumericValue()))                                                     //COBOL==> IF LSI-NVR-L26-CNT-70 IS NOT NUMERIC
            {
                LS.LSI_NVR_L26_CNT_70.SetValueWithZeroes();                                                         //COBOL==> MOVE ZEROS TO LSI-NVR-L26-CNT-70
            }                                                                                                   //COBOL==> END-IF.
            if (!(LS.LSI_CUR_L27_CNT_71.IsNumericValue()))                                                     //COBOL==> IF LSI-CUR-L27-CNT-71 IS NOT NUMERIC
            {
                LS.LSI_CUR_L27_CNT_71.SetValueWithZeroes();                                                         //COBOL==> MOVE ZEROS TO LSI-CUR-L27-CNT-71
            }                                                                                                   //COBOL==> END-IF.
            if (!(LS.LSI_FMR_L27_CNT_72.IsNumericValue()))                                                     //COBOL==> IF LSI-FMR-L27-CNT-72 IS NOT NUMERIC
            {
                LS.LSI_FMR_L27_CNT_72.SetValueWithZeroes();                                                         //COBOL==> MOVE ZEROS TO LSI-FMR-L27-CNT-72
            }                                                                                                   //COBOL==> END-IF.
            if (!(LS.LSI_NVR_L27_CNT_73.IsNumericValue()))                                                     //COBOL==> IF LSI-NVR-L27-CNT-73 IS NOT NUMERIC
            {
                LS.LSI_NVR_L27_CNT_73.SetValueWithZeroes();                                                         //COBOL==> MOVE ZEROS TO LSI-NVR-L27-CNT-73
            }                                                                                                   //COBOL==> END-IF.
            if (!(LS.LSI_TOT_L28_CNT_74.IsNumericValue()))                                                     //COBOL==> IF LSI-TOT-L28-CNT-74 IS NOT NUMERIC
            {
                LS.LSI_TOT_L28_CNT_74.SetValueWithZeroes();                                                         //COBOL==> MOVE ZEROS TO LSI-TOT-L28-CNT-74
            }                                                                                                   //COBOL==> END-IF.
            if (!(LS.LSI_TOT_L29_CNT_75.IsNumericValue()))                                                     //COBOL==> IF LSI-TOT-L29-CNT-75 IS NOT NUMERIC
            {
                LS.LSI_TOT_L29_CNT_75.SetValueWithZeroes();                                                         //COBOL==> MOVE ZEROS TO LSI-TOT-L29-CNT-75
            }                                                                                                   //COBOL==> END-IF.
            if (!(LS.LSI_TOT_L30_CNT_76.IsNumericValue()))                                                     //COBOL==> IF LSI-TOT-L30-CNT-76 IS NOT NUMERIC
            {
                LS.LSI_TOT_L30_CNT_76.SetValueWithZeroes();                                                         //COBOL==> MOVE ZEROS TO LSI-TOT-L30-CNT-76
            }                                                                                                   //COBOL==> END-IF.
            if (!(LS.LSI_TOT_L31_CNT_77.IsNumericValue()))                                                     //COBOL==> IF LSI-TOT-L31-CNT-77 IS NOT NUMERIC
            {
                LS.LSI_TOT_L31_CNT_77.SetValueWithZeroes();                                                         //COBOL==> MOVE ZEROS TO LSI-TOT-L31-CNT-77
            }                                                                                                   //COBOL==> END-IF.
            if (!(LS.LSI_TOT_L32_CNT_78.IsNumericValue()))                                                     //COBOL==> IF LSI-TOT-L32-CNT-78 IS NOT NUMERIC
            {
                LS.LSI_TOT_L32_CNT_78.SetValueWithZeroes();                                                         //COBOL==> MOVE ZEROS TO LSI-TOT-L32-CNT-78
            }                                                                                                   //COBOL==> END-IF.
            if (!(LS.LSI_CUR_L38_CNT_79.IsNumericValue()))                                                     //COBOL==> IF LSI-CUR-L38-CNT-79 IS NOT NUMERIC
            {
                LS.LSI_CUR_L38_CNT_79.SetValueWithZeroes();                                                         //COBOL==> MOVE ZEROS TO LSI-CUR-L38-CNT-79
            }                                                                                                   //COBOL==> END-IF.
            if (!(LS.LSI_CUR_L39_CNT_80.IsNumericValue()))                                                     //COBOL==> IF LSI-CUR-L39-CNT-80 IS NOT NUMERIC
            {
                LS.LSI_CUR_L39_CNT_80.SetValueWithZeroes();                                                         //COBOL==> MOVE ZEROS TO LSI-CUR-L39-CNT-80
            }                                                                                                   //COBOL==> END-IF.
            if (!(LS.LSI_TOT_L40_CNT_81.IsNumericValue()))                                                     //COBOL==> IF LSI-TOT-L40-CNT-81 IS NOT NUMERIC
            {
                LS.LSI_TOT_L40_CNT_81.SetValueWithZeroes();                                                         //COBOL==> MOVE ZEROS TO LSI-TOT-L40-CNT-81
            }                                                                                                   //COBOL==> END-IF.
            if (!(LS.LSI_TOT_L41_CNT_82.IsNumericValue()))                                                     //COBOL==> IF LSI-TOT-L41-CNT-82 IS NOT NUMERIC
            {
                LS.LSI_TOT_L41_CNT_82.SetValueWithZeroes();                                                         //COBOL==> MOVE ZEROS TO LSI-TOT-L41-CNT-82
            }                                                                                                   //COBOL==> END-IF.
            if (!(LS.LSI_TOT_L42_CNT_83.IsNumericValue()))                                                     //COBOL==> IF LSI-TOT-L42-CNT-83 IS NOT NUMERIC
            {
                LS.LSI_TOT_L42_CNT_83.SetValueWithZeroes();                                                         //COBOL==> MOVE ZEROS TO LSI-TOT-L42-CNT-83
            }                                                                                                   //COBOL==> END-IF.
            if ((LS.LSI_PARM1_84XX.IsEqualTo(HIGH_VALUES))
             || (LS.LSI_PARM1_84XX.IsEqualTo(LOW_VALUES)))  //COBOL==> IF LSI-PARM1-84XX = HIGH-VALUES OR LSI-PARM1-84XX = LOW-VALUES
            {
                LS.LSI_PARM1_84.SetValueWithSpaces();                                                               //COBOL==> MOVE SPACES TO LSI-PARM1-84
            }                                                                                                   //COBOL==> END-IF.
            if ((LS.LSI_PARM2_85XX.IsEqualTo(HIGH_VALUES))
             || (LS.LSI_PARM2_85XX.IsEqualTo(LOW_VALUES)))  //COBOL==> IF LSI-PARM2-85XX = HIGH-VALUES OR LSI-PARM2-85XX = LOW-VALUES
            {
                LS.LSI_PARM2_85.SetValueWithSpaces();                                                               //COBOL==> MOVE SPACES TO LSI-PARM2-85
            }                                                                                                   //COBOL==> END-IF.
            if ((LS.LSI_SUBRPT_CD_86XX.IsEqualTo(HIGH_VALUES))
             || (LS.LSI_SUBRPT_CD_86XX.IsEqualTo(LOW_VALUES)))  //COBOL==> IF LSI-SUBRPT-CD-86XX = HIGH-VALUES OR LSI-SUBRPT-CD-86XX = LOW-VALUES
            {
                LS.LSI_SUBRPT_CD_86.SetValueWithSpaces();                                                           //COBOL==> MOVE SPACES TO LSI-SUBRPT-CD-86
            }                                                                                                   //COBOL==> END-IF.
            LS.LSE_PARM1_87.SetValueWithSpaces();                                                               //COBOL==> MOVE SPACES TO LSE-PARM1-87.
            LS.LSE_PARM2_88.SetValueWithSpaces();                                                               //COBOL==> MOVE SPACES TO LSE-PARM2-88.
            LS.LSE_SUBRPT_CD_89.SetValueWithSpaces();                                                           //COBOL==> MOVE SPACES TO LSE-SUBRPT-CD-89.
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
            WS.WS_CUR_L1_CNT_01.SetValue(LS.LSI_CUR_L1_CNT_01);                                                 //COBOL==> MOVE LSI-CUR-L1-CNT-01 TO WS-CUR-L1-CNT-01.
            WS.WS_FMR_L1_CNT_02.SetValue(LS.LSI_FMR_L1_CNT_02);                                                 //COBOL==> MOVE LSI-FMR-L1-CNT-02 TO WS-FMR-L1-CNT-02.
            WS.WS_NVR_L1_CNT_03.SetValue(LS.LSI_NVR_L1_CNT_03);                                                 //COBOL==> MOVE LSI-NVR-L1-CNT-03 TO WS-NVR-L1-CNT-03.
            WS.WS_CUR_L1A_CNT_04.SetValue(LS.LSI_CUR_L1A_CNT_04);                                               //COBOL==> MOVE LSI-CUR-L1A-CNT-04 TO WS-CUR-L1A-CNT-04.
            WS.WS_FMR_L1A_CNT_05.SetValue(LS.LSI_FMR_L1A_CNT_05);                                               //COBOL==> MOVE LSI-FMR-L1A-CNT-05 TO WS-FMR-L1A-CNT-05.
            WS.WS_NVR_L1A_CNT_06.SetValue(LS.LSI_NVR_L1A_CNT_06);                                               //COBOL==> MOVE LSI-NVR-L1A-CNT-06 TO WS-NVR-L1A-CNT-06.
            WS.WS_CUR_L1B_CNT_07.SetValue(LS.LSI_CUR_L1B_CNT_07);                                               //COBOL==> MOVE LSI-CUR-L1B-CNT-07 TO WS-CUR-L1B-CNT-07.
            WS.WS_FMR_L1B_CNT_08.SetValue(LS.LSI_FMR_L1B_CNT_08);                                               //COBOL==> MOVE LSI-FMR-L1B-CNT-08 TO WS-FMR-L1B-CNT-08.
            WS.WS_NVR_L1B_CNT_09.SetValue(LS.LSI_NVR_L1B_CNT_09);                                               //COBOL==> MOVE LSI-NVR-L1B-CNT-09 TO WS-NVR-L1B-CNT-09.
            WS.WS_NVR_L1C_CNT_10.SetValue(LS.LSI_NVR_L1C_CNT_10);                                               //COBOL==> MOVE LSI-NVR-L1C-CNT-10 TO WS-NVR-L1C-CNT-10.
            WS.WS_CUR_L2_CNT_11.SetValue(LS.LSI_CUR_L2_CNT_11);                                                 //COBOL==> MOVE LSI-CUR-L2-CNT-11 TO WS-CUR-L2-CNT-11.
            WS.WS_FMR_L2_CNT_12.SetValue(LS.LSI_FMR_L2_CNT_12);                                                 //COBOL==> MOVE LSI-FMR-L2-CNT-12 TO WS-FMR-L2-CNT-12.
            WS.WS_NVR_L2_CNT_13.SetValue(LS.LSI_NVR_L2_CNT_13);                                                 //COBOL==> MOVE LSI-NVR-L2-CNT-13 TO WS-NVR-L2-CNT-13.
            WS.WS_CUR_L2A_CNT_14.SetValue(LS.LSI_CUR_L2A_CNT_14);                                               //COBOL==> MOVE LSI-CUR-L2A-CNT-14 TO WS-CUR-L2A-CNT-14.
            WS.WS_FMR_L2A_CNT_15.SetValue(LS.LSI_FMR_L2A_CNT_15);                                               //COBOL==> MOVE LSI-FMR-L2A-CNT-15 TO WS-FMR-L2A-CNT-15.
            WS.WS_NVR_L2A_CNT_16.SetValue(LS.LSI_NVR_L2A_CNT_16);                                               //COBOL==> MOVE LSI-NVR-L2A-CNT-16 TO WS-NVR-L2A-CNT-16.
            WS.WS_CUR_L2B_CNT_17.SetValue(LS.LSI_CUR_L2B_CNT_17);                                               //COBOL==> MOVE LSI-CUR-L2B-CNT-17 TO WS-CUR-L2B-CNT-17.
            WS.WS_FMR_L2B_CNT_18.SetValue(LS.LSI_FMR_L2B_CNT_18);                                               //COBOL==> MOVE LSI-FMR-L2B-CNT-18 TO WS-FMR-L2B-CNT-18.
            WS.WS_NVR_L2B_CNT_19.SetValue(LS.LSI_NVR_L2B_CNT_19);                                               //COBOL==> MOVE LSI-NVR-L2B-CNT-19 TO WS-NVR-L2B-CNT-19.
            WS.WS_CUR_L2C_CNT_20.SetValue(LS.LSI_CUR_L2C_CNT_20);                                               //COBOL==> MOVE LSI-CUR-L2C-CNT-20 TO WS-CUR-L2C-CNT-20.
            WS.WS_FMR_L2C_CNT_21.SetValue(LS.LSI_FMR_L2C_CNT_21);                                               //COBOL==> MOVE LSI-FMR-L2C-CNT-21 TO WS-FMR-L2C-CNT-21.
            WS.WS_NVR_L2C_CNT_22.SetValue(LS.LSI_NVR_L2C_CNT_22);                                               //COBOL==> MOVE LSI-NVR-L2C-CNT-22 TO WS-NVR-L2C-CNT-22.
            WS.WS_NVR_L2D_CNT_23.SetValue(LS.LSI_NVR_L2D_CNT_23);                                               //COBOL==> MOVE LSI-NVR-L2D-CNT-23 TO WS-NVR-L2D-CNT-23.
            WS.WS_CUR_L3_CNT_24.SetValue(LS.LSI_CUR_L3_CNT_24);                                                 //COBOL==> MOVE LSI-CUR-L3-CNT-24 TO WS-CUR-L3-CNT-24.
            WS.WS_FMR_L3_CNT_25.SetValue(LS.LSI_FMR_L3_CNT_25);                                                 //COBOL==> MOVE LSI-FMR-L3-CNT-25 TO WS-FMR-L3-CNT-25.
            WS.WS_NVR_L3_CNT_26.SetValue(LS.LSI_NVR_L3_CNT_26);                                                 //COBOL==> MOVE LSI-NVR-L3-CNT-26 TO WS-NVR-L3-CNT-26.
            WS.WS_TOT_L4_CNT_27.SetValue(LS.LSI_TOT_L4_CNT_27);                                                 //COBOL==> MOVE LSI-TOT-L4-CNT-27 TO WS-TOT-L4-CNT-27.
            WS.WS_TOT_L5_CNT_28.SetValue(LS.LSI_TOT_L5_CNT_28);                                                 //COBOL==> MOVE LSI-TOT-L5-CNT-28 TO WS-TOT-L5-CNT-28.
            WS.WS_TOT_L6_CNT_29.SetValue(LS.LSI_TOT_L6_CNT_29);                                                 //COBOL==> MOVE LSI-TOT-L6-CNT-29 TO WS-TOT-L6-CNT-29.
            WS.WS_TOT_L7_CNT_30.SetValue(LS.LSI_TOT_L7_CNT_30);                                                 //COBOL==> MOVE LSI-TOT-L7-CNT-30 TO WS-TOT-L7-CNT-30.
            WS.WS_TOT_L8_CNT_31.SetValue(LS.LSI_TOT_L8_CNT_31);                                                 //COBOL==> MOVE LSI-TOT-L8-CNT-31 TO WS-TOT-L8-CNT-31.
            WS.WS_TOT_L9_CNT_32.SetValue(LS.LSI_TOT_L9_CNT_32);                                                 //COBOL==> MOVE LSI-TOT-L9-CNT-32 TO WS-TOT-L9-CNT-32.
            WS.WS_TOT_L10_CNT_33.SetValue(LS.LSI_TOT_L10_CNT_33);                                               //COBOL==> MOVE LSI-TOT-L10-CNT-33 TO WS-TOT-L10-CNT-33.
            WS.WS_CUR_L12_CNT_34.SetValue(LS.LSI_CUR_L12_CNT_34);                                               //COBOL==> MOVE LSI-CUR-L12-CNT-34 TO WS-CUR-L12-CNT-34.
            WS.WS_FMR_L12_CNT_35.SetValue(LS.LSI_FMR_L12_CNT_35);                                               //COBOL==> MOVE LSI-FMR-L12-CNT-35 TO WS-FMR-L12-CNT-35.
            WS.WS_NVR_L12_CNT_36.SetValue(LS.LSI_NVR_L12_CNT_36);                                               //COBOL==> MOVE LSI-NVR-L12-CNT-36 TO WS-NVR-L12-CNT-36.
            WS.WS_CUR_L13_CNT_37.SetValue(LS.LSI_CUR_L13_CNT_37);                                               //COBOL==> MOVE LSI-CUR-L13-CNT-37 TO WS-CUR-L13-CNT-37.
            WS.WS_FMR_L13_CNT_38.SetValue(LS.LSI_FMR_L13_CNT_38);                                               //COBOL==> MOVE LSI-FMR-L13-CNT-38 TO WS-FMR-L13-CNT-38.
            WS.WS_NVR_L13_CNT_39.SetValue(LS.LSI_NVR_L13_CNT_39);                                               //COBOL==> MOVE LSI-NVR-L13-CNT-39 TO WS-NVR-L13-CNT-39.
            WS.WS_TOT_L14_CNT_40.SetValue(LS.LSI_TOT_L14_CNT_40);                                               //COBOL==> MOVE LSI-TOT-L14-CNT-40 TO WS-TOT-L14-CNT-40.
            WS.WS_CUR_L16_CNT_41.SetValue(LS.LSI_CUR_L16_CNT_41);                                               //COBOL==> MOVE LSI-CUR-L16-CNT-41 TO WS-CUR-L16-CNT-41.
            WS.WS_FMR_L16_CNT_42.SetValue(LS.LSI_FMR_L16_CNT_42);                                               //COBOL==> MOVE LSI-FMR-L16-CNT-42 TO WS-FMR-L16-CNT-42.
            WS.WS_NVR_L16_CNT_43.SetValue(LS.LSI_NVR_L16_CNT_43);                                               //COBOL==> MOVE LSI-NVR-L16-CNT-43 TO WS-NVR-L16-CNT-43.
            WS.WS_CUR_L17_CNT_44.SetValue(LS.LSI_CUR_L17_CNT_44);                                               //COBOL==> MOVE LSI-CUR-L17-CNT-44 TO WS-CUR-L17-CNT-44.
            WS.WS_FMR_L17_CNT_45.SetValue(LS.LSI_FMR_L17_CNT_45);                                               //COBOL==> MOVE LSI-FMR-L17-CNT-45 TO WS-FMR-L17-CNT-45.
            WS.WS_NVR_L17_CNT_46.SetValue(LS.LSI_NVR_L17_CNT_46);                                               //COBOL==> MOVE LSI-NVR-L17-CNT-46 TO WS-NVR-L17-CNT-46.
            WS.WS_CUR_L18_CNT_47.SetValue(LS.LSI_CUR_L18_CNT_47);                                               //COBOL==> MOVE LSI-CUR-L18-CNT-47 TO WS-CUR-L18-CNT-47.
            WS.WS_FMR_L18_CNT_48.SetValue(LS.LSI_FMR_L18_CNT_48);                                               //COBOL==> MOVE LSI-FMR-L18-CNT-48 TO WS-FMR-L18-CNT-48.
            WS.WS_NVR_L18_CNT_49.SetValue(LS.LSI_NVR_L18_CNT_49);                                               //COBOL==> MOVE LSI-NVR-L18-CNT-49 TO WS-NVR-L18-CNT-49.
            WS.WS_CUR_L18A_CNT_50.SetValue(LS.LSI_CUR_L18A_CNT_50);                                             //COBOL==> MOVE LSI-CUR-L18A-CNT-50 TO WS-CUR-L18A-CNT-50.
            WS.WS_FMR_L18A_CNT_51.SetValue(LS.LSI_FMR_L18A_CNT_51);                                             //COBOL==> MOVE LSI-FMR-L18A-CNT-51 TO WS-FMR-L18A-CNT-51.
            WS.WS_NVR_L18A_CNT_52.SetValue(LS.LSI_NVR_L18A_CNT_52);                                             //COBOL==> MOVE LSI-NVR-L18A-CNT-52 TO WS-NVR-L18A-CNT-52.
            WS.WS_CUR_L19_CNT_53.SetValue(LS.LSI_CUR_L19_CNT_53);                                               //COBOL==> MOVE LSI-CUR-L19-CNT-53 TO WS-CUR-L19-CNT-53.
            WS.WS_FMR_L19_CNT_54.SetValue(LS.LSI_FMR_L19_CNT_54);                                               //COBOL==> MOVE LSI-FMR-L19-CNT-54 TO WS-FMR-L19-CNT-54.
            WS.WS_NVR_L19_CNT_55.SetValue(LS.LSI_NVR_L19_CNT_55);                                               //COBOL==> MOVE LSI-NVR-L19-CNT-55 TO WS-NVR-L19-CNT-55.
            WS.WS_CUR_L20_CNT_56.SetValue(LS.LSI_CUR_L20_CNT_56);                                               //COBOL==> MOVE LSI-CUR-L20-CNT-56 TO WS-CUR-L20-CNT-56.
            WS.WS_FMR_L20_CNT_57.SetValue(LS.LSI_FMR_L20_CNT_57);                                               //COBOL==> MOVE LSI-FMR-L20-CNT-57 TO WS-FMR-L20-CNT-57.
            WS.WS_NVR_L20_CNT_58.SetValue(LS.LSI_NVR_L20_CNT_58);                                               //COBOL==> MOVE LSI-NVR-L20-CNT-58 TO WS-NVR-L20-CNT-58.
            WS.WS_TOT_L21_CNT_59.SetValue(LS.LSI_TOT_L21_CNT_59);                                               //COBOL==> MOVE LSI-TOT-L21-CNT-59 TO WS-TOT-L21-CNT-59.
            WS.WS_TOT_L22_CNT_60.SetValue(LS.LSI_TOT_L22_CNT_60);                                               //COBOL==> MOVE LSI-TOT-L22-CNT-60 TO WS-TOT-L22-CNT-60.
            WS.WS_TOT_L23_CNT_61.SetValue(LS.LSI_TOT_L23_CNT_61);                                               //COBOL==> MOVE LSI-TOT-L23-CNT-61 TO WS-TOT-L23-CNT-61.
            WS.WS_CUR_L24_CNT_62.SetValue(LS.LSI_CUR_L24_CNT_62);                                               //COBOL==> MOVE LSI-CUR-L24-CNT-62 TO WS-CUR-L24-CNT-62.
            WS.WS_FMR_L24_CNT_63.SetValue(LS.LSI_FMR_L24_CNT_63);                                               //COBOL==> MOVE LSI-FMR-L24-CNT-63 TO WS-FMR-L24-CNT-63.
            WS.WS_NVR_L24_CNT_64.SetValue(LS.LSI_NVR_L24_CNT_64);                                               //COBOL==> MOVE LSI-NVR-L24-CNT-64 TO WS-NVR-L24-CNT-64.
            WS.WS_CUR_L25_CNT_65.SetValue(LS.LSI_CUR_L25_CNT_65);                                               //COBOL==> MOVE LSI-CUR-L25-CNT-65 TO WS-CUR-L25-CNT-65.
            WS.WS_FMR_L25_CNT_66.SetValue(LS.LSI_FMR_L25_CNT_66);                                               //COBOL==> MOVE LSI-FMR-L25-CNT-66 TO WS-FMR-L25-CNT-66.
            WS.WS_NVR_L25_CNT_67.SetValue(LS.LSI_NVR_L25_CNT_67);                                               //COBOL==> MOVE LSI-NVR-L25-CNT-67 TO WS-NVR-L25-CNT-67.
            WS.WS_CUR_L26_CNT_68.SetValue(LS.LSI_CUR_L26_CNT_68);                                               //COBOL==> MOVE LSI-CUR-L26-CNT-68 TO WS-CUR-L26-CNT-68.
            WS.WS_FMR_L26_CNT_69.SetValue(LS.LSI_FMR_L26_CNT_69);                                               //COBOL==> MOVE LSI-FMR-L26-CNT-69 TO WS-FMR-L26-CNT-69.
            WS.WS_NVR_L26_CNT_70.SetValue(LS.LSI_NVR_L26_CNT_70);                                               //COBOL==> MOVE LSI-NVR-L26-CNT-70 TO WS-NVR-L26-CNT-70.
            WS.WS_CUR_L27_CNT_71.SetValue(LS.LSI_CUR_L27_CNT_71);                                               //COBOL==> MOVE LSI-CUR-L27-CNT-71 TO WS-CUR-L27-CNT-71.
            WS.WS_FMR_L27_CNT_72.SetValue(LS.LSI_FMR_L27_CNT_72);                                               //COBOL==> MOVE LSI-FMR-L27-CNT-72 TO WS-FMR-L27-CNT-72.
            WS.WS_NVR_L27_CNT_73.SetValue(LS.LSI_NVR_L27_CNT_73);                                               //COBOL==> MOVE LSI-NVR-L27-CNT-73 TO WS-NVR-L27-CNT-73.
            WS.WS_TOT_L28_CNT_74.SetValue(LS.LSI_TOT_L28_CNT_74);                                               //COBOL==> MOVE LSI-TOT-L28-CNT-74 TO WS-TOT-L28-CNT-74.
            WS.WS_TOT_L29_CNT_75.SetValue(LS.LSI_TOT_L29_CNT_75);                                               //COBOL==> MOVE LSI-TOT-L29-CNT-75 TO WS-TOT-L29-CNT-75.
            WS.WS_TOT_L30_CNT_76.SetValue(LS.LSI_TOT_L30_CNT_76);                                               //COBOL==> MOVE LSI-TOT-L30-CNT-76 TO WS-TOT-L30-CNT-76.
            WS.WS_TOT_L31_CNT_77.SetValue(LS.LSI_TOT_L31_CNT_77);                                               //COBOL==> MOVE LSI-TOT-L31-CNT-77 TO WS-TOT-L31-CNT-77.
            WS.WS_TOT_L32_CNT_78.SetValue(LS.LSI_TOT_L32_CNT_78);                                               //COBOL==> MOVE LSI-TOT-L32-CNT-78 TO WS-TOT-L32-CNT-78.
            WS.WS_CUR_L38_CNT_79.SetValue(LS.LSI_CUR_L38_CNT_79);                                               //COBOL==> MOVE LSI-CUR-L38-CNT-79 TO WS-CUR-L38-CNT-79.
            WS.WS_CUR_L39_CNT_80.SetValue(LS.LSI_CUR_L39_CNT_80);                                               //COBOL==> MOVE LSI-CUR-L39-CNT-80 TO WS-CUR-L39-CNT-80.
            WS.WS_TOT_L40_CNT_81.SetValue(LS.LSI_TOT_L40_CNT_81);                                               //COBOL==> MOVE LSI-TOT-L40-CNT-81 TO WS-TOT-L40-CNT-81.
            WS.WS_TOT_L41_CNT_82.SetValue(LS.LSI_TOT_L41_CNT_82);                                               //COBOL==> MOVE LSI-TOT-L41-CNT-82 TO WS-TOT-L41-CNT-82.
            WS.WS_TOT_L42_CNT_83.SetValue(LS.LSI_TOT_L42_CNT_83);                                               //COBOL==> MOVE LSI-TOT-L42-CNT-83 TO WS-TOT-L42-CNT-83.
            WS.WS_SUBRPT_CD.SetValue(LS.LSI_SUBRPT_CD_86);                                                      //COBOL==> MOVE LSI-SUBRPT-CD-86 TO WS-SUBRPT-CD.
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
