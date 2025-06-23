using HotelPmsCore.Data;
using HotelPmsCore.Models;
using System;
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
            SeedTypedCategories();
            SeedPeriods();
            SeedCustomers();
            SeedRooms();
            SeedStaff();
            SeedUsers();
            SeedReservations();
        }

        private void SeedTypedCategories()
        {
            var typedCategories = new List<TypedCategory>
            {
                // Staff Speciality
                new() { Id = 1, Description = "Reception", Type = 1 },
                new() { Id = 2, Description = "Housekeeping", Type = 1 },
                new() { Id = 3, Description = "Manager", Type = 1 },
                new() { Id = 4, Description = "Security", Type = 1 },
                new() { Id = 5, Description = "Chef", Type = 1 },
                new() { Id = 6, Description = "Waiter", Type = 1 },
                new() { Id = 7, Description = "Maintenance", Type = 1 },
                new() { Id = 8, Description = "Bellboy", Type = 1 },
                new() { Id = 9, Description = "Concierge", Type = 1 },
                new() { Id = 10, Description = "Spa", Type = 1 },
                // Room Types
                new() { Id = 20, Description = "Single", Type = 2 },
                new() { Id = 21, Description = "Double", Type = 2 },
                new() { Id = 22, Description = "Triple", Type = 2 },
                new() { Id = 23, Description = "Suite", Type = 2 },
                new() { Id = 24, Description = "Family", Type = 2 },
                new() { Id = 25, Description = "Penthouse", Type = 2 },
                new() { Id = 26, Description = "Junior Suite", Type = 2 },
                new() { Id = 27, Description = "Presidential Suite", Type = 2 },
                new() { Id = 28, Description = "Bungalow", Type = 2 },
                new() { Id = 29, Description = "Loft", Type = 2 },
                // User Roles
                new() { Id = 30, Description = "Administrator", Type = 3 },
                new() { Id = 31, Description = "User", Type = 3 },
                new() { Id = 32, Description = "Guest", Type = 3 }
            };

            foreach (var item in typedCategories)
            {
                var exists = context.TypedCategories.FirstOrDefault(tc => tc.Id == item.Id && tc.Type == item.Type);
                if (exists == null)
                    context.TypedCategories.Add(item);
            }
            context.SaveChanges();
        }

        private void SeedPeriods()
        {
            var periods = new List<Period>
            {
                new() { Name = "Winter", StartDate = new DateTime(2025, 10, 1), EndDate = new DateTime(2026, 4, 30) },
                new() { Name = "Summer", StartDate = new DateTime(2025, 5, 1), EndDate = new DateTime(2025, 9, 30) },
                new() { Name = "Spring", StartDate = new DateTime(2025, 4, 1), EndDate = new DateTime(2025, 4, 30) },
                new() { Name = "Autumn", StartDate = new DateTime(2025, 9, 1), EndDate = new DateTime(2025, 9, 30) },
                new() { Name = "Off Season", StartDate = new DateTime(2025, 1, 1), EndDate = new DateTime(2025, 2, 28) },
                new() { Name = "High Season", StartDate = new DateTime(2025, 7, 1), EndDate = new DateTime(2025, 8, 31) },
                new() { Name = "Mid Season", StartDate = new DateTime(2025, 5, 15), EndDate = new DateTime(2025, 6, 30) },
                new() { Name = "Festive", StartDate = new DateTime(2025, 12, 20), EndDate = new DateTime(2026, 1, 5) },
                new() { Name = "Low Season", StartDate = new DateTime(2025, 10, 15), EndDate = new DateTime(2025, 12, 19) },
                new() { Name = "Weekend", StartDate = new DateTime(2025, 6, 6), EndDate = new DateTime(2025, 6, 8) }
            };

            foreach (var p in periods)
            {
                var exists = context.Periods.FirstOrDefault(x => x.Name == p.Name);
                if (exists == null)
                    context.Periods.Add(p);
            }
            context.SaveChanges();
        }

        private void SeedCustomers()
        {
            var customers = new List<Customer>
            {
                new() { FirstName = "Alice", LastName = "Smith", Afm = "111111111", Email = "alice@example.com", Phone = "2101111111", Address = "Main 1", City = "Athens", Country = "Greece", ZipCode = "10001" },
                new() { FirstName = "Bob", LastName = "Brown", Afm = "222222222", Email = "bob@example.com", Phone = "2102222222", Address = "Side 2", City = "Athens", Country = "Greece", ZipCode = "10002" },
                new() { FirstName = "Carol", LastName = "White", Afm = "333333333", Email = "carol@example.com", Phone = "2103333333", Address = "Up 3", City = "Athens", Country = "Greece", ZipCode = "10003" },
                new() { FirstName = "David", LastName = "Black", Afm = "444444444", Email = "david@example.com", Phone = "2104444444", Address = "Down 4", City = "Athens", Country = "Greece", ZipCode = "10004" },
                new() { FirstName = "Eve", LastName = "Green", Afm = "555555555", Email = "eve@example.com", Phone = "2105555555", Address = "Cross 5", City = "Athens", Country = "Greece", ZipCode = "10005" },
                new() { FirstName = "Frank", LastName = "Gray", Afm = "666666666", Email = "frank@example.com", Phone = "2106666666", Address = "West 6", City = "Athens", Country = "Greece", ZipCode = "10006" },
                new() { FirstName = "Grace", LastName = "Blue", Afm = "777777777", Email = "grace@example.com", Phone = "2107777777", Address = "East 7", City = "Athens", Country = "Greece", ZipCode = "10007" },
                new() { FirstName = "Hank", LastName = "Red", Afm = "888888888", Email = "hank@example.com", Phone = "2108888888", Address = "North 8", City = "Athens", Country = "Greece", ZipCode = "10008" },
                new() { FirstName = "Ivy", LastName = "Purple", Afm = "999999999", Email = "ivy@example.com", Phone = "2109999999", Address = "South 9", City = "Athens", Country = "Greece", ZipCode = "10009" },
                new() { FirstName = "Jack", LastName = "Yellow", Afm = "123456789", Email = "jack@example.com", Phone = "2101234567", Address = "Hill 10", City = "Athens", Country = "Greece", ZipCode = "10010" }
            };

            foreach (var c in customers)
            {
                var exists = context.Customers.FirstOrDefault(x => x.Afm == c.Afm);
                if (exists == null)
                    context.Customers.Add(c);
            }
            context.SaveChanges();
        }

        private void SeedRooms()
        {
            var roomTypes = context.TypedCategories.Where(tc => tc.Type == 2).OrderBy(tc => tc.Id).ToList();
            // Make sure there are enough room types
            if (roomTypes.Count < 10) return;

            var rooms = new List<Room>
            {
                new() { RoomNumber = "101", Floor = 1, WinterPrice = 60,  SummerPrice = 80,  PeopleCapacity = 1, RoomTypeId = roomTypes[0].Id },
                new() { RoomNumber = "102", Floor = 1, WinterPrice = 75,  SummerPrice = 100, PeopleCapacity = 2, RoomTypeId = roomTypes[1].Id },
                new() { RoomNumber = "201", Floor = 2, WinterPrice = 90,  SummerPrice = 120, PeopleCapacity = 3, RoomTypeId = roomTypes[2].Id },
                new() { RoomNumber = "202", Floor = 2, WinterPrice = 200, SummerPrice = 300, PeopleCapacity = 2, RoomTypeId = roomTypes[3].Id },
                new() { RoomNumber = "203", Floor = 2, WinterPrice = 110, SummerPrice = 140, PeopleCapacity = 2, RoomTypeId = roomTypes[1].Id },
                new() { RoomNumber = "301", Floor = 3, WinterPrice = 150, SummerPrice = 220, PeopleCapacity = 4, RoomTypeId = roomTypes[4].Id },
                new() { RoomNumber = "302", Floor = 3, WinterPrice = 180, SummerPrice = 250, PeopleCapacity = 5, RoomTypeId = roomTypes[5].Id },
                new() { RoomNumber = "303", Floor = 3, WinterPrice = 210, SummerPrice = 320, PeopleCapacity = 2, RoomTypeId = roomTypes[6].Id },
                new() { RoomNumber = "401", Floor = 4, WinterPrice = 300, SummerPrice = 450, PeopleCapacity = 6, RoomTypeId = roomTypes[7].Id },
                new() { RoomNumber = "402", Floor = 4, WinterPrice = 400, SummerPrice = 600, PeopleCapacity = 8, RoomTypeId = roomTypes[8].Id }
            };

            foreach (var r in rooms)
            {
                var exists = context.Rooms.FirstOrDefault(x => x.RoomNumber == r.RoomNumber);
                if (exists == null)
                    context.Rooms.Add(r);
            }
            context.SaveChanges();
        }

        private void SeedStaff()
        {
            var specialties = context.TypedCategories.Where(tc => tc.Type == 1).OrderBy(tc => tc.Id).ToList();
            if (specialties.Count < 10) return;

            var staff = new List<Staff>
            {
                new() { Firstname = "Maria",    Lastname = "Kosta",       SpecialityId = specialties[0].Id },
                new() { Firstname = "Petros",   Lastname = "Dimos",       SpecialityId = specialties[1].Id },
                new() { Firstname = "Stella",   Lastname = "Lazos",       SpecialityId = specialties[2].Id },
                new() { Firstname = "Yannis",   Lastname = "Papadopoulos",SpecialityId = specialties[3].Id },
                new() { Firstname = "Eleni",    Lastname = "Georgiou",    SpecialityId = specialties[4].Id },
                new() { Firstname = "Kostas",   Lastname = "Alexiou",     SpecialityId = specialties[5].Id },
                new() { Firstname = "Dimitris", Lastname = "Spanos",      SpecialityId = specialties[6].Id },
                new() { Firstname = "Sophia",   Lastname = "Nikolaou",    SpecialityId = specialties[7].Id },
                new() { Firstname = "Christos", Lastname = "Kritikos",    SpecialityId = specialties[8].Id },
                new() { Firstname = "Anna",     Lastname = "Marinou",     SpecialityId = specialties[9].Id }
            };

            foreach (var s in staff)
            {
                var exists = context.Staff.FirstOrDefault(x => x.Firstname == s.Firstname && x.Lastname == s.Lastname);
                if (exists == null)
                    context.Staff.Add(s);
            }
            context.SaveChanges();
        }

        private void SeedUsers()
        {
            var adminRole = context.TypedCategories.FirstOrDefault(tc => tc.Type == 3 && tc.Description == "Administrator");
            var userRole = context.TypedCategories.FirstOrDefault(tc => tc.Type == 3 && tc.Description == "User");
            var guestRole = context.TypedCategories.FirstOrDefault(tc => tc.Type == 3 && tc.Description == "Guest");

            var users = new List<User>
            {
                new() { Username = "admin", Password = hasher.HashPassword("1234ok"), RoleId = adminRole.Id, FullName = "Admin User" },
                new() { Username = "john", Password = hasher.HashPassword("johnpass"), RoleId = userRole.Id, FullName = "John Normal" },
                new() { Username = "guest", Password = hasher.HashPassword("guestpass"), RoleId = guestRole.Id, FullName = "Guest User" },
                new() { Username = "user1", Password = hasher.HashPassword("pass1"), RoleId = userRole.Id, FullName = "User One" },
                new() { Username = "user2", Password = hasher.HashPassword("pass2"), RoleId = userRole.Id, FullName = "User Two" },
                new() { Username = "user3", Password = hasher.HashPassword("pass3"), RoleId = userRole.Id, FullName = "User Three" },
                new() { Username = "user4", Password = hasher.HashPassword("pass4"), RoleId = userRole.Id, FullName = "User Four" },
                new() { Username = "user5", Password = hasher.HashPassword("pass5"), RoleId = userRole.Id, FullName = "User Five" },
                new() { Username = "user6", Password = hasher.HashPassword("pass6"), RoleId = userRole.Id, FullName = "User Six" },
                new() { Username = "user7", Password = hasher.HashPassword("pass7"), RoleId = userRole.Id, FullName = "User Seven" }
            };

            foreach (var u in users)
            {
                var exists = context.Users.FirstOrDefault(x => x.Username == u.Username);
                if (exists == null)
                    context.Users.Add(u);
            }
            context.SaveChanges();
        }

        private void SeedReservations()
        {
            var customers = context.Customers.OrderBy(x => x.Id).Take(10).ToList();
            var rooms = context.Rooms.OrderBy(x => x.Id).Take(10).ToList();
            if (customers.Count < 10 || rooms.Count < 10) return;

            var today = DateTime.Today;

            var reservations = new List<Reservation>
            {
                new() { CustomerId = customers[0].Id, RoomId = rooms[0].Id, ReservationDateFrom = today,               ReservationDateTo = today.AddDays(2), CheckInDate = today,               CheckOutDate = today.AddDays(2), Canceled = false, ReservationDayPrice = rooms[0].WinterPrice },
                new() { CustomerId = customers[1].Id, RoomId = rooms[1].Id, ReservationDateFrom = today.AddDays(3),    ReservationDateTo = today.AddDays(6), CheckInDate = DateTime.MinValue,   CheckOutDate = DateTime.MinValue,  Canceled = false, ReservationDayPrice = rooms[1].SummerPrice },
                new() { CustomerId = customers[2].Id, RoomId = rooms[2].Id, ReservationDateFrom = today.AddDays(7),    ReservationDateTo = today.AddDays(10),CheckInDate = today.AddDays(7),    CheckOutDate = today.AddDays(10),  Canceled = false, ReservationDayPrice = rooms[2].WinterPrice },
                new() { CustomerId = customers[3].Id, RoomId = rooms[3].Id, ReservationDateFrom = today.AddDays(11),   ReservationDateTo = today.AddDays(13),CheckInDate = DateTime.MinValue,   CheckOutDate = DateTime.MinValue,  Canceled = false, ReservationDayPrice = rooms[3].SummerPrice },
                new() { CustomerId = customers[4].Id, RoomId = rooms[4].Id, ReservationDateFrom = today.AddDays(14),   ReservationDateTo = today.AddDays(16),CheckInDate = DateTime.MinValue,   CheckOutDate = DateTime.MinValue,  Canceled = false, ReservationDayPrice = rooms[4].WinterPrice },
                new() { CustomerId = customers[5].Id, RoomId = rooms[5].Id, ReservationDateFrom = today.AddDays(17),   ReservationDateTo = today.AddDays(19),CheckInDate = today.AddDays(17),   CheckOutDate = today.AddDays(19),  Canceled = false, ReservationDayPrice = rooms[5].SummerPrice },
                new() { CustomerId = customers[6].Id, RoomId = rooms[6].Id, ReservationDateFrom = today.AddDays(20),   ReservationDateTo = today.AddDays(21),CheckInDate = DateTime.MinValue,   CheckOutDate = DateTime.MinValue,  Canceled = false, ReservationDayPrice = rooms[6].WinterPrice },
                new() { CustomerId = customers[7].Id, RoomId = rooms[7].Id, ReservationDateFrom = today.AddDays(22),   ReservationDateTo = today.AddDays(24),CheckInDate = today.AddDays(22),   CheckOutDate = today.AddDays(24),  Canceled = false, ReservationDayPrice = rooms[7].SummerPrice },
                new() { CustomerId = customers[8].Id, RoomId = rooms[8].Id, ReservationDateFrom = today.AddDays(25),   ReservationDateTo = today.AddDays(28),CheckInDate = DateTime.MinValue,   CheckOutDate = DateTime.MinValue,  Canceled = true,  ReservationDayPrice = rooms[8].WinterPrice },
                new() { CustomerId = customers[9].Id, RoomId = rooms[9].Id, ReservationDateFrom = today.AddDays(29),   ReservationDateTo = today.AddDays(31),CheckInDate = today.AddDays(29),   CheckOutDate = today.AddDays(31),  Canceled = false, ReservationDayPrice = rooms[9].SummerPrice }
            };

            foreach (var r in reservations)
            {
                var exists = context.Reservations.FirstOrDefault(x =>
                    x.CustomerId == r.CustomerId && x.RoomId == r.RoomId && x.ReservationDateFrom == r.ReservationDateFrom);
                if (exists == null)
                    context.Reservations.Add(r);
            }
            context.SaveChanges();
        }
    }
}
