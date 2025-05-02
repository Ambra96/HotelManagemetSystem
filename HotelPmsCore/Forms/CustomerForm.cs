using HotelPmsCore.Data;
using HotelPmsCore.Models;
using HotelPmsCore.Services;
using Microsoft.EntityFrameworkCore;
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
    public partial class CustomerForm : Form
    {
        private HotelPmsCoreContext context;
        private BindingSource bindingSource = new();
        private int pageSize = 10;  // Number of records per page
        private int currentPage = 0; // Current page index
        private int totalRecords = 0; // Total records in the database
        private int totalPages = 0; // Total number of pages
        public bool HasSelection => dataGridViewCustomer.SelectedRows.Count > 0;

        public CustomerForm()
        {
            InitializeComponent();
            context = new HotelPmsCoreContext();
            LoadData();
        }

        private void LoadData(bool resetPagination = false)
        {
            if (resetPagination)
            {
                currentPage = 0; // Reset to first page for new entries
            }

            totalRecords = context.Customers.Count();
            totalPages = (int)Math.Floor((double)totalRecords / pageSize);

            var customers = context.Customers
                .OrderBy(x => x.Id)
                .Skip(currentPage * pageSize)
                .Take(pageSize)
                .ToList();

            bindingSource.DataSource = customers;
            dataGridViewCustomer.DataSource = bindingSource;
            UpdateButtonStates();
        }

        private void UpdateButtonStates()
        {
            PreviousButton.Enabled = currentPage > 0; // Disable if on first page
            NextButton.Enabled = currentPage < totalPages; // Disable if on last page
        }

        private void PreviousButton_Click(object sender, EventArgs e)
        {
            if (currentPage > 0)
            {
                currentPage--;
                LoadData();
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                currentPage++;
                LoadData();
            }
        }

        public void Add()
        {
            var newCustomer = new Customer(); // ID will be 0 for new

            // Debug
            //MessageBox.Show($"New customer created: {newCustomer.FirstName}, {newCustomer.LastName}");

            using (var editForm = new CustomerEditForm(newCustomer))
            {
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    // Debug
                    //MessageBox.Show($"New customer data: {newCustomer.FirstName} {newCustomer.LastName}, {newCustomer.Email}");

                    context.Customers.Add(newCustomer);
                    context.SaveChanges();
                    MessageBox.Show("New customer added successfully!");
                    LoadData(true); // Refresh grid
                }
            }
        }



        public void Edit()
        {
            if (dataGridViewCustomer.SelectedRows.Count == 0) return;

            var selectedCustomer = (Customer)dataGridViewCustomer.SelectedRows[0].DataBoundItem;

            // create a copy to prevent direct editing of grid data
            var customerToEdit = new Customer
            {
                Id = selectedCustomer.Id,
                FirstName = selectedCustomer.FirstName,
                LastName = selectedCustomer.LastName,
                Afm = selectedCustomer.Afm,
                Email = selectedCustomer.Email,
                Phone = selectedCustomer.Phone,
                Address = selectedCustomer.Address,
                City = selectedCustomer.City,
                Country = selectedCustomer.Country,
                ZipCode = selectedCustomer.ZipCode
            };

            using (var editForm = new CustomerEditForm(customerToEdit))
            {
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    // update original customer with edited values
                    var editedCustomer = editForm.GetEditedCustomer();
                    context.Entry(selectedCustomer).CurrentValues.SetValues(editedCustomer);
                    context.SaveChanges();
                    RefreshGrid();
                }
            }
        }

        public void Delete()
        {
            if (dataGridViewCustomer.SelectedRows.Count == 0) return;

            var customer = (Customer)dataGridViewCustomer.SelectedRows[0].DataBoundItem;
            if (MessageBox.Show("Delete this customer?", "Confirm",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                context.Customers.Remove(customer);
                context.SaveChanges();
                RefreshGrid();
            }
        }

        public void RefreshGrid()
        {

            bindingSource.DataSource = context.Customers
                .OrderBy(x => x.Id)
                .Skip(currentPage * pageSize)
                .Take(pageSize)
                .ToList();
            dataGridViewCustomer.Refresh();
        }

    
    }

}

