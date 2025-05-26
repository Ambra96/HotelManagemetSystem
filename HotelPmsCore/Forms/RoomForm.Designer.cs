namespace HotelPmsCore.Forms
{
    partial class RoomForm
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
            dataGridViewRoom = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            roomNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            floorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            WinterPrice = new DataGridViewTextBoxColumn();
            SummerPrice = new DataGridViewTextBoxColumn();
            PeopleCapacity = new DataGridViewTextBoxColumn();
            RoomType = new DataGridViewTextBoxColumn();
            RoomTypeDescription = new DataGridViewTextBoxColumn();
            roomBindingSource = new BindingSource(components);
            NxtBttn = new Button();
            PrvBttn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRoom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)roomBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewRoom
            // 
            dataGridViewRoom.AllowUserToAddRows = false;
            dataGridViewRoom.AllowUserToDeleteRows = false;
            dataGridViewRoom.AutoGenerateColumns = false;
            dataGridViewRoom.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewRoom.BackgroundColor = SystemColors.ButtonFace;
            dataGridViewRoom.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRoom.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, roomNumberDataGridViewTextBoxColumn, floorDataGridViewTextBoxColumn, WinterPrice, SummerPrice, PeopleCapacity, RoomType, RoomTypeDescription });
            dataGridViewRoom.DataSource = roomBindingSource;
            dataGridViewRoom.Location = new Point(12, 89);
            dataGridViewRoom.Name = "dataGridViewRoom";
            dataGridViewRoom.ReadOnly = true;
            dataGridViewRoom.RowHeadersWidth = 62;
            dataGridViewRoom.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewRoom.Size = new Size(1471, 626);
            dataGridViewRoom.TabIndex = 0;
      
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 8;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roomNumberDataGridViewTextBoxColumn
            // 
            roomNumberDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            roomNumberDataGridViewTextBoxColumn.DataPropertyName = "RoomNumber";
            roomNumberDataGridViewTextBoxColumn.HeaderText = "RoomNumber";
            roomNumberDataGridViewTextBoxColumn.MinimumWidth = 8;
            roomNumberDataGridViewTextBoxColumn.Name = "roomNumberDataGridViewTextBoxColumn";
            roomNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // floorDataGridViewTextBoxColumn
            // 
            floorDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            floorDataGridViewTextBoxColumn.DataPropertyName = "Floor";
            floorDataGridViewTextBoxColumn.HeaderText = "Floor";
            floorDataGridViewTextBoxColumn.MinimumWidth = 8;
            floorDataGridViewTextBoxColumn.Name = "floorDataGridViewTextBoxColumn";
            floorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // WinterPrice
            // 
            WinterPrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            WinterPrice.DataPropertyName = "WinterPrice";
            WinterPrice.HeaderText = "WinterPrice";
            WinterPrice.MinimumWidth = 8;
            WinterPrice.Name = "WinterPrice";
            WinterPrice.ReadOnly = true;
            // 
            // SummerPrice
            // 
            SummerPrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SummerPrice.DataPropertyName = "SummerPrice";
            SummerPrice.HeaderText = "SummerPrice";
            SummerPrice.MinimumWidth = 8;
            SummerPrice.Name = "SummerPrice";
            SummerPrice.ReadOnly = true;
            // 
            // PeopleCapacity
            // 
            PeopleCapacity.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            PeopleCapacity.DataPropertyName = "PeopleCapacity";
            PeopleCapacity.HeaderText = "PeopleCapacity";
            PeopleCapacity.MinimumWidth = 8;
            PeopleCapacity.Name = "PeopleCapacity";
            PeopleCapacity.ReadOnly = true;
            // 
            // RoomType
            // 
            RoomType.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            RoomType.DataPropertyName = "RoomType";
            RoomType.HeaderText = "RoomType";
            RoomType.MinimumWidth = 8;
            RoomType.Name = "RoomType";
            RoomType.ReadOnly = true;
            // 
            // RoomTypeDescription
            // 
            RoomTypeDescription.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            RoomTypeDescription.DataPropertyName = "RoomTypeDescription";
            RoomTypeDescription.HeaderText = "RoomTypeDescription";
            RoomTypeDescription.MinimumWidth = 8;
            RoomTypeDescription.Name = "RoomTypeDescription";
            RoomTypeDescription.ReadOnly = true;
            // 
            // roomBindingSource
            // 
            roomBindingSource.DataSource = typeof(Models.Room);
            // 
            // NxtBttn
            // 
            NxtBttn.Location = new Point(1350, 27);
            NxtBttn.Name = "NxtBttn";
            NxtBttn.Size = new Size(48, 34);
            NxtBttn.TabIndex = 4;
            NxtBttn.Text = ">";
            NxtBttn.UseVisualStyleBackColor = true;
            // 
            // PrvBttn
            // 
            PrvBttn.Location = new Point(1277, 27);
            PrvBttn.Name = "PrvBttn";
            PrvBttn.Size = new Size(48, 34);
            PrvBttn.TabIndex = 3;
            PrvBttn.Text = "<";
            PrvBttn.UseVisualStyleBackColor = true;
            // 
            // RoomForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 55, 55);
            ClientSize = new Size(1495, 727);
            Controls.Add(NxtBttn);
            Controls.Add(PrvBttn);
            Controls.Add(dataGridViewRoom);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(204, 133);
            Name = "RoomForm";
            Text = "RoomForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewRoom).EndInit();
            ((System.ComponentModel.ISupportInitialize)roomBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewRoom;
        private DataGridViewTextBoxColumn bedNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bathNumberDataGridViewTextBoxColumn;
        private BindingSource roomBindingSource;
        private Button NxtBttn;
        private Button PrvBttn;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn roomNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn floorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn WinterPrice;
        private DataGridViewTextBoxColumn SummerPrice;
        private DataGridViewTextBoxColumn PeopleCapacity;
        private DataGridViewTextBoxColumn RoomType;
        private DataGridViewTextBoxColumn RoomTypeDescription;
    }
}