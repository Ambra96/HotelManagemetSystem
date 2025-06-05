using HotelPmsCore.Data;
using HotelPmsCore.Forms;
using HotelPmsCore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.ComponentModel;
using System.Linq;

namespace HotelPmsCore.Services
{
    public class CategoryService : PagedService<CategoryForm, CategoryEditForm, TypedCategory>
    {
        public int CategoryType { get; set; } //= 2;

        public CategoryService(HotelPmsCoreContext context) : base(context) { }


        public override void RefreshGrid()
        {

            all = context.TypedCategories.Where(tc => tc.Type == this.CategoryType).OrderBy(tc => tc.Id).ToList();
            BndSource.DataSource = new BindingList<TypedCategory>(all);


        }


        public void ApplyFilters(Dictionary<string, object> filterValues)
        {
            var query = context.TypedCategories
                .Where(tc => tc.Type == this.CategoryType)
                .AsQueryable();

            if (filterValues.TryGetValue("Description", out var fn) && fn is string desc && !string.IsNullOrWhiteSpace(desc))
                query = query.Where(c => EF.Functions.Like(c.Description, desc));

            BndSource.DataSource = query.ToList();
        }

    }
}