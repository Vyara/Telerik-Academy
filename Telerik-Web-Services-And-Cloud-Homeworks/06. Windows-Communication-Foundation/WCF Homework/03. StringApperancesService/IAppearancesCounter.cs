namespace StringApperancesService
{
    using System.ServiceModel;

    [ServiceContract]
    public interface IAppearancesCounter
    {
        [OperationContract]
        int CountStringAppearances(string occuringString, string containingString);
    }
}
