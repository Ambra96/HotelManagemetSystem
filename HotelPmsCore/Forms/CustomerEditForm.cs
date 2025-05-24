using System;
using System.Windows.Forms;
using HotelPmsCore.Models;

namespace HotelPmsCore.Forms
{
    public partial class CustomerEditForm : Form
    {
        public Customer Customer { get; }

        public CustomerEditForm(Customer customer)
        {
            InitializeComponent();
            Customer = customer;

            // Bind each textbox directly to the Customer instance
            txtFirstName.DataBindings.Add("Text", Customer, nameof(Customer.FirstName));
            txtLastName.DataBindings.Add("Text", Customer, nameof(Customer.LastName));
            txtAFM.DataBindings.Add("Text", Customer, nameof(Customer.Afm));
            txtEmail.DataBindings.Add("Text", Customer, nameof(Customer.Email));
            txtPhone.DataBindings.Add("Text", Customer, nameof(Customer.Phone));
            txtAddress.DataBindings.Add("Text", Customer, nameof(Customer.Address));
            txtCity.DataBindings.Add("Text", Customer, nameof(Customer.City));
            txtCountry.DataBindings.Add("Text", Customer, nameof(Customer.Country));
            txtZipCode.DataBindings.Add("Text", Customer, nameof(Customer.ZipCode));

            // Wire up Save/Cancel
            SaveButton.Click += (_, __) => { DialogResult = DialogResult.OK; };
            btnCancel.Click += (_, __) => { DialogResult = DialogResult.Cancel; };
        }
    }
}
