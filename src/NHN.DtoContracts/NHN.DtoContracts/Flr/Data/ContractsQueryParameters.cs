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
        /// Kun pasientlister som tilh�rer i disse kommunene blir returnert
        /// Er denne listen tom, returneres alle pasientlister
        /// </summary>
        [DataMember]
        public ICollection<Code> Municipalities { get; set; }
    }
}