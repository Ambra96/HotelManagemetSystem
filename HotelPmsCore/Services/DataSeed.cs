using HotelPmsCore.Data;
using HotelPmsCore.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace HotelPmsCore.Services
{
    public class DataSeed
    {
        private readonly HotelPmsCoreContext context;
        private readonly Argon2 hasher;

        public DataSeed(HotelPmsCoreContext context, Argon2 hasher)
        {
            this.context = context;
            this.hasher = hasher;
        }

        public void Seed()
        {
#if DEBUG
            SeedCustomers();
            SeedRooms();
#endif
            SeedRoles();
            SeedAdminUser();
        }

        private void SeedCustomers()
        {
            if (context.Customers.Any()) return;

            var customers = new List<Customer>();
            for (int i = 1; i <= 20; i++)
            {
                customers.Add(new Customer
                {
                    FirstName = $"Name{i}",
                    LastName = $"Surname{i}",
                    Address = "Test Address",
                    Afm = "123456789",
                    City = "Test City",
                    Country = "Test Country",
                    ZipCode = "00000"
                });
            }

            context.Customers.AddRange(customers);
            context.SaveChanges();
        }

        private void SeedRooms()
        {
            if (context.Rooms.Any()) return;

            var rooms = new List<Room>();
            for (int i = 1; i <= 20; i++)
            {
                rooms.Add(new Room
                {
                    RoomNumber = i.ToString(),
                    Floor = 1,
                    PeopleCapacity = 2,
                    WinterPrice = 50,
                    SummerPrice = 75,
                    RoomType = new TypedCategory { Type = 2 },
                    RoomTypeDescription = ""
                });
            }

            context.Rooms.AddRange(rooms);
            context.SaveChanges();
        }

        private void SeedRoles()
        {
            if (!context.TypedCategories.Where(x => x.Type == 3).Any())
            {
                List<Models.TypedCategory> roles = [
                    new(){ Id = 1, Description = "Administrator", Type = 3 },
                    new(){ Id = 2, Description = "User", Type = 3 }
                ];

                context.TypedCategories.AddRange(roles);
                context.SaveChanges();
            }
        }

        private void SeedAdminUser()
        {
           
            var adminRole = context.TypedCategories
                                   .FirstOrDefault(tc => tc.Type == 3
                                                      && tc.Description == "Administrator");
            if (adminRole == null) return;

            if (context.Users.Any()) return;

            var admin = new User
            {
                Username = "admin",
                FullName = "System Administrator",
                Role = adminRole,                   
                Password = hasher.HashPassword("1234ok")
            };

            context.Users.Add(admin);
            context.SaveChanges();
        }
    }
}
