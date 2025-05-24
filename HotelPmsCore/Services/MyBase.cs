using System.Collections.Generic;

namespace HotelPmsCore.Services
{

    public interface MyBase<T>
        where T : class
    {
        IList<T> GetAll();
        void Add(T entity);
        void Edit(T original, T edited);
        void Delete(T entity);
    }
}
