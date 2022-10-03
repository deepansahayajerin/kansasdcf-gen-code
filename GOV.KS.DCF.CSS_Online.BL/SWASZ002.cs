#region Comments
/* Conversion Comments
   ************************************************************
   **   MODERN SYSTEMS INC.  COPYRIGHT 2000-2022
   **   DB-SHUTTLE COBOL to C# Conversion
   ************************************************************
   ** INIT   *  INITIAL VERSION   *  2022-01-14 12:46:03 PM
   **        *   FROM COBOL PGM   :  SWASZ002
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
    internal class SWASZ002_ws : PredefinedRecordBase
    {
        #region Name constants
        /// <summary>
        /// Name constants.
        /// </summary>
        internal static class Names
        {
            internal const string WorkingStorage = "SWASZ002_ws_WorkingStorage";
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
    internal class SWASZ002_ls : PredefinedRecordBase
    {
        #region Name constants
        /// <summary>
        /// Name constants.
        /// </summary>
        internal static class Names
        {
            internal const string LinkageSection = "SWASZ002_ls_LinkageSection";
            internal const string PV_SCREEN_IN = "PV_SCREEN_IN";
            internal const string PV_SCREEN_DATE = "PV_SCREEN_DATE";
            internal const string PV_SCREEN_MONTH = "PV_SCREEN_MONTH";
            internal const string PV_SCREEN_DAY = "PV_SCREEN_DAY";
            internal const string PV_SCREEN_YEAR = "PV_SCREEN_YEAR";
            internal const string PV_SCREEN_YY = "PV_SCREEN_YY";
            internal const string PV_SCREEN_Y1 = "PV_SCREEN_Y1";
            internal const string PV_SCREEN_Y2 = "PV_SCREEN_Y2";
            internal const string PV_SCREEN_DATE_N = "PV_SCREEN_DATE_N";
            internal const string PV_DB_DATE = "PV_DB_DATE";
            internal const string PV_DB_CENTURY = "PV_DB_CENTURY";
            internal const string PV_DB_YEAR = "PV_DB_YEAR";
            internal const string PV_DB_MONTH = "PV_DB_MONTH";
            internal const string PV_DB_DAY = "PV_DB_DAY";
            internal const string PV_ERROR_FLAG = "PV_ERROR_FLAG";
        }
        #endregion

        #region Direct-access element properties
        public IField PV_SCREEN_IN { get { return GetElementByName<IField>(Names.PV_SCREEN_IN); } }
        public IGroup PV_SCREEN_DATE { get { return GetElementByName<IGroup>(Names.PV_SCREEN_DATE); } }
        public IField PV_SCREEN_MONTH { get { return GetElementByName<IField>(Names.PV_SCREEN_MONTH); } }
        public IField PV_SCREEN_DAY { get { return GetElementByName<IField>(Names.PV_SCREEN_DAY); } }
        public IField PV_SCREEN_YEAR { get { return GetElementByName<IField>(Names.PV_SCREEN_YEAR); } }
        public IGroup PV_SCREEN_YY { get { return GetElementByName<IGroup>(Names.PV_SCREEN_YY); } }
        public IField PV_SCREEN_Y1 { get { return GetElementByName<IField>(Names.PV_SCREEN_Y1); } }
        public IField PV_SCREEN_Y2 { get { return GetElementByName<IField>(Names.PV_SCREEN_Y2); } }
        public IField PV_SCREEN_DATE_N { get { return GetElementByName<IField>(Names.PV_SCREEN_DATE_N); } }
        public IGroup PV_DB_DATE { get { return GetElementByName<IGroup>(Names.PV_DB_DATE); } }
        public IField PV_DB_CENTURY { get { return GetElementByName<IField>(Names.PV_DB_CENTURY); } }
        public IField PV_DB_YEAR { get { return GetElementByName<IField>(Names.PV_DB_YEAR); } }
        public IField PV_DB_MONTH { get { return GetElementByName<IField>(Names.PV_DB_MONTH); } }
        public IField PV_DB_DAY { get { return GetElementByName<IField>(Names.PV_DB_DAY); } }
        public IField PV_ERROR_FLAG { get { return GetElementByName<IField>(Names.PV_ERROR_FLAG); } }

        #endregion

        #region Data structure definition
        /// <summary>
        /// Defines the entirety of the LinkageSection IRecord structure as described by the Ateras.Framework.Buffer API.
        /// </summary>
        /// <param name="recordDef">The IStructureDefinition object to be used in defining the record structure.</param>
        protected override void DefineRecordStructure(IStructureDefinition recordDef)
        {

            IField PV_SCREEN_IN_local = recordDef.CreateNewField(Names.PV_SCREEN_IN, FieldType.String, 6);
            IGroup PV_SCREEN_DATE_local = (IGroup)recordDef.CreateNewGroupRedefine(Names.PV_SCREEN_DATE, PV_SCREEN_IN_local, (PV_SCREEN_DATE) =>
            {
                PV_SCREEN_DATE.CreateNewField(Names.PV_SCREEN_MONTH, FieldType.UnsignedNumeric, 2);
                PV_SCREEN_DATE.CreateNewField(Names.PV_SCREEN_DAY, FieldType.UnsignedNumeric, 2);

                IField PV_SCREEN_YEAR_local = PV_SCREEN_DATE.CreateNewField(Names.PV_SCREEN_YEAR, FieldType.UnsignedNumeric, 2);
                PV_SCREEN_DATE.CreateNewGroupRedefine(Names.PV_SCREEN_YY, PV_SCREEN_YEAR_local, (PV_SCREEN_YY) =>
                {
                    PV_SCREEN_YY.CreateNewField(Names.PV_SCREEN_Y1, FieldType.UnsignedNumeric, 1);
                    PV_SCREEN_YY.CreateNewField(Names.PV_SCREEN_Y2, FieldType.UnsignedNumeric, 1);
                });
            });
            recordDef.CreateNewFieldRedefine(Names.PV_SCREEN_DATE_N, FieldType.UnsignedNumeric, PV_SCREEN_DATE_local, 6);

            recordDef.CreateNewGroup(Names.PV_DB_DATE, (PV_DB_DATE) =>
           {
               PV_DB_DATE.CreateNewField(Names.PV_DB_CENTURY, FieldType.UnsignedNumeric, 2);
               PV_DB_DATE.CreateNewField(Names.PV_DB_YEAR, FieldType.UnsignedNumeric, 2);
               PV_DB_DATE.CreateNewField(Names.PV_DB_MONTH, FieldType.UnsignedNumeric, 2);
               PV_DB_DATE.CreateNewField(Names.PV_DB_DAY, FieldType.UnsignedNumeric, 2);
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
            SetPassedParm(PV_SCREEN_IN, args, 0);
            SetPassedParm(PV_DB_DATE, args, 1);
            SetPassedParm(PV_ERROR_FLAG, args, 2);
        }


        public void UpdateReturnParameters(object[] args)
        {
            SetReturnParm(PV_SCREEN_IN, args, 0);
            SetReturnParm(PV_DB_DATE, args, 1);
            SetReturnParm(PV_ERROR_FLAG, args, 2);
        }
    }
    #endregion Linkage Section Class

    #region Business Logic Class
    public class SWASZ002 : BatchBase
    {

        #region Public Constructors
        public SWASZ002()
            : base()
        {
            this.ProgramName.SetValue("SWASZ002");

            WS = new SWASZ002_ws();
            LS = new SWASZ002_ls();
        }

        #endregion

        #region Private Fields


        //==== Working Storage Data Class ========================================
        private SWASZ002_ws WS;

        //==== Linkage Section Data Class ========================================
        private SWASZ002_ls LS;
        #endregion

        #region Public Methods
        //========================================================================
        //==== RunMain Entry Point Method ========================================
        //========================================================================
        public override int ExecuteMain(params object[] args)                                              //COBOL==> PROCEDURE DIVISION USING PV-SCREEN-IN PV-DB-DATE PV-ERROR-FLAG.
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
            M_0000_EDIT_THE_SCREEN_DATE(returnMethod);
        }
        /// <summary>
        /// Method M_0000_EDIT_THE_SCREEN_DATE
        /// </summary>
        private void M_0000_EDIT_THE_SCREEN_DATE(string returnMethod = "")
        {
            //COMMENT:     THIS ROUTINE HAS NO WORKING STORAGE TO ENSURE THAT IT
            //COMMENT:     MEETS THE REQUIREMENTS OF A RE-ENTRANT PROGRAM.
            if ((LS.PV_SCREEN_DATE.IsSpaces())
             || (LS.PV_SCREEN_DATE.IsEqualTo(LOW_VALUES)))    //COBOL==> IF PV-SCREEN-DATE = SPACES OR LOW-VALUES
            {
                LS.PV_ERROR_FLAG.SetValue("Y");                                                                     //COBOL==> MOVE 'Y' TO PV-ERROR-FLAG
                LS.PV_DB_DATE.SetValueWithZeroes();                                                                 //COBOL==> MOVE ZEROS TO PV-DB-DATE
                M_0000_EXIT(CheckGotoReturn(returnMethod)); return;                                                 //COBOL==> GO TO 0000-EXIT.
            }
            LS.PV_ERROR_FLAG.SetValue("Y");                                                                     //COBOL==> MOVE 'Y' TO PV-ERROR-FLAG.
            if (!(LS.PV_SCREEN_DATE_N.IsNumericValue()))                                                       //COBOL==> IF PV-SCREEN-DATE-N NOT NUMERIC
            {
                M_0000_EXIT(CheckGotoReturn(returnMethod)); return;                                                 //COBOL==> GO TO 0000-EXIT.
            }
            if ((LS.PV_SCREEN_MONTH.IsLessThan(1))
             || (LS.PV_SCREEN_MONTH.IsGreaterThan(12)))   //COBOL==> IF PV-SCREEN-MONTH < 1 OR > 12
            {
                M_0000_EXIT(CheckGotoReturn(returnMethod)); return;                                                 //COBOL==> GO TO 0000-EXIT.
            }
            if ((LS.PV_SCREEN_DAY.IsLessThan(1))
             || (LS.PV_SCREEN_DAY.IsGreaterThan(31)))       //COBOL==> IF PV-SCREEN-DAY < 1 OR > 31
            {
                M_0000_EXIT(CheckGotoReturn(returnMethod)); return;                                                 //COBOL==> GO TO 0000-EXIT.
            }
            if ((((LS.PV_SCREEN_MONTH.IsEqualTo(4))
             || (LS.PV_SCREEN_MONTH.IsEqualTo(6)))
             || (LS.PV_SCREEN_MONTH.IsEqualTo(9)))
             || (LS.PV_SCREEN_MONTH.IsEqualTo(11)))  //COBOL==> IF PV-SCREEN-MONTH = 4 OR 6 OR 9 OR 11
            {
                if (LS.PV_SCREEN_DAY.IsGreaterThan(30))                                                             //COBOL==> IF PV-SCREEN-DAY > 30
                {
                    M_0000_EXIT(CheckGotoReturn(returnMethod)); return;                                                 //COBOL==> GO TO 0000-EXIT
                }                                                                                                   //COBOL==> ELSE
                else
                {
                    LS.PV_ERROR_FLAG.SetValue("N");                                                                     //COBOL==> MOVE 'N' TO PV-ERROR-FLAG
                }                                                                                                   //COBOL==> ELSE
            }
            else
            {
                if (LS.PV_SCREEN_MONTH.IsEqualTo(2))                                                                //COBOL==> IF PV-SCREEN-MONTH = 2
                {
                    M_1000_CHECK_FEBRUARY("M_1000_EXIT"); if (Control.ExitProgram) { return; }                            //COBOL==> PERFORM 1000-CHECK-FEBRUARY THRU 1000-EXIT
                }                                                                                                   //COBOL==> ELSE
                else
                {
                    LS.PV_ERROR_FLAG.SetValue("N");                                                                     //COBOL==> MOVE 'N' TO PV-ERROR-FLAG.
                }
            }
            if (LS.PV_ERROR_FLAG.IsEqualTo("Y"))                                                                //COBOL==> IF PV-ERROR-FLAG = 'Y'
            {
                M_0000_EXIT(CheckGotoReturn(returnMethod)); return;                                                 //COBOL==> GO TO 0000-EXIT.
            }
            //COMMENT: *****************************************************************
            //COMMENT:    CTA MODIFICATION TSCTA47                                     *
            //COMMENT:  THE FOLLOWING MOVE STATEMENT WAS COMMENTED OUT TO ACCOMMODATE  *
            //COMMENT:  YEAR 2000 CONVERSIONS.                                         *
            //COMMENT: *****************************************************************
            //COMMENT:           MOVE       19        TO PV-DB-CENTURY.
            //COMMENT: *****************************************************************
            //COMMENT:    CTA MODIFICATION TSCTA47                                     *
            //COMMENT:  THE NEXT FIVE LINES OF CODE WERE INSERTED TO ACCOMMODATE       *
            //COMMENT:  YEAR 2000 CONVERSIONS.                                         *
            //COMMENT: *****************************************************************
            if (LS.PV_SCREEN_YEAR.IsLessThan(48))                                                               //COBOL==> IF PV-SCREEN-YEAR < 48
            {
                LS.PV_DB_CENTURY.SetValue(20);                                                                      //COBOL==> MOVE 20 TO PV-DB-CENTURY
            }                                                                                                   //COBOL==> ELSE
            else
            {
                LS.PV_DB_CENTURY.SetValue(19);                                                                      //COBOL==> MOVE 19 TO PV-DB-CENTURY.
            }
            LS.PV_DB_YEAR.SetValue(LS.PV_SCREEN_YEAR);                                                          //COBOL==> MOVE PV-SCREEN-YEAR TO PV-DB-YEAR.
            LS.PV_DB_MONTH.SetValue(LS.PV_SCREEN_MONTH);                                                        //COBOL==> MOVE PV-SCREEN-MONTH TO PV-DB-MONTH.
            LS.PV_DB_DAY.SetValue(LS.PV_SCREEN_DAY);                                                            //COBOL==> MOVE PV-SCREEN-DAY TO PV-DB-DAY.
            if (returnMethod != "" && returnMethod != "M_0000_EDIT_THE_SCREEN_DATE") { M_0000_EXIT(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_0000_EXIT
        /// </summary>
        private void M_0000_EXIT(string returnMethod = "")
        {
            Control.ExitProgram = true; return;                                                                 //COBOL==> GOBACK.
        }
        /// <summary>
        /// Method M_1000_CHECK_FEBRUARY
        /// </summary>
        private void M_1000_CHECK_FEBRUARY(string returnMethod = "")
        {
            if (LS.PV_SCREEN_DAY.IsGreaterThan(29))                                                             //COBOL==> IF PV-SCREEN-DAY > 29
            {
                M_1000_EXIT(CheckGotoReturn(returnMethod)); return;                                                 //COBOL==> GO TO 1000-EXIT.
            }
            if (LS.PV_SCREEN_DAY.IsLessThan(29))                                                                //COBOL==> IF PV-SCREEN-DAY < 29
            {
                LS.PV_ERROR_FLAG.SetValue("N");                                                                     //COBOL==> MOVE 'N' TO PV-ERROR-FLAG
                M_1000_EXIT(CheckGotoReturn(returnMethod)); return;                                                 //COBOL==> GO TO 1000-EXIT.
            }
            if (((((LS.PV_SCREEN_Y1.IsEqualTo(1))
             || (LS.PV_SCREEN_Y1.IsEqualTo(3)))
             || (LS.PV_SCREEN_Y1.IsEqualTo(5)))
             || (LS.PV_SCREEN_Y1.IsEqualTo(7)))
             || (LS.PV_SCREEN_Y1.IsEqualTo(9)))  //COBOL==> IF PV-SCREEN-Y1 = 1 OR 3 OR 5 OR 7 OR 9
            {
                if ((LS.PV_SCREEN_Y2.IsEqualTo(2))
             || (LS.PV_SCREEN_Y2.IsEqualTo(6)))               //COBOL==> IF PV-SCREEN-Y2 = 2 OR 6
                {
                    LS.PV_ERROR_FLAG.SetValue("N");                                                                     //COBOL==> MOVE 'N' TO PV-ERROR-FLAG
                }                                                                                                   //COBOL==> ELSE
                else
                {
                    goto EndOfSentence_1;                                                                               //COBOL==> NEXT SENTENCE
                }                                                                                                   //COBOL==> ELSE
            }
            else
            {
                if (((LS.PV_SCREEN_Y2.IsEqualTo(0))
             || (LS.PV_SCREEN_Y2.IsEqualTo(4)))
             || (LS.PV_SCREEN_Y2.IsEqualTo(8)))  //COBOL==> IF PV-SCREEN-Y2 = 0 OR 4 OR 8
                {
                    LS.PV_ERROR_FLAG.SetValue("N");                                                                     //COBOL==> MOVE 'N' TO PV-ERROR-FLAG.
                }
            }
        EndOfSentence_1:;
            if (returnMethod != "" && returnMethod != "M_1000_CHECK_FEBRUARY") { M_1000_EXIT(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_1000_EXIT
        /// </summary>
        private void M_1000_EXIT(string returnMethod = "")
        {
            if (returnMethod == "M_1000_EXIT") { return; }                                                      //COBOL==> EXIT.
        }
        #endregion
    }
    #endregion
}
