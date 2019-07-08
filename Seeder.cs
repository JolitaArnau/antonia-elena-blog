using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Your_Blog_Template
{
    public class Seeder
    {
        private const string AdminRoleName = "Administrator";

        public static async Task SeedRoles(RoleManager<IdentityRole> roleManager)
        {
            var adminRoleExists = await roleManager.RoleExistsAsync(AdminRoleName);
            if (!adminRoleExists)
            {
                var adminRole = new IdentityRole()
                {
                    Name = AdminRoleName,
                    NormalizedName = AdminRoleName.ToUpper(),
                    ConcurrencyStamp = "0"
                };
                var result = await roleManager.CreateAsync(adminRole);
            }
        }
    }
}