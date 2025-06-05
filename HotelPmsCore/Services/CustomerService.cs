using System.Linq;
using HotelPmsCore.Data;
using HotelPmsCore.Models;

namespace HotelPmsCore.Services
{
    public class CustomerService
        : PagedService<
            Forms.CustomerForm,
            Forms.CustomerEditForm,
            Customer>
    {
        public CustomerService(HotelPmsCoreContext context)
            : base(context)
        {
           
        }
    }
}
