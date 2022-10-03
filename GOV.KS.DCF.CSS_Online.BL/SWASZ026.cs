#region Comments
/* Conversion Comments
   ************************************************************
   **   MODERN SYSTEMS INC.  COPYRIGHT 2000-2022
   **   DB-SHUTTLE COBOL to C# Conversion
   ************************************************************
   ** INIT   *  INITIAL VERSION   *  2022-01-14 12:46:12 PM
   **        *   FROM COBOL PGM   :  SWASZ026
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
    internal class SWASZ026_ws : PredefinedRecordBase
    {
        #region Name constants
        /// <summary>
        /// Name constants.
        /// </summary>
        internal static class Names
        {
            internal const string WorkingStorage = "SWASZ026_ws_WorkingStorage";
            internal const string MODULE_VARIABLES = "MODULE_VARIABLES";
            internal const string MV_LEADING_ZERO = "MV_LEADING_ZERO";
            internal const string MV_SIGN_FOUND = "MV_SIGN_FOUND";
            internal const string MV_NUMBER_IS_ZERO = "MV_NUMBER_IS_ZERO";
            internal const string MV_DECIMAL_PT = "MV_DECIMAL_PT";
            internal const string MV_CENTS = "MV_CENTS";
            internal const string MV_WORK_LEN = "MV_WORK_LEN";
            internal const string MV_ALIGN_SS = "MV_ALIGN_SS";
            internal const string MV_SIGN_IND = "MV_SIGN_IND";
            internal const string MV_WORK_AREA = "MV_WORK_AREA";
            internal const string MV_WORK_DIGIT = "MV_WORK_DIGIT";
            internal const string MV_ALIGN_AREA = "MV_ALIGN_AREA";
            internal const string MV_ALIGN_DIGIT = "MV_ALIGN_DIGIT";
            internal const string MV_WORK_NDX = "MV_WORK_NDX";
            internal const string MV_ALIGN_NDX = "MV_ALIGN_NDX";
            internal const string PV_SCREEN_NDX = "PV_SCREEN_NDX";
            internal const string PV_DB_NDX = "PV_DB_NDX";
        }
        #endregion

        #region Direct-access element properties
        public IGroup MODULE_VARIABLES { get { return GetElementByName<IGroup>(Names.MODULE_VARIABLES); } }
        public IField MV_LEADING_ZERO { get { return GetElementByName<IField>(Names.MV_LEADING_ZERO); } }
        public IField MV_SIGN_FOUND { get { return GetElementByName<IField>(Names.MV_SIGN_FOUND); } }
        public IField MV_NUMBER_IS_ZERO { get { return GetElementByName<IField>(Names.MV_NUMBER_IS_ZERO); } }
        public IField MV_DECIMAL_PT { get { return GetElementByName<IField>(Names.MV_DECIMAL_PT); } }
        public IField MV_CENTS { get { return GetElementByName<IField>(Names.MV_CENTS); } }
        public IField MV_WORK_LEN { get { return GetElementByName<IField>(Names.MV_WORK_LEN); } }
        public IField MV_ALIGN_SS { get { return GetElementByName<IField>(Names.MV_ALIGN_SS); } }
        public IField MV_SIGN_IND { get { return GetElementByName<IField>(Names.MV_SIGN_IND); } }
        public IGroup MV_WORK_AREA { get { return GetElementByName<IGroup>(Names.MV_WORK_AREA); } }
        public IArrayElementAccessor<IField> MV_WORK_DIGIT { get { return GetArrayElementAccessor<IField>(Names.MV_WORK_DIGIT); } }
        public IGroup MV_ALIGN_AREA { get { return GetElementByName<IGroup>(Names.MV_ALIGN_AREA); } }
        public IArrayElementAccessor<IField> MV_ALIGN_DIGIT { get { return GetArrayElementAccessor<IField>(Names.MV_ALIGN_DIGIT); } }
        public IField MV_WORK_NDX { get { return GetElementByName<IField>(Names.MV_WORK_NDX); } }
        public IField MV_ALIGN_NDX { get { return GetElementByName<IField>(Names.MV_ALIGN_NDX); } }
        public IField PV_SCREEN_NDX { get { return GetElementByName<IField>(Names.PV_SCREEN_NDX); } }
        public IField PV_DB_NDX { get { return GetElementByName<IField>(Names.PV_DB_NDX); } }

        #endregion

        #region Data structure definition
        /// <summary>
        /// Defines the entirety of the WorkingStorage IRecord structure as described by the Ateras.Framework.Buffer API.
        /// </summary>
        /// <param name="recordDef">The IStructureDefinition object to be used in defining the record structure.</param>
        protected override void DefineRecordStructure(IStructureDefinition recordDef)
        {

            recordDef.CreateNewGroup(Names.MODULE_VARIABLES, (MODULE_VARIABLES) =>
           {
               MODULE_VARIABLES.CreateNewField(Names.MV_LEADING_ZERO, FieldType.String, 1);
               MODULE_VARIABLES.CreateNewField(Names.MV_SIGN_FOUND, FieldType.String, 1);
               MODULE_VARIABLES.CreateNewField(Names.MV_NUMBER_IS_ZERO, FieldType.String, 1);
               MODULE_VARIABLES.CreateNewField(Names.MV_DECIMAL_PT, FieldType.CompShort, 2);
               MODULE_VARIABLES.CreateNewField(Names.MV_CENTS, FieldType.CompShort, 2);
               MODULE_VARIABLES.CreateNewField(Names.MV_WORK_LEN, FieldType.CompShort, 2);
               MODULE_VARIABLES.CreateNewField(Names.MV_ALIGN_SS, FieldType.CompShort, 2);
               MODULE_VARIABLES.CreateNewField(Names.MV_SIGN_IND, FieldType.CompShort, 2);
               MODULE_VARIABLES.CreateNewGroup(Names.MV_WORK_AREA, (MV_WORK_AREA) =>
               {
                   MV_WORK_AREA.CreateNewFieldArray(Names.MV_WORK_DIGIT, 15, FieldType.SignedNumeric, 1);
               });
               MODULE_VARIABLES.CreateNewGroup(Names.MV_ALIGN_AREA, (MV_ALIGN_AREA) =>
               {
                   MV_ALIGN_AREA.CreateNewFieldArray(Names.MV_ALIGN_DIGIT, 15, FieldType.SignedNumeric, 1);
               });
           });
            recordDef.CreateNewField(Names.MV_WORK_NDX, FieldType.CompShort, 4);
            recordDef.CreateNewField(Names.MV_ALIGN_NDX, FieldType.CompShort, 4);
            recordDef.CreateNewField(Names.PV_SCREEN_NDX, FieldType.CompShort, 4);
            recordDef.CreateNewField(Names.PV_DB_NDX, FieldType.CompShort, 4);

        }

        protected override string GetRecordName()
        {
            return Names.WorkingStorage;
        }
        #endregion

    }
    #endregion Working Storage Class

    #region Linkage Section Class
    internal class SWASZ026_ls : PredefinedRecordBase
    {
        #region Name constants
        /// <summary>
        /// Name constants.
        /// </summary>
        internal static class Names
        {
            internal const string LinkageSection = "SWASZ026_ls_LinkageSection";
            internal const string PV_SCREEN_NUMBER = "PV_SCREEN_NUMBER";
            internal const string PV_SCREEN_DIGIT = "PV_SCREEN_DIGIT";
            internal const string PV_LENGTH = "PV_LENGTH";
            internal const string PV_DB_NUMBER = "PV_DB_NUMBER";
            internal const string PV_DB_DIGIT = "PV_DB_DIGIT";
            internal const string PV_DB_DIGIT_ALPHA = "PV_DB_DIGIT_ALPHA";
            internal const string PV_ERROR_FLAG = "PV_ERROR_FLAG";
        }
        #endregion

        #region Direct-access element properties
        public IGroup PV_SCREEN_NUMBER { get { return GetElementByName<IGroup>(Names.PV_SCREEN_NUMBER); } }
        public IArrayElementAccessor<IField> PV_SCREEN_DIGIT { get { return GetArrayElementAccessor<IField>(Names.PV_SCREEN_DIGIT); } }
        public IField PV_LENGTH { get { return GetElementByName<IField>(Names.PV_LENGTH); } }
        public IGroup PV_DB_NUMBER { get { return GetElementByName<IGroup>(Names.PV_DB_NUMBER); } }
        public IArrayElementAccessor<IField> PV_DB_DIGIT { get { return GetArrayElementAccessor<IField>(Names.PV_DB_DIGIT); } }
        public IArrayElementAccessor<IField> PV_DB_DIGIT_ALPHA { get { return GetArrayElementAccessor<IField>(Names.PV_DB_DIGIT_ALPHA); } }
        public IField PV_ERROR_FLAG { get { return GetElementByName<IField>(Names.PV_ERROR_FLAG); } }

        #endregion

        #region Data structure definition
        /// <summary>
        /// Defines the entirety of the LinkageSection IRecord structure as described by the Ateras.Framework.Buffer API.
        /// </summary>
        /// <param name="recordDef">The IStructureDefinition object to be used in defining the record structure.</param>
        protected override void DefineRecordStructure(IStructureDefinition recordDef)
        {

            recordDef.CreateNewGroup(Names.PV_SCREEN_NUMBER, (PV_SCREEN_NUMBER) =>
           {
               PV_SCREEN_NUMBER.CreateNewFieldArray(Names.PV_SCREEN_DIGIT, 15, FieldType.String, 1);
           });
            recordDef.CreateNewField(Names.PV_LENGTH, FieldType.CompShort, 2);

            IGroup PV_DB_NUMBER_local = (IGroup)recordDef.CreateNewGroup(Names.PV_DB_NUMBER, (PV_DB_NUMBER) =>
           {
               PV_DB_NUMBER.CreateNewFieldArray(Names.PV_DB_DIGIT, 15, FieldType.SignedNumeric, 1);
           });
            recordDef.CreateNewGroupRedefine("FILLER", PV_DB_NUMBER_local, (FILLER) =>
            {
                FILLER.CreateNewFieldArray(Names.PV_DB_DIGIT_ALPHA, 15, FieldType.String, 1);
            });
            recordDef.CreateNewField(Names.PV_ERROR_FLAG, FieldType.String, 1);

        }

        protected override string GetRecordName()
        {
            return Names.LinkageSection;
        }
        #endregion

        public void SetPassedParameters(object[] args)
        {
            SetPassedParm(PV_SCREEN_NUMBER, args, 0);
            SetPassedParm(PV_LENGTH, args, 1);
            SetPassedParm(PV_DB_NUMBER, args, 2);
            SetPassedParm(PV_ERROR_FLAG, args, 3);
        }


        public void UpdateReturnParameters(object[] args)
        {
            SetReturnParm(PV_SCREEN_NUMBER, args, 0);
            SetReturnParm(PV_LENGTH, args, 1);
            SetReturnParm(PV_DB_NUMBER, args, 2);
            SetReturnParm(PV_ERROR_FLAG, args, 3);
        }
    }
    #endregion Linkage Section Class

    #region Business Logic Class
    public class SWASZ026 : BatchBase
    {

        #region Public Constructors
        public SWASZ026()
            : base()
        {
            this.ProgramName.SetValue("SWASZ026");

            WS = new SWASZ026_ws();
            LS = new SWASZ026_ls();
        }

        #endregion

        #region Private Fields


        //==== Working Storage Data Class ========================================
        private SWASZ026_ws WS;

        //==== Linkage Section Data Class ========================================
        private SWASZ026_ls LS;
        #endregion

        #region Public Methods
        //========================================================================
        //==== RunMain Entry Point Method ========================================
        //========================================================================
        public override int ExecuteMain(params object[] args)                                              //COBOL==> PROCEDURE DIVISION USING PV-SCREEN-NUMBER PV-LENGTH PV-DB-NUMBER PV-ERROR-FLAG.
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
            M_0000_MAIN_LOGIC(returnMethod);
        }
        /// <summary>
        /// Method M_0000_MAIN_LOGIC
        /// </summary>
        private void M_0000_MAIN_LOGIC(string returnMethod = "")
        {
            LS.PV_ERROR_FLAG.SetValue("N");                                                                     //COBOL==> MOVE 'N' TO PV-ERROR-FLAG.
            WS.MV_LEADING_ZERO.SetValue("Y");                                                                   //COBOL==> MOVE 'Y' TO MV-LEADING-ZERO.
            WS.MV_SIGN_FOUND.SetValue("N");                                                                     //COBOL==> MOVE 'N' TO MV-SIGN-FOUND.
            WS.MV_NUMBER_IS_ZERO.SetValue("Y");                                                                 //COBOL==> MOVE 'Y' TO MV-NUMBER-IS-ZERO.
            WS.MV_DECIMAL_PT.SetValue(-1);                                                                      //COBOL==> MOVE -1 TO MV-DECIMAL-PT.
            WS.MV_WORK_LEN.SetValue(+0);                                                                        //COBOL==> MOVE +0 TO MV-WORK-LEN.
            WS.MV_WORK_AREA.SetValueWithZeroes();                                                               //COBOL==> MOVE ZEROS TO MV-WORK-AREA.
            WS.MV_ALIGN_AREA.SetValueWithZeroes();                                                              //COBOL==> MOVE ZEROS TO MV-ALIGN-AREA.
            for (WS.PV_SCREEN_NDX.SetValue(1); (!((WS.PV_SCREEN_NDX.IsGreaterThan(LS.PV_LENGTH)) || (LS.PV_ERROR_FLAG.IsEqualTo("Y")))); WS.PV_SCREEN_NDX.Add(1))  //COBOL==> PERFORM 1000-SCAN-INPUT THRU 1000-EXIT VARYING PV-SCREEN-NDX FROM 1 BY 1 UNTIL PV-SCREEN-NDX > PV-LENGTH OR PV-ERROR-FLAG = 'Y'.
            {
                M_1000_SCAN_INPUT("M_1000_EXIT"); if (Control.ExitProgram) { return; }
            }
            if (LS.PV_ERROR_FLAG.IsEqualTo("Y"))                                                                //COBOL==> IF PV-ERROR-FLAG = 'Y'
            {
                M_0000_EXIT(CheckGotoReturn(returnMethod)); return;                                                 //COBOL==> GO TO 0000-EXIT.
            }
            if (WS.MV_DECIMAL_PT.IsLessThan(ZEROS))                                                             //COBOL==> IF MV-DECIMAL-PT < ZERO
            {
                WS.MV_DECIMAL_PT.SetValue(WS.MV_WORK_LEN);                                                          //COBOL==> MOVE MV-WORK-LEN TO MV-DECIMAL-PT.
            }
            WS.MV_ALIGN_SS.SetComputeValue((LS.PV_LENGTH.AsDecimal() - WS.MV_DECIMAL_PT.AsDecimal()) - 1m);     //COBOL==> COMPUTE MV-ALIGN-SS = PV-LENGTH - MV-DECIMAL-PT - 1.
            WS.MV_SIGN_IND.SetComputeValue(WS.MV_ALIGN_SS.AsDecimal() - 2m);                                    //COBOL==> COMPUTE MV-SIGN-IND = MV-ALIGN-SS - 2.
            if (WS.MV_SIGN_IND.IsGreaterThan(ZEROS))                                                            //COBOL==> IF MV-SIGN-IND > ZERO
            {
                goto EndOfSentence_1;                                                                               //COBOL==> NEXT SENTENCE
            }                                                                                                   //COBOL==> ELSE
            else
            {
                LS.PV_ERROR_FLAG.SetValue("Y");                                                                     //COBOL==> MOVE 'Y' TO PV-ERROR-FLAG
                M_0000_EXIT(CheckGotoReturn(returnMethod)); return;                                                 //COBOL==> GO TO 0000-EXIT.
            }
        EndOfSentence_1:;
            WS.MV_CENTS.SetComputeValue(WS.MV_WORK_LEN.AsDecimal() - WS.MV_DECIMAL_PT.AsDecimal());             //COBOL==> COMPUTE MV-CENTS = MV-WORK-LEN - MV-DECIMAL-PT.
            if (WS.MV_CENTS.IsGreaterThan(2))                                                                   //COBOL==> IF MV-CENTS > 2
            {
                LS.PV_ERROR_FLAG.SetValue("Y");                                                                     //COBOL==> MOVE 'Y' TO PV-ERROR-FLAG
                M_0000_EXIT(CheckGotoReturn(returnMethod)); return;                                                 //COBOL==> GO TO 0000-EXIT.
            }
            for (WS.MV_WORK_NDX.SetValue(1); (!(WS.MV_WORK_NDX.IsGreaterThan(WS.MV_WORK_LEN))); WS.MV_WORK_NDX.Add(1))  //COBOL==> PERFORM 2000-ALIGN-DECIMAL THRU 2000-EXIT VARYING MV-WORK-NDX FROM 1 BY 1 UNTIL MV-WORK-NDX > MV-WORK-LEN.
            {
                M_2000_ALIGN_DECIMAL("M_2000_EXIT"); if (Control.ExitProgram) { return; }
            }
            WS.MV_WORK_LEN.SetValue(LS.PV_LENGTH);                                                              //COBOL==> MOVE PV-LENGTH TO MV-WORK-LEN.
            WS.MV_ALIGN_NDX.SetValue(1);                                                                        //COBOL==> SET MV-ALIGN-NDX TO 1.
            for (WS.PV_DB_NDX.SetValue(1); (!(WS.PV_DB_NDX.IsGreaterThan(WS.MV_WORK_LEN))); WS.PV_DB_NDX.Add(1))  //COBOL==> PERFORM 3000-FILL-OUTPUT THRU 3000-EXIT VARYING PV-DB-NDX FROM 1 BY 1 UNTIL PV-DB-NDX > MV-WORK-LEN.
            {
                M_3000_FILL_OUTPUT("M_3000_EXIT"); if (Control.ExitProgram) { return; }
            }
            if (WS.MV_SIGN_FOUND.IsEqualTo("Y"))                                                                //COBOL==> IF MV-SIGN-FOUND = 'Y'
            {
                WS.PV_DB_NDX.SetValue(LS.PV_LENGTH);                                                                //COBOL==> SET PV-DB-NDX TO PV-LENGTH
                if (LS.PV_DB_DIGIT[WS.PV_DB_NDX].IsGreaterThan(ZEROS))                                              //COBOL==> IF PV-DB-DIGIT ( PV-DB-NDX ) > ZERO
                {
                    LS.PV_DB_DIGIT[WS.PV_DB_NDX].SetValue(LS.PV_DB_DIGIT[WS.PV_DB_NDX.AsInt()].AsInt() * -1);           //COBOL==> MULTIPLY PV-DB-DIGIT ( PV-DB-NDX ) BY -1 GIVING PV-DB-DIGIT ( PV-DB-NDX )
                }                                                                                                   //COBOL==> ELSE
                else
                {
                    //COMMENT:              AT THIS POINT, THE LAST DIGIT = '0'
                    if (WS.MV_NUMBER_IS_ZERO.IsEqualTo("N"))                                                            //COBOL==> IF MV-NUMBER-IS-ZERO = 'N'
                    {
                        //COMMENT:                  IF NUMBER IS GREATER THAN ZERO THEN FORCE
                        //COMMENT:                  A SIGN ON THE LAST ZERO DIGIT
                        LS.PV_DB_DIGIT_ALPHA[WS.PV_DB_NDX.AsInt()].SetValue("}");                                           //COBOL==> MOVE '}' TO PV-DB-DIGIT-ALPHA ( PV-DB-NDX ) .
                    }
                }
            }
            if (returnMethod != "" && returnMethod != "M_0000_MAIN_LOGIC") { M_0000_EXIT(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_0000_EXIT
        /// </summary>
        private void M_0000_EXIT(string returnMethod = "")
        {
            Control.ExitProgram = true; return;                                                                 //COBOL==> GOBACK.
        }
        /// <summary>
        /// Method M_1000_SCAN_INPUT
        /// </summary>
        private void M_1000_SCAN_INPUT(string returnMethod = "")
        {
            if (WS.MV_LEADING_ZERO.IsEqualTo("Y"))                                                              //COBOL==> IF MV-LEADING-ZERO = 'Y'
            {
                if (((LS.PV_SCREEN_DIGIT[WS.PV_SCREEN_NDX.AsInt()].IsEqualTo("0"))
             || (LS.PV_SCREEN_DIGIT[WS.PV_SCREEN_NDX.AsInt()].IsEqualTo(" ")))
             || (LS.PV_SCREEN_DIGIT[WS.PV_SCREEN_NDX.AsInt()].IsEqualTo(LOW_VALUES)))  //COBOL==> IF PV-SCREEN-DIGIT ( PV-SCREEN-NDX ) = '0' OR ' ' OR LOW-VALUE
                {
                    M_1000_EXIT(CheckGotoReturn(returnMethod)); return;                                                 //COBOL==> GO TO 1000-EXIT
                }                                                                                                   //COBOL==> ELSE
                else
                {
                    if (LS.PV_SCREEN_DIGIT[WS.PV_SCREEN_NDX.AsInt()].IsEqualTo("-"))                                    //COBOL==> IF PV-SCREEN-DIGIT ( PV-SCREEN-NDX ) = '-'
                    {
                        WS.MV_SIGN_FOUND.SetValue("Y");                                                                     //COBOL==> MOVE 'Y' TO MV-SIGN-FOUND
                        M_1000_EXIT(CheckGotoReturn(returnMethod)); return;                                                 //COBOL==> GO TO 1000-EXIT.
                    }
                }
            }
            WS.MV_LEADING_ZERO.SetValue("N");                                                                   //COBOL==> MOVE 'N' TO MV-LEADING-ZERO.
            if ((LS.PV_SCREEN_DIGIT[WS.PV_SCREEN_NDX.AsInt()].IsSpaces())
             || (LS.PV_SCREEN_DIGIT[WS.PV_SCREEN_NDX.AsInt()].IsEqualTo(LOW_VALUES)))  //COBOL==> IF PV-SCREEN-DIGIT ( PV-SCREEN-NDX ) = SPACE OR LOW-VALUE
            {
                goto EndOfSentence_2;                                                                               //COBOL==> NEXT SENTENCE
            }                                                                                                   //COBOL==> ELSE
            else
            {
                if (LS.PV_SCREEN_DIGIT[WS.PV_SCREEN_NDX.AsInt()].IsEqualTo("."))                                    //COBOL==> IF PV-SCREEN-DIGIT ( PV-SCREEN-NDX ) = '.'
                {
                    if (WS.MV_DECIMAL_PT.IsLessThan(ZEROS))                                                             //COBOL==> IF MV-DECIMAL-PT < ZERO
                    {
                        WS.MV_DECIMAL_PT.SetValue(WS.MV_WORK_LEN);                                                          //COBOL==> MOVE MV-WORK-LEN TO MV-DECIMAL-PT
                    }                                                                                                   //COBOL==> ELSE
                    else
                    {
                        LS.PV_ERROR_FLAG.SetValue("Y");                                                                     //COBOL==> MOVE 'Y' TO PV-ERROR-FLAG
                    }                                                                                                   //COBOL==> ELSE
                }
                else
                {
                    if ((LS.PV_SCREEN_DIGIT[WS.PV_SCREEN_NDX.AsInt()].IsLessThan("0"))
             || (LS.PV_SCREEN_DIGIT[WS.PV_SCREEN_NDX.AsInt()].IsGreaterThan("9")))  //COBOL==> IF PV-SCREEN-DIGIT ( PV-SCREEN-NDX ) < '0' OR > '9'
                    {
                        LS.PV_ERROR_FLAG.SetValue("Y");                                                                     //COBOL==> MOVE 'Y' TO PV-ERROR-FLAG
                    }                                                                                                   //COBOL==> ELSE
                    else
                    {
                        WS.MV_WORK_LEN.Add(1);                                                                              //COBOL==> ADD 1 TO MV-WORK-LEN
                        WS.MV_WORK_DIGIT[WS.MV_WORK_LEN.AsInt()].SetValue(LS.PV_SCREEN_DIGIT[WS.PV_SCREEN_NDX.AsInt()]);    //COBOL==> MOVE PV-SCREEN-DIGIT ( PV-SCREEN-NDX ) TO MV-WORK-DIGIT ( MV-WORK-LEN ) .
                    }
                }
            }
        EndOfSentence_2:;
            if (LS.PV_SCREEN_DIGIT[WS.PV_SCREEN_NDX.AsInt()].IsGreaterThan("0"))                                //COBOL==> IF PV-SCREEN-DIGIT ( PV-SCREEN-NDX ) > '0'
            {
                WS.MV_NUMBER_IS_ZERO.SetValue("N");                                                                 //COBOL==> MOVE 'N' TO MV-NUMBER-IS-ZERO.
            }
            if (returnMethod != "" && returnMethod != "M_1000_SCAN_INPUT") { M_1000_EXIT(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_1000_EXIT
        /// </summary>
        private void M_1000_EXIT(string returnMethod = "")
        {
            if (returnMethod != "" && returnMethod != "M_1000_EXIT") { M_2000_ALIGN_DECIMAL(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_2000_ALIGN_DECIMAL
        /// </summary>
        private void M_2000_ALIGN_DECIMAL(string returnMethod = "")
        {
            WS.MV_ALIGN_DIGIT[WS.MV_ALIGN_SS.AsInt()].SetValue(WS.MV_WORK_DIGIT[WS.MV_WORK_NDX.AsInt()]);       //COBOL==> MOVE MV-WORK-DIGIT ( MV-WORK-NDX ) TO MV-ALIGN-DIGIT ( MV-ALIGN-SS ) .
            WS.MV_ALIGN_SS.Add(1);                                                                              //COBOL==> ADD 1 TO MV-ALIGN-SS.
            if (returnMethod != "" && returnMethod != "M_2000_ALIGN_DECIMAL") { M_2000_EXIT(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_2000_EXIT
        /// </summary>
        private void M_2000_EXIT(string returnMethod = "")
        {
            if (returnMethod != "" && returnMethod != "M_2000_EXIT") { M_3000_FILL_OUTPUT(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_3000_FILL_OUTPUT
        /// </summary>
        private void M_3000_FILL_OUTPUT(string returnMethod = "")
        {
            LS.PV_DB_DIGIT[WS.PV_DB_NDX.AsInt()].SetValue(WS.MV_ALIGN_DIGIT[WS.MV_ALIGN_NDX.AsInt()]);          //COBOL==> MOVE MV-ALIGN-DIGIT ( MV-ALIGN-NDX ) TO PV-DB-DIGIT ( PV-DB-NDX ) .
            WS.MV_ALIGN_NDX.Add(1);                                                                             //COBOL==> SET MV-ALIGN-NDX UP BY 1.
            if (returnMethod != "" && returnMethod != "M_3000_FILL_OUTPUT") { M_3000_EXIT(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_3000_EXIT
        /// </summary>
        private void M_3000_EXIT(string returnMethod = "")
        {
        }
        #endregion
    }
    #endregion
}
