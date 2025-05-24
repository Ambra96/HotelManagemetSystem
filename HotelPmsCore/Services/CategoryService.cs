using System.Linq;
using HotelPmsCore.Data;
using HotelPmsCore.Models;

namespace HotelPmsCore.Services
{
    public class CategoryServices
        : BaseService<
            Forms.CategoryForm,
            Forms.CategoryEditForm,
            TypedCategory>
    {
        public CategoryServices(HotelPmsCoreContext ctx) : base(ctx)
        {
            SetCurrentTable(ctx.TypedCategories.OrderBy(tc => tc.Description));
        }
    }
}
