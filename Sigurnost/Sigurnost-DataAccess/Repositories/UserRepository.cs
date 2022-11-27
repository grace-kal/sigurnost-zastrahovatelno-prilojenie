using Microsoft.EntityFrameworkCore;
using Sigurnost_DataAccess.Repositories.Interfaces;
using Sigurnost_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sigurnost_DataAccess.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly SigurnostDbContext _dbContext;
        public UserRepository(SigurnostDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<User> GetUserById(string userId)
        {
            return await _dbContext.Users.FirstOrDefaultAsync(u => u.Id == userId);
        }

        public async Task<User> GetUserByUsername(string userName)
        {
            return await _dbContext.Users.FirstOrDefaultAsync(u => u.UserName == userName);

        }
    }
}
