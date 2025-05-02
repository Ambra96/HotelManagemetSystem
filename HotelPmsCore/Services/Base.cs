using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelPmsCore.Services
{
    public class Base<B> where B : class, new()
    {
        protected BindingSource bindingSource = new();


        public Base()
        {
            initializeButtons();
        }
        private void initializeButtons()
        {
        

        }

        public void Add()
        {
            bindingSource.Add(new B());
        }

        //public void Edit()
        //{
            //if (bindingSource.Current != null)
            //{
             //   var selectedItem = bindingSource.Current as B;
             //   MessageBox.Show($"Editing{typeof(B).Name}: {selectedItem}");
                //edit form ??

            //}
       // }

        public void Delete()
        {
        }
    }
}