using HotelPmsCore.Data;
using HotelPmsCore.Forms;
using HotelPmsCore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HotelPmsCore.Services
{
    public class PeriodService : PagedService<PeriodForm, PeriodEditForm, Period>
    {
        public Dictionary<string, object> FilterValues { get; set; } = new();

        public PeriodService(HotelPmsCoreContext context) : base(context) { }

        public void ApplyFilters(Dictionary<string, object> filterValues)
        {
            var query = context.Periods.AsQueryable();

            // If NOfilters load all data
            if (filterValues == null || filterValues.Count == 0)
            {
                BndSource.DataSource = query.OrderBy(p => p.Id).ToList();
                return;
            }

            if (filterValues.TryGetValue("Name", out var n) && n is string name && !string.IsNullOrWhiteSpace(name))
                query = query.Where(p => EF.Functions.Like(p.Name, name));

           
            if (filterValues.TryGetValue("StartDate", out var sd) && sd is DateTime start)
                query = query.Where(p => p.StartDate >= start);

            
            if (filterValues.TryGetValue("EndDate", out var ed) && ed is DateTime end)
                query = query.Where(p => p.EndDate <= end);

            BndSource.DataSource = query.OrderBy(p => p.Id).ToList();
        }

    }
}
