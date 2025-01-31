using SoapMongoProject.Models;
using System.Collections.Generic;
using System.ServiceModel;

namespace SoapMongoProject.Contracts
{
    [ServiceContract]
    public interface IUserService
    {
        [OperationContract]
        List<User> GetUsers();
    }
}
