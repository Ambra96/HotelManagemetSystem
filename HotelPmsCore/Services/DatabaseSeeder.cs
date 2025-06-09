//using HotelPmsCore.Data;
//using HotelPmsCore.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace HotelPmsCore.Services
//{
//    public class DatabaseSeeder
//    {
//        private readonly HotelPmsCoreContext context;
//        private readonly Argon2 hasher; 

//        public DatabaseSeeder(HotelPmsCoreContext context, Argon2 hasher)
//        {
//            this.context = context;
//            this.hasher = hasher;
//        }

//        public void Seed()
//        {
//            SeedTypedCategories();
//            SeedPeriods();
//            SeedCustomers();
//            SeedRooms();
//            SeedStaff();
//            SeedUsers();
//            SeedReservations();
//        }

//        private void SeedTypedCategories()
//        {
  
//            var typedCategories = new List<TypedCategory>
//            {
//                // Staff Speciality
//                new() { Id = 1, Description = "Reception", Type = 1 },
//                new() { Id = 2, Description = "Housekeeping", Type = 1 },
//                new() { Id = 3, Description = "Manager", Type = 1 },
//                // Room Types
//                new() { Id = 10, Description = "Single", Type = 2 },
//                new() { Id = 11, Description = "Double", Type = 2 },
//                new() { Id = 12, Description = "Triple", Type = 2 },
//                new() { Id = 13, Description = "Suite", Type = 2 },
//                // User Roles
//                new() { Id = 20, Description = "Administrator", Type = 3 },
//                new() { Id = 21, Description = "User", Type = 3 },
//                new() { Id = 22, Description = "Guest", Type = 3 }
//            };

//            foreach (var item in typedCategories)
//            {
//                var exists = context.TypedCategories.FirstOrDefault(tc => tc.Id == item.Id && tc.Type == item.Type);
//                if (exists == null)
//                    context.TypedCategories.Add(item);
//            }
//            context.SaveChanges();
//        }


//        private void SeedPeriods()
//        {
//            var periods = new List<Period>
//            {
//                new() { Name = "Winter", StartDate = new DateTime(2025, 1, 1), EndDate = new DateTime(2025, 4, 30) },
//                new() { Name = "Summer", StartDate = new DateTime(2025, 5, 1), EndDate = new DateTime(2025, 9, 30) }
//            };

//            foreach (var p in periods)
//            {
//                var exists = context.Periods.FirstOrDefault(x => x.Name == p.Name);
//                if (exists == null)
//                    context.Periods.Add(p);
//            }
//            context.SaveChanges();
//        }

     
//        private void SeedCustomers()
//        {
//            var customers = new List<Customer>
//            {
//                new() { FirstName = "Alice", LastName = "Smith", Afm = "111111111", Email = "alice@example.com", Phone = "2101111111", Address = "Main 1", City = "Athens", Country = "Greece", ZipCode = "10001" },
//                new() { FirstName = "Bob", LastName = "Brown", Afm = "222222222", Email = "bob@example.com", Phone = "2102222222", Address = "Side 2", City = "Athens", Country = "Greece", ZipCode = "10002" },
//                new() { FirstName = "Carol", LastName = "White", Afm = "333333333", Email = "carol@example.com", Phone = "2103333333", Address = "Up 3", City = "Athens", Country = "Greece", ZipCode = "10003" },
//                new() { FirstName = "David", LastName = "Black", Afm = "444444444", Email = "david@example.com", Phone = "2104444444", Address = "Down 4", City = "Athens", Country = "Greece", ZipCode = "10004" },
//                new() { FirstName = "Eve", LastName = "Green", Afm = "555555555", Email = "eve@example.com", Phone = "2105555555", Address = "Cross 5", City = "Athens", Country = "Greece", ZipCode = "10005" }
//            };

//            foreach (var c in customers)
//            {
//                var exists = context.Customers.FirstOrDefault(x => x.Afm == c.Afm);
//                if (exists == null)
//                    context.Customers.Add(c);
//            }
//            context.SaveChanges();
//        }


//        private void SeedRooms()
//        {
            
//            var roomTypes = context.TypedCategories.Where(tc => tc.Type == 2).ToList();

//            var rooms = new List<Room>
//            {
//                new() { RoomNumber = "101", Floor = 1, WinterPrice = 60, SummerPrice = 80, PeopleCapacity = 1, RoomTypeId = roomTypes[0].Id },
//                new() { RoomNumber = "102", Floor = 1, WinterPrice = 75, SummerPrice = 100, PeopleCapacity = 2, RoomTypeId = roomTypes[1].Id },
//                new() { RoomNumber = "201", Floor = 2, WinterPrice = 90, SummerPrice = 120, PeopleCapacity = 3, RoomTypeId = roomTypes[2].Id },
//                new() { RoomNumber = "202", Floor = 2, WinterPrice = 200, SummerPrice = 300, PeopleCapacity = 2, RoomTypeId = roomTypes[3].Id },
//                new() { RoomNumber = "203", Floor = 2, WinterPrice = 110, SummerPrice = 140, PeopleCapacity = 2, RoomTypeId = roomTypes[1].Id }
//            };

//            foreach (var r in rooms)
//            {
//                var exists = context.Rooms.FirstOrDefault(x => x.RoomNumber == r.RoomNumber);
//                if (exists == null)
//                    context.Rooms.Add(r);
//            }
//            context.SaveChanges();
//        }


//        private void SeedStaff()
//        {
//            var specialties = context.TypedCategories.Where(tc => tc.Type == 1).ToList();
//            var staff = new List<Staff>
//            {
//                new() { Firstname = "Maria", Lastname = "Kosta", SpecialityId = specialties[0].Id },
//                new() { Firstname = "Petros", Lastname = "Dimos", SpecialityId = specialties[1].Id },
//                new() { Firstname = "Stella", Lastname = "Lazos", SpecialityId = specialties[2].Id },
//                new() { Firstname = "Yannis", Lastname = "Papadopoulos", SpecialityId = specialties[0].Id },
//                new() { Firstname = "Eleni", Lastname = "Georgiou", SpecialityId = specialties[1].Id }
//            };

//            foreach (var s in staff)
//            {
//                var exists = context.Staff.FirstOrDefault(x => x.Firstname == s.Firstname && x.Lastname == s.Lastname);
//                if (exists == null)
//                    context.Staff.Add(s);
//            }
//            context.SaveChanges();
//        }


//        private void SeedUsers()
//        {
//            var adminRole = context.TypedCategories.FirstOrDefault(tc => tc.Type == 3 && tc.Description == "Administrator");
//            var userRole = context.TypedCategories.FirstOrDefault(tc => tc.Type == 3 && tc.Description == "User");
//            var guestRole = context.TypedCategories.FirstOrDefault(tc => tc.Type == 3 && tc.Description == "Guest");

//            var users = new List<User>
//            {
//                new() { Username = "admin", Password = hasher.HashPassword("admin123"), RoleId = adminRole.Id, FullName = "Admin User" },
//                new() { Username = "john", Password = hasher.HashPassword("johnpass"), RoleId = userRole.Id, FullName = "John Normal" },
//                new() { Username = "guest", Password = hasher.HashPassword("guestpass"), RoleId = guestRole.Id, FullName = "Guest User" },
//                new() { Username = "user1", Password = hasher.HashPassword("pass1"), RoleId = userRole.Id, FullName = "User One" },
//                new() { Username = "user2", Password = hasher.HashPassword("pass2"), RoleId = userRole.Id, FullName = "User Two" }
//            };

//            foreach (var u in users)
//            {
//                var exists = context.Users.FirstOrDefault(x => x.Username == u.Username);
//                if (exists == null)
//                    context.Users.Add(u);
//            }
//            context.SaveChanges();
//        }


//        private void SeedReservations()
//        {
           
//            var customers = context.Customers.Take(5).ToList();
//            var rooms = context.Rooms.Take(5).ToList();

//            var reservations = new List<Reservation>
//            {
//                new() { CustomerId = customers[0].Id, RoomId = rooms[0].Id, ReservationDateFrom = DateTime.Today, ReservationDateTo = DateTime.Today.AddDays(3), CheckInDate = DateTime.Today, CheckOutDate = DateTime.Today.AddDays(3), Canceled = false, ReservationDayPrice = rooms[0].WinterPrice },
//                new() { CustomerId = customers[1].Id, RoomId = rooms[1].Id, ReservationDateFrom = DateTime.Today.AddDays(4), ReservationDateTo = DateTime.Today.AddDays(7), CheckInDate = DateTime.MinValue, CheckOutDate = DateTime.MinValue, Canceled = false, ReservationDayPrice = rooms[1].WinterPrice },
//                new() { CustomerId = customers[2].Id, RoomId = rooms[2].Id, ReservationDateFrom = DateTime.Today.AddDays(1), ReservationDateTo = DateTime.Today.AddDays(2), CheckInDate = DateTime.MinValue, CheckOutDate = DateTime.MinValue, Canceled = false, ReservationDayPrice = rooms[2].WinterPrice },
//                new() { CustomerId = customers[3].Id, RoomId = rooms[3].Id, ReservationDateFrom = DateTime.Today.AddDays(5), ReservationDateTo = DateTime.Today.AddDays(8), CheckInDate = DateTime.MinValue, CheckOutDate = DateTime.MinValue, Canceled = false, ReservationDayPrice = rooms[3].WinterPrice },
//                new() { CustomerId = customers[4].Id, RoomId = rooms[4].Id, ReservationDateFrom = DateTime.Today.AddDays(10), ReservationDateTo = DateTime.Today.AddDays(15), CheckInDate = DateTime.MinValue, CheckOutDate = DateTime.MinValue, Canceled = false, ReservationDayPrice = rooms[4].WinterPrice }
//            };

//            foreach (var r in reservations)
//            {
//                var exists = context.Reservations.FirstOrDefault(x =>
//                    x.CustomerId == r.CustomerId && x.RoomId == r.RoomId && x.ReservationDateFrom == r.ReservationDateFrom);
//                if (exists == null)
//                    context.Reservations.Add(r);
//            }
//            context.SaveChanges();
//        }
//    }
//}
