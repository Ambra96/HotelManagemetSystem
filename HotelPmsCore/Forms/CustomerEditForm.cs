using HotelPmsCore.Models;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace HotelPmsCore.Forms
{
    public partial class CustomerEditForm : Form
    {
        private Customer customer;
        private bool isNewCustomer = false;

        public CustomerEditForm(Customer customer)
        {
            InitializeComponent();

            this.customer = customer;
            this.CancelButton = btnCancel;

            InitializeDataBindings();
            ConfigureForm();
        }

        public CustomerEditForm() : this(new Customer())
        {
            isNewCustomer = true;
            Text = "New Customer";
        }

        private void ConfigureForm()
        {
            if (!isNewCustomer)
            {
                Text = $"Create/Edit Customer: {customer.FirstName} {customer.LastName}";
            }
        }

        private void InitializeDataBindings()
        {
            txtFirstName.DataBindings.Add("Text", customer, nameof(Customer.FirstName));
            txtLastName.DataBindings.Add("Text", customer, nameof(Customer.LastName));
            txtAFM.DataBindings.Add("Text", customer, nameof(Customer.Afm));

            txtEmail.DataBindings.Add("Text", customer, nameof(Customer.Email));
            txtPhone.DataBindings.Add("Text", customer, nameof(Customer.Phone));

            txtAddress.DataBindings.Add("Text", customer, nameof(Customer.Address));
            txtCity.DataBindings.Add("Text", customer, nameof(Customer.City));
            txtCountry.DataBindings.Add("Text", customer, nameof(Customer.Country));
            txtZipCode.DataBindings.Add("Text", customer, nameof(Customer.ZipCode));
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
