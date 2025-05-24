using System.Collections.Generic;
using System.Linq;
using HotelPmsCore.Data;
using Microsoft.EntityFrameworkCore;

namespace HotelPmsCore.Services
{
  
    public interface MyBase<T> where T : class
    {
        IList<T> GetAll();
        void Add(T entity);
        void Edit(T original, T edited);
        void Delete(T entity);
    }

    public class CrudServices<T> : MyBase<T>
        where T : class, new()
    {
        protected readonly HotelPmsCoreContext context;

        public CrudServices(HotelPmsCoreContext context)
        {
            this.context = context;
        }

        public IList<T> GetAll()
            => context.Set<T>()
                      .OrderBy(x => EF.Property<object>(x, "Id"))
                      .ToList();

        public void Add(T entity)
        {
            context.Set<T>().Add(entity);
            context.SaveChanges();
        }

        public void Edit(T original, T edited)
        {
            context.Entry(original)
                   .CurrentValues
                   .SetValues(edited);
            context.SaveChanges();
        }

        public void Delete(T entity)
        {
            context.Set<T>().Remove(entity);
            context.SaveChanges();
        }
    }
}
