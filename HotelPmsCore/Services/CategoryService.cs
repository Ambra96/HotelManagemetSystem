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
        public int? CategoryType { get; set; }

        public CategoryService(HotelPmsCoreContext context) : base(context) { }


        public override void RefreshGrid()
        {
            IQueryable<TypedCategory> query = context.TypedCategories;

            if (CategoryType != null && CategoryType != 0)
                query = query.Where(tc => tc.Type == this.CategoryType);

            all = query.OrderBy(tc => tc.Id).ToList();
            BndSource.DataSource = new BindingList<TypedCategory>(all);
        }



        public void ApplyFilters(Dictionary<string, object> filterValues)
        {
            var query = context.TypedCategories.AsQueryable();

            if (filterValues.TryGetValue("Description", out var fn) && fn is string desc && !string.IsNullOrWhiteSpace(desc))
                query = query.Where(c => EF.Functions.Like(c.Description, desc));

            var result = query.OrderBy(tc => tc.Id).ToList();

            all = result;
            BndSource.DataSource = new BindingList<TypedCategory>(all);
        }


    }
}