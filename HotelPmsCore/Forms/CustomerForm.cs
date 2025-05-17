using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using HotelPmsCore.Models;
using HotelPmsCore.Services;

namespace HotelPmsCore.Forms
{
    public partial class CustomerForm : Form, IModule
    {
        private readonly MyBase<Customer> service;
        private readonly BindingSource binder = new BindingSource();
        private IList<Customer> allCustomers;

        private const int PageSize = 10;
        private int currentPage = 0;
        private int totalPages = 0;

        public bool HasSelection => dataGridViewCustomer.SelectedRows.Count > 0;

        public CustomerForm(MyBase<Customer> service)
        {
            InitializeComponent();

            this.service = service;
            dataGridViewCustomer.DataSource = binder;

            // load all data
            allCustomers = service.GetAll();
            totalPages = (int)Math.Ceiling(allCustomers.Count / (double)PageSize);

            // show the first page
            LoadPage(0);
        }

        private void LoadPage(int pageIndex)
        {
            currentPage = pageIndex;
            var page = allCustomers
                .Skip(pageIndex * PageSize)
                .Take(PageSize)
                .ToList();

            binder.DataSource = page;

            PreviousButton.Enabled = pageIndex > 0;
            NextButton.Enabled = pageIndex < totalPages - 1;
        }

        // ICrudModule methods:

        public void New()
        {
            var cust = new Customer();
            using var dlg = new CustomerEditForm(cust);
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                service.Add(cust);
                RefreshDataAndPage(0);
            }
        }

        public void Edit()
        {
            if (!HasSelection) return;

            var original = (Customer)binder.Current;
            var copy = new Customer { Id = original.Id };
            foreach (var p in typeof(Customer).GetProperties().Where(p => p.CanWrite))
                p.SetValue(copy, p.GetValue(original));

            using var dlg = new CustomerEditForm(copy);
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                service.Edit(original, copy);
                RefreshDataAndPage(currentPage);
            }
        }

        public void Delete()
        {
            if (!HasSelection) return;

            var cust = (Customer)binder.Current;
            if (MessageBox.Show(
                    $"Delete {cust.FirstName} {cust.LastName}?",
                    "Confirm", MessageBoxButtons.YesNo)
                == DialogResult.Yes)
            {
                service.Delete(cust);
                // refresh all and ensure currentPage valid
                allCustomers = service.GetAll();
                totalPages = (int)Math.Ceiling(allCustomers.Count / (double)PageSize);
                if (currentPage >= totalPages)
                    currentPage = Math.Max(0, totalPages - 1);
                LoadPage(currentPage);
            }
        }

        public void RefreshGrid() => LoadPage(currentPage);


        private void RefreshDataAndPage(int pageIndex)
        {
            allCustomers = service.GetAll();
            totalPages = (int)Math.Ceiling(allCustomers.Count / (double)PageSize);
            LoadPage(pageIndex);
        }


        private void PreviousButton_Click(object sender, EventArgs e)
            => LoadPage(currentPage - 1);

        private void NextButton_Click(object sender, EventArgs e)
            => LoadPage(currentPage + 1);

        
    }
}
