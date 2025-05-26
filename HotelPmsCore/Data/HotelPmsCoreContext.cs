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

        public DbSet<Period> Periods { get; set; }

        public DbSet<TypedCategory> TypedCategories { get; set; }

        public DbSet<Room> Rooms { get; set; }
        public DbSet<Reservation> Reservations { get; set; }

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
            //modelBuilder.Entity<Room>().ToTable("Room");
            //modelBuilder.Entity<User>().ToTable("User");
            //modelBuilder.Entity<TypedCategory>()
           ////.HasKey(tc => new { tc.Id, tc.Type }); 

           // modelBuilder.Entity<User>()
               // .HasOne(u => u.Role)
                //.WithMany()
               // .HasForeignKey(u => new { u.RoleId, u.RoleType }) 
               // .HasPrincipalKey(tc => new { tc.Id, tc.Type }); 

            //modelBuilder.Entity<PriceList>()
               // .HasOne(p => p.Period)
               // .WithMany()
               // .HasForeignKey(p => p.PeriodId);

        }
    }
}
