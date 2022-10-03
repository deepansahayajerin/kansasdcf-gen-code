#region Comments
/* Conversion Comments
   ************************************************************
   **   MODERN SYSTEMS INC.  COPYRIGHT 2000-2022
   **   DB-SHUTTLE COBOL to C# Conversion
   ************************************************************
   ** INIT   *  INITIAL VERSION   *  2022-03-02 04:53:55 PM
   **        *   FROM COBOL PGM   :  SWEXOE04
   **        *   FROM CANISTER    :  SR.CAECSES.PROD.LIBR.SOURCE.PDS
   ************************************************************ */

/* Original Program Identification Comments
   *****************************************************************
                                                                   *
                                                                   *
        EAB NAME:  SWEXOE04.                                       *
     DESCRIPTION:  OE_EAB_GET_AE_CASE_NBR_FOR_PERS                 *
                                                        MEMR/      *
     RELATION TYPE     NAME      DETAIL LEVEL: 1        DOM DIALOG *
     OWNEDBY  BUSSYS   KESSEP_BUSINESS_SYSTEM                      *
     USEDBY   PSTEP-B  FN_BFXH_COLL_CONVERSION_FIX      SWEFFXHB   *
     USEDBY   PSTEP-B  OE_B467_PROCESS_FC_OBLIG_TO_URA  SWEE467B   *
     REFERSTO ENTITY   CSE_PERSON                                  *
     REFERSTO ENTITY   DEBT_DETAIL                                 *
     REFERSTO ENTITY   IM_HOUSEHOLD                                *
     REFERSTO ENTITY   IM_HOUSEHOLD_MBR_MNTHLY_SUM                 *
                                                                   *
                                                                   *
                                                                   *
                                                                   *
                                                                   *
         CREATED:  ??/??/??                                        *
              BY:  ???????.                                        *
                                                                   *
   ** MAINTENANCE **************************************************
                     CHANGE                                        *
                     CONTRL                                        *
    DATE     AUTHOR  NUMBER  DESCRIPTION                           *
    -------- ------- ------- ------------------------------------- *
    01/08/14 WBR     CQ35825 CHANGE ADABAS TO DB2 FOR KEES PHASE 3 *
    12/22/15 RKM     CQ35825 P3 PREFERRED ID CODING CHANGES        *
   *****************************************************************
*/
#endregion
#region Using Directives
using MDSY.Framework.Buffer;
using MDSY.Framework.Buffer.BaseClasses;
using MDSY.Framework.Buffer.Common;
using MDSY.Framework.Buffer.Interfaces;
using MDSY.Framework.Core;
using System;

/*  usings for referenced objects  */
#endregion

namespace GOV.KS.DCF.CSS.Common.BL
{
    #region Working Storage Class
    internal class SWEXOE04_ws : PredefinedRecordBase
    {
        #region Name constants
        /// <summary>
        /// Name constants.
        /// </summary>
        internal static class Names
        {
            internal const string WorkingStorage = "SWEXOE04_ws_WorkingStorage";
            internal const string WRK_TM_SW = "WRK_TM_SW";
            internal const string WRK_FST_TM = "WRK_FST_TM";
            internal const string WRK_LST_TM = "WRK_LST_TM";
            internal const string WRK_DB_CD = "WRK_DB_CD";
            internal const string WRK_ARC_DB = "WRK_ARC_DB";
            internal const string WRK_BEN_DB = "WRK_BEN_DB";
            internal const string WRK_PRT_DB = "WRK_PRT_DB";
            internal const string WRK_RET_CD = "WRK_RET_CD";
            internal const string WRK_NO_ERR = "WRK_NO_ERR";
            internal const string WRK_EOF_ERR = "WRK_EOF_ERR";
            internal const string WRK_ADA_ERR = "WRK_ADA_ERR";
            internal const string WRK_ERR_MSG = "WRK_ERR_MSG";
            internal const string WRK_ERR_CD = "WRK_ERR_CD";
            internal const string WRK_ERR_TXT = "WRK_ERR_TXT";
            internal const string WRK_BEN_FND_SW = "WRK_BEN_FND_SW";
            internal const string WRK_BEN_FND = "WRK_BEN_FND";
            internal const string WRK_PRT_FND_SW = "WRK_PRT_FND_SW";
            internal const string WRK_PRT_FND = "WRK_PRT_FND";
            internal const string WRK_BEN_DT = "WRK_BEN_DT";
            internal const string WRK_BEN_YM = "WRK_BEN_YM";
            internal const string WRK_BEN_DD = "WRK_BEN_DD";
            internal const string WRK_FST_YM = "WRK_FST_YM";
            internal const string WRK_DB2_AREA = "WRK_DB2_AREA";
            internal const string WRK_DATE_0002 = "WRK_DATE_0002";
            internal const string WRK_DATE_AREA = "WRK_DATE_AREA";
            internal const string DCLKSD_BENEFITS = "DCLKSD_BENEFITS";
            internal const string BEN_BUDGETING_METHOD = "BEN_BUDGETING_METHOD";
            internal const string BEN_BENEFIT_TYPE = "BEN_BENEFIT_TYPE";
            internal const string BEN_PAYEE_STREET1 = "BEN_PAYEE_STREET1";
            internal const string BEN_PAYEE_STREET2 = "BEN_PAYEE_STREET2";
            internal const string BEN_PAYEE_CITY = "BEN_PAYEE_CITY";
            internal const string BEN_PAYEE_STATE = "BEN_PAYEE_STATE";
            internal const string BEN_PAYEE_ZIP_CODE = "BEN_PAYEE_ZIP_CODE";
            internal const string BEN_PAYEE_ZIP_PLUS_4 = "BEN_PAYEE_ZIP_PLUS_4";
            internal const string BEN_PAYMENT_START_DATE = "BEN_PAYMENT_START_DATE";
            internal const string BEN_PAYMENT_END_DATE = "BEN_PAYMENT_END_DATE";
            internal const string BEN_COUNTABLE_INCOME = "BEN_COUNTABLE_INCOME";
            internal const string BEN_DEPENDENT_CARE = "BEN_DEPENDENT_CARE";
            internal const string BEN_RECOUPED_AMT = "BEN_RECOUPED_AMT";
            internal const string BEN_NUM_OF_CHILDREN = "BEN_NUM_OF_CHILDREN";
            internal const string BEN_NUMBER_IN_HH = "BEN_NUMBER_IN_HH";
            internal const string BEN_ISSUED_DATE = "BEN_ISSUED_DATE";
            internal const string BEN_ISSUED_AMT = "BEN_ISSUED_AMT";
            internal const string BEN_ISSUANCE_TYPE = "BEN_ISSUANCE_TYPE";
            internal const string BEN_HOUSEHOLD_SIZE = "BEN_HOUSEHOLD_SIZE";
            internal const string BEN_HOUSEHOLD_TYPE = "BEN_HOUSEHOLD_TYPE";
            internal const string BEN_CSE_PROC_FLAG = "BEN_CSE_PROC_FLAG";
            internal const string BEN_BENEFIT_AMT = "BEN_BENEFIT_AMT";
            internal const string BEN_THIRTY_ONE_THIRD = "BEN_THIRTY_ONE_THIRD";
            internal const string BEN_THIRTY_DISREGARD = "BEN_THIRTY_DISREGARD";
            internal const string BEN_CREATED_TIMESTAMP = "BEN_CREATED_TIMESTAMP";
            internal const string BEN_CREATED_BY = "BEN_CREATED_BY";
            internal const string BEN_LAST_MODIFIED_BY = "BEN_LAST_MODIFIED_BY";
            internal const string BEN_LAST_MODIFIED_TMST = "BEN_LAST_MODIFIED_TMST";
            internal const string BEN_FK_CSB_CASE_NO = "BEN_FK_CSB_CASE_NO";
            internal const string BEN_FK_PGB_PROG_TYPE = "BEN_FK_PGB_PROG_TYPE";
            internal const string BEN_FK_PMO_PROG_SUBT = "BEN_FK_PMO_PROG_SUBT";
            internal const string BEN_FK_PMO_PROG_BEN_MO = "BEN_FK_PMO_PROG_BEN_MO";
            internal const string DCLKSD_BENEFITS_ARCHV = "DCLKSD_BENEFITS_ARCHV";
            internal const string BENA_CASE_NUMBER = "BENA_CASE_NUMBER";
            internal const string BENA_PROGRAM_TYPE = "BENA_PROGRAM_TYPE";
            internal const string BENA_PROGRAM_SUBTYPE = "BENA_PROGRAM_SUBTYPE";
            internal const string BENA_BENEFIT_MONTH = "BENA_BENEFIT_MONTH";
            internal const string BENA_ISSUANCE_TYPE = "BENA_ISSUANCE_TYPE";
            internal const string BENA_BENEFIT_TYPE = "BENA_BENEFIT_TYPE";
            internal const string BENA_BUDGETING_METHOD = "BENA_BUDGETING_METHOD";
            internal const string BENA_ISSUED_DATE = "BENA_ISSUED_DATE";
            internal const string BENA_PAYMENT_START_DATE = "BENA_PAYMENT_START_DATE";
            internal const string BENA_PAYMENT_END_DATE = "BENA_PAYMENT_END_DATE";
            internal const string BENA_CREATED_BY = "BENA_CREATED_BY";
            internal const string BENA_CREATED_TIMESTAMP = "BENA_CREATED_TIMESTAMP";
            internal const string DCLKSD_PARTICIPATION = "DCLKSD_PARTICIPATION";
            internal const string PART_KESSEP_TIME_STMP = "PART_KESSEP_TIME_STMP";
            internal const string PART_PART_END_DATE = "PART_PART_END_DATE";
            internal const string PART_PART_START_DATE = "PART_PART_START_DATE";
            internal const string PART_PART_CODE = "PART_PART_CODE";
            internal const string PART_PROGRAM_END_DATE = "PART_PROGRAM_END_DATE";
            internal const string PART_PROGRAM_SUBTYPE = "PART_PROGRAM_SUBTYPE";
            internal const string PART_RELATIONSHIP = "PART_RELATIONSHIP";
            internal const string PART_CREATED_BY = "PART_CREATED_BY";
            internal const string PART_CREATED_TIMESTAMP = "PART_CREATED_TIMESTAMP";
            internal const string PART_LAST_MODIFIED_BY = "PART_LAST_MODIFIED_BY";
            internal const string PART_LAST_MODIFIED_TMST = "PART_LAST_MODIFIED_TMST";
            internal const string PART_FK_CSB_CASE_NO = "PART_FK_CSB_CASE_NO";
            internal const string PART_FK_PGB_PROG_TYPE = "PART_FK_PGB_PROG_TYPE";
            internal const string PART_FK_CLB_CLIENT_NO = "PART_FK_CLB_CLIENT_NO";
            internal const string DCLKSD_CLIENT_BASIC = "DCLKSD_CLIENT_BASIC";
            internal const string CLB_CLIENT_NUMBER = "CLB_CLIENT_NUMBER";
            internal const string CLB_CIS_PREFERRED_ID = "CLB_CIS_PREFERRED_ID";
        }
        #endregion

        #region Direct-access element properties
        public IField WRK_TM_SW { get { return GetElementByName<IField>(Names.WRK_TM_SW); } }
        public ICheckField WRK_FST_TM { get { return GetElementByName<ICheckField>(Names.WRK_FST_TM); } }
        public ICheckField WRK_LST_TM { get { return GetElementByName<ICheckField>(Names.WRK_LST_TM); } }
        public IField WRK_DB_CD { get { return GetElementByName<IField>(Names.WRK_DB_CD); } }
        public ICheckField WRK_ARC_DB { get { return GetElementByName<ICheckField>(Names.WRK_ARC_DB); } }
        public ICheckField WRK_BEN_DB { get { return GetElementByName<ICheckField>(Names.WRK_BEN_DB); } }
        public ICheckField WRK_PRT_DB { get { return GetElementByName<ICheckField>(Names.WRK_PRT_DB); } }
        public IField WRK_RET_CD { get { return GetElementByName<IField>(Names.WRK_RET_CD); } }
        public ICheckField WRK_NO_ERR { get { return GetElementByName<ICheckField>(Names.WRK_NO_ERR); } }
        public ICheckField WRK_EOF_ERR { get { return GetElementByName<ICheckField>(Names.WRK_EOF_ERR); } }
        public ICheckField WRK_ADA_ERR { get { return GetElementByName<ICheckField>(Names.WRK_ADA_ERR); } }
        public IGroup WRK_ERR_MSG { get { return GetElementByName<IGroup>(Names.WRK_ERR_MSG); } }
        public IField WRK_ERR_CD { get { return GetElementByName<IField>(Names.WRK_ERR_CD); } }
        public IField WRK_ERR_TXT { get { return GetElementByName<IField>(Names.WRK_ERR_TXT); } }
        public IField WRK_BEN_FND_SW { get { return GetElementByName<IField>(Names.WRK_BEN_FND_SW); } }
        public ICheckField WRK_BEN_FND { get { return GetElementByName<ICheckField>(Names.WRK_BEN_FND); } }
        public IField WRK_PRT_FND_SW { get { return GetElementByName<IField>(Names.WRK_PRT_FND_SW); } }
        public ICheckField WRK_PRT_FND { get { return GetElementByName<ICheckField>(Names.WRK_PRT_FND); } }
        public IGroup WRK_BEN_DT { get { return GetElementByName<IGroup>(Names.WRK_BEN_DT); } }
        public IField WRK_BEN_YM { get { return GetElementByName<IField>(Names.WRK_BEN_YM); } }
        public IField WRK_BEN_DD { get { return GetElementByName<IField>(Names.WRK_BEN_DD); } }
        public IField WRK_FST_YM { get { return GetElementByName<IField>(Names.WRK_FST_YM); } }
        public IGroup WRK_DB2_AREA { get { return GetElementByName<IGroup>(Names.WRK_DB2_AREA); } }
        public IField WRK_DATE_0002 { get { return GetElementByName<IField>(Names.WRK_DATE_0002); } }
        public IField WRK_DATE_AREA { get { return GetElementByName<IField>(Names.WRK_DATE_AREA); } }
        public IGroup DCLKSD_BENEFITS { get { return GetElementByName<IGroup>(Names.DCLKSD_BENEFITS); } }
        public IField BEN_BUDGETING_METHOD { get { return GetElementByName<IField>(Names.BEN_BUDGETING_METHOD); } }
        public IField BEN_BENEFIT_TYPE { get { return GetElementByName<IField>(Names.BEN_BENEFIT_TYPE); } }
        public IField BEN_PAYEE_STREET1 { get { return GetElementByName<IField>(Names.BEN_PAYEE_STREET1); } }
        public IField BEN_PAYEE_STREET2 { get { return GetElementByName<IField>(Names.BEN_PAYEE_STREET2); } }
        public IField BEN_PAYEE_CITY { get { return GetElementByName<IField>(Names.BEN_PAYEE_CITY); } }
        public IField BEN_PAYEE_STATE { get { return GetElementByName<IField>(Names.BEN_PAYEE_STATE); } }
        public IField BEN_PAYEE_ZIP_CODE { get { return GetElementByName<IField>(Names.BEN_PAYEE_ZIP_CODE); } }
        public IField BEN_PAYEE_ZIP_PLUS_4 { get { return GetElementByName<IField>(Names.BEN_PAYEE_ZIP_PLUS_4); } }
        public IField BEN_PAYMENT_START_DATE { get { return GetElementByName<IField>(Names.BEN_PAYMENT_START_DATE); } }
        public IField BEN_PAYMENT_END_DATE { get { return GetElementByName<IField>(Names.BEN_PAYMENT_END_DATE); } }
        public IField BEN_COUNTABLE_INCOME { get { return GetElementByName<IField>(Names.BEN_COUNTABLE_INCOME); } }
        public IField BEN_DEPENDENT_CARE { get { return GetElementByName<IField>(Names.BEN_DEPENDENT_CARE); } }
        public IField BEN_RECOUPED_AMT { get { return GetElementByName<IField>(Names.BEN_RECOUPED_AMT); } }
        public IField BEN_NUM_OF_CHILDREN { get { return GetElementByName<IField>(Names.BEN_NUM_OF_CHILDREN); } }
        public IField BEN_NUMBER_IN_HH { get { return GetElementByName<IField>(Names.BEN_NUMBER_IN_HH); } }
        public IField BEN_ISSUED_DATE { get { return GetElementByName<IField>(Names.BEN_ISSUED_DATE); } }
        public IField BEN_ISSUED_AMT { get { return GetElementByName<IField>(Names.BEN_ISSUED_AMT); } }
        public IField BEN_ISSUANCE_TYPE { get { return GetElementByName<IField>(Names.BEN_ISSUANCE_TYPE); } }
        public IField BEN_HOUSEHOLD_SIZE { get { return GetElementByName<IField>(Names.BEN_HOUSEHOLD_SIZE); } }
        public IField BEN_HOUSEHOLD_TYPE { get { return GetElementByName<IField>(Names.BEN_HOUSEHOLD_TYPE); } }
        public IField BEN_CSE_PROC_FLAG { get { return GetElementByName<IField>(Names.BEN_CSE_PROC_FLAG); } }
        public IField BEN_BENEFIT_AMT { get { return GetElementByName<IField>(Names.BEN_BENEFIT_AMT); } }
        public IField BEN_THIRTY_ONE_THIRD { get { return GetElementByName<IField>(Names.BEN_THIRTY_ONE_THIRD); } }
        public IField BEN_THIRTY_DISREGARD { get { return GetElementByName<IField>(Names.BEN_THIRTY_DISREGARD); } }
        public IField BEN_CREATED_TIMESTAMP { get { return GetElementByName<IField>(Names.BEN_CREATED_TIMESTAMP); } }
        public IField BEN_CREATED_BY { get { return GetElementByName<IField>(Names.BEN_CREATED_BY); } }
        public IField BEN_LAST_MODIFIED_BY { get { return GetElementByName<IField>(Names.BEN_LAST_MODIFIED_BY); } }
        public IField BEN_LAST_MODIFIED_TMST { get { return GetElementByName<IField>(Names.BEN_LAST_MODIFIED_TMST); } }
        public IField BEN_FK_CSB_CASE_NO { get { return GetElementByName<IField>(Names.BEN_FK_CSB_CASE_NO); } }
        public IField BEN_FK_PGB_PROG_TYPE { get { return GetElementByName<IField>(Names.BEN_FK_PGB_PROG_TYPE); } }
        public IField BEN_FK_PMO_PROG_SUBT { get { return GetElementByName<IField>(Names.BEN_FK_PMO_PROG_SUBT); } }
        public IField BEN_FK_PMO_PROG_BEN_MO { get { return GetElementByName<IField>(Names.BEN_FK_PMO_PROG_BEN_MO); } }
        public IGroup DCLKSD_BENEFITS_ARCHV { get { return GetElementByName<IGroup>(Names.DCLKSD_BENEFITS_ARCHV); } }
        public IField BENA_CASE_NUMBER { get { return GetElementByName<IField>(Names.BENA_CASE_NUMBER); } }
        public IField BENA_PROGRAM_TYPE { get { return GetElementByName<IField>(Names.BENA_PROGRAM_TYPE); } }
        public IField BENA_PROGRAM_SUBTYPE { get { return GetElementByName<IField>(Names.BENA_PROGRAM_SUBTYPE); } }
        public IField BENA_BENEFIT_MONTH { get { return GetElementByName<IField>(Names.BENA_BENEFIT_MONTH); } }
        public IField BENA_ISSUANCE_TYPE { get { return GetElementByName<IField>(Names.BENA_ISSUANCE_TYPE); } }
        public IField BENA_BENEFIT_TYPE { get { return GetElementByName<IField>(Names.BENA_BENEFIT_TYPE); } }
        public IField BENA_BUDGETING_METHOD { get { return GetElementByName<IField>(Names.BENA_BUDGETING_METHOD); } }
        public IField BENA_ISSUED_DATE { get { return GetElementByName<IField>(Names.BENA_ISSUED_DATE); } }
        public IField BENA_PAYMENT_START_DATE { get { return GetElementByName<IField>(Names.BENA_PAYMENT_START_DATE); } }
        public IField BENA_PAYMENT_END_DATE { get { return GetElementByName<IField>(Names.BENA_PAYMENT_END_DATE); } }
        public IField BENA_CREATED_BY { get { return GetElementByName<IField>(Names.BENA_CREATED_BY); } }
        public IField BENA_CREATED_TIMESTAMP { get { return GetElementByName<IField>(Names.BENA_CREATED_TIMESTAMP); } }
        public IGroup DCLKSD_PARTICIPATION { get { return GetElementByName<IGroup>(Names.DCLKSD_PARTICIPATION); } }
        public IField PART_KESSEP_TIME_STMP { get { return GetElementByName<IField>(Names.PART_KESSEP_TIME_STMP); } }
        public IField PART_PART_END_DATE { get { return GetElementByName<IField>(Names.PART_PART_END_DATE); } }
        public IField PART_PART_START_DATE { get { return GetElementByName<IField>(Names.PART_PART_START_DATE); } }
        public IField PART_PART_CODE { get { return GetElementByName<IField>(Names.PART_PART_CODE); } }
        public IField PART_PROGRAM_END_DATE { get { return GetElementByName<IField>(Names.PART_PROGRAM_END_DATE); } }
        public IField PART_PROGRAM_SUBTYPE { get { return GetElementByName<IField>(Names.PART_PROGRAM_SUBTYPE); } }
        public IField PART_RELATIONSHIP { get { return GetElementByName<IField>(Names.PART_RELATIONSHIP); } }
        public IField PART_CREATED_BY { get { return GetElementByName<IField>(Names.PART_CREATED_BY); } }
        public IField PART_CREATED_TIMESTAMP { get { return GetElementByName<IField>(Names.PART_CREATED_TIMESTAMP); } }
        public IField PART_LAST_MODIFIED_BY { get { return GetElementByName<IField>(Names.PART_LAST_MODIFIED_BY); } }
        public IField PART_LAST_MODIFIED_TMST { get { return GetElementByName<IField>(Names.PART_LAST_MODIFIED_TMST); } }
        public IField PART_FK_CSB_CASE_NO { get { return GetElementByName<IField>(Names.PART_FK_CSB_CASE_NO); } }
        public IField PART_FK_PGB_PROG_TYPE { get { return GetElementByName<IField>(Names.PART_FK_PGB_PROG_TYPE); } }
        public IField PART_FK_CLB_CLIENT_NO { get { return GetElementByName<IField>(Names.PART_FK_CLB_CLIENT_NO); } }
        public IGroup DCLKSD_CLIENT_BASIC { get { return GetElementByName<IGroup>(Names.DCLKSD_CLIENT_BASIC); } }
        public IField CLB_CLIENT_NUMBER { get { return GetElementByName<IField>(Names.CLB_CLIENT_NUMBER); } }
        public IField CLB_CIS_PREFERRED_ID { get { return GetElementByName<IField>(Names.CLB_CIS_PREFERRED_ID); } }

        public CPY_SQLCA SQLCA = new CPY_SQLCA(null, true);
        #endregion

        #region Data structure definition
        /// <summary>
        /// Defines the entirety of the WorkingStorage IRecord structure as described by the Ateras.Framework.Buffer API.
        /// </summary>
        /// <param name="recordDef">The IStructureDefinition object to be used in defining the record structure.</param>
        protected override void DefineRecordStructure(IStructureDefinition recordDef)
        {
            recordDef.CreateNewField(Names.WRK_TM_SW, FieldType.String, 1)
                .NewCheckField(Names.WRK_FST_TM, "F")
                .NewCheckField(Names.WRK_LST_TM, "L")
                ;
            recordDef.CreateNewField(Names.WRK_DB_CD, FieldType.String, 1)
                .NewCheckField(Names.WRK_ARC_DB, "A")
                .NewCheckField(Names.WRK_BEN_DB, "B")
                .NewCheckField(Names.WRK_PRT_DB, "P")
                ;
            recordDef.CreateNewField(Names.WRK_RET_CD, FieldType.CompInt, 8)
                .NewCheckField(Names.WRK_NO_ERR, 0)
                .NewCheckField(Names.WRK_EOF_ERR, +100)
                .NewCheckFieldRange(Names.WRK_ADA_ERR, -99999999, -1)
                ;

            recordDef.CreateNewGroup(Names.WRK_ERR_MSG, (WRK_ERR_MSG) =>
           {
               WRK_ERR_MSG.CreateNewField(Names.WRK_ERR_CD, FieldType.UnsignedNumeric, 2);
               WRK_ERR_MSG.CreateNewFillerField(FieldType.String, 1, SPACE);
               WRK_ERR_MSG.CreateNewField(Names.WRK_ERR_TXT, FieldType.String, 77);
           });
            recordDef.CreateNewField(Names.WRK_BEN_FND_SW, FieldType.String, 1)
                .NewCheckField(Names.WRK_BEN_FND, "Y")
                ;
            recordDef.CreateNewField(Names.WRK_PRT_FND_SW, FieldType.String, 1)
                .NewCheckField(Names.WRK_PRT_FND, "Y")
                ;

            recordDef.CreateNewGroup(Names.WRK_BEN_DT, (WRK_BEN_DT) =>
           {
               WRK_BEN_DT.CreateNewField(Names.WRK_BEN_YM, FieldType.UnsignedNumeric, 6);
               WRK_BEN_DT.CreateNewField(Names.WRK_BEN_DD, FieldType.UnsignedNumeric, 2, 1);
           });
            recordDef.CreateNewField(Names.WRK_FST_YM, FieldType.UnsignedNumeric, 6);

            recordDef.CreateNewGroup(Names.WRK_DB2_AREA, (WRK_DB2_AREA) =>
           {
               WRK_DB2_AREA.CreateNewField(Names.WRK_DATE_0002, FieldType.String, 10);
           });
            recordDef.CreateNewField(Names.WRK_DATE_AREA, FieldType.String, 8);

            recordDef.CreateNewGroup(Names.DCLKSD_BENEFITS, (DCLKSD_BENEFITS) =>
           {
               DCLKSD_BENEFITS.CreateNewField(Names.BEN_BUDGETING_METHOD, FieldType.String, 1);
               DCLKSD_BENEFITS.CreateNewField(Names.BEN_BENEFIT_TYPE, FieldType.String, 2);
               DCLKSD_BENEFITS.CreateNewField(Names.BEN_PAYEE_STREET1, FieldType.String, 30);
               DCLKSD_BENEFITS.CreateNewField(Names.BEN_PAYEE_STREET2, FieldType.String, 30);
               DCLKSD_BENEFITS.CreateNewField(Names.BEN_PAYEE_CITY, FieldType.String, 30);
               DCLKSD_BENEFITS.CreateNewField(Names.BEN_PAYEE_STATE, FieldType.String, 2);
               DCLKSD_BENEFITS.CreateNewField(Names.BEN_PAYEE_ZIP_CODE, FieldType.CompInt, 9);
               DCLKSD_BENEFITS.CreateNewField(Names.BEN_PAYEE_ZIP_PLUS_4, FieldType.CompShort, 4);
               DCLKSD_BENEFITS.CreateNewField(Names.BEN_PAYMENT_START_DATE, FieldType.String, 10);
               DCLKSD_BENEFITS.CreateNewField(Names.BEN_PAYMENT_END_DATE, FieldType.String, 10);
               DCLKSD_BENEFITS.CreateNewField(Names.BEN_COUNTABLE_INCOME, FieldType.PackedDecimal, 8, null, 2);
               DCLKSD_BENEFITS.CreateNewField(Names.BEN_DEPENDENT_CARE, FieldType.PackedDecimal, 8, null, 2);
               DCLKSD_BENEFITS.CreateNewField(Names.BEN_RECOUPED_AMT, FieldType.PackedDecimal, 8, null, 2);
               DCLKSD_BENEFITS.CreateNewField(Names.BEN_NUM_OF_CHILDREN, FieldType.CompShort, 4);
               DCLKSD_BENEFITS.CreateNewField(Names.BEN_NUMBER_IN_HH, FieldType.CompShort, 4);
               DCLKSD_BENEFITS.CreateNewField(Names.BEN_ISSUED_DATE, FieldType.String, 10);
               DCLKSD_BENEFITS.CreateNewField(Names.BEN_ISSUED_AMT, FieldType.PackedDecimal, 8, null, 2);
               DCLKSD_BENEFITS.CreateNewField(Names.BEN_ISSUANCE_TYPE, FieldType.String, 2);
               DCLKSD_BENEFITS.CreateNewField(Names.BEN_HOUSEHOLD_SIZE, FieldType.CompShort, 4);
               DCLKSD_BENEFITS.CreateNewField(Names.BEN_HOUSEHOLD_TYPE, FieldType.String, 3);
               DCLKSD_BENEFITS.CreateNewField(Names.BEN_CSE_PROC_FLAG, FieldType.String, 1);
               DCLKSD_BENEFITS.CreateNewField(Names.BEN_BENEFIT_AMT, FieldType.PackedDecimal, 8, null, 2);
               DCLKSD_BENEFITS.CreateNewField(Names.BEN_THIRTY_ONE_THIRD, FieldType.PackedDecimal, 8, null, 2);
               DCLKSD_BENEFITS.CreateNewField(Names.BEN_THIRTY_DISREGARD, FieldType.PackedDecimal, 8, null, 2);
               DCLKSD_BENEFITS.CreateNewField(Names.BEN_CREATED_TIMESTAMP, FieldType.String, 26);
               DCLKSD_BENEFITS.CreateNewField(Names.BEN_CREATED_BY, FieldType.String, 8);
               DCLKSD_BENEFITS.CreateNewField(Names.BEN_LAST_MODIFIED_BY, FieldType.String, 8);
               DCLKSD_BENEFITS.CreateNewField(Names.BEN_LAST_MODIFIED_TMST, FieldType.String, 26);
               DCLKSD_BENEFITS.CreateNewField(Names.BEN_FK_CSB_CASE_NO, FieldType.String, 8);
               DCLKSD_BENEFITS.CreateNewField(Names.BEN_FK_PGB_PROG_TYPE, FieldType.String, 2);
               DCLKSD_BENEFITS.CreateNewField(Names.BEN_FK_PMO_PROG_SUBT, FieldType.String, 2);
               DCLKSD_BENEFITS.CreateNewField(Names.BEN_FK_PMO_PROG_BEN_MO, FieldType.CompInt, 9);
           });

            recordDef.CreateNewGroup(Names.DCLKSD_BENEFITS_ARCHV, (DCLKSD_BENEFITS_ARCHV) =>
           {
               DCLKSD_BENEFITS_ARCHV.CreateNewField(Names.BENA_CASE_NUMBER, FieldType.String, 8);
               DCLKSD_BENEFITS_ARCHV.CreateNewField(Names.BENA_PROGRAM_TYPE, FieldType.String, 2);
               DCLKSD_BENEFITS_ARCHV.CreateNewField(Names.BENA_PROGRAM_SUBTYPE, FieldType.String, 2);
               DCLKSD_BENEFITS_ARCHV.CreateNewField(Names.BENA_BENEFIT_MONTH, FieldType.CompInt, 9);
               DCLKSD_BENEFITS_ARCHV.CreateNewField(Names.BENA_ISSUANCE_TYPE, FieldType.String, 2);
               DCLKSD_BENEFITS_ARCHV.CreateNewField(Names.BENA_BENEFIT_TYPE, FieldType.String, 2);
               DCLKSD_BENEFITS_ARCHV.CreateNewField(Names.BENA_BUDGETING_METHOD, FieldType.String, 1);
               DCLKSD_BENEFITS_ARCHV.CreateNewField(Names.BENA_ISSUED_DATE, FieldType.String, 10);
               DCLKSD_BENEFITS_ARCHV.CreateNewField(Names.BENA_PAYMENT_START_DATE, FieldType.String, 10);
               DCLKSD_BENEFITS_ARCHV.CreateNewField(Names.BENA_PAYMENT_END_DATE, FieldType.String, 10);
               DCLKSD_BENEFITS_ARCHV.CreateNewField(Names.BENA_CREATED_BY, FieldType.String, 8);
               DCLKSD_BENEFITS_ARCHV.CreateNewField(Names.BENA_CREATED_TIMESTAMP, FieldType.String, 26);
           });

            recordDef.CreateNewGroup(Names.DCLKSD_PARTICIPATION, (DCLKSD_PARTICIPATION) =>
           {
               DCLKSD_PARTICIPATION.CreateNewField(Names.PART_KESSEP_TIME_STMP, FieldType.String, 20);
               DCLKSD_PARTICIPATION.CreateNewField(Names.PART_PART_END_DATE, FieldType.String, 10);
               DCLKSD_PARTICIPATION.CreateNewField(Names.PART_PART_START_DATE, FieldType.String, 10);
               DCLKSD_PARTICIPATION.CreateNewField(Names.PART_PART_CODE, FieldType.String, 2);
               DCLKSD_PARTICIPATION.CreateNewField(Names.PART_PROGRAM_END_DATE, FieldType.String, 10);
               DCLKSD_PARTICIPATION.CreateNewField(Names.PART_PROGRAM_SUBTYPE, FieldType.String, 2);
               DCLKSD_PARTICIPATION.CreateNewField(Names.PART_RELATIONSHIP, FieldType.String, 2);
               DCLKSD_PARTICIPATION.CreateNewField(Names.PART_CREATED_BY, FieldType.String, 8);
               DCLKSD_PARTICIPATION.CreateNewField(Names.PART_CREATED_TIMESTAMP, FieldType.String, 26);
               DCLKSD_PARTICIPATION.CreateNewField(Names.PART_LAST_MODIFIED_BY, FieldType.String, 8);
               DCLKSD_PARTICIPATION.CreateNewField(Names.PART_LAST_MODIFIED_TMST, FieldType.String, 26);
               DCLKSD_PARTICIPATION.CreateNewField(Names.PART_FK_CSB_CASE_NO, FieldType.String, 8);
               DCLKSD_PARTICIPATION.CreateNewField(Names.PART_FK_PGB_PROG_TYPE, FieldType.String, 2);
               DCLKSD_PARTICIPATION.CreateNewField(Names.PART_FK_CLB_CLIENT_NO, FieldType.String, 10);
           });

            recordDef.CreateNewGroup(Names.DCLKSD_CLIENT_BASIC, (DCLKSD_CLIENT_BASIC) =>
           {
               DCLKSD_CLIENT_BASIC.CreateNewField(Names.CLB_CLIENT_NUMBER, FieldType.String, 10);
               DCLKSD_CLIENT_BASIC.CreateNewField(Names.CLB_CIS_PREFERRED_ID, FieldType.String, 10);
           });


        }

        protected override string GetRecordName()
        {
            return Names.WorkingStorage;
        }
        #endregion

        #region Initialize
        public override void Initialize()
        {
            InitializeWithLowValues();
            SQLCA.InitializeWithLowValues();
        }
        #endregion

    }
    #endregion Working Storage Class

    #region Linkage Section Class
    internal class SWEXOE04_ls : PredefinedRecordBase
    {
        #region Name constants
        /// <summary>
        /// Name constants.
        /// </summary>
        internal static class Names
        {
            internal const string LinkageSection = "SWEXOE04_ls_LinkageSection";
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
            internal const string IMP_0001EV = "IMP_0001EV";
            internal const string CSE_PERSON_0001ET = "CSE_PERSON_0001ET";
            internal const string NUMBER_0001AS = "NUMBER_0001AS";
            internal const string NUMBER_0001 = "NUMBER_0001";
            internal const string NUMBER_0001XX = "NUMBER_0001XX";
            internal const string IMPORT_ON_FC_DATE_0002EV = "IMPORT_ON_FC_DATE_0002EV";
            internal const string DATE_WORK_AREA_0002ET = "DATE_WORK_AREA_0002ET";
            internal const string DATE_0002AS = "DATE_0002AS";
            internal const string DATE_0002 = "DATE_0002";
            internal const string DATE_0002XX = "DATE_0002XX";
            internal const string IMP_ADABAS_EXTERNAL_ACT_0003EV = "IMP_ADABAS_EXTERNAL_ACT_0003EV";
            internal const string IEF_SUPPLIED_0003ET = "IEF_SUPPLIED_0003ET";
            internal const string FLAG_0003AS = "FLAG_0003AS";
            internal const string FLAG_0003 = "FLAG_0003";
            internal const string FLAG_0003XX = "FLAG_0003XX";
            internal const string EXP_0004EV = "EXP_0004EV";
            internal const string IM_HOUSEHOLD_0004ET = "IM_HOUSEHOLD_0004ET";
            internal const string AE_CASE_NO_0004AS = "AE_CASE_NO_0004AS";
            internal const string AE_CASE_NO_0004 = "AE_CASE_NO_0004";
            internal const string AE_CASE_NO_0004XX = "AE_CASE_NO_0004XX";
            internal const string FIRST_BENEFIT_DATE_0004AS = "FIRST_BENEFIT_DATE_0004AS";
            internal const string FIRST_BENEFIT_DATE_0004 = "FIRST_BENEFIT_DATE_0004";
            internal const string FIRST_BENEFIT_DATE_0004XX = "FIRST_BENEFIT_DATE_0004XX";
            internal const string EXP_0005EV = "EXP_0005EV";
            internal const string IM_HOUSEHOLD_MBR_MNTHLY_0005ET = "IM_HOUSEHOLD_MBR_MNTHLY_0005ET";
            internal const string RELATIONSHIP_0005AS = "RELATIONSHIP_0005AS";
            internal const string RELATIONSHIP_0005 = "RELATIONSHIP_0005";
            internal const string RELATIONSHIP_0005XX = "RELATIONSHIP_0005XX";
            internal const string EXPORT_EXEC_RESULTS_0006EV = "EXPORT_EXEC_RESULTS_0006EV";
            internal const string WORK_AREA_0006ET = "WORK_AREA_0006ET";
            internal const string TEXT_5_0006AS = "TEXT_5_0006AS";
            internal const string TEXT_5_0006 = "TEXT_5_0006";
            internal const string TEXT_5_0006XX = "TEXT_5_0006XX";
            internal const string TEXT_80_0006AS = "TEXT_80_0006AS";
            internal const string TEXT_80_0006 = "TEXT_80_0006";
            internal const string TEXT_80_0006XX = "TEXT_80_0006XX";
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
        public IGroup IMP_0001EV { get { return GetElementByName<IGroup>(Names.IMP_0001EV); } }
        public IGroup CSE_PERSON_0001ET { get { return GetElementByName<IGroup>(Names.CSE_PERSON_0001ET); } }
        public IField NUMBER_0001AS { get { return GetElementByName<IField>(Names.NUMBER_0001AS); } }
        public IField NUMBER_0001 { get { return GetElementByName<IField>(Names.NUMBER_0001); } }
        public IField NUMBER_0001XX { get { return GetElementByName<IField>(Names.NUMBER_0001XX); } }
        public IGroup IMPORT_ON_FC_DATE_0002EV { get { return GetElementByName<IGroup>(Names.IMPORT_ON_FC_DATE_0002EV); } }
        public IGroup DATE_WORK_AREA_0002ET { get { return GetElementByName<IGroup>(Names.DATE_WORK_AREA_0002ET); } }
        public IField DATE_0002AS { get { return GetElementByName<IField>(Names.DATE_0002AS); } }
        public IField DATE_0002 { get { return GetElementByName<IField>(Names.DATE_0002); } }
        public IField DATE_0002XX { get { return GetElementByName<IField>(Names.DATE_0002XX); } }
        public IGroup IMP_ADABAS_EXTERNAL_ACT_0003EV { get { return GetElementByName<IGroup>(Names.IMP_ADABAS_EXTERNAL_ACT_0003EV); } }
        public IGroup IEF_SUPPLIED_0003ET { get { return GetElementByName<IGroup>(Names.IEF_SUPPLIED_0003ET); } }
        public IField FLAG_0003AS { get { return GetElementByName<IField>(Names.FLAG_0003AS); } }
        public IField FLAG_0003 { get { return GetElementByName<IField>(Names.FLAG_0003); } }
        public IField FLAG_0003XX { get { return GetElementByName<IField>(Names.FLAG_0003XX); } }
        public IGroup EXP_0004EV { get { return GetElementByName<IGroup>(Names.EXP_0004EV); } }
        public IGroup IM_HOUSEHOLD_0004ET { get { return GetElementByName<IGroup>(Names.IM_HOUSEHOLD_0004ET); } }
        public IField AE_CASE_NO_0004AS { get { return GetElementByName<IField>(Names.AE_CASE_NO_0004AS); } }
        public IField AE_CASE_NO_0004 { get { return GetElementByName<IField>(Names.AE_CASE_NO_0004); } }
        public IField AE_CASE_NO_0004XX { get { return GetElementByName<IField>(Names.AE_CASE_NO_0004XX); } }
        public IField FIRST_BENEFIT_DATE_0004AS { get { return GetElementByName<IField>(Names.FIRST_BENEFIT_DATE_0004AS); } }
        public IField FIRST_BENEFIT_DATE_0004 { get { return GetElementByName<IField>(Names.FIRST_BENEFIT_DATE_0004); } }
        public IField FIRST_BENEFIT_DATE_0004XX { get { return GetElementByName<IField>(Names.FIRST_BENEFIT_DATE_0004XX); } }
        public IGroup EXP_0005EV { get { return GetElementByName<IGroup>(Names.EXP_0005EV); } }
        public IGroup IM_HOUSEHOLD_MBR_MNTHLY_0005ET { get { return GetElementByName<IGroup>(Names.IM_HOUSEHOLD_MBR_MNTHLY_0005ET); } }
        public IField RELATIONSHIP_0005AS { get { return GetElementByName<IField>(Names.RELATIONSHIP_0005AS); } }
        public IField RELATIONSHIP_0005 { get { return GetElementByName<IField>(Names.RELATIONSHIP_0005); } }
        public IField RELATIONSHIP_0005XX { get { return GetElementByName<IField>(Names.RELATIONSHIP_0005XX); } }
        public IGroup EXPORT_EXEC_RESULTS_0006EV { get { return GetElementByName<IGroup>(Names.EXPORT_EXEC_RESULTS_0006EV); } }
        public IGroup WORK_AREA_0006ET { get { return GetElementByName<IGroup>(Names.WORK_AREA_0006ET); } }
        public IField TEXT_5_0006AS { get { return GetElementByName<IField>(Names.TEXT_5_0006AS); } }
        public IField TEXT_5_0006 { get { return GetElementByName<IField>(Names.TEXT_5_0006); } }
        public IField TEXT_5_0006XX { get { return GetElementByName<IField>(Names.TEXT_5_0006XX); } }
        public IField TEXT_80_0006AS { get { return GetElementByName<IField>(Names.TEXT_80_0006AS); } }
        public IField TEXT_80_0006 { get { return GetElementByName<IField>(Names.TEXT_80_0006); } }
        public IField TEXT_80_0006XX { get { return GetElementByName<IField>(Names.TEXT_80_0006XX); } }

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
                   PSMGR_TIRDATE_CMCB.CreateNewGroupRedefine("FILLER_d6", PSMGR_TIRDATE_TSTAMP_local, (FILLER_d6) =>
                   {
                       FILLER_d6.CreateNewField(Names.PSMGR_TIRDATE_DATE_Z, FieldType.UnsignedNumeric, 8);
                       FILLER_d6.CreateNewField(Names.PSMGR_TIRDATE_TIME_Z, FieldType.UnsignedNumeric, 8);
                       FILLER_d6.CreateNewFillerField(4, FillWith.Hashes);
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

            recordDef.CreateNewGroup(Names.IMP_0001EV, (IMP_0001EV) =>
           {
               IMP_0001EV.CreateNewGroup(Names.CSE_PERSON_0001ET, (CSE_PERSON_0001ET) =>
               {
                   CSE_PERSON_0001ET.CreateNewField(Names.NUMBER_0001AS, FieldType.String, 1);

                   IField NUMBER_0001_local = CSE_PERSON_0001ET.CreateNewField(Names.NUMBER_0001, FieldType.String, 10);
                   CSE_PERSON_0001ET.CreateNewFieldRedefine(Names.NUMBER_0001XX, FieldType.String, NUMBER_0001_local, 10);
               });
           });

            recordDef.CreateNewGroup(Names.IMPORT_ON_FC_DATE_0002EV, (IMPORT_ON_FC_DATE_0002EV) =>
           {
               IMPORT_ON_FC_DATE_0002EV.CreateNewGroup(Names.DATE_WORK_AREA_0002ET, (DATE_WORK_AREA_0002ET) =>
               {
                   DATE_WORK_AREA_0002ET.CreateNewField(Names.DATE_0002AS, FieldType.String, 1);

                   IField DATE_0002_local = DATE_WORK_AREA_0002ET.CreateNewField(Names.DATE_0002, FieldType.SignedNumeric, 8);
                   DATE_WORK_AREA_0002ET.CreateNewFieldRedefine(Names.DATE_0002XX, FieldType.String, DATE_0002_local, 8);
               });
           });

            recordDef.CreateNewGroup(Names.IMP_ADABAS_EXTERNAL_ACT_0003EV, (IMP_ADABAS_EXTERNAL_ACT_0003EV) =>
           {
               IMP_ADABAS_EXTERNAL_ACT_0003EV.CreateNewGroup(Names.IEF_SUPPLIED_0003ET, (IEF_SUPPLIED_0003ET) =>
               {
                   IEF_SUPPLIED_0003ET.CreateNewField(Names.FLAG_0003AS, FieldType.String, 1);

                   IField FLAG_0003_local = IEF_SUPPLIED_0003ET.CreateNewField(Names.FLAG_0003, FieldType.String, 1);
                   IEF_SUPPLIED_0003ET.CreateNewFieldRedefine(Names.FLAG_0003XX, FieldType.String, FLAG_0003_local, 1);
               });
           });

            recordDef.CreateNewGroup(Names.EXP_0004EV, (EXP_0004EV) =>
           {
               EXP_0004EV.CreateNewGroup(Names.IM_HOUSEHOLD_0004ET, (IM_HOUSEHOLD_0004ET) =>
               {
                   IM_HOUSEHOLD_0004ET.CreateNewField(Names.AE_CASE_NO_0004AS, FieldType.String, 1);

                   IField AE_CASE_NO_0004_local = IM_HOUSEHOLD_0004ET.CreateNewField(Names.AE_CASE_NO_0004, FieldType.String, 8);
                   IM_HOUSEHOLD_0004ET.CreateNewFieldRedefine(Names.AE_CASE_NO_0004XX, FieldType.String, AE_CASE_NO_0004_local, 8);
                   IM_HOUSEHOLD_0004ET.CreateNewField(Names.FIRST_BENEFIT_DATE_0004AS, FieldType.String, 1);

                   IField FIRST_BENEFIT_DATE_0004_local = IM_HOUSEHOLD_0004ET.CreateNewField(Names.FIRST_BENEFIT_DATE_0004, FieldType.SignedNumeric, 8);
                   IM_HOUSEHOLD_0004ET.CreateNewFieldRedefine(Names.FIRST_BENEFIT_DATE_0004XX, FieldType.String, FIRST_BENEFIT_DATE_0004_local, 8);
               });
           });

            recordDef.CreateNewGroup(Names.EXP_0005EV, (EXP_0005EV) =>
           {
               EXP_0005EV.CreateNewGroup(Names.IM_HOUSEHOLD_MBR_MNTHLY_0005ET, (IM_HOUSEHOLD_MBR_MNTHLY_0005ET) =>
               {
                   IM_HOUSEHOLD_MBR_MNTHLY_0005ET.CreateNewField(Names.RELATIONSHIP_0005AS, FieldType.String, 1);

                   IField RELATIONSHIP_0005_local = IM_HOUSEHOLD_MBR_MNTHLY_0005ET.CreateNewField(Names.RELATIONSHIP_0005, FieldType.String, 2);
                   IM_HOUSEHOLD_MBR_MNTHLY_0005ET.CreateNewFieldRedefine(Names.RELATIONSHIP_0005XX, FieldType.String, RELATIONSHIP_0005_local, 2);
               });
           });

            recordDef.CreateNewGroup(Names.EXPORT_EXEC_RESULTS_0006EV, (EXPORT_EXEC_RESULTS_0006EV) =>
           {
               EXPORT_EXEC_RESULTS_0006EV.CreateNewGroup(Names.WORK_AREA_0006ET, (WORK_AREA_0006ET) =>
               {
                   WORK_AREA_0006ET.CreateNewField(Names.TEXT_5_0006AS, FieldType.String, 1);

                   IField TEXT_5_0006_local = WORK_AREA_0006ET.CreateNewField(Names.TEXT_5_0006, FieldType.String, 5);
                   WORK_AREA_0006ET.CreateNewFieldRedefine(Names.TEXT_5_0006XX, FieldType.String, TEXT_5_0006_local, 5);
                   WORK_AREA_0006ET.CreateNewField(Names.TEXT_80_0006AS, FieldType.String, 1);

                   IField TEXT_80_0006_local = WORK_AREA_0006ET.CreateNewField(Names.TEXT_80_0006, FieldType.String, 80);
                   WORK_AREA_0006ET.CreateNewFieldRedefine(Names.TEXT_80_0006XX, FieldType.String, TEXT_80_0006_local, 80);
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
            SetPassedParm(IMP_0001EV, args, 3);
            SetPassedParm(IMPORT_ON_FC_DATE_0002EV, args, 4);
            SetPassedParm(IMP_ADABAS_EXTERNAL_ACT_0003EV, args, 5);
            SetPassedParm(EXP_0004EV, args, 6);
            SetPassedParm(EXP_0005EV, args, 7);
            SetPassedParm(EXPORT_EXEC_RESULTS_0006EV, args, 8);
        }


        public void UpdateReturnParameters(object[] args)
        {
            SetReturnParm(IEF_RUNTIME_PARM1, args, 0);
            SetReturnParm(IEF_RUNTIME_PARM2, args, 1);
            SetReturnParm(GLOBDATA, args, 2);
            SetReturnParm(IMP_0001EV, args, 3);
            SetReturnParm(IMPORT_ON_FC_DATE_0002EV, args, 4);
            SetReturnParm(IMP_ADABAS_EXTERNAL_ACT_0003EV, args, 5);
            SetReturnParm(EXP_0004EV, args, 6);
            SetReturnParm(EXP_0005EV, args, 7);
            SetReturnParm(EXPORT_EXEC_RESULTS_0006EV, args, 8);
        }
    }
    #endregion Linkage Section Class

    #region Business Logic Class
    public class SWEXOE04 : EABBase
    {

        #region Public Constructors
        public SWEXOE04()
            : base()
        {
            this.ProgramName.SetValue("SWEXOE04");

            WS = new SWEXOE04_ws();
            LS = new SWEXOE04_ls();
            DbConv.SQLCA.Record = WS.SQLCA.Record;

            DbConv.SetQueryText("PARTCSR", "SELECT KESSEP_TIME_STMP, PART_END_DATE, PART_START_DATE, PART_CODE, PROGRAM_END_DATE, PROGRAM_SUBTYPE, RELATIONSHIP, CREATED_BY, CREATED_TIMESTAMP, LAST_MODIFIED_BY, LAST_MODIFIED_TMST, FK_CSB_CASE_NO, FK_PGB_PROG_TYPE, FK_CLB_CLIENT_NO FROM KSD_PARTICIPATION WHERE FK_CLB_CLIENT_NO = {0}  AND FK_PGB_PROG_TYPE = {1}  AND FK_CSB_CASE_NO > {2}  AND PART_START_DATE > {3}  ORDER BY PART_START_DATE, FK_CSB_CASE_NO",  //COBOL==>EXEC SQL DECLARE PARTCSR CURSOR FOR SELECT KESSEP_TIME_STMP , PART_END_DATE , PART_START_DATE , PART_CODE , PROGRAM_END_DATE , PROGRAM_SUBTYPE , RELATIONSHIP , CREATED_BY , CREATED_TIMESTAMP , LAST_MODIFIED_BY , LAST_MODIFIED_TMST , FK_CSB_CASE_NO , FK_PGB_PROG_TYPE , FK_CLB_CLIENT_NO FROM KSD_PARTICIPATION WHERE FK_CLB_CLIENT_NO = :PART-FK-CLB-CLIENT-NO AND FK_PGB_PROG_TYPE = :PART-FK-PGB-PROG-TYPE AND FK_CSB_CASE_NO > :PART-FK-CSB-CASE-NO AND PART_START_DATE > :PART-PART-START-DATE ORDER BY PART_START_DATE , FK_CSB_CASE_NO END-EXEC
                                WS.PART_FK_CLB_CLIENT_NO, WS.PART_FK_PGB_PROG_TYPE, WS.PART_FK_CSB_CASE_NO, WS.PART_PART_START_DATE);

            DbConv.SetQueryText("BENCSR", "SELECT BUDGETING_METHOD, BENEFIT_TYPE, PAYEE_STREET1, PAYEE_STREET2, PAYEE_CITY, PAYEE_STATE, PAYEE_ZIP_CODE, PAYEE_ZIP_PLUS_4, PAYMENT_START_DATE, PAYMENT_END_DATE, COUNTABLE_INCOME, DEPENDENT_CARE, RECOUPED_AMT, NUM_OF_CHILDREN, NUMBER_IN_HH, ISSUED_DATE, ISSUED_AMT, ISSUANCE_TYPE, HOUSEHOLD_SIZE, HOUSEHOLD_TYPE, CSE_PROC_FLAG, BENEFIT_AMT, THIRTY_ONE_THIRD, THIRTY_DISREGARD, CREATED_TIMESTAMP, CREATED_BY, LAST_MODIFIED_BY, LAST_MODIFIED_TMST, FK_CSB_CASE_NO, FK_PGB_PROG_TYPE, FK_PMO_PROG_SUBT, FK_PMO_PROG_BEN_MO FROM KSD_BENEFITS WHERE FK_CSB_CASE_NO = {0}  AND FK_PGB_PROG_TYPE = {1}  AND FK_PMO_PROG_BEN_MO > {2}  ORDER BY FK_PMO_PROG_BEN_MO, PAYMENT_START_DATE, PAYMENT_END_DATE",  //COBOL==>EXEC SQL DECLARE BENCSR CURSOR FOR SELECT BUDGETING_METHOD , BENEFIT_TYPE , PAYEE_STREET1 , PAYEE_STREET2 , PAYEE_CITY , PAYEE_STATE , PAYEE_ZIP_CODE , PAYEE_ZIP_PLUS_4 , PAYMENT_START_DATE , PAYMENT_END_DATE , COUNTABLE_INCOME , DEPENDENT_CARE , RECOUPED_AMT , NUM_OF_CHILDREN , NUMBER_IN_HH , ISSUED_DATE , ISSUED_AMT , ISSUANCE_TYPE , HOUSEHOLD_SIZE , HOUSEHOLD_TYPE , CSE_PROC_FLAG , BENEFIT_AMT , THIRTY_ONE_THIRD , THIRTY_DISREGARD , CREATED_TIMESTAMP , CREATED_BY , LAST_MODIFIED_BY , LAST_MODIFIED_TMST , FK_CSB_CASE_NO , FK_PGB_PROG_TYPE , FK_PMO_PROG_SUBT , FK_PMO_PROG_BEN_MO FROM KSD_BENEFITS WHERE FK_CSB_CASE_NO = :BEN-FK-CSB-CASE-NO AND FK_PGB_PROG_TYPE = :BEN-FK-PGB-PROG-TYPE AND FK_PMO_PROG_BEN_MO > :BEN-FK-PMO-PROG-BEN-MO ORDER BY FK_PMO_PROG_BEN_MO , PAYMENT_START_DATE , PAYMENT_END_DATE END-EXEC
                                WS.BEN_FK_CSB_CASE_NO, WS.BEN_FK_PGB_PROG_TYPE, WS.BEN_FK_PMO_PROG_BEN_MO);

            DbConv.SetQueryText("BENACSR", "SELECT CASE_NUMBER, PROGRAM_TYPE, PROGRAM_SUBTYPE, BENEFIT_MONTH, ISSUANCE_TYPE, BENEFIT_TYPE, BUDGETING_METHOD, ISSUED_DATE, PAYMENT_START_DATE, PAYMENT_END_DATE, CREATED_BY, CREATED_TIMESTAMP FROM KSD_BENEFITS_ARCHV WHERE CASE_NUMBER = {0}  AND PROGRAM_TYPE = {1}  AND BENEFIT_MONTH > {2}  ORDER BY BENEFIT_MONTH, PAYMENT_START_DATE, PAYMENT_END_DATE",  //COBOL==>EXEC SQL DECLARE BENACSR CURSOR FOR SELECT CASE_NUMBER , PROGRAM_TYPE , PROGRAM_SUBTYPE , BENEFIT_MONTH , ISSUANCE_TYPE , BENEFIT_TYPE , BUDGETING_METHOD , ISSUED_DATE , PAYMENT_START_DATE , PAYMENT_END_DATE , CREATED_BY , CREATED_TIMESTAMP FROM KSD_BENEFITS_ARCHV WHERE CASE_NUMBER = :BENA-CASE-NUMBER AND PROGRAM_TYPE = :BENA-PROGRAM-TYPE AND BENEFIT_MONTH > :BENA-BENEFIT-MONTH ORDER BY BENEFIT_MONTH , PAYMENT_START_DATE , PAYMENT_END_DATE END-EXEC
                                WS.BENA_CASE_NUMBER, WS.BENA_PROGRAM_TYPE, WS.BENA_BENEFIT_MONTH);

        }

        #endregion

        #region Private Fields


        //==== Working Storage Data Class ========================================
        private SWEXOE04_ws WS;

        //==== Linkage Section Data Class ========================================
        private SWEXOE04_ls LS;
        #endregion

        #region Public Methods
        //========================================================================
        //==== RunMain Entry Point Method ========================================
        //========================================================================
        public override int ExecuteMain(params object[] args)                                              //COBOL==> PROCEDURE DIVISION USING IEF-RUNTIME-PARM1 , IEF-RUNTIME-PARM2 , GLOBDATA , IMP-0001EV , IMPORT-ON-FC-DATE-0002EV , IMP-ADABAS-EXTERNAL-ACT-0003EV , EXP-0004EV , EXP-0005EV , EXPORT-EXEC-RESULTS-0006EV.
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
            M_0000_MAINLINE(returnMethod);
        }
        /// <summary>
        /// Method M_0000_MAINLINE
        /// </summary>
        /// <remarks>
        ///COMMENT: *****************************************************************
        ///COMMENT:  MAINLINE SECTION
        ///COMMENT: *****************************************************************
        /// </remarks>
        private void M_0000_MAINLINE(string returnMethod = "")
        {
            M_1000_BEG_PGM(); if (Control.ExitProgram) { return; }                                                //COBOL==> PERFORM 1000-BEG-PGM.
            if (WS.WRK_LST_TM.Value)                                                                            //COBOL==> IF WRK-LST-TM
            {
                //COMMENT: WBR      PERFORM 7000-END-PGM
                //Continue                                                                                          //COBOL==> CONTINUE
            }                                                                                                   //COBOL==> ELSE
            else
            {
                M_2000_GET_BEN_DT(); if (Control.ExitProgram) { return; }                                             //COBOL==> PERFORM 2000-GET-BEN-DT
            }                                                                                                   //COBOL==> END-IF.
            DisplayToLog("CLT NBR " + LS.NUMBER_0001.AsString() + " DT1 " + LS.DATE_0002.AsString() + " FLG " + LS.FLAG_0003.AsString() + " CASE " + LS.AE_CASE_NO_0004.AsString() + " DT2 " + LS.FIRST_BENEFIT_DATE_0004XX.AsString() + " REL " + LS.RELATIONSHIP_0005.AsString());  //COBOL==> DISPLAY 'CLT NBR ' , NUMBER-0001 , ' DT1 ' , DATE-0002 , ' FLG ' , FLAG-0003 , ' CASE ' , AE-CASE-NO-0004 , ' DT2 ' , FIRST-BENEFIT-DATE-0004XX , ' REL ' , RELATIONSHIP-0005.
            Control.ExitProgram = true; return;                                                                 //COBOL==> GOBACK.
        }
        /// <summary>
        /// Method M_1000_BEG_PGM
        /// </summary>
        /// <remarks>
        ///COMMENT: *****************************************************************
        ///COMMENT:  BEGIN PROGRAM ROUTINE
        ///COMMENT: *****************************************************************
        /// </remarks>
        private void M_1000_BEG_PGM(string returnMethod = "")
        {
            WS.WRK_DB_CD.ResetToInitialValue();                                                                 //COBOL==> INITIALIZE WRK-DB-CD.
            WS.WRK_RET_CD.ResetToInitialValue();                                                                //COBOL==> INITIALIZE WRK-RET-CD.
            WS.WRK_BEN_YM.ResetToInitialValue();                                                                //COBOL==> INITIALIZE WRK-BEN-YM.
            WS.WRK_FST_YM.ResetToInitialValue();                                                                //COBOL==> INITIALIZE WRK-FST-YM.
            LS.EXP_0004EV.ResetToInitialValue();                                                                //COBOL==> INITIALIZE EXP-0004EV.
            LS.EXP_0005EV.ResetToInitialValue();                                                                //COBOL==> INITIALIZE EXP-0005EV.
            LS.EXPORT_EXEC_RESULTS_0006EV.ResetToInitialValue();                                                //COBOL==> INITIALIZE EXPORT-EXEC-RESULTS-0006EV.
            WS.WRK_TM_SW.SetValue(LS.FLAG_0003);                                                                //COBOL==> MOVE FLAG-0003 TO WRK-TM-SW.
            LS.FIRST_BENEFIT_DATE_0004XX.SetValue("00010101");                                                  //COBOL==> MOVE '00010101' TO FIRST-BENEFIT-DATE-0004XX.
            WS.WRK_BEN_FND_SW.SetValue("N");                                                                    //COBOL==> MOVE 'N' TO WRK-BEN-FND-SW.
            WS.WRK_PRT_FND_SW.SetValue("N");                                                                    //COBOL==> MOVE 'N' TO WRK-PRT-FND-SW.
                                                                                                                //COMMENT: WBR START
            WS.WRK_DATE_AREA.SetValue(LS.DATE_0002);                                                            //COBOL==> MOVE DATE-0002 TO WRK-DATE-AREA.
            WS.WRK_DATE_0002.SetValueOfSubstring(1, 4, WS.WRK_DATE_AREA.GetSubstring(1, 4).AsString());         //COBOL==> MOVE WRK-DATE-AREA ( 1:4 ) TO WRK-DATE-0002 ( 1:4 ) .
            WS.WRK_DATE_0002.SetValueOfSubstring(5, 1, "-");                                                    //COBOL==> MOVE '-' TO WRK-DATE-0002 ( 5:1 ) .
            WS.WRK_DATE_0002.SetValueOfSubstring(6, 2, WS.WRK_DATE_AREA.GetSubstring(5, 2).AsString());         //COBOL==> MOVE WRK-DATE-AREA ( 5:2 ) TO WRK-DATE-0002 ( 6:2 ) .
            WS.WRK_DATE_0002.SetValueOfSubstring(8, 1, "-");                                                    //COBOL==> MOVE '-' TO WRK-DATE-0002 ( 8:1 ) .
            WS.WRK_DATE_0002.SetValueOfSubstring(9, 2, WS.WRK_DATE_AREA.GetSubstring(7, 2).AsString());         //COBOL==> MOVE WRK-DATE-AREA ( 7:2 ) TO WRK-DATE-0002 ( 9:2 ) .
            if (returnMethod != "" && returnMethod != "M_1000_BEG_PGM") { M_2000_GET_BEN_DT(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_2000_GET_BEN_DT
        /// </summary>
        /// <remarks>
        ///COMMENT: WBR  IF  WRK-FST-TM
        ///COMMENT: WBR      PERFORM 1200-OPN-ADA-DB
        ///COMMENT: WBR  END-IF.
        ///COMMENT: WBR END
        ///COMMENT: *****************************************************************
        ///COMMENT:  THE FOLLOWING HAS BEEN COMMENTED OUT BECAUSE IT IS NOT NEEDED
        ///COMMENT: *****************************************************************
        ///COMMENT: 1200-OPN-ADA-DB.
        ///COMMENT:      @OPEN BENEFITS-ARCHIVED-DBF.
        ///COMMENT:      IF  RESPONSE-CODE193 NOT = 0
        ///COMMENT:          MOVE RESPONSE-CODE193 TO WRK-RET-CD
        ///COMMENT:      END-IF.
        ///COMMENT:      @OPEN BENEFITS-DBF.
        ///COMMENT:      IF  RESPONSE-CODE151 NOT = 0
        ///COMMENT:          MOVE RESPONSE-CODE151 TO WRK-RET-CD
        ///COMMENT:      END-IF.
        ///COMMENT:      @OPEN PARTICIPATION-DBF.
        ///COMMENT:      IF  RESPONSE-CODE161 NOT = 0
        ///COMMENT:          MOVE RESPONSE-CODE161 TO WRK-RET-CD
        ///COMMENT:      END-IF.
        ///COMMENT: 2000-GET-BEN-DT.
        ///COMMENT:      PERFORM 3000-GET-PRT-REC.
        ///COMMENT:      IF  WRK-PRT-FND
        ///COMMENT:          MOVE CASE-NUMBER161  TO AE-CASE-NO-0004
        ///COMMENT:          MOVE RELATIONSHIP161 TO RELATIONSHIP-0005
        ///COMMENT:          PERFORM 4000-GET-ARC-REC
        ///COMMENT:          IF  WRK-BEN-FND
        ///COMMENT:          OR  WRK-ADA-ERR
        ///COMMENT:              CONTINUE
        ///COMMENT:          ELSE
        ///COMMENT:              PERFORM 5000-GET-BEN-REC
        ///COMMENT:          END-IF
        ///COMMENT:      END-IF.
        ///COMMENT:      IF  WRK-BEN-FND
        ///COMMENT:          MOVE WRK-BEN-DT TO FIRST-BENEFIT-DATE-0004
        ///COMMENT:      ELSE
        ///COMMENT:          IF  WRK-FST-YM > 0
        ///COMMENT:              MOVE WRK-FST-YM TO WRK-BEN-YM
        ///COMMENT:              MOVE WRK-BEN-DT TO FIRST-BENEFIT-DATE-0004
        ///COMMENT:          ELSE
        ///COMMENT:              IF  WRK-ADA-ERR
        ///COMMENT:                  MOVE 'ABEND'                TO TEXT-5-0006
        ///COMMENT:                  MOVE WRK-RET-CD             TO WRK-ERR-CD
        ///COMMENT:                  MOVE 'FATAL ADABAS ERROR'   TO WRK-ERR-TXT
        ///COMMENT:                  MOVE WRK-ERR-MSG            TO TEXT-80-0006
        ///COMMENT:              ELSE
        ///COMMENT:                  MOVE 'OKAY'                 TO TEXT-5-0006
        ///COMMENT:                  IF  WRK-PRT-FND
        ///COMMENT:                      MOVE 'NO BENEFIT DATE'  TO TEXT-80-0006
        ///COMMENT:                  ELSE
        ///COMMENT:                      MOVE 'NO PARTICIPATION' TO TEXT-80-0006
        ///COMMENT:                  END-IF
        ///COMMENT:              END-IF
        ///COMMENT:          END-IF
        ///COMMENT:      END-IF.
        ///COMMENT: *****************************************************************
        ///COMMENT:  GET BENEFIT INFORMATION ROUTINE
        ///COMMENT: *****************************************************************
        /// </remarks>
        private void M_2000_GET_BEN_DT(string returnMethod = "")
        {
            M_3000_GET_PRT_REC(); if (Control.ExitProgram) { return; }                                            //COBOL==> PERFORM 3000-GET-PRT-REC.
            if (WS.WRK_PRT_FND.Value)                                                                           //COBOL==> IF WRK-PRT-FND
            {
                LS.AE_CASE_NO_0004.SetValue(WS.PART_FK_CSB_CASE_NO);                                                //COBOL==> MOVE PART-FK-CSB-CASE-NO TO AE-CASE-NO-0004
                LS.RELATIONSHIP_0005.SetValue(WS.PART_RELATIONSHIP);                                                //COBOL==> MOVE PART-RELATIONSHIP TO RELATIONSHIP-0005
                M_4000_GET_ARC_REC(); if (Control.ExitProgram) { return; }                                            //COBOL==> PERFORM 4000-GET-ARC-REC
                if ((WS.WRK_BEN_FND.Value)
             || (WS.WRK_ADA_ERR.Value))                               //COBOL==> IF WRK-BEN-FND OR WRK-ADA-ERR
                {
                    //Continue                                                                                          //COBOL==> CONTINUE
                }                                                                                                   //COBOL==> ELSE
                else
                {
                    M_5000_GET_BEN_REC(); if (Control.ExitProgram) { return; }                                            //COBOL==> PERFORM 5000-GET-BEN-REC
                }                                                                                                   //COBOL==> END-IF
            }                                                                                                   //COBOL==> END-IF.
            if (WS.WRK_BEN_FND.Value)                                                                           //COBOL==> IF WRK-BEN-FND
            {
                LS.FIRST_BENEFIT_DATE_0004.SetValue(WS.WRK_BEN_DT);                                                 //COBOL==> MOVE WRK-BEN-DT TO FIRST-BENEFIT-DATE-0004
            }                                                                                                   //COBOL==> ELSE
            else
            {
                if (WS.WRK_FST_YM.IsGreaterThan(0))                                                                 //COBOL==> IF WRK-FST-YM > 0
                {
                    WS.WRK_BEN_YM.SetValue(WS.WRK_FST_YM);                                                              //COBOL==> MOVE WRK-FST-YM TO WRK-BEN-YM
                    LS.FIRST_BENEFIT_DATE_0004.SetValue(WS.WRK_BEN_DT);                                                 //COBOL==> MOVE WRK-BEN-DT TO FIRST-BENEFIT-DATE-0004
                }                                                                                                   //COBOL==> ELSE
                else
                {
                    if (WS.WRK_ADA_ERR.Value)                                                                           //COBOL==> IF WRK-ADA-ERR
                    {
                        LS.TEXT_5_0006.SetValue("ABEND");                                                                   //COBOL==> MOVE 'ABEND' TO TEXT-5-0006
                        WS.WRK_ERR_CD.SetValue(WS.WRK_RET_CD);                                                              //COBOL==> MOVE WRK-RET-CD TO WRK-ERR-CD
                        WS.WRK_ERR_TXT.SetValue("FATAL ADABAS ERROR");                                                      //COBOL==> MOVE 'FATAL ADABAS ERROR' TO WRK-ERR-TXT
                        LS.TEXT_80_0006.SetValue(WS.WRK_ERR_MSG);                                                           //COBOL==> MOVE WRK-ERR-MSG TO TEXT-80-0006
                    }                                                                                                   //COBOL==> ELSE
                    else
                    {
                        LS.TEXT_5_0006.SetValue("OKAY");                                                                    //COBOL==> MOVE 'OKAY' TO TEXT-5-0006
                        if (WS.WRK_PRT_FND.Value)                                                                           //COBOL==> IF WRK-PRT-FND
                        {
                            LS.TEXT_80_0006.SetValue("NO BENEFIT DATE");                                                        //COBOL==> MOVE 'NO BENEFIT DATE' TO TEXT-80-0006
                        }                                                                                                   //COBOL==> ELSE
                        else
                        {
                            LS.TEXT_80_0006.SetValue("NO PARTICIPATION");                                                       //COBOL==> MOVE 'NO PARTICIPATION' TO TEXT-80-0006
                        }                                                                                                   //COBOL==> END-IF
                    }                                                                                                   //COBOL==> END-IF
                }                                                                                                   //COBOL==> END-IF
            }                                                                                                   //COBOL==> END-IF.
            if (returnMethod != "" && returnMethod != "M_2000_GET_BEN_DT") { M_3000_GET_PRT_REC(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_3000_GET_PRT_REC
        /// </summary>
        /// <remarks>
        ///COMMENT: 3000-GET-PRT-REC.
        ///COMMENT:      SET  WRK-PRT-DB  TO TRUE.
        ///COMMENT:      MOVE NUMBER-0001 TO V-CLIENT-NUMBER161.
        ///COMMENT:      MOVE 'FC'        TO V-PROGRAM-TYPE161.
        ///COMMENT:      MOVE ZERO        TO V-PART-START-DATE161.
        ///COMMENT:      MOVE SPACES      TO V-CASE-NUMBER161.
        ///COMMENT:      @READLOGICAL161 FIRST.
        ///COMMENT:      PERFORM 6000-CHK-RET-CD.
        ///COMMENT:      PERFORM 3200-CHK-PRT-REC
        ///COMMENT:      UNTIL   WRK-PRT-FND
        ///COMMENT:      OR      WRK-EOF-ERR
        ///COMMENT:      OR      WRK-ADA-ERR.
        ///COMMENT: *****************************************************************
        ///COMMENT:  GET PARTICIPATION INFORMATION ROUTINE
        ///COMMENT: *****************************************************************
        /// </remarks>
        private void M_3000_GET_PRT_REC(string returnMethod = "")
        {
            WS.WRK_PRT_DB.SetValue(true);                                                                       //COBOL==> SET WRK-PRT-DB TO TRUE.
                                                                                                                //COMMENT:  RKM - CHANGES FOR CLIENT PREFERRED ID
                                                                                                                //COMMENT:     MOVE NUMBER-0001 TO PART-FK-CLB-CLIENT-NO.
            WS.DCLKSD_CLIENT_BASIC.ResetToInitialValue();                                                       //COBOL==> INITIALIZE DCLKSD-CLIENT-BASIC.
            DbConv.ExecuteSqlQueryWithUR("SELECT CLIENT_NUMBER , CIS_PREFERRED_ID INTO {0} , {1} FROM KSD_CLIENT_BASIC WHERE CLIENT_NUMBER = {2} ",  //COBOL==> EXEC SQL SELECT CLIENT_NUMBER , CIS_PREFERRED_ID INTO :CLB-CLIENT-NUMBER , :CLB-CIS-PREFERRED-ID FROM KSD_CLIENT_BASIC WHERE CLIENT_NUMBER = :NUMBER-0001 WITH UR END-EXEC.
                                 WS.CLB_CLIENT_NUMBER, WS.CLB_CIS_PREFERRED_ID, LS.NUMBER_0001);
            // EvaluateList !DbConv.SQLCA.SQLCODE!                                                              //COBOL==> EVALUATE SQLCODE
            if ((DbConv.SQLCA.SQLCODE.IsZeroes()))                                                              //COBOL==> WHEN ZERO
            {
                if ((WS.CLB_CIS_PREFERRED_ID.IsNumericValue())
             && (!(WS.CLB_CIS_PREFERRED_ID.IsEqualTo(WS.CLB_CLIENT_NUMBER))))  //COBOL==> IF CLB-CIS-PREFERRED-ID IS NUMERIC AND CLB-CIS-PREFERRED-ID NOT = CLB-CLIENT-NUMBER
                {
                    WS.PART_FK_CLB_CLIENT_NO.SetValue(WS.CLB_CIS_PREFERRED_ID);                                         //COBOL==> MOVE CLB-CIS-PREFERRED-ID TO PART-FK-CLB-CLIENT-NO
                }                                                                                                   //COBOL==> ELSE
                else
                {
                    WS.PART_FK_CLB_CLIENT_NO.SetValue(LS.NUMBER_0001);                                                  //COBOL==> MOVE NUMBER-0001 TO PART-FK-CLB-CLIENT-NO
                }                                                                                                   //COBOL==> END-IF
            }                                                                                                //COBOL==> WHEN OTHER
            else
            {
                WS.PART_FK_CLB_CLIENT_NO.SetValue(LS.NUMBER_0001);                                                  //COBOL==> MOVE NUMBER-0001 TO PART-FK-CLB-CLIENT-NO
            }                                                                                                   //COBOL==> END-EVALUATE.
            WS.PART_FK_PGB_PROG_TYPE.SetValue("FC");                                                            //COBOL==> MOVE 'FC' TO PART-FK-PGB-PROG-TYPE.
            WS.PART_PART_START_DATE.SetValue("0001-01-01");                                                     //COBOL==> MOVE '0001-01-01' TO PART-PART-START-DATE.
            WS.PART_FK_CSB_CASE_NO.SetValueWithSpaces();                                                        //COBOL==> MOVE SPACES TO PART-FK-CSB-CASE-NO.
            M_8010_OPEN_PART_CSR(); if (Control.ExitProgram) { return; }                                          //COBOL==> PERFORM 8010-OPEN-PART-CSR.
            M_6000_CHK_RET_CD(); if (Control.ExitProgram) { return; }                                             //COBOL==> PERFORM 6000-CHK-RET-CD.
            if (WS.WRK_NO_ERR.Value)                                                                            //COBOL==> IF WRK-NO-ERR
            {
                M_8020_FETCH_PART_CSR(); if (Control.ExitProgram) { return; }                                         //COBOL==> PERFORM 8020-FETCH-PART-CSR
                M_6000_CHK_RET_CD(); if (Control.ExitProgram) { return; }                                             //COBOL==> PERFORM 6000-CHK-RET-CD
            }                                                                                                   //COBOL==> END-IF.
            while (!(((WS.WRK_PRT_FND.Value) || (WS.WRK_EOF_ERR.Value)) || (WS.WRK_ADA_ERR.Value)))             //COBOL==> PERFORM 3200-CHK-PRT-REC UNTIL WRK-PRT-FND OR WRK-EOF-ERR OR WRK-ADA-ERR.
            {
                M_3200_CHK_PRT_REC(); if (Control.ExitProgram) { return; }
            }
            M_8030_CLOSE_PART_CSR(); if (Control.ExitProgram) { return; }                                         //COBOL==> PERFORM 8030-CLOSE-PART-CSR.
            if (returnMethod != "" && returnMethod != "M_3000_GET_PRT_REC") { M_3200_CHK_PRT_REC(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_3200_CHK_PRT_REC
        /// </summary>
        /// <remarks>
        ///COMMENT: 3200-CHK-PRT-REC.
        ///COMMENT:      IF  DATE-0002 >= PART-START-DATE161
        ///COMMENT:          IF  DATE-0002 <= PART-END-DATE161
        ///COMMENT:              SET WRK-PRT-FND TO TRUE
        ///COMMENT:          ELSE
        ///COMMENT:              PERFORM 3400-GET-NXT-PRT
        ///COMMENT:          END-IF
        ///COMMENT:      ELSE
        ///COMMENT:          SET WRK-EOF-ERR TO TRUE
        ///COMMENT:      END-IF.
        ///COMMENT: *****************************************************************
        ///COMMENT:  CHECK PARTICIPATION INFORMATION ROUTINE
        ///COMMENT: *****************************************************************
        /// </remarks>
        private void M_3200_CHK_PRT_REC(string returnMethod = "")
        {
            if (WS.WRK_DATE_0002.IsGreaterThanOrEqualTo(WS.PART_PART_START_DATE))                               //COBOL==> IF WRK-DATE-0002 >= PART-PART-START-DATE
            {
                if (WS.WRK_DATE_0002.IsLessThanOrEqualTo(WS.PART_PART_END_DATE))                                    //COBOL==> IF WRK-DATE-0002 <= PART-PART-END-DATE
                {
                    WS.WRK_PRT_FND.SetValue(true);                                                                      //COBOL==> SET WRK-PRT-FND TO TRUE
                }                                                                                                   //COBOL==> ELSE
                else
                {
                    M_3400_GET_NXT_PRT(); if (Control.ExitProgram) { return; }                                            //COBOL==> PERFORM 3400-GET-NXT-PRT
                }                                                                                                   //COBOL==> END-IF
            }                                                                                                   //COBOL==> ELSE
            else
            {
                WS.WRK_EOF_ERR.SetValue(true);                                                                      //COBOL==> SET WRK-EOF-ERR TO TRUE
            }                                                                                                   //COBOL==> END-IF.
            if (returnMethod != "" && returnMethod != "M_3200_CHK_PRT_REC") { M_3400_GET_NXT_PRT(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_3400_GET_NXT_PRT
        /// </summary>
        /// <remarks>
        ///COMMENT: 3400-GET-NXT-PRT.
        ///COMMENT:      @READLOGICAL161.
        ///COMMENT:      PERFORM 6000-CHK-RET-CD.
        ///COMMENT: *****************************************************************
        ///COMMENT:  GET NEXT PARTICIPATION ROW ROUTINE
        ///COMMENT: *****************************************************************
        /// </remarks>
        private void M_3400_GET_NXT_PRT(string returnMethod = "")
        {
            M_8020_FETCH_PART_CSR(); if (Control.ExitProgram) { return; }                                         //COBOL==> PERFORM 8020-FETCH-PART-CSR.
            M_6000_CHK_RET_CD(); if (Control.ExitProgram) { return; }                                             //COBOL==> PERFORM 6000-CHK-RET-CD.
            if (returnMethod != "" && returnMethod != "M_3400_GET_NXT_PRT") { M_4000_GET_ARC_REC(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_4000_GET_ARC_REC
        /// </summary>
        /// <remarks>
        ///COMMENT: 4000-GET-ARC-REC.
        ///COMMENT:      SET  WRK-ARC-DB     TO TRUE.
        ///COMMENT:      MOVE CASE-NUMBER161 TO V-CASE-NUMBER193.
        ///COMMENT:      MOVE 'FC'           TO V-PROGRAM-TYPE193.
        ///COMMENT:      MOVE ZERO           TO V-BENEFIT-MONTH193.
        ///COMMENT:      @READLOGICAL193 FIRST.
        ///COMMENT:      PERFORM 6000-CHK-RET-CD.
        ///COMMENT:      PERFORM 4200-CHK-ARC-REC
        ///COMMENT:      UNTIL   WRK-BEN-FND
        ///COMMENT:      OR      WRK-EOF-ERR
        ///COMMENT:      OR      WRK-ADA-ERR.
        ///COMMENT: *****************************************************************
        ///COMMENT:  GET BENEFIT ARCHIVE INFORMATION ROUTINE
        ///COMMENT: *****************************************************************
        /// </remarks>
        private void M_4000_GET_ARC_REC(string returnMethod = "")
        {
            WS.WRK_ARC_DB.SetValue(true);                                                                       //COBOL==> SET WRK-ARC-DB TO TRUE.
            WS.BENA_CASE_NUMBER.SetValue(WS.PART_FK_CSB_CASE_NO);                                               //COBOL==> MOVE PART-FK-CSB-CASE-NO TO BENA-CASE-NUMBER.
            WS.BENA_PROGRAM_TYPE.SetValue("FC");                                                                //COBOL==> MOVE 'FC' TO BENA-PROGRAM-TYPE.
            WS.BENA_BENEFIT_MONTH.SetValue(ZEROES);                                                             //COBOL==> MOVE ZEROES TO BENA-BENEFIT-MONTH.
            M_8210_OPEN_BENA_CSR(); if (Control.ExitProgram) { return; }                                          //COBOL==> PERFORM 8210-OPEN-BENA-CSR.
            M_6000_CHK_RET_CD(); if (Control.ExitProgram) { return; }                                             //COBOL==> PERFORM 6000-CHK-RET-CD.
            if (WS.WRK_NO_ERR.Value)                                                                            //COBOL==> IF WRK-NO-ERR
            {
                M_8220_FETCH_BENA_CSR(); if (Control.ExitProgram) { return; }                                         //COBOL==> PERFORM 8220-FETCH-BENA-CSR
                M_6000_CHK_RET_CD(); if (Control.ExitProgram) { return; }                                             //COBOL==> PERFORM 6000-CHK-RET-CD
            }                                                                                                   //COBOL==> END-IF.
            while (!(((WS.WRK_BEN_FND.Value) || (WS.WRK_EOF_ERR.Value)) || (WS.WRK_ADA_ERR.Value)))             //COBOL==> PERFORM 4200-CHK-ARC-REC UNTIL WRK-BEN-FND OR WRK-EOF-ERR OR WRK-ADA-ERR.
            {
                M_4200_CHK_ARC_REC(); if (Control.ExitProgram) { return; }
            }
            M_8230_CLOSE_BENA_CSR(); if (Control.ExitProgram) { return; }                                         //COBOL==> PERFORM 8230-CLOSE-BENA-CSR.
            if (returnMethod != "" && returnMethod != "M_4000_GET_ARC_REC") { M_4200_CHK_ARC_REC(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_4200_CHK_ARC_REC
        /// </summary>
        /// <remarks>
        ///COMMENT: 4200-CHK-ARC-REC.
        ///COMMENT:      IF  ISSUED-DATE193 > 0
        ///COMMENT:          MOVE BENEFIT-MONTH193 TO WRK-BEN-YM
        ///COMMENT:          SET  WRK-BEN-FND TO TRUE
        ///COMMENT:      ELSE
        ///COMMENT:          IF  WRK-FST-YM = 0
        ///COMMENT:              MOVE BENEFIT-MONTH193 TO WRK-FST-YM
        ///COMMENT:          END-IF
        ///COMMENT:          PERFORM 4400-GET-NXT-ARC
        ///COMMENT:      END-IF.
        ///COMMENT: *****************************************************************
        ///COMMENT:  CHECK BENEFIT ARCHIVE INFORMATION ROUTINE
        ///COMMENT: *****************************************************************
        /// </remarks>
        private void M_4200_CHK_ARC_REC(string returnMethod = "")
        {
            if (WS.BENA_ISSUED_DATE.IsGreaterThan("0001-01-01"))                                                //COBOL==> IF BENA-ISSUED-DATE > '0001-01-01'
            {
                WS.WRK_BEN_YM.SetValue(WS.BENA_BENEFIT_MONTH);                                                      //COBOL==> MOVE BENA-BENEFIT-MONTH TO WRK-BEN-YM
                WS.WRK_BEN_FND.SetValue(true);                                                                      //COBOL==> SET WRK-BEN-FND TO TRUE
            }                                                                                                   //COBOL==> ELSE
            else
            {
                if (WS.WRK_FST_YM.IsEqualTo(0))                                                                     //COBOL==> IF WRK-FST-YM = 0
                {
                    WS.WRK_FST_YM.SetValue(WS.BENA_BENEFIT_MONTH);                                                      //COBOL==> MOVE BENA-BENEFIT-MONTH TO WRK-FST-YM
                }                                                                                                   //COBOL==> END-IF
                M_4400_GET_NXT_ARC(); if (Control.ExitProgram) { return; }                                            //COBOL==> PERFORM 4400-GET-NXT-ARC
            }                                                                                                   //COBOL==> END-IF.
            if (returnMethod != "" && returnMethod != "M_4200_CHK_ARC_REC") { M_4400_GET_NXT_ARC(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_4400_GET_NXT_ARC
        /// </summary>
        /// <remarks>
        ///COMMENT: 4400-GET-NXT-ARC.
        ///COMMENT:      @READLOGICAL193.
        ///COMMENT:      PERFORM 6000-CHK-RET-CD.
        ///COMMENT: *****************************************************************
        ///COMMENT:  GET NEXT BENEFIT ARCHIVE ROW ROUTINE
        ///COMMENT: *****************************************************************
        /// </remarks>
        private void M_4400_GET_NXT_ARC(string returnMethod = "")
        {
            M_8220_FETCH_BENA_CSR(); if (Control.ExitProgram) { return; }                                         //COBOL==> PERFORM 8220-FETCH-BENA-CSR.
            M_6000_CHK_RET_CD(); if (Control.ExitProgram) { return; }                                             //COBOL==> PERFORM 6000-CHK-RET-CD.
            if (returnMethod != "" && returnMethod != "M_4400_GET_NXT_ARC") { M_5000_GET_BEN_REC(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_5000_GET_BEN_REC
        /// </summary>
        /// <remarks>
        ///COMMENT: 5000-GET-BEN-REC.
        ///COMMENT:      SET  WRK-BEN-DB     TO TRUE.
        ///COMMENT:      MOVE CASE-NUMBER161 TO V-CASE-NUMBER151.
        ///COMMENT:      MOVE 'FC'           TO V-PROGRAM-TYPE151.
        ///COMMENT:      MOVE ZERO           TO V-BENEFIT-MONTH151.
        ///COMMENT:      @READLOGICAL151 FIRST.
        ///COMMENT:      PERFORM 6000-CHK-RET-CD.
        ///COMMENT:      PERFORM 5200-CHK-BEN-REC
        ///COMMENT:      UNTIL   WRK-BEN-FND
        ///COMMENT:      OR      WRK-EOF-ERR
        ///COMMENT:      OR      WRK-ADA-ERR.
        ///COMMENT: *****************************************************************
        ///COMMENT:  GET BENEFIT INFORMATION ROUTINE
        ///COMMENT: *****************************************************************
        /// </remarks>
        private void M_5000_GET_BEN_REC(string returnMethod = "")
        {
            WS.WRK_BEN_DB.SetValue(true);                                                                       //COBOL==> SET WRK-BEN-DB TO TRUE.
            WS.BEN_FK_CSB_CASE_NO.SetValue(WS.PART_FK_CSB_CASE_NO);                                             //COBOL==> MOVE PART-FK-CSB-CASE-NO TO BEN-FK-CSB-CASE-NO.
            WS.BEN_FK_PGB_PROG_TYPE.SetValue("FC");                                                             //COBOL==> MOVE 'FC' TO BEN-FK-PGB-PROG-TYPE.
            WS.BEN_FK_PMO_PROG_BEN_MO.SetValue(ZEROES);                                                         //COBOL==> MOVE ZEROES TO BEN-FK-PMO-PROG-BEN-MO.
            M_8110_OPEN_BEN_CSR(); if (Control.ExitProgram) { return; }                                           //COBOL==> PERFORM 8110-OPEN-BEN-CSR.
            M_6000_CHK_RET_CD(); if (Control.ExitProgram) { return; }                                             //COBOL==> PERFORM 6000-CHK-RET-CD.
            if (WS.WRK_NO_ERR.Value)                                                                            //COBOL==> IF WRK-NO-ERR
            {
                M_8120_FETCH_BEN_CSR(); if (Control.ExitProgram) { return; }                                          //COBOL==> PERFORM 8120-FETCH-BEN-CSR
                M_6000_CHK_RET_CD(); if (Control.ExitProgram) { return; }                                             //COBOL==> PERFORM 6000-CHK-RET-CD
            }                                                                                                   //COBOL==> END-IF.
            while (!(((WS.WRK_BEN_FND.Value) || (WS.WRK_EOF_ERR.Value)) || (WS.WRK_ADA_ERR.Value)))             //COBOL==> PERFORM 5200-CHK-BEN-REC UNTIL WRK-BEN-FND OR WRK-EOF-ERR OR WRK-ADA-ERR.
            {
                M_5200_CHK_BEN_REC(); if (Control.ExitProgram) { return; }
            }
            M_8130_CLOSE_BEN_CSR(); if (Control.ExitProgram) { return; }                                          //COBOL==> PERFORM 8130-CLOSE-BEN-CSR.
            if (returnMethod != "" && returnMethod != "M_5000_GET_BEN_REC") { M_5200_CHK_BEN_REC(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_5200_CHK_BEN_REC
        /// </summary>
        /// <remarks>
        ///COMMENT: 5200-CHK-BEN-REC.
        ///COMMENT:      IF  ISSUED-DATE151 > 0
        ///COMMENT:          MOVE BENEFIT-MONTH151 TO WRK-BEN-YM
        ///COMMENT:          SET  WRK-BEN-FND TO TRUE
        ///COMMENT:      ELSE
        ///COMMENT:          IF  WRK-FST-YM = 0
        ///COMMENT:              MOVE BENEFIT-MONTH151 TO WRK-FST-YM
        ///COMMENT:          END-IF
        ///COMMENT:          PERFORM 5400-GET-NXT-BEN
        ///COMMENT:      END-IF.
        ///COMMENT: *****************************************************************
        ///COMMENT:  CHECK BENEFIT INFORMATION ROUTINE
        ///COMMENT: *****************************************************************
        /// </remarks>
        private void M_5200_CHK_BEN_REC(string returnMethod = "")
        {
            if (WS.BEN_ISSUED_DATE.IsGreaterThan("0001-01-01"))                                                 //COBOL==> IF BEN-ISSUED-DATE > '0001-01-01'
            {
                WS.WRK_BEN_YM.SetValue(WS.BEN_FK_PMO_PROG_BEN_MO);                                                  //COBOL==> MOVE BEN-FK-PMO-PROG-BEN-MO TO WRK-BEN-YM
                WS.WRK_BEN_FND.SetValue(true);                                                                      //COBOL==> SET WRK-BEN-FND TO TRUE
            }                                                                                                   //COBOL==> ELSE
            else
            {
                if (WS.WRK_FST_YM.IsEqualTo(0))                                                                     //COBOL==> IF WRK-FST-YM = 0
                {
                    WS.WRK_FST_YM.SetValue(WS.BEN_FK_PMO_PROG_BEN_MO);                                                  //COBOL==> MOVE BEN-FK-PMO-PROG-BEN-MO TO WRK-FST-YM
                }                                                                                                   //COBOL==> END-IF
                M_5400_GET_NXT_BEN(); if (Control.ExitProgram) { return; }                                            //COBOL==> PERFORM 5400-GET-NXT-BEN
            }                                                                                                   //COBOL==> END-IF.
            if (returnMethod != "" && returnMethod != "M_5200_CHK_BEN_REC") { M_5400_GET_NXT_BEN(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_5400_GET_NXT_BEN
        /// </summary>
        /// <remarks>
        ///COMMENT: 5400-GET-NXT-BEN.
        ///COMMENT:      @READLOGICAL151.
        ///COMMENT:      PERFORM 6000-CHK-RET-CD.
        ///COMMENT: *****************************************************************
        ///COMMENT:  GET NEXT BENEFIT ARCHIVE ROW ROUTINE
        ///COMMENT: *****************************************************************
        /// </remarks>
        private void M_5400_GET_NXT_BEN(string returnMethod = "")
        {
            M_8120_FETCH_BEN_CSR(); if (Control.ExitProgram) { return; }                                          //COBOL==> PERFORM 8120-FETCH-BEN-CSR.
            M_6000_CHK_RET_CD(); if (Control.ExitProgram) { return; }                                             //COBOL==> PERFORM 6000-CHK-RET-CD.
            if (returnMethod != "" && returnMethod != "M_5400_GET_NXT_BEN") { M_6000_CHK_RET_CD(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_6000_CHK_RET_CD
        /// </summary>
        /// <remarks>
        ///COMMENT: 6000-CHK-RET-CD.
        ///COMMENT:      EVALUATE TRUE
        ///COMMENT:        WHEN WRK-ARC-DB
        ///COMMENT:             MOVE RESPONSE-CODE193 TO WRK-RET-CD
        ///COMMENT:        WHEN WRK-BEN-DB
        ///COMMENT:             MOVE RESPONSE-CODE151 TO WRK-RET-CD
        ///COMMENT:        WHEN WRK-PRT-DB
        ///COMMENT:             MOVE RESPONSE-CODE161 TO WRK-RET-CD
        ///COMMENT:      END-EVALUATE.
        ///COMMENT:      IF  WRK-NO-ERR
        ///COMMENT:      OR  WRK-EOF-ERR
        ///COMMENT:          CONTINUE
        ///COMMENT:      ELSE
        ///COMMENT:          SET WRK-ADA-ERR TO TRUE
        ///COMMENT:      END-IF.
        ///COMMENT:      IF  WRK-NO-ERR
        ///COMMENT:          EVALUATE TRUE
        ///COMMENT:            WHEN WRK-ARC-DB
        ///COMMENT:                 IF  CASE-NUMBER193  NOT = CASE-NUMBER161
        ///COMMENT:                 OR  PROGRAM-TYPE193 NOT = 'FC'
        ///COMMENT:                     SET WRK-EOF-ERR TO TRUE
        ///COMMENT:                 END-IF
        ///COMMENT:            WHEN WRK-BEN-DB
        ///COMMENT:                 IF  CASE-NUMBER151  NOT = CASE-NUMBER161
        ///COMMENT:                 OR  PROGRAM-TYPE151 NOT = 'FC'
        ///COMMENT:                     SET WRK-EOF-ERR TO TRUE
        ///COMMENT:                 END-IF
        ///COMMENT:            WHEN WRK-PRT-DB
        ///COMMENT:                 IF  CLIENT-NUMBER161 NOT = NUMBER-0001
        ///COMMENT:                 OR  PROGRAM-TYPE161  NOT = 'FC'
        ///COMMENT:                     SET WRK-EOF-ERR TO TRUE
        ///COMMENT:                 END-IF
        ///COMMENT:          END-EVALUATE
        ///COMMENT:      END-IF.
        ///COMMENT: *****************************************************************
        ///COMMENT:  CHECK THE SQLCODE ROUTINE
        ///COMMENT: *****************************************************************
        /// </remarks>
        private void M_6000_CHK_RET_CD(string returnMethod = "")
        {
            if ((WS.WRK_NO_ERR.Value)
             || (WS.WRK_EOF_ERR.Value))                                //COBOL==> IF WRK-NO-ERR OR WRK-EOF-ERR
            {
                //Continue                                                                                          //COBOL==> CONTINUE
            }                                                                                                   //COBOL==> ELSE
            else
            {
                WS.WRK_ADA_ERR.SetValue(true);                                                                      //COBOL==> SET WRK-ADA-ERR TO TRUE
            }                                                                                                   //COBOL==> END-IF.
            if (WS.WRK_NO_ERR.Value)                                                                            //COBOL==> IF WRK-NO-ERR
            {
                // EvaluateList !TRUE!                                                                              //COBOL==> EVALUATE TRUE
                if (WS.WRK_ARC_DB.Value)                                                                        //COBOL==> WHEN WRK-ARC-DB
                {
                    if ((!(WS.BENA_CASE_NUMBER.IsEqualTo(WS.PART_FK_CSB_CASE_NO)))
             || (!(WS.BENA_PROGRAM_TYPE.IsEqualTo("FC"))))  //COBOL==> IF BENA-CASE-NUMBER NOT = PART-FK-CSB-CASE-NO OR BENA-PROGRAM-TYPE NOT = 'FC'
                    {
                        WS.WRK_EOF_ERR.SetValue(true);                                                                      //COBOL==> SET WRK-EOF-ERR TO TRUE
                    }                                                                                                   //COBOL==> END-IF
                }                                                                                               //COBOL==> WHEN WRK-BEN-DB
                else
                if (WS.WRK_BEN_DB.Value)
                {
                    if ((!(WS.BEN_FK_CSB_CASE_NO.IsEqualTo(WS.PART_FK_CSB_CASE_NO)))
             || (!(WS.BEN_FK_PGB_PROG_TYPE.IsEqualTo("FC"))))  //COBOL==> IF BEN-FK-CSB-CASE-NO NOT = PART-FK-CSB-CASE-NO OR BEN-FK-PGB-PROG-TYPE NOT = 'FC'
                    {
                        WS.WRK_EOF_ERR.SetValue(true);                                                                      //COBOL==> SET WRK-EOF-ERR TO TRUE
                    }                                                                                                   //COBOL==> END-IF
                }                                                                                               //COBOL==> WHEN WRK-PRT-DB
                else
                if (WS.WRK_PRT_DB.Value)
                {
                    //COMMENT:  RKM - MODIFIED CLIENT EDIT FOR PARTICIPATION EOF
                    if (((!(WS.PART_FK_CLB_CLIENT_NO.IsEqualTo(LS.NUMBER_0001)))
             && (!(WS.PART_FK_CLB_CLIENT_NO.IsEqualTo(WS.CLB_CIS_PREFERRED_ID))))
             || (!(WS.PART_FK_PGB_PROG_TYPE.IsEqualTo("FC"))))  //COBOL==> IF ( PART-FK-CLB-CLIENT-NO NOT = NUMBER-0001 AND PART-FK-CLB-CLIENT-NO NOT = CLB-CIS-PREFERRED-ID ) OR PART-FK-PGB-PROG-TYPE NOT = 'FC'
                    {
                        WS.WRK_EOF_ERR.SetValue(true);                                                                      //COBOL==> SET WRK-EOF-ERR TO TRUE
                    }                                                                                                   //COBOL==> END-IF
                }                                                                                                   //COBOL==> END-EVALUATE
            }                                                                                                   //COBOL==> END-IF.
            if (returnMethod != "" && returnMethod != "M_6000_CHK_RET_CD") { M_8010_OPEN_PART_CSR(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_8010_OPEN_PART_CSR
        /// </summary>
        /// <remarks>
        ///COMMENT: *****************************************************************
        ///COMMENT:  THE FOLLOWING PARAGRAPH IS NO LONGER NEEDED
        ///COMMENT: *****************************************************************
        ///COMMENT: 7000-END-PGM.
        ///COMMENT:      @CLOSE.
        ///COMMENT: *****************************************************************
        ///COMMENT: *****************************************************************
        ///COMMENT:  OPEN CURSOR FOR KSD PARTICIPATION DB2 TABLE ROUTINE
        ///COMMENT: *****************************************************************
        /// </remarks>
        private void M_8010_OPEN_PART_CSR(string returnMethod = "")
        {
            DbConv.OpenReader("PARTCSR");                                                                       //COBOL==> EXEC SQL OPEN PARTCSR END-EXEC.
            WS.WRK_RET_CD.SetValue(DbConv.SQLCA.SQLCODE);                                                       //COBOL==> MOVE SQLCODE TO WRK-RET-CD.
            if (returnMethod != "" && returnMethod != "M_8010_OPEN_PART_CSR") { M_8020_FETCH_PART_CSR(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_8020_FETCH_PART_CSR
        /// </summary>
        /// <remarks>
        ///COMMENT: *****************************************************************
        ///COMMENT:  FETCH CURSOR FOR KSD PARTICIPATION DB2 TABLE ROUTINE
        ///COMMENT: *****************************************************************
        /// </remarks>
        private void M_8020_FETCH_PART_CSR(string returnMethod = "")
        {
            DbConv.FetchReaderRow("PARTCSR",                                                                 //COBOL==> EXEC SQL FETCH PARTCSR INTO :PART-KESSEP-TIME-STMP , :PART-PART-END-DATE , :PART-PART-START-DATE , :PART-PART-CODE , :PART-PROGRAM-END-DATE , :PART-PROGRAM-SUBTYPE , :PART-RELATIONSHIP , :PART-CREATED-BY , :PART-CREATED-TIMESTAMP , :PART-LAST-MODIFIED-BY , :PART-LAST-MODIFIED-TMST , :PART-FK-CSB-CASE-NO , :PART-FK-PGB-PROG-TYPE , :PART-FK-CLB-CLIENT-NO END-EXEC.
                             WS.PART_KESSEP_TIME_STMP, WS.PART_PART_END_DATE, WS.PART_PART_START_DATE, WS.PART_PART_CODE, WS.PART_PROGRAM_END_DATE, WS.PART_PROGRAM_SUBTYPE, WS.PART_RELATIONSHIP, WS.PART_CREATED_BY, WS.PART_CREATED_TIMESTAMP, WS.PART_LAST_MODIFIED_BY, WS.PART_LAST_MODIFIED_TMST, WS.PART_FK_CSB_CASE_NO, WS.PART_FK_PGB_PROG_TYPE, WS.PART_FK_CLB_CLIENT_NO);
            WS.WRK_RET_CD.SetValue(DbConv.SQLCA.SQLCODE);                                                       //COBOL==> MOVE SQLCODE TO WRK-RET-CD.
            if (returnMethod != "" && returnMethod != "M_8020_FETCH_PART_CSR") { M_8030_CLOSE_PART_CSR(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_8030_CLOSE_PART_CSR
        /// </summary>
        /// <remarks>
        ///COMMENT: *****************************************************************
        ///COMMENT:  CLOSE CURSOR FOR KSD PARTICIPATION DB2 TABLE ROUTINE
        ///COMMENT: *****************************************************************
        /// </remarks>
        private void M_8030_CLOSE_PART_CSR(string returnMethod = "")
        {
            DbConv.CloseReader("PARTCSR");                                                                      //COBOL==> EXEC SQL CLOSE PARTCSR END-EXEC.
            WS.WRK_RET_CD.SetValue(DbConv.SQLCA.SQLCODE);                                                       //COBOL==> MOVE SQLCODE TO WRK-RET-CD.
            if (returnMethod != "" && returnMethod != "M_8030_CLOSE_PART_CSR") { M_8110_OPEN_BEN_CSR(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_8110_OPEN_BEN_CSR
        /// </summary>
        /// <remarks>
        ///COMMENT: *****************************************************************
        ///COMMENT:  OPEN CURSOR FOR KSD BENEFITS DB2 TABLE ROUTINE
        ///COMMENT: *****************************************************************
        /// </remarks>
        private void M_8110_OPEN_BEN_CSR(string returnMethod = "")
        {
            DbConv.OpenReader("BENCSR");                                                                        //COBOL==> EXEC SQL OPEN BENCSR END-EXEC.
            WS.WRK_RET_CD.SetValue(DbConv.SQLCA.SQLCODE);                                                       //COBOL==> MOVE SQLCODE TO WRK-RET-CD.
            if (returnMethod != "" && returnMethod != "M_8110_OPEN_BEN_CSR") { M_8120_FETCH_BEN_CSR(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_8120_FETCH_BEN_CSR
        /// </summary>
        /// <remarks>
        ///COMMENT: *****************************************************************
        ///COMMENT:  FETCH CURSOR FOR KSD BENEFITS DB2 TABLE ROUTINE
        ///COMMENT: *****************************************************************
        /// </remarks>
        private void M_8120_FETCH_BEN_CSR(string returnMethod = "")
        {
            DbConv.FetchReaderRow("BENCSR",                                                                  //COBOL==> EXEC SQL FETCH BENCSR INTO :BEN-BUDGETING-METHOD , :BEN-BENEFIT-TYPE , :BEN-PAYEE-STREET1 , :BEN-PAYEE-STREET2 , :BEN-PAYEE-CITY , :BEN-PAYEE-STATE , :BEN-PAYEE-ZIP-CODE , :BEN-PAYEE-ZIP-PLUS-4 , :BEN-PAYMENT-START-DATE , :BEN-PAYMENT-END-DATE , :BEN-COUNTABLE-INCOME , :BEN-DEPENDENT-CARE , :BEN-RECOUPED-AMT , :BEN-NUM-OF-CHILDREN , :BEN-NUMBER-IN-HH , :BEN-ISSUED-DATE , :BEN-ISSUED-AMT , :BEN-ISSUANCE-TYPE , :BEN-HOUSEHOLD-SIZE , :BEN-HOUSEHOLD-TYPE , :BEN-CSE-PROC-FLAG , :BEN-BENEFIT-AMT , :BEN-THIRTY-ONE-THIRD , :BEN-THIRTY-DISREGARD , :BEN-CREATED-TIMESTAMP , :BEN-CREATED-BY , :BEN-LAST-MODIFIED-BY , :BEN-LAST-MODIFIED-TMST , :BEN-FK-CSB-CASE-NO , :BEN-FK-PGB-PROG-TYPE , :BEN-FK-PMO-PROG-SUBT , :BEN-FK-PMO-PROG-BEN-MO END-EXEC.
                             WS.BEN_BUDGETING_METHOD, WS.BEN_BENEFIT_TYPE, WS.BEN_PAYEE_STREET1, WS.BEN_PAYEE_STREET2, WS.BEN_PAYEE_CITY, WS.BEN_PAYEE_STATE, WS.BEN_PAYEE_ZIP_CODE, WS.BEN_PAYEE_ZIP_PLUS_4, WS.BEN_PAYMENT_START_DATE, WS.BEN_PAYMENT_END_DATE, WS.BEN_COUNTABLE_INCOME, WS.BEN_DEPENDENT_CARE, WS.BEN_RECOUPED_AMT, WS.BEN_NUM_OF_CHILDREN, WS.BEN_NUMBER_IN_HH, WS.BEN_ISSUED_DATE, WS.BEN_ISSUED_AMT, WS.BEN_ISSUANCE_TYPE, WS.BEN_HOUSEHOLD_SIZE, WS.BEN_HOUSEHOLD_TYPE, WS.BEN_CSE_PROC_FLAG, WS.BEN_BENEFIT_AMT, WS.BEN_THIRTY_ONE_THIRD, WS.BEN_THIRTY_DISREGARD, WS.BEN_CREATED_TIMESTAMP, WS.BEN_CREATED_BY, WS.BEN_LAST_MODIFIED_BY, WS.BEN_LAST_MODIFIED_TMST, WS.BEN_FK_CSB_CASE_NO, WS.BEN_FK_PGB_PROG_TYPE, WS.BEN_FK_PMO_PROG_SUBT, WS.BEN_FK_PMO_PROG_BEN_MO);
            WS.WRK_RET_CD.SetValue(DbConv.SQLCA.SQLCODE);                                                       //COBOL==> MOVE SQLCODE TO WRK-RET-CD.
            if (returnMethod != "" && returnMethod != "M_8120_FETCH_BEN_CSR") { M_8130_CLOSE_BEN_CSR(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_8130_CLOSE_BEN_CSR
        /// </summary>
        /// <remarks>
        ///COMMENT: *****************************************************************
        ///COMMENT:  CLOSE CURSOR FOR KSD BENEFITS DB2 TABLE ROUTINE
        ///COMMENT: *****************************************************************
        /// </remarks>
        private void M_8130_CLOSE_BEN_CSR(string returnMethod = "")
        {
            DbConv.CloseReader("BENCSR");                                                                       //COBOL==> EXEC SQL CLOSE BENCSR END-EXEC.
            WS.WRK_RET_CD.SetValue(DbConv.SQLCA.SQLCODE);                                                       //COBOL==> MOVE SQLCODE TO WRK-RET-CD.
            if (returnMethod != "" && returnMethod != "M_8130_CLOSE_BEN_CSR") { M_8210_OPEN_BENA_CSR(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_8210_OPEN_BENA_CSR
        /// </summary>
        /// <remarks>
        ///COMMENT: *****************************************************************
        ///COMMENT:  OPEN CURSOR FOR KSD BENEFITS ARCHIVE DB2 TABLE ROUTINE
        ///COMMENT: *****************************************************************
        /// </remarks>
        private void M_8210_OPEN_BENA_CSR(string returnMethod = "")
        {
            DbConv.OpenReader("BENACSR");                                                                       //COBOL==> EXEC SQL OPEN BENACSR END-EXEC.
            WS.WRK_RET_CD.SetValue(DbConv.SQLCA.SQLCODE);                                                       //COBOL==> MOVE SQLCODE TO WRK-RET-CD.
            if (returnMethod != "" && returnMethod != "M_8210_OPEN_BENA_CSR") { M_8220_FETCH_BENA_CSR(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_8220_FETCH_BENA_CSR
        /// </summary>
        /// <remarks>
        ///COMMENT: *****************************************************************
        ///COMMENT:  FETCH CURSOR FOR KSD BENEFITS ARCHIVE DB2 TABLE ROUTINE
        ///COMMENT: *****************************************************************
        /// </remarks>
        private void M_8220_FETCH_BENA_CSR(string returnMethod = "")
        {
            DbConv.FetchReaderRow("BENACSR",                                                                 //COBOL==> EXEC SQL FETCH BENACSR INTO :BENA-CASE-NUMBER , :BENA-PROGRAM-TYPE , :BENA-PROGRAM-SUBTYPE , :BENA-BENEFIT-MONTH , :BENA-ISSUANCE-TYPE , :BENA-BENEFIT-TYPE , :BENA-BUDGETING-METHOD , :BENA-ISSUED-DATE , :BENA-PAYMENT-START-DATE , :BENA-PAYMENT-END-DATE , :BENA-CREATED-BY , :BENA-CREATED-TIMESTAMP END-EXEC.
                             WS.BENA_CASE_NUMBER, WS.BENA_PROGRAM_TYPE, WS.BENA_PROGRAM_SUBTYPE, WS.BENA_BENEFIT_MONTH, WS.BENA_ISSUANCE_TYPE, WS.BENA_BENEFIT_TYPE, WS.BENA_BUDGETING_METHOD, WS.BENA_ISSUED_DATE, WS.BENA_PAYMENT_START_DATE, WS.BENA_PAYMENT_END_DATE, WS.BENA_CREATED_BY, WS.BENA_CREATED_TIMESTAMP);
            WS.WRK_RET_CD.SetValue(DbConv.SQLCA.SQLCODE);                                                       //COBOL==> MOVE SQLCODE TO WRK-RET-CD.
            if (returnMethod != "" && returnMethod != "M_8220_FETCH_BENA_CSR") { M_8230_CLOSE_BENA_CSR(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_8230_CLOSE_BENA_CSR
        /// </summary>
        /// <remarks>
        ///COMMENT: *****************************************************************
        ///COMMENT:  CLOSE CURSOR FOR KSD BENEFITS ARCHIVE DB2 TABLE ROUTINE
        ///COMMENT: *****************************************************************
        /// </remarks>
        private void M_8230_CLOSE_BENA_CSR(string returnMethod = "")
        {
            DbConv.CloseReader("BENACSR");                                                                      //COBOL==> EXEC SQL CLOSE BENACSR END-EXEC.
            WS.WRK_RET_CD.SetValue(DbConv.SQLCA.SQLCODE);                                                       //COBOL==> MOVE SQLCODE TO WRK-RET-CD.
        }
        #endregion
    }
    #endregion
}
