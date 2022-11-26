using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Sigurnost_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sigurnost_DataAccess.Seeder
{
    public class Seeder : ISeeder
    {
        public async Task SeedAsync(SigurnostDbContext dbContext, IServiceProvider serviceProvider)
        {
            var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            var userManager = serviceProvider.GetRequiredService<UserManager<User>>();

            await SeedRolesAsync(roleManager, "Admin");
            await SeedRolesAsync(roleManager, "Agent");

            await SeedUserWithRoleAdminAsync(userManager);
            await SeedUserWithRoleAgentAsync(userManager);
        }

        private async Task SeedUserWithRoleAdminAsync(UserManager<User> userManager)
        {
            var user = await userManager.FindByNameAsync("Admin");
            if (user == null)
            {
                var result = await userManager.CreateAsync(new User
                {
                    UserName = "Admin",
                    Email = "kalinina.grace@gmail.com",
                    EmailConfirmed = true,
                    FirstName = "Gratsiya",
                    LastName = "Kalinina"

                }, "Admin_12345");

                if (!result.Succeeded)
                {
                    throw new Exception(string.Join(Environment.NewLine, result.Errors.Select(e => e.Description)));
                }
                else
                {
                    user = await userManager.FindByNameAsync("Admin");
                    await userManager.AddToRoleAsync(user, "Admin");
                }
            }

        }

        private async Task SeedUserWithRoleAgentAsync(UserManager<User> userManager)
        {
            var user = await userManager.FindByNameAsync("Agent0");
            if (user == null)
            {
                var result = await userManager.CreateAsync(new User
                {
                    UserName = "Agent0",
                    Email = "agent@gmail.com",
                    EmailConfirmed = true,
                    FirstName = "Gratsiya",
                    LastName = "Kalinina"

                }, "Agent_12345");

                if (!result.Succeeded)
                {
                    throw new Exception(string.Join(Environment.NewLine, result.Errors.Select(e => e.Description)));
                }
                else
                {
                    user = await userManager.FindByNameAsync("Agent0");
                    await userManager.AddToRoleAsync(user, "Agent");
                }
            }

        }

        private async Task SeedRolesAsync(RoleManager<IdentityRole> roleManager, string roleName)
        {
            var role = await roleManager.FindByNameAsync(roleName);
            if (role == null)
            {
                var result = await roleManager.CreateAsync(new IdentityRole(roleName));
                if (!result.Succeeded)
                {
                    throw new Exception(string.Join(Environment.NewLine, result.Errors.Select(e => e.Description)));
                }
            }
        }
    }
}
