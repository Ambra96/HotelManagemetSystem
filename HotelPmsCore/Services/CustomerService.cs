using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using HotelPmsCore.Models;

namespace HotelPmsCore.Services
{
   
    public class CustomerService
    {
        private readonly MyBase<Customer> crud;
        private List<Customer> cache;
        private int currentPage;

        public BindingSource BndSource { get; }
        public int PageSize { get; } = 10;
        public int TotalPages => (int)Math.Ceiling(cache.Count / (double)PageSize);

        public CustomerService(MyBase<Customer> crud)
        {
            this.crud = crud;
            cache = crud.GetAll().ToList();
            BndSource = new BindingSource();
            LoadPage(0);
        }

        private void LoadPage(int page)
        {
            currentPage = page;
            var slice = cache
                .Skip(page * PageSize)
                .Take(PageSize)
                .ToList();
            BndSource.DataSource = new BindingList<Customer>(slice);
        }

        public void NextPage()
        {
            if (currentPage < TotalPages - 1)
                LoadPage(currentPage + 1);
        }

        public void PrevPage()
        {
            if (currentPage > 0)
                LoadPage(currentPage - 1);
        }

        public void Add(Customer c)
        {
            crud.Add(c);
            RefreshAll();
            LoadPage(0);
        }

        public void Edit(Customer orig, Customer edited)
        {
            crud.Edit(orig, edited);
            RefreshAll();
            LoadPage(currentPage);
        }

        public void Delete(Customer c)
        {
            crud.Delete(c);
            RefreshAll();
            if (currentPage >= TotalPages)
                currentPage = Math.Max(0, TotalPages - 1);
            LoadPage(currentPage);
        }

        private void RefreshAll()
        {
            cache = crud.GetAll().ToList();
        }
    }
}
