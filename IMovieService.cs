using System.ServiceModel;

namespace CSE445Project
{
    [ServiceContract]
    public interface IMovieService
    {
        [OperationContract]
        string GetRecommendation(string genre);
    }
}