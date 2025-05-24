using System;
using System.Windows.Forms;
using HotelPmsCore.Services;

namespace HotelPmsCore.Forms
{
    public partial class CategoryEditForm : Form
    {
        private readonly CategoryServices svc;

        public CategoryEditForm(CategoryServices svc)
        {
            InitializeComponent();
            this.svc = svc;

            categoryBindingSource.DataSource = svc.BndSource;
        }

        private void SaveBttn_Click(object sender, EventArgs e)
        {

            DialogResult = DialogResult.OK;
        }

        private void CancelBttn_Click(object sender, EventArgs e)
        {

            DialogResult = DialogResult.Cancel;
        }

 
    }
}
