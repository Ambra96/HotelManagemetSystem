using HotelPmsCore.Data;
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
    public partial class RoomForm : Form
    {
        private HotelPmsCoreContext context;
        private BindingSource bindingSource = new();
        private int pageSize = 10;  // Number of records per page
        private int currentPage = 0; // Current page index
        private int totalRecords = 0; // Total records in the database
        private int totalPages = 0;  // Total number of pages

        public RoomForm()
        {
            InitializeComponent();
            context = new HotelPmsCoreContext();
            LoadData();
        }


        private void LoadData()
        {
            totalRecords = context.Rooms.Count(); //total recordscount
            totalPages = (int)Math.Floor((double)totalRecords / pageSize);  //calc total pages
            //var rooms = context.Rooms.OrderBy(x => x.Id).Skip(currentPage * pageSize).Take(pageSize).ToList(); //it brings rooms for curr page
            //bindingSource.DataSource = rooms;
            dataGridViewRoom.DataSource = bindingSource;
            //UpdateButtonStates();
        }  
        
    } 
}
