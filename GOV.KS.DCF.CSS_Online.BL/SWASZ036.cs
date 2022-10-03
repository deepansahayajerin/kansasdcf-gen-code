#region Comments
/* Conversion Comments
   ************************************************************
   **   MODERN SYSTEMS INC.  COPYRIGHT 2000-2022
   **   DB-SHUTTLE COBOL to C# Conversion
   ************************************************************
   ** INIT   *  INITIAL VERSION   *  2022-01-14 12:46:19 PM
   **        *   FROM COBOL PGM   :  SWASZ036
   **        *   FROM CANISTER    :  SR.CAECSES.PROD.LIBR.SOURCE.PDS
   ************************************************************ */

/* Original Program Identification Comments
   
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
    internal class SWASZ036_ws : PredefinedRecordBase
    {
        #region Name constants
        /// <summary>
        /// Name constants.
        /// </summary>
        internal static class Names
        {
            internal const string WorkingStorage = "SWASZ036_ws_WorkingStorage";
            internal const string THIS_IS_NOTHING = "THIS_IS_NOTHING";
        }
        #endregion

        #region Direct-access element properties
        public IField THIS_IS_NOTHING { get { return GetElementByName<IField>(Names.THIS_IS_NOTHING); } }

        #endregion

        #region Data structure definition
        /// <summary>
        /// Defines the entirety of the WorkingStorage IRecord structure as described by the Ateras.Framework.Buffer API.
        /// </summary>
        /// <param name="recordDef">The IStructureDefinition object to be used in defining the record structure.</param>
        protected override void DefineRecordStructure(IStructureDefinition recordDef)
        {
            recordDef.CreateNewField(Names.THIS_IS_NOTHING, FieldType.String, 6, "AAAAAA");

        }

        protected override string GetRecordName()
        {
            return Names.WorkingStorage;
        }
        #endregion

    }
    #endregion Working Storage Class

    #region Linkage Section Class
    internal class SWASZ036_ls : PredefinedRecordBase
    {
        #region Name constants
        /// <summary>
        /// Name constants.
        /// </summary>
        internal static class Names
        {
            internal const string LinkageSection = "SWASZ036_ls_LinkageSection";
            internal const string PV_DISPLAY = "PV_DISPLAY";
            internal const string MV_DISPLAY = "MV_DISPLAY";
            internal const string MV_DISPLAY_MONTH = "MV_DISPLAY_MONTH";
            internal const string MV_COMMA = "MV_COMMA";
            internal const string MV_DISPLAY_YEAR = "MV_DISPLAY_YEAR";
            internal const string PV_DB_MONTH = "PV_DB_MONTH";
            internal const string PV_DB_YEAR = "PV_DB_YEAR";
            internal const string PV_DB_MONTH_NUM = "PV_DB_MONTH_NUM";
        }
        #endregion

        #region Direct-access element properties
        public IField PV_DISPLAY { get { return GetElementByName<IField>(Names.PV_DISPLAY); } }
        public IGroup MV_DISPLAY { get { return GetElementByName<IGroup>(Names.MV_DISPLAY); } }
        public IField MV_DISPLAY_MONTH { get { return GetElementByName<IField>(Names.MV_DISPLAY_MONTH); } }
        public IField MV_COMMA { get { return GetElementByName<IField>(Names.MV_COMMA); } }
        public IField MV_DISPLAY_YEAR { get { return GetElementByName<IField>(Names.MV_DISPLAY_YEAR); } }
        public IGroup PV_DB_MONTH { get { return GetElementByName<IGroup>(Names.PV_DB_MONTH); } }
        public IField PV_DB_YEAR { get { return GetElementByName<IField>(Names.PV_DB_YEAR); } }
        public IField PV_DB_MONTH_NUM { get { return GetElementByName<IField>(Names.PV_DB_MONTH_NUM); } }

        #endregion

        #region Data structure definition
        /// <summary>
        /// Defines the entirety of the LinkageSection IRecord structure as described by the Ateras.Framework.Buffer API.
        /// </summary>
        /// <param name="recordDef">The IStructureDefinition object to be used in defining the record structure.</param>
        protected override void DefineRecordStructure(IStructureDefinition recordDef)
        {

            IField PV_DISPLAY_local = recordDef.CreateNewField(Names.PV_DISPLAY, FieldType.String, 15);
            recordDef.CreateNewGroupRedefine(Names.MV_DISPLAY, PV_DISPLAY_local, (MV_DISPLAY) =>
            {
                MV_DISPLAY.CreateNewField(Names.MV_DISPLAY_MONTH, FieldType.String, 9);
                MV_DISPLAY.CreateNewField(Names.MV_COMMA, FieldType.String, 2);
                MV_DISPLAY.CreateNewField(Names.MV_DISPLAY_YEAR, FieldType.String, 4);
            });

            recordDef.CreateNewGroup(Names.PV_DB_MONTH, (PV_DB_MONTH) =>
           {
               PV_DB_MONTH.CreateNewField(Names.PV_DB_YEAR, FieldType.String, 4);
               PV_DB_MONTH.CreateNewField(Names.PV_DB_MONTH_NUM, FieldType.UnsignedNumeric, 2);
           });

        }

        protected override string GetRecordName()
        {
            return Names.LinkageSection;
        }
        #endregion

        public void SetPassedParameters(object[] args)
        {
            SetPassedParm(PV_DISPLAY, args, 0);
            SetPassedParm(PV_DB_MONTH, args, 1);
        }


        public void UpdateReturnParameters(object[] args)
        {
            SetReturnParm(PV_DISPLAY, args, 0);
            SetReturnParm(PV_DB_MONTH, args, 1);
        }
    }
    #endregion Linkage Section Class

    #region Business Logic Class
    public class SWASZ036 : BatchBase
    {

        #region Public Constructors
        public SWASZ036()
            : base()
        {
            this.ProgramName.SetValue("SWASZ036");

            WS = new SWASZ036_ws();
            LS = new SWASZ036_ls();
        }

        #endregion

        #region Private Fields


        //==== Working Storage Data Class ========================================
        private SWASZ036_ws WS;

        //==== Linkage Section Data Class ========================================
        private SWASZ036_ls LS;
        #endregion

        #region Public Methods
        //========================================================================
        //==== RunMain Entry Point Method ========================================
        //========================================================================
        public override int ExecuteMain(params object[] args)                                              //COBOL==> PROCEDURE DIVISION USING PV-DISPLAY PV-DB-MONTH.
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
            WS.THIS_IS_NOTHING.SetValue("ZZZZZZ");                                                              //COBOL==> MOVE 'ZZZZZZ' TO THIS-IS-NOTHING.
            if (LS.PV_DB_MONTH.IsLessThanOrEqualTo(ZEROES))                                                     //COBOL==> IF PV-DB-MONTH NOT > ZEROES
            {
                LS.PV_DISPLAY.SetValue("ASZ036??");                                                                 //COBOL==> MOVE 'ASZ036??' TO PV-DISPLAY
            }                                                                                                   //COBOL==> ELSE
            else
            {
                if (LS.PV_DB_MONTH_NUM.IsEqualTo(01))                                                               //COBOL==> IF PV-DB-MONTH-NUM = 01
                {
                    LS.MV_DISPLAY_MONTH.SetValue("JANUARY  ");                                                          //COBOL==> MOVE 'JANUARY  ' TO MV-DISPLAY-MONTH.
                }
            }
            if (LS.PV_DB_MONTH_NUM.IsEqualTo(02))                                                               //COBOL==> IF PV-DB-MONTH-NUM = 02
            {
                LS.MV_DISPLAY_MONTH.SetValue("FEBRUARY ");                                                          //COBOL==> MOVE 'FEBRUARY ' TO MV-DISPLAY-MONTH.
            }
            if (LS.PV_DB_MONTH_NUM.IsEqualTo(03))                                                               //COBOL==> IF PV-DB-MONTH-NUM = 03
            {
                LS.MV_DISPLAY_MONTH.SetValue("MARCH    ");                                                          //COBOL==> MOVE 'MARCH    ' TO MV-DISPLAY-MONTH.
            }
            if (LS.PV_DB_MONTH_NUM.IsEqualTo(04))                                                               //COBOL==> IF PV-DB-MONTH-NUM = 04
            {
                LS.MV_DISPLAY_MONTH.SetValue("APRIL    ");                                                          //COBOL==> MOVE 'APRIL    ' TO MV-DISPLAY-MONTH.
            }
            if (LS.PV_DB_MONTH_NUM.IsEqualTo(05))                                                               //COBOL==> IF PV-DB-MONTH-NUM = 05
            {
                LS.MV_DISPLAY_MONTH.SetValue("MAY      ");                                                          //COBOL==> MOVE 'MAY      ' TO MV-DISPLAY-MONTH.
            }
            if (LS.PV_DB_MONTH_NUM.IsEqualTo(06))                                                               //COBOL==> IF PV-DB-MONTH-NUM = 06
            {
                LS.MV_DISPLAY_MONTH.SetValue("JUNE     ");                                                          //COBOL==> MOVE 'JUNE     ' TO MV-DISPLAY-MONTH.
            }
            if (LS.PV_DB_MONTH_NUM.IsEqualTo(07))                                                               //COBOL==> IF PV-DB-MONTH-NUM = 07
            {
                LS.MV_DISPLAY_MONTH.SetValue("JULY     ");                                                          //COBOL==> MOVE 'JULY     ' TO MV-DISPLAY-MONTH.
            }
            if (LS.PV_DB_MONTH_NUM.IsEqualTo(08))                                                               //COBOL==> IF PV-DB-MONTH-NUM = 08
            {
                LS.MV_DISPLAY_MONTH.SetValue("AUGUST   ");                                                          //COBOL==> MOVE 'AUGUST   ' TO MV-DISPLAY-MONTH.
            }
            if (LS.PV_DB_MONTH_NUM.IsEqualTo(09))                                                               //COBOL==> IF PV-DB-MONTH-NUM = 09
            {
                LS.MV_DISPLAY_MONTH.SetValue("SEPTEMBER");                                                          //COBOL==> MOVE 'SEPTEMBER' TO MV-DISPLAY-MONTH.
            }
            if (LS.PV_DB_MONTH_NUM.IsEqualTo(10))                                                               //COBOL==> IF PV-DB-MONTH-NUM = 10
            {
                LS.MV_DISPLAY_MONTH.SetValue("OCTOBER  ");                                                          //COBOL==> MOVE 'OCTOBER  ' TO MV-DISPLAY-MONTH.
            }
            if (LS.PV_DB_MONTH_NUM.IsEqualTo(11))                                                               //COBOL==> IF PV-DB-MONTH-NUM = 11
            {
                LS.MV_DISPLAY_MONTH.SetValue("NOVEMBER ");                                                          //COBOL==> MOVE 'NOVEMBER ' TO MV-DISPLAY-MONTH.
            }
            if (LS.PV_DB_MONTH_NUM.IsEqualTo(12))                                                               //COBOL==> IF PV-DB-MONTH-NUM = 12
            {
                LS.MV_DISPLAY_MONTH.SetValue("DECEMBER ");                                                          //COBOL==> MOVE 'DECEMBER ' TO MV-DISPLAY-MONTH.
            }
            LS.MV_COMMA.SetValue(", ");                                                                         //COBOL==> MOVE ', ' TO MV-COMMA.
            LS.MV_DISPLAY_YEAR.SetValue(LS.PV_DB_YEAR);                                                         //COBOL==> MOVE PV-DB-YEAR TO MV-DISPLAY-YEAR.
            Control.ExitProgram = true; return;                                                                 //COBOL==> GOBACK.
        }
        #endregion
    }
    #endregion
}
