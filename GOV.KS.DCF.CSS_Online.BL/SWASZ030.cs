#region Comments
/* Conversion Comments
   ************************************************************
   **   MODERN SYSTEMS INC.  COPYRIGHT 2000-2022
   **   DB-SHUTTLE COBOL to C# Conversion
   ************************************************************
   ** INIT   *  INITIAL VERSION   *  2022-01-14 12:46:16 PM
   **        *   FROM COBOL PGM   :  SWASZ030
   **        *   FROM CANISTER    :  SR.CAECSES.PROD.LIBR.SOURCE.PDS
   ************************************************************ */

/* Original Program Identification Comments
   DATE-COMPILED.
   
   
   **** START DOCUMENTATION ****************************************
   *                                                              **
   *    SYSTEM:  CAECSES  - AUTOMATED ELIGIBILITY                 **
   *                                                              **
   *    PROGRAM: SWASZ030 - MERGE SCREENS                         **
   *                                                              **
   *    DESCRIPTION:                                              **
   *        THIS PROGRAM MERGES SENT & RECEIVED SCREENS.          **
   *                                                              **
   *    PROCESSING:                                               **
   *        THIS MODULE ACCEPTS PARAMETERS FROM THE CALLING       **
   *        MODULE AND MERGES THE "SENT" VERSION OF THE SCREEN    **
   *        WITH THE "RECEIVED" VERSION OF THE SCREEN.            **
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
   
   
   
   **** START MAINTENANCE LOG ************ PROGRAM SWASZ030 ********
   *                                                              **
   *    MAINTENANCE LOG                                           **
   *        AUTHOR     DATE    CHG REQ #  DESCRIPTION             **
   *                                                              **
   **** END MAINTENANCE LOG ****************************************
   
   ----------------------------------------------------------------*
    CTA MODIFICATION   NOVEMBER 3, 1997                            *
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
     NO SPECS FOUND FOR THIS PROGRAM.
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
    internal class SWASZ030_ws : PredefinedRecordBase
    {
        #region Name constants
        /// <summary>
        /// Name constants.
        /// </summary>
        internal static class Names
        {
            internal const string WorkingStorage = "SWASZ030_ws_WorkingStorage";
            internal const string MODULE_VARIABLES = "MODULE_VARIABLES";
            internal const string MV_POS = "MV_POS";
            internal const string MV_POS1 = "MV_POS1";
            internal const string MV_HEADER_AREA = "MV_HEADER_AREA";
            internal const string MV_HEADER = "MV_HEADER";
            internal const string MV_HEADER_REDF = "MV_HEADER_REDF";
            internal const string MV_LEN = "MV_LEN";
            internal const string MV_FLAG = "MV_FLAG";
            internal const string MV_SAVE_HEADER_AREA = "MV_SAVE_HEADER_AREA";
            internal const string MV_MARK_LEN = "MV_MARK_LEN";
            internal const string MV_SAVE_HEADER_REDF = "MV_SAVE_HEADER_REDF";
            internal const string MV_MARK = "MV_MARK";
            internal const string SYSTEM_CONSTANTS = "SYSTEM_CONSTANTS";
            internal const string SC_MARK_UNCHANGED = "SC_MARK_UNCHANGED";
            internal const string SC_MARK_CHANGE = "SC_MARK_CHANGE";
            internal const string SC_MARK_OUTPUT = "SC_MARK_OUTPUT";
            internal const string SC_MARK_MERGE_ONLY = "SC_MARK_MERGE_ONLY";
            internal const string IX_SCREEN = "IX_SCREEN";
            internal const string IX_SAVE = "IX_SAVE";
        }
        #endregion

        #region Direct-access element properties
        public IGroup MODULE_VARIABLES { get { return GetElementByName<IGroup>(Names.MODULE_VARIABLES); } }
        public IField MV_POS { get { return GetElementByName<IField>(Names.MV_POS); } }
        public IField MV_POS1 { get { return GetElementByName<IField>(Names.MV_POS1); } }
        public IGroup MV_HEADER_AREA { get { return GetElementByName<IGroup>(Names.MV_HEADER_AREA); } }
        public IArrayElementAccessor<IField> MV_HEADER { get { return GetArrayElementAccessor<IField>(Names.MV_HEADER); } }
        public IGroup MV_HEADER_REDF { get { return GetElementByName<IGroup>(Names.MV_HEADER_REDF); } }
        public IField MV_LEN { get { return GetElementByName<IField>(Names.MV_LEN); } }
        public IField MV_FLAG { get { return GetElementByName<IField>(Names.MV_FLAG); } }
        public IGroup MV_SAVE_HEADER_AREA { get { return GetElementByName<IGroup>(Names.MV_SAVE_HEADER_AREA); } }
        public IField MV_MARK_LEN { get { return GetElementByName<IField>(Names.MV_MARK_LEN); } }
        public IGroup MV_SAVE_HEADER_REDF { get { return GetElementByName<IGroup>(Names.MV_SAVE_HEADER_REDF); } }
        public IArrayElementAccessor<IField> MV_MARK { get { return GetArrayElementAccessor<IField>(Names.MV_MARK); } }
        public IGroup SYSTEM_CONSTANTS { get { return GetElementByName<IGroup>(Names.SYSTEM_CONSTANTS); } }
        public IField SC_MARK_UNCHANGED { get { return GetElementByName<IField>(Names.SC_MARK_UNCHANGED); } }
        public IField SC_MARK_CHANGE { get { return GetElementByName<IField>(Names.SC_MARK_CHANGE); } }
        public IField SC_MARK_OUTPUT { get { return GetElementByName<IField>(Names.SC_MARK_OUTPUT); } }
        public IField SC_MARK_MERGE_ONLY { get { return GetElementByName<IField>(Names.SC_MARK_MERGE_ONLY); } }
        public IField IX_SCREEN { get { return GetElementByName<IField>(Names.IX_SCREEN); } }
        public IField IX_SAVE { get { return GetElementByName<IField>(Names.IX_SAVE); } }

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
               MODULE_VARIABLES.CreateNewField(Names.MV_POS, FieldType.CompInt, 8);
               MODULE_VARIABLES.CreateNewField(Names.MV_POS1, FieldType.CompInt, 8);
               IGroup MV_HEADER_AREA_local = (IGroup)MODULE_VARIABLES.CreateNewGroup(Names.MV_HEADER_AREA, (MV_HEADER_AREA) =>
               {
                   MV_HEADER_AREA.CreateNewFieldArray(Names.MV_HEADER, 3, FieldType.String, 1);
               });
               MODULE_VARIABLES.CreateNewGroupRedefine(Names.MV_HEADER_REDF, MV_HEADER_AREA_local, (MV_HEADER_REDF) =>
               {
                   MV_HEADER_REDF.CreateNewField(Names.MV_LEN, FieldType.CompShort, 4);
                   MV_HEADER_REDF.CreateNewField(Names.MV_FLAG, FieldType.String, 1);
               });
               IGroup MV_SAVE_HEADER_AREA_local = (IGroup)MODULE_VARIABLES.CreateNewGroup(Names.MV_SAVE_HEADER_AREA, (MV_SAVE_HEADER_AREA) =>
               {
                   MV_SAVE_HEADER_AREA.CreateNewField(Names.MV_MARK_LEN, FieldType.CompShort, 4);
                   MV_SAVE_HEADER_AREA.CreateNewFillerField(1, FillWith.Hashes);
               });
               MODULE_VARIABLES.CreateNewGroupRedefine(Names.MV_SAVE_HEADER_REDF, MV_SAVE_HEADER_AREA_local, (MV_SAVE_HEADER_REDF) =>
               {
                   MV_SAVE_HEADER_REDF.CreateNewFieldArray(Names.MV_MARK, 3, FieldType.String, 1);
               });
           });

            recordDef.CreateNewGroup(Names.SYSTEM_CONSTANTS, (SYSTEM_CONSTANTS) =>
           {
               SYSTEM_CONSTANTS.CreateNewField(Names.SC_MARK_UNCHANGED, FieldType.CompShort, 4, -2);
               SYSTEM_CONSTANTS.CreateNewField(Names.SC_MARK_CHANGE, FieldType.CompShort, 4, -3);
               SYSTEM_CONSTANTS.CreateNewField(Names.SC_MARK_OUTPUT, FieldType.CompShort, 4, -4);
               SYSTEM_CONSTANTS.CreateNewField(Names.SC_MARK_MERGE_ONLY, FieldType.CompShort, 4, -9);
           });
            recordDef.CreateNewField(Names.IX_SCREEN, FieldType.CompShort, 4);
            recordDef.CreateNewField(Names.IX_SAVE, FieldType.CompShort, 4);

        }

        protected override string GetRecordName()
        {
            return Names.WorkingStorage;
        }
        #endregion

    }
    #endregion Working Storage Class

    #region Linkage Section Class
    internal class SWASZ030_ls : PredefinedRecordBase
    {
        #region Name constants
        /// <summary>
        /// Name constants.
        /// </summary>
        internal static class Names
        {
            internal const string LinkageSection = "SWASZ030_ls_LinkageSection";
            internal const string PV_SCREEN = "PV_SCREEN";
            internal const string PV_SCREEN_CHAR = "PV_SCREEN_CHAR";
            internal const string PV_SAVE_SCREEN = "PV_SAVE_SCREEN";
            internal const string PV_SAVE_CHAR = "PV_SAVE_CHAR";
            internal const string PV_LENGTH = "PV_LENGTH";
            internal const string PV_CHANGED = "PV_CHANGED";
        }
        #endregion

        #region Direct-access element properties
        public IGroup PV_SCREEN { get { return GetElementByName<IGroup>(Names.PV_SCREEN); } }
        public IArrayElementAccessor<IField> PV_SCREEN_CHAR { get { return GetArrayElementAccessor<IField>(Names.PV_SCREEN_CHAR); } }
        public IGroup PV_SAVE_SCREEN { get { return GetElementByName<IGroup>(Names.PV_SAVE_SCREEN); } }
        public IArrayElementAccessor<IField> PV_SAVE_CHAR { get { return GetArrayElementAccessor<IField>(Names.PV_SAVE_CHAR); } }
        public IField PV_LENGTH { get { return GetElementByName<IField>(Names.PV_LENGTH); } }
        public IField PV_CHANGED { get { return GetElementByName<IField>(Names.PV_CHANGED); } }

        #endregion

        #region Data structure definition
        /// <summary>
        /// Defines the entirety of the LinkageSection IRecord structure as described by the Ateras.Framework.Buffer API.
        /// </summary>
        /// <param name="recordDef">The IStructureDefinition object to be used in defining the record structure.</param>
        protected override void DefineRecordStructure(IStructureDefinition recordDef)
        {

            recordDef.CreateNewGroup(Names.PV_SCREEN, (PV_SCREEN) =>
           {
               PV_SCREEN.CreateNewFieldArray(Names.PV_SCREEN_CHAR, 4000, FieldType.String, 1);
           });

            recordDef.CreateNewGroup(Names.PV_SAVE_SCREEN, (PV_SAVE_SCREEN) =>
           {
               PV_SAVE_SCREEN.CreateNewFieldArray(Names.PV_SAVE_CHAR, 4000, FieldType.String, 1);
           });
            recordDef.CreateNewField(Names.PV_LENGTH, FieldType.CompShort, 4);
            recordDef.CreateNewField(Names.PV_CHANGED, FieldType.String, 1);

        }

        protected override string GetRecordName()
        {
            return Names.LinkageSection;
        }
        #endregion

        public void SetPassedParameters(object[] args)
        {
            SetPassedParm(PV_SCREEN, args, 0);
            SetPassedParm(PV_SAVE_SCREEN, args, 1);
            SetPassedParm(PV_LENGTH, args, 2);
            SetPassedParm(PV_CHANGED, args, 3);
        }


        public void UpdateReturnParameters(object[] args)
        {
            SetReturnParm(PV_SCREEN, args, 0);
            SetReturnParm(PV_SAVE_SCREEN, args, 1);
            SetReturnParm(PV_LENGTH, args, 2);
            SetReturnParm(PV_CHANGED, args, 3);
        }
    }
    #endregion Linkage Section Class

    #region Business Logic Class
    public class SWASZ030 : BatchBase
    {

        #region Public Constructors
        public SWASZ030()
            : base()
        {
            this.ProgramName.SetValue("SWASZ030");

            WS = new SWASZ030_ws();
            LS = new SWASZ030_ls();
        }

        #endregion

        #region Private Fields


        //==== Working Storage Data Class ========================================
        private SWASZ030_ws WS;

        //==== Linkage Section Data Class ========================================
        private SWASZ030_ls LS;
        #endregion

        #region Public Methods
        //========================================================================
        //==== RunMain Entry Point Method ========================================
        //========================================================================
        public override int ExecuteMain(params object[] args)                                              //COBOL==> PROCEDURE DIVISION USING PV-SCREEN PV-SAVE-SCREEN PV-LENGTH PV-CHANGED.
        {
            try
            {
                WS.Initialize();
                LS.SetPassedParameters(args);
                RunMain(string.Empty, "Main");
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

        protected override void RunMain(string startLabel, string returnLbl)
        {
            #region Perform Navigation
            string returnLabel = returnLbl;
            switch (startLabel)
            {
                case "2000-FIND-MARKED-FIELD": goto L_2000_FIND_MARKED_FIELD; break;
                case "1000-MERGE-FIELDS": goto L_1000_MERGE_FIELDS; break;
                case "4000-MARK-SAVE": goto L_4000_MARK_SAVE; break;
                case "4100-MOVE-TO-SAVE": goto L_4100_MOVE_TO_SAVE; break;
                default: break;
            }
            WS.MV_POS.SetValue(13);                                                                             //COBOL==> MOVE 13 TO MV-POS.
            LS.PV_CHANGED.SetValue("N");                                                                        //COBOL==> MOVE 'N' TO PV-CHANGED.
            Perform("2000-FIND-MARKED-FIELD", "2000-EXIT"); if (Control.ExitProgram) { return; }                  //COBOL==> PERFORM 2000-FIND-MARKED-FIELD THRU 2000-EXIT.
            while (!(WS.MV_POS.IsGreaterThan(LS.PV_LENGTH)))                                                    //COBOL==> PERFORM 1000-MERGE-FIELDS THRU 1000-EXIT UNTIL MV-POS > PV-LENGTH.
            {
                Perform("1000-MERGE-FIELDS", "1000-EXIT"); if (Control.ExitProgram) { return; }
            }
        #endregion

        #region 0000-EXIT
        L_0000_EXIT:;
            Control.ExitProgram = true; return;                                                                 //COBOL==> GOBACK.
        #endregion 0000-EXIT

        #region 1000-MERGE-FIELDS
        L_1000_MERGE_FIELDS:;
            WS.IX_SCREEN.SetValue(WS.MV_POS);                                                                   //COBOL==> SET IX-SCREEN TO MV-POS.
            WS.MV_HEADER[1].SetValue(LS.PV_SCREEN_CHAR[WS.IX_SCREEN.AsInt()]);                                  //COBOL==> MOVE PV-SCREEN-CHAR ( IX-SCREEN ) TO MV-HEADER ( 1 ) .
            WS.MV_HEADER[2].SetValue(LS.PV_SCREEN_CHAR[(WS.IX_SCREEN.AsInt() + 1)]);                            //COBOL==> MOVE PV-SCREEN-CHAR ( IX-SCREEN + 1 ) TO MV-HEADER ( 2 ) .
            WS.MV_HEADER[3].SetValue(LS.PV_SCREEN_CHAR[(WS.IX_SCREEN.AsInt() + 2)]);                            //COBOL==> MOVE PV-SCREEN-CHAR ( IX-SCREEN + 2 ) TO MV-HEADER ( 3 ) .
            WS.IX_SAVE.SetValue(WS.MV_POS);                                                                     //COBOL==> SET IX-SAVE TO MV-POS.
            WS.MV_MARK[1].SetValue(LS.PV_SAVE_CHAR[WS.IX_SAVE.AsInt()]);                                        //COBOL==> MOVE PV-SAVE-CHAR ( IX-SAVE ) TO MV-MARK ( 1 ) .
            WS.MV_MARK[2].SetValue(LS.PV_SAVE_CHAR[(WS.IX_SAVE.AsInt() + 1)]);                                  //COBOL==> MOVE PV-SAVE-CHAR ( IX-SAVE + 1 ) TO MV-MARK ( 2 ) .
            WS.MV_POS.Add(3);                                                                                   //COBOL==> ADD 3 TO MV-POS.
            if (!(WS.MV_MARK_LEN.IsEqualTo(WS.SC_MARK_OUTPUT)))                                                 //COBOL==> IF MV-MARK-LEN NOT = SC-MARK-OUTPUT
            {
                Perform("4000-MARK-SAVE", "4000-EXIT"); if (Control.ExitProgram) { return; }                          //COBOL==> PERFORM 4000-MARK-SAVE THRU 4000-EXIT
                while (!((WS.MV_POS.IsGreaterThan(LS.PV_LENGTH)) || (LS.PV_SAVE_CHAR[WS.MV_POS.AsInt()].IsEqualTo(HIGH_VALUES))))  //COBOL==> PERFORM 4100-MOVE-TO-SAVE THRU 4100-EXIT UNTIL MV-POS > PV-LENGTH OR PV-SAVE-CHAR ( MV-POS ) = HIGH-VALUE.
                {
                    Perform("4100-MOVE-TO-SAVE", "4100-EXIT"); if (Control.ExitProgram) { return; }
                }
            }
            Perform("2000-FIND-MARKED-FIELD", "2000-EXIT"); if (Control.ExitProgram) { return; }                  //COBOL==> PERFORM 2000-FIND-MARKED-FIELD THRU 2000-EXIT.
            if (returnLabel == "1000-MERGE-FIELDS") { return; }  //Check for pass through to next method
        #endregion 1000-MERGE-FIELDS

        #region 1000-EXIT
        L_1000_EXIT:;
            if (returnLabel == "1000-EXIT") { return; }  //Check for pass through to next method
        #endregion 1000-EXIT

        #region 2000-FIND-MARKED-FIELD
        L_2000_FIND_MARKED_FIELD:;
            if (WS.MV_POS.IsGreaterThan(LS.PV_LENGTH))                                                          //COBOL==> IF MV-POS > PV-LENGTH
            {
                goto L_2000_EXIT;                                                                                   //COBOL==> GO TO 2000-EXIT.
            }
            if (LS.PV_SAVE_CHAR[WS.MV_POS.AsInt()].IsEqualTo(HIGH_VALUES))                                      //COBOL==> IF PV-SAVE-CHAR ( MV-POS ) = HIGH-VALUES
            {
                goto L_2000_EXIT;                                                                                   //COBOL==> GO TO 2000-EXIT.
            }
            WS.MV_POS.Add(1);                                                                                   //COBOL==> ADD 1 TO MV-POS.
            goto L_2000_FIND_MARKED_FIELD;                                                                      //COBOL==> GO TO 2000-FIND-MARKED-FIELD.
        #endregion 2000-FIND-MARKED-FIELD

        #region 2000-EXIT
        L_2000_EXIT:;
            if (returnLabel == "2000-EXIT") { return; }  //Check for pass through to next method
        #endregion 2000-EXIT

        #region 4000-MARK-SAVE
        L_4000_MARK_SAVE:;
            if (WS.MV_MARK_LEN.IsEqualTo(WS.SC_MARK_MERGE_ONLY))                                                //COBOL==> IF MV-MARK-LEN = SC-MARK-MERGE-ONLY
            {
                goto L_4000_EXIT;                                                                                   //COBOL==> GO TO 4000-EXIT.
            }
            if ((WS.MV_LEN.IsGreaterThan(0))
             || (WS.MV_FLAG.IsGreaterThan(LOW_VALUES)))         //COBOL==> IF ( MV-LEN > 0 ) OR ( MV-FLAG > LOW-VALUES )
            {
                LS.PV_CHANGED.SetValue("Y");                                                                        //COBOL==> MOVE 'Y' TO PV-CHANGED
                WS.MV_MARK_LEN.SetValue(WS.SC_MARK_CHANGE);                                                         //COBOL==> MOVE SC-MARK-CHANGE TO MV-MARK-LEN
            }                                                                                                   //COBOL==> ELSE
            else
            {
                WS.MV_MARK_LEN.SetValue(WS.SC_MARK_UNCHANGED);                                                      //COBOL==> MOVE SC-MARK-UNCHANGED TO MV-MARK-LEN.
            }
            WS.MV_POS1.SetComputeValue(WS.MV_POS.AsDecimal() - 2m);                                             //COBOL==> COMPUTE MV-POS1 = MV-POS - 2
            LS.PV_SAVE_CHAR[WS.MV_POS1.AsInt()].SetValue(WS.MV_MARK[2]);                                        //COBOL==> MOVE MV-MARK ( 2 ) TO PV-SAVE-CHAR ( MV-POS1 ) .
            if (returnLabel == "4000-MARK-SAVE") { return; }  //Check for pass through to next method
        #endregion 4000-MARK-SAVE

        #region 4000-EXIT
        L_4000_EXIT:;
            if (returnLabel == "4000-EXIT") { return; }  //Check for pass through to next method
        #endregion 4000-EXIT

        #region 4100-MOVE-TO-SAVE
        L_4100_MOVE_TO_SAVE:;
            if ((WS.MV_LEN.IsGreaterThan(0))
             || (WS.MV_FLAG.IsGreaterThan(LOW_VALUES)))         //COBOL==> IF ( MV-LEN > 0 ) OR ( MV-FLAG > LOW-VALUES )
            {
                LS.PV_SAVE_CHAR[WS.MV_POS.AsInt()].SetValue(LS.PV_SCREEN_CHAR[WS.MV_POS.AsInt()]);                  //COBOL==> MOVE PV-SCREEN-CHAR ( MV-POS ) TO PV-SAVE-CHAR ( MV-POS ) .
            }
            if (LS.PV_SAVE_CHAR[WS.MV_POS.AsInt()].IsEqualTo(LOW_VALUES))                                       //COBOL==> IF PV-SAVE-CHAR ( MV-POS ) = LOW-VALUES
            {
                LS.PV_SAVE_CHAR[WS.MV_POS.AsInt()].SetValueWithSpaces();                                            //COBOL==> MOVE SPACES TO PV-SAVE-CHAR ( MV-POS ) .
            }
            WS.MV_POS.Add(1);                                                                                   //COBOL==> ADD 1 TO MV-POS.
            if (returnLabel == "4100-MOVE-TO-SAVE") { return; }  //Check for pass through to next method
        #endregion 4100-MOVE-TO-SAVE

        #region 4100-EXIT
        L_4100_EXIT:;
            #endregion 4100-EXIT
        }
        #endregion
    }
    #endregion
}
