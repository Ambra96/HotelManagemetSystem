using System;
using System.Windows.Forms;
using HotelPmsCore.Services;
using HotelPmsCore.Models;

namespace HotelPmsCore.Forms
{
    public partial class RoomForm : Form, IModule
    {
        private readonly RoomService svc;

        public RoomForm(RoomService svc)
        {
            InitializeComponent();
            this.svc = svc;

            dataGridViewRoom.DataSource = svc.BndSource;
            dataGridViewRoom.RowEnter += (s, e) => svc.SetCurrentIndex(e.RowIndex);




            PrvBttn.Click += (_, __) => { svc.PrevPage(); UpdateNav(); };
            NxtBttn.Click += (_, __) => { svc.NextPage(); UpdateNav(); };


        }

        private void UpdateNav()
        {
            PrvBttn.Enabled = svc.CurrentPage > 0;
            NxtBttn.Enabled = svc.CurrentPage < svc.TotalPages - 1;
        }

        // IModule
        public void New() => svc.New();
        public void Edit() => svc.Edit();
        public void Delete() => svc.Delete();
        public void RefreshGrid() => svc.RefreshGrid();
        public bool HasSelection => svc.HasSelection;
        public void SetCurrentIndex(int index)
            => svc.SetCurrentIndex(index);


        public void ShowFilter()
        {
            var filterDialog = new RoomFilter();
            filterDialog.FilterValues = svc.filterValues;

            if (filterDialog.ShowDialog() == DialogResult.OK)
            {
                svc.filterValues = filterDialog.FilterValues;
                svc.ApplyFilters(svc.filterValues);
            }
            else
            {
                // Optionally, do something if canceled
            }
        }
    }
}
