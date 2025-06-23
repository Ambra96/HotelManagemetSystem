using System;
using System.Windows.Forms;
using HotelPmsCore.Services;
using HotelPmsCore.Models;
using System.Linq;

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


            this.txtId.DataBindings.Add("Text", this.typedCategoryBindingSource, "Id", true, DataSourceUpdateMode.OnPropertyChanged);
            this.txtDescription.DataBindings.Add("Text", this.typedCategoryBindingSource, "Description", true, DataSourceUpdateMode.OnPropertyChanged);


            comboType.Items.Add(new ComboBoxItem("Staff Speciality", 1));
            comboType.Items.Add(new ComboBoxItem("Room Type", 2));
            comboType.Items.Add(new ComboBoxItem("User Role", 3));
            comboType.DisplayMember = "Text";
            comboType.ValueMember = "Value";

          
            comboType.DataBindings.Add("SelectedValue", this.typedCategoryBindingSource, "Type", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void SaveBttn_Click(object sender, EventArgs e)
        {
            var current = (TypedCategory)typedCategoryBindingSource.Current;
            int id;
            int.TryParse(txtId.Text, out id);

            if (id == 0 || comboType.SelectedValue == null)
            {
                MessageBox.Show("Please enter a valid ID and select a Type.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int type = (int)comboType.SelectedValue;

            bool exists = svc.BndSource.Cast<TypedCategory>()
                .Any(tc => tc.Id == id && tc.Type == type && tc != current);

            if (exists)
            {
                MessageBox.Show(" ID and Type must be unique.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            current.Id = id;
            current.Type = type;
            current.Description = txtDescription.Text;

            this.DialogResult = DialogResult.OK;
            svc.RefreshGrid();
        }

        private void CancelBttn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

      
        private class ComboBoxItem
        {
            public string Text { get; }
            public int Value { get; }
            public ComboBoxItem(string text, int value) { Text = text; Value = value; }
            public override string ToString() => Text;
        }
    }
}
