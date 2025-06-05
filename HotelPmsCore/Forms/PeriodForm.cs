using System.Windows.Forms;
using HotelPmsCore.Services;

namespace HotelPmsCore.Forms
{
    public partial class PeriodForm : Form, IModule
    {
        private readonly PeriodService svc;

        public PeriodForm(PeriodService svc)
        {
            InitializeComponent();
            this.svc = svc;
            dataGridViewPeriod.DataSource = svc.BndSource;
            dataGridViewPeriod.RowEnter += (s, e) => SetCurrentIndex(e.RowIndex);
        }

        public void New() => svc.New();
        public void Edit() => svc.Edit();
        public void Delete() => svc.Delete();
        public void RefreshGrid() => svc.RefreshGrid();
        public bool HasSelection => dataGridViewPeriod.SelectedRows.Count > 0;
        public void SetCurrentIndex(int index) => svc.BndSource.Position = index;

        public void ShowFilter()
        {
            var filterDialog = new PeriodFilter();
            filterDialog.FilterValues = svc.FilterValues;

            if (filterDialog.ShowDialog() == DialogResult.OK)
            {
                svc.FilterValues = filterDialog.FilterValues;
                svc.ApplyFilters(svc.FilterValues);
            }
        }
    }
}
