using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using HotelPmsCore.Data;

namespace HotelPmsCore.Services
{
 
    public class PageCrudServices<T> : CrudServices<T>
        where T : class, new()
    {
        private int _pageSize = 10;
        private int _currentPage = 0;
        private int _totalPages = 0;

        protected PageCrudServices() { }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);


            PrevBtn.Click += (s, ev) =>
            {
                if (_currentPage > 0) _currentPage--;
                LoadPage();
            };
            NextBtn.Click += (s, ev) =>
            {
                if (_currentPage < _totalPages) _currentPage++;
                LoadPage();
            };

            // initial paged load
            LoadPage(reset: true);
        }

        private void LoadPage(bool reset = false)
        {
            if (reset) _currentPage = 0;

            var set = _context.Set<T>();
            var total = set.Count();
            _totalPages = (int)Math.Ceiling(total / (double)_pageSize) - 1;

            var items = set
                .OrderBy(x => EF.Property<object>(x, "Id"))
                .Skip(_currentPage * _pageSize)
                .Take(_pageSize)
                .ToList();

            _binding.DataSource = items;
            PrevBtn.Enabled = _currentPage > 0;
            NextBtn.Enabled = _currentPage < _totalPages;
        }

        //public override void Add()
        //{
        //    var entity = new T();
        //    using (var dlg = CreateEditForm(entity))
        //        if (dlg.ShowDialog() == DialogResult.OK)
        //        {
        //            _context.Set<T>().Add(entity);
        //            _context.SaveChanges();
        //            LoadPage(reset: true);
        //        }
        //}

        //public override void Edit()
        //{
        //    if (!HasSelection) return;
        //    var original = (T)Grid.SelectedRows[0].DataBoundItem;
        //    var copy = new T();
        //    foreach (var p in typeof(T).GetProperties().Where(p => p.CanWrite))
        //        p.SetValue(copy, p.GetValue(original));

        //    using (var dlg = CreateEditForm(copy))
        //        if (dlg.ShowDialog() == DialogResult.OK)
        //        {
        //            _context.Entry(original).CurrentValues.SetValues(copy);
        //            _context.SaveChanges();
        //            LoadPage();
        //        }
        //}

        //public override void Delete()
        //{
        //    if (!HasSelection) return;
        //    var entity = (T)Grid.SelectedRows[0].DataBoundItem;
        //    if (MessageBox.Show($"Delete this {typeof(T).Name}?", "Confirm",
        //            MessageBoxButtons.YesNo) == DialogResult.Yes)
        //    {
        //        _context.Set<T>().Remove(entity);
        //        _context.SaveChanges();
        //        LoadPage();
        //    }
        //}

        public override void RefreshGrid() => LoadPage();

      
        protected virtual Button PrevBtn { get; }
        protected virtual Button NextBtn { get; }
    }
}
