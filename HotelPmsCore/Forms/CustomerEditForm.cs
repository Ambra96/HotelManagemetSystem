using HotelPmsCore.Models;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace HotelPmsCore.Forms
{
    public partial class CustomerEditForm : Form
    {
        private Customer _customer;
        private bool _isNewCustomer = false;

        public CustomerEditForm(Customer customer)
        {
            InitializeComponent();

            _customer = customer;
            this.CancelButton = btnCancel;

            InitializeDataBindings();
            ConfigureForm();
        }



        public CustomerEditForm() : this(new Customer())
        {
            _isNewCustomer = true;
            Text = "New Customer";
        }

        private void ConfigureForm()
        {

            if (!_isNewCustomer)
            {
                Text = $"Create/Edit Customer: {_customer.FirstName} {_customer.LastName}";
            }
        }

        private void InitializeDataBindings()
        {

            txtFirstName.DataBindings.Add("Text", _customer, nameof(Customer.FirstName));
            txtLastName.DataBindings.Add("Text", _customer, nameof(Customer.LastName));
            txtAFM.DataBindings.Add("Text", _customer, nameof(Customer.Afm));

            txtEmail.DataBindings.Add("Text", _customer, nameof(Customer.Email));
            txtPhone.DataBindings.Add("Text", _customer, nameof(Customer.Phone));

            txtAddress.DataBindings.Add("Text", _customer, nameof(Customer.Address));
            txtCity.DataBindings.Add("Text", _customer, nameof(Customer.City));
            txtCountry.DataBindings.Add("Text", _customer, nameof(Customer.Country));
            txtZipCode.DataBindings.Add("Text", _customer, nameof(Customer.ZipCode));
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