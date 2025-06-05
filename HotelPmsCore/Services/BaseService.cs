using HotelPmsCore.Data;
using HotelPmsCore.Forms;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace HotelPmsCore.Services
{

    public abstract class BaseService<TListForm, TEditForm, TEntity> : IModule
        where TListForm : Form
        where TEditForm : Form
        where TEntity : class, new()
    {
        protected readonly HotelPmsCoreContext context;
        protected readonly List<TEntity> all = new List<TEntity>();
        private int currentPageIndex;
        internal Dictionary<string, object> filterValues = new();


        public BindingSource BndSource { get; } = new BindingSource();
        public int PageSize { get; set; } = 10;
        public int CurrentPage => currentPageIndex;
        public int TotalPages
            => (int)Math.Ceiling(all.Count / (double)PageSize);

        protected BaseService(HotelPmsCoreContext context)
        {
            this.context = context;
            LoadAll();
            LoadPage(0);
        }

        protected void LoadAll()
        {
            all.Clear();
            all.AddRange(context.Set<TEntity>()
                                .AsNoTracking()
                                .OrderBy(x => EF.Property<object>(x, "Id"))
                                .ToList());
        }


        protected void LoadPage(int pageIndex)
        {
            currentPageIndex = pageIndex;

            var slice = all
                .Skip(pageIndex * PageSize)
                .Take(PageSize)
                .ToList();

            BndSource.DataSource = new BindingList<TEntity>(slice);
        }

        public virtual void New()
        {

            var entity = new TEntity();

            var dlg = Program.ServiceProvider.GetRequiredService<TEditForm>();
            if (dlg.ShowDialog() != DialogResult.OK)
                return;

            context.Set<TEntity>().Add(entity);
            context.SaveChanges();

            ReloadAndNavigateByKey(entity);
        }

        public virtual void Edit()
        {
            if (!HasSelection) return;

            var original = (TEntity)BndSource.Current;
            var copy = new TEntity();
            foreach (var p in typeof(TEntity).GetProperties().Where(p => p.CanWrite))
                p.SetValue(copy, p.GetValue(original));


            BndSource.DataSource = new BindingList<TEntity>(new[] { copy });
            BndSource.Position = 0;

            var dlg = Program.ServiceProvider.GetRequiredService<TEditForm>();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                context.Entry(original).CurrentValues.SetValues(copy);
                context.SaveChanges();
                ReloadAndNavigateByKey(original);
            }
            else
            {
                ReloadAndNavigateByKey(original);
            }
        }

        public virtual void Delete()
        {
            if (!HasSelection) return;

            var entity = (TEntity)BndSource.Current;
            if (MessageBox.Show($"Delete this {typeof(TEntity).Name}?",
                    "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                context.Set<TEntity>().Remove(entity);
                context.SaveChanges();


                var keyVal = GetKey(entity);
                all.RemoveAll(e => GetKey(e)?.Equals(keyVal) == true);

                ReloadAndNavigateByKey(null);
            }
        }

        public virtual void RefreshGrid()
        {
            LoadPage(currentPageIndex);
        }

        public bool HasSelection
            => BndSource.Position >= 0;

        public void SetCurrentIndex(int index)
            => BndSource.Position = index;


        protected void ReloadAndNavigateByKey(TEntity? target)
        {
            LoadAll();
            if (target != null)
            {
                var keyVal = GetKey(target);
                var idx = all.FindIndex(e => GetKey(e)?.Equals(keyVal) == true);
                if (idx >= 0)
                {
                    var pg = idx / PageSize;
                    LoadPage(pg);
                    BndSource.Position = idx % PageSize;
                    return;
                }
            }

            LoadPage(currentPageIndex);
        }

        public void ShowFilter()
        {

        }


        protected virtual object? GetKey(TEntity entity)
        {
            return typeof(TEntity)
                .GetProperty("Id", BindingFlags.Public | BindingFlags.Instance)
                ?.GetValue(entity);
        }
    }
}

