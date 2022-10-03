#region Comments
/* Conversion Comments
   ************************************************************
   **   MODERN SYSTEMS INC.  COPYRIGHT 2000-2022
   **   DB-SHUTTLE COBOL to C# Conversion
   ************************************************************
   ** INIT   *  INITIAL VERSION   *  2022-01-14 12:46:06 PM
   **        *   FROM COBOL PGM   :  SWASZ008
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
    internal class SWASZ008_ws : PredefinedRecordBase
    {
        #region Name constants
        /// <summary>
        /// Name constants.
        /// </summary>
        internal static class Names
        {
            internal const string WorkingStorage = "SWASZ008_ws_WorkingStorage";
            internal const string MODULE_CONSTANTS = "MODULE_CONSTANTS";
            internal const string MC_DATE_DAY_TBL = "MC_DATE_DAY_TBL";
            internal const string MC_DATE_DAYS = "MC_DATE_DAYS";
            internal const string MODULE_VARIABLES = "MODULE_VARIABLES";
            internal const string MV_FROM_DAYS = "MV_FROM_DAYS";
            internal const string MV_TO_DAYS = "MV_TO_DAYS";
            internal const string MV_LEAP_DAYS = "MV_LEAP_DAYS";
            internal const string MV_REMAINDER = "MV_REMAINDER";
        }
        #endregion

        #region Direct-access element properties
        public IGroup MODULE_CONSTANTS { get { return GetElementByName<IGroup>(Names.MODULE_CONSTANTS); } }
        public IGroup MC_DATE_DAY_TBL { get { return GetElementByName<IGroup>(Names.MC_DATE_DAY_TBL); } }
        public IArrayElementAccessor<IField> MC_DATE_DAYS { get { return GetArrayElementAccessor<IField>(Names.MC_DATE_DAYS); } }
        public IGroup MODULE_VARIABLES { get { return GetElementByName<IGroup>(Names.MODULE_VARIABLES); } }
        public IField MV_FROM_DAYS { get { return GetElementByName<IField>(Names.MV_FROM_DAYS); } }
        public IField MV_TO_DAYS { get { return GetElementByName<IField>(Names.MV_TO_DAYS); } }
        public IField MV_LEAP_DAYS { get { return GetElementByName<IField>(Names.MV_LEAP_DAYS); } }
        public IField MV_REMAINDER { get { return GetElementByName<IField>(Names.MV_REMAINDER); } }

        #endregion

        #region Data structure definition
        /// <summary>
        /// Defines the entirety of the WorkingStorage IRecord structure as described by the Ateras.Framework.Buffer API.
        /// </summary>
        /// <param name="recordDef">The IStructureDefinition object to be used in defining the record structure.</param>
        protected override void DefineRecordStructure(IStructureDefinition recordDef)
        {

            recordDef.CreateNewGroup(Names.MODULE_CONSTANTS, (MODULE_CONSTANTS) =>
           {
               IGroup MC_DATE_DAY_TBL_local = (IGroup)MODULE_CONSTANTS.CreateNewGroup(Names.MC_DATE_DAY_TBL, (MC_DATE_DAY_TBL) =>
               {
                   MC_DATE_DAY_TBL.CreateNewFillerField(FieldType.CompShort, 2, +000);
                   MC_DATE_DAY_TBL.CreateNewFillerField(FieldType.CompShort, 2, +031);
                   MC_DATE_DAY_TBL.CreateNewFillerField(FieldType.CompShort, 2, +059);
                   MC_DATE_DAY_TBL.CreateNewFillerField(FieldType.CompShort, 2, +090);
                   MC_DATE_DAY_TBL.CreateNewFillerField(FieldType.CompShort, 2, +120);
                   MC_DATE_DAY_TBL.CreateNewFillerField(FieldType.CompShort, 2, +151);
                   MC_DATE_DAY_TBL.CreateNewFillerField(FieldType.CompShort, 2, +181);
                   MC_DATE_DAY_TBL.CreateNewFillerField(FieldType.CompShort, 2, +212);
                   MC_DATE_DAY_TBL.CreateNewFillerField(FieldType.CompShort, 2, +243);
                   MC_DATE_DAY_TBL.CreateNewFillerField(FieldType.CompShort, 2, +273);
                   MC_DATE_DAY_TBL.CreateNewFillerField(FieldType.CompShort, 2, +304);
                   MC_DATE_DAY_TBL.CreateNewFillerField(FieldType.CompShort, 2, +334);
               });
               MODULE_CONSTANTS.CreateNewGroupRedefine("FILLER_d13", MC_DATE_DAY_TBL_local, (FILLER_d13) =>
               {
                   FILLER_d13.CreateNewFieldArray(Names.MC_DATE_DAYS, 12, FieldType.CompShort, 3);
               });
           });

            recordDef.CreateNewGroup(Names.MODULE_VARIABLES, (MODULE_VARIABLES) =>
           {
               MODULE_VARIABLES.CreateNewField(Names.MV_FROM_DAYS, FieldType.CompInt, 7);
               MODULE_VARIABLES.CreateNewField(Names.MV_TO_DAYS, FieldType.CompInt, 7);
               MODULE_VARIABLES.CreateNewField(Names.MV_LEAP_DAYS, FieldType.CompShort, 3);
               MODULE_VARIABLES.CreateNewField(Names.MV_REMAINDER, FieldType.CompShort, 2);
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
    internal class SWASZ008_ls : PredefinedRecordBase
    {
        #region Name constants
        /// <summary>
        /// Name constants.
        /// </summary>
        internal static class Names
        {
            internal const string LinkageSection = "SWASZ008_ls_LinkageSection";
            internal const string PV_FROM_YYYYMMDD = "PV_FROM_YYYYMMDD";
            internal const string PV_FROM_YYYY = "PV_FROM_YYYY";
            internal const string PV_FROM_MM = "PV_FROM_MM";
            internal const string PV_FROM_DD = "PV_FROM_DD";
            internal const string PV_TO_YYYYMMDD = "PV_TO_YYYYMMDD";
            internal const string PV_TO_YYYY = "PV_TO_YYYY";
            internal const string PV_TO_MM = "PV_TO_MM";
            internal const string PV_TO_DD = "PV_TO_DD";
            internal const string PV_DAYS_DIFFERENCE = "PV_DAYS_DIFFERENCE";
        }
        #endregion

        #region Direct-access element properties
        public IGroup PV_FROM_YYYYMMDD { get { return GetElementByName<IGroup>(Names.PV_FROM_YYYYMMDD); } }
        public IField PV_FROM_YYYY { get { return GetElementByName<IField>(Names.PV_FROM_YYYY); } }
        public IField PV_FROM_MM { get { return GetElementByName<IField>(Names.PV_FROM_MM); } }
        public IField PV_FROM_DD { get { return GetElementByName<IField>(Names.PV_FROM_DD); } }
        public IGroup PV_TO_YYYYMMDD { get { return GetElementByName<IGroup>(Names.PV_TO_YYYYMMDD); } }
        public IField PV_TO_YYYY { get { return GetElementByName<IField>(Names.PV_TO_YYYY); } }
        public IField PV_TO_MM { get { return GetElementByName<IField>(Names.PV_TO_MM); } }
        public IField PV_TO_DD { get { return GetElementByName<IField>(Names.PV_TO_DD); } }
        public IField PV_DAYS_DIFFERENCE { get { return GetElementByName<IField>(Names.PV_DAYS_DIFFERENCE); } }

        #endregion

        #region Data structure definition
        /// <summary>
        /// Defines the entirety of the LinkageSection IRecord structure as described by the Ateras.Framework.Buffer API.
        /// </summary>
        /// <param name="recordDef">The IStructureDefinition object to be used in defining the record structure.</param>
        protected override void DefineRecordStructure(IStructureDefinition recordDef)
        {

            recordDef.CreateNewGroup(Names.PV_FROM_YYYYMMDD, (PV_FROM_YYYYMMDD) =>
           {
               PV_FROM_YYYYMMDD.CreateNewField(Names.PV_FROM_YYYY, FieldType.UnsignedNumeric, 4);
               PV_FROM_YYYYMMDD.CreateNewField(Names.PV_FROM_MM, FieldType.UnsignedNumeric, 2);
               PV_FROM_YYYYMMDD.CreateNewField(Names.PV_FROM_DD, FieldType.UnsignedNumeric, 2);
           });

            recordDef.CreateNewGroup(Names.PV_TO_YYYYMMDD, (PV_TO_YYYYMMDD) =>
           {
               PV_TO_YYYYMMDD.CreateNewField(Names.PV_TO_YYYY, FieldType.UnsignedNumeric, 4);
               PV_TO_YYYYMMDD.CreateNewField(Names.PV_TO_MM, FieldType.UnsignedNumeric, 2);
               PV_TO_YYYYMMDD.CreateNewField(Names.PV_TO_DD, FieldType.UnsignedNumeric, 2);
           });
            recordDef.CreateNewField(Names.PV_DAYS_DIFFERENCE, FieldType.SignedNumeric, 7);

        }

        protected override string GetRecordName()
        {
            return Names.LinkageSection;
        }
        #endregion

        public void SetPassedParameters(object[] args)
        {
            SetPassedParm(PV_FROM_YYYYMMDD, args, 0);
            SetPassedParm(PV_TO_YYYYMMDD, args, 1);
            SetPassedParm(PV_DAYS_DIFFERENCE, args, 2);
        }


        public void UpdateReturnParameters(object[] args)
        {
            SetReturnParm(PV_FROM_YYYYMMDD, args, 0);
            SetReturnParm(PV_TO_YYYYMMDD, args, 1);
            SetReturnParm(PV_DAYS_DIFFERENCE, args, 2);
        }
    }
    #endregion Linkage Section Class

    #region Business Logic Class
    public class SWASZ008 : BatchBase
    {

        #region Public Constructors
        public SWASZ008()
            : base()
        {
            this.ProgramName.SetValue("SWASZ008");

            WS = new SWASZ008_ws();
            LS = new SWASZ008_ls();
        }

        #endregion

        #region Private Fields


        //==== Working Storage Data Class ========================================
        private SWASZ008_ws WS;

        //==== Linkage Section Data Class ========================================
        private SWASZ008_ls LS;
        #endregion

        #region Public Methods
        //========================================================================
        //==== RunMain Entry Point Method ========================================
        //========================================================================
        public override int ExecuteMain(params object[] args)                                              //COBOL==> PROCEDURE DIVISION USING PV-FROM-YYYYMMDD PV-TO-YYYYMMDD PV-DAYS-DIFFERENCE.
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
            M_0000_CONVERT_TO_ABSOLUTE_DAYS(returnMethod);
        }
        /// <summary>
        /// Method M_0000_CONVERT_TO_ABSOLUTE_DAYS
        /// </summary>
        private void M_0000_CONVERT_TO_ABSOLUTE_DAYS(string returnMethod = "")
        {
            WS.MV_LEAP_DAYS.SetValue(LS.PV_FROM_YYYY.AsDecimal() / 4m);                                         //COBOL==> DIVIDE PV-FROM-YYYY BY 4 GIVING MV-LEAP-DAYS REMAINDER MV-REMAINDER.
            WS.MV_REMAINDER.SetValue(LS.PV_FROM_YYYY.AsDecimal() % 4m);
            WS.MV_FROM_DAYS.SetComputeValue(((WS.MC_DATE_DAYS[LS.PV_FROM_MM].AsDecimal() + LS.PV_FROM_DD.AsDecimal()) + (LS.PV_FROM_YYYY.AsInt() * 365)) + WS.MV_LEAP_DAYS.AsDecimal());  //COBOL==> COMPUTE MV-FROM-DAYS = MC-DATE-DAYS ( PV-FROM-MM ) + PV-FROM-DD + PV-FROM-YYYY * 365 + MV-LEAP-DAYS.
            if ((LS.PV_FROM_MM.IsLessThan(2))
             && (WS.MV_REMAINDER.IsEqualTo(0)))                //COBOL==> IF PV-FROM-MM < 2 AND MV-REMAINDER = 0
            {
                WS.MV_FROM_DAYS.SetValue(WS.MV_FROM_DAYS.AsInt() - 1);                                              //COBOL==> SUBTRACT 1 FROM MV-FROM-DAYS.
            }
            WS.MV_LEAP_DAYS.SetValue(LS.PV_TO_YYYY.AsDecimal() / 4m);                                           //COBOL==> DIVIDE PV-TO-YYYY BY 4 GIVING MV-LEAP-DAYS REMAINDER MV-REMAINDER.
            WS.MV_REMAINDER.SetValue(LS.PV_TO_YYYY.AsDecimal() % 4m);
            WS.MV_TO_DAYS.SetComputeValue(((WS.MC_DATE_DAYS[LS.PV_TO_MM].AsDecimal() + LS.PV_TO_DD.AsDecimal()) + (LS.PV_TO_YYYY.AsInt() * 365)) + WS.MV_LEAP_DAYS.AsDecimal());  //COBOL==> COMPUTE MV-TO-DAYS = MC-DATE-DAYS ( PV-TO-MM ) + PV-TO-DD + PV-TO-YYYY * 365 + MV-LEAP-DAYS.
            if ((LS.PV_TO_MM.IsLessThan(2))
             && (WS.MV_REMAINDER.IsEqualTo(0)))                  //COBOL==> IF PV-TO-MM < 2 AND MV-REMAINDER = 0
            {
                WS.MV_TO_DAYS.SetValue(WS.MV_TO_DAYS.AsInt() - 1);                                                  //COBOL==> SUBTRACT 1 FROM MV-TO-DAYS.
            }
            //COMMENT: ***
            //COMMENT: *** SUBTRACT ABSOLUTE DAYS
            //COMMENT: ***
            LS.PV_DAYS_DIFFERENCE.SetComputeValue(WS.MV_TO_DAYS.AsDecimal() - WS.MV_FROM_DAYS.AsDecimal());     //COBOL==> COMPUTE PV-DAYS-DIFFERENCE = MV-TO-DAYS - MV-FROM-DAYS.
            if (!(LS.PV_DAYS_DIFFERENCE.IsEqualTo(0)))                                                          //COBOL==> IF PV-DAYS-DIFFERENCE NOT = 0
            {
                LS.PV_DAYS_DIFFERENCE.SetValue(LS.PV_DAYS_DIFFERENCE.AsInt() - 1);                                  //COBOL==> SUBTRACT 1 FROM PV-DAYS-DIFFERENCE.
            }
            if (returnMethod != "" && returnMethod != "M_0000_CONVERT_TO_ABSOLUTE_DAYS") { M_0000_EXIT(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_0000_EXIT
        /// </summary>
        private void M_0000_EXIT(string returnMethod = "")
        {
            Control.ExitProgram = true; return;                                                                 //COBOL==> GOBACK.
        }
        #endregion
    }
    #endregion
}
