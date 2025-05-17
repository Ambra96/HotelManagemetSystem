//using System;
//using System.Collections.Generic;
//using System.Linq;
//using HotelPmsCore.Data;
//using Microsoft.EntityFrameworkCore;

//namespace HotelPmsCore.Services
//{

//    public class PageCrudServices<T> : CrudServices<T> where T : class, new()
//    {
//        public PageCrudServices(HotelPmsCoreContext context)
//            : base(context)
//        {
//        }

   
//        public IList<T> GetPage(int pageIndex, int pageSize)
//        {
//            return context.Set<T>()
//                .OrderBy(x => EF.Property<object>(x, "Id"))
//                .Skip(pageIndex * pageSize)
//                .Take(pageSize)
//                .ToList();
//        }


//        public int GetTotalPages(int pageSize)
//        {
//            var total = context.Set<T>().Count();
//            return (int)Math.Ceiling(total / (double)pageSize);
//        }
//    }
//}
