#region Comments
/* Conversion Comments
   ************************************************************
   **   MODERN SYSTEMS INC.  COPYRIGHT 2000-2022
   **   DB-SHUTTLE COBOL to C# Conversion
   ************************************************************
   ** INIT   *  INITIAL VERSION   *  2022-01-14 12:46:18 PM
   **        *   FROM COBOL PGM   :  SWASZ032
   **        *   FROM CANISTER    :  SR.CAECSES.PROD.LIBR.SOURCE.PDS
   ************************************************************ */

/* Original Program Identification Comments
   DATE-COMPILED.
   
   
   
   **** START DOCUMENTATION ****************************************
   *                                                              **
   *    SYSTEM:  CAECSES  - AUTOMATED ELIGIBILITY                 **
   *                                                              **
   *    PROGRAM: SWASZ032 - SET SCR. ATTRIBUTES AND POSITION CURS.**
   *                                                              **
   *    DESCRIPTION:                                              **
   *        THIS PROGRAM SETS SCREEN ATTRIBUTES FOR ERRORS.       **
   *                                                              **
   *    PROCESSING:                                               **
   *        THIS PROGRAM ACCEPTS PARAMETERS FROM THE CALLING      **
   *        MODULE AND SETS THE SCREEN ATTRIBUTES AND CURSOR      **
   *        POSITION ACCORDING TO THE ERRORS RECORDED.            **
   *                                                              **
   *                                                              **
   *    SCREEN(S) GENERATED:                                      **
   *        SCREEN    DESCRIPTION                                 **
   *         NONE                                                 **
   *                                                              **
   *    TABLE(S) ACCESSED:                                        **
   *        TABLE #   DESCRIPTION                                 **
   *         NONE                                                 **
   *                                                              **
   *    DATABASE FILE(S) AND QUEUE(S):                            **
   *         FILE               INPUT  UPDATE  ADD  DELETE        **
   *         NONE                                                 **
   *                                                              **
   *    COPY MODULES:                                             **
   *         MODULE      DESCRIPTION                              **
   *      1) NONE                                                 **
   *                                                              **
   *    LINK MODULES:                                             **
   *         MODULE      DESCRIPTION                              **
   *      1) NONE                                                 **
   *                                                              **
   *    CREATED BY SHL SYSTEMHOUSE, 09/01/1987                    **
   *                                                              **
   **** END DOCUMENTATION ******************************************
   
   ----------------------------------------------------------------*
    CTA MODIFICATION   FEBRUARY 10, 1998                           *
                                                                   *
    CONTRACT NO:  31994                                            *
    NO CHANGES MADE FOR THE Y2K PROCESSING - CTA Y2K SRS           *
                                                                   *
   ----------------------------------------------------------------*
   *****************************************************************
    CTA INCORPORATED Y2K PROJECT FOR THE YEAR 2000                 *
                    CONTRACT NO: 31994                             *
    SPECIFICATION DATA FOR Y2K KAECSES PROGRAMS                    *
                                                                   *
    NO FILES TO CONVERT                                            *
                                                                   *
    A.  EXAMINE THE CANDIDATE DATE NAME                            *
    B.  ACKNOWLEDGE WHETHER DATA NAME DEFINED TO PROGRAM           *
        IF NONE DEFINED - COMMENT IN CTA LOGO  'NO CHANGE'         *
        WITH THE DATE AND TIME                                     *
    C.  ANALYZE DATA NAME AND DECIDE WHICH COPY BOOK TO USE        *
    D.  PROCEED TO MAKE NECESSARY CHANGES                          *
    E.  QUESTIONS NOTIFY YOUR TEAM LEAD OR PROJECT MANAGER         *
   *****************************************************************
   
   
   
   **** START MAINTENANCE LOG ************ PROGRAM SWASZ032 ********
   *                                                              **
   *    MAINTENANCE LOG                                           **
   *        AUTHOR     DATE    CHG REQ #  DESCRIPTION             **
   *                                                              **
   **** END MAINTENANCE LOG ****************************************
   
   
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
    internal class SWASZ032_ws : PredefinedRecordBase
    {
        #region Name constants
        /// <summary>
        /// Name constants.
        /// </summary>
        internal static class Names
        {
            internal const string WorkingStorage = "SWASZ032_ws_WorkingStorage";
            internal const string MODULE_VARIABLES = "MODULE_VARIABLES";
            internal const string MV_POS = "MV_POS";
            internal const string MV_POS1 = "MV_POS1";
            internal const string MV_SAVE_ERROR = "MV_SAVE_ERROR";
            internal const string MV_SAVE_WARNING = "MV_SAVE_WARNING";
            internal const string MV_SAVE_HEADER_AREA = "MV_SAVE_HEADER_AREA";
            internal const string MV_MARK_LEN = "MV_MARK_LEN";
            internal const string MV_SAVE_HEADER_REDF = "MV_SAVE_HEADER_REDF";
            internal const string MV_MARK = "MV_MARK";
            internal const string SYSTEM_CONSTANTS = "SYSTEM_CONSTANTS";
            internal const string SC_SET_CURSOR = "SC_SET_CURSOR";
            internal const string SC_MARK_ERROR = "SC_MARK_ERROR";
            internal const string SC_MARK_ERROR_NUM = "SC_MARK_ERROR_NUM";
            internal const string SC_MARK_WARNING = "SC_MARK_WARNING";
            internal const string SC_MARK_WARNING_NUM = "SC_MARK_WARNING_NUM";
            internal const string SC_BRIGHT_UNPRO = "SC_BRIGHT_UNPRO";
            internal const string SC_BRIGHT_UNPRO_NUM = "SC_BRIGHT_UNPRO_NUM";
        }
        #endregion

        #region Direct-access element properties
        public IGroup MODULE_VARIABLES { get { return GetElementByName<IGroup>(Names.MODULE_VARIABLES); } }
        public IField MV_POS { get { return GetElementByName<IField>(Names.MV_POS); } }
        public IField MV_POS1 { get { return GetElementByName<IField>(Names.MV_POS1); } }
        public IField MV_SAVE_ERROR { get { return GetElementByName<IField>(Names.MV_SAVE_ERROR); } }
        public IField MV_SAVE_WARNING { get { return GetElementByName<IField>(Names.MV_SAVE_WARNING); } }
        public IGroup MV_SAVE_HEADER_AREA { get { return GetElementByName<IGroup>(Names.MV_SAVE_HEADER_AREA); } }
        public IField MV_MARK_LEN { get { return GetElementByName<IField>(Names.MV_MARK_LEN); } }
        public IGroup MV_SAVE_HEADER_REDF { get { return GetElementByName<IGroup>(Names.MV_SAVE_HEADER_REDF); } }
        public IArrayElementAccessor<IField> MV_MARK { get { return GetArrayElementAccessor<IField>(Names.MV_MARK); } }
        public IGroup SYSTEM_CONSTANTS { get { return GetElementByName<IGroup>(Names.SYSTEM_CONSTANTS); } }
        public IField SC_SET_CURSOR { get { return GetElementByName<IField>(Names.SC_SET_CURSOR); } }
        public IField SC_MARK_ERROR { get { return GetElementByName<IField>(Names.SC_MARK_ERROR); } }
        public IField SC_MARK_ERROR_NUM { get { return GetElementByName<IField>(Names.SC_MARK_ERROR_NUM); } }
        public IField SC_MARK_WARNING { get { return GetElementByName<IField>(Names.SC_MARK_WARNING); } }
        public IField SC_MARK_WARNING_NUM { get { return GetElementByName<IField>(Names.SC_MARK_WARNING_NUM); } }
        public IField SC_BRIGHT_UNPRO { get { return GetElementByName<IField>(Names.SC_BRIGHT_UNPRO); } }
        public IField SC_BRIGHT_UNPRO_NUM { get { return GetElementByName<IField>(Names.SC_BRIGHT_UNPRO_NUM); } }

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
               MODULE_VARIABLES.CreateNewField(Names.MV_POS, FieldType.CompShort, 4);
               MODULE_VARIABLES.CreateNewField(Names.MV_POS1, FieldType.CompShort, 4);
               MODULE_VARIABLES.CreateNewField(Names.MV_SAVE_ERROR, FieldType.CompShort, 4);
               MODULE_VARIABLES.CreateNewField(Names.MV_SAVE_WARNING, FieldType.CompShort, 4);
               IGroup MV_SAVE_HEADER_AREA_local = (IGroup)MODULE_VARIABLES.CreateNewGroup(Names.MV_SAVE_HEADER_AREA, (MV_SAVE_HEADER_AREA) =>
               {
                   MV_SAVE_HEADER_AREA.CreateNewField(Names.MV_MARK_LEN, FieldType.CompShort, 4);
               });
               MODULE_VARIABLES.CreateNewGroupRedefine(Names.MV_SAVE_HEADER_REDF, MV_SAVE_HEADER_AREA_local, (MV_SAVE_HEADER_REDF) =>
               {
                   MV_SAVE_HEADER_REDF.CreateNewFieldArray(Names.MV_MARK, 2, FieldType.String, 1);
               });
           });

            recordDef.CreateNewGroup(Names.SYSTEM_CONSTANTS, (SYSTEM_CONSTANTS) =>
           {
               SYSTEM_CONSTANTS.CreateNewField(Names.SC_SET_CURSOR, FieldType.CompShort, 4, -1);
               SYSTEM_CONSTANTS.CreateNewField(Names.SC_MARK_ERROR, FieldType.CompShort, 4, -5);
               SYSTEM_CONSTANTS.CreateNewField(Names.SC_MARK_ERROR_NUM, FieldType.CompShort, 4, -6);
               SYSTEM_CONSTANTS.CreateNewField(Names.SC_MARK_WARNING, FieldType.CompShort, 4, -7);
               SYSTEM_CONSTANTS.CreateNewField(Names.SC_MARK_WARNING_NUM, FieldType.CompShort, 4, -8);
               SYSTEM_CONSTANTS.CreateNewField(Names.SC_BRIGHT_UNPRO, FieldType.String, 1, "H");
               SYSTEM_CONSTANTS.CreateNewField(Names.SC_BRIGHT_UNPRO_NUM, FieldType.String, 1, "Q");
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
    internal class SWASZ032_ls : PredefinedRecordBase
    {
        #region Name constants
        /// <summary>
        /// Name constants.
        /// </summary>
        internal static class Names
        {
            internal const string LinkageSection = "SWASZ032_ls_LinkageSection";
            internal const string PV_SAVE_SCREEN = "PV_SAVE_SCREEN";
            internal const string PV_SAVE_CHAR = "PV_SAVE_CHAR";
            internal const string PV_LENGTH = "PV_LENGTH";
        }
        #endregion

        #region Direct-access element properties
        public IGroup PV_SAVE_SCREEN { get { return GetElementByName<IGroup>(Names.PV_SAVE_SCREEN); } }
        public IArrayElementAccessor<IField> PV_SAVE_CHAR { get { return GetArrayElementAccessor<IField>(Names.PV_SAVE_CHAR); } }
        public IField PV_LENGTH { get { return GetElementByName<IField>(Names.PV_LENGTH); } }

        #endregion

        #region Data structure definition
        /// <summary>
        /// Defines the entirety of the LinkageSection IRecord structure as described by the Ateras.Framework.Buffer API.
        /// </summary>
        /// <param name="recordDef">The IStructureDefinition object to be used in defining the record structure.</param>
        protected override void DefineRecordStructure(IStructureDefinition recordDef)
        {

            recordDef.CreateNewGroup(Names.PV_SAVE_SCREEN, (PV_SAVE_SCREEN) =>
           {
               PV_SAVE_SCREEN.CreateNewFieldArray(Names.PV_SAVE_CHAR, 4000, FieldType.String, 1);
           });
            recordDef.CreateNewField(Names.PV_LENGTH, FieldType.CompShort, 4);

        }

        protected override string GetRecordName()
        {
            return Names.LinkageSection;
        }
        #endregion

        public void SetPassedParameters(object[] args)
        {
            SetPassedParm(PV_SAVE_SCREEN, args, 0);
            SetPassedParm(PV_LENGTH, args, 1);
        }


        public void UpdateReturnParameters(object[] args)
        {
            SetReturnParm(PV_SAVE_SCREEN, args, 0);
            SetReturnParm(PV_LENGTH, args, 1);
        }
    }
    #endregion Linkage Section Class

    #region Business Logic Class
    public class SWASZ032 : BatchBase
    {

        #region Public Constructors
        public SWASZ032()
            : base()
        {
            this.ProgramName.SetValue("SWASZ032");

            WS = new SWASZ032_ws();
            LS = new SWASZ032_ls();
        }

        #endregion

        #region Private Fields


        //==== Working Storage Data Class ========================================
        private SWASZ032_ws WS;

        //==== Linkage Section Data Class ========================================
        private SWASZ032_ls LS;
        #endregion

        #region Public Methods
        //========================================================================
        //==== RunMain Entry Point Method ========================================
        //========================================================================
        public override int ExecuteMain(params object[] args)                                              //COBOL==> PROCEDURE DIVISION USING PV-SAVE-SCREEN PV-LENGTH.
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
            WS.MV_POS.SetValue(13);                                                                             //COBOL==> MOVE 13 TO MV-POS.
            WS.MV_SAVE_ERROR.SetValueWithZeroes();                                                              //COBOL==> MOVE ZERO TO MV-SAVE-ERROR MV-SAVE-WARNING.
            WS.MV_SAVE_WARNING.SetValueWithZeroes();
            M_2000_FIND_MARKED_FIELD("M_2000_EXIT"); if (Control.ExitProgram) { return; }                         //COBOL==> PERFORM 2000-FIND-MARKED-FIELD THRU 2000-EXIT.
            while (!(WS.MV_POS.IsGreaterThan(LS.PV_LENGTH)))                                                    //COBOL==> PERFORM 1000-SET-ATTRS THRU 1000-EXIT UNTIL MV-POS > PV-LENGTH.
            {
                M_1000_SET_ATTRS("M_1000_EXIT"); if (Control.ExitProgram) { return; }
            }
            WS.MV_MARK_LEN.SetValue(WS.SC_SET_CURSOR);                                                          //COBOL==> MOVE SC-SET-CURSOR TO MV-MARK-LEN.
            if (!(WS.MV_SAVE_ERROR.IsEqualTo(0)))                                                               //COBOL==> IF MV-SAVE-ERROR NOT = ZERO
            {
                LS.PV_SAVE_CHAR[WS.MV_SAVE_ERROR.AsInt()].SetValue(WS.MV_MARK[2]);                                  //COBOL==> MOVE MV-MARK ( 2 ) TO PV-SAVE-CHAR ( MV-SAVE-ERROR )
            }                                                                                                   //COBOL==> ELSE
            else
            {
                if (!(WS.MV_SAVE_WARNING.IsEqualTo(0)))                                                             //COBOL==> IF MV-SAVE-WARNING NOT = ZERO
                {
                    LS.PV_SAVE_CHAR[WS.MV_SAVE_WARNING.AsInt()].SetValue(WS.MV_MARK[2]);                                //COBOL==> MOVE MV-MARK ( 2 ) TO PV-SAVE-CHAR ( MV-SAVE-WARNING ) .
                }
            }
            // Execute Procedure Division Logic
            M_0000_EXIT("M_1000_EXIT");
        }
        /// <summary>
        /// Method M_0000_EXIT
        /// </summary>
        private void M_0000_EXIT(string returnMethod = "")
        {
            Control.ExitProgram = true; return;                                                                 //COBOL==> GOBACK.
        }
        /// <summary>
        /// Method M_1000_SET_ATTRS
        /// </summary>
        private void M_1000_SET_ATTRS(string returnMethod = "")
        {
            for (WS.MV_POS1.SetValue(1); (!(WS.MV_POS1.IsGreaterThan(2))); WS.MV_POS1.Add(1))                  //COBOL==> PERFORM 3000-GET-HEADER-INFO THRU 3000-EXIT VARYING MV-POS1 FROM 1 BY 1 UNTIL MV-POS1 > 2.
            {
                M_3000_GET_HEADER_INFO("M_3000_EXIT"); if (Control.ExitProgram) { return; }
            }
            WS.MV_POS1.SetComputeValue(WS.MV_POS.AsDecimal() - 1m);                                             //COBOL==> COMPUTE MV-POS1 = MV-POS - 1.
            if (WS.MV_MARK_LEN.IsEqualTo(WS.SC_SET_CURSOR))                                                     //COBOL==> IF MV-MARK-LEN = SC-SET-CURSOR
            {
                WS.MV_SAVE_ERROR.SetValue(WS.MV_POS1);                                                              //COBOL==> MOVE MV-POS1 TO MV-SAVE-ERROR
                M_1000_END_CASE(CheckGotoReturn(returnMethod)); return;                                             //COBOL==> GO TO 1000-END-CASE.
            }
            if (WS.MV_MARK_LEN.IsEqualTo(WS.SC_MARK_ERROR))                                                     //COBOL==> IF MV-MARK-LEN = SC-MARK-ERROR
            {
                LS.PV_SAVE_CHAR[WS.MV_POS.AsInt()].SetValue(WS.SC_BRIGHT_UNPRO);                                    //COBOL==> MOVE SC-BRIGHT-UNPRO TO PV-SAVE-CHAR ( MV-POS )
                if (WS.MV_SAVE_ERROR.IsEqualTo(0))                                                                  //COBOL==> IF MV-SAVE-ERROR = ZERO
                {
                    WS.MV_SAVE_ERROR.SetValue(WS.MV_POS1);                                                              //COBOL==> MOVE MV-POS1 TO MV-SAVE-ERROR
                    M_1000_END_CASE(CheckGotoReturn(returnMethod)); return;                                             //COBOL==> GO TO 1000-END-CASE
                }                                                                                                   //COBOL==> ELSE
                else
                {
                    M_1000_END_CASE(CheckGotoReturn(returnMethod)); return;                                             //COBOL==> GO TO 1000-END-CASE.
                }
            }
            if (WS.MV_MARK_LEN.IsEqualTo(WS.SC_MARK_ERROR_NUM))                                                 //COBOL==> IF MV-MARK-LEN = SC-MARK-ERROR-NUM
            {
                LS.PV_SAVE_CHAR[WS.MV_POS.AsInt()].SetValue(WS.SC_BRIGHT_UNPRO_NUM);                                //COBOL==> MOVE SC-BRIGHT-UNPRO-NUM TO PV-SAVE-CHAR ( MV-POS )
                if (WS.MV_SAVE_ERROR.IsEqualTo(0))                                                                  //COBOL==> IF MV-SAVE-ERROR = ZERO
                {
                    WS.MV_SAVE_ERROR.SetValue(WS.MV_POS1);                                                              //COBOL==> MOVE MV-POS1 TO MV-SAVE-ERROR
                    M_1000_END_CASE(CheckGotoReturn(returnMethod)); return;                                             //COBOL==> GO TO 1000-END-CASE
                }                                                                                                   //COBOL==> ELSE
                else
                {
                    M_1000_END_CASE(CheckGotoReturn(returnMethod)); return;                                             //COBOL==> GO TO 1000-END-CASE.
                }
            }
            if (WS.MV_MARK_LEN.IsEqualTo(WS.SC_MARK_WARNING))                                                   //COBOL==> IF MV-MARK-LEN = SC-MARK-WARNING
            {
                LS.PV_SAVE_CHAR[WS.MV_POS.AsInt()].SetValue(WS.SC_BRIGHT_UNPRO);                                    //COBOL==> MOVE SC-BRIGHT-UNPRO TO PV-SAVE-CHAR ( MV-POS )
                if (WS.MV_SAVE_WARNING.IsEqualTo(0))                                                                //COBOL==> IF MV-SAVE-WARNING = ZERO
                {
                    WS.MV_SAVE_WARNING.SetValue(WS.MV_POS1);                                                            //COBOL==> MOVE MV-POS1 TO MV-SAVE-WARNING
                    M_1000_END_CASE(CheckGotoReturn(returnMethod)); return;                                             //COBOL==> GO TO 1000-END-CASE
                }                                                                                                   //COBOL==> ELSE
                else
                {
                    M_1000_END_CASE(CheckGotoReturn(returnMethod)); return;                                             //COBOL==> GO TO 1000-END-CASE.
                }
            }
            if (WS.MV_MARK_LEN.IsEqualTo(WS.SC_MARK_WARNING_NUM))                                               //COBOL==> IF MV-MARK-LEN = SC-MARK-WARNING-NUM
            {
                LS.PV_SAVE_CHAR[WS.MV_POS.AsInt()].SetValue(WS.SC_BRIGHT_UNPRO_NUM);                                //COBOL==> MOVE SC-BRIGHT-UNPRO-NUM TO PV-SAVE-CHAR ( MV-POS )
                if (WS.MV_SAVE_WARNING.IsEqualTo(0))                                                                //COBOL==> IF MV-SAVE-WARNING = ZERO
                {
                    WS.MV_SAVE_WARNING.SetValue(WS.MV_POS1);                                                            //COBOL==> MOVE MV-POS1 TO MV-SAVE-WARNING.
                }
            }
            if (returnMethod != "" && returnMethod != "M_1000_SET_ATTRS") { M_1000_END_CASE(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_1000_END_CASE
        /// </summary>
        private void M_1000_END_CASE(string returnMethod = "")
        {
            M_2000_FIND_MARKED_FIELD("M_2000_EXIT"); if (Control.ExitProgram) { return; }                         //COBOL==> PERFORM 2000-FIND-MARKED-FIELD THRU 2000-EXIT.
            if (returnMethod != "" && returnMethod != "M_1000_END_CASE") { M_1000_EXIT(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_1000_EXIT
        /// </summary>
        private void M_1000_EXIT(string returnMethod = "")
        {
            if (returnMethod != "" && returnMethod != "M_1000_EXIT") { M_2000_FIND_MARKED_FIELD(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_2000_FIND_MARKED_FIELD
        /// </summary>
        private void M_2000_FIND_MARKED_FIELD(string returnMethod = "")
        {
            while (!((WS.MV_POS.IsGreaterThan(LS.PV_LENGTH)) || (LS.PV_SAVE_CHAR[WS.MV_POS.AsInt()].IsEqualTo(HIGH_VALUES))))  //COBOL==> PERFORM 2100-CHECK-CHARS THRU 2100-EXIT UNTIL MV-POS > PV-LENGTH OR PV-SAVE-CHAR ( MV-POS ) = HIGH-VALUES.
            {
                M_2100_CHECK_CHARS("M_2100_EXIT"); if (Control.ExitProgram) { return; }
            }
            if (returnMethod != "" && returnMethod != "M_2000_FIND_MARKED_FIELD") { M_2000_EXIT(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_2000_EXIT
        /// </summary>
        private void M_2000_EXIT(string returnMethod = "")
        {
            if (returnMethod != "" && returnMethod != "M_2000_EXIT") { M_2100_CHECK_CHARS(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_2100_CHECK_CHARS
        /// </summary>
        private void M_2100_CHECK_CHARS(string returnMethod = "")
        {
            WS.MV_POS.Add(1);                                                                                   //COBOL==> ADD 1 TO MV-POS.
            if (returnMethod != "" && returnMethod != "M_2100_CHECK_CHARS") { M_2100_EXIT(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_2100_EXIT
        /// </summary>
        private void M_2100_EXIT(string returnMethod = "")
        {
            if (returnMethod != "" && returnMethod != "M_2100_EXIT") { M_3000_GET_HEADER_INFO(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_3000_GET_HEADER_INFO
        /// </summary>
        private void M_3000_GET_HEADER_INFO(string returnMethod = "")
        {
            WS.MV_MARK[WS.MV_POS1.AsInt()].SetValue(LS.PV_SAVE_CHAR[WS.MV_POS.AsInt()]);                        //COBOL==> MOVE PV-SAVE-CHAR ( MV-POS ) TO MV-MARK ( MV-POS1 ) .
            WS.MV_POS.Add(1);                                                                                   //COBOL==> ADD 1 TO MV-POS.
            if (returnMethod != "" && returnMethod != "M_3000_GET_HEADER_INFO") { M_3000_EXIT(returnMethod); }  //Check for pass through to next method
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
