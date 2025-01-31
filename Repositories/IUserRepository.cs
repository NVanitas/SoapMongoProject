using SoapMongoProject.Models;
using System.Collections.Generic;

namespace SoapMongoProject.Repositories
{
    public interface IUserRepository
    {
        List<User> GetUsers();
    }
}