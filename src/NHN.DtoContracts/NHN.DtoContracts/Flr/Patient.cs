using System.Runtime.Serialization;

namespace NHN.DtoContracts.Flr
{
    [DataContract(Namespace = FlrXmlNamespace.V1)]
    public class Patient
    {
        [DataMember]
        public string FirstName { get; set; }
    }
}