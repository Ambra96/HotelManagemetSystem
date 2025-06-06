namespace HotelPmsCore.Forms
{
    partial class RoomFilter
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
            txtRoomNumber = new TextBox();
            label3 = new Label();
            label4 = new Label();
            numCapacity = new NumericUpDown();
            ButtonCancel = new Button();
            ButtonOk = new Button();
            ButtonClFilter = new Button();
            ((System.ComponentModel.ISupportInitialize)numCapacity).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(204, 51);
            label1.Name = "label1";
            label1.Size = new Size(125, 25);
            label1.TabIndex = 23;
            label1.Text = "RoomNumber";
            // 
            // txtRoomNumber
            // 
            txtRoomNumber.Location = new Point(405, 51);
            txtRoomNumber.Name = "txtRoomNumber";
            txtRoomNumber.Size = new Size(150, 31);
            txtRoomNumber.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(204, 162);
            label3.Name = "label3";
            label3.Size = new Size(0, 25);
            label3.TabIndex = 31;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(204, 116);
            label4.Name = "label4";
            label4.Size = new Size(79, 25);
            label4.TabIndex = 30;
            label4.Text = "Capacity";
            // 
            // numCapacity
            // 
            numCapacity.Location = new Point(405, 116);
            numCapacity.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            numCapacity.Name = "numCapacity";
            numCapacity.Size = new Size(150, 31);
            numCapacity.TabIndex = 29;
            // 
            // ButtonCancel
            // 
            ButtonCancel.Location = new Point(488, 275);
            ButtonCancel.Name = "ButtonCancel";
            ButtonCancel.Size = new Size(95, 37);
            ButtonCancel.TabIndex = 34;
            ButtonCancel.Text = "Cancel";
            ButtonCancel.UseVisualStyleBackColor = true;
            ButtonCancel.Click += ButtonCancel_Click;
            // 
            // ButtonOk
            // 
            ButtonOk.Location = new Point(202, 275);
            ButtonOk.Name = "ButtonOk";
            ButtonOk.Size = new Size(58, 37);
            ButtonOk.TabIndex = 33;
            ButtonOk.Text = "Ok";
            ButtonOk.UseVisualStyleBackColor = true;
            ButtonOk.Click += ButtonOk_Click;
            // 
            // ButtonClFilter
            // 
            ButtonClFilter.Location = new Point(290, 275);
            ButtonClFilter.Name = "ButtonClFilter";
            ButtonClFilter.Size = new Size(174, 36);
            ButtonClFilter.TabIndex = 32;
            ButtonClFilter.Text = "Clear Filter";
            ButtonClFilter.UseVisualStyleBackColor = true;
            ButtonClFilter.Click += ButtonClFilter_Click;
            // 
            // RoomFilter
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ButtonCancel);
            Controls.Add(ButtonOk);
            Controls.Add(ButtonClFilter);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(numCapacity);
            Controls.Add(label1);
            Controls.Add(txtRoomNumber);
            Name = "RoomFilter";
            Text = "RoomFilter";
            ((System.ComponentModel.ISupportInitialize)numCapacity).EndInit();
            Shown += RoomFilter_Shown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtRoomNumber;
        private Label label3;
        private Label label4;
        private NumericUpDown numCapacity;
        private Button ButtonCancel;
        private Button ButtonOk;
        private Button ButtonClFilter;
    }
}