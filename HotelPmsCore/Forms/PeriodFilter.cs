using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HotelPmsCore.Forms
{
    public partial class PeriodFilter : Form
    {
        private Dictionary<string, object> filterValues = new();
        public Dictionary<string, object> FilterValues
        {
            get { return filterValues; }
            set { filterValues = value; }
        }

        public PeriodFilter()
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
            textBoxName.Text = "";
            dateTimePickerStart.Value = DateTime.Today;
            dateTimePickerEnd.Value = DateTime.Today;
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void GetFilterValues()
        {
            filterValues.Clear();

            var name = textBoxName.Text.Trim();
            if (!string.IsNullOrEmpty(name))
            {
                name = name.Replace("*", "%");
                filterValues["Name"] = name;
            }

            
            if (dateTimePickerStart.Checked)
            {
                filterValues["StartDate"] = dateTimePickerStart.Value.Date;
            }

            if (dateTimePickerEnd.Checked)
            {
                filterValues["EndDate"] = dateTimePickerEnd.Value.Date;
            }
        }

        private void PeriodFilter_Shown(object sender, EventArgs e)
        {
            if (filterValues.Count > 0)
            {
                if (filterValues.TryGetValue("Name", out object? nameVal))
                    textBoxName.Text = nameVal?.ToString()?.Replace("%", "*") ?? "";

                if (filterValues.TryGetValue("StartDate", out object? startVal) && startVal is DateTime sdt)
                {
                    dateTimePickerStart.Value = sdt;
                    dateTimePickerStart.Checked = true;
                }
                else
                    dateTimePickerStart.Checked = false;

                if (filterValues.TryGetValue("EndDate", out object? endVal) && endVal is DateTime edt)
                {
                    dateTimePickerEnd.Value = edt;
                    dateTimePickerEnd.Checked = true;
                }
                else
                    dateTimePickerEnd.Checked = false;
            }
        }
    }
}
