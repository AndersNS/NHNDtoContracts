using System.Collections.Generic;
using System.Runtime.Serialization;
using NHN.DtoContracts.Common.en;

namespace NHN.DtoContracts.Flr.Data
{
    /// <summary>
    /// Parametere for export
    /// </summary>
    [DataContract(Namespace = FlrXmlNamespace.V1)]
    public class ContractsQueryParameters   
    {
        /// <summary>
        /// Kun pasientlister som tilh�rer i disse kommunene blir returnert.
        /// Er denne listen tom, returneres alle pasientlister.
        /// Kodeverk: <see href="/CodeAdmin/EditCodesInGroup/kommune">kommune</see> (OID 3402).
        /// </summary>
        [DataMember]
        public ICollection<Code> Municipalities { get; set; }

        /// <summary>
        /// Om man absolutt m� hente personinfo fra personregisteret, settes denne til true.
        /// Oppslag i personregisteret vil gj�re at svar vil ta VESENTLIG lengre tid
        /// </summary>
        [DataMember]
        public bool GetFullPersonInfo { get; set; }

        /// <summary>
        /// Er denne false, vil kun <see cref="GPContract"/>s som var aktive p� eksporttidspunktet bli returnert. 
        /// <see cref="GPContract.PatientList"/> vil da ogs� kun inneholde pasienter som var aktive p� listen p� eksporttidspunktet.
        /// 
        /// Er denne true, vil alle <see cref="GPContract"/>s, inkludert de som er kansellert/utg�tt/etc bli returnert.
        /// <see cref="GPContract.PatientList"/> vil da ogs� inneholde full pasienthistorikk.
        /// </summary>
        [DataMember]
        public bool GetHistoricalData { get; set; }
    }
}