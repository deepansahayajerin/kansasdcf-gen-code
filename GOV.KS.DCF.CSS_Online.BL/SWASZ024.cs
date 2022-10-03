#region Comments
/* Conversion Comments
   ************************************************************
   **   MODERN SYSTEMS INC.  COPYRIGHT 2000-2022
   **   DB-SHUTTLE COBOL to C# Conversion
   ************************************************************
   ** INIT   *  INITIAL VERSION   *  2022-01-14 12:46:10 PM
   **        *   FROM COBOL PGM   :  SWASZ024
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
    internal class SWASZ024_ws : PredefinedRecordBase
    {
        #region Name constants
        /// <summary>
        /// Name constants.
        /// </summary>
        internal static class Names
        {
            internal const string WorkingStorage = "SWASZ024_ws_WorkingStorage";
            internal const string PV_SCREEN_NDX = "PV_SCREEN_NDX";
            internal const string PV_DB_NDX = "PV_DB_NDX";
        }
        #endregion

        #region Direct-access element properties
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
    internal class SWASZ024_ls : PredefinedRecordBase
    {
        #region Name constants
        /// <summary>
        /// Name constants.
        /// </summary>
        internal static class Names
        {
            internal const string LinkageSection = "SWASZ024_ls_LinkageSection";
            internal const string PV_SCREEN_NUMBER = "PV_SCREEN_NUMBER";
            internal const string PV_SCREEN_DIGIT = "PV_SCREEN_DIGIT";
            internal const string PV_LENGTH = "PV_LENGTH";
            internal const string PV_DB_NUMBER = "PV_DB_NUMBER";
            internal const string PV_DB_DIGIT = "PV_DB_DIGIT";
            internal const string PV_ERROR_FLAG = "PV_ERROR_FLAG";
        }
        #endregion

        #region Direct-access element properties
        public IGroup PV_SCREEN_NUMBER { get { return GetElementByName<IGroup>(Names.PV_SCREEN_NUMBER); } }
        public IArrayElementAccessor<IField> PV_SCREEN_DIGIT { get { return GetArrayElementAccessor<IField>(Names.PV_SCREEN_DIGIT); } }
        public IField PV_LENGTH { get { return GetElementByName<IField>(Names.PV_LENGTH); } }
        public IGroup PV_DB_NUMBER { get { return GetElementByName<IGroup>(Names.PV_DB_NUMBER); } }
        public IArrayElementAccessor<IField> PV_DB_DIGIT { get { return GetArrayElementAccessor<IField>(Names.PV_DB_DIGIT); } }
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

            recordDef.CreateNewGroup(Names.PV_DB_NUMBER, (PV_DB_NUMBER) =>
           {
               PV_DB_NUMBER.CreateNewFieldArray(Names.PV_DB_DIGIT, 15, FieldType.UnsignedNumeric, 1);
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
    public class SWASZ024 : BatchBase
    {

        #region Public Constructors
        public SWASZ024()
            : base()
        {
            this.ProgramName.SetValue("SWASZ024");

            WS = new SWASZ024_ws();
            LS = new SWASZ024_ls();
        }

        #endregion

        #region Private Fields


        //==== Working Storage Data Class ========================================
        private SWASZ024_ws WS;

        //==== Linkage Section Data Class ========================================
        private SWASZ024_ls LS;
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
            LS.PV_ERROR_FLAG.SetValue("N");                                                                     //COBOL==> MOVE 'N' TO PV-ERROR-FLAG.
            WS.PV_DB_NDX.SetValue(LS.PV_LENGTH);                                                                //COBOL==> SET PV-DB-NDX TO PV-LENGTH.
            for (WS.PV_DB_NDX.SetValue(LS.PV_LENGTH); (!(WS.PV_DB_NDX.IsLessThan(1))); WS.PV_DB_NDX.Add(-1))   //COBOL==> PERFORM 1000-MOVE-ZEROS THRU 1000-MOVE-ZEROS-EXIT VARYING PV-DB-NDX FROM PV-LENGTH BY -1 UNTIL PV-DB-NDX < 1.
            {
                M_1000_MOVE_ZEROS("M_1000_MOVE_ZEROS_EXIT"); if (Control.ExitProgram) { return; }
            }
            WS.PV_DB_NDX.SetValue(LS.PV_LENGTH);                                                                //COBOL==> SET PV-DB-NDX TO PV-LENGTH.
            for (WS.PV_SCREEN_NDX.SetValue(LS.PV_LENGTH); (!((WS.PV_SCREEN_NDX.IsLessThan(1)) || (LS.PV_ERROR_FLAG.IsEqualTo("Y")))); WS.PV_SCREEN_NDX.Add(-1))  //COBOL==> PERFORM 2000-SCAN-INPUT THRU 2000-EXIT VARYING PV-SCREEN-NDX FROM PV-LENGTH BY -1 UNTIL PV-SCREEN-NDX < 1 OR PV-ERROR-FLAG = 'Y'.
            {
                M_2000_SCAN_INPUT("M_2000_EXIT"); if (Control.ExitProgram) { return; }
            }
            Control.ExitProgram = true; return;                                                                 //COBOL==> GOBACK.
        }
        /// <summary>
        /// Method M_1000_MOVE_ZEROS
        /// </summary>
        private void M_1000_MOVE_ZEROS(string returnMethod = "")
        {
            LS.PV_DB_DIGIT[WS.PV_DB_NDX.AsInt()].SetValueWithZeroes();                                          //COBOL==> MOVE ZERO TO PV-DB-DIGIT ( PV-DB-NDX ) .
            if (returnMethod != "" && returnMethod != "M_1000_MOVE_ZEROS") { M_1000_MOVE_ZEROS_EXIT(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_1000_MOVE_ZEROS_EXIT
        /// </summary>
        private void M_1000_MOVE_ZEROS_EXIT(string returnMethod = "")
        {
            if (returnMethod != "" && returnMethod != "M_1000_MOVE_ZEROS_EXIT") { M_2000_SCAN_INPUT(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_2000_SCAN_INPUT
        /// </summary>
        private void M_2000_SCAN_INPUT(string returnMethod = "")
        {
            if ((!(LS.PV_SCREEN_DIGIT[WS.PV_SCREEN_NDX.AsInt()].IsSpaces()))
             && (!(LS.PV_SCREEN_DIGIT[WS.PV_SCREEN_NDX.AsInt()].IsEqualTo(LOW_VALUES))))  //COBOL==> IF PV-SCREEN-DIGIT ( PV-SCREEN-NDX ) NOT = SPACE AND LOW-VALUE
            {
                if ((LS.PV_SCREEN_DIGIT[WS.PV_SCREEN_NDX.AsInt()].IsLessThan("0"))
             || (LS.PV_SCREEN_DIGIT[WS.PV_SCREEN_NDX.AsInt()].IsGreaterThan("9")))  //COBOL==> IF PV-SCREEN-DIGIT ( PV-SCREEN-NDX ) < '0' OR > '9'
                {
                    LS.PV_ERROR_FLAG.SetValue("Y");                                                                     //COBOL==> MOVE 'Y' TO PV-ERROR-FLAG
                }                                                                                                   //COBOL==> ELSE
                else
                {
                    LS.PV_DB_DIGIT[WS.PV_DB_NDX.AsInt()].SetValue(LS.PV_SCREEN_DIGIT[WS.PV_SCREEN_NDX.AsInt()]);        //COBOL==> MOVE PV-SCREEN-DIGIT ( PV-SCREEN-NDX ) TO PV-DB-DIGIT ( PV-DB-NDX )
                    WS.PV_DB_NDX.Subtract(1);                                                                           //COBOL==> SET PV-DB-NDX DOWN BY 1.
                }
            }
            if (returnMethod != "" && returnMethod != "M_2000_SCAN_INPUT") { M_2000_EXIT(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_2000_EXIT
        /// </summary>
        private void M_2000_EXIT(string returnMethod = "")
        {
        }
        #endregion
    }
    #endregion
}
