using HotelPmsCore.Data;
using HotelPmsCore.Forms;
using HotelPmsCore.Models;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;

namespace HotelPmsCore.Services
{
    public class CategoryService
        : BaseService<CategoryForm, CategoryEditForm, TypedCategory>
    {
        public int CategoryType { get; set; }

        public CategoryService(HotelPmsCoreContext context)
            : base(context)
        {

        }


    }
}


