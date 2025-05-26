using System;
using System.Windows.Forms;
using HotelPmsCore.Models;
using HotelPmsCore.Services;

namespace HotelPmsCore.Forms
{
    public partial class CategoryEditForm : Form
    {
        public CategoryEditForm(CategoryService service)
        {
            InitializeComponent();

            categoryBindingSource.DataSource = service.BndSource;

     
            txtId.DataBindings.Add(
                "Text",
                categoryBindingSource,
                nameof(TypedCategory.Id),
                false,
                DataSourceUpdateMode.Never);

        
            txtDescription.DataBindings.Add(
                "Text",
                categoryBindingSource,
                nameof(TypedCategory.Description),
                true,
                DataSourceUpdateMode.OnPropertyChanged);

            SaveBttn.Click += (_, __) => DialogResult = DialogResult.OK;
            CancelBttn.Click += (_, __) => DialogResult = DialogResult.Cancel;
        }
    }
}


