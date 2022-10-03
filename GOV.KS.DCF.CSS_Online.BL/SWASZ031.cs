#region Comments
/* Conversion Comments
   ************************************************************
   **   MODERN SYSTEMS INC.  COPYRIGHT 2000-2022
   **   DB-SHUTTLE COBOL to C# Conversion
   ************************************************************
   ** INIT   *  INITIAL VERSION   *  2022-01-14 12:46:17 PM
   **        *   FROM COBOL PGM   :  SWASZ031
   **        *   FROM CANISTER    :  SR.CAECSES.PROD.LIBR.SOURCE.PDS
   ************************************************************ */

/* Original Program Identification Comments
   DATE-COMPILED.
   
   
   **** START DOCUMENTATION ****************************************
   *                                                              **
   *    SYSTEM:  CAECSES  - AUTOMATED ELIGIBILITY                 **
   *                                                              **
   *    PROGRAM: SWASZ031 - CLEAR SCREEN ATTRIBUTES               **
   *                                                              **
   *    DESCRIPTION:                                              **
   *        THIS PROGRAM RESETS SCREEN ATTRIBUTES.                **
   *                                                              **
   *    PROCESSING:                                               **
   *        THIS MODULE ACCEPTS PARAMETERS FROM THE CALLING       **
   *        MODULE AND RESETS THE SCREEN, FIELD ATTRIBUTES TO     **
   *        THEIR ORIGINAL VALUES.                                **
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
   
   
   
   **** START MAINTENANCE LOG ************ PROGRAM SWASZ031 ********
   *                                                              **
   *    MAINTENANCE LOG                                           **
   *        AUTHOR     DATE    CHG REQ #  DESCRIPTION             **
   *                                                              **
   **** END MAINTENANCE LOG ****************************************
   CTA MODIFICATION
   NO CHANGES FOR Y2K     CTA  Y2K   SRS
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
#endregion

namespace GOV.KS.DCF.CSS.Online.BL
{
    #region Working Storage Class
    internal class SWASZ031_ws : PredefinedRecordBase
    {
        #region Name constants
        /// <summary>
        /// Name constants.
        /// </summary>
        internal static class Names
        {
            internal const string WorkingStorage = "SWASZ031_ws_WorkingStorage";
            internal const string MODULE_VARIABLES = "MODULE_VARIABLES";
            internal const string MV_POS = "MV_POS";
            internal const string MV_POS1 = "MV_POS1";
            internal const string MV_SAVE_HEADER_AREA = "MV_SAVE_HEADER_AREA";
            internal const string MV_MARK_LEN = "MV_MARK_LEN";
            internal const string MV_ATTRIBUTE = "MV_ATTRIBUTE";
            internal const string MV_SAVE_HEADER_REDF = "MV_SAVE_HEADER_REDF";
            internal const string MV_MARK = "MV_MARK";
            internal const string SYSTEM_CONSTANTS = "SYSTEM_CONSTANTS";
            internal const string SC_MARK_OUTPUT = "SC_MARK_OUTPUT";
            internal const string SC_NORMAL_UNPRO = "SC_NORMAL_UNPRO";
            internal const string SC_NORMAL_UNPRO_NUM = "SC_NORMAL_UNPRO_NUM";
            internal const string SC_BRIGHT_UNPRO = "SC_BRIGHT_UNPRO";
            internal const string SC_BRIGHT_UNPRO_NUM = "SC_BRIGHT_UNPRO_NUM";
        }
        #endregion

        #region Direct-access element properties
        public IGroup MODULE_VARIABLES { get { return GetElementByName<IGroup>(Names.MODULE_VARIABLES); } }
        public IField MV_POS { get { return GetElementByName<IField>(Names.MV_POS); } }
        public IField MV_POS1 { get { return GetElementByName<IField>(Names.MV_POS1); } }
        public IGroup MV_SAVE_HEADER_AREA { get { return GetElementByName<IGroup>(Names.MV_SAVE_HEADER_AREA); } }
        public IField MV_MARK_LEN { get { return GetElementByName<IField>(Names.MV_MARK_LEN); } }
        public IField MV_ATTRIBUTE { get { return GetElementByName<IField>(Names.MV_ATTRIBUTE); } }
        public IGroup MV_SAVE_HEADER_REDF { get { return GetElementByName<IGroup>(Names.MV_SAVE_HEADER_REDF); } }
        public IArrayElementAccessor<IField> MV_MARK { get { return GetArrayElementAccessor<IField>(Names.MV_MARK); } }
        public IGroup SYSTEM_CONSTANTS { get { return GetElementByName<IGroup>(Names.SYSTEM_CONSTANTS); } }
        public IField SC_MARK_OUTPUT { get { return GetElementByName<IField>(Names.SC_MARK_OUTPUT); } }
        public IField SC_NORMAL_UNPRO { get { return GetElementByName<IField>(Names.SC_NORMAL_UNPRO); } }
        public IField SC_NORMAL_UNPRO_NUM { get { return GetElementByName<IField>(Names.SC_NORMAL_UNPRO_NUM); } }
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
               IGroup MV_SAVE_HEADER_AREA_local = (IGroup)MODULE_VARIABLES.CreateNewGroup(Names.MV_SAVE_HEADER_AREA, (MV_SAVE_HEADER_AREA) =>
               {
                   MV_SAVE_HEADER_AREA.CreateNewField(Names.MV_MARK_LEN, FieldType.CompShort, 4);
                   MV_SAVE_HEADER_AREA.CreateNewField(Names.MV_ATTRIBUTE, FieldType.String, 1);
               });
               MODULE_VARIABLES.CreateNewGroupRedefine(Names.MV_SAVE_HEADER_REDF, MV_SAVE_HEADER_AREA_local, (MV_SAVE_HEADER_REDF) =>
               {
                   MV_SAVE_HEADER_REDF.CreateNewFieldArray(Names.MV_MARK, 3, FieldType.String, 1);
               });
           });

            recordDef.CreateNewGroup(Names.SYSTEM_CONSTANTS, (SYSTEM_CONSTANTS) =>
           {
               SYSTEM_CONSTANTS.CreateNewField(Names.SC_MARK_OUTPUT, FieldType.CompShort, 4, -4);
               SYSTEM_CONSTANTS.CreateNewField(Names.SC_NORMAL_UNPRO, FieldType.String, 1, "D");
               SYSTEM_CONSTANTS.CreateNewField(Names.SC_NORMAL_UNPRO_NUM, FieldType.String, 1, "M");
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
    internal class SWASZ031_ls : PredefinedRecordBase
    {
        #region Name constants
        /// <summary>
        /// Name constants.
        /// </summary>
        internal static class Names
        {
            internal const string LinkageSection = "SWASZ031_ls_LinkageSection";
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
    public class SWASZ031 : BatchBase
    {

        #region Public Constructors
        public SWASZ031()
            : base()
        {
            this.ProgramName.SetValue("SWASZ031");

            WS = new SWASZ031_ws();
            LS = new SWASZ031_ls();
        }

        #endregion

        #region Private Fields


        //==== Working Storage Data Class ========================================
        private SWASZ031_ws WS;

        //==== Linkage Section Data Class ========================================
        private SWASZ031_ls LS;
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
            // Execute Procedure Division Logic
            M_0000_MAIN_LOGIC(returnMethod);
        }
        /// <summary>
        /// Method M_0000_MAIN_LOGIC
        /// </summary>
        private void M_0000_MAIN_LOGIC(string returnMethod = "")
        {
            WS.MV_POS.SetValue(13);                                                                             //COBOL==> MOVE 13 TO MV-POS.
            M_2000_FIND_MARKED_FIELD("M_2000_EXIT"); if (Control.ExitProgram) { return; }                         //COBOL==> PERFORM 2000-FIND-MARKED-FIELD THRU 2000-EXIT.
            while (!(WS.MV_POS.IsGreaterThan(LS.PV_LENGTH)))                                                    //COBOL==> PERFORM 1000-CLEAR-ATTRS THRU 1000-EXIT UNTIL MV-POS > PV-LENGTH.
            {
                M_1000_CLEAR_ATTRS("M_1000_EXIT"); if (Control.ExitProgram) { return; }
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
        /// Method M_1000_CLEAR_ATTRS
        /// </summary>
        private void M_1000_CLEAR_ATTRS(string returnMethod = "")
        {
            for (WS.MV_POS1.SetValue(1); (!(WS.MV_POS1.IsGreaterThan(3))); WS.MV_POS1.Add(1))                  //COBOL==> PERFORM 3000-GET-HEADER-INFO THRU 3000-EXIT VARYING MV-POS1 FROM 1 BY 1 UNTIL MV-POS1 > 3.
            {
                M_3000_GET_HEADER_INFO("M_3000_EXIT"); if (Control.ExitProgram) { return; }
            }
            WS.MV_POS1.SetComputeValue(WS.MV_POS.AsDecimal() - 1m);                                             //COBOL==> COMPUTE MV-POS1 = MV-POS - 1.
            if (!(WS.MV_MARK_LEN.IsEqualTo(WS.SC_MARK_OUTPUT)))                                                 //COBOL==> IF MV-MARK-LEN NOT = SC-MARK-OUTPUT
            {
                if (WS.MV_ATTRIBUTE.IsEqualTo(WS.SC_BRIGHT_UNPRO_NUM))                                              //COBOL==> IF MV-ATTRIBUTE = SC-BRIGHT-UNPRO-NUM
                {
                    LS.PV_SAVE_CHAR[WS.MV_POS1.AsInt()].SetValue(WS.SC_NORMAL_UNPRO_NUM);                               //COBOL==> MOVE SC-NORMAL-UNPRO-NUM TO PV-SAVE-CHAR ( MV-POS1 )
                }                                                                                                   //COBOL==> ELSE
                else
                {
                    if (WS.MV_ATTRIBUTE.IsEqualTo(WS.SC_BRIGHT_UNPRO))                                                  //COBOL==> IF MV-ATTRIBUTE = SC-BRIGHT-UNPRO
                    {
                        LS.PV_SAVE_CHAR[WS.MV_POS1.AsInt()].SetValue(WS.SC_NORMAL_UNPRO);                                   //COBOL==> MOVE SC-NORMAL-UNPRO TO PV-SAVE-CHAR ( MV-POS1 ) .
                    }
                }
            }
            M_2000_FIND_MARKED_FIELD("M_2000_EXIT"); if (Control.ExitProgram) { return; }                         //COBOL==> PERFORM 2000-FIND-MARKED-FIELD THRU 2000-EXIT.
            if (returnMethod != "" && returnMethod != "M_1000_CLEAR_ATTRS") { M_1000_EXIT(returnMethod); }  //Check for pass through to next method
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
