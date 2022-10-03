#region Comments
/* Conversion Comments
   ************************************************************
   **   MODERN SYSTEMS INC.  COPYRIGHT 2000-2022
   **   DB-SHUTTLE COBOL to C# Conversion
   ************************************************************
   ** INIT   *  INITIAL VERSION   *  2022-03-02 04:48:17 PM
   **        *   FROM COBOL PGM   :  SWEXGC05
   **        *   FROM CANISTER    :  SR.CAECSES.PROD.LIBR.SOURCE.PDS
   ************************************************************ */

/* Original Program Identification Comments
   **************************************************************
   * DEVELOPED BY : ARUN MATHIAS                               **
   * DATE WRITTEN : 02/21/2008                                 **
   * COMMENTS     : THIS CALL IS MADE FROM THE COOL:GEN        **
   *                SECURITY EXIT.                             **
   **************************************************************
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

namespace GOV.KS.DCF.CSS.Common.BL
{
    #region Working Storage Class
    internal class SWEXGC05_ws : PredefinedRecordBase
    {
        #region Name constants
        /// <summary>
        /// Name constants.
        /// </summary>
        internal static class Names
        {
            internal const string WorkingStorage = "SWEXGC05_ws_WorkingStorage";
            internal const string WS_VARIABLES = "WS_VARIABLES";
            internal const string WS_REGION = "WS_REGION";
            internal const string WS_LENGTHS = "WS_LENGTHS";
            internal const string WS_NAME_LENGTH = "WS_NAME_LENGTH";
            internal const string WS_MESSAGE_LENGTH = "WS_MESSAGE_LENGTH";
            internal const string WS_PARMS = "WS_PARMS";
            internal const string WS_RUNTIME_PARM1 = "WS_RUNTIME_PARM1";
            internal const string WS_RUNTIME_PARM2 = "WS_RUNTIME_PARM2";
            internal const string WS_GLOBDATA = "WS_GLOBDATA";
            internal const string WS_IMPORT_0005EV = "WS_IMPORT_0005EV";
            internal const string WS_SERVICE_PROVIDER_0005ET = "WS_SERVICE_PROVIDER_0005ET";
            internal const string WS_USER_ID_0005AS = "WS_USER_ID_0005AS";
            internal const string WS_USER_ID_0005 = "WS_USER_ID_0005";
            internal const string WS_USER_ID_0005XX = "WS_USER_ID_0005XX";
            internal const string WS_IMPORT_0006EV = "WS_IMPORT_0006EV";
            internal const string WS_TRANSACTION_0006ET = "WS_TRANSACTION_0006ET";
            internal const string WS_TRANCODE_0006AS = "WS_TRANCODE_0006AS";
            internal const string WS_TRANCODE_0006 = "WS_TRANCODE_0006";
            internal const string WS_TRANCODE_0006XX = "WS_TRANCODE_0006XX";
            internal const string WS_EXP_SECURITY_BYPASS__0006EV = "WS_EXP_SECURITY_BYPASS__0006EV";
            internal const string WS_IEF_SUPPLIED_0006ET = "WS_IEF_SUPPLIED_0006ET";
            internal const string WS_FLAG_0006AS = "WS_FLAG_0006AS";
            internal const string WS_FLAG_0006 = "WS_FLAG_0006";
            internal const string WS_FLAG_0006XX = "WS_FLAG_0006XX";
            internal const string WS_CONSTANTS = "WS_CONSTANTS";
            internal const string WS_SRCICSY = "WS_SRCICSY";
            internal const string WS_SRXK_NAME = "WS_SRXK_NAME";
            internal const string WS_SWE00554_PGM = "WS_SWE00554_PGM";
            internal const string WS_WARN_MESSAGE = "WS_WARN_MESSAGE";
            internal const string WS_WARN_MSG1 = "WS_WARN_MSG1";
            internal const string WS_WARN_MSG2 = "WS_WARN_MSG2";
            internal const string WS_WARN_MSG3 = "WS_WARN_MSG3";
            internal const string WS_WARN_MSG4 = "WS_WARN_MSG4";
            internal const string WS_POINTERS = "WS_POINTERS";
            internal const string CSE_SECURE_ADDR = "CSE_SECURE_ADDR";
        }
        #endregion

        #region Direct-access element properties
        public IGroup WS_VARIABLES { get { return GetElementByName<IGroup>(Names.WS_VARIABLES); } }
        public IField WS_REGION { get { return GetElementByName<IField>(Names.WS_REGION); } }
        public IGroup WS_LENGTHS { get { return GetElementByName<IGroup>(Names.WS_LENGTHS); } }
        public IField WS_NAME_LENGTH { get { return GetElementByName<IField>(Names.WS_NAME_LENGTH); } }
        public IField WS_MESSAGE_LENGTH { get { return GetElementByName<IField>(Names.WS_MESSAGE_LENGTH); } }
        public IGroup WS_PARMS { get { return GetElementByName<IGroup>(Names.WS_PARMS); } }
        public IField WS_RUNTIME_PARM1 { get { return GetElementByName<IField>(Names.WS_RUNTIME_PARM1); } }
        public IField WS_RUNTIME_PARM2 { get { return GetElementByName<IField>(Names.WS_RUNTIME_PARM2); } }
        public IField WS_GLOBDATA { get { return GetElementByName<IField>(Names.WS_GLOBDATA); } }
        public IGroup WS_IMPORT_0005EV { get { return GetElementByName<IGroup>(Names.WS_IMPORT_0005EV); } }
        public IGroup WS_SERVICE_PROVIDER_0005ET { get { return GetElementByName<IGroup>(Names.WS_SERVICE_PROVIDER_0005ET); } }
        public IField WS_USER_ID_0005AS { get { return GetElementByName<IField>(Names.WS_USER_ID_0005AS); } }
        public IField WS_USER_ID_0005 { get { return GetElementByName<IField>(Names.WS_USER_ID_0005); } }
        public IField WS_USER_ID_0005XX { get { return GetElementByName<IField>(Names.WS_USER_ID_0005XX); } }
        public IGroup WS_IMPORT_0006EV { get { return GetElementByName<IGroup>(Names.WS_IMPORT_0006EV); } }
        public IGroup WS_TRANSACTION_0006ET { get { return GetElementByName<IGroup>(Names.WS_TRANSACTION_0006ET); } }
        public IField WS_TRANCODE_0006AS { get { return GetElementByName<IField>(Names.WS_TRANCODE_0006AS); } }
        public IField WS_TRANCODE_0006 { get { return GetElementByName<IField>(Names.WS_TRANCODE_0006); } }
        public IField WS_TRANCODE_0006XX { get { return GetElementByName<IField>(Names.WS_TRANCODE_0006XX); } }
        public IGroup WS_EXP_SECURITY_BYPASS__0006EV { get { return GetElementByName<IGroup>(Names.WS_EXP_SECURITY_BYPASS__0006EV); } }
        public IGroup WS_IEF_SUPPLIED_0006ET { get { return GetElementByName<IGroup>(Names.WS_IEF_SUPPLIED_0006ET); } }
        public IField WS_FLAG_0006AS { get { return GetElementByName<IField>(Names.WS_FLAG_0006AS); } }
        public IField WS_FLAG_0006 { get { return GetElementByName<IField>(Names.WS_FLAG_0006); } }
        public IField WS_FLAG_0006XX { get { return GetElementByName<IField>(Names.WS_FLAG_0006XX); } }
        public IGroup WS_CONSTANTS { get { return GetElementByName<IGroup>(Names.WS_CONSTANTS); } }
        public IField WS_SRCICSY { get { return GetElementByName<IField>(Names.WS_SRCICSY); } }
        public IField WS_SRXK_NAME { get { return GetElementByName<IField>(Names.WS_SRXK_NAME); } }
        public IField WS_SWE00554_PGM { get { return GetElementByName<IField>(Names.WS_SWE00554_PGM); } }
        public IGroup WS_WARN_MESSAGE { get { return GetElementByName<IGroup>(Names.WS_WARN_MESSAGE); } }
        public IField WS_WARN_MSG1 { get { return GetElementByName<IField>(Names.WS_WARN_MSG1); } }
        public IField WS_WARN_MSG2 { get { return GetElementByName<IField>(Names.WS_WARN_MSG2); } }
        public IField WS_WARN_MSG3 { get { return GetElementByName<IField>(Names.WS_WARN_MSG3); } }
        public IField WS_WARN_MSG4 { get { return GetElementByName<IField>(Names.WS_WARN_MSG4); } }
        public IGroup WS_POINTERS { get { return GetElementByName<IGroup>(Names.WS_POINTERS); } }
        public IField CSE_SECURE_ADDR { get { return GetElementByName<IField>(Names.CSE_SECURE_ADDR); } }

        #endregion

        #region Data structure definition
        /// <summary>
        /// Defines the entirety of the WorkingStorage IRecord structure as described by the Ateras.Framework.Buffer API.
        /// </summary>
        /// <param name="recordDef">The IStructureDefinition object to be used in defining the record structure.</param>
        protected override void DefineRecordStructure(IStructureDefinition recordDef)
        {

            recordDef.CreateNewGroup(Names.WS_VARIABLES, (WS_VARIABLES) =>
           {
               WS_VARIABLES.CreateNewField(Names.WS_REGION, FieldType.String, 8, SPACES);
           });

            recordDef.CreateNewGroup(Names.WS_LENGTHS, (WS_LENGTHS) =>
           {
               WS_LENGTHS.CreateNewField(Names.WS_NAME_LENGTH, FieldType.CompShort, 4, 0);
               WS_LENGTHS.CreateNewField(Names.WS_MESSAGE_LENGTH, FieldType.CompShort, 4, 0);
           });

            recordDef.CreateNewGroup(Names.WS_PARMS, (WS_PARMS) =>
           {
               WS_PARMS.CreateNewField(Names.WS_RUNTIME_PARM1, FieldType.String, 1, SPACES);
               WS_PARMS.CreateNewField(Names.WS_RUNTIME_PARM2, FieldType.String, 1, SPACES);
               WS_PARMS.CreateNewField(Names.WS_GLOBDATA, FieldType.String, 3645, SPACES);
               WS_PARMS.CreateNewGroup(Names.WS_IMPORT_0005EV, (WS_IMPORT_0005EV) =>
               {
                   WS_IMPORT_0005EV.CreateNewGroup(Names.WS_SERVICE_PROVIDER_0005ET, (WS_SERVICE_PROVIDER_0005ET) =>
                   {
                       WS_SERVICE_PROVIDER_0005ET.CreateNewField(Names.WS_USER_ID_0005AS, FieldType.String, 1);

                       IField WS_USER_ID_0005_local = WS_SERVICE_PROVIDER_0005ET.CreateNewField(Names.WS_USER_ID_0005, FieldType.String, 8);
                       WS_SERVICE_PROVIDER_0005ET.CreateNewFieldRedefine(Names.WS_USER_ID_0005XX, FieldType.String, WS_USER_ID_0005_local, 8);
                   });
               });
               WS_PARMS.CreateNewGroup(Names.WS_IMPORT_0006EV, (WS_IMPORT_0006EV) =>
               {
                   WS_IMPORT_0006EV.CreateNewGroup(Names.WS_TRANSACTION_0006ET, (WS_TRANSACTION_0006ET) =>
                   {
                       WS_TRANSACTION_0006ET.CreateNewField(Names.WS_TRANCODE_0006AS, FieldType.String, 1);

                       IField WS_TRANCODE_0006_local = WS_TRANSACTION_0006ET.CreateNewField(Names.WS_TRANCODE_0006, FieldType.String, 4);
                       WS_TRANSACTION_0006ET.CreateNewFieldRedefine(Names.WS_TRANCODE_0006XX, FieldType.String, WS_TRANCODE_0006_local, 4);
                   });
               });
               WS_PARMS.CreateNewGroup(Names.WS_EXP_SECURITY_BYPASS__0006EV, (WS_EXP_SECURITY_BYPASS__0006EV) =>
               {
                   WS_EXP_SECURITY_BYPASS__0006EV.CreateNewGroup(Names.WS_IEF_SUPPLIED_0006ET, (WS_IEF_SUPPLIED_0006ET) =>
                   {
                       WS_IEF_SUPPLIED_0006ET.CreateNewField(Names.WS_FLAG_0006AS, FieldType.String, 1);

                       IField WS_FLAG_0006_local = WS_IEF_SUPPLIED_0006ET.CreateNewField(Names.WS_FLAG_0006, FieldType.String, 1);
                       WS_IEF_SUPPLIED_0006ET.CreateNewFieldRedefine(Names.WS_FLAG_0006XX, FieldType.String, WS_FLAG_0006_local, 1);
                   });
               });
           });

            recordDef.CreateNewGroup(Names.WS_CONSTANTS, (WS_CONSTANTS) =>
           {
               WS_CONSTANTS.CreateNewField(Names.WS_SRCICSY, FieldType.String, 8, "SRCICSY ");
               WS_CONSTANTS.CreateNewField(Names.WS_SRXK_NAME, FieldType.String, 4, "SRXK");
               WS_CONSTANTS.CreateNewField(Names.WS_SWE00554_PGM, FieldType.String, 8, "SWE00554");
               WS_CONSTANTS.CreateNewGroup(Names.WS_WARN_MESSAGE, (WS_WARN_MESSAGE) =>
               {
                   WS_WARN_MESSAGE.CreateNewField(Names.WS_WARN_MSG1, FieldType.String, 50, "You have violated KAESCES-CSE security by entering");
                   WS_WARN_MESSAGE.CreateNewField(Names.WS_WARN_MSG2, FieldType.String, 28, " an invalid transaction.   ");
                   WS_WARN_MESSAGE.CreateNewField(Names.WS_WARN_MSG3, FieldType.String, 43, " You will automatically be prompted to SRXK");
                   WS_WARN_MESSAGE.CreateNewField(Names.WS_WARN_MSG4, FieldType.String, 16, " in 5 seconds...");
               });
           });

            recordDef.CreateNewGroup(Names.WS_POINTERS, (WS_POINTERS) =>
           {
               WS_POINTERS.CreateNewField(Names.CSE_SECURE_ADDR, FieldType.ReferencePointer, 4);
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
    internal class SWEXGC05_ls : PredefinedRecordBase
    {
        #region Name constants
        /// <summary>
        /// Name constants.
        /// </summary>
        internal static class Names
        {
            internal const string LinkageSection = "SWEXGC05_ls_LinkageSection";
            internal const string LK_PARMS = "LK_PARMS";
            internal const string LK_USER_ID = "LK_USER_ID";
            internal const string LK_TRANCODE = "LK_TRANCODE";
            internal const string CSE_USER = "CSE_USER";
        }
        #endregion

        #region Direct-access element properties
        public IGroup LK_PARMS { get { return GetElementByName<IGroup>(Names.LK_PARMS); } }
        public IField LK_USER_ID { get { return GetElementByName<IField>(Names.LK_USER_ID); } }
        public IField LK_TRANCODE { get { return GetElementByName<IField>(Names.LK_TRANCODE); } }
        public IField CSE_USER { get { return GetElementByName<IField>(Names.CSE_USER); } }

        #endregion

        #region Data structure definition
        /// <summary>
        /// Defines the entirety of the LinkageSection IRecord structure as described by the Ateras.Framework.Buffer API.
        /// </summary>
        /// <param name="recordDef">The IStructureDefinition object to be used in defining the record structure.</param>
        protected override void DefineRecordStructure(IStructureDefinition recordDef)
        {

            recordDef.CreateNewGroup(Names.LK_PARMS, (LK_PARMS) =>
           {
               LK_PARMS.CreateNewField(Names.LK_USER_ID, FieldType.String, 8);
               LK_PARMS.CreateNewField(Names.LK_TRANCODE, FieldType.String, 8);
           });
            recordDef.CreateNewField(Names.CSE_USER, FieldType.String, 1);

        }

        protected override string GetRecordName()
        {
            return Names.LinkageSection;
        }
        #endregion

        public void SetPassedParameters(object[] args)
        {
            SetPassedParm(LK_PARMS, args, 0);
        }


        public void UpdateReturnParameters(object[] args)
        {
            SetReturnParm(LK_PARMS, args, 0);
        }
    }
    #endregion Linkage Section Class

    #region Business Logic Class
    public class SWEXGC05 : OnlineEABBase
    {

        #region Public Constructors
        public SWEXGC05()
            : base()
        {
            SetUpProgram();
        }

        public SWEXGC05(OnlineControl controlData) : base(controlData)
        {
            SetUpProgram();
        }

        private void SetUpProgram()
        {
            this.ProgramName = "SWEXGC05";

            WS = new SWEXGC05_ws();
            LS = new SWEXGC05_ls();
        }

        #endregion

        #region Private Fields


        //==== Working Storage Data Class ========================================
        private SWEXGC05_ws WS;

        //==== Linkage Section Data Class ========================================
        private SWEXGC05_ls LS;
        #endregion

        #region Public Methods
        //========================================================================
        //==== RunMain Entry Point Method ========================================
        //========================================================================
        public override int ExecuteMain(params object[] args)                                              //COBOL==> PROCEDURE DIVISION USING LK-PARMS.
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
            M_MAIN_PARA(returnMethod);
        }
        /// <summary>
        /// Method M_MAIN_PARA
        /// </summary>
        private void M_MAIN_PARA(string returnMethod = "")
        {
            M_INIT_PARA("M_INIT_PARA_EXIT"); if (Control.ExitProgram) { return; }                                 //COBOL==> PERFORM INIT-PARA THRU INIT-PARA-EXIT
            M_GET_APPLID_PARA("M_GET_APPLID_PARA_EXIT"); if (Control.ExitProgram) { return; }                     //COBOL==> PERFORM GET-APPLID-PARA THRU GET-APPLID-PARA-EXIT
            if (WS.WS_REGION.IsEqualTo(WS.WS_SRCICSY))                                                          //COBOL==> IF WS-REGION = WS-SRCICSY
            {
                M_PROCESS_PARA("M_PROCESS_PARA_EXIT"); if (Control.ExitProgram) { return; }                           //COBOL==> PERFORM PROCESS-PARA THRU PROCESS-PARA-EXIT
                if (LS.CSE_USER.IsEqualTo("Y"))                                                                     //COBOL==> IF CSE-USER = 'Y'
                {
                    //Continue                                                                                          //COBOL==> CONTINUE
                }                                                                                                   //COBOL==> ELSE
                else
                {
                    M_CALL_SECURITY_CAB_PARA("M_CALL_SECURITY_CAB_PARA_EXIT"); if (Control.ExitProgram) { return; }       //COBOL==> PERFORM CALL-SECURITY-CAB-PARA THRU CALL-SECURITY-CAB-PARA-EXIT
                    if (WS.WS_FLAG_0006.IsEqualTo("N"))                                                                 //COBOL==> IF WS-FLAG-0006 = 'N'
                    {
                        M_DISPLAY_WARNING_PARA("M_DISPLAY_WARNING_PARA_EXIT"); if (Control.ExitProgram) { return; }           //COBOL==> PERFORM DISPLAY-WARNING-PARA THRU DISPLAY-WARNING-PARA-EXIT
                        StopExecution(); return;                                                                          //COBOL==> STOP RUN
                    }                                                                                                   //COBOL==> END-IF
                }                                                                                                   //COBOL==> END-IF
            }                                                                                                   //COBOL==> END-IF.
            Control.ExitProgram = true; return;                                                                 //COBOL==> GOBACK.
        }
        /// <summary>
        /// Method M_GET_APPLID_PARA
        /// </summary>
        private void M_GET_APPLID_PARA(string returnMethod = "")
        {
            WS.WS_REGION.SetValue(ServiceControl.APPLID);                                                       //COBOL==> EXEC CICS ASSIGN APPLID ( WS-REGION ) END-EXEC.
            if (returnMethod != "" && returnMethod != "M_GET_APPLID_PARA") { M_GET_APPLID_PARA_EXIT(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_GET_APPLID_PARA_EXIT
        /// </summary>
        private void M_GET_APPLID_PARA_EXIT(string returnMethod = "")
        {
            if (returnMethod == "M_GET_APPLID_PARA_EXIT") { return; }                                           //COBOL==> EXIT.
            if (returnMethod != "" && returnMethod != "M_GET_APPLID_PARA_EXIT") { M_PROCESS_PARA(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_PROCESS_PARA
        /// </summary>
        private void M_PROCESS_PARA(string returnMethod = "")
        {
            LS.CSE_USER.SetBufferReference(WS.CSE_SECURE_ADDR);                                                 //COBOL==> SET ADDRESS OF CSE-USER TO CSE-SECURE-ADDR.
            if (returnMethod != "" && returnMethod != "M_PROCESS_PARA") { M_PROCESS_PARA_EXIT(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_PROCESS_PARA_EXIT
        /// </summary>
        private void M_PROCESS_PARA_EXIT(string returnMethod = "")
        {
            if (returnMethod == "M_PROCESS_PARA_EXIT") { return; }                                              //COBOL==> EXIT.
            if (returnMethod != "" && returnMethod != "M_PROCESS_PARA_EXIT") { M_CALL_SECURITY_CAB_PARA(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_CALL_SECURITY_CAB_PARA
        /// </summary>
        private void M_CALL_SECURITY_CAB_PARA(string returnMethod = "")
        {
            WS.WS_RUNTIME_PARM1.ResetToInitialValue();                                                          //COBOL==> INITIALIZE WS-RUNTIME-PARM1 WS-RUNTIME-PARM2 WS-GLOBDATA WS-IMPORT-0005EV WS-IMPORT-0006EV WS-EXP-SECURITY-BYPASS--0006EV.
            WS.WS_RUNTIME_PARM2.ResetToInitialValue();
            WS.WS_GLOBDATA.ResetToInitialValue();
            WS.WS_IMPORT_0005EV.ResetToInitialValue();
            WS.WS_IMPORT_0006EV.ResetToInitialValue();
            WS.WS_EXP_SECURITY_BYPASS__0006EV.ResetToInitialValue();
            WS.WS_USER_ID_0005.SetValue(LS.LK_USER_ID);                                                         //COBOL==> MOVE LK-USER-ID TO WS-USER-ID-0005.
            WS.WS_TRANCODE_0006.SetValue(LS.LK_TRANCODE);                                                       //COBOL==> MOVE LK-TRANCODE TO WS-TRANCODE-0006.
            Control.Call(WS.WS_SWE00554_PGM.AsString(), WS.WS_RUNTIME_PARM1, WS.WS_RUNTIME_PARM2, WS.WS_GLOBDATA, WS.WS_IMPORT_0005EV, WS.WS_IMPORT_0006EV, WS.WS_EXP_SECURITY_BYPASS__0006EV); if (Control.ExitProgram) return;  //COBOL==> CALL WS-SWE00554-PGM USING WS-RUNTIME-PARM1 WS-RUNTIME-PARM2 WS-GLOBDATA WS-IMPORT-0005EV WS-IMPORT-0006EV WS-EXP-SECURITY-BYPASS--0006EV.
        }
        /// <summary>
        /// Method M_CALL_SECURITY_CAB_PARA_EXIT
        /// </summary>
        private void M_CALL_SECURITY_CAB_PARA_EXIT(string returnMethod = "")
        {
            if (returnMethod == "M_CALL_SECURITY_CAB_PARA_EXIT") { return; }                                    //COBOL==> EXIT.
            if (returnMethod != "" && returnMethod != "M_CALL_SECURITY_CAB_PARA_EXIT") { M_DISPLAY_WARNING_PARA(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_DISPLAY_WARNING_PARA
        /// </summary>
        private void M_DISPLAY_WARNING_PARA(string returnMethod = "")
        {
            WS.WS_MESSAGE_LENGTH.SetValue(WS.WS_WARN_MESSAGE.LengthInBuffer);                                   //COBOL==> MOVE LENGTH OF WS-WARN-MESSAGE TO WS-MESSAGE-LENGTH.
            Map.SendText(WS.WS_WARN_MESSAGE, WS.WS_MESSAGE_LENGTH.LengthInBuffer, SendOption.Erase); if (CheckHandleConditions(returnMethod)) { return; }  //COBOL==> EXEC CICS SEND TEXT FROM ( WS-WARN-MESSAGE ) LENGTH ( WS-MESSAGE-LENGTH ) WAIT ERASE END-EXEC.
            Control.Delay(5, "DELACODE");                                                                       //COBOL==> EXEC CICS DELAY FOR SECONDS ( 5 ) REQID ( 'DELACODE' ) END-EXEC.
            WS.WS_NAME_LENGTH.SetValue(WS.WS_SRXK_NAME.LengthInBuffer);                                         //COBOL==> MOVE LENGTH OF WS-SRXK-NAME TO WS-NAME-LENGTH.
            Map.SendFrom(WS.WS_SRXK_NAME, WS.WS_NAME_LENGTH.AsInt(), SendOption.Erase); if (CheckHandleConditions(returnMethod)) { return; }  //COBOL==> EXEC CICS SEND FROM ( WS-SRXK-NAME ) LENGTH ( WS-NAME-LENGTH ) ERASE END-EXEC.
            if (returnMethod != "" && returnMethod != "M_DISPLAY_WARNING_PARA") { M_DISPLAY_WARNING_PARA_EXIT(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_DISPLAY_WARNING_PARA_EXIT
        /// </summary>
        private void M_DISPLAY_WARNING_PARA_EXIT(string returnMethod = "")
        {
            if (returnMethod == "M_DISPLAY_WARNING_PARA_EXIT") { return; }                                      //COBOL==> EXIT.
            if (returnMethod != "" && returnMethod != "M_DISPLAY_WARNING_PARA_EXIT") { M_INIT_PARA(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_INIT_PARA
        /// </summary>
        private void M_INIT_PARA(string returnMethod = "")
        {
            WS.WS_NAME_LENGTH.SetValue(ZEROES);                                                                 //COBOL==> MOVE ZEROES TO WS-NAME-LENGTH.
            WS.WS_MESSAGE_LENGTH.SetValue(ZEROES);                                                              //COBOL==> MOVE ZEROES TO WS-MESSAGE-LENGTH.
            WS.WS_REGION.SetValueWithSpaces();                                                                  //COBOL==> MOVE SPACES TO WS-REGION.
            WS.WS_FLAG_0006.SetValueWithSpaces();                                                               //COBOL==> MOVE SPACES TO WS-FLAG-0006.
            if (returnMethod != "" && returnMethod != "M_INIT_PARA") { M_INIT_PARA_EXIT(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_INIT_PARA_EXIT
        /// </summary>
        private void M_INIT_PARA_EXIT(string returnMethod = "")
        {
            if (returnMethod == "M_INIT_PARA_EXIT") { return; }                                                 //COBOL==> EXIT.
        }
        #endregion
    }
    #endregion
}
