using HotelPmsCore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelPmsCore.Data
{
    public class HotelPmsCoreContext: DbContext
    {
        //public HotelPmsCoreContext(DbContextOptions<HotelPmsCoreContext> options) : base(options) { }

        public DbSet<Models.Customer> Customers { get; set; }

        public DbSet<Models.PriceList> PriceLists { get; set; }

        public DbSet<Period> Periods { get; set; }

        public DbSet<TypedCategory> TypedCategories { get; set; }

        public DbSet<Room> Rooms { get; set; }

        public DbSet<Staff> Staffs { get; set; }

        public DbSet<User> Users { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
         base.OnConfiguring(optionsBuilder);
         var connString = ConfigurationManager.ConnectionStrings["LocalHost"].ConnectionString;
            optionsBuilder.UseMySql(connString, ServerVersion.AutoDetect(connString));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            //modelBuilder.Entity<Customer>().ToTable("Customer");
            //modelBuilder.Entity<PriceList>().ToTable("PriceList");
            //modelBuilder.Entity<Period>().ToTable("Period");
            //modelBuilder.Entity<TypedCategory>().ToTable("TypedCategory");
            
        }
    }
}
