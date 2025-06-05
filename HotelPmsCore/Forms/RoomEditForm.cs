using System;
using System.Windows.Forms;
using HotelPmsCore.Models;
using HotelPmsCore.Services;

namespace HotelPmsCore.Forms
{
    public partial class RoomEditForm : Form
    {
        public RoomEditForm(RoomService service)
        {
            InitializeComponent();


            roomBindingSource.DataSource = service.BndSource;


            txtRoomNumber.DataBindings.Add("Text", roomBindingSource, nameof(Room.RoomNumber), true, DataSourceUpdateMode.OnPropertyChanged);
            txtFloor.DataBindings.Add("Text", roomBindingSource, nameof(Room.Floor), true, DataSourceUpdateMode.OnPropertyChanged);
            numWinter.DataBindings.Add("Value", roomBindingSource, nameof(Room.WinterPrice), true, DataSourceUpdateMode.OnPropertyChanged);
            numSummer.DataBindings.Add("Value", roomBindingSource, nameof(Room.SummerPrice), true, DataSourceUpdateMode.OnPropertyChanged);
            numCapacity.DataBindings.Add("Value", roomBindingSource, nameof(Room.PeopleCapacity), true, DataSourceUpdateMode.OnPropertyChanged);
           

            SaveBttn.Click += (_, __) => DialogResult = DialogResult.OK;
            CancelBttn.Click += (_, __) => DialogResult = DialogResult.Cancel;
        }

      
    }
}


