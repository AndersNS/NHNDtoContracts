using System.Runtime.Serialization;
using NHN.DtoContracts.Common.en;

namespace NHN.DtoContracts.Flr.Service
{
    /// <summary>
    /// Brukes for � hente PasientLister i NAV disc format.
    /// </summary>
    [DataContract]
    public class ContractWithPeriod
    {
        /// <summary>
        /// Kontrakt id man �nsker � hente
        /// </summary>
        [DataMember]
        public long ContractId { get; set; }
        /// <summary>
        /// Perioden man �nsker listen hentet for
        /// </summary>
        [DataMember]
        public Period Period { get; set; }
    }
}