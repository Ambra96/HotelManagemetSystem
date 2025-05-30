using HotelPmsCore.Data;
using HotelPmsCore.Models;
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
            // Order matters: Seed parent tables FIRST
            SeedRoles();
            SeedRoomTypes();
            SeedPeriods();

#if DEBUG
            SeedCustomers();
            SeedRooms();
            SeedStaff();
            SeedReservations();
#endif
            SeedAdminUser();
        }

        private void SeedRoles()
        {
            if (!context.TypedCategories.Any(tc => tc.Type == 3))
            {
                var roles = new List<TypedCategory>
                {
                    new() { Id = 1, Description = "Administrator", Type = 3 },
                    new() { Id = 2, Description = "User", Type = 3 }
                };
                context.TypedCategories.AddRange(roles);
                context.SaveChanges();
            }
        }

        private void SeedRoomTypes()
        {
            if (!context.TypedCategories.Any(tc => tc.Type == 2))
            {
                var roomTypes = new List<TypedCategory>
                {
                    new() { Id = 3, Description = "Single", Type = 2 },
                    new() { Id = 4, Description = "Double", Type = 2 },
                    new() { Id = 5, Description = "Suite", Type = 2 }
                };
                context.TypedCategories.AddRange(roomTypes);
                context.SaveChanges();
            }
        }

        private void SeedPeriods()
        {
            if (context.Periods.Any()) return;
            var periods = new List<Period>
            {
                new() { Name = "Winter", StartDate = new System.DateTime(2025, 1, 1), EndDate = new System.DateTime(2025, 4, 30) },
                new() { Name = "Summer", StartDate = new System.DateTime(2025, 5, 1), EndDate = new System.DateTime(2025, 9, 30) }
            };
            context.Periods.AddRange(periods);
            context.SaveChanges();
        }

        private void SeedCustomers()
        {
            if (context.Customers.Any()) return;

            var customers = new List<Customer>();
            for (int i = 1; i <= 10; i++)
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

            // Always fetch an EXISTING RoomType (Type == 2)
            var defaultRoomType = context.TypedCategories.FirstOrDefault(tc => tc.Type == 2) ??
                                  context.TypedCategories.First(tc => tc.Type == 2);

            var rooms = new List<Room>();
            for (int i = 1; i <= 10; i++)
            {
                rooms.Add(new Room
                {
                    RoomNumber = i.ToString(),
                    Floor = 1,
                    PeopleCapacity = 2,
                    WinterPrice = 50,
                    SummerPrice = 75,
                    RoomType = defaultRoomType
                });
            }
            context.Rooms.AddRange(rooms);
            context.SaveChanges();
        }

        private void SeedStaff()
        {
            if (context.Set<Staff>().Any()) return;

            var specialty = context.TypedCategories.FirstOrDefault(tc => tc.Type == 1)
                         ?? new TypedCategory { Id = 6, Description = "Reception", Type = 1 };
            if (specialty.Id == 0)
            {
                context.TypedCategories.Add(specialty);
                context.SaveChanges();
            }

            var staffList = new List<Staff>();
            for (int i = 1; i <= 5; i++)
            {
                staffList.Add(new Staff
                {
                    Firstname = $"Staff{i}",
                    Lastname = $"Last{i}",
                    Speciality = specialty
                });
            }
            context.Set<Staff>().AddRange(staffList);
            context.SaveChanges();
        }

        private void SeedReservations()
        {
            if (context.Reservations.Any()) return;

            var customer = context.Customers.FirstOrDefault();
            var room = context.Rooms.FirstOrDefault();

            if (customer == null || room == null) return;

            var reservations = new List<Reservation>
            {
                new Reservation
                {
                    CustomerId = customer.Id,
                    RoomId = room.Id,
                    ReservationDateFrom = System.DateTime.Today,
                    ReservationDateTo = System.DateTime.Today.AddDays(3),
                    CheckInDate = System.DateTime.Today,
                    CheckOutDate = System.DateTime.Today.AddDays(3),
                    Canceled = false,
                    ReservationDayPrice = room.WinterPrice
                }
            };

            context.Reservations.AddRange(reservations);
            context.SaveChanges();
        }

        private void SeedAdminUser()
        {
            var adminRole = context.TypedCategories.FirstOrDefault(tc => tc.Type == 3 && tc.Description == "Administrator");
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
