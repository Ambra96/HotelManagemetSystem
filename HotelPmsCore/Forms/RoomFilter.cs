using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HotelPmsCore.Forms
{
    public partial class RoomFilter : Form
    {
        public Dictionary<string, object> FilterValues { get; set; } = new();

        public RoomFilter()
        {
            InitializeComponent();
        }

        private void ButtonOk_Click(object sender, EventArgs e)
        {
            GetFilterValues();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void ButtonClFilter_Click(object sender, EventArgs e)
        {
            txtRoomNumber.Text = "";
            numCapacity.Value = 0;
            FilterValues.Clear();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void GetFilterValues()
        {
            FilterValues.Clear();

            string roomNumber = txtRoomNumber.Text.Trim();
            if (!string.IsNullOrEmpty(roomNumber))
            {
                roomNumber = roomNumber.Replace("*", "%");
                FilterValues["RoomNumber"] = roomNumber;
            }

            int capacity = (int)numCapacity.Value;
            if (capacity > 0)
                FilterValues["Capacity"] = capacity;
        }
        private void RoomFilter_Shown(object sender, EventArgs e)
        {
            if (FilterValues.Count > 0)
            {
                if (FilterValues.TryGetValue("RoomNumber", out var rn) && rn is string roomNumber)
                    txtRoomNumber.Text = roomNumber.Replace("%", "*");

                if (FilterValues.TryGetValue("Capacity", out var cap) && cap is int capacity)
                    numCapacity.Value = capacity;
                else
                    numCapacity.Value = 0;
            }
            else
            {
                txtRoomNumber.Text = "";
                numCapacity.Value = 0;
            }
        }

    }
}
