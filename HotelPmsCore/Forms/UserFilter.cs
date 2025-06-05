using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HotelPmsCore.Forms
{
    public partial class UserFilter : Form
    {
        private Dictionary<string, object> filterValues = new();
        public Dictionary<string, object> FilterValues
        {
            get => filterValues;
            set => filterValues = value;
        }

        public UserFilter()
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
            textBoxUsername.Text = "";
            textBoxFullName.Text = "";
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void GetFilterValues()
        {
            filterValues.Clear();

            var Username = textBoxUsername.Text.Trim();
            if (!string.IsNullOrEmpty(Username))
            {
                Username = Username.Replace("*", "%");
                filterValues["Username"] = Username;
            }

            var FullName = textBoxFullName.Text.Trim();
            if (!string.IsNullOrEmpty(FullName))
            {
                FullName = FullName.Replace("*", "%");
                filterValues["FullName"] = FullName;
            }
        }

        private void UserFilter_Shown(object sender, EventArgs e)
        {
            if (filterValues.Count > 0)
            {
                if (filterValues.TryGetValue("Username", out object? usernameVal) && usernameVal != null)
                    textBoxUsername.Text = usernameVal.ToString()?.Replace("%", "*");
                if (filterValues.TryGetValue("FullName", out object? fullNameVal) && fullNameVal != null)
                    textBoxFullName.Text = fullNameVal.ToString()?.Replace("%", "*");
            }
        }
    }
}
