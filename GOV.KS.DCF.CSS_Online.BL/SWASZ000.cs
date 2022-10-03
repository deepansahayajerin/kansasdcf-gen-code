#region Comments
/* Conversion Comments
   ************************************************************
   **   MODERN SYSTEMS INC.  COPYRIGHT 2000-2022
   **   DB-SHUTTLE COBOL to C# Conversion
   ************************************************************
   ** INIT   *  INITIAL VERSION   *  2022-01-14 12:46:02 PM
   **        *   FROM COBOL PGM   :  SWASZ000
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
using MDSY.Framework.Control.CICS;
using MDSY.Framework.Core;
using MDSY.Framework.Interfaces;
using System;
#endregion

namespace GOV.KS.DCF.CSS.Online.BL
{
    #region Working Storage Class
    internal class SWASZ000_ws : PredefinedRecordBase
    {
        #region Name constants
        /// <summary>
        /// Name constants.
        /// </summary>
        internal static class Names
        {
            internal const string WorkingStorage = "SWASZ000_ws_WorkingStorage";
            internal const string ABEND_ITEMS = "ABEND_ITEMS";
            internal const string ABEND_MESSAGE = "ABEND_MESSAGE";
            internal const string ABEND_MESSAGE_PROGRAM = "ABEND_MESSAGE_PROGRAM";
            internal const string ABEND_MESSAGE_LENGTH = "ABEND_MESSAGE_LENGTH";
            internal const string ABEND_CURSOR_POS = "ABEND_CURSOR_POS";
        }
        #endregion

        #region Direct-access element properties
        public IGroup ABEND_ITEMS { get { return GetElementByName<IGroup>(Names.ABEND_ITEMS); } }
        public IGroup ABEND_MESSAGE { get { return GetElementByName<IGroup>(Names.ABEND_MESSAGE); } }
        public IField ABEND_MESSAGE_PROGRAM { get { return GetElementByName<IField>(Names.ABEND_MESSAGE_PROGRAM); } }
        public IField ABEND_MESSAGE_LENGTH { get { return GetElementByName<IField>(Names.ABEND_MESSAGE_LENGTH); } }
        public IField ABEND_CURSOR_POS { get { return GetElementByName<IField>(Names.ABEND_CURSOR_POS); } }

        #endregion

        #region Data structure definition
        /// <summary>
        /// Defines the entirety of the WorkingStorage IRecord structure as described by the Ateras.Framework.Buffer API.
        /// </summary>
        /// <param name="recordDef">The IStructureDefinition object to be used in defining the record structure.</param>
        protected override void DefineRecordStructure(IStructureDefinition recordDef)
        {

            recordDef.CreateNewGroup(Names.ABEND_ITEMS, (ABEND_ITEMS) =>
           {
               ABEND_ITEMS.CreateNewGroup(Names.ABEND_MESSAGE, (ABEND_MESSAGE) =>
               {
                   ABEND_MESSAGE.CreateNewFillerField(FieldType.String, 31, "BAD CALL TO SWASZ000 - PROGRAM ");
                   ABEND_MESSAGE.CreateNewField(Names.ABEND_MESSAGE_PROGRAM, FieldType.String, 8);
                   ABEND_MESSAGE.CreateNewFillerField(FieldType.String, 15, " DOES NOT EXIST");
               });
               ABEND_ITEMS.CreateNewField(Names.ABEND_MESSAGE_LENGTH, FieldType.CompShort, 4, +54);
               ABEND_ITEMS.CreateNewField(Names.ABEND_CURSOR_POS, FieldType.CompShort, 4, +81);
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
    internal class SWASZ000_ls : PredefinedRecordBase
    {
        #region Name constants
        /// <summary>
        /// Name constants.
        /// </summary>
        internal static class Names
        {
            internal const string LinkageSection = "SWASZ000_ls_LinkageSection";
            internal const string PV_TWA = "PV_TWA";
            internal const string PV_ENTRY_POINT = "PV_ENTRY_POINT";
            internal const string PV_PARM1_ADDR = "PV_PARM1_ADDR";
            internal const string PV_PARM2_ADDR = "PV_PARM2_ADDR";
            internal const string PV_PARM3_ADDR = "PV_PARM3_ADDR";
            internal const string PV_PARM4_ADDR = "PV_PARM4_ADDR";
            internal const string PV_PARM5_ADDR = "PV_PARM5_ADDR";
            internal const string PV_PARM1 = "PV_PARM1";
            internal const string PV_PARM2 = "PV_PARM2";
            internal const string PV_PARM3 = "PV_PARM3";
            internal const string PV_PARM4 = "PV_PARM4";
            internal const string PV_PARM5 = "PV_PARM5";
        }
        #endregion

        #region Direct-access element properties
        public IGroup PV_TWA { get { return GetElementByName<IGroup>(Names.PV_TWA); } }
        public IField PV_ENTRY_POINT { get { return GetElementByName<IField>(Names.PV_ENTRY_POINT); } }
        public IField PV_PARM1_ADDR { get { return GetElementByName<IField>(Names.PV_PARM1_ADDR); } }
        public IField PV_PARM2_ADDR { get { return GetElementByName<IField>(Names.PV_PARM2_ADDR); } }
        public IField PV_PARM3_ADDR { get { return GetElementByName<IField>(Names.PV_PARM3_ADDR); } }
        public IField PV_PARM4_ADDR { get { return GetElementByName<IField>(Names.PV_PARM4_ADDR); } }
        public IField PV_PARM5_ADDR { get { return GetElementByName<IField>(Names.PV_PARM5_ADDR); } }
        public IField PV_PARM1 { get { return GetElementByName<IField>(Names.PV_PARM1); } }
        public IField PV_PARM2 { get { return GetElementByName<IField>(Names.PV_PARM2); } }
        public IField PV_PARM3 { get { return GetElementByName<IField>(Names.PV_PARM3); } }
        public IField PV_PARM4 { get { return GetElementByName<IField>(Names.PV_PARM4); } }
        public IField PV_PARM5 { get { return GetElementByName<IField>(Names.PV_PARM5); } }

        #endregion

        #region Data structure definition
        /// <summary>
        /// Defines the entirety of the LinkageSection IRecord structure as described by the Ateras.Framework.Buffer API.
        /// </summary>
        /// <param name="recordDef">The IStructureDefinition object to be used in defining the record structure.</param>
        protected override void DefineRecordStructure(IStructureDefinition recordDef)
        {

            recordDef.CreateNewGroup(Names.PV_TWA, (PV_TWA) =>
           {
               PV_TWA.CreateNewField(Names.PV_ENTRY_POINT, FieldType.String, 8);
               PV_TWA.CreateNewField(Names.PV_PARM1_ADDR, FieldType.ReferencePointer, 4);
               PV_TWA.CreateNewField(Names.PV_PARM2_ADDR, FieldType.ReferencePointer, 4);
               PV_TWA.CreateNewField(Names.PV_PARM3_ADDR, FieldType.ReferencePointer, 4);
               PV_TWA.CreateNewField(Names.PV_PARM4_ADDR, FieldType.ReferencePointer, 4);
               PV_TWA.CreateNewField(Names.PV_PARM5_ADDR, FieldType.ReferencePointer, 4);
           });
            recordDef.CreateNewField(Names.PV_PARM1, FieldType.String, 1);
            recordDef.CreateNewField(Names.PV_PARM2, FieldType.String, 1);
            recordDef.CreateNewField(Names.PV_PARM3, FieldType.String, 1);
            recordDef.CreateNewField(Names.PV_PARM4, FieldType.String, 1);
            recordDef.CreateNewField(Names.PV_PARM5, FieldType.String, 1);

        }

        protected override string GetRecordName()
        {
            return Names.LinkageSection;
        }
        #endregion

    }
    #endregion Linkage Section Class

    #region Business Logic Class
    public class SWASZ000 : OnlineProgramBase
    {

        #region Public Constructors
        public SWASZ000()
            : base()
        {
            SetUpProgram();
        }

        public SWASZ000(OnlineControl controlData) : base(controlData)
        {
            SetUpProgram();
        }

        private void SetUpProgram()
        {
            this.ProgramName = "SWASZ000";

            WS = new SWASZ000_ws();
            LS = new SWASZ000_ls();
        }

        #endregion

        #region Private Fields


        //==== Working Storage Data Class ========================================
        private SWASZ000_ws WS;

        //==== Linkage Section Data Class ========================================
        private SWASZ000_ls LS;
        #endregion

        #region Public Methods
        //========================================================================
        //==== RunMain Entry Point Method ========================================
        //========================================================================
        public override int ExecuteMain()                                                                  //COBOL==> PROCEDURE DIVISION.
        {
            try
            {
                WS.Initialize();
                SetData();
                RunMain();
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

        private void SetData()
        {
            LS.InitializeWithLowValues();
            WS.InitializeWithLowValues();
        }

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
            //COMMENT: *   CALL REQUESTED MODULE AND PASS REQUIRED PARAMETERS
            //COMMENT: *   NOTE: IT IS IMPORTANT TO LEAVE THIS CODE IN THE FORMAT
            //COMMENT: *         IT IS CURRENTLY IN.  DO NOT DEFINE ANY WORKING
            //COMMENT: *         STORAGE SINCE THIS MODULE IS ATTEMPTING TO BE
            //COMMENT: *         A TRUE RE-ENTRANT PROGRAM FOR VS-COBOL-II.
            //LS.PV_TWA.SetBufferReference(Control.GetTransactionWorkArea());                                     //COBOL==> EXEC CICS ADDRESS TWA ( ADDRESS OF PV-TWA ) END-EXEC.
            if (LS.PV_ENTRY_POINT.IsEqualTo("SWASZ002"))                                                        //COBOL==> IF PV-ENTRY-POINT = 'SWASZ002'
            {
                LS.PV_PARM1.SetBufferReference(LS.PV_PARM1_ADDR);                                                   //COBOL==> SET ADDRESS OF PV-PARM1 TO PV-PARM1-ADDR
                LS.PV_PARM2.SetBufferReference(LS.PV_PARM2_ADDR);                                                   //COBOL==> SET ADDRESS OF PV-PARM2 TO PV-PARM2-ADDR
                LS.PV_PARM3.SetBufferReference(LS.PV_PARM3_ADDR);                                                   //COBOL==> SET ADDRESS OF PV-PARM3 TO PV-PARM3-ADDR
                Control.Call("SWASZ002", LS.PV_PARM1, LS.PV_PARM2, LS.PV_PARM3); if (Control.ExitProgram) return;  //COBOL==> CALL 'SWASZ002' USING PV-PARM1 PV-PARM2 PV-PARM3
                M_0000_EXIT(CheckGotoReturn(returnMethod)); return;                                                 //COBOL==> GO TO 0000-EXIT.
            }
            if (LS.PV_ENTRY_POINT.IsEqualTo("SWASZ007"))                                                        //COBOL==> IF PV-ENTRY-POINT = 'SWASZ007'
            {
                LS.PV_PARM1.SetBufferReference(LS.PV_PARM1_ADDR);                                                   //COBOL==> SET ADDRESS OF PV-PARM1 TO PV-PARM1-ADDR
                LS.PV_PARM2.SetBufferReference(LS.PV_PARM2_ADDR);                                                   //COBOL==> SET ADDRESS OF PV-PARM2 TO PV-PARM2-ADDR
                LS.PV_PARM3.SetBufferReference(LS.PV_PARM3_ADDR);                                                   //COBOL==> SET ADDRESS OF PV-PARM3 TO PV-PARM3-ADDR
                Control.Call("SWASZ007", LS.PV_PARM1, LS.PV_PARM2, LS.PV_PARM3); if (Control.ExitProgram) return;  //COBOL==> CALL 'SWASZ007' USING PV-PARM1 PV-PARM2 PV-PARM3
                M_0000_EXIT(CheckGotoReturn(returnMethod)); return;                                                 //COBOL==> GO TO 0000-EXIT.
            }
            if (LS.PV_ENTRY_POINT.IsEqualTo("SWASZ008"))                                                        //COBOL==> IF PV-ENTRY-POINT = 'SWASZ008'
            {
                LS.PV_PARM1.SetBufferReference(LS.PV_PARM1_ADDR);                                                   //COBOL==> SET ADDRESS OF PV-PARM1 TO PV-PARM1-ADDR
                LS.PV_PARM2.SetBufferReference(LS.PV_PARM2_ADDR);                                                   //COBOL==> SET ADDRESS OF PV-PARM2 TO PV-PARM2-ADDR
                LS.PV_PARM3.SetBufferReference(LS.PV_PARM3_ADDR);                                                   //COBOL==> SET ADDRESS OF PV-PARM3 TO PV-PARM3-ADDR
                Control.Call("SWASZ008", LS.PV_PARM1, LS.PV_PARM2, LS.PV_PARM3); if (Control.ExitProgram) return;  //COBOL==> CALL 'SWASZ008' USING PV-PARM1 PV-PARM2 PV-PARM3
                M_0000_EXIT(CheckGotoReturn(returnMethod)); return;                                                 //COBOL==> GO TO 0000-EXIT.
            }
            if (LS.PV_ENTRY_POINT.IsEqualTo("SWASZ009"))                                                        //COBOL==> IF PV-ENTRY-POINT = 'SWASZ009'
            {
                LS.PV_PARM1.SetBufferReference(LS.PV_PARM1_ADDR);                                                   //COBOL==> SET ADDRESS OF PV-PARM1 TO PV-PARM1-ADDR
                LS.PV_PARM2.SetBufferReference(LS.PV_PARM2_ADDR);                                                   //COBOL==> SET ADDRESS OF PV-PARM2 TO PV-PARM2-ADDR
                LS.PV_PARM3.SetBufferReference(LS.PV_PARM3_ADDR);                                                   //COBOL==> SET ADDRESS OF PV-PARM3 TO PV-PARM3-ADDR
                Control.Call("SWASZ009", LS.PV_PARM1, LS.PV_PARM2, LS.PV_PARM3); if (Control.ExitProgram) return;  //COBOL==> CALL 'SWASZ009' USING PV-PARM1 PV-PARM2 PV-PARM3
                M_0000_EXIT(CheckGotoReturn(returnMethod)); return;                                                 //COBOL==> GO TO 0000-EXIT.
            }
            if (LS.PV_ENTRY_POINT.IsEqualTo("SWASZ010"))                                                        //COBOL==> IF PV-ENTRY-POINT = 'SWASZ010'
            {
                LS.PV_PARM1.SetBufferReference(LS.PV_PARM1_ADDR);                                                   //COBOL==> SET ADDRESS OF PV-PARM1 TO PV-PARM1-ADDR
                LS.PV_PARM2.SetBufferReference(LS.PV_PARM2_ADDR);                                                   //COBOL==> SET ADDRESS OF PV-PARM2 TO PV-PARM2-ADDR
                LS.PV_PARM3.SetBufferReference(LS.PV_PARM3_ADDR);                                                   //COBOL==> SET ADDRESS OF PV-PARM3 TO PV-PARM3-ADDR
                Control.Call("SWASZ010", LS.PV_PARM1, LS.PV_PARM2, LS.PV_PARM3); if (Control.ExitProgram) return;  //COBOL==> CALL 'SWASZ010' USING PV-PARM1 PV-PARM2 PV-PARM3
                M_0000_EXIT(CheckGotoReturn(returnMethod)); return;                                                 //COBOL==> GO TO 0000-EXIT.
            }
            if (LS.PV_ENTRY_POINT.IsEqualTo("SWASZ022"))                                                        //COBOL==> IF PV-ENTRY-POINT = 'SWASZ022'
            {
                LS.PV_PARM1.SetBufferReference(LS.PV_PARM1_ADDR);                                                   //COBOL==> SET ADDRESS OF PV-PARM1 TO PV-PARM1-ADDR
                LS.PV_PARM2.SetBufferReference(LS.PV_PARM2_ADDR);                                                   //COBOL==> SET ADDRESS OF PV-PARM2 TO PV-PARM2-ADDR
                Control.Call("SWASZ022", LS.PV_PARM1, LS.PV_PARM2); if (Control.ExitProgram) return;               //COBOL==> CALL 'SWASZ022' USING PV-PARM1 PV-PARM2
                M_0000_EXIT(CheckGotoReturn(returnMethod)); return;                                                 //COBOL==> GO TO 0000-EXIT.
            }
            if (LS.PV_ENTRY_POINT.IsEqualTo("SWASZ024"))                                                        //COBOL==> IF PV-ENTRY-POINT = 'SWASZ024'
            {
                LS.PV_PARM1.SetBufferReference(LS.PV_PARM1_ADDR);                                                   //COBOL==> SET ADDRESS OF PV-PARM1 TO PV-PARM1-ADDR
                LS.PV_PARM2.SetBufferReference(LS.PV_PARM2_ADDR);                                                   //COBOL==> SET ADDRESS OF PV-PARM2 TO PV-PARM2-ADDR
                LS.PV_PARM3.SetBufferReference(LS.PV_PARM3_ADDR);                                                   //COBOL==> SET ADDRESS OF PV-PARM3 TO PV-PARM3-ADDR
                LS.PV_PARM4.SetBufferReference(LS.PV_PARM4_ADDR);                                                   //COBOL==> SET ADDRESS OF PV-PARM4 TO PV-PARM4-ADDR
                Control.Call("SWASZ024", LS.PV_PARM1, LS.PV_PARM2, LS.PV_PARM3, LS.PV_PARM4); if (Control.ExitProgram) return;  //COBOL==> CALL 'SWASZ024' USING PV-PARM1 PV-PARM2 PV-PARM3 PV-PARM4
                M_0000_EXIT(CheckGotoReturn(returnMethod)); return;                                                 //COBOL==> GO TO 0000-EXIT.
            }
            if (LS.PV_ENTRY_POINT.IsEqualTo("SWASZ025"))                                                        //COBOL==> IF PV-ENTRY-POINT = 'SWASZ025'
            {
                LS.PV_PARM1.SetBufferReference(LS.PV_PARM1_ADDR);                                                   //COBOL==> SET ADDRESS OF PV-PARM1 TO PV-PARM1-ADDR
                LS.PV_PARM2.SetBufferReference(LS.PV_PARM2_ADDR);                                                   //COBOL==> SET ADDRESS OF PV-PARM2 TO PV-PARM2-ADDR
                LS.PV_PARM3.SetBufferReference(LS.PV_PARM3_ADDR);                                                   //COBOL==> SET ADDRESS OF PV-PARM3 TO PV-PARM3-ADDR
                LS.PV_PARM4.SetBufferReference(LS.PV_PARM4_ADDR);                                                   //COBOL==> SET ADDRESS OF PV-PARM4 TO PV-PARM4-ADDR
                Control.Call("SWASZ025", LS.PV_PARM1, LS.PV_PARM2, LS.PV_PARM3, LS.PV_PARM4); if (Control.ExitProgram) return;  //COBOL==> CALL 'SWASZ025' USING PV-PARM1 PV-PARM2 PV-PARM3 PV-PARM4
                M_0000_EXIT(CheckGotoReturn(returnMethod)); return;                                                 //COBOL==> GO TO 0000-EXIT.
            }
            if (LS.PV_ENTRY_POINT.IsEqualTo("SWASZ026"))                                                        //COBOL==> IF PV-ENTRY-POINT = 'SWASZ026'
            {
                LS.PV_PARM1.SetBufferReference(LS.PV_PARM1_ADDR);                                                   //COBOL==> SET ADDRESS OF PV-PARM1 TO PV-PARM1-ADDR
                LS.PV_PARM2.SetBufferReference(LS.PV_PARM2_ADDR);                                                   //COBOL==> SET ADDRESS OF PV-PARM2 TO PV-PARM2-ADDR
                LS.PV_PARM3.SetBufferReference(LS.PV_PARM3_ADDR);                                                   //COBOL==> SET ADDRESS OF PV-PARM3 TO PV-PARM3-ADDR
                LS.PV_PARM4.SetBufferReference(LS.PV_PARM4_ADDR);                                                   //COBOL==> SET ADDRESS OF PV-PARM4 TO PV-PARM4-ADDR
                Control.Call("SWASZ026", LS.PV_PARM1, LS.PV_PARM2, LS.PV_PARM3, LS.PV_PARM4); if (Control.ExitProgram) return;  //COBOL==> CALL 'SWASZ026' USING PV-PARM1 PV-PARM2 PV-PARM3 PV-PARM4
                M_0000_EXIT(CheckGotoReturn(returnMethod)); return;                                                 //COBOL==> GO TO 0000-EXIT.
            }
            if (LS.PV_ENTRY_POINT.IsEqualTo("SWASZ027"))                                                        //COBOL==> IF PV-ENTRY-POINT = 'SWASZ027'
            {
                LS.PV_PARM1.SetBufferReference(LS.PV_PARM1_ADDR);                                                   //COBOL==> SET ADDRESS OF PV-PARM1 TO PV-PARM1-ADDR
                LS.PV_PARM2.SetBufferReference(LS.PV_PARM2_ADDR);                                                   //COBOL==> SET ADDRESS OF PV-PARM2 TO PV-PARM2-ADDR
                Control.Call("SWASZ027", LS.PV_PARM1, LS.PV_PARM2); if (Control.ExitProgram) return;               //COBOL==> CALL 'SWASZ027' USING PV-PARM1 PV-PARM2
                M_0000_EXIT(CheckGotoReturn(returnMethod)); return;                                                 //COBOL==> GO TO 0000-EXIT.
            }
            if (LS.PV_ENTRY_POINT.IsEqualTo("SWASZ030"))                                                        //COBOL==> IF PV-ENTRY-POINT = 'SWASZ030'
            {
                LS.PV_PARM1.SetBufferReference(LS.PV_PARM1_ADDR);                                                   //COBOL==> SET ADDRESS OF PV-PARM1 TO PV-PARM1-ADDR
                LS.PV_PARM2.SetBufferReference(LS.PV_PARM2_ADDR);                                                   //COBOL==> SET ADDRESS OF PV-PARM2 TO PV-PARM2-ADDR
                LS.PV_PARM3.SetBufferReference(LS.PV_PARM3_ADDR);                                                   //COBOL==> SET ADDRESS OF PV-PARM3 TO PV-PARM3-ADDR
                LS.PV_PARM4.SetBufferReference(LS.PV_PARM4_ADDR);                                                   //COBOL==> SET ADDRESS OF PV-PARM4 TO PV-PARM4-ADDR
                Control.Call("SWASZ030", LS.PV_PARM1, LS.PV_PARM2, LS.PV_PARM3, LS.PV_PARM4); if (Control.ExitProgram) return;  //COBOL==> CALL 'SWASZ030' USING PV-PARM1 PV-PARM2 PV-PARM3 PV-PARM4
                M_0000_EXIT(CheckGotoReturn(returnMethod)); return;                                                 //COBOL==> GO TO 0000-EXIT.
            }
            if (LS.PV_ENTRY_POINT.IsEqualTo("SWASZ031"))                                                        //COBOL==> IF PV-ENTRY-POINT = 'SWASZ031'
            {
                LS.PV_PARM1.SetBufferReference(LS.PV_PARM1_ADDR);                                                   //COBOL==> SET ADDRESS OF PV-PARM1 TO PV-PARM1-ADDR
                LS.PV_PARM2.SetBufferReference(LS.PV_PARM2_ADDR);                                                   //COBOL==> SET ADDRESS OF PV-PARM2 TO PV-PARM2-ADDR
                Control.Call("SWASZ031", LS.PV_PARM1, LS.PV_PARM2); if (Control.ExitProgram) return;               //COBOL==> CALL 'SWASZ031' USING PV-PARM1 PV-PARM2
                M_0000_EXIT(CheckGotoReturn(returnMethod)); return;                                                 //COBOL==> GO TO 0000-EXIT.
            }
            if (LS.PV_ENTRY_POINT.IsEqualTo("SWASZ032"))                                                        //COBOL==> IF PV-ENTRY-POINT = 'SWASZ032'
            {
                LS.PV_PARM1.SetBufferReference(LS.PV_PARM1_ADDR);                                                   //COBOL==> SET ADDRESS OF PV-PARM1 TO PV-PARM1-ADDR
                LS.PV_PARM2.SetBufferReference(LS.PV_PARM2_ADDR);                                                   //COBOL==> SET ADDRESS OF PV-PARM2 TO PV-PARM2-ADDR
                Control.Call("SWASZ032", LS.PV_PARM1, LS.PV_PARM2); if (Control.ExitProgram) return;               //COBOL==> CALL 'SWASZ032' USING PV-PARM1 PV-PARM2
                M_0000_EXIT(CheckGotoReturn(returnMethod)); return;                                                 //COBOL==> GO TO 0000-EXIT.
            }
            if (LS.PV_ENTRY_POINT.IsEqualTo("SWASZ036"))                                                        //COBOL==> IF PV-ENTRY-POINT = 'SWASZ036'
            {
                LS.PV_PARM1.SetBufferReference(LS.PV_PARM1_ADDR);                                                   //COBOL==> SET ADDRESS OF PV-PARM1 TO PV-PARM1-ADDR
                LS.PV_PARM2.SetBufferReference(LS.PV_PARM2_ADDR);                                                   //COBOL==> SET ADDRESS OF PV-PARM2 TO PV-PARM2-ADDR
                Control.Call("SWASZ036", LS.PV_PARM1, LS.PV_PARM2); if (Control.ExitProgram) return;               //COBOL==> CALL 'SWASZ036' USING PV-PARM1 PV-PARM2
                M_0000_EXIT(CheckGotoReturn(returnMethod)); return;                                                 //COBOL==> GO TO 0000-EXIT.
            }
            if (LS.PV_ENTRY_POINT.IsEqualTo("SWASZ037"))                                                        //COBOL==> IF PV-ENTRY-POINT = 'SWASZ037'
            {
                LS.PV_PARM1.SetBufferReference(LS.PV_PARM1_ADDR);                                                   //COBOL==> SET ADDRESS OF PV-PARM1 TO PV-PARM1-ADDR
                LS.PV_PARM2.SetBufferReference(LS.PV_PARM2_ADDR);                                                   //COBOL==> SET ADDRESS OF PV-PARM2 TO PV-PARM2-ADDR
                LS.PV_PARM3.SetBufferReference(LS.PV_PARM3_ADDR);                                                   //COBOL==> SET ADDRESS OF PV-PARM3 TO PV-PARM3-ADDR
                Control.Call("SWASZ037", LS.PV_PARM1, LS.PV_PARM2, LS.PV_PARM3); if (Control.ExitProgram) return;  //COBOL==> CALL 'SWASZ037' USING PV-PARM1 PV-PARM2 PV-PARM3
                M_0000_EXIT(CheckGotoReturn(returnMethod)); return;                                                 //COBOL==> GO TO 0000-EXIT.
            }
            //COMMENT:     IF THE LOGIC REACHES THIS POINT, THE PROGRAM HAS BEEN
            //COMMENT:     CALLED WITH A BAD PROGRAM ID TO EXECUTE.
            WS.ABEND_MESSAGE_PROGRAM.SetValue(LS.PV_ENTRY_POINT);                                               //COBOL==> MOVE PV-ENTRY-POINT TO ABEND-MESSAGE-PROGRAM
            Map.SendText(WS.ABEND_MESSAGE, WS.ABEND_MESSAGE_LENGTH.LengthInBuffer, SendOption.Erase, SendOption.Cursor); if (CheckHandleConditions(returnMethod)) { return; }  //COBOL==> EXEC CICS SEND TEXT FROM ( ABEND-MESSAGE ) LENGTH ( ABEND-MESSAGE-LENGTH ) CURSOR ( ABEND-CURSOR-POS ) ERASE WAIT END-EXEC.
            Control.ThrowException();                                                                           //COBOL==> EXEC CICS ABEND END-EXEC.
            if (returnMethod != "" && returnMethod != "M_0000_MAIN_LOGIC") { M_0000_EXIT(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_0000_EXIT
        /// </summary>
        private void M_0000_EXIT(string returnMethod = "")
        {
            Control.Return(LS); return;                                                                         //COBOL==> EXEC CICS RETURN END-EXEC.
            Control.ExitProgram = true; return;                                                                 //COBOL==> GOBACK.
        }
        #endregion
    }
    #endregion
}
