using Sigurnost_DataAccess.Repositories.Interfaces;
using Sigurnost_Models;
using Sigurnost_Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sigurnost_Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task<User> GetUserById(string userId)
        {
            return await _userRepository.GetUserById(userId);
        }

        public async Task<User> GetUserByUsername(string userName)
        {
            return await _userRepository.GetUserByUsername(userName);
        }
    }
}
