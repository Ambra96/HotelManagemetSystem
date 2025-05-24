using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using HotelPmsCore.Models;
using HotelPmsCore.Services;

namespace HotelPmsCore.Forms
{
    public partial class RoomForm : Form, IModule
    {
        private readonly MyBase<Room> service;
        private readonly BindingSource binder = new BindingSource();
        private IList<Room> allRooms;

        private const int PageSize = 10;
        private int currentPage=0;
        private int totalPages = 0;

        public bool HasSelection => dataGridViewRoom.SelectedRows.Count > 0;

        public RoomForm(MyBase<Room> service)
        {
            InitializeComponent();

            this.service = service;
            dataGridViewRoom.DataSource = binder;

            allRooms = service.GetAll();
            totalPages = (int)Math.Ceiling(allRooms.Count / (double)PageSize);

            LoadPage(0);
        }

        private void LoadPage(int pageIndex)
        {
            currentPage = pageIndex;
            var page = allRooms
                .Skip(pageIndex * PageSize)
                .Take(PageSize)
                .ToList();

            binder.DataSource = page;

            PrvBttn.Enabled = pageIndex > 0;
            NxtBttn.Enabled = pageIndex < totalPages - 1;
        }

        public void New()
        {
            var room = new Room();
            using var dlg = new RoomEditForm(room);
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                service.Add(room);
                RefreshDataAndPage(0);
            }
        }

        public void Edit()
        {
            if (!HasSelection) return;

            var original = (Room)binder.Current;
            var copy = new Room { Id = original.Id };
            foreach (var p in typeof(Room).GetProperties().Where(p => p.CanWrite))
                p.SetValue(copy, p.GetValue(original));

            using var dlg = new RoomEditForm(copy);
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                service.Edit(original, copy);
                RefreshDataAndPage(currentPage);
            }
        }

        public void Delete()
        {
            if (!HasSelection) return;

            var room = (Room)binder.Current;
            if (MessageBox.Show(
                    $"Delete room {room.RoomNumber}?",
                    "Confirm", MessageBoxButtons.YesNo)
                == DialogResult.Yes)
            {
                service.Delete(room);
                allRooms = service.GetAll();
                totalPages = (int)Math.Ceiling(allRooms.Count / (double)PageSize);
                if (currentPage >= totalPages)
                    currentPage = Math.Max(0, totalPages - 1);
                LoadPage(currentPage);
            }
        }

        public void RefreshGrid() => LoadPage(currentPage);

        private void RefreshDataAndPage(int pageIndex)
        {
            allRooms = service.GetAll();
            totalPages = (int)Math.Ceiling(allRooms.Count / (double)PageSize);
            LoadPage(pageIndex);
        }

        private void PreviousButton_Click(object sender, EventArgs e)
            => LoadPage(currentPage - 1);

        private void NextButton_Click(object sender, EventArgs e)
            => LoadPage(currentPage + 1);

        
    }
}
