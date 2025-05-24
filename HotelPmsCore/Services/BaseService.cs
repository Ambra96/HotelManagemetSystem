using HotelPmsCore.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace HotelPmsCore.Services
{
   
    public abstract class BaseService<TListForm, TEditForm, TEntity> : IModule
        where TListForm : Form
        where TEditForm : Form
        where TEntity : class, new()
    {
        protected readonly HotelPmsCoreContext context;

        public BindingSource BndSource { get; } = new BindingSource();

        protected List<TEntity> cache = new();
        //protected int pageSize = 10;
        //protected int currentIndex;

        protected BaseService(HotelPmsCoreContext ctx)
        {
            context = ctx;
        }

      
        protected void SetCurrentTable(IQueryable<TEntity> query)
        {
            cache = query
                .OrderBy(x => EF.Property<object>(x, "Id"))
                .ToList();
            BndSource.DataSource = new BindingList<TEntity>(cache);
        }

        

        public virtual void New()
        {
            var entity = new TEntity();
            cache.Insert(0, entity);
            BndSource.DataSource = new BindingList<TEntity>(cache);
            BndSource.Position = 0;

            var dlg = Program.ServiceProvider.GetRequiredService<TEditForm>();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                context.Set<TEntity>().Add(entity);
                context.SaveChanges();
            }
            else
            {
                cache.RemoveAt(0);
                BndSource.DataSource = new BindingList<TEntity>(cache);
            }
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
            }

         
            BndSource.DataSource = new BindingList<TEntity>(cache);
        }

        public virtual void Delete()
        {
            if (!HasSelection) return;

            var entity = (TEntity)BndSource.Current;
            if (MessageBox.Show(
                    $"Delete this {typeof(TEntity).Name}?",
                    "Confirm",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                context.Set<TEntity>().Remove(entity);
                context.SaveChanges();
                cache.Remove(entity);
                BndSource.DataSource = new BindingList<TEntity>(cache);
            }
        }

        public virtual void RefreshGrid()
            => BndSource.ResetBindings(false);

        public bool HasSelection => BndSource.Position >= 0;

        public void SetCurrentIndex(int index)
            => BndSource.Position = index;
    }
}
