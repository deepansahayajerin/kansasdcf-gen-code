#region Comments
/* Conversion Comments
   ************************************************************
   **   MODERN SYSTEMS INC.  COPYRIGHT 2000-2022
   **   DB-SHUTTLE COBOL to C# Conversion
   ************************************************************
   ** INIT   *  INITIAL VERSION   *  2022-03-02 04:48:20 PM
   **        *   FROM COBOL PGM   :  SWEXGDAT
   **        *   FROM CANISTER    :  SR.CAECSES.PROD.LIBR.SOURCE.PDS
   ************************************************************ */

/* Original Program Identification Comments
   REMARKS.
       DATE UTILITY.
   
               REQUIRED PARAMETER:
                A. WS-FROM-DATE (CCYYMMDD) TEXT
               RETURN PARAMETER:
                B. WS-DATE-RETURN (CCYYMMDD) NUMERIC DATE FORMAT
                   (ONLY PRESENT IF VALID OR CORRECTED DATE)
                   (OTHERWISE WILL BE ZEROS)
                C. WS-DATE-RETURN-CODE (SPACES EQUALS VALID DATE)
   
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
    internal class SWEXGDAT_ws : PredefinedRecordBase
    {
        #region Name constants
        /// <summary>
        /// Name constants.
        /// </summary>
        internal static class Names
        {
            internal const string WorkingStorage = "SWEXGDAT_ws_WorkingStorage";
            internal const string WS_DATE_AREA = "WS_DATE_AREA";
            internal const string PPF_DATE_WORK = "PPF_DATE_WORK";
            internal const string PPF_WORK_CC = "PPF_WORK_CC";
            internal const string PPF_WORK_YY = "PPF_WORK_YY";
            internal const string PPF_WORK_MM = "PPF_WORK_MM";
            internal const string PPF_WORK_DD = "PPF_WORK_DD";
            internal const string WS_DATE_RETURN = "WS_DATE_RETURN";
            internal const string WS_DATE_RETURN_CODE = "WS_DATE_RETURN_CODE";
            internal const string PPF_WORK_YYYY = "PPF_WORK_YYYY";
            internal const string PROGRAM_PROCESSING_FIELDS = "PROGRAM_PROCESSING_FIELDS";
            internal const string PPF_INDX = "PPF_INDX";
            internal const string PPF_CALC_DAYS = "PPF_CALC_DAYS";
            internal const string PPF_CALC_MO = "PPF_CALC_MO";
            internal const string PPF_CALC_29_DAYS = "PPF_CALC_29_DAYS";
            internal const string PPF_CALC_FROM_DAYS = "PPF_CALC_FROM_DAYS";
            internal const string PPF_CALC_L_YRS = "PPF_CALC_L_YRS";
            internal const string PPF_CALC_YRS = "PPF_CALC_YRS";
            internal const string PPF_CALC_REMAINDER = "PPF_CALC_REMAINDER";
            internal const string PPF_CALC_REMAINDER_4 = "PPF_CALC_REMAINDER_4";
            internal const string PPF_CALC_REMAINDER_100 = "PPF_CALC_REMAINDER_100";
            internal const string PPF_CALC_REMAINDER_400 = "PPF_CALC_REMAINDER_400";
            internal const string LEAP_YEAR_SW = "LEAP_YEAR_SW";
            internal const string LEAP_YEAR = "LEAP_YEAR";
            internal const string PPF_WORK_DAYS = "PPF_WORK_DAYS";
            internal const string PROGRAM_PROCESSING_CODES = "PROGRAM_PROCESSING_CODES";
            internal const string PPC_MONTH_VALUES = "PPC_MONTH_VALUES";
            internal const string MONTH_1 = "MONTH_1";
            internal const string MONTH_2 = "MONTH_2";
            internal const string MONTH_3 = "MONTH_3";
            internal const string MONTH_4 = "MONTH_4";
            internal const string MONTH_5 = "MONTH_5";
            internal const string MONTH_6 = "MONTH_6";
            internal const string MONTH_7 = "MONTH_7";
            internal const string MONTH_8 = "MONTH_8";
            internal const string MONTH_9 = "MONTH_9";
            internal const string MONTH_10 = "MONTH_10";
            internal const string MONTH_11 = "MONTH_11";
            internal const string MONTH_12 = "MONTH_12";
            internal const string PPC_DAY_ACC_TABLE = "PPC_DAY_ACC_TABLE";
            internal const string PPC_DAY_ACC_TABLE_Redefines = "PPC_DAY_ACC_TABLE_Redefines";
            internal const string PPC_MONTH = "PPC_MONTH";
            internal const string PPC_DAYS_IN_MONTH = "PPC_DAYS_IN_MONTH";
        }
        #endregion

        #region Direct-access element properties
        public IField WS_DATE_AREA { get { return GetElementByName<IField>(Names.WS_DATE_AREA); } }
        public IGroup PPF_DATE_WORK { get { return GetElementByName<IGroup>(Names.PPF_DATE_WORK); } }
        public IField PPF_WORK_CC { get { return GetElementByName<IField>(Names.PPF_WORK_CC); } }
        public IField PPF_WORK_YY { get { return GetElementByName<IField>(Names.PPF_WORK_YY); } }
        public IField PPF_WORK_MM { get { return GetElementByName<IField>(Names.PPF_WORK_MM); } }
        public IField PPF_WORK_DD { get { return GetElementByName<IField>(Names.PPF_WORK_DD); } }
        public IField WS_DATE_RETURN { get { return GetElementByName<IField>(Names.WS_DATE_RETURN); } }
        public IField WS_DATE_RETURN_CODE { get { return GetElementByName<IField>(Names.WS_DATE_RETURN_CODE); } }
        public IField PPF_WORK_YYYY { get { return GetElementByName<IField>(Names.PPF_WORK_YYYY); } }
        public IGroup PROGRAM_PROCESSING_FIELDS { get { return GetElementByName<IGroup>(Names.PROGRAM_PROCESSING_FIELDS); } }
        public IField PPF_INDX { get { return GetElementByName<IField>(Names.PPF_INDX); } }
        public IField PPF_CALC_DAYS { get { return GetElementByName<IField>(Names.PPF_CALC_DAYS); } }
        public IField PPF_CALC_MO { get { return GetElementByName<IField>(Names.PPF_CALC_MO); } }
        public IField PPF_CALC_29_DAYS { get { return GetElementByName<IField>(Names.PPF_CALC_29_DAYS); } }
        public IField PPF_CALC_FROM_DAYS { get { return GetElementByName<IField>(Names.PPF_CALC_FROM_DAYS); } }
        public IField PPF_CALC_L_YRS { get { return GetElementByName<IField>(Names.PPF_CALC_L_YRS); } }
        public IField PPF_CALC_YRS { get { return GetElementByName<IField>(Names.PPF_CALC_YRS); } }
        public IField PPF_CALC_REMAINDER { get { return GetElementByName<IField>(Names.PPF_CALC_REMAINDER); } }
        public IField PPF_CALC_REMAINDER_4 { get { return GetElementByName<IField>(Names.PPF_CALC_REMAINDER_4); } }
        public IField PPF_CALC_REMAINDER_100 { get { return GetElementByName<IField>(Names.PPF_CALC_REMAINDER_100); } }
        public IField PPF_CALC_REMAINDER_400 { get { return GetElementByName<IField>(Names.PPF_CALC_REMAINDER_400); } }
        public IField LEAP_YEAR_SW { get { return GetElementByName<IField>(Names.LEAP_YEAR_SW); } }
        public ICheckField LEAP_YEAR { get { return GetElementByName<ICheckField>(Names.LEAP_YEAR); } }
        public IField PPF_WORK_DAYS { get { return GetElementByName<IField>(Names.PPF_WORK_DAYS); } }
        public IGroup PROGRAM_PROCESSING_CODES { get { return GetElementByName<IGroup>(Names.PROGRAM_PROCESSING_CODES); } }
        public IGroup PPC_MONTH_VALUES { get { return GetElementByName<IGroup>(Names.PPC_MONTH_VALUES); } }
        public IField MONTH_1 { get { return GetElementByName<IField>(Names.MONTH_1); } }
        public IField MONTH_2 { get { return GetElementByName<IField>(Names.MONTH_2); } }
        public IField MONTH_3 { get { return GetElementByName<IField>(Names.MONTH_3); } }
        public IField MONTH_4 { get { return GetElementByName<IField>(Names.MONTH_4); } }
        public IField MONTH_5 { get { return GetElementByName<IField>(Names.MONTH_5); } }
        public IField MONTH_6 { get { return GetElementByName<IField>(Names.MONTH_6); } }
        public IField MONTH_7 { get { return GetElementByName<IField>(Names.MONTH_7); } }
        public IField MONTH_8 { get { return GetElementByName<IField>(Names.MONTH_8); } }
        public IField MONTH_9 { get { return GetElementByName<IField>(Names.MONTH_9); } }
        public IField MONTH_10 { get { return GetElementByName<IField>(Names.MONTH_10); } }
        public IField MONTH_11 { get { return GetElementByName<IField>(Names.MONTH_11); } }
        public IField MONTH_12 { get { return GetElementByName<IField>(Names.MONTH_12); } }
        public IGroup PPC_DAY_ACC_TABLE_Redefines { get { return GetElementByName<IGroup>(Names.PPC_DAY_ACC_TABLE_Redefines); } }
        public IArrayElementAccessor<IGroup> PPC_DAY_ACC_TABLE { get { return GetArrayElementAccessor<IGroup>(Names.PPC_DAY_ACC_TABLE); } }
        public IArrayElementAccessor<IField> PPC_MONTH { get { return GetArrayElementAccessor<IField>(Names.PPC_MONTH); } }
        public IArrayElementAccessor<IField> PPC_DAYS_IN_MONTH { get { return GetArrayElementAccessor<IField>(Names.PPC_DAYS_IN_MONTH); } }

        #endregion

        #region Data structure definition
        /// <summary>
        /// Defines the entirety of the WorkingStorage IRecord structure as described by the Ateras.Framework.Buffer API.
        /// </summary>
        /// <param name="recordDef">The IStructureDefinition object to be used in defining the record structure.</param>
        protected override void DefineRecordStructure(IStructureDefinition recordDef)
        {

            IField WS_DATE_AREA_local = recordDef.CreateNewField(Names.WS_DATE_AREA, FieldType.String, 57);
            recordDef.CreateNewGroupRedefine("FILLER", WS_DATE_AREA_local, (FILLER) =>
            {
                FILLER.CreateNewGroup(Names.PPF_DATE_WORK, (PPF_DATE_WORK) =>
                {
                    PPF_DATE_WORK.CreateNewField(Names.PPF_WORK_CC, FieldType.UnsignedNumeric, 2);
                    PPF_DATE_WORK.CreateNewField(Names.PPF_WORK_YY, FieldType.UnsignedNumeric, 2);
                    PPF_DATE_WORK.CreateNewField(Names.PPF_WORK_MM, FieldType.UnsignedNumeric, 2);
                    PPF_DATE_WORK.CreateNewField(Names.PPF_WORK_DD, FieldType.UnsignedNumeric, 2);
                });
                FILLER.CreateNewField(Names.WS_DATE_RETURN, FieldType.UnsignedNumeric, 8);
                FILLER.CreateNewField(Names.WS_DATE_RETURN_CODE, FieldType.String, 2);
                FILLER.CreateNewFillerField(39, FillWith.Hashes);
            });
            recordDef.CreateNewGroupRedefine("FILLER_d3", WS_DATE_AREA_local, (FILLER_d3) =>
            {
                FILLER_d3.CreateNewGroup("FILLER_d4", (FILLER_d4) =>
                {
                    FILLER_d4.CreateNewField(Names.PPF_WORK_YYYY, FieldType.UnsignedNumeric, 4);
                    FILLER_d4.CreateNewFillerField(4, FillWith.Hashes);
                });
                FILLER_d3.CreateNewFillerField(49, FillWith.Hashes);
            });

            recordDef.CreateNewGroup(Names.PROGRAM_PROCESSING_FIELDS, (PROGRAM_PROCESSING_FIELDS) =>
           {
               PROGRAM_PROCESSING_FIELDS.CreateNewField(Names.PPF_INDX, FieldType.PackedDecimal, 3, +0);
               PROGRAM_PROCESSING_FIELDS.CreateNewField(Names.PPF_CALC_DAYS, FieldType.PackedDecimal, 7);
               PROGRAM_PROCESSING_FIELDS.CreateNewField(Names.PPF_CALC_MO, FieldType.PackedDecimal, 7);
               PROGRAM_PROCESSING_FIELDS.CreateNewField(Names.PPF_CALC_29_DAYS, FieldType.PackedDecimal, 7);
               PROGRAM_PROCESSING_FIELDS.CreateNewField(Names.PPF_CALC_FROM_DAYS, FieldType.PackedDecimal, 7);
               PROGRAM_PROCESSING_FIELDS.CreateNewField(Names.PPF_CALC_L_YRS, FieldType.PackedDecimal, 7);
               PROGRAM_PROCESSING_FIELDS.CreateNewField(Names.PPF_CALC_YRS, FieldType.PackedDecimal, 7);
               PROGRAM_PROCESSING_FIELDS.CreateNewField(Names.PPF_CALC_REMAINDER, FieldType.PackedDecimal, 7);
               PROGRAM_PROCESSING_FIELDS.CreateNewField(Names.PPF_CALC_REMAINDER_4, FieldType.PackedDecimal, 7);
               PROGRAM_PROCESSING_FIELDS.CreateNewField(Names.PPF_CALC_REMAINDER_100, FieldType.PackedDecimal, 7);
               PROGRAM_PROCESSING_FIELDS.CreateNewField(Names.PPF_CALC_REMAINDER_400, FieldType.PackedDecimal, 7);
               PROGRAM_PROCESSING_FIELDS.CreateNewField(Names.LEAP_YEAR_SW, FieldType.String, 1, SPACES)
                   .NewCheckField(Names.LEAP_YEAR, "Y")
                   ;
               PROGRAM_PROCESSING_FIELDS.CreateNewField(Names.PPF_WORK_DAYS, FieldType.UnsignedNumeric, 3);
           });

            recordDef.CreateNewGroup(Names.PROGRAM_PROCESSING_CODES, (PROGRAM_PROCESSING_CODES) =>
           {
               IGroup PPC_MONTH_VALUES_local = (IGroup)PROGRAM_PROCESSING_CODES.CreateNewGroup(Names.PPC_MONTH_VALUES, (PPC_MONTH_VALUES) =>
               {
                   PPC_MONTH_VALUES.CreateNewField(Names.MONTH_1, FieldType.String, 5, "JAN31");
                   PPC_MONTH_VALUES.CreateNewField(Names.MONTH_2, FieldType.String, 5, "FEB28");
                   PPC_MONTH_VALUES.CreateNewField(Names.MONTH_3, FieldType.String, 5, "MAR31");
                   PPC_MONTH_VALUES.CreateNewField(Names.MONTH_4, FieldType.String, 5, "APR30");
                   PPC_MONTH_VALUES.CreateNewField(Names.MONTH_5, FieldType.String, 5, "MAY31");
                   PPC_MONTH_VALUES.CreateNewField(Names.MONTH_6, FieldType.String, 5, "JUN30");
                   PPC_MONTH_VALUES.CreateNewField(Names.MONTH_7, FieldType.String, 5, "JUL31");
                   PPC_MONTH_VALUES.CreateNewField(Names.MONTH_8, FieldType.String, 5, "AUG31");
                   PPC_MONTH_VALUES.CreateNewField(Names.MONTH_9, FieldType.String, 5, "SEP30");
                   PPC_MONTH_VALUES.CreateNewField(Names.MONTH_10, FieldType.String, 5, "OCT31");
                   PPC_MONTH_VALUES.CreateNewField(Names.MONTH_11, FieldType.String, 5, "NOV30");
                   PPC_MONTH_VALUES.CreateNewField(Names.MONTH_12, FieldType.String, 5, "DEC31");
               });
               PROGRAM_PROCESSING_CODES.CreateNewGroupRedefine(Names.PPC_DAY_ACC_TABLE_Redefines, PPC_MONTH_VALUES_local, (PPC_DAY_ACC_TABLE_Redefines) =>
               {
                   PPC_DAY_ACC_TABLE_Redefines.CreateNewGroupArray(Names.PPC_DAY_ACC_TABLE, 12, (PPC_DAY_ACC_TABLE) =>
                   {
                       PPC_DAY_ACC_TABLE.CreateNewField(Names.PPC_MONTH, FieldType.String, 3);
                       PPC_DAY_ACC_TABLE.CreateNewField(Names.PPC_DAYS_IN_MONTH, FieldType.UnsignedNumeric, 2);
                   });
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
    internal class SWEXGDAT_ls : PredefinedRecordBase
    {
        #region Name constants
        /// <summary>
        /// Name constants.
        /// </summary>
        internal static class Names
        {
            internal const string LinkageSection = "SWEXGDAT_ls_LinkageSection";
            internal const string LS_DATE_AREA = "LS_DATE_AREA";
        }
        #endregion

        #region Direct-access element properties
        public IField LS_DATE_AREA { get { return GetElementByName<IField>(Names.LS_DATE_AREA); } }

        #endregion

        #region Data structure definition
        /// <summary>
        /// Defines the entirety of the LinkageSection IRecord structure as described by the Ateras.Framework.Buffer API.
        /// </summary>
        /// <param name="recordDef">The IStructureDefinition object to be used in defining the record structure.</param>
        protected override void DefineRecordStructure(IStructureDefinition recordDef)
        {
            recordDef.CreateNewField(Names.LS_DATE_AREA, FieldType.String, 57);

        }

        protected override string GetRecordName()
        {
            return Names.LinkageSection;
        }
        #endregion

        public void SetPassedParameters(object[] args)
        {
            SetPassedParm(LS_DATE_AREA, args, 0);
        }


        public void UpdateReturnParameters(object[] args)
        {
            SetReturnParm(LS_DATE_AREA, args, 0);
        }
    }
    #endregion Linkage Section Class

    #region Business Logic Class
    public class SWEXGDAT : EABBase
    {

        #region Public Constructors
        public SWEXGDAT()
            : base()
        {
            this.ProgramName.SetValue("SWEXGDAT");

            WS = new SWEXGDAT_ws();
            LS = new SWEXGDAT_ls();
        }

        #endregion

        #region Private Fields


        //==== Working Storage Data Class ========================================
        private SWEXGDAT_ws WS;

        //==== Linkage Section Data Class ========================================
        private SWEXGDAT_ls LS;
        #endregion

        #region Public Methods
        //========================================================================
        //==== RunMain Entry Point Method ========================================
        //========================================================================
        public override int ExecuteMain(params object[] args)                                              //COBOL==> PROCEDURE DIVISION USING LS-DATE-AREA.
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
            M_0100_MAINLINE_PROCESS(returnMethod);
        }
        /// <summary>
        /// Method M_0100_MAINLINE_PROCESS
        /// </summary>
        private void M_0100_MAINLINE_PROCESS(string returnMethod = "")
        {
            WS.WS_DATE_AREA.SetValue(LS.LS_DATE_AREA);                                                          //COBOL==> MOVE LS-DATE-AREA TO WS-DATE-AREA.
            WS.WS_DATE_RETURN.SetValueWithZeroes();                                                             //COBOL==> MOVE ZEROS TO WS-DATE-RETURN.
            WS.WS_DATE_RETURN_CODE.SetValueWithSpaces();                                                        //COBOL==> MOVE SPACES TO WS-DATE-RETURN-CODE.
            M_1000_DATE_VALIDATION("M_1000_EXIT"); if (Control.ExitProgram) { return; }                           //COBOL==> PERFORM 1000-DATE-VALIDATION THRU 1000-EXIT.
            LS.LS_DATE_AREA.SetValue(WS.WS_DATE_AREA);                                                          //COBOL==> MOVE WS-DATE-AREA TO LS-DATE-AREA.
            Control.ExitProgram = true; return;                                                                 //COBOL==> GOBACK.
        }
        /// <summary>
        /// Method M_1000_DATE_VALIDATION
        /// </summary>
        private void M_1000_DATE_VALIDATION(string returnMethod = "")
        {
            if (WS.PPF_DATE_WORK.IsSpaces())                                                                    //COBOL==> IF PPF-DATE-WORK EQUAL SPACES
            {
                WS.WS_DATE_RETURN_CODE.SetValue("ND");                                                              //COBOL==> MOVE 'ND' TO WS-DATE-RETURN-CODE
                M_1000_EXIT(CheckGotoReturn(returnMethod)); return;                                                 //COBOL==> GO TO 1000-EXIT.
            }
            if (WS.PPF_DATE_WORK.IsEqualTo(0))                                                                  //COBOL==> IF PPF-DATE-WORK EQUAL ZEROS
            {
                WS.WS_DATE_RETURN_CODE.SetValue("ND");                                                              //COBOL==> MOVE 'ND' TO WS-DATE-RETURN-CODE
                M_1000_EXIT(CheckGotoReturn(returnMethod)); return;                                                 //COBOL==> GO TO 1000-EXIT.
            }
            if (!(WS.PPF_DATE_WORK.IsNumericValue()))                                                          //COBOL==> IF PPF-DATE-WORK NOT NUMERIC
            {
                WS.WS_DATE_RETURN_CODE.SetValue("NN");                                                              //COBOL==> MOVE 'NN' TO WS-DATE-RETURN-CODE
                M_1000_EXIT(CheckGotoReturn(returnMethod)); return;                                                 //COBOL==> GO TO 1000-EXIT.
            }
            if ((WS.PPF_WORK_CC.IsLessThan(18))
             || (WS.PPF_WORK_CC.IsGreaterThan(22)))          //COBOL==> IF PPF-WORK-CC < 18 OR > 22
            {
                WS.WS_DATE_RETURN_CODE.SetValue("BC");                                                              //COBOL==> MOVE 'BC' TO WS-DATE-RETURN-CODE
                M_1000_EXIT(CheckGotoReturn(returnMethod)); return;                                                 //COBOL==> GO TO 1000-EXIT.
            }
            if ((WS.PPF_WORK_MM.IsLessThan(1))
             || (WS.PPF_WORK_MM.IsGreaterThan(12)))           //COBOL==> IF PPF-WORK-MM < 1 OR > 12
            {
                WS.WS_DATE_RETURN_CODE.SetValue("BM");                                                              //COBOL==> MOVE 'BM' TO WS-DATE-RETURN-CODE
                M_1000_EXIT(CheckGotoReturn(returnMethod)); return;                                                 //COBOL==> GO TO 1000-EXIT.
            }
            if ((WS.PPF_WORK_DD.IsLessThan(1))
             || (WS.PPF_WORK_DD.IsGreaterThan(31)))           //COBOL==> IF PPF-WORK-DD < 1 OR > 31
            {
                WS.WS_DATE_RETURN_CODE.SetValue("BD");                                                              //COBOL==> MOVE 'BD' TO WS-DATE-RETURN-CODE
                M_1000_EXIT(CheckGotoReturn(returnMethod)); return;                                                 //COBOL==> GO TO 1000-EXIT.
            }
            if ((WS.PPF_WORK_MM.IsEqualTo("02"))
             && (WS.PPF_WORK_DD.IsEqualTo("29")))           //COBOL==> IF PPF-WORK-MM = '02' AND PPF-WORK-DD = '29'
            {
                M_1010_LEAP_YEAR_CALC("M_1010_EXIT"); if (Control.ExitProgram) { return; }                            //COBOL==> PERFORM 1010-LEAP-YEAR-CALC THRU 1010-EXIT
                if (WS.LEAP_YEAR.Value)                                                                             //COBOL==> IF LEAP-YEAR
                {
                    goto EndOfSentence_1;                                                                               //COBOL==> NEXT SENTENCE
                }                                                                                                   //COBOL==> ELSE
                else
                {
                    WS.PPF_WORK_DD.SetValue("28");                                                                      //COBOL==> MOVE '28' TO PPF-WORK-DD
                    WS.WS_DATE_RETURN_CODE.SetValue("CD");                                                              //COBOL==> MOVE 'CD' TO WS-DATE-RETURN-CODE
                }                                                                                                   //COBOL==> END-IF
            }                                                                                                   //COBOL==> ELSE
            else
            {
                WS.PPF_INDX.SetValue(WS.PPF_WORK_MM);                                                               //COBOL==> MOVE PPF-WORK-MM TO PPF-INDX
                if (WS.PPF_WORK_DD.IsGreaterThan(WS.PPC_DAYS_IN_MONTH[WS.PPF_INDX.AsInt()]))                        //COBOL==> IF PPF-WORK-DD > PPC-DAYS-IN-MONTH ( PPF-INDX )
                {
                    WS.PPF_WORK_DD.SetValue(WS.PPC_DAYS_IN_MONTH[WS.PPF_INDX.AsInt()]);                                 //COBOL==> MOVE PPC-DAYS-IN-MONTH ( PPF-INDX ) TO PPF-WORK-DD
                    WS.WS_DATE_RETURN_CODE.SetValue("CD");                                                              //COBOL==> MOVE 'CD' TO WS-DATE-RETURN-CODE
                }                                                                                                   //COBOL==> ELSE
                else
                {
                    goto EndOfSentence_1;                                                                               //COBOL==> NEXT SENTENCE
                }                                                                                                   //COBOL==> END-IF
            }                                                                                                   //COBOL==> END-IF.
        EndOfSentence_1:;
            WS.WS_DATE_RETURN.SetValue(WS.PPF_DATE_WORK);                                                       //COBOL==> MOVE PPF-DATE-WORK TO WS-DATE-RETURN.
            if (returnMethod != "" && returnMethod != "M_1000_DATE_VALIDATION") { M_1000_EXIT(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_1000_EXIT
        /// </summary>
        private void M_1000_EXIT(string returnMethod = "")
        {
            if (returnMethod == "M_1000_EXIT") { return; }                                                      //COBOL==> EXIT.
            if (returnMethod != "" && returnMethod != "M_1000_EXIT") { M_1010_LEAP_YEAR_CALC(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_1010_LEAP_YEAR_CALC
        /// </summary>
        private void M_1010_LEAP_YEAR_CALC(string returnMethod = "")
        {
            //COMMENT:  ANY YYYY DIVISABLE BY 4 AND 400 IS A LEAP YEAR
            //COMMENT:           OR
            //COMMENT:  ANY YYYY DIVISABLE BY 4 AND NOT 100 IS A LEAP YEAR
            WS.PPF_CALC_L_YRS.SetValue(WS.PPF_WORK_YYYY.AsDecimal() / 4m);                                      //COBOL==> DIVIDE PPF-WORK-YYYY BY 4 GIVING PPF-CALC-L-YRS REMAINDER PPF-CALC-REMAINDER-4.
            WS.PPF_CALC_REMAINDER_4.SetValue(WS.PPF_WORK_YYYY.AsDecimal() % 4m);
            if (WS.PPF_CALC_REMAINDER_4.IsEqualTo(0))                                                           //COBOL==> IF PPF-CALC-REMAINDER-4 = ZEROS
            {
                WS.PPF_CALC_L_YRS.SetValue(WS.PPF_WORK_YYYY.AsDecimal() / 100m);                                    //COBOL==> DIVIDE PPF-WORK-YYYY BY 100 GIVING PPF-CALC-L-YRS REMAINDER PPF-CALC-REMAINDER-100
                WS.PPF_CALC_REMAINDER_100.SetValue(WS.PPF_WORK_YYYY.AsDecimal() % 100m);
                WS.PPF_CALC_L_YRS.SetValue(WS.PPF_WORK_YYYY.AsDecimal() / 400m);                                    //COBOL==> DIVIDE PPF-WORK-YYYY BY 400 GIVING PPF-CALC-L-YRS REMAINDER PPF-CALC-REMAINDER-400
                WS.PPF_CALC_REMAINDER_400.SetValue(WS.PPF_WORK_YYYY.AsDecimal() % 400m);
                if ((WS.PPF_CALC_REMAINDER_400.IsEqualTo(0))
             || (!(WS.PPF_CALC_REMAINDER_100.IsEqualTo(0))))  //COBOL==> IF PPF-CALC-REMAINDER-400 = ZEROS OR PPF-CALC-REMAINDER-100 NOT = ZEROS
                {
                    WS.LEAP_YEAR_SW.SetValue("Y");                                                                      //COBOL==> MOVE 'Y' TO LEAP-YEAR-SW
                }                                                                                                   //COBOL==> END-IF
            }                                                                                                   //COBOL==> END-IF.
            if (WS.LEAP_YEAR.Value)                                                                             //COBOL==> IF LEAP-YEAR
            {
                WS.PPF_CALC_REMAINDER.SetValue(ZEROES);                                                             //COBOL==> MOVE ZEROES TO PPF-CALC-REMAINDER
            }                                                                                                   //COBOL==> ELSE
            else
            {
                WS.PPF_CALC_REMAINDER.SetValue(1);                                                                  //COBOL==> MOVE 1 TO PPF-CALC-REMAINDER
            }                                                                                                   //COBOL==> END-IF.
            if (returnMethod != "" && returnMethod != "M_1010_LEAP_YEAR_CALC") { M_1010_EXIT(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_1010_EXIT
        /// </summary>
        private void M_1010_EXIT(string returnMethod = "")
        {
            if (returnMethod == "M_1010_EXIT") { return; }                                                      //COBOL==> EXIT.
        }
        #endregion
    }
    #endregion
}
