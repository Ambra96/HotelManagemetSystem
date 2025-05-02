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


        // For creating new customers
        public CustomerEditForm() : this(new Customer())
        {
            _isNewCustomer = true;
            Text = "New Customer";
        }

        private void ConfigureForm()
        {
         
            if (!_isNewCustomer)
            {
                Text = $"Edit Customer: {_customer.FirstName} {_customer.LastName}";
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

        // Validation
        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtFirstName, "First name is required");
            }
            else
            {
                errorProvider.SetError(txtFirstName, "");
            }
        }

        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtLastName, "Last name is required");
            }
            else
            {
                errorProvider.SetError(txtLastName, "");
            }
        }

        public Customer GetEditedCustomer()
        {
            // Validate and update 
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                //update the customer object
                foreach (Control control in Controls)
                {
                    foreach (Binding binding in control.DataBindings)
                    {
                        binding.WriteValue();
                    }
                }
            }
            return _customer;
        }


    }
}