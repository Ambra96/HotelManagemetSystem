using HotelPmsCore.Data;
using HotelPmsCore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelPmsCore.Services
{
    public class UserService
        : PagedService<
            Forms.UserForm,
            Forms.UserEditForm,
            User>
    {
        public UserService(HotelPmsCoreContext context)
            : base(context)
        {

        }

        public void ApplyFilters(Dictionary<string, object> filterValues)
        {
            var query = context.Users.AsQueryable();

            if (filterValues.TryGetValue("Username", out var Username) && Username is string u && !string.IsNullOrWhiteSpace(u))
                query = query.Where(user => EF.Functions.Like(user.Username, u));

            if (filterValues.TryGetValue("FullName", out var FullName) && FullName is string fn && !string.IsNullOrWhiteSpace(fn))
                query = query.Where(user => EF.Functions.Like(user.FullName, fn));

            BndSource.DataSource = query.ToList();
        }

    }
}

