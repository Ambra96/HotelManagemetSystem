using HotelPmsCore.Data;
using HotelPmsCore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace HotelPmsCore.Forms
{
    public partial class ReservationFormChkInOut : Form
    {
        private readonly HotelPmsCoreContext context;
        private Reservation? currentReservation = null;

        public ReservationFormChkInOut(HotelPmsCoreContext context)
        {
            InitializeComponent();
            this.context = context;

            comboBoxCustomer.DataSource = context.Customers.ToList();
            comboBoxCustomer.DisplayMember = "LastName";
            comboBoxCustomer.ValueMember = "Id";
            comboBoxCustomer.SelectedIndex = -1;

            btnCheckIn.Enabled = false;
            btnCheckOut.Enabled = false;
        }

        private void btnFindReservation_Click(object sender, EventArgs e)
        {
            if (comboBoxCustomer.SelectedItem is not Customer customer)
            {
                MessageBox.Show("Please select a customer.");
                return;
            }
            var selectedDate = dateTimeReservation.Value.Date;

            // Find reservation for customer and date
            currentReservation = context.Reservations
                .Include(r => r.Room)
                .FirstOrDefault(r =>
                    r.CustomerId == customer.Id &&
                    r.ReservationDateFrom <= selectedDate && r.ReservationDateTo >= selectedDate &&
                    !r.Canceled);

            if (currentReservation == null)
            {
                MessageBox.Show("No reservation found for this customer and date.");
                comboBoxRoom.DataSource = null;
                btnCheckIn.Enabled = false;
                btnCheckOut.Enabled = false;
                return;
            }

            dateTimeFrom.Value = currentReservation.ReservationDateFrom;
            dateTimeTo.Value = currentReservation.ReservationDateTo;
            comboBoxRoom.DataSource = new List<Room> { currentReservation.Room };
            comboBoxRoom.DisplayMember = "RoomNumber";
            comboBoxRoom.ValueMember = "Id";
            comboBoxRoom.SelectedIndex = 0;

            btnCheckIn.Enabled = currentReservation.CheckInDate == DateTime.MinValue;
            btnCheckOut.Enabled = currentReservation.CheckInDate != DateTime.MinValue &&
                                  currentReservation.CheckOutDate == DateTime.MinValue;
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            if (currentReservation == null) return;
            if (currentReservation.CheckInDate != DateTime.MinValue)
            {
                MessageBox.Show("Already checked in!");
                return;
            }
            currentReservation.CheckInDate = DateTime.Now;
            context.SaveChanges();
            MessageBox.Show("Check-in successful!");
            btnCheckIn.Enabled = false;
            btnCheckOut.Enabled = true;
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if (currentReservation == null)
            {
                MessageBox.Show("No reservation selected for check-out.");
                return;
            }

            if (currentReservation.CheckOutDate == DateTime.MinValue)
            {
                currentReservation.CheckOutDate = DateTime.Now;
                context.SaveChanges();
                MessageBox.Show("Check-out successful!");
                btnCheckOut.Enabled = false;
            }
            else
            {
                MessageBox.Show("This reservation is already checked out.");
            }
        }

       
    }
}

