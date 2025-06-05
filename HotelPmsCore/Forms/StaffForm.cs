using System;
using System.Windows.Forms;
using HotelPmsCore.Services;

namespace HotelPmsCore.Forms
{
    public partial class StaffForm : Form, IModule
    {
        private readonly StaffService svc;

        public StaffForm(StaffService svc)
        {
            InitializeComponent();
            this.svc = svc;

            dataGridView1.DataSource = svc.BndSource;
            dataGridView1.RowEnter += (s, e) => SetCurrentIndex(e.RowIndex);

            
        }


        public void New() => svc.New();
        public void Edit() => svc.Edit();
        public void Delete() => svc.Delete();
        public void RefreshGrid() => svc.RefreshGrid();
        public bool HasSelection
            => dataGridView1.SelectedRows.Count > 0;

        public void SetCurrentIndex(int index)
            => svc.BndSource.Position = index;

        public void ShowFilter()
        {
            var filterDialog = new StaffFilter();
            filterDialog.FilterValues = svc.filterValues;

            if (filterDialog.ShowDialog() == DialogResult.OK)
            {
                svc.filterValues = filterDialog.FilterValues;
                svc.ApplyFilters(svc.filterValues);
            }
        }

    }
}
