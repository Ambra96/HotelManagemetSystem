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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomFilter));
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
            label1.Location = new Point(140, 96);
            label1.Name = "label1";
            label1.Size = new Size(125, 25);
            label1.TabIndex = 23;
            label1.Text = "RoomNumber";
            // 
            // txtRoomNumber
            // 
            txtRoomNumber.Location = new Point(341, 96);
            txtRoomNumber.Name = "txtRoomNumber";
            txtRoomNumber.Size = new Size(190, 31);
            txtRoomNumber.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(142, 207);
            label3.Name = "label3";
            label3.Size = new Size(0, 25);
            label3.TabIndex = 31;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(140, 161);
            label4.Name = "label4";
            label4.Size = new Size(79, 25);
            label4.TabIndex = 30;
            label4.Text = "Capacity";
            // 
            // numCapacity
            // 
            numCapacity.Location = new Point(341, 161);
            numCapacity.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            numCapacity.Name = "numCapacity";
            numCapacity.Size = new Size(190, 31);
            numCapacity.TabIndex = 29;
            // 
            // ButtonCancel
            // 
            ButtonCancel.BackColor = Color.Brown;
            ButtonCancel.Location = new Point(428, 296);
            ButtonCancel.Name = "ButtonCancel";
            ButtonCancel.Size = new Size(94, 42);
            ButtonCancel.TabIndex = 34;
            ButtonCancel.Text = "Cancel";
            ButtonCancel.UseVisualStyleBackColor = false;
            ButtonCancel.Click += ButtonCancel_Click;
            // 
            // ButtonOk
            // 
            ButtonOk.BackColor = Color.LightSteelBlue;
            ButtonOk.Location = new Point(142, 296);
            ButtonOk.Name = "ButtonOk";
            ButtonOk.Size = new Size(94, 42);
            ButtonOk.TabIndex = 33;
            ButtonOk.Text = "Ok";
            ButtonOk.UseVisualStyleBackColor = false;
            ButtonOk.Click += ButtonOk_Click;
            // 
            // ButtonClFilter
            // 
            ButtonClFilter.BackColor = Color.LightSteelBlue;
            ButtonClFilter.Location = new Point(256, 296);
            ButtonClFilter.Name = "ButtonClFilter";
            ButtonClFilter.Size = new Size(137, 42);
            ButtonClFilter.TabIndex = 32;
            ButtonClFilter.Text = "Clear Filter";
            ButtonClFilter.UseVisualStyleBackColor = false;
            ButtonClFilter.Click += ButtonClFilter_Click;
            // 
            // RoomFilter
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(694, 459);
            Controls.Add(ButtonCancel);
            Controls.Add(ButtonOk);
            Controls.Add(ButtonClFilter);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(numCapacity);
            Controls.Add(label1);
            Controls.Add(txtRoomNumber);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "RoomFilter";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RoomFilter";
            Shown += RoomFilter_Shown;
            ((System.ComponentModel.ISupportInitialize)numCapacity).EndInit();
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