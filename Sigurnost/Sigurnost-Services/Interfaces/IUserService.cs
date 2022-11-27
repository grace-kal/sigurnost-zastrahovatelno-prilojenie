using Sigurnost_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sigurnost_Services.Interfaces
{
    public interface IUserService
    {
        Task<User> GetUserByUsername(string userName);
        Task<User> GetUserById(string userId);
    }
}
