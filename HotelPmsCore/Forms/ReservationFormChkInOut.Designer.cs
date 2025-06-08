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
            label1 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            label3 = new Label();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker3 = new DateTimePicker();
            label4 = new Label();
            comboBox2 = new ComboBox();
            button3 = new Button();
            button2 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 32);
            label1.Name = "label1";
            label1.Size = new Size(89, 25);
            label1.TabIndex = 0;
            label1.Text = "Customer";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 101);
            label2.Name = "label2";
            label2.Size = new Size(145, 25);
            label2.TabIndex = 1;
            label2.Text = "Reservation Date";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(214, 24);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(502, 33);
            comboBox1.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(214, 95);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(152, 31);
            dateTimePicker1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(487, 95);
            button1.Name = "button1";
            button1.Size = new Size(205, 31);
            button1.TabIndex = 4;
            button1.Text = "Find Reservation";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(comboBox1);
            panel1.Location = new Point(3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(755, 224);
            panel1.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(comboBox2);
            panel2.Controls.Add(dateTimePicker3);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(dateTimePicker2);
            panel2.Location = new Point(3, 232);
            panel2.Name = "panel2";
            panel2.Size = new Size(755, 349);
            panel2.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 27);
            label3.Name = "label3";
            label3.Size = new Size(153, 25);
            label3.TabIndex = 4;
            label3.Text = "Reservation Dates";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(214, 21);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(152, 31);
            dateTimePicker2.TabIndex = 5;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Format = DateTimePickerFormat.Short;
            dateTimePicker3.Location = new Point(487, 21);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(152, 31);
            dateTimePicker3.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 107);
            label4.Name = "label4";
            label4.Size = new Size(60, 25);
            label4.TabIndex = 7;
            label4.Text = "Room";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(214, 99);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(502, 33);
            comboBox2.TabIndex = 8;
            // 
            // button3
            // 
            button3.Location = new Point(609, 275);
            button3.Margin = new Padding(4, 5, 4, 5);
            button3.Name = "button3";
            button3.Size = new Size(107, 38);
            button3.TabIndex = 12;
            button3.Text = "Check Out";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(469, 275);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(107, 38);
            button2.TabIndex = 11;
            button2.Text = "Check In";
            button2.UseVisualStyleBackColor = true;
            // 
            // ReservationFormChkInOut
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(761, 585);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ReservationFormChkInOut";
            Text = "ReservationFormChkInOut";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker1;
        private Button button1;
        private Panel panel1;
        private Panel panel2;
        private Button button3;
        private Button button2;
        private Label label4;
        private ComboBox comboBox2;
        private DateTimePicker dateTimePicker3;
        private Label label3;
        private DateTimePicker dateTimePicker2;
    }
}