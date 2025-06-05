using HotelPmsCore.Forms;
using HotelPmsCore.Services;
using System;
using System.Windows.Forms;

namespace HotelPmsCore.Forms
{
    public partial class CustomerForm : Form, IModule
    {
        private readonly CustomerService svc;

        public CustomerForm(CustomerService svc)
        {
            InitializeComponent();
            this.svc = svc;

            dataGridViewCustomer.DataSource = svc.BndSource;
            dataGridViewCustomer.RowEnter += (s, e) => SetCurrentIndex(e.RowIndex);

            PrvButton.Click += PrvButton_Click;
            NxtButton.Click += NxtButton_Click;

            UpdateNav();
        }

        private void PrvButton_Click(object sender, EventArgs e)
        {
            svc.PrevPage();
            UpdateNav();
        }

        private void NxtButton_Click(object sender, EventArgs e)
        {
            svc.NextPage();
            UpdateNav();
        }


        private void UpdateNav()
        {
            PrvButton.Enabled = svc.CurrentPage > 0;
            NxtButton.Enabled = svc.CurrentPage < svc.TotalPages - 1;
        }



        public void New() => svc.New();
        public void Edit() => svc.Edit();
        public void Delete() => svc.Delete();
        public void RefreshGrid() => svc.RefreshGrid();
        public bool HasSelection
            => dataGridViewCustomer.SelectedRows.Count > 0;

        public void SetCurrentIndex(int index)
            => svc.BndSource.Position = index;

        public void ShowFilter()
        {
            var filterDialog = new CustomerFilter();
            filterDialog.FilterValues = svc.filterValues;

            if (filterDialog.ShowDialog() == DialogResult.OK)
            {
                svc.filterValues = filterDialog.FilterValues;
                svc.ApplyFilters(svc.filterValues); 
            }
        }


    }
}

