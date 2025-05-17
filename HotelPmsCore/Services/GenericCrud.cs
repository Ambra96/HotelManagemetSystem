using System;
using System.Linq;
using System.Windows.Forms;
using HotelPmsCore.Services;

namespace HotelPmsCore.Services
{
 
    public abstract class GenericCrud<T> : Form where T : class, new()
    {
        private readonly CrudServices<T> service;
        private readonly BindingSource binder = new BindingSource();

        protected GenericCrud(CrudServices<T> service)
        {
            this.service = service;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            Grid.DataSource = binder;

          
            buttonNew.Click += (_, _) => OnAdd();
            buttonEdit.Click += (_, _) => OnEdit();
            buttonDelete.Click += (_, _) => OnDelete();

            RefreshGrid();
        }

        private void OnAdd()
        {
            var entity = new T();
            using (var dlg = CreateEditForm(entity))
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    service.Add(entity);
                    RefreshGrid();
                }
        }

        private void OnEdit()
        {
            if (Grid.SelectedRows.Count == 0) return;
            var orig = (T)Grid.SelectedRows[0].DataBoundItem;
            var copy = new T();
            foreach (var p in typeof(T).GetProperties().Where(x => x.CanWrite))
                p.SetValue(copy, p.GetValue(orig));

            using (var dlg = CreateEditForm(copy))
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    service.Edit(orig, copy);
                    RefreshGrid();
                }
        }

        private void OnDelete()
        {
            if (Grid.SelectedRows.Count == 0) return;
            var ent = (T)Grid.SelectedRows[0].DataBoundItem;
            if (MessageBox.Show($"Delete this {typeof(T).Name}?", "Confirm",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                service.Delete(ent);
                RefreshGrid();
            }
        }

    
        public void RefreshGrid()
        {
            binder.DataSource = service.GetAll();
        }

        protected abstract DataGridView Grid { get; }
        protected abstract Button buttonNew { get; }
        protected abstract Button buttonEdit { get; }
        protected abstract Button buttonDelete { get; }
        protected abstract Form CreateEditForm(T entity);
    }
}
