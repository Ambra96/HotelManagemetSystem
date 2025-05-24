using System.Windows.Forms;
using HotelPmsCore.Services;

namespace HotelPmsCore.Forms
{
    public partial class CategoryForm : Form, IModule
    {
        private readonly CategoryServices svc;

        public CategoryForm(CategoryServices svc)
        {
            InitializeComponent();
            this.svc = svc;

            
            dataGridViewCategory.DataSource = svc.BndSource;

            
            dataGridViewCategory.RowEnter += (s, e) => SetCurrentIndex(e.RowIndex);
        }

        
        public void New() => svc.New();
        public void Edit() => svc.Edit();
        public void Delete() => svc.Delete();
        public void RefreshGrid() => svc.RefreshGrid();
        public bool HasSelection
            => dataGridViewCategory.SelectedRows.Count > 0;

        public void SetCurrentIndex(int index)
            => svc.BndSource.Position = index;
    }
}
