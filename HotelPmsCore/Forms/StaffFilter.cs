using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HotelPmsCore.Forms
{
    public partial class StaffFilter : Form
    {
        private Dictionary<string, object> filterValues = new();
        public Dictionary<string, object> FilterValues
        {
            get { return filterValues; }
            set { filterValues = value; }
        }

        public StaffFilter()
        {
            InitializeComponent();
        }

        private void ButtonOk_Click(object sender, EventArgs e)
        {
            GetFilterValues();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void ButtonClFilter_Click(object sender, EventArgs e)
        {
            filterValues.Clear();
            textBoxFirstname.Text = "";
            textBoxLastname.Text = "";
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void GetFilterValues()
        {
            filterValues.Clear();

            var Firstname = textBoxFirstname.Text.Trim();
            if (!string.IsNullOrEmpty(Firstname))
            {
                Firstname = Firstname.Replace("*", "%");
                filterValues["Firstname"] = Firstname;
            }

            var Lastname = textBoxLastname.Text.Trim();
            if (!string.IsNullOrEmpty(Lastname))
            {
                Lastname = Lastname.Replace("*", "%");
                filterValues["LastName"] = Lastname;
            }
        }

        private void StaffFilter_Shown(object sender, EventArgs e)
        {
            if (filterValues.Count > 0)
            {
                filterValues.TryGetValue("FirstName", out object? fnValue);
                if (fnValue != null)
                    textBoxFirstname.Text = fnValue.ToString()?.Replace("%", "*");
                filterValues.TryGetValue("LastName", out object? lnValue);
                if (lnValue != null)
                    textBoxLastname.Text = lnValue.ToString()?.Replace("%", "*");
            }
        }
    }
}
