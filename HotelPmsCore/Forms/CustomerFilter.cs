using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelPmsCore.Forms

{
    public partial class CustomerFilter : Form
    {
        private Dictionary<string, object> filterValues = [];
        public Dictionary<string, object> FilterValues
        {
            get { return filterValues; }
            set { filterValues = value; }
        }
        public CustomerFilter()
        {
            InitializeComponent();
        }

        private void ButtonClFilter_Click(object sender, EventArgs e)
        {
            filterValues.Clear();
            TextBoxName.Text = "";
            TextBoxNameTo.Text = "";
            TextBoxSurname.Text = "";
            TextBoxAfm.Text = "";

        }

        private void ButtonOk_Click(object sender, EventArgs e)
        {
            GetFilterValues();
            DialogResult = DialogResult.OK;
            Close();


        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();

        }

        private void GetFilterValues()
        {
            filterValues.Clear();

            var FirstName = TextBoxName.Text.Trim();
            if (!string.IsNullOrEmpty(FirstName))
            {
                FirstName = FirstName.Replace("*", "%");
                filterValues["FirstName"] = FirstName;
            }

            var FirstNameTo = TextBoxNameTo.Text.Trim();
            if (!string.IsNullOrEmpty(FirstNameTo))
            {
                FirstNameTo = FirstNameTo.Replace("*", "%");
                filterValues["FirstNameTo"] = FirstNameTo;
            }

            var LastName = TextBoxSurname.Text.Trim();
            if (!string.IsNullOrEmpty(LastName))
            {
                LastName = LastName.Replace("*", "%");
                filterValues["LastName"] = LastName;
            }
            var Afm = TextBoxAfm.Text.Trim();
            if (!string.IsNullOrEmpty(Afm))
            {
                Afm = Afm.Replace("*", "%");
                filterValues["Afm"] = Afm;
            }

        }
        private void CustomerFilter_Shown(object sender, EventArgs e)
        {
            if (filterValues.Count > 0)
            {
                filterValues.TryGetValue("FirstName", out object? FirstNameValue);
                if (FirstNameValue != null)
                    TextBoxName.Text = FirstNameValue.ToString()?.Replace("%", "*");
                filterValues.TryGetValue("FirstNameTo", out object? FirstNameValueTo);
                if (FirstNameValueTo != null)
                    TextBoxNameTo.Text = FirstNameValueTo.ToString()?.Replace("%", "*");
                filterValues.TryGetValue("LastName", out object? LastNameValue);
                if (LastNameValue != null)
                    TextBoxSurname.Text = LastNameValue.ToString()?.Replace("%", "*");
                filterValues.TryGetValue("Afm", out object? AfmValue);
                if (AfmValue != null)
                    TextBoxAfm.Text = AfmValue.ToString()?.Replace("%", "*");
            }
        }

       
        private void CustomerFilter_Load(object sender, EventArgs e)
        {

        }
    }
}
