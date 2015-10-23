using System;
using System.Runtime.Serialization;

namespace NHN.DtoContracts.Flr
{
    /// <summary>
    /// Status på pasient
    /// </summary>
    [DataContract(Namespace = FlrXmlNamespace.V1)]
    [Serializable]
    public class PatientStatus
    {
        /// <summary>
        /// Status
        /// </summary>
        [DataMember]
        public string Value { get; set; }

        /// <summary>
        /// Beskrivelse av status
        /// </summary>
        [DataMember]
        public string Text { get; set; }
    }
}