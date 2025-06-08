using HotelPmsCore.Data;
using HotelPmsCore.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelPmsCore.Forms
{
    public partial class NewCustomerForm : Form
    {
        private readonly HotelPmsCoreContext context;
        public NewCustomerForm(HotelPmsCoreContext context)
        {
            InitializeComponent();
            this.context = context;
            
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            var customer = new Customer
            {
                FirstName = txtFirstName.Text.Trim(),
                LastName = txtLastName.Text.Trim(),
                Afm = txtAFM.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Phone = txtPhone.Text.Trim(),
                Address = txtAddress.Text.Trim(),
                City = txtCity.Text.Trim(),
                Country = txtCountry.Text.Trim(),
                ZipCode = txtZipCode.Text.Trim()
            };
            context.Customers.Add(customer);
            context.SaveChanges();
            DialogResult = DialogResult.OK;
        }

     

    }

}
