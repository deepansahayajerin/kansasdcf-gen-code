#region Comments
/* Conversion Comments
   ************************************************************
   **   MODERN SYSTEMS INC.  COPYRIGHT 2000-2022
   **   DB-SHUTTLE COBOL to C# Conversion
   ************************************************************
   ** INIT   *  INITIAL VERSION   *  2022-01-14 12:46:09 PM
   **        *   FROM COBOL PGM   :  SWASZ022
   **        *   FROM CANISTER    :  SR.CAECSES.PROD.LIBR.SOURCE.PDS
   ************************************************************ */

/* Original Program Identification Comments
   DATE-COMPILED.
   
   
   **** START DOCUMENTATION ****************************************
   *                                                              **
   *    SYSTEM:  CAECSES  - AUTOMATED ELIGIBILITY                 **
   *                                                              **
   *    PROGRAM: SWASZ022 - FORMAT DATABASE NAME TO DISPLAY FORM. **
   *                                                              **
   *    DESCRIPTION:                                              **
   *        THIS PROGRAM FORMATS A DB NAME INTO DISPLAY FORMAT.   **
   *                                                              **
   *    PROCESSING:                                               **
   *        THIS PROGRAM 0CCEPTS PARAMETERS FROM THE CALLING      **
   *        MODULE AND FORMATS A DATABASE NAME INTO DISPLAY       **
   *        FORMAT.  A DATABASE NAME IS THIRTY CHARACTERS LONG,   **
   *        WITH THE FIRST SEVENTEEN REPRESENTING THE SURNAME,    **
   *        THE NEXT TWELVE, THE GIVEN NAME, AND THE LAST, AN     **
   *        INITIAL.  THE DISPLAY FORMAT HAS THE SAME FIELD       **
   *        SEQUENCE EXCEPT THAT THE FIELDS ARE COMPRESSED WITH A **
   *        COMMA SEPARATING THE SURNAME AND GIVEN NAME.          **
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
   *        FILE                INPUT  UPDATE  ADD  DELETE        **
   *        NONE                                                  **
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
   
   
   
   **** START MAINTENANCE LOG ************ PROGRAM SWASZ022 ********
   *                                                              **
   *    MAINTENANCE LOG                                           **
   *        AUTHOR     DATE    CHG REQ #  DESCRIPTION             **
   *                                                              **
   **** END MAINTENANCE LOG ****************************************
   
   ----------------------------------------------------------------*
    CTA MODIFICATION                                               *
                                                                   *
    CONTRACT NO: 31994                                             *
    CHANGES MADE FOR Y2K PROCESSING - CTA Y2K SRS                  *
    NO CHANGES MADE                                                *
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
    internal class SWASZ022_ws : PredefinedRecordBase
    {
        #region Name constants
        /// <summary>
        /// Name constants.
        /// </summary>
        internal static class Names
        {
            internal const string WorkingStorage = "SWASZ022_ws_WorkingStorage";
            internal const string NDX_GIVEN = "NDX_GIVEN";
            internal const string NDX_NAME = "NDX_NAME";
        }
        #endregion

        #region Direct-access element properties
        public IField NDX_GIVEN { get { return GetElementByName<IField>(Names.NDX_GIVEN); } }
        public IField NDX_NAME { get { return GetElementByName<IField>(Names.NDX_NAME); } }

        #endregion

        #region Data structure definition
        /// <summary>
        /// Defines the entirety of the WorkingStorage IRecord structure as described by the Ateras.Framework.Buffer API.
        /// </summary>
        /// <param name="recordDef">The IStructureDefinition object to be used in defining the record structure.</param>
        protected override void DefineRecordStructure(IStructureDefinition recordDef)
        {
            recordDef.CreateNewField(Names.NDX_GIVEN, FieldType.CompShort, 4);
            recordDef.CreateNewField(Names.NDX_NAME, FieldType.CompShort, 4);

        }

        protected override string GetRecordName()
        {
            return Names.WorkingStorage;
        }
        #endregion

    }
    #endregion Working Storage Class

    #region Linkage Section Class
    internal class SWASZ022_ls : PredefinedRecordBase
    {
        #region Name constants
        /// <summary>
        /// Name constants.
        /// </summary>
        internal static class Names
        {
            internal const string LinkageSection = "SWASZ022_ls_LinkageSection";
            internal const string PV_DB_NAME = "PV_DB_NAME";
            internal const string PV_SURNAME = "PV_SURNAME";
            internal const string PV_GIVEN_NAME = "PV_GIVEN_NAME";
            internal const string PV_GIVEN_CHAR = "PV_GIVEN_CHAR";
            internal const string PV_INITIAL = "PV_INITIAL";
            internal const string PV_SCREEN_NAME = "PV_SCREEN_NAME";
            internal const string PV_NAME_CHAR = "PV_NAME_CHAR";
        }
        #endregion

        #region Direct-access element properties
        public IGroup PV_DB_NAME { get { return GetElementByName<IGroup>(Names.PV_DB_NAME); } }
        public IField PV_SURNAME { get { return GetElementByName<IField>(Names.PV_SURNAME); } }
        public IField PV_GIVEN_NAME { get { return GetElementByName<IField>(Names.PV_GIVEN_NAME); } }
        public IArrayElementAccessor<IField> PV_GIVEN_CHAR { get { return GetArrayElementAccessor<IField>(Names.PV_GIVEN_CHAR); } }
        public IField PV_INITIAL { get { return GetElementByName<IField>(Names.PV_INITIAL); } }
        public IGroup PV_SCREEN_NAME { get { return GetElementByName<IGroup>(Names.PV_SCREEN_NAME); } }
        public IArrayElementAccessor<IField> PV_NAME_CHAR { get { return GetArrayElementAccessor<IField>(Names.PV_NAME_CHAR); } }

        #endregion

        #region Data structure definition
        /// <summary>
        /// Defines the entirety of the LinkageSection IRecord structure as described by the Ateras.Framework.Buffer API.
        /// </summary>
        /// <param name="recordDef">The IStructureDefinition object to be used in defining the record structure.</param>
        protected override void DefineRecordStructure(IStructureDefinition recordDef)
        {

            recordDef.CreateNewGroup(Names.PV_DB_NAME, (PV_DB_NAME) =>
           {
               PV_DB_NAME.CreateNewField(Names.PV_SURNAME, FieldType.String, 17);

               IField PV_GIVEN_NAME_local = PV_DB_NAME.CreateNewField(Names.PV_GIVEN_NAME, FieldType.String, 12);
               PV_DB_NAME.CreateNewGroupRedefine("FILLER", PV_GIVEN_NAME_local, (FILLER) =>
               {
                   FILLER.CreateNewFieldArray(Names.PV_GIVEN_CHAR, 12, FieldType.String, 1);
               });
               PV_DB_NAME.CreateNewField(Names.PV_INITIAL, FieldType.String, 1);
           });

            recordDef.CreateNewGroup(Names.PV_SCREEN_NAME, (PV_SCREEN_NAME) =>
           {
               PV_SCREEN_NAME.CreateNewFieldArray(Names.PV_NAME_CHAR, 32, FieldType.String, 1);
           });

        }

        protected override string GetRecordName()
        {
            return Names.LinkageSection;
        }
        #endregion

        public void SetPassedParameters(object[] args)
        {
            SetPassedParm(PV_DB_NAME, args, 0);
            SetPassedParm(PV_SCREEN_NAME, args, 1);
        }


        public void UpdateReturnParameters(object[] args)
        {
            SetReturnParm(PV_DB_NAME, args, 0);
            SetReturnParm(PV_SCREEN_NAME, args, 1);
        }
    }
    #endregion Linkage Section Class

    #region Business Logic Class
    public class SWASZ022 : BatchBase
    {

        #region Public Constructors
        public SWASZ022()
            : base()
        {
            this.ProgramName.SetValue("SWASZ022");

            WS = new SWASZ022_ws();
            LS = new SWASZ022_ls();
        }

        #endregion

        #region Private Fields


        //==== Working Storage Data Class ========================================
        private SWASZ022_ws WS;

        //==== Linkage Section Data Class ========================================
        private SWASZ022_ls LS;
        #endregion

        #region Public Methods
        //========================================================================
        //==== RunMain Entry Point Method ========================================
        //========================================================================
        public override int ExecuteMain(params object[] args)                                              //COBOL==> PROCEDURE DIVISION USING PV-DB-NAME PV-SCREEN-NAME.
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
            M_0000_FORMAT_NAME(returnMethod);
        }
        /// <summary>
        /// Method M_0000_FORMAT_NAME
        /// </summary>
        private void M_0000_FORMAT_NAME(string returnMethod = "")
        {
            if (LS.PV_SURNAME.IsGreaterThan(SPACES))                                                            //COBOL==> IF PV-SURNAME > SPACES
            {
                goto EndOfSentence_1;                                                                               //COBOL==> NEXT SENTENCE
            }                                                                                                   //COBOL==> ELSE
            else
            {
                LS.PV_SCREEN_NAME.SetValueWithSpaces();                                                             //COBOL==> MOVE SPACES TO PV-SCREEN-NAME
                M_0000_EXIT(CheckGotoReturn(returnMethod)); return;                                                 //COBOL==> GO TO 0000-EXIT.
            }
        EndOfSentence_1:;
            LS.PV_SCREEN_NAME.SetValue(LS.PV_SURNAME);                                                          //COBOL==> MOVE PV-SURNAME TO PV-SCREEN-NAME.
            if (LS.PV_GIVEN_NAME.IsGreaterThan(SPACES))                                                         //COBOL==> IF PV-GIVEN-NAME > SPACES
            {
                WS.NDX_NAME.SetValue(17);                                                                           //COBOL==> SET NDX-NAME TO 17
                while (!((WS.NDX_NAME.IsLessThan(2)) && (LS.PV_NAME_CHAR[2].IsGreaterThan(SPACES))))                //COBOL==> PERFORM 2000-ADD-COMMA-AND-NAME THRU 2000-EXIT UNTIL NDX-NAME < 2 AND PV-NAME-CHAR ( 2 ) > SPACES.
                {
                    M_2000_ADD_COMMA_AND_NAME("M_2000_EXIT"); if (Control.ExitProgram) { return; }
                }
            }
            if ((LS.PV_INITIAL.IsGreaterThan(SPACES))
             && (LS.PV_NAME_CHAR[31].IsSpaces()))      //COBOL==> IF PV-INITIAL > SPACE AND PV-NAME-CHAR ( 31 ) = SPACE
            {
                WS.NDX_NAME.SetValue(30);                                                                           //COBOL==> SET NDX-NAME TO 30
                while (!(WS.NDX_NAME.IsLessThan(2)))                                                                //COBOL==> PERFORM 4000-ADD-INITIAL THRU 4000-EXIT UNTIL NDX-NAME < 2.
                {
                    M_4000_ADD_INITIAL("M_4000_EXIT"); if (Control.ExitProgram) { return; }
                }
            }
            if (returnMethod != "" && returnMethod != "M_0000_FORMAT_NAME") { M_0000_EXIT(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_0000_EXIT
        /// </summary>
        private void M_0000_EXIT(string returnMethod = "")
        {
            Control.ExitProgram = true; return;                                                                 //COBOL==> GOBACK.
        }
        /// <summary>
        /// Method M_2000_ADD_COMMA_AND_NAME
        /// </summary>
        private void M_2000_ADD_COMMA_AND_NAME(string returnMethod = "")
        {
            if (LS.PV_NAME_CHAR[WS.NDX_NAME.AsInt()].IsGreaterThan(SPACES))                                     //COBOL==> IF PV-NAME-CHAR ( NDX-NAME ) > SPACE
            {
                WS.NDX_NAME.Add(1);                                                                                 //COBOL==> SET NDX-NAME UP BY 1
                LS.PV_NAME_CHAR[WS.NDX_NAME.AsInt()].SetValue(",");                                                 //COBOL==> MOVE ',' TO PV-NAME-CHAR ( NDX-NAME )
                WS.NDX_NAME.Add(2);                                                                                 //COBOL==> SET NDX-NAME UP BY 2
                WS.NDX_GIVEN.SetValue(1);                                                                           //COBOL==> SET NDX-GIVEN TO 1
                while (!(WS.NDX_GIVEN.IsGreaterThan(12)))                                                           //COBOL==> PERFORM 2200-MOVE-NAME THRU 2200-EXIT UNTIL NDX-GIVEN > 12
                {
                    M_2200_MOVE_NAME("M_2200_EXIT"); if (Control.ExitProgram) { return; }
                }
                WS.NDX_NAME.SetValue(1);                                                                            //COBOL==> SET NDX-NAME TO 1
            }                                                                                                   //COBOL==> ELSE
            else
            {
                WS.NDX_NAME.Subtract(1);                                                                            //COBOL==> SET NDX-NAME DOWN BY 1.
            }
            if (returnMethod != "" && returnMethod != "M_2000_ADD_COMMA_AND_NAME") { M_2000_EXIT(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_2000_EXIT
        /// </summary>
        private void M_2000_EXIT(string returnMethod = "")
        {
            if (returnMethod == "M_2000_EXIT") { return; }                                                      //COBOL==> EXIT.
            if (returnMethod != "" && returnMethod != "M_2000_EXIT") { M_2200_MOVE_NAME(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_2200_MOVE_NAME
        /// </summary>
        private void M_2200_MOVE_NAME(string returnMethod = "")
        {
            LS.PV_NAME_CHAR[WS.NDX_NAME.AsInt()].SetValue(LS.PV_GIVEN_CHAR[WS.NDX_GIVEN.AsInt()]);              //COBOL==> MOVE PV-GIVEN-CHAR ( NDX-GIVEN ) TO PV-NAME-CHAR ( NDX-NAME ) .
            WS.NDX_NAME.Add(1);                                                                                 //COBOL==> SET NDX-NAME UP BY 1.
            WS.NDX_GIVEN.Add(1);                                                                                //COBOL==> SET NDX-GIVEN UP BY 1.
            if (returnMethod != "" && returnMethod != "M_2200_MOVE_NAME") { M_2200_EXIT(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_2200_EXIT
        /// </summary>
        private void M_2200_EXIT(string returnMethod = "")
        {
            if (returnMethod == "M_2200_EXIT") { return; }                                                      //COBOL==> EXIT.
            if (returnMethod != "" && returnMethod != "M_2200_EXIT") { M_4000_ADD_INITIAL(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_4000_ADD_INITIAL
        /// </summary>
        private void M_4000_ADD_INITIAL(string returnMethod = "")
        {
            if (LS.PV_NAME_CHAR[WS.NDX_NAME.AsInt()].IsGreaterThan(SPACES))                                     //COBOL==> IF PV-NAME-CHAR ( NDX-NAME ) > SPACE
            {
                WS.NDX_NAME.Add(2);                                                                                 //COBOL==> SET NDX-NAME UP BY 2
                LS.PV_NAME_CHAR[WS.NDX_NAME.AsInt()].SetValue(LS.PV_INITIAL);                                       //COBOL==> MOVE PV-INITIAL TO PV-NAME-CHAR ( NDX-NAME )
                WS.NDX_NAME.SetValue(1);                                                                            //COBOL==> SET NDX-NAME TO 1
            }                                                                                                   //COBOL==> ELSE
            else
            {
                WS.NDX_NAME.Subtract(1);                                                                            //COBOL==> SET NDX-NAME DOWN BY 1.
            }
            if (returnMethod != "" && returnMethod != "M_4000_ADD_INITIAL") { M_4000_EXIT(returnMethod); }  //Check for pass through to next method
        }
        /// <summary>
        /// Method M_4000_EXIT
        /// </summary>
        private void M_4000_EXIT(string returnMethod = "")
        {
            if (returnMethod == "M_4000_EXIT") { return; }                                                      //COBOL==> EXIT.
        }
        #endregion
    }
    #endregion
}
