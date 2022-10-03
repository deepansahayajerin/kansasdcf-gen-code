#region Comments
/* Conversion Comments
   ************************************************************
   **   MODERN SYSTEMS INC.  COPYRIGHT 2000-2022
   **   DB-SHUTTLE COBOL to C# Conversion
   ************************************************************
   ** INIT   *  INITIAL VERSION   *  2022-01-14 12:46:08 PM
   **        *   FROM COBOL PGM   :  SWASZ010
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
    internal class SWASZ010_ws : PredefinedRecordBase
    {
        #region Name constants
        /// <summary>
        /// Name constants.
        /// </summary>
        internal static class Names
        {
            internal const string WorkingStorage = "SWASZ010_ws_WorkingStorage";
            internal const string MODULE_VARIABLES = "MODULE_VARIABLES";
            internal const string MV_TEMP = "MV_TEMP";
            internal const string MV_REMAINDER = "MV_REMAINDER";
            internal const string SC_CENTURY_19 = "SC_CENTURY_19";
            internal const string SC_CENTURY_20 = "SC_CENTURY_20";
        }
        #endregion

        #region Direct-access element properties
        public IGroup MODULE_VARIABLES { get { return GetElementByName<IGroup>(Names.MODULE_VARIABLES); } }
        public IField MV_TEMP { get { return GetElementByName<IField>(Names.MV_TEMP); } }
        public IField MV_REMAINDER { get { return GetElementByName<IField>(Names.MV_REMAINDER); } }
        public IField SC_CENTURY_19 { get { return GetElementByName<IField>(Names.SC_CENTURY_19); } }
        public IField SC_CENTURY_20 { get { return GetElementByName<IField>(Names.SC_CENTURY_20); } }

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
               MODULE_VARIABLES.CreateNewField(Names.MV_TEMP, FieldType.CompShort, 2);
               MODULE_VARIABLES.CreateNewField(Names.MV_REMAINDER, FieldType.CompShort, 2);
           });
            recordDef.CreateNewField(Names.SC_CENTURY_19, FieldType.UnsignedNumeric, 2, 19);
            recordDef.CreateNewField(Names.SC_CENTURY_20, FieldType.UnsignedNumeric, 2, 20);

        }

        protected override string GetRecordName()
        {
            return Names.WorkingStorage;
        }
        #endregion

    }
    #endregion Working Storage Class

    #region Linkage Section Class
    internal class SWASZ010_ls : PredefinedRecordBase
    {
        #region Name constants
        /// <summary>
        /// Name constants.
        /// </summary>
        internal static class Names
        {
            internal const string LinkageSection = "SWASZ010_ls_LinkageSection";
            internal const string PV_SCREEN_DATE = "PV_SCREEN_DATE";
            internal const string PV_SCREEN_MONTH = "PV_SCREEN_MONTH";
            internal const string PV_SCREEN_DAY = "PV_SCREEN_DAY";
            internal const string PV_SCREEN_CENTURY = "PV_SCREEN_CENTURY";
            internal const string PV_SCREEN_YEAR = "PV_SCREEN_YEAR";
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
        public IGroup PV_SCREEN_DATE { get { return GetElementByName<IGroup>(Names.PV_SCREEN_DATE); } }
        public IField PV_SCREEN_MONTH { get { return GetElementByName<IField>(Names.PV_SCREEN_MONTH); } }
        public IField PV_SCREEN_DAY { get { return GetElementByName<IField>(Names.PV_SCREEN_DAY); } }
        public IField PV_SCREEN_CENTURY { get { return GetElementByName<IField>(Names.PV_SCREEN_CENTURY); } }
        public IField PV_SCREEN_YEAR { get { return GetElementByName<IField>(Names.PV_SCREEN_YEAR); } }
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

            IGroup PV_SCREEN_DATE_local = (IGroup)recordDef.CreateNewGroup(Names.PV_SCREEN_DATE, (PV_SCREEN_DATE) =>
           {
               PV_SCREEN_DATE.CreateNewField(Names.PV_SCREEN_MONTH, FieldType.UnsignedNumeric, 2);
               PV_SCREEN_DATE.CreateNewField(Names.PV_SCREEN_DAY, FieldType.UnsignedNumeric, 2);
               PV_SCREEN_DATE.CreateNewField(Names.PV_SCREEN_CENTURY, FieldType.UnsignedNumeric, 2);
               PV_SCREEN_DATE.CreateNewField(Names.PV_SCREEN_YEAR, FieldType.UnsignedNumeric, 2);
           });
            recordDef.CreateNewFieldRedefine(Names.PV_SCREEN_DATE_N, FieldType.UnsignedNumeric, PV_SCREEN_DATE_local, 8);

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
            SetPassedParm(PV_SCREEN_DATE, args, 0);
            SetPassedParm(PV_DB_DATE, args, 1);
            SetPassedParm(PV_ERROR_FLAG, args, 2);
        }


        public void UpdateReturnParameters(object[] args)
        {
            SetReturnParm(PV_SCREEN_DATE, args, 0);
            SetReturnParm(PV_DB_DATE, args, 1);
            SetReturnParm(PV_ERROR_FLAG, args, 2);
        }
    }
    #endregion Linkage Section Class

    #region Business Logic Class
    public class SWASZ010 : BatchBase
    {

        #region Public Constructors
        public SWASZ010()
            : base()
        {
            this.ProgramName.SetValue("SWASZ010");

            WS = new SWASZ010_ws();
            LS = new SWASZ010_ls();
        }

        #endregion

        #region Private Fields


        //==== Working Storage Data Class ========================================
        private SWASZ010_ws WS;

        //==== Linkage Section Data Class ========================================
        private SWASZ010_ls LS;
        #endregion

        #region Public Methods
        //========================================================================
        //==== RunMain Entry Point Method ========================================
        //========================================================================
        public override int ExecuteMain(params object[] args)                                              //COBOL==> PROCEDURE DIVISION USING PV-SCREEN-DATE PV-DB-DATE PV-ERROR-FLAG.
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
            //COMMENT: *** EDIT THE SCREEN DATE
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
            WS.MV_TEMP.SetValue(LS.PV_SCREEN_YEAR.AsDecimal() / 4m);                                            //COBOL==> DIVIDE PV-SCREEN-YEAR BY 4 GIVING MV-TEMP REMAINDER MV-REMAINDER.
            WS.MV_REMAINDER.SetValue(LS.PV_SCREEN_YEAR.AsDecimal() % 4m);
            if (WS.MV_REMAINDER.IsEqualTo(0))                                                                   //COBOL==> IF MV-REMAINDER = 0
            {
                LS.PV_DB_DAY.SetValue(29);                                                                          //COBOL==> MOVE 29 TO PV-DB-DAY
            }                                                                                                   //COBOL==> ELSE
            else
            {
                LS.PV_DB_DAY.SetValue(28);                                                                          //COBOL==> MOVE 28 TO PV-DB-DAY.
            }
            if (LS.PV_SCREEN_DAY.IsLessThan(1))                                                                 //COBOL==> IF PV-SCREEN-DAY < 1
            {
                M_0000_EXIT(CheckGotoReturn(returnMethod)); return;                                                 //COBOL==> GO TO 0000-EXIT.
            }
            if (LS.PV_SCREEN_MONTH.IsEqualTo(2))                                                                //COBOL==> IF PV-SCREEN-MONTH = 2
            {
                if (LS.PV_SCREEN_DAY.IsGreaterThan(LS.PV_DB_DAY))                                                   //COBOL==> IF PV-SCREEN-DAY > PV-DB-DAY
                {
                    M_0000_EXIT(CheckGotoReturn(returnMethod)); return;                                                 //COBOL==> GO TO 0000-EXIT.
                }
            }
            if (((((LS.PV_SCREEN_MONTH.IsEqualTo(2))
             || (LS.PV_SCREEN_MONTH.IsEqualTo(4)))
             || (LS.PV_SCREEN_MONTH.IsEqualTo(6)))
             || (LS.PV_SCREEN_MONTH.IsEqualTo(9)))
             || (LS.PV_SCREEN_MONTH.IsEqualTo(11)))  //COBOL==> IF PV-SCREEN-MONTH = 2 OR PV-SCREEN-MONTH = 4 OR PV-SCREEN-MONTH = 6 OR PV-SCREEN-MONTH = 9 OR PV-SCREEN-MONTH = 11
            {
                if (LS.PV_SCREEN_DAY.IsGreaterThan(30))                                                             //COBOL==> IF PV-SCREEN-DAY > 30
                {
                    M_0000_EXIT(CheckGotoReturn(returnMethod)); return;                                                 //COBOL==> GO TO 0000-EXIT.
                }
            }
            if (LS.PV_SCREEN_DAY.IsGreaterThan(31))                                                             //COBOL==> IF PV-SCREEN-DAY > 31
            {
                M_0000_EXIT(CheckGotoReturn(returnMethod)); return;                                                 //COBOL==> GO TO 0000-EXIT.
            }
            //COMMENT: ----------------------------------------------------------------*
            //COMMENT:  CTA MODIFICATION 10:00:01 AM. MARCH 16, 1998                   *
            //COMMENT:     IF PV-SCREEN-CENTURY > SC-CENTURY OR                        *
            //COMMENT: ----------------------------------------------------------------*
            if ((LS.PV_SCREEN_CENTURY.IsGreaterThan(WS.SC_CENTURY_20))
             || (LS.PV_SCREEN_CENTURY.IsLessThan(18)))  //COBOL==> IF PV-SCREEN-CENTURY > SC-CENTURY-20 OR PV-SCREEN-CENTURY < 18
            {
                M_0000_EXIT(CheckGotoReturn(returnMethod)); return;                                                 //COBOL==> GO TO 0000-EXIT.
            }
            LS.PV_ERROR_FLAG.SetValue("N");                                                                     //COBOL==> MOVE 'N' TO PV-ERROR-FLAG.
                                                                                                                //COMMENT: *** CONVERT THE SCREEN DATE
            LS.PV_DB_CENTURY.SetValue(LS.PV_SCREEN_CENTURY);                                                    //COBOL==> MOVE PV-SCREEN-CENTURY TO PV-DB-CENTURY.
            LS.PV_DB_YEAR.SetValue(LS.PV_SCREEN_YEAR);                                                          //COBOL==> MOVE PV-SCREEN-YEAR TO PV-DB-YEAR.
            LS.PV_DB_MONTH.SetValue(LS.PV_SCREEN_MONTH);                                                        //COBOL==> MOVE PV-SCREEN-MONTH TO PV-DB-MONTH.
            LS.PV_DB_DAY.SetValue(LS.PV_SCREEN_DAY);                                                            //COBOL==> MOVE PV-SCREEN-DAY TO PV-DB-DAY.
                                                                                                                // Execute Procedure Division Logic
            M_0000_EXIT(returnMethod);
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
