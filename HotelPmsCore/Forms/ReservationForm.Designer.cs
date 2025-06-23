namespace HotelPmsCore.Forms
{
    partial class ReservationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            reservationBindingSource = new BindingSource(components);
            dateTimeFrom = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            dateTimeTo = new DateTimePicker();
            numericCapacity = new NumericUpDown();
            label3 = new Label();
            panel1 = new Panel();
            btnSave = new Button();
            button1 = new Button();
            textBoxTotal = new TextBox();
            textBoxPrice = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            comboBoxRoom = new ComboBox();
            comboBoxCustomer = new ComboBox();
            btnSearchRooms = new Button();
            buttonEditRes = new Button();
            customerBindingSource = new BindingSource(components);
            roomBindingSource = new BindingSource(components);
            customerIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            roomIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            reservationDateFromDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            reservationDateToDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            checkInDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            checkOutDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Canceled = new DataGridViewCheckBoxColumn();
            reservationDayPriceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)reservationBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericCapacity).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)roomBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.BackgroundColor = Color.MintCream;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { customerIdDataGridViewTextBoxColumn, roomIdDataGridViewTextBoxColumn, reservationDateFromDataGridViewTextBoxColumn, reservationDateToDataGridViewTextBoxColumn, checkInDateDataGridViewTextBoxColumn, checkOutDateDataGridViewTextBoxColumn, Canceled, reservationDayPriceDataGridViewTextBoxColumn });
            dataGridView1.DataSource = reservationBindingSource;
            dataGridView1.Location = new Point(-5, 67);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1488, 384);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
            dataGridView1.CurrentCellDirtyStateChanged += dataGridView1_CurrentCellDirtyStateChanged;
            // 
            // reservationBindingSource
            // 
            reservationBindingSource.DataSource = typeof(Models.Reservation);
            // 
            // dateTimeFrom
            // 
            dateTimeFrom.Format = DateTimePickerFormat.Short;
            dateTimeFrom.Location = new Point(358, 12);
            dateTimeFrom.Name = "dateTimeFrom";
            dateTimeFrom.Size = new Size(167, 31);
            dateTimeFrom.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(259, 18);
            label1.Name = "label1";
            label1.Size = new Size(93, 25);
            label1.TabIndex = 3;
            label1.Text = "Date from";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Window;
            label2.Location = new Point(548, 18);
            label2.Name = "label2";
            label2.Size = new Size(29, 25);
            label2.TabIndex = 5;
            label2.Text = "to";
            // 
            // dateTimeTo
            // 
            dateTimeTo.Format = DateTimePickerFormat.Short;
            dateTimeTo.Location = new Point(597, 12);
            dateTimeTo.Name = "dateTimeTo";
            dateTimeTo.Size = new Size(169, 31);
            dateTimeTo.TabIndex = 4;
            // 
            // numericCapacity
            // 
            numericCapacity.Location = new Point(945, 12);
            numericCapacity.Name = "numericCapacity";
            numericCapacity.Size = new Size(107, 31);
            numericCapacity.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Window;
            label3.Location = new Point(814, 18);
            label3.Name = "label3";
            label3.Size = new Size(107, 25);
            label3.TabIndex = 7;
            label3.Text = "Total People";
            // 
            // panel1
            // 
            panel1.BackColor = Color.MintCream;
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBoxTotal);
            panel1.Controls.Add(textBoxPrice);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(comboBoxRoom);
            panel1.Controls.Add(comboBoxCustomer);
            panel1.ForeColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(2, 457);
            panel1.Name = "panel1";
            panel1.Size = new Size(1488, 155);
            panel1.TabIndex = 8;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.LightSteelBlue;
            btnSave.Location = new Point(1241, 74);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(171, 41);
            btnSave.TabIndex = 19;
            btnSave.Text = "Create Reservation";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += BtnSave_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.LightSteelBlue;
            button1.Location = new Point(1241, 20);
            button1.Name = "button1";
            button1.Size = new Size(171, 41);
            button1.TabIndex = 18;
            button1.Text = "New Customer";
            button1.UseVisualStyleBackColor = false;
            button1.Click += BtnNewCustomer_Click;
            // 
            // textBoxTotal
            // 
            textBoxTotal.Location = new Point(109, 115);
            textBoxTotal.Name = "textBoxTotal";
            textBoxTotal.PlaceholderText = "€";
            textBoxTotal.Size = new Size(139, 31);
            textBoxTotal.TabIndex = 17;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(109, 75);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.PlaceholderText = "€";
            textBoxPrice.Size = new Size(139, 31);
            textBoxPrice.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(10, 78);
            label7.Name = "label7";
            label7.Size = new Size(49, 25);
            label7.TabIndex = 15;
            label7.Text = "Price";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(8, 118);
            label6.Name = "label6";
            label6.Size = new Size(91, 25);
            label6.TabIndex = 14;
            label6.Text = "Total Price";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(646, 28);
            label5.Name = "label5";
            label5.Size = new Size(60, 25);
            label5.TabIndex = 13;
            label5.Text = "Room";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(10, 28);
            label4.Name = "label4";
            label4.Size = new Size(89, 25);
            label4.TabIndex = 12;
            label4.Text = "Customer";
            // 
            // comboBoxRoom
            // 
            comboBoxRoom.FormattingEnabled = true;
            comboBoxRoom.Location = new Point(723, 20);
            comboBoxRoom.Name = "comboBoxRoom";
            comboBoxRoom.Size = new Size(331, 33);
            comboBoxRoom.TabIndex = 11;
            comboBoxRoom.SelectedIndexChanged += ComboBoxRoom_SelectedIndexChanged;
            // 
            // comboBoxCustomer
            // 
            comboBoxCustomer.FormattingEnabled = true;
            comboBoxCustomer.Location = new Point(109, 20);
            comboBoxCustomer.Name = "comboBoxCustomer";
            comboBoxCustomer.Size = new Size(331, 33);
            comboBoxCustomer.TabIndex = 10;
            // 
            // btnSearchRooms
            // 
            btnSearchRooms.BackColor = Color.LightSteelBlue;
            btnSearchRooms.Location = new Point(1243, 12);
            btnSearchRooms.Name = "btnSearchRooms";
            btnSearchRooms.Size = new Size(171, 41);
            btnSearchRooms.TabIndex = 9;
            btnSearchRooms.Text = "Search";
            btnSearchRooms.UseVisualStyleBackColor = false;
            btnSearchRooms.Click += BtnSearchRooms_Click;
            // 
            // buttonEditRes
            // 
            buttonEditRes.BackColor = Color.LightSteelBlue;
            buttonEditRes.Location = new Point(1243, 652);
            buttonEditRes.Name = "buttonEditRes";
            buttonEditRes.Size = new Size(171, 41);
            buttonEditRes.TabIndex = 19;
            buttonEditRes.Text = "Edit Reservation";
            buttonEditRes.UseVisualStyleBackColor = false;
            buttonEditRes.Click += buttonEditRes_Click;
            // 
            // customerBindingSource
            // 
            customerBindingSource.DataSource = typeof(Models.Customer);
            // 
            // roomBindingSource
            // 
            roomBindingSource.DataSource = typeof(Models.Room);
            // 
            // customerIdDataGridViewTextBoxColumn
            // 
            customerIdDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            customerIdDataGridViewTextBoxColumn.DataPropertyName = "CustomerId";
            customerIdDataGridViewTextBoxColumn.HeaderText = "CustomerId";
            customerIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            customerIdDataGridViewTextBoxColumn.Name = "customerIdDataGridViewTextBoxColumn";
            // 
            // roomIdDataGridViewTextBoxColumn
            // 
            roomIdDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            roomIdDataGridViewTextBoxColumn.DataPropertyName = "RoomId";
            roomIdDataGridViewTextBoxColumn.HeaderText = "RoomId";
            roomIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            roomIdDataGridViewTextBoxColumn.Name = "roomIdDataGridViewTextBoxColumn";
            // 
            // reservationDateFromDataGridViewTextBoxColumn
            // 
            reservationDateFromDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            reservationDateFromDataGridViewTextBoxColumn.DataPropertyName = "ReservationDateFrom";
            reservationDateFromDataGridViewTextBoxColumn.HeaderText = "ReservationDateFrom";
            reservationDateFromDataGridViewTextBoxColumn.MinimumWidth = 8;
            reservationDateFromDataGridViewTextBoxColumn.Name = "reservationDateFromDataGridViewTextBoxColumn";
            // 
            // reservationDateToDataGridViewTextBoxColumn
            // 
            reservationDateToDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            reservationDateToDataGridViewTextBoxColumn.DataPropertyName = "ReservationDateTo";
            reservationDateToDataGridViewTextBoxColumn.HeaderText = "ReservationDateTo";
            reservationDateToDataGridViewTextBoxColumn.MinimumWidth = 8;
            reservationDateToDataGridViewTextBoxColumn.Name = "reservationDateToDataGridViewTextBoxColumn";
            // 
            // checkInDateDataGridViewTextBoxColumn
            // 
            checkInDateDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            checkInDateDataGridViewTextBoxColumn.DataPropertyName = "CheckInDate";
            checkInDateDataGridViewTextBoxColumn.HeaderText = "CheckInDate";
            checkInDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            checkInDateDataGridViewTextBoxColumn.Name = "checkInDateDataGridViewTextBoxColumn";
            // 
            // checkOutDateDataGridViewTextBoxColumn
            // 
            checkOutDateDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            checkOutDateDataGridViewTextBoxColumn.DataPropertyName = "CheckOutDate";
            checkOutDateDataGridViewTextBoxColumn.HeaderText = "CheckOutDate";
            checkOutDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            checkOutDateDataGridViewTextBoxColumn.Name = "checkOutDateDataGridViewTextBoxColumn";
            // 
            // Canceled
            // 
            Canceled.DataPropertyName = "Canceled";
            Canceled.HeaderText = "Canceled";
            Canceled.MinimumWidth = 8;
            Canceled.Name = "Canceled";
            Canceled.Width = 150;
            // 
            // reservationDayPriceDataGridViewTextBoxColumn
            // 
            reservationDayPriceDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            reservationDayPriceDataGridViewTextBoxColumn.DataPropertyName = "ReservationDayPrice";
            reservationDayPriceDataGridViewTextBoxColumn.HeaderText = "ReservationDayPrice";
            reservationDayPriceDataGridViewTextBoxColumn.MinimumWidth = 8;
            reservationDayPriceDataGridViewTextBoxColumn.Name = "reservationDayPriceDataGridViewTextBoxColumn";
            // 
            // ReservationForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 55, 55);
            ClientSize = new Size(1495, 727);
            Controls.Add(buttonEditRes);
            Controls.Add(btnSearchRooms);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(numericCapacity);
            Controls.Add(label2);
            Controls.Add(dateTimeTo);
            Controls.Add(label1);
            Controls.Add(dateTimeFrom);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ReservationForm";
            Text = "ReservationForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)reservationBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericCapacity).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)roomBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private BindingSource reservationBindingSource;
        private DateTimePicker dateTimeFrom;
        private Label label1;
        private Label label2;
        private DateTimePicker dateTimeTo;
        private NumericUpDown numericCapacity;
        private Label label3;
        private Panel panel1;
        private ComboBox comboBoxRoom;
        private ComboBox comboBoxCustomer;
        private Label label5;
        private Label label4;
        private Label label7;
        private Label label6;
        private TextBox textBoxTotal;
        private TextBox textBoxPrice;
        private Button btnSearchRooms;
        private Button button1;
        private Button buttonEditRes;
        private Button btnSave;
        private BindingSource customerBindingSource;
        private BindingSource roomBindingSource;
        private DataGridViewTextBoxColumn customerIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn roomIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn reservationDateFromDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn reservationDateToDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn checkInDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn checkOutDateDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn Canceled;
        private DataGridViewTextBoxColumn reservationDayPriceDataGridViewTextBoxColumn;
    }
}