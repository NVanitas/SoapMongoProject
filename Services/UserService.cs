using SoapMongoProject.Contracts;
using SoapMongoProject.Models;
using SoapMongoProject.Repositories;
using System.Collections.Generic;

namespace SoapMongoProject.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public List<User> GetUsers()
        {
            return _userRepository.GetUsers();
        }
    }
}
