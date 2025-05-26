using System.Collections.Generic;
using System.Linq;
using HotelPmsCore.Data;
using HotelPmsCore.Models;

namespace HotelPmsCore.Services
{

    public class StartupData
    {
        public List<TypedCategory> UserRoles { get; }
        public List<TypedCategory> RoomTypes { get; }
        public List<TypedCategory> SpecialtyTypes { get; }
        public List<Period> Periods { get; }

        public StartupData(HotelPmsCoreContext context)
        {
      
            UserRoles = new List<TypedCategory> { new() { Id = 0, Type = 3 } }
                                .Concat(context.TypedCategories.Where(x => x.Type == 3))
                                .ToList();

            RoomTypes = new List<TypedCategory> { new() { Id = 0, Type = 2 } }
                                .Concat(context.TypedCategories.Where(x => x.Type == 2))
                                .ToList();

            SpecialtyTypes = new List<TypedCategory> { new() { Id = 0, Type = 1 } }
                                .Concat(context.TypedCategories.Where(x => x.Type == 1))
                                .ToList();

            Periods = new List<Period> { new() { Id = 0, Name = "" } }
                                .Concat(context.Periods.OrderBy(p => p.StartDate))
                                .ToList();
        }
    }
}
