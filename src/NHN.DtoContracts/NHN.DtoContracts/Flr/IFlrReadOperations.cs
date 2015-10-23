using System.Collections.Generic;
using System.ServiceModel;
using NHN.DtoContracts.Common.en;

namespace NHN.DtoContracts.Flr
{
    [ServiceContract(Namespace = FlrXmlNamespace.V1)]
    public interface IFlrReadOperations
    {
        /// <summary>
        /// Henter fastlege for en gitt person.
        /// </summary>
        /// <param name="patientNin"></param>
        /// <returns></returns>
        [OperationContract]
        [FaultContract(typeof(GenericFault))]
        GPDetails GetPatientGPDetails(string patientNin);

        /// <summary>
        /// Henter fastlege med status for gitt person. Skal ikke publiseres.
        /// </summary>
        /// <param name="patientNin"></param>
        /// <returns></returns>
        GPDetailsWithStatus GetPatientGPDetailsWithStatus(string patientNin);

        /// <summary>
        /// Henter fastlegens kommunikasjonspart.
        /// </summary>
        /// <param name="hprNumber">Legens HPR-nummer</param>
        [OperationContract]
        [FaultContract(typeof(GenericFault))]
        GPCommunicationDetails GetGPCommunicationDetails(int hprNumber);

        /// <summary>
        /// Henter fastlegebytte historikken
        /// </summary>
        /// <param name="patientNin"></param>
        /// <returns></returns>
        [OperationContract]
        [FaultContract(typeof(GenericFault))]
        ICollection<PatientToGPContractAssociation> GetPatientGPHistory(string patientNin);

        /// <summary>
        /// Henter fastlegeavtaler tilknyttet virksomheten.
        /// </summary>
        /// <param name="organizationNumber"></param>
        /// <returns></returns>
        [OperationContract]
        [FaultContract(typeof(GenericFault))]
        ICollection<GPContract> GetGPContractsOnOffice(string organizationNumber);

        /// <summary>
        /// Henter fastlegeliste.
        /// </summary>
        /// <param name="gpContractId">Fastlegeavtalen.</param>
        /// <returns></returns>
        [OperationContract]
        [FaultContract(typeof(GenericFault))]
        ICollection<PatientToGPContractAssociation> GetGPPatientList(int gpContractId);

        /// <summary>
        /// Henter fastlege og tilhørende praksis
        /// </summary>
        /// <param name="hprNumber">Legens HPR-nummer.</param>
        /// <returns></returns>
        [OperationContract]
        [FaultContract(typeof(GenericFault))]
        GPDetailsWithContracts GetGPWithAssociatedGPContracts(int hprNumber);
    }
}
