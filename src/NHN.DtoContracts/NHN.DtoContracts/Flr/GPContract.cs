﻿using NHN.DtoContracts.Common.en;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace NHN.DtoContracts.Flr
{
    /// <summary>
    /// Dette representerer en fastlegeavtale og implisitt en fastlegeliste.
    /// </summary>
    [DataContract(Namespace = FlrXmlNamespace.V1)]
    public class GPContract
    {
        /// <summary>
        /// This ID is owned by and set by FLO. Must be a positive integer.
        /// </summary>
        [DataMember]
        public int Id { get; set; }

        /// <summary>
        /// Hvorvidt listen er en del av en "Fellesliste".
        /// </summary>
        [DataMember]
        public bool ParticipatesOnCommonList { get; set; }

        /// <summary>
        /// Hvorvidt listen er en del av "gruppepraksis".
        /// </summary>
        [DataMember]
        public bool FactionPractice { get; set; }

        /// <summary>
        /// Hvis det kreves medlemskap for være på en liste, så er innholdet av RequiresMembership satt til ID'en for dette medlemskapet.
        /// </summary>
        [DataMember]
        public Code RequiresMembership { get; set; }

        /// <summary>
        /// Legekontor.
        /// Orgnummeret vil en finne i Adresseregisteret og eventuelt RESH.
        /// </summary>
        [DataMember]
        public Business TreatmentCenter { get; set; }

        /// <summary>
        /// Listetak
        /// </summary>
        [DataMember]
        public int MaxPatients { get; set; }

        /// <summary>
        /// Listestatus.
        /// </summary>
        [DataMember]
        public ListStatus Status { get; set; }

        /// <summary>
        /// Navn på listen. ??? Trenger vi dette?
        /// </summary>
        [DataMember]
        public string Name { get; set; }

        /// <summary>
        /// Når avtalen ble opprettet
        /// </summary>
        [DataMember]
        public DateTime AgreementDate { get; set; }

        /// <summary>
        /// Gyldighetsperiode for avtalen.
        /// </summary>
        [DataMember]
        public Period Valid { get; set; } // FraDato; ?TilDato;

        /// <summary>
        /// Legetilknytninger.
        /// </summary>
        [DataMember]
        public ICollection<GPOnContractAssociation> DoctorCycles { get; set; }

        /// <summary>
        /// Liste over utekontor for denne listen.
        /// </summary>
        [DataMember]
        public ICollection<OutOfOfficeLocation> OutOfOfficeOffices { get; set; }

        /// <summary>
        /// Kommune
        /// </summary>
        [DataMember]
        public Business Municipality { get; set; }

        /// <summary>
        /// Bydel
        /// </summary>
        [DataMember]
        public Code District { get; set; }
    }
}