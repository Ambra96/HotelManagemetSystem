using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using HotelPmsCore.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace HotelPmsCore.Services
{
    public abstract class PagedService<TListForm, TEditForm, TEntity> : IModule
        where TListForm : Form
        where TEditForm : Form
        where TEntity : class, new()
    {
        protected readonly HotelPmsCoreContext context;
        private List<TEntity> all;
        private int currentPageIndex;

        public BindingSource BndSource { get; } = new();
        public int PageSize { get; set; } = 10;

        public int TotalPages
            => (int)Math.Ceiling(all.Count / (double)PageSize);

        public int CurrentPage => currentPageIndex;

        protected PagedService(HotelPmsCoreContext context)
        {
            this.context = context;
            LoadAll();       
            LoadPage(0);
        }

       
        private void LoadAll()
        {
            all = context.Set<TEntity>()
                         .OrderBy(x => EF.Property<object>(x, "Id"))
                         .ToList();
        }

    
        private void LoadPage(int page)
        {
            currentPageIndex = page;
            var slice = all
                .Skip(page * PageSize)
                .Take(PageSize)
                .ToList();

            BndSource.DataSource = new BindingList<TEntity>(slice);
        }

        public void PrevPage()
        {
            if (currentPageIndex > 0)
                LoadPage(currentPageIndex - 1);
        }

        public void NextPage()
        {
            if (currentPageIndex < TotalPages - 1)
                LoadPage(currentPageIndex + 1);
        }

        public virtual void New()
        {
            var entity = new TEntity();
            all.Insert(0, entity);
            LoadPage(0);
            BndSource.Position = 0;

            var dlg = Program.ServiceProvider.GetRequiredService<TEditForm>();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                context.Set<TEntity>().Add(entity);
                context.SaveChanges();
                ReloadAndNavigate(entity);
            }
            else
            {
                all.RemoveAt(0);
                ReloadAndNavigate(null);
            }
        }

        public virtual void Edit()
        {
            if (!HasSelection) return;

            var original = (TEntity)BndSource.Current;
            var copy = new TEntity();
            foreach (var p in typeof(TEntity).GetProperties().Where(p => p.CanWrite))
                p.SetValue(copy, p.GetValue(original));

            // bind only the copy
            BndSource.DataSource = new BindingList<TEntity>(new[] { copy });
            BndSource.Position = 0;

            var dlg = Program.ServiceProvider.GetRequiredService<TEditForm>();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                context.Entry(original).CurrentValues.SetValues(copy);
                context.SaveChanges();
                ReloadAndNavigate(original);
            }
            else
            {
                ReloadAndNavigate(original);
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
                all.Remove(entity);
                ReloadAndNavigate(null);
            }
        }

        public virtual void RefreshGrid()
            => LoadPage(currentPageIndex);

        public bool HasSelection
            => BndSource.Position >= 0;

        public void SetCurrentIndex(int index)
            => BndSource.Position = index;

        private void ReloadAndNavigate(TEntity? target)
        {
            LoadAll();
            if (target != null)
            {
                var idx = all.IndexOf(target);
                if (idx >= 0)
                {
                    var page = idx / PageSize;
                    LoadPage(page);
                    BndSource.Position = idx % PageSize;
                    return;
                }
            }
            LoadPage(currentPageIndex);
        }
    }
}
