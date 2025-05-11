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

        protected readonly HotelPmsCoreContext _context = new();
        protected readonly BindingSource _binding = new();

       
        public virtual bool HasSelection => Grid.SelectedRows.Count > 0;

    
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Grid.DataSource = _binding;
            LoadAll();
        }

        private void LoadAll()
        {
            var items = _context.Set<T>()
                .OrderBy(x => EF.Property<object>(x, "Id"))
                .ToList();
            _binding.DataSource = items;
        }

        public virtual void Add()
        {
            var entity = new T();
            using (var dlg = CreateEditForm(entity))
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    _context.Set<T>().Add(entity);
                    _context.SaveChanges();
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
                    _context.Entry(original).CurrentValues.SetValues(copy);
                    _context.SaveChanges();
                    LoadAll();
                }
        }

        public virtual void Delete()
        {
            if (!HasSelection) return;
            var entity = (T)Grid.SelectedRows[0].DataBoundItem;
            if (MessageBox.Show($"Delete this {typeof(T).Name}?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _context.Set<T>().Remove(entity);
                _context.SaveChanges();
                LoadAll();
            }
        }

        public virtual void RefreshGrid() => LoadAll();

        protected virtual DataGridView Grid
            => throw new NotImplementedException("Override Grid in your derived form");

        protected virtual Form CreateEditForm(T entity)
            => throw new NotImplementedException("Override CreateEditForm in your derived form");
    }
}
