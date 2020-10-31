using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace Paycompute.Persistence
{
    public static class DataSeedingInitializer
    {
        public static async Task UserAndRoleSeedAsync(UserManager<IdentityUser> userManager, 
                                                 RoleManager<IdentityRole> roleManager)
        {
            string[] roles = { "Admin", "Manager", "Staff" };
            foreach (var role in roles)
            {
                var roleExist = await roleManager.RoleExistsAsync(role);
                if (!roleExist)
                {
                    IdentityResult result = await roleManager.CreateAsync(new IdentityRole(role));
                }
            }

            //Create Admin User
            if (userManager.FindByEmailAsync("admin@nhom5.com").Result == null)
            {
                IdentityUser user = new IdentityUser
                {
                    UserName = "admin@nhom5.com",
                    Email = "admin@nhom5.com"
                };
                IdentityResult identityResult = userManager.CreateAsync(user, "Password1").Result;
                if (identityResult.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "Admin").Wait();
                }
            }

            //Create Manager User
            if (userManager.FindByEmailAsync("manager@gmail.com").Result == null)
            {
                IdentityUser user = new IdentityUser
                {
                    UserName = "manager@gmail.com",
                    Email = "manager@gmail.com"
                };
                IdentityResult identityResult = userManager.CreateAsync(user, "Password1").Result;
                if (identityResult.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "Manager").Wait();
                }
            }

            //Create Staff User
            if (userManager.FindByEmailAsync("khanh.dang@gmail.com").Result == null)
            {
                IdentityUser user = new IdentityUser
                {
                    UserName = "khanh.dang@gmail.com",
                    Email = "khanh.dang@gmail.com"
                };
                IdentityResult identityResult = userManager.CreateAsync(user, "Password1").Result;
                if (identityResult.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "Staff").Wait();
                }
            }

            //Create No Role User
            if (userManager.FindByEmailAsync("dat.dinh@gmail.com").Result == null)
            {
                IdentityUser user = new IdentityUser
                {
                    UserName = "dat.dinh@gmail.com",
                    Email = "dat.dinh@gmail.com"
                };
                IdentityResult identityResult = userManager.CreateAsync(user, "Password1").Result;
               //No Role assigned to Mr John Doe
            }
        }
    }
}
