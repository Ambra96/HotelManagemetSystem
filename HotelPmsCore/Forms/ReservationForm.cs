using HotelPmsCore.Data;
using HotelPmsCore.Models;
using HotelPmsCore.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace HotelPmsCore.Forms
{
    public partial class ReservationForm : Form, IModule
    {
        private readonly HotelPmsCoreContext context;
        private List<Room> availableRooms = new();
        private List<Customer> customers = new();

        public ReservationForm(HotelPmsCoreContext context)
        {
            InitializeComponent();
            this.context = context;


            customers = context.Customers.ToList();
            comboBoxCustomer.DataSource = customers;
            comboBoxCustomer.DisplayMember = "LastName";
            comboBoxCustomer.ValueMember = "Id";
            comboBoxCustomer.SelectedIndex = -1;


            comboBoxRoom.DataSource = null;

            dateTimeFrom.ValueChanged += (s, e) => CalculateTotal();
            dateTimeTo.ValueChanged += (s, e) => CalculateTotal();
            textBoxPrice.TextChanged += (s, e) => CalculateTotal();


            dataGridView1.DataSource = context.Reservations
                .Include(r => r.Customer)
                .Include(r => r.Room)
                .ToList();
        }
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Customer" && e.Value is Customer cust)
                e.Value = cust.LastName;
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "Room" && e.Value is Room room)
                e.Value = room.RoomNumber;
        }
        private void dataGridView1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridView1.IsCurrentCellDirty)
                dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
           
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Canceled")
            {
                var reservation = dataGridView1.Rows[e.RowIndex].DataBoundItem as Reservation;
                if (reservation != null)
                {
                    context.Reservations.Update(reservation);
                    context.SaveChanges();
                    MessageBox.Show("Canceled status saved!");
                }
            }
        }



        private void BtnSearchRooms_Click(object sender, EventArgs e)
        {
            var from = dateTimeFrom.Value.Date;
            var to = dateTimeTo.Value.Date;
            int people = (int)numericCapacity.Value;

            var reservedRoomIds = context.Reservations
                .Where(r =>
                    (r.ReservationDateFrom < to && r.ReservationDateTo > from) && !r.Canceled)
                .Select(r => r.RoomId)
                .Distinct()
                .ToList();

            availableRooms = context.Rooms
                .Include(r => r.RoomType)
                .Where(r => !reservedRoomIds.Contains(r.Id) && r.PeopleCapacity >= people)
                .ToList();

            if (availableRooms.Count == 0)
            {
                MessageBox.Show("No available rooms for these dates/people.", "Info");
                comboBoxRoom.DataSource = null;
                dataGridView1.DataSource = null;
                textBoxPrice.Text = "";
                textBoxTotal.Text = "";
                return;
            }
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "RoomNumber",
                HeaderText = "Room",
                DataPropertyName = "RoomNumber"
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Floor",
                HeaderText = "Floor",
                DataPropertyName = "Floor"
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "PeopleCapacity",
                HeaderText = "Capacity",
                DataPropertyName = "PeopleCapacity"
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Price",
                HeaderText = "Price",
                DataPropertyName = "WinterPrice" 
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Price",
                HeaderText = "Summer Price",
                DataPropertyName = "SummerPrice" 
            });

            dataGridView1.DataSource = availableRooms;
            // Fill combobox with available rooms
            comboBoxRoom.DataSource = availableRooms;
            comboBoxRoom.DisplayMember = "RoomNumber";
            comboBoxRoom.ValueMember = "Id";
            comboBoxRoom.SelectedIndex = 0;
        }

        private void ComboBoxRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxRoom.SelectedItem is Room room)
            {

                var from = dateTimeFrom.Value.Date;
                var to = dateTimeTo.Value.Date;


                var period = context.Periods.FirstOrDefault(p => from >= p.StartDate && to <= p.EndDate);

                double price = room.WinterPrice;
                if (period != null)
                {
                    if (period.Name.Contains("Summer", StringComparison.OrdinalIgnoreCase))
                        price = room.SummerPrice;
                    else
                        price = room.WinterPrice;
                }
                textBoxPrice.Text = price.ToString("0.00");
                CalculateTotal();
            }
        }

        private void CalculateTotal()
        {
            if (!double.TryParse(textBoxPrice.Text, out var dayPrice)) dayPrice = 0;
            int days = Math.Max((dateTimeTo.Value.Date - dateTimeFrom.Value.Date).Days, 1);
            textBoxTotal.Text = (dayPrice * days).ToString("0.00");
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {

            if (comboBoxCustomer.SelectedItem is not Customer customer)
            {
                MessageBox.Show("Select a customer!"); return;
            }
            if (comboBoxRoom.SelectedItem is not Room room)
            {
                MessageBox.Show("Select a room!"); return;
            }

            double.TryParse(textBoxPrice.Text, out double price);

            var from = dateTimeFrom.Value.Date;
            var to = dateTimeTo.Value.Date;

            var reservation = new Reservation
            {
                CustomerId = customer.Id,
                RoomId = room.Id,
                ReservationDateFrom = from,
                ReservationDateTo = to,
                ReservationDayPrice = price,
                CheckInDate = DateTime.MinValue,
                CheckOutDate = DateTime.MinValue,
                Canceled = false
            };

            context.Reservations.Add(reservation);
            context.SaveChanges();

            MessageBox.Show("Reservation created!");
            dataGridView1.AutoGenerateColumns = true;

            var reservations = context.Reservations.Include(r => r.Customer).Include(r => r.Room).ToList();

            dataGridView1.DataSource = reservations;

            // Select the new reservation in the grid
            int rowIndex = reservations.FindIndex(r => r.Id == reservation.Id);
            if (rowIndex >= 0)
            {
                dataGridView1.ClearSelection();
                dataGridView1.Rows[rowIndex].Selected = true;
                dataGridView1.FirstDisplayedScrollingRowIndex = rowIndex;
            }
        }

        private void BtnNewCustomer_Click(object sender, EventArgs e)
        {

            using (var form = new NewCustomerForm(context))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {

                    customers = context.Customers.ToList();
                    comboBoxCustomer.DataSource = customers;
                    comboBoxCustomer.SelectedIndex = customers.Count - 1;
                }
            }
        }
        public void New() { }
        public void Edit() { }
        public void Delete() { }
        public void RefreshGrid() { }
        public bool HasSelection => false;
        public void SetCurrentIndex(int index) { }
        public void ShowFilter() { }

        private void buttonEditRes_Click(object sender, EventArgs e)
        {
            var form = Program.ServiceProvider.GetRequiredService<ReservationFormChkInOut>();
            form.ShowDialog();
       
        }
    }
}
