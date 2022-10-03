#region Comments
/* Conversion Comments
   ************************************************************
   **   MODERN SYSTEMS INC.  COPYRIGHT 2000-2022
   **   DB-SHUTTLE COBOL to C# Conversion
   ************************************************************
   ** INIT   *  INITIAL VERSION   *  2022-01-14 12:46:20 PM
   **        *   FROM COBOL PGM   :  SWASZ037
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
    internal class SWASZ037_ws : PredefinedRecordBase
    {
        #region Name constants
        /// <summary>
        /// Name constants.
        /// </summary>
        internal static class Names
        {
            internal const string WorkingStorage = "SWASZ037_ws_WorkingStorage";
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
    internal class SWASZ037_ls : PredefinedRecordBase
    {
        #region Name constants
        /// <summary>
        /// Name constants.
        /// </summary>
        internal static class Names
        {
            internal const string LinkageSection = "SWASZ037_ls_LinkageSection";
            internal const string PV_DATE_IN = "PV_DATE_IN";
            internal const string MV_DATE_IN_Y1 = "MV_DATE_IN_Y1";
            internal const string MV_DATE_IN_Y2 = "MV_DATE_IN_Y2";
            internal const string MV_DATE_IN_Y3 = "MV_DATE_IN_Y3";
            internal const string MV_DATE_IN_Y4 = "MV_DATE_IN_Y4";
            internal const string MV_DATE_IN_MM = "MV_DATE_IN_MM";
            internal const string MV_DATE_IN_D1 = "MV_DATE_IN_D1";
            internal const string MV_DATE_IN_D2 = "MV_DATE_IN_D2";
            internal const string PV_DATE_OUT = "PV_DATE_OUT";
            internal const string MV_DATE_OUT_CHAR = "MV_DATE_OUT_CHAR";
            internal const string PV_DATE_OUT_LEN = "PV_DATE_OUT_LEN";
        }
        #endregion

        #region Direct-access element properties
        public IField PV_DATE_IN { get { return GetElementByName<IField>(Names.PV_DATE_IN); } }
        public IField MV_DATE_IN_Y1 { get { return GetElementByName<IField>(Names.MV_DATE_IN_Y1); } }
        public IField MV_DATE_IN_Y2 { get { return GetElementByName<IField>(Names.MV_DATE_IN_Y2); } }
        public IField MV_DATE_IN_Y3 { get { return GetElementByName<IField>(Names.MV_DATE_IN_Y3); } }
        public IField MV_DATE_IN_Y4 { get { return GetElementByName<IField>(Names.MV_DATE_IN_Y4); } }
        public IField MV_DATE_IN_MM { get { return GetElementByName<IField>(Names.MV_DATE_IN_MM); } }
        public IField MV_DATE_IN_D1 { get { return GetElementByName<IField>(Names.MV_DATE_IN_D1); } }
        public IField MV_DATE_IN_D2 { get { return GetElementByName<IField>(Names.MV_DATE_IN_D2); } }
        public IField PV_DATE_OUT { get { return GetElementByName<IField>(Names.PV_DATE_OUT); } }
        public IArrayElementAccessor<IField> MV_DATE_OUT_CHAR { get { return GetArrayElementAccessor<IField>(Names.MV_DATE_OUT_CHAR); } }
        public IField PV_DATE_OUT_LEN { get { return GetElementByName<IField>(Names.PV_DATE_OUT_LEN); } }

        #endregion

        #region Data structure definition
        /// <summary>
        /// Defines the entirety of the LinkageSection IRecord structure as described by the Ateras.Framework.Buffer API.
        /// </summary>
        /// <param name="recordDef">The IStructureDefinition object to be used in defining the record structure.</param>
        protected override void DefineRecordStructure(IStructureDefinition recordDef)
        {

            IField PV_DATE_IN_local = recordDef.CreateNewField(Names.PV_DATE_IN, FieldType.UnsignedNumeric, 8);
            recordDef.CreateNewGroupRedefine("FILLER", PV_DATE_IN_local, (FILLER) =>
            {
                FILLER.CreateNewField(Names.MV_DATE_IN_Y1, FieldType.String, 1);
                FILLER.CreateNewField(Names.MV_DATE_IN_Y2, FieldType.String, 1);
                FILLER.CreateNewField(Names.MV_DATE_IN_Y3, FieldType.String, 1);
                FILLER.CreateNewField(Names.MV_DATE_IN_Y4, FieldType.String, 1);
                FILLER.CreateNewField(Names.MV_DATE_IN_MM, FieldType.UnsignedNumeric, 2);
                FILLER.CreateNewField(Names.MV_DATE_IN_D1, FieldType.String, 1);
                FILLER.CreateNewField(Names.MV_DATE_IN_D2, FieldType.String, 1);
            });

            IField PV_DATE_OUT_local = recordDef.CreateNewField(Names.PV_DATE_OUT, FieldType.String, 18);
            recordDef.CreateNewGroupRedefine("FILLER_d2", PV_DATE_OUT_local, (FILLER_d2) =>
            {
                FILLER_d2.CreateNewFieldArray(Names.MV_DATE_OUT_CHAR, 18, FieldType.String, 1);
            });
            recordDef.CreateNewField(Names.PV_DATE_OUT_LEN, FieldType.UnsignedNumeric, 2);

        }

        protected override string GetRecordName()
        {
            return Names.LinkageSection;
        }
        #endregion

        public void SetPassedParameters(object[] args)
        {
            SetPassedParm(PV_DATE_IN, args, 0);
            SetPassedParm(PV_DATE_OUT, args, 1);
            SetPassedParm(PV_DATE_OUT_LEN, args, 2);
        }


        public void UpdateReturnParameters(object[] args)
        {
            SetReturnParm(PV_DATE_IN, args, 0);
            SetReturnParm(PV_DATE_OUT, args, 1);
            SetReturnParm(PV_DATE_OUT_LEN, args, 2);
        }
    }
    #endregion Linkage Section Class

    #region Business Logic Class
    public class SWASZ037 : BatchBase
    {

        #region Public Constructors
        public SWASZ037()
            : base()
        {
            this.ProgramName.SetValue("SWASZ037");

            WS = new SWASZ037_ws();
            LS = new SWASZ037_ls();
        }

        #endregion

        #region Private Fields


        //==== Working Storage Data Class ========================================
        private SWASZ037_ws WS;

        //==== Linkage Section Data Class ========================================
        private SWASZ037_ls LS;
        #endregion

        #region Public Methods
        //========================================================================
        //==== RunMain Entry Point Method ========================================
        //========================================================================
        public override int ExecuteMain(params object[] args)                                              //COBOL==> PROCEDURE DIVISION USING PV-DATE-IN PV-DATE-OUT PV-DATE-OUT-LEN.
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
            if (LS.MV_DATE_IN_MM.IsEqualTo(1))                                                                  //COBOL==> IF MV-DATE-IN-MM = 1
            {
                LS.PV_DATE_OUT.SetValue("JANUARY");                                                                 //COBOL==> MOVE 'JANUARY' TO PV-DATE-OUT
                LS.PV_DATE_OUT_LEN.SetValue(7);                                                                     //COBOL==> MOVE 7 TO PV-DATE-OUT-LEN
            }                                                                                                   //COBOL==> ELSE
            else
            {
                if (LS.MV_DATE_IN_MM.IsEqualTo(2))                                                                  //COBOL==> IF MV-DATE-IN-MM = 2
                {
                    LS.PV_DATE_OUT.SetValue("FEBRUARY");                                                                //COBOL==> MOVE 'FEBRUARY' TO PV-DATE-OUT
                    LS.PV_DATE_OUT_LEN.SetValue(8);                                                                     //COBOL==> MOVE 8 TO PV-DATE-OUT-LEN
                }                                                                                                   //COBOL==> ELSE
                else
                {
                    if (LS.MV_DATE_IN_MM.IsEqualTo(3))                                                                  //COBOL==> IF MV-DATE-IN-MM = 3
                    {
                        LS.PV_DATE_OUT.SetValue("MARCH");                                                                   //COBOL==> MOVE 'MARCH' TO PV-DATE-OUT
                        LS.PV_DATE_OUT_LEN.SetValue(5);                                                                     //COBOL==> MOVE 5 TO PV-DATE-OUT-LEN
                    }                                                                                                   //COBOL==> ELSE
                    else
                    {
                        if (LS.MV_DATE_IN_MM.IsEqualTo(4))                                                                  //COBOL==> IF MV-DATE-IN-MM = 4
                        {
                            LS.PV_DATE_OUT.SetValue("APRIL");                                                                   //COBOL==> MOVE 'APRIL' TO PV-DATE-OUT
                            LS.PV_DATE_OUT_LEN.SetValue(5);                                                                     //COBOL==> MOVE 5 TO PV-DATE-OUT-LEN
                        }                                                                                                   //COBOL==> ELSE
                        else
                        {
                            if (LS.MV_DATE_IN_MM.IsEqualTo(5))                                                                  //COBOL==> IF MV-DATE-IN-MM = 5
                            {
                                LS.PV_DATE_OUT.SetValue("MAY");                                                                     //COBOL==> MOVE 'MAY' TO PV-DATE-OUT
                                LS.PV_DATE_OUT_LEN.SetValue(3);                                                                     //COBOL==> MOVE 3 TO PV-DATE-OUT-LEN
                            }                                                                                                   //COBOL==> ELSE
                            else
                            {
                                if (LS.MV_DATE_IN_MM.IsEqualTo(6))                                                                  //COBOL==> IF MV-DATE-IN-MM = 6
                                {
                                    LS.PV_DATE_OUT.SetValue("JUNE");                                                                    //COBOL==> MOVE 'JUNE' TO PV-DATE-OUT
                                    LS.PV_DATE_OUT_LEN.SetValue(4);                                                                     //COBOL==> MOVE 4 TO PV-DATE-OUT-LEN
                                }                                                                                                   //COBOL==> ELSE
                                else
                                {
                                    if (LS.MV_DATE_IN_MM.IsEqualTo(7))                                                                  //COBOL==> IF MV-DATE-IN-MM = 7
                                    {
                                        LS.PV_DATE_OUT.SetValue("JULY");                                                                    //COBOL==> MOVE 'JULY' TO PV-DATE-OUT
                                        LS.PV_DATE_OUT_LEN.SetValue(4);                                                                     //COBOL==> MOVE 4 TO PV-DATE-OUT-LEN
                                    }                                                                                                   //COBOL==> ELSE
                                    else
                                    {
                                        if (LS.MV_DATE_IN_MM.IsEqualTo(8))                                                                  //COBOL==> IF MV-DATE-IN-MM = 8
                                        {
                                            LS.PV_DATE_OUT.SetValue("AUGUST");                                                                  //COBOL==> MOVE 'AUGUST' TO PV-DATE-OUT
                                            LS.PV_DATE_OUT_LEN.SetValue(6);                                                                     //COBOL==> MOVE 6 TO PV-DATE-OUT-LEN
                                        }                                                                                                   //COBOL==> ELSE
                                        else
                                        {
                                            if (LS.MV_DATE_IN_MM.IsEqualTo(9))                                                                  //COBOL==> IF MV-DATE-IN-MM = 9
                                            {
                                                LS.PV_DATE_OUT.SetValue("SEPTEMBER");                                                               //COBOL==> MOVE 'SEPTEMBER' TO PV-DATE-OUT
                                                LS.PV_DATE_OUT_LEN.SetValue(9);                                                                     //COBOL==> MOVE 9 TO PV-DATE-OUT-LEN
                                            }                                                                                                   //COBOL==> ELSE
                                            else
                                            {
                                                if (LS.MV_DATE_IN_MM.IsEqualTo(10))                                                                 //COBOL==> IF MV-DATE-IN-MM = 10
                                                {
                                                    LS.PV_DATE_OUT.SetValue("OCTOBER");                                                                 //COBOL==> MOVE 'OCTOBER' TO PV-DATE-OUT
                                                    LS.PV_DATE_OUT_LEN.SetValue(7);                                                                     //COBOL==> MOVE 7 TO PV-DATE-OUT-LEN
                                                }                                                                                                   //COBOL==> ELSE
                                                else
                                                {
                                                    if (LS.MV_DATE_IN_MM.IsEqualTo(11))                                                                 //COBOL==> IF MV-DATE-IN-MM = 11
                                                    {
                                                        LS.PV_DATE_OUT.SetValue("NOVEMBER");                                                                //COBOL==> MOVE 'NOVEMBER' TO PV-DATE-OUT
                                                        LS.PV_DATE_OUT_LEN.SetValue(8);                                                                     //COBOL==> MOVE 8 TO PV-DATE-OUT-LEN
                                                    }                                                                                                   //COBOL==> ELSE
                                                    else
                                                    {
                                                        if (LS.MV_DATE_IN_MM.IsEqualTo(12))                                                                 //COBOL==> IF MV-DATE-IN-MM = 12
                                                        {
                                                            LS.PV_DATE_OUT.SetValue("DECEMBER");                                                                //COBOL==> MOVE 'DECEMBER' TO PV-DATE-OUT
                                                            LS.PV_DATE_OUT_LEN.SetValue(8);                                                                     //COBOL==> MOVE 8 TO PV-DATE-OUT-LEN
                                                        }                                                                                                   //COBOL==> ELSE
                                                        else
                                                        {
                                                            LS.PV_DATE_OUT.SetValue("?????????");                                                               //COBOL==> MOVE '?????????' TO PV-DATE-OUT
                                                            LS.PV_DATE_OUT_LEN.SetValue(9);                                                                     //COBOL==> MOVE 9 TO PV-DATE-OUT-LEN.
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            LS.PV_DATE_OUT_LEN.Add(2);                                                                          //COBOL==> ADD 2 TO PV-DATE-OUT-LEN.
            LS.MV_DATE_OUT_CHAR[LS.PV_DATE_OUT_LEN.AsInt()].SetValue(LS.MV_DATE_IN_D1);                         //COBOL==> MOVE MV-DATE-IN-D1 TO MV-DATE-OUT-CHAR ( PV-DATE-OUT-LEN ) .
            LS.PV_DATE_OUT_LEN.Add(1);                                                                          //COBOL==> ADD 1 TO PV-DATE-OUT-LEN.
            LS.MV_DATE_OUT_CHAR[LS.PV_DATE_OUT_LEN.AsInt()].SetValue(LS.MV_DATE_IN_D2);                         //COBOL==> MOVE MV-DATE-IN-D2 TO MV-DATE-OUT-CHAR ( PV-DATE-OUT-LEN ) .
            LS.PV_DATE_OUT_LEN.Add(1);                                                                          //COBOL==> ADD 1 TO PV-DATE-OUT-LEN.
            LS.MV_DATE_OUT_CHAR[LS.PV_DATE_OUT_LEN.AsInt()].SetValue(",");                                      //COBOL==> MOVE ',' TO MV-DATE-OUT-CHAR ( PV-DATE-OUT-LEN ) .
            LS.PV_DATE_OUT_LEN.Add(2);                                                                          //COBOL==> ADD 2 TO PV-DATE-OUT-LEN.
            LS.MV_DATE_OUT_CHAR[LS.PV_DATE_OUT_LEN.AsInt()].SetValue(LS.MV_DATE_IN_Y1);                         //COBOL==> MOVE MV-DATE-IN-Y1 TO MV-DATE-OUT-CHAR ( PV-DATE-OUT-LEN ) .
            LS.PV_DATE_OUT_LEN.Add(1);                                                                          //COBOL==> ADD 1 TO PV-DATE-OUT-LEN.
            LS.MV_DATE_OUT_CHAR[LS.PV_DATE_OUT_LEN.AsInt()].SetValue(LS.MV_DATE_IN_Y2);                         //COBOL==> MOVE MV-DATE-IN-Y2 TO MV-DATE-OUT-CHAR ( PV-DATE-OUT-LEN ) .
            LS.PV_DATE_OUT_LEN.Add(1);                                                                          //COBOL==> ADD 1 TO PV-DATE-OUT-LEN.
            LS.MV_DATE_OUT_CHAR[LS.PV_DATE_OUT_LEN.AsInt()].SetValue(LS.MV_DATE_IN_Y3);                         //COBOL==> MOVE MV-DATE-IN-Y3 TO MV-DATE-OUT-CHAR ( PV-DATE-OUT-LEN ) .
            LS.PV_DATE_OUT_LEN.Add(1);                                                                          //COBOL==> ADD 1 TO PV-DATE-OUT-LEN.
            LS.MV_DATE_OUT_CHAR[LS.PV_DATE_OUT_LEN.AsInt()].SetValue(LS.MV_DATE_IN_Y4);                         //COBOL==> MOVE MV-DATE-IN-Y4 TO MV-DATE-OUT-CHAR ( PV-DATE-OUT-LEN ) .
            Control.ExitProgram = true; return;                                                                 //COBOL==> GOBACK.
        }
        #endregion
    }
    #endregion
}
