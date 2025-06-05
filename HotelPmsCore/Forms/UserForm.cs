using HotelPmsCore.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelPmsCore.Forms
{
    public partial class UserForm : Form, IModule
    {
        private readonly UserService svc;


        public UserForm(UserService svc)
        {
            InitializeComponent();
            this.svc = svc;

            dataGridViewUser.DataSource = svc.BndSource;
            dataGridViewUser.RowEnter += (s, e) => SetCurrentIndex(e.RowIndex);

          
        }

     


        public void New() => svc.New();
        public void Edit() => svc.Edit();
        public void Delete() => svc.Delete();
        public void RefreshGrid() => svc.RefreshGrid();
        public bool HasSelection
            => dataGridViewUser.SelectedRows.Count > 0;

        public void SetCurrentIndex(int index)
            => svc.BndSource.Position = index;




        public void ShowFilter()
        {
            var filterDialog = new UserFilter();
            filterDialog.FilterValues = svc.filterValues;

            if (filterDialog.ShowDialog() == DialogResult.OK)
            {
                svc.filterValues = filterDialog.FilterValues;
                svc.ApplyFilters(svc.filterValues);
            }
        }

    }
}
