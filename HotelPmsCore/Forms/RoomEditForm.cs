using HotelPmsCore.Models;
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
    public partial class RoomEditForm : Form
    {
        private Room _room;

        public RoomEditForm(Room room)
        {
            _room = room;
            InitializeComponent();
        }
    }
}
