using System;
using System.Windows.Forms;
using HotelPmsCore.Models;
using HotelPmsCore.Services;

namespace HotelPmsCore.Forms
{
    public partial class CategoryForm : Form, IModule
    {
        private readonly CategoryService service;

        public CategoryForm(CategoryService service)
        {
            InitializeComponent();
            this.service = service;

            
            dataGridViewCategory.DataSource = service.BndSource;
            dataGridViewCategory.RowEnter += (s, e)
                => service.SetCurrentIndex(e.RowIndex);
        }

        // IModule
        public void New() => service.New();
        public void Edit() => service.Edit();
        public void Delete() => service.Delete();
        public void RefreshGrid() => service.RefreshGrid();
        public bool HasSelection => service.HasSelection;
        public void SetCurrentIndex(int idx)
            => service.SetCurrentIndex(idx);
    }
}
