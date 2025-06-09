using HotelPmsCore.Models;
using HotelPmsCore.Services;
using System;
using System.Windows.Forms;

namespace HotelPmsCore.Forms
{
    public partial class CustomerEditForm : Form
    {
        private readonly CustomerService svc;

        public CustomerEditForm(CustomerService svc)
        {
            InitializeComponent();
            this.svc = svc;

            this.bindingSourceCustomer.DataSource = svc.BndSource;

            this.txtFirstName.DataBindings.Add("Text", this.bindingSourceCustomer, nameof(Models.Customer.FirstName), true, DataSourceUpdateMode.OnPropertyChanged);

            this.txtLastName.DataBindings.Add("Text", this.bindingSourceCustomer, nameof(Models.Customer.LastName), true, DataSourceUpdateMode.OnPropertyChanged);

            this.txtAFM.DataBindings.Add("Text", this.bindingSourceCustomer, nameof(Models.Customer.Afm), true, DataSourceUpdateMode.OnPropertyChanged);
            this.txtEmail.DataBindings.Add("Text", this.bindingSourceCustomer, nameof(Customer.Email), true, DataSourceUpdateMode.OnPropertyChanged);

            this.txtPhone.DataBindings.Add("Text", this.bindingSourceCustomer, nameof(Customer.Phone), true, DataSourceUpdateMode.OnPropertyChanged);

            this.txtAddress.DataBindings.Add("Text", this.bindingSourceCustomer, nameof(Customer.Address), true, DataSourceUpdateMode.OnPropertyChanged);

            this.txtCity.DataBindings.Add("Text", this.bindingSourceCustomer, nameof(Customer.City), true, DataSourceUpdateMode.OnPropertyChanged);

            this.txtCountry.DataBindings.Add("Text", this.bindingSourceCustomer, nameof(Customer.Country), true, DataSourceUpdateMode.OnPropertyChanged);

            this.txtZipCode.DataBindings.Add("Text", this.bindingSourceCustomer, nameof(Customer.ZipCode), true, DataSourceUpdateMode.OnPropertyChanged);

        }

        private void SaveButton_Click_1(object sender, EventArgs e)
        {

            DialogResult = DialogResult.OK;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {

            DialogResult = DialogResult.Cancel;
        }

        private void CustomerEditForm_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
