using System.Collections.Generic;
using System.Runtime.Serialization;
using NHN.DtoContracts.Common.en;

namespace NHN.DtoContracts.Flr
{
    [DataContract(Namespace = FlrXmlNamespace.V1)]
    public class GPCommunicationDetails
    {
        /// <summary>
        /// Kommunikasjonspart til fastlege
        /// </summary>
        [DataMember]
        public CommunicationParty CommunicationParty { get; set; }

        /// <summary>
        /// CPP til fastlege
        /// </summary>
        //[DataMember]
        //public CollaborationProtocolProfile CPP { get; set; }

        /// <summary>
        /// Fastlegekontor til fastlege
        /// </summary>
        [DataMember]
        public Business Business { get; set; }

        /// <summary>
        /// Egenskaper 
        /// </summary>
        [DataMember]
        public List<Code> Properties { get; set; }

        /// <summary>
        /// Status og periode for pasient 
        /// </summary>
        [DataMember]
        public GPDetailsWithStatus PatientDetails { get; set; }
    }
}