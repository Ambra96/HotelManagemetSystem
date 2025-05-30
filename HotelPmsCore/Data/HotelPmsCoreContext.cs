using HotelPmsCore.Models;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace HotelPmsCore.Data
{
    public class HotelPmsCoreContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Period> Periods { get; set; }
        public DbSet<TypedCategory> TypedCategories { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Staff> Staff { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            var connString = ConfigurationManager.ConnectionStrings["LocalHost"].ConnectionString;
            optionsBuilder.UseMySql(connString, ServerVersion.AutoDetect(connString));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // TypedCategory (Id + Type)
            modelBuilder.Entity<TypedCategory>()
                .HasKey(tc => new { tc.Id, tc.Type });

            // --- Room
            modelBuilder.Entity<Room>()
                .HasOne(r => r.RoomType)
                .WithMany()
                .HasForeignKey(r => r.RoomTypeId)
                .HasPrincipalKey(tc => tc.Id)
                .OnDelete(DeleteBehavior.Restrict);

            // --- Staff
            modelBuilder.Entity<Staff>()
                .HasOne(s => s.Speciality)
                .WithMany()
                .HasForeignKey(s => s.SpecialityId)
                .HasPrincipalKey(tc => tc.Id)
                .OnDelete(DeleteBehavior.Restrict);

            // --- User
            modelBuilder.Entity<User>()
                .HasOne(u => u.Role)
                .WithMany()
                .HasForeignKey(u => u.RoleId)
                .HasPrincipalKey(tc => tc.Id)
                .OnDelete(DeleteBehavior.Restrict);

            // --- Reservation
            modelBuilder.Entity<Reservation>()
                .HasOne(r => r.Customer)
                .WithMany()
                .HasForeignKey(r => r.CustomerId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Reservation>()
                .HasOne(r => r.Room)
                .WithMany()
                .HasForeignKey(r => r.RoomId)
                .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
