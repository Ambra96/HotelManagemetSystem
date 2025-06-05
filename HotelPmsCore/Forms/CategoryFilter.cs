using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelPmsCore.Forms
{
    public partial class CategoryFilter : Form
    {
        private Dictionary<string, object> filterValues = [];
        public Dictionary<string, object> FilterValues
        {
            get { return filterValues; }
            set { filterValues = value; }
        }
        public CategoryFilter()
        {
            InitializeComponent();
        }

        private void ButtonClFilter_Click_1(object sender, EventArgs e)
        {
            filterValues.Clear();
            textBoxDesc.Text = "";

        }

        private void ButtonOk_Click_1(object sender, EventArgs e)
        {
            GetFilterValues();
            DialogResult = DialogResult.OK;
            Close();


        }

        private void ButtonCancel_Click_1(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();

        }

        private void GetFilterValues()
        {
            filterValues.Clear();

            var Description = textBoxDesc.Text.Trim();
            if (!string.IsNullOrEmpty(Description))
            {
                Description = Description.Replace("*", "%");
                filterValues["Description"] = Description;
            }



        }
        private void CategoryFilter_Shown(object sender, EventArgs e)
        {
            if (filterValues.Count > 0)
            {
                filterValues.TryGetValue("Description", out object? DescriptionValue);
                if (DescriptionValue != null)
                    textBoxDesc.Text = DescriptionValue.ToString()?.Replace("%", "*");

            }
        }


        private void CategoryFilter_Load(object sender, EventArgs e)
        {

        }



    }
}
