using System;
using System.Runtime.Serialization;

namespace NHN.DtoContracts.Flr
{
    /// <summary>
    /// Detaljbeskrivelse av lege og tilknyttet virksomhet.
    /// </summary>
    [DataContract(Namespace = FlrXmlNamespace.V1)]
    [Serializable]
    public class GPDetailsWithStatus : GPDetails
    {
        /// <summary>
        /// Status for oppføring i Fastlegeregisteret. Gyldige varianter:
        /// BU=BOSATT I UTLANDET, IF=IKKE MED I FASTLEGEORDN, IL=IKKE TILDELT LEGE, OP=FNR OPPHØRT,
        /// PD=PASIENTEN ER DØD, PR=RETUR FORELDRES LEGE, UL=DNR UTEN LEGE, SA=SAMISKTALENDE,
        /// VP=VANLIG PASIENT, UP=UKJENT PASIENT
        /// </summary>
        [DataMember]
        public PatientStatus Status { get; set; }
    }
}