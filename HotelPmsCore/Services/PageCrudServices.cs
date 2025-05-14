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
        private int pageSize = 10;
        private int currentPage = 0;
        private int totalPages = 0;

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            PrevBtn.Click += (s, ev) =>
            {
                if (currentPage > 0) currentPage--;
                LoadPage();
            };
            NextBtn.Click += (s, ev) =>
            {
                if (currentPage < totalPages) currentPage++;
                LoadPage();
            };

            // initial paged load
            LoadPage(reset: true);
        }

        private void LoadPage(bool reset = false)
        {
            if (reset) currentPage = 0;

            var set = context.Set<T>();
            var total = set.Count();
            totalPages = (int)Math.Ceiling(total / (double)pageSize) - 1;

            var items = set
                .OrderBy(x => EF.Property<object>(x, "Id"))
                .Skip(currentPage * pageSize)
                .Take(pageSize)
                .ToList();

            binding.DataSource = items;
            PrevBtn.Enabled = currentPage > 0;
            NextBtn.Enabled = currentPage < totalPages;
        }

        //public override void Add()
        //{
        //    var entity = new T();
        //    using (var dlg = CreateEditForm(entity))
        //        if (dlg.ShowDialog() == DialogResult.OK)
        //        {
        //            context.Set<T>().Add(entity);
        //            context.SaveChanges();
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
        //            context.Entry(original).CurrentValues.SetValues(copy);
        //            context.SaveChanges();
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
        //        context.Set<T>().Remove(entity);
        //        context.SaveChanges();
        //        LoadPage();
        //    }
        //}

        public override void RefreshGrid() => LoadPage();

        protected virtual Button PrevBtn { get; }
        protected virtual Button NextBtn { get; }
    }
}
