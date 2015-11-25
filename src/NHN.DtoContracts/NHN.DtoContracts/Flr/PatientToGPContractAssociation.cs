using System.Runtime.Serialization;
using NHN.DtoContracts.Common.en;

namespace NHN.DtoContracts.Flr
{
    /// <summary>
    /// Representerer koblingen mellom en pasient og til en fastlegeliste.
    /// </summary>
    [DataContract(Namespace = FlrXmlNamespace.V1)]
    public class PatientToGPContractAssociation
    {
        /// <summary>
        /// Id til denne assiosasjonen.
        /// </summary>
        [DataMember]
        public long Id { get; set; }

        /// <summary>
        /// ID til GPContract. M� v�re satt ved skriving, vil v�re satt ved lesing og vil v�re identisk med GPContract.Id.
        /// </summary>
        [DataMember]
        public long GPContractId { get; set; }

        /// <summary>
        ///  Kontakten denne assoisasjonen peker til. Satt ved lesing, skal v�re null ved skriving.
        /// </summary>
        [DataMember]
        public GPContract GPContract { get; set; }

        /// <summary>
        /// Personnummer til innbygger
        /// </summary>
        [DataMember]
        public string PatientSSN { get; set; }

        /// <summary>
        /// For hvilken periode er denne assiosasjonen gyldig?
        /// </summary>
        [DataMember]
        public Period Period { get; set; } //FraDato ?TilDato;

        /// <summary>
        /// Kode p� hvorfor perioden er endret (avsluttet). Er NULL normalt sett med mindre personen har forlatt ordnignen.
        /// </summary>
        [DataMember]
        public Code EndCode { get; set; }

        /// <summary>
        /// Kode p� hvorfor perioden er endret (avsluttet).
        /// </summary>
        [DataMember]
        public Code BeginCode { get; set; }

        /// <summary>
        /// Detaljer om pasienten. Dette vil v�re satt p� leseoperasjoner n�r det er relevant, men m� v�re NULL p� skriveoperasjoner.
        /// </summary>
        [DataMember]
        public Person Patient { get; set; }

        /// <summary>
        /// Detaljer om legen tilknyttet denne assiosasjonen. Denne er satt ved lesing n�r det er relevant, men Skal v�re null ved skriving.
        /// </summary>
        [DataMember]
        public GPDetails GPDetails { get; set; }
    }
}