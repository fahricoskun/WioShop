using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WioShop.Identity;

namespace WioShop.Models.Classes
{
    public class DataContext : IdentityDbContext<ApplicationUser>

    {
        public DataContext() :base("dataConnection")
        {
            
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderLine> OrderLines { get; set; }
        public DbSet<Cargo> Cargos { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Login> Logins { get; set; }
        public DbSet<Register> Registers { get; set; }
    }
}