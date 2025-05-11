using System.Windows.Forms;
using HotelPmsCore.Models;
using HotelPmsCore.Services;

namespace HotelPmsCore.Forms
{
    public partial class CategoryForm : CrudServices<TypedCategory>
    {
        public CategoryForm()
        {
            InitializeComponent();

        }

        protected override DataGridView Grid => dataGridViewCategory;

        protected override Form CreateEditForm(TypedCategory e)

            => new CategoryEditForm(e);


    }
}
