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
                              RoleManager<AppRole> roleManager)
        {
            context.Database.EnsureCreated();


            string srAccountant = "SrAccountant";
            string jrAccountant = "JrAccountant";

           

            string password = "P@$$w0rd";

            //if (await roleManager.FindByNameAsync(srAccountant) == null)
            //{
            //    await roleManager.CreateAsync(new AppRole(srAccountant));
            //}
            //if (await roleManager.FindByNameAsync(jrAccountant) == null)
            //{
            //    await roleManager.CreateAsync(new AppRole(jrAccountant));
            //}

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

            if (await userManager.FindByNameAsync("rimy4884@gmail.com") == null)
            {
                var user = new AppUser
                {
                    UserName = "rimy4884@gmail.com",
                    Name = "Abiyad Ahnaf",
                    Email = "rimy4884@gmail.com"
                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, password);
                    await userManager.AddToRoleAsync(user, jrAccountant);
                }
            }

            if (await userManager.FindByNameAsync("rimy2042@yahoo.com") == null)
            {
                var user = new AppUser
                {
                    UserName = "rimy2042@yahoo.com",
                    Name = "Nafiu Nawer",
                    Email = "rimy2042@yahoo.com" 
                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, password);
                    await userManager.AddToRoleAsync(user, jrAccountant);
                }
            }

            if (await userManager.FindByNameAsync("thomas49@gmail.com") == null)
            {
                var user = new AppUser
                {
                    UserName = "thomas49@gmail.com",
                    Name = "Thomas Jhonson",
                    Email = "thomas49@gmail.com"
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
