using System.Windows.Forms;
using HotelPmsCore.Services;

namespace HotelPmsCore.Forms
{
    public partial class CategoryForm : Form, IModule
    {
        private readonly CategoryService svc;
        public CategoryForm(CategoryService svc)
        {
            InitializeComponent();
            this.svc = svc;
            dataGridViewCategory.DataSource = svc.BndSource;
            svc.RefreshGrid();
        }

        public void New() { svc.New(); svc.RefreshGrid(); }
        public void Edit() { svc.Edit(); svc.RefreshGrid(); }
        public void Delete() { svc.Delete(); svc.RefreshGrid(); }
        public void RefreshGrid() => svc.RefreshGrid();
        public bool HasSelection => dataGridViewCategory.SelectedRows.Count > 0;
        public void SetCurrentIndex(int index) => svc.BndSource.Position = index;

        public void ShowFilter()
        {
            var filterDialog = new CategoryFilter();
            filterDialog.FilterValues = svc.filterValues;

            if (filterDialog.ShowDialog() == DialogResult.OK)
            {
       
                if (filterDialog.FilterValues.Count == 0)
                {
                    svc.filterValues.Clear();
                    svc.RefreshGrid();
                }
                else
                {
                    svc.filterValues = filterDialog.FilterValues;
                    svc.ApplyFilters(svc.filterValues);
                }
            }
        }

    }
}

