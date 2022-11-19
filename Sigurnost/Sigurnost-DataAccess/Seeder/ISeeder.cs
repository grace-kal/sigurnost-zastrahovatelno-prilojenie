using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sigurnost_DataAccess.Seeder
{
    public interface ISeeder
    {
        Task SeedAsync(SigurnostDbContext dbContext, IServiceProvider serviceProvider);

    }
}
