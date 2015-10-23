using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace NHN.DtoContracts.Common.en
{
    /// <summary>
    /// Representerer alle kommunikasjonsparter i systemet.
    /// </summary>
    [DataContract(Namespace = CommonXmlNamespaces.XmlNsCommonEnglishOld)]
    [DebuggerDisplay("HerId = {HerId} Name = {Name} ParentName: {ParentName}")]
    [Serializable]
    public class CommunicationParty
    {
        private DateTime _serverTime = DateTime.Now;
        [DataMember]
        public DateTime ServerTime
        {
            get { return _serverTime; }
            set { _serverTime = value; }
        }

        /// <summary>
        /// Dato og tid for siste endring til objektet
        /// </summary>
        [DataMember] public DateTime LastChanged { get; set; }

        /// <summary>
        /// HER id på kommunikasjonsparten.
        /// </summary>
        [DataMember] public int HerId { get; set; }

        /// <summary>
        /// Type kommunikasjonspart (Service, Person, Organization, Department)
        /// </summary>
        [DataMember] public CommunicationPartyType Type { get; set; }

        /// <summary>
        /// Definerer om dette er en aktiv kommunikasjonspart
        /// </summary>
        [DataMember] public bool Active { get; set; }

        /// <summary>
        /// Det reelle navnet på kommunikasjonsparten
        /// </summary>
        [DataMember] public string Name { get; set; }

        /// <summary>
        /// Visningsnavn på kommunikasjonsparten
        /// </summary>
        [DataMember] public string DisplayName { get; set; }

        /// <summary>
        /// HER id på enheten som publiserer kommunikasjonsparten
        /// </summary>
        [DataMember]
        public int ParentHerId { get; set; }

        /// <summary>
        /// Navn på enheten som publiserer kommunikasjonsparten
        /// </summary>
        [DataMember] public string ParentName { get; set; }

        /// <summary>
        /// Organisasjonsnummer på enheten som publiserer tjenesten
        /// </summary>
        [DataMember] public int ParentOrganizationNumber { get; set; }

        /// <summary>
        /// Helsevirksomhet type på enheten avdelingen er tilknyttet
        /// Gyldige verdier: OID 9040
        /// </summary>
        [DataMember]
        public Code ParentBusinessType { get; set; }

        /// <summary>
        /// Fysiske addresser (f.eks. besøks-,post- og fakturaadresse)
        /// </summary>
        [DataMember] public List<PhysicalAddress> PhysicalAddresses { get; set; }

        /// <summary>
        /// Liste over elektroniske addresser
        /// </summary>
        [DataMember] public List<ElectronicAddress> ElectronicAddresses { get; set; }

        /// <summary>
        /// Kommunenummer 
        /// Gyldige verdier: OID 3402
        /// </summary>
        [DataMember]
        public Code Municipality { get; set; }

        /// <summary>
        /// Perioden (fra, til) hvor denne kommunikasjonsparten er gyldig
        /// </summary>
        [DataMember] public Period Valid { get; set; }

        /// <summary>
        /// Er et flagg som beskriver hvorvidt denne CommunicationParty er en faktisk kommunikasjonspart en kan sende EDI meldinger til.
        /// Verdien av denne boolske variablen er identisk til uttrykket Type == Service || Type == Person
        /// </summary>
        [DataMember]
        public bool IsValidCommunicationParty
        {
            get
            {
                return Type == CommunicationPartyType.Service || Type == CommunicationPartyType.Person;
            }

            set { } //Do nothing.
        }

        public CommunicationParty()
        {
            ParentHerId = -1;
            ParentOrganizationNumber = -1;
            ElectronicAddresses = new List<ElectronicAddress>();
            PhysicalAddresses = new List<PhysicalAddress>();
        }
    }
}