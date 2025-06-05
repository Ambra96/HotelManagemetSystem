using HotelPmsCore.Data;
using HotelPmsCore.Models;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace HotelPmsCore.Services
{
    public class StaffService
        : PagedService<Forms.StaffForm, Forms.StaffEditForm, Staff>
    {
        public StaffService(HotelPmsCoreContext context) : base(context) { }

        public void ApplyFilters(Dictionary<string, object> filterValues)
        {
            var query = context.Staff.AsQueryable();

            if (filterValues.TryGetValue("Firstname", out var fn) && fn is string Firstname && !string.IsNullOrWhiteSpace(Firstname))
                query = query.Where(s => EF.Functions.Like(s.Firstname, Firstname));
            if (filterValues.TryGetValue("Lastname", out var ln) && ln is string Lastname && !string.IsNullOrWhiteSpace(Lastname))
                query = query.Where(s => EF.Functions.Like(s.Lastname, Lastname));

            BndSource.DataSource = query.ToList();
        }
    }
}
