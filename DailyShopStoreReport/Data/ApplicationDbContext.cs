using System;
using System.Collections.Generic;
using System.Text;
using DailyShopStoreReport.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DailyShopStoreReport.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        } 
        public DbSet<Income> Incomes { get; set; }
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<SelectYear> SelectYears { get; set; }
        public DbSet<YearlyDataModelView> YearlyDataModelViews { get; set; }


       
        public DbSet<AppUser> AppUsers { get; set; } 
        //public DbSet<AppRole> AppRoles { get; set; } 

        public DbSet<AppPermission> AppPermissions { get; set; }
        public DbSet<AppMenu> AppMenus { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}