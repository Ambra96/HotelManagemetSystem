using System;
using System.Linq;
using System.Windows.Forms;
using HotelPmsCore.Models;
using HotelPmsCore.Services;

namespace HotelPmsCore.Forms
{
    public partial class CategoryForm : Form, IModule
    {
        private readonly MyBase<TypedCategory> service;
        private readonly BindingSource binder = new BindingSource();

        public bool HasSelection => dataGridViewCategory.SelectedRows.Count > 0;

        public CategoryForm(MyBase<TypedCategory> service)
        {
            InitializeComponent();
            this.service = service;

           
            dataGridViewCategory.DataSource = binder;
            LoadAll();
        }

        private void LoadAll()
        {
            binder.DataSource = service.GetAll();
        }

        public void New()
        {
            var cat = new TypedCategory();
            using var dlg = new CategoryEditForm(cat);
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                service.Add(cat);
                LoadAll();
            }
        }

        public void Edit()
        {
            if (!HasSelection) return;

            var original = (TypedCategory)binder.Current;
            var copy = new TypedCategory
            {
                Id = original.Id,
                Description = original.Description,
                Type = original.Type
            };

            using var dlg = new CategoryEditForm(copy);
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                service.Edit(original, copy);
                LoadAll();
            }
        }

        public void Delete()
        {
            if (!HasSelection) return;

            var cat = (TypedCategory)binder.Current;
       
            if (MessageBox.Show(
                    $"Delete category “{cat.Description}” of type {cat.Type}?",
                    "Confirm",
                    MessageBoxButtons.YesNo
                ) == DialogResult.Yes)
            {
                service.Delete(cat);
                LoadAll();
            }
        }

        public void RefreshGrid() => LoadAll();
    }
}
