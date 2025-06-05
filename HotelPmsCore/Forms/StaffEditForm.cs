using HotelPmsCore.Models;
using HotelPmsCore.Services;
using System;
using System.Windows.Forms;

namespace HotelPmsCore.Forms
{
    public partial class StaffEditForm : Form
    {
        private readonly StaffService svc;

        public StaffEditForm(StaffService svc)
        {
            InitializeComponent();
            this.svc = svc;

            this.StaffBindingSource.DataSource = svc.BndSource;

            this.textBoxFirstname.DataBindings.Add("Text", this.StaffBindingSource, nameof(Models.Staff.Firstname), true, DataSourceUpdateMode.OnPropertyChanged);

            this.textBoxLastname.DataBindings.Add("Text", this.StaffBindingSource, nameof(Models.Staff.Lastname), true, DataSourceUpdateMode.OnPropertyChanged);
            this.textBoxSpeciality.DataBindings.Add("Text", this.StaffBindingSource, nameof(Models.Staff.Speciality), true, DataSourceUpdateMode.OnPropertyChanged);


        }


        private void button1save_Click(object sender, EventArgs e)
        {

            DialogResult = DialogResult.OK;
        }

        private void button2cancel_Click(object sender, EventArgs e)
        {

            DialogResult = DialogResult.Cancel;
        }
    }
}
