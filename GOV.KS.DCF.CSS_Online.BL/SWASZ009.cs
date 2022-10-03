#region Comments
/* Conversion Comments
   ************************************************************
   **   MODERN SYSTEMS INC.  COPYRIGHT 2000-2022
   **   DB-SHUTTLE COBOL to C# Conversion
   ************************************************************
   ** INIT   *  INITIAL VERSION   *  2022-01-14 12:46:07 PM
   **        *   FROM COBOL PGM   :  SWASZ009
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
    internal class SWASZ009_ws : PredefinedRecordBase
    {
        #region Name constants
        /// <summary>
        /// Name constants.
        /// </summary>
        internal static class Names
        {
            internal const string WorkingStorage = "SWASZ009_ws_WorkingStorage";
            internal const string MODULE_CONSTANTS = "MODULE_CONSTANTS";
            internal const string MC_DATE_DAY_TBL = "MC_DATE_DAY_TBL";
            internal const string MC_DATE_DAYS = "MC_DATE_DAYS";
            internal const string MODULE_VARIABLES = "MODULE_VARIABLES";
            internal const string MV_TEMP = "MV_TEMP";
            internal const string MV_REMAINDER = "MV_REMAINDER";
            internal const string MV_CALC_DAY = "MV_CALC_DAY";
            internal const string MV_DAYS_TO_ADJUST = "MV_DAYS_TO_ADJUST";
            internal const string MV_ONE = "MV_ONE";
            internal const string MV_DB_END_DAY = "MV_DB_END_DAY";
        }
        #endregion

        #region Direct-access element properties
        public IGroup MODULE_CONSTANTS { get { return GetElementByName<IGroup>(Names.MODULE_CONSTANTS); } }
        public IGroup MC_DATE_DAY_TBL { get { return GetElementByName<IGroup>(Names.MC_DATE_DAY_TBL); } }
        public IArrayElementAccessor<IField> MC_DATE_DAYS { get { return GetArrayElementAccessor<IField>(Names.MC_DATE_DAYS); } }
        public IGroup MODULE_VARIABLES { get { return GetElementByName<IGroup>(Names.MODULE_VARIABLES); } }
        public IField MV_TEMP { get { return GetElementByName<IField>(Names.MV_TEMP); } }
        public IField MV_REMAINDER { get { return GetElementByName<IField>(Names.MV_REMAINDER); } }
        public IField MV_CALC_DAY { get { return GetElementByName<IField>(Names.MV_CALC_DAY); } }
        public IField MV_DAYS_TO_ADJUST { get { return GetElementByName<IField>(Names.MV_DAYS_TO_ADJUST); } }
        public IField MV_ONE { get { return GetElementByName<IField>(Names.MV_ONE); } }
        public IField MV_DB_END_DAY { get { return GetElementByName<IField>(Names.MV_DB_END_DAY); } }

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
                   MC_DATE_DAY_TBL.CreateNewFillerField(FieldType.UnsignedNumeric, 2, 31);
                   MC_DATE_DAY_TBL.CreateNewFillerField(FieldType.UnsignedNumeric, 2, 28);
                   MC_DATE_DAY_TBL.CreateNewFillerField(FieldType.UnsignedNumeric, 2, 31);
                   MC_DATE_DAY_TBL.CreateNewFillerField(FieldType.UnsignedNumeric, 2, 30);
                   MC_DATE_DAY_TBL.CreateNewFillerField(FieldType.UnsignedNumeric, 2, 31);
                   MC_DATE_DAY_TBL.CreateNewFillerField(FieldType.UnsignedNumeric, 2, 30);
                   MC_DATE_DAY_TBL.CreateNewFillerField(FieldType.UnsignedNumeric, 2, 31);
                   MC_DATE_DAY_TBL.CreateNewFillerField(FieldType.UnsignedNumeric, 2, 31);
                   MC_DATE_DAY_TBL.CreateNewFillerField(FieldType.UnsignedNumeric, 2, 30);
                   MC_DATE_DAY_TBL.CreateNewFillerField(FieldType.UnsignedNumeric, 2, 31);
                   MC_DATE_DAY_TBL.CreateNewFillerField(FieldType.UnsignedNumeric, 2, 30);
                   MC_DATE_DAY_TBL.CreateNewFillerField(FieldType.UnsignedNumeric, 2, 31);
               });
               MODULE_CONSTANTS.CreateNewGroupRedefine("FILLER_d13", MC_DATE_DAY_TBL_local, (FILLER_d13) =>
               {
                   FILLER_d13.CreateNewFieldArray(Names.MC_DATE_DAYS, 12, FieldType.UnsignedNumeric, 2);
               });
           });

            recordDef.CreateNewGroup(Names.MODULE_VARIABLES, (MODULE_VARIABLES) =>
           {
               MODULE_VARIABLES.CreateNewField(Names.MV_TEMP, FieldType.SignedNumeric, 2);
               MODULE_VARIABLES.CreateNewField(Names.MV_REMAINDER, FieldType.SignedNumeric, 2);
               MODULE_VARIABLES.CreateNewField(Names.MV_CALC_DAY, FieldType.UnsignedNumeric, 4);
               MODULE_VARIABLES.CreateNewField(Names.MV_DAYS_TO_ADJUST, FieldType.UnsignedNumeric, 4);
               MODULE_VARIABLES.CreateNewField(Names.MV_ONE, FieldType.SignedNumeric, 1);
               MODULE_VARIABLES.CreateNewField(Names.MV_DB_END_DAY, FieldType.SignedNumeric, 2);
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
    internal class SWASZ009_ls : PredefinedRecordBase
    {
        #region Name constants
        /// <summary>
        /// Name constants.
        /// </summary>
        internal static class Names
        {
            internal const string LinkageSection = "SWASZ009_ls_LinkageSection";
            internal const string PV_DB_DATE = "PV_DB_DATE";
            internal const string PV_DB_YEAR = "PV_DB_YEAR";
            internal const string PV_DB_MONTH = "PV_DB_MONTH";
            internal const string PV_DB_DAY = "PV_DB_DAY";
            internal const string PV_DB_END_DATE = "PV_DB_END_DATE";
            internal const string PV_DB_END_YEAR = "PV_DB_END_YEAR";
            internal const string PV_DB_END_MONTH = "PV_DB_END_MONTH";
            internal const string PV_DB_END_DAY = "PV_DB_END_DAY";
            internal const string PV_DAYS_TO_ADJUST = "PV_DAYS_TO_ADJUST";
        }
        #endregion

        #region Direct-access element properties
        public IGroup PV_DB_DATE { get { return GetElementByName<IGroup>(Names.PV_DB_DATE); } }
        public IField PV_DB_YEAR { get { return GetElementByName<IField>(Names.PV_DB_YEAR); } }
        public IField PV_DB_MONTH { get { return GetElementByName<IField>(Names.PV_DB_MONTH); } }
        public IField PV_DB_DAY { get { return GetElementByName<IField>(Names.PV_DB_DAY); } }
        public IGroup PV_DB_END_DATE { get { return GetElementByName<IGroup>(Names.PV_DB_END_DATE); } }
        public IField PV_DB_END_YEAR { get { return GetElementByName<IField>(Names.PV_DB_END_YEAR); } }
        public IField PV_DB_END_MONTH { get { return GetElementByName<IField>(Names.PV_DB_END_MONTH); } }
        public IField PV_DB_END_DAY { get { return GetElementByName<IField>(Names.PV_DB_END_DAY); } }
        public IField PV_DAYS_TO_ADJUST { get { return GetElementByName<IField>(Names.PV_DAYS_TO_ADJUST); } }

        #endregion

        #region Data structure definition
        /// <summary>
        /// Defines the entirety of the LinkageSection IRecord structure as described by the Ateras.Framework.Buffer API.
        /// </summary>
        /// <param name="recordDef">The IStructureDefinition object to be used in defining the record structure.</param>
        protected override void DefineRecordStructure(IStructureDefinition recordDef)
        {

            recordDef.CreateNewGroup(Names.PV_DB_DATE, (PV_DB_DATE) =>
           {
               PV_DB_DATE.CreateNewField(Names.PV_DB_YEAR, FieldType.UnsignedNumeric, 4);
               PV_DB_DATE.CreateNewField(Names.PV_DB_MONTH, FieldType.UnsignedNumeric, 2);
               PV_DB_DATE.CreateNewField(Names.PV_DB_DAY, FieldType.UnsignedNumeric, 2);
           });

            recordDef.CreateNewGroup(Names.PV_DB_END_DATE, (PV_DB_END_DATE) =>
           {
               PV_DB_END_DATE.CreateNewField(Names.PV_DB_END_YEAR, FieldType.UnsignedNumeric, 4);
               PV_DB_END_DATE.CreateNewField(Names.PV_DB_END_MONTH, FieldType.UnsignedNumeric, 2);
               PV_DB_END_DATE.CreateNewField(Names.PV_DB_END_DAY, FieldType.UnsignedNumeric, 2);
           });
            recordDef.CreateNewField(Names.PV_DAYS_TO_ADJUST, FieldType.SignedNumeric, 4);

        }

        protected override string GetRecordName()
        {
            return Names.LinkageSection;
        }
        #endregion

        public void SetPassedParameters(object[] args)
        {
            SetPassedParm(PV_DB_DATE, args, 0);
            SetPassedParm(PV_DB_END_DATE, args, 1);
            SetPassedParm(PV_DAYS_TO_ADJUST, args, 2);
        }


        public void UpdateReturnParameters(object[] args)
        {
            SetReturnParm(PV_DB_DATE, args, 0);
            SetReturnParm(PV_DB_END_DATE, args, 1);
            SetReturnParm(PV_DAYS_TO_ADJUST, args, 2);
        }
    }
    #endregion Linkage Section Class

    #region Business Logic Class
    public class SWASZ009 : BatchBase
    {

        #region Public Constructors
        public SWASZ009()
            : base()
        {
            this.ProgramName.SetValue("SWASZ009");

            WS = new SWASZ009_ws();
            LS = new SWASZ009_ls();
        }

        #endregion

        #region Private Fields


        //==== Working Storage Data Class ========================================
        private SWASZ009_ws WS;

        //==== Linkage Section Data Class ========================================
        private SWASZ009_ls LS;
        #endregion

        #region Public Methods
        //========================================================================
        //==== RunMain Entry Point Method ========================================
        //========================================================================
        public override int ExecuteMain(params object[] args)                                              //COBOL==> PROCEDURE DIVISION USING PV-DB-DATE PV-DB-END-DATE PV-DAYS-TO-ADJUST.
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
            //COMMENT: *** BEFORE ADJUSTING THE REQUIRED NUMBER OF DAYS TO A DATE
            //COMMENT: *** ENSURE THAT THE GIVEN DATE IS VALID AS FAR AS THE MONTH IS
            //COMMENT: *** CONCERNED
            //COMMENT: *** IF THE DATE IS INVALID, SET THE RETURNED DATE TO ZEROS
            if (LS.PV_DAYS_TO_ADJUST.IsPositive())                                                              //COBOL==> IF PV-DAYS-TO-ADJUST IS POSITIVE
            {
                WS.MV_ONE.SetValue(+1);                                                                             //COBOL==> MOVE +1 TO MV-ONE
            }                                                                                                   //COBOL==> ELSE
            else
            {
                WS.MV_ONE.SetValue(-1);                                                                             //COBOL==> MOVE -1 TO MV-ONE.
            }
            if ((LS.PV_DB_MONTH.IsLessThan(1))
             || (LS.PV_DB_MONTH.IsGreaterThan(12)))           //COBOL==> IF PV-DB-MONTH < 1 OR > 12
            {
                LS.PV_DB_END_DATE.SetValueWithZeroes();                                                             //COBOL==> MOVE ZEROS TO PV-DB-END-DATE
            }                                                                                                   //COBOL==> ELSE
            else
            {
                LS.PV_DB_END_YEAR.SetValue(LS.PV_DB_YEAR);                                                          //COBOL==> MOVE PV-DB-YEAR TO PV-DB-END-YEAR
                LS.PV_DB_END_MONTH.SetValue(LS.PV_DB_MONTH);                                                        //COBOL==> MOVE PV-DB-MONTH TO PV-DB-END-MONTH
                WS.MV_DB_END_DAY.SetValue(LS.PV_DB_DAY);                                                            //COBOL==> MOVE PV-DB-DAY TO MV-DB-END-DAY
                M_4000_DET_LEAP_YEAR("M_4000_EXIT"); if (Control.ExitProgram) { return; }                             //COBOL==> PERFORM 4000-DET-LEAP-YEAR THRU 4000-EXIT
                WS.MV_DAYS_TO_ADJUST.SetValue(LS.PV_DAYS_TO_ADJUST);                                                //COBOL==> MOVE PV-DAYS-TO-ADJUST TO MV-DAYS-TO-ADJUST
                for (int i = 0; i < WS.MV_DAYS_TO_ADJUST.AsInt(); i++)                                              //COBOL==> PERFORM 1000-ADJUST-DAYS-TO-DATE THRU 1000-EXIT MV-DAYS-TO-ADJUST TIMES
                {
                    M_1000_ADJUST_DAYS_TO_DATE("M_1000_EXIT"); if (Control.ExitProgram) { return; }
                }
                LS.PV_DB_END_DAY.SetValue(WS.MV_DB_END_DAY);                                                        //COBOL==> MOVE MV-DB-END-DAY TO PV-DB-END-DAY.
            }
            Control.ExitProgram = true; return;                                                                 //COBOL==> GOBACK.
        }
        /// <summary>
        /// Method M_1000_ADJUST_DAYS_TO_DATE
        /// </summary>
        /// <remarks>
        ///COMMENT: *** ADJUST THE GIVEN DATE EITHER FORWARD OR BACKWARD ONE DAY
        ///COMMENT: *** AT A TIME FOR THE NUMBER OF ADJUSTMENT DAYS
        ///COMMENT: *** ADJUST FOR NEW MONTH AND NEW YEAR
        /// </remarks>
        private void M_1000_ADJUST_DAYS_TO_DATE(string returnMethod = "")
        {
            WS.MV_DB_END_DAY.Add(WS.MV_ONE.AsDecimal());                                                        //COBOL==> ADD MV-ONE TO MV-DB-END-DAY.
            if (WS.MV_DB_END_DAY.IsEqualTo(0))                                                                  //COBOL==> IF MV-DB-END-DAY = ZERO
            {
                M_2000_PREV_MONTH("M_2000_EXIT"); if (Control.ExitProgram) { return; }                                //COBOL==> PERFORM 2000-PREV-MONTH THRU 2000-EXIT.
            }
            if (WS.MV_DB_END_DAY.IsGreaterThan(WS.MC_DATE_DAYS[LS.PV_DB_END_MONTH.AsInt()]))                    //COBOL==> IF MV-DB-END-DAY > MC-DATE-DAYS ( PV-DB-END-MONTH )
            {
                M_3000_NEXT_MONTH("M_3000_EXIT"); if (Control.ExitProgram) { return; }                                //COBOL==> PERFORM 3000-NEXT-MONTH THRU 3000-EXIT.
            }
            if (returnMethod != "" && returnMethod != "M_1000_ADJUST_DAYS_TO_DATE") { M_1000_EXIT(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_1000_EXIT
        /// </summary>
        private void M_1000_EXIT(string returnMethod = "")
        {
            if (returnMethod != "" && returnMethod != "M_1000_EXIT") { M_2000_PREV_MONTH(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_2000_PREV_MONTH
        /// </summary>
        /// <remarks>
        ///COMMENT: *** GO BACK TO PREVIOUS MONTH
        ///COMMENT: *** IF CURRENT MONTH IS JANUARY, GO BACK TO PREVIOUS YEAR AS WELL
        /// </remarks>
        private void M_2000_PREV_MONTH(string returnMethod = "")
        {
            LS.PV_DB_END_MONTH.SetValue(LS.PV_DB_END_MONTH.AsInt() - 1);                                        //COBOL==> SUBTRACT 1 FROM PV-DB-END-MONTH.
            if (LS.PV_DB_END_MONTH.IsEqualTo(0))                                                                //COBOL==> IF PV-DB-END-MONTH = ZERO
            {
                LS.PV_DB_END_MONTH.SetValue(12);                                                                    //COBOL==> MOVE 12 TO PV-DB-END-MONTH
                LS.PV_DB_END_YEAR.SetValue(LS.PV_DB_END_YEAR.AsInt() - 01);                                         //COBOL==> SUBTRACT 01 FROM PV-DB-END-YEAR
                M_4000_DET_LEAP_YEAR("M_4000_EXIT"); if (Control.ExitProgram) { return; }                             //COBOL==> PERFORM 4000-DET-LEAP-YEAR THRU 4000-EXIT.
            }
            WS.MV_DB_END_DAY.SetValue(WS.MC_DATE_DAYS[LS.PV_DB_END_MONTH]);                                     //COBOL==> MOVE MC-DATE-DAYS ( PV-DB-END-MONTH ) TO MV-DB-END-DAY.
            if (returnMethod != "" && returnMethod != "M_2000_PREV_MONTH") { M_2000_EXIT(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_2000_EXIT
        /// </summary>
        private void M_2000_EXIT(string returnMethod = "")
        {
            if (returnMethod != "" && returnMethod != "M_2000_EXIT") { M_3000_NEXT_MONTH(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_3000_NEXT_MONTH
        /// </summary>
        /// <remarks>
        ///COMMENT: *** INCREMENT MONTH TO NEXT ONE
        ///COMMENT: *** IF MONTH BECOMES 13, THEN INCREMENT YEAR TO NEXT ONE
        /// </remarks>
        private void M_3000_NEXT_MONTH(string returnMethod = "")
        {
            LS.PV_DB_END_MONTH.Add(01);                                                                         //COBOL==> ADD 01 TO PV-DB-END-MONTH.
            if (LS.PV_DB_END_MONTH.IsGreaterThan(12))                                                           //COBOL==> IF PV-DB-END-MONTH > 12
            {
                LS.PV_DB_END_MONTH.SetValue(01);                                                                    //COBOL==> MOVE 01 TO PV-DB-END-MONTH
                LS.PV_DB_END_YEAR.Add(01);                                                                          //COBOL==> ADD 01 TO PV-DB-END-YEAR
                M_4000_DET_LEAP_YEAR("M_4000_EXIT"); if (Control.ExitProgram) { return; }                             //COBOL==> PERFORM 4000-DET-LEAP-YEAR THRU 4000-EXIT.
            }
            WS.MV_DB_END_DAY.SetValue(01);                                                                      //COBOL==> MOVE 01 TO MV-DB-END-DAY.
            if (returnMethod != "" && returnMethod != "M_3000_NEXT_MONTH") { M_3000_EXIT(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_3000_EXIT
        /// </summary>
        private void M_3000_EXIT(string returnMethod = "")
        {
            if (returnMethod != "" && returnMethod != "M_3000_EXIT") { M_4000_DET_LEAP_YEAR(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_4000_DET_LEAP_YEAR
        /// </summary>
        /// <remarks>
        ///COMMENT: *** DETERMINE IF THE YEAR IS A LEAP YEAR
        ///COMMENT: *** IF IT IS, THEN STORE 29 DAYS FOR FEBRUARY
        /// </remarks>
        private void M_4000_DET_LEAP_YEAR(string returnMethod = "")
        {
            WS.MV_TEMP.SetValue(LS.PV_DB_END_YEAR.AsDecimal() / 4m);                                            //COBOL==> DIVIDE PV-DB-END-YEAR BY 4 GIVING MV-TEMP REMAINDER MV-REMAINDER.
            WS.MV_REMAINDER.SetValue(LS.PV_DB_END_YEAR.AsDecimal() % 4m);
            if (WS.MV_REMAINDER.IsEqualTo(0))                                                                   //COBOL==> IF MV-REMAINDER = 0
            {
                WS.MC_DATE_DAYS[2].SetValue(29);                                                                    //COBOL==> MOVE 29 TO MC-DATE-DAYS ( 2 )
            }                                                                                                   //COBOL==> ELSE
            else
            {
                WS.MC_DATE_DAYS[2].SetValue(28);                                                                    //COBOL==> MOVE 28 TO MC-DATE-DAYS ( 2 ) .
            }
            if (returnMethod != "" && returnMethod != "M_4000_DET_LEAP_YEAR") { M_4000_EXIT(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_4000_EXIT
        /// </summary>
        private void M_4000_EXIT(string returnMethod = "")
        {
        }
        #endregion
    }
    #endregion
}
