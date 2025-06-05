using HotelPmsCore.Data;
using HotelPmsCore.Forms;
using HotelPmsCore.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace HotelPmsCore.Services
{
    public class CustomerService : PagedService<CustomerForm, CustomerEditForm, Customer>
    {
        public Dictionary<string, object> FilterValues { get; set; } = new();

        public CustomerService(HotelPmsCoreContext context) : base(context) { }



        public void ApplyFilters(Dictionary<string, object> filterValues)
        {
            var query = context.Customers.AsQueryable();

     
            if (filterValues.TryGetValue("FirstName", out var fn) && fn is string firstName && !string.IsNullOrWhiteSpace(firstName))
                query = query.Where(c => EF.Functions.Like(c.FirstName, firstName));

           
            if (filterValues.TryGetValue("FirstNameTo", out var fnTo) && fnTo is string firstNameTo && !string.IsNullOrWhiteSpace(firstNameTo))
                query = query.Where(c => EF.Functions.Like(c.FirstName, firstNameTo));

      
            if (filterValues.TryGetValue("LastName", out var ln) && ln is string lastName && !string.IsNullOrWhiteSpace(lastName))
                query = query.Where(c => EF.Functions.Like(c.LastName, lastName));

            if (filterValues.TryGetValue("Afm", out var afm) && afm is string afmVal && !string.IsNullOrWhiteSpace(afmVal))
                query = query.Where(c => EF.Functions.Like(c.Afm, afmVal));

            BndSource.DataSource = query.ToList();
           

        }

    }
}


