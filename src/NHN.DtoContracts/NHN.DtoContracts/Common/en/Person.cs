using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace NHN.DtoContracts.Common.en
{
    /// <summary>
    /// Detaljbeskrivelse av en person.
    /// </summary>
    [DataContract(Namespace = CommonXmlNamespaces.XmlNsCommonEnglishOld)]
    [Serializable]
    public class Person
    {
        /// <summary>
        /// Fødselsnummer, D-nummer eller H-nummer.
        /// </summary>
        [DataMember]
        public string SSN { get; set; }

        /// <summary>
        /// Fornavn
        /// </summary>
        [DataMember]
        public string FirstName { get; set; }

        /// <summary>
        /// Mellomnavn
        /// </summary>
        [DataMember]
        public string MiddleName { get; set; }

        /// <summary>
        /// Etternavn
        /// </summary>
        [DataMember]
        public string LastName { get; set; }

        /// <summary>
        /// HPR informasjon om personen som gjeder for denne koblingen
        /// </summary>
        [DataMember]
        public int HprNumber { get; set; }

        /// <summary>
        /// Statusverdier for personen
        /// Gyldige verdier: OID 5510 og OID 5511
        /// </summary>
        [DataMember]
        public List<Status> Status { get; set; }
    }
}