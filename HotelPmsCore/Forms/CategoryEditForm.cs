using System;
using System.ComponentModel;
using System.Windows.Forms;
using HotelPmsCore.Services;

namespace HotelPmsCore.Forms
{
    public partial class CategoryEditForm : Form
    {
        private readonly CategoryService svc;

        public CategoryEditForm(CategoryService svc)
        {
            InitializeComponent();
            this.svc = svc;
            this.typedCategoryBindingSource.DataSource = svc.BndSource;

            this.txtDescription.DataBindings.Add(
                "Text",
                this.typedCategoryBindingSource,
                "Description",
                true,
                DataSourceUpdateMode.OnPropertyChanged);
        }

        private void SaveBttn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
         
            svc.RefreshGrid();
        }

       
        private void CancelBttn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

    }

}
