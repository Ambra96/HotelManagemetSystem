using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using HotelPmsCore.Data;

namespace HotelPmsCore.Services
{
    public class CrudServices<T> : Form, MyBase
        where T : class, new()
    {
        protected readonly HotelPmsCoreContext context = new();
        protected readonly BindingSource binding = new();

        public virtual bool HasSelection => Grid.SelectedRows.Count > 0;

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Grid.DataSource = binding;
            LoadAll();
        }

        private void LoadAll()
        {
            var items = context.Set<T>()
                .OrderBy(x => EF.Property<object>(x, "Id"))
                .ToList();
            binding.DataSource = items;
        }

        public virtual void Add()
        {
            var entity = new T();
            using (var dlg = CreateEditForm(entity))
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    context.Set<T>().Add(entity);
                    context.SaveChanges();
                    LoadAll();
                }
        }

        public virtual void Edit()
        {
            if (!HasSelection) return;
            var original = (T)Grid.SelectedRows[0].DataBoundItem;
            var copy = new T();
            foreach (var p in typeof(T).GetProperties().Where(p => p.CanWrite))
                p.SetValue(copy, p.GetValue(original));

            using (var dlg = CreateEditForm(copy))
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    context.Entry(original).CurrentValues.SetValues(copy);
                    context.SaveChanges();
                    LoadAll();
                }
        }

        public virtual void Delete()
        {
            if (!HasSelection) return;
            var entity = (T)Grid.SelectedRows[0].DataBoundItem;
            if (MessageBox.Show($"Delete this {typeof(T).Name}?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                context.Set<T>().Remove(entity);
                context.SaveChanges();
                LoadAll();
            }
        }

        public virtual void RefreshGrid() => LoadAll();

        protected virtual DataGridView Grid
            => throw new NotImplementedException("Override Grid ");

        protected virtual Form CreateEditForm(T entity)
            => throw new NotImplementedException("Override CreateEditForm ");
    }
}
