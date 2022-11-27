using Sigurnost_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sigurnost_DataAccess.Repositories.Interfaces
{
    public interface IUserRepository
    {
        Task<User> GetUserByUsername(string userName);
        Task<User> GetUserById(string userId);
    }
}
