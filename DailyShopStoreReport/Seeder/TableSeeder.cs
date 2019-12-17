using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DailyShopStoreReport.Data;
using DailyShopStoreReport.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace DailyShopStoreReport.Seeder 
{
    public class TableSeeder   
    {
        public static async Task Initialize(ApplicationDbContext context,
                                     UserManager<AppUser> userManager,
                                     RoleManager<IdentityRole> roleManager)
        {
            context.Database.EnsureCreated();

            string spAccountant = "SuperAccountant";
            string srAccountant = "SrAccountant";
            string jrAccountant = "JrAccountant";


            string passwordSp = "P@$$w0rdSp";
            string password = "P@$$w0rd";  

            if (await roleManager.FindByNameAsync(spAccountant) == null)
            {
                await roleManager.CreateAsync(new IdentityRole(spAccountant));
            }

            if (await roleManager.FindByNameAsync(srAccountant) == null)
            {
                await roleManager.CreateAsync(new IdentityRole(srAccountant));
            }

            if (await roleManager.FindByNameAsync(jrAccountant) == null)
            {
                await roleManager.CreateAsync(new IdentityRole(jrAccountant));
            }
            
            if (await userManager.FindByEmailAsync("akramSuper@gmail.com") == null)
            {
                var user = new AppUser
                {
                    UserName = "akramSuper@gmail.com",
                    Name = "Akram Hossain",
                    Email = "akramSuper@gmail.com"
                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, passwordSp);
                    await userManager.AddToRoleAsync(user, spAccountant);
                }
            }

            if (await userManager.FindByEmailAsync("akram49119@gmail.com") == null)
            {
                var user = new AppUser
                {
                    UserName = "akram49119@gmail.com",
                    Name = "Akram Hossain",
                    Email = "akram49119@gmail.com"
                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, password);
                    await userManager.AddToRoleAsync(user, srAccountant);
                }
            }

            if (await userManager.FindByNameAsync("nondini49119@gmail.com") == null)
            {
                var user = new AppUser
                {
                    UserName = "nondini49119@gmail.com",
                    Name = "Nawer Nandini Hossain",
                    Email = "nondini49119@gmail.com"
                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, password);
                    await userManager.AddToRoleAsync(user, jrAccountant);
                }
            }

            if (await userManager.FindByNameAsync("user49119@gmail.com") == null)
            {
                var user = new AppUser
                {
                    UserName = "user49119@gmail.com",
                    Name = "User User User",
                    Email = "user49119@gmail.com"
                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, password);
                    await userManager.AddToRoleAsync(user, jrAccountant);
                }
            }
            if (await userManager.FindByNameAsync("malthomas@gmail.com") == null)
            {
                var user = new AppUser
                {
                    UserName = "malthomas@gmail.com",
                    Name = "Alfred Malthomas Bhuttabin",
                    Email = "malthomas@gmail.com"
                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, password);
                    await userManager.AddToRoleAsync(user, jrAccountant);
                }
            }
        }
    }
}
