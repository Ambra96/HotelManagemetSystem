using System;
using System.Linq;
using System.Windows.Forms;
using HotelPmsCore.Models;
using HotelPmsCore.Services;

namespace HotelPmsCore.Forms
{
    public partial class CustomerForm : Form, IModule
    {
        private readonly CustomerService svc;

        public CustomerForm(CustomerService svc)
        {
            InitializeComponent();
            this.svc = svc;

            // 1) bind the grid
            dataGridViewCustomer.DataSource = svc.BndSource;

            // 2) wire paging buttons
            PrvButton.Click += (_, __) => { svc.PrevPage(); UpdateNav(); };
            NxtButton.Click += (_, __) => { svc.NextPage(); UpdateNav(); };

            // 3) initial enable/disable
            UpdateNav();
        }

        private void UpdateNav()
        {
            PrvButton.Enabled = svc.BndSource.Position > 0;
            NxtButton.Enabled = svc.BndSource.Position < svc.TotalPages - 1;
        }


        public bool HasSelection
            => dataGridViewCustomer.SelectedRows.Count > 0;

        public void New()
        {
            var c = new Customer();
            using var dlg = new CustomerEditForm(c);
            if (dlg.ShowDialog() == DialogResult.OK)
                svc.Add(c);
        }

        public void Edit()
        {
            if (!HasSelection) return;

            var orig = (Customer)svc.BndSource.Current;
            var copy = new Customer();
            foreach (var p in typeof(Customer).GetProperties().Where(p => p.CanWrite))
                p.SetValue(copy, p.GetValue(orig));

            using var dlg = new CustomerEditForm(copy);
            if (dlg.ShowDialog() == DialogResult.OK)
                svc.Edit(orig, copy);
        }

        public void Delete()
        {
            if (!HasSelection) return;

            var c = (Customer)svc.BndSource.Current;
            if (MessageBox.Show(
                    $"Delete {c.FirstName} {c.LastName}?",
                    "Confirm", MessageBoxButtons.YesNo
                ) == DialogResult.Yes)
            {
                svc.Delete(c);
            }
        }

        public void RefreshGrid()
            => svc.PrevPage();

        private void PrvButton_Click(object sender, EventArgs e)
        {

        }

        private void NxtButton_Click(object sender, EventArgs e)
        {

        }
    }
}
