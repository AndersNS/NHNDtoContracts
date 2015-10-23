using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace NHN.DtoContracts.Common.en
{
    [DataContract(Namespace = CommonXmlNamespaces.XmlNsCommonEnglishOld)]
    [Flags]
    [Serializable]
    public enum CommunicationPartyType
    {
        /// <summary>
        /// Ingen kommunikasjonspart
        /// </summary>
        [EnumMember]
        None = 0,
        /// <summary>
        /// Person
        /// </summary>
        [EnumMember, Description("Person")]
        Person = 1,
        /// <summary>
        /// Virksomhet/enhet fra enhetsregisteret
        /// </summary>
        [EnumMember, Description("Virksomhet")]
        Organization = 2,
        /// <summary>
        /// Avdeling. Kan også være en bedrift fra bedrifts- og foretaksregisteret (BoF)
        /// </summary>
        [EnumMember, Description("Avdeling")]
        Department = 8,
        /// <summary>
        /// Tjeneste
        /// </summary>
        [EnumMember, Description("Tjeneste")]
        Service = 4,
        /// <summary>
        /// Alle. Kan være hvilken som helst av de over.
        /// </summary>
        [EnumMember, Description("Alle")]
        All = Person | Organization | Department | Service
    }
}