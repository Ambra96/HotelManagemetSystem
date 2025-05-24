using System;
using System.Windows.Forms;
using HotelPmsCore.Models;

namespace HotelPmsCore.Forms
{
    public partial class CategoryEditForm : Form
    {
        public TypedCategory Category { get; }

        public CategoryEditForm(TypedCategory category)
        {
            InitializeComponent();
            Category = category;

          
            TxtDesc.DataBindings.Add("Text", Category, nameof(Category.Description));
            TxtType.DataBindings.Add("Text", Category, nameof(Category.Type));
        }

        private void SaveBttn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void CancelBttn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
