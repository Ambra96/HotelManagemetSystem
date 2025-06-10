namespace HotelPmsCore.Forms
{
    partial class ReservationFormChkInOut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReservationFormChkInOut));
            label1 = new Label();
            label2 = new Label();
            comboBoxCustomer = new ComboBox();
            dateTimeReservation = new DateTimePicker();
            btnFindReservation = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            btnCheckOut = new Button();
            btnCheckIn = new Button();
            label4 = new Label();
            comboBoxRoom = new ComboBox();
            dateTimeTo = new DateTimePicker();
            label3 = new Label();
            dateTimeFrom = new DateTimePicker();
            bindingSource1 = new BindingSource(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(85, 52);
            label1.Name = "label1";
            label1.Size = new Size(89, 25);
            label1.TabIndex = 0;
            label1.Text = "Customer";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(85, 121);
            label2.Name = "label2";
            label2.Size = new Size(145, 25);
            label2.TabIndex = 1;
            label2.Text = "Reservation Date";
            // 
            // comboBoxCustomer
            // 
            comboBoxCustomer.FormattingEnabled = true;
            comboBoxCustomer.Location = new Point(245, 44);
            comboBoxCustomer.Name = "comboBoxCustomer";
            comboBoxCustomer.Size = new Size(340, 33);
            comboBoxCustomer.TabIndex = 2;
            // 
            // dateTimeReservation
            // 
            dateTimeReservation.Format = DateTimePickerFormat.Short;
            dateTimeReservation.Location = new Point(245, 116);
            dateTimeReservation.Name = "dateTimeReservation";
            dateTimeReservation.Size = new Size(152, 31);
            dateTimeReservation.TabIndex = 3;
            // 
            // btnFindReservation
            // 
            btnFindReservation.Location = new Point(413, 116);
            btnFindReservation.Name = "btnFindReservation";
            btnFindReservation.Size = new Size(172, 38);
            btnFindReservation.TabIndex = 4;
            btnFindReservation.Text = "Find Reservation";
            btnFindReservation.UseVisualStyleBackColor = true;
            btnFindReservation.Click += btnFindReservation_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnFindReservation);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(dateTimeReservation);
            panel1.Controls.Add(comboBoxCustomer);
            panel1.Location = new Point(3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(689, 224);
            panel1.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnCheckOut);
            panel2.Controls.Add(btnCheckIn);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(comboBoxRoom);
            panel2.Controls.Add(dateTimeTo);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(dateTimeFrom);
            panel2.Location = new Point(3, 232);
            panel2.Name = "panel2";
            panel2.Size = new Size(689, 227);
            panel2.TabIndex = 6;
            // 
            // btnCheckOut
            // 
            btnCheckOut.Location = new Point(478, 157);
            btnCheckOut.Margin = new Padding(4, 5, 4, 5);
            btnCheckOut.Name = "btnCheckOut";
            btnCheckOut.Size = new Size(107, 38);
            btnCheckOut.TabIndex = 12;
            btnCheckOut.Text = "Check Out";
            btnCheckOut.UseVisualStyleBackColor = true;
            btnCheckOut.Click += btnCheckOut_Click;
            // 
            // btnCheckIn
            // 
            btnCheckIn.Location = new Point(338, 157);
            btnCheckIn.Margin = new Padding(4, 5, 4, 5);
            btnCheckIn.Name = "btnCheckIn";
            btnCheckIn.Size = new Size(107, 38);
            btnCheckIn.TabIndex = 11;
            btnCheckIn.Text = "Check In";
            btnCheckIn.UseVisualStyleBackColor = true;
            btnCheckIn.Click += btnCheckIn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(85, 101);
            label4.Name = "label4";
            label4.Size = new Size(60, 25);
            label4.TabIndex = 7;
            label4.Text = "Room";
            // 
            // comboBoxRoom
            // 
            comboBoxRoom.FormattingEnabled = true;
            comboBoxRoom.Location = new Point(245, 93);
            comboBoxRoom.Name = "comboBoxRoom";
            comboBoxRoom.Size = new Size(340, 33);
            comboBoxRoom.TabIndex = 8;
            // 
            // dateTimeTo
            // 
            dateTimeTo.Format = DateTimePickerFormat.Short;
            dateTimeTo.Location = new Point(433, 16);
            dateTimeTo.Name = "dateTimeTo";
            dateTimeTo.Size = new Size(152, 31);
            dateTimeTo.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(85, 21);
            label3.Name = "label3";
            label3.Size = new Size(153, 25);
            label3.TabIndex = 4;
            label3.Text = "Reservation Dates";
            // 
            // dateTimeFrom
            // 
            dateTimeFrom.Format = DateTimePickerFormat.Short;
            dateTimeFrom.Location = new Point(245, 15);
            dateTimeFrom.Name = "dateTimeFrom";
            dateTimeFrom.Size = new Size(152, 31);
            dateTimeFrom.TabIndex = 5;
            // 
            // ReservationFormChkInOut
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(694, 459);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ReservationFormChkInOut";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CheckIn/Out";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox comboBoxCustomer;
        private DateTimePicker dateTimeReservation;
        private Button btnFindReservation;
        private Panel panel1;
        private Panel panel2;
        private Button btnCheckOut;
        private Button btnCheckIn;
        private Label label4;
        private ComboBox comboBoxRoom;
        private DateTimePicker dateTimeTo;
        private Label label3;
        private DateTimePicker dateTimeFrom;
        private BindingSource bindingSource1;
    }
}