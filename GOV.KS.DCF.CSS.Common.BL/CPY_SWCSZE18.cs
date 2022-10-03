// ***************************************************************
// **   ATERAS INC.  COPYRIGHT 2000-2021
// **   DB-SHUTTLE COBOL Copybook to C# Conversion
// ***************************************************************
// ** MOD ID * DESC                   *   DATE
// ***************************************************************
// ** INIT   *  INITIAL VERSION       *  2021-10-26 01:02:19 PM
// **        *   FROM COBOL COPYBOOK  :  SWCSZE18
// **        *   FROM CANISTER        :  SR.CAECSES.PROD.LIBR.SOURCE.PDS
// **        *   SOURCE TYPE          :  COBOL COPYBOOK
// ***************************************************************
// ***************************************************************
using MDSY.Framework.Buffer;
using MDSY.Framework.Buffer.BaseClasses;
using MDSY.Framework.Buffer.Common;
using MDSY.Framework.Buffer.Interfaces;
using MDSY.Framework.IO.Common;

namespace GOV.KS.DCF.CSS.Common.BL
{
    public class CPY_SWCSZE18 : PredefinedRecordBase
    {
        #region Name constants
        /// <summary>
        /// Name constants.
        /// </summary>
        internal static class Names
        {
            internal const string CPY_SWCSZE18 = "CPY_SWCSZE18";
            internal const string EXTFILE = "EXTFILE";
            internal const string EXTFILE_RECORD = "EXTFILE_RECORD";
        }
        #endregion

        #region Direct-access element properties
        public IFileLink EXTFILE { get; set; }
        public IField EXTFILE_RECORD { get { return GetElementByName<IField>(Names.EXTFILE_RECORD); } }

        #endregion

        #region Data structure definition
        /// <summary>
        /// Defines the entirety of the CPY_SWCSZE18 IRecord structure as described by the Ateras.Framework.Buffer API.
        /// </summary>
        /// <param name="recordDef">The IStructureDefinition object to be used in defining the record structure.</param>
        protected override void DefineRecordStructure(IStructureDefinition recordDef)
        {
            recordDef.CreateNewField(Names.EXTFILE_RECORD, FieldType.String, 335);

        }

        protected override string GetRecordName()
        {
            return Names.CPY_SWCSZE18;
        }
        #endregion


        #region Public Constructors

        public CPY_SWCSZE18(IRecord recordBuffer, bool isNewCopy)
            : base()
        {
            if (isNewCopy || recordBuffer.AsBytes() == null)
                this.Record.ResetToInitialValue();
            else
                this.Record.AssignFrom(recordBuffer.AsBytes());
        }
        public CPY_SWCSZE18()
            : base()
        {

            this.Record.ResetToInitialValue();
        }
        #endregion
    }

}
