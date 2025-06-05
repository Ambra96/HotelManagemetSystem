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

            SeedRoles();
            SeedRoomTypes();
            SeedPeriods();

            //#if DEBUG
            SeedCustomers();
            SeedRooms();
            SeedStaff();
            SeedReservations();
            //#endif
            SeedAdminUser();
            SeedGuestUser();
        }

        private void SeedRoles()
        {
            if (!context.TypedCategories.Any(tc => tc.Type == 3))
            {
                var roles = new List<TypedCategory>
                {
                    new() { Id = 1, Description = "Administrator", Type = 3 },
                    new() { Id = 2, Description = "User", Type = 3 },
                    new() { Id = 8, Description = "Guest", Type = 3 }
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
                    new() { Id = 5, Description = "Suite", Type = 2 },
                    new() { Id = 9, Description = "Triple", Type = 2 }
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
                    Email = "test@gmail.com",
                    Phone = "999999999",
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

            var defaultRoomType = context.TypedCategories.FirstOrDefault(tc => tc.Type == 2);
            if (defaultRoomType == null) return;

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

        private void SeedGuestUser()
        {
            var guestRole = context.TypedCategories.FirstOrDefault(tc => tc.Type == 3 && tc.Description == "Guest");
            if (guestRole == null) return;
            if (context.Users.Any()) return;
            var guest = new User
            {
                Username = "guest",
                FullName = "System Guest",
                Role = guestRole,
                Password = hasher.HashPassword("1234")
            };
            context.Users.Add(guest);
            context.SaveChanges();

        }
    }
}



//------------------------------------------------------------------------------------------------------//
//ΚΑΝΕΙ UPDATE & INSERT ΚΑΘΕ ΦΟΡΑ ΠΟΥ ΤΡΕΧΕΙ Η ΕΦΑΡΜΟΓΗ!!! sos
//------------------------------------------------------------------------------------------------------//

//using HotelPmsCore.Data;
//using HotelPmsCore.Models;
//using System.Collections.Generic;
//using System.Linq;

//namespace HotelPmsCore.Services
//{
//    public class DataSeed
//    {
//        private readonly HotelPmsCoreContext context;
//        private readonly Argon2 hasher;

//        public DataSeed(HotelPmsCoreContext context, Argon2 hasher)
//        {
//            this.context = context;
//            this.hasher = hasher;
//        }

//        public void Seed()
//        {
//            SeedRoles();
//            SeedRoomTypes();
//            SeedPeriods();
//            SeedCustomers();
//            SeedRooms();
//            SeedStaff();
//            SeedReservations();
//            SeedAdminUser();
//            SeedGuestUser();
//        }

//        private void SeedRoles()
//        {
//            var roles = new List<TypedCategory>
//            {
//                new() { Id = 1, Description = "Administrator", Type = 3 },
//                new() { Id = 2, Description = "User", Type = 3 },
//                new() { Id = 8, Description = "Guest", Type = 3 }
//            };

//            foreach (var role in roles)
//            {
//                var existing = context.TypedCategories.FirstOrDefault(tc => tc.Id == role.Id && tc.Type == role.Type);
//                if (existing == null)
//                    context.TypedCategories.Add(role);
//                else
//                    existing.Description = role.Description;
//            }
//            context.SaveChanges();
//        }

//        private void SeedRoomTypes()
//        {
//            var roomTypes = new List<TypedCategory>
//            {
//                new() { Id = 3, Description = "Single", Type = 2 },
//                new() { Id = 4, Description = "Double", Type = 2 },
//                new() { Id = 5, Description = "Suite", Type = 2 },
//                new() { Id = 9, Description = "Triple", Type = 2 }
//            };

//            foreach (var roomType in roomTypes)
//            {
//                var existing = context.TypedCategories.FirstOrDefault(tc => tc.Id == roomType.Id && tc.Type == roomType.Type);
//                if (existing == null)
//                    context.TypedCategories.Add(roomType);
//                else
//                    existing.Description = roomType.Description;
//            }
//            context.SaveChanges();
//        }

//        private void SeedPeriods()
//        {
//            var periods = new List<Period>
//            {
//                new() { Name = "Winter", StartDate = new System.DateTime(2025, 1, 1), EndDate = new System.DateTime(2025, 4, 30) },
//                new() { Name = "Summer", StartDate = new System.DateTime(2025, 5, 1), EndDate = new System.DateTime(2025, 9, 30) }
//            };

//            foreach (var period in periods)
//            {
//                var existing = context.Periods.FirstOrDefault(p => p.Name == period.Name);
//                if (existing == null)
//                {
//                    context.Periods.Add(period);
//                }
//                else
//                {
//                    existing.StartDate = period.StartDate;
//                    existing.EndDate = period.EndDate;
//                }
//            }
//            context.SaveChanges();
//        }

//        private void SeedCustomers()
//        {
//            var customers = new List<Customer>();
//            for (int i = 1; i <= 10; i++)
//            {
//                customers.Add(new Customer
//                {
//                    FirstName = $"Name{i}",
//                    LastName = $"Surname{i}",
//                    Address = "Test Address",
//                    Afm = $"12345678{i}", // unique
//                    Email = $"test{i}@gmail.com",
//                    Phone = "999999999",
//                    City = "Test City",
//                    Country = "Test Country",
//                    ZipCode = "00000"
//                });
//            }

//            foreach (var customer in customers)
//            {
//                var existing = context.Customers.FirstOrDefault(c => c.Afm == customer.Afm);
//                if (existing == null)
//                    context.Customers.Add(customer);
//                else
//                {
//                    existing.FirstName = customer.FirstName;
//                    existing.LastName = customer.LastName;
//                    existing.Address = customer.Address;
//                    existing.Email = customer.Email;
//                    existing.Phone = customer.Phone;
//                    existing.City = customer.City;
//                    existing.Country = customer.Country;
//                    existing.ZipCode = customer.ZipCode;
//                }
//            }
//            context.SaveChanges();
//        }

//        private void SeedRooms()
//        {
//            var defaultRoomType = context.TypedCategories.FirstOrDefault(tc => tc.Type == 2);
//            if (defaultRoomType == null) return;

//            var rooms = new List<Room>();
//            for (int i = 1; i <= 20; i++)
//            {
//                rooms.Add(new Room
//                {
//                    RoomNumber = i.ToString(),
//                    Floor = 1,
//                    PeopleCapacity = 2,
//                    WinterPrice = 50,
//                    SummerPrice = 75,
//                    RoomType = defaultRoomType
//                });
//            }

//            foreach (var room in rooms)
//            {
//                var existing = context.Rooms.FirstOrDefault(r => r.RoomNumber == room.RoomNumber);
//                if (existing == null)
//                {
//                    context.Rooms.Add(room);
//                }
//                else
//                {
//                    existing.Floor = room.Floor;
//                    existing.PeopleCapacity = room.PeopleCapacity;
//                    existing.WinterPrice = room.WinterPrice;
//                    existing.SummerPrice = room.SummerPrice;
//                    existing.RoomType = room.RoomType;
//                }
//            }
//            context.SaveChanges();
//        }

//        private void SeedStaff()
//        {
//            var specialty = context.TypedCategories.FirstOrDefault(tc => tc.Type == 1)
//                         ?? new TypedCategory { Id = 6, Description = "Reception", Type = 1 };
//            if (specialty.Id == 0)
//            {
//                context.TypedCategories.Add(specialty);
//                context.SaveChanges();
//            }

//            var staffList = new List<Staff>();
//            for (int i = 1; i <= 5; i++)
//            {
//                staffList.Add(new Staff
//                {
//                    Firstname = $"Staff{i}",
//                    Lastname = $"Last{i}",
//                    Speciality = specialty
//                });
//            }

//            foreach (var staff in staffList)
//            {
//                var existing = context.Set<Staff>().FirstOrDefault(s => s.Firstname == staff.Firstname && s.Lastname == staff.Lastname);
//                if (existing == null)
//                    context.Set<Staff>().Add(staff);
//                else
//                    existing.Speciality = staff.Speciality;
//            }
//            context.SaveChanges();
//        }

//        private void SeedReservations()
//        {
//            var customer = context.Customers.FirstOrDefault();
//            var room = context.Rooms.FirstOrDefault();

//            if (customer == null || room == null) return;

//            var reservations = new List<Reservation>
//            {
//                new Reservation
//                {
//                    CustomerId = customer.Id,
//                    RoomId = room.Id,
//                    ReservationDateFrom = System.DateTime.Today,
//                    ReservationDateTo = System.DateTime.Today.AddDays(3),
//                    CheckInDate = System.DateTime.Today,
//                    CheckOutDate = System.DateTime.Today.AddDays(3),
//                    Canceled = false,
//                    ReservationDayPrice = room.WinterPrice
//                }
//            };

//            foreach (var res in reservations)
//            {
//                var existing = context.Reservations.FirstOrDefault(r =>
//                    r.CustomerId == res.CustomerId &&
//                    r.RoomId == res.RoomId &&
//                    r.ReservationDateFrom == res.ReservationDateFrom);

//                if (existing == null)
//                    context.Reservations.Add(res);
//                else
//                {
//                    existing.ReservationDateTo = res.ReservationDateTo;
//                    existing.CheckInDate = res.CheckInDate;
//                    existing.CheckOutDate = res.CheckOutDate;
//                    existing.Canceled = res.Canceled;
//                    existing.ReservationDayPrice = res.ReservationDayPrice;
//                }
//            }
//            context.SaveChanges();
//        }

//        private void SeedAdminUser()
//        {
//            var adminRole = context.TypedCategories.FirstOrDefault(tc => tc.Type == 3 && tc.Description == "Administrator");
//            if (adminRole == null) return;

//            var username = "admin";
//            var existing = context.Users.FirstOrDefault(u => u.Username == username);
//            if (existing == null)
//            {
//                var admin = new User
//                {
//                    Username = username,
//                    FullName = "System Administrator",
//                    Role = adminRole,
//                    Password = hasher.HashPassword("1234ok")
//                };
//                context.Users.Add(admin);
//            }
//            else
//            {
//                existing.FullName = "System Administrator";
//                existing.Role = adminRole;
//                existing.Password = hasher.HashPassword("1234ok");
//            }
//            context.SaveChanges();
//        }

//        private void SeedGuestUser()
//        {
//            var guestRole = context.TypedCategories.FirstOrDefault(tc => tc.Type == 3 && tc.Description == "Guest");
//            if (guestRole == null) return;

//            var username = "guest";
//            var existing = context.Users.FirstOrDefault(u => u.Username == username);
//            if (existing == null)
//            {
//                var guest = new User
//                {
//                    Username = username,
//                    FullName = "System Guest",
//                    Role = guestRole,
//                    Password = hasher.HashPassword("1234")
//                };
//                context.Users.Add(guest);
//            }
//            else
//            {
//                existing.FullName = "System Guest";
//                existing.Role = guestRole;
//                existing.Password = hasher.HashPassword("1234");
//            }
//            context.SaveChanges();
//        }
//    }
//}
