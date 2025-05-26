namespace HotelPmsCore.Forms
{
    partial class RoomEditForm
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
            roomBindingSource = new BindingSource(components);
            txtDescription = new TextBox();
            txtRoomType = new TextBox();
            txtFloor = new TextBox();
            txtRoomNumber = new TextBox();
            SaveBttn = new Button();
            CancelBttn = new Button();
            numCapacity = new NumericUpDown();
            numSummer = new NumericUpDown();
            numWinter = new NumericUpDown();
            label1 = new Label();
            label5 = new Label();
            label6 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)roomBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCapacity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSummer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numWinter).BeginInit();
            SuspendLayout();
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(352, 301);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(150, 31);
            txtDescription.TabIndex = 15;
            // 
            // txtRoomType
            // 
            txtRoomType.Location = new Point(352, 264);
            txtRoomType.Name = "txtRoomType";
            txtRoomType.Size = new Size(150, 31);
            txtRoomType.TabIndex = 12;
            // 
            // txtFloor
            // 
            txtFloor.Location = new Point(352, 116);
            txtFloor.Name = "txtFloor";
            txtFloor.Size = new Size(150, 31);
            txtFloor.TabIndex = 10;
            // 
            // txtRoomNumber
            // 
            txtRoomNumber.Location = new Point(352, 77);
            txtRoomNumber.Name = "txtRoomNumber";
            txtRoomNumber.Size = new Size(150, 31);
            txtRoomNumber.TabIndex = 9;
            // 
            // SaveBttn
            // 
            SaveBttn.Location = new Point(209, 385);
            SaveBttn.Name = "SaveBttn";
            SaveBttn.Size = new Size(111, 42);
            SaveBttn.TabIndex = 16;
            SaveBttn.Text = "Save";
            SaveBttn.UseVisualStyleBackColor = true;
            // 
            // CancelBttn
            // 
            CancelBttn.Location = new Point(478, 385);
            CancelBttn.Name = "CancelBttn";
            CancelBttn.Size = new Size(111, 42);
            CancelBttn.TabIndex = 17;
            CancelBttn.Text = "Cancel";
            CancelBttn.UseVisualStyleBackColor = true;
            // 
            // numCapacity
            // 
            numCapacity.Location = new Point(352, 227);
            numCapacity.Name = "numCapacity";
            numCapacity.Size = new Size(150, 31);
            numCapacity.TabIndex = 18;
            // 
            // numSummer
            // 
            numSummer.Location = new Point(352, 190);
            numSummer.Name = "numSummer";
            numSummer.Size = new Size(150, 31);
            numSummer.TabIndex = 19;
            // 
            // numWinter
            // 
            numWinter.AccessibleName = "WinterPrice";
            numWinter.Location = new Point(352, 153);
            numWinter.Name = "numWinter";
            numWinter.Size = new Size(150, 31);
            numWinter.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(151, 77);
            label1.Name = "label1";
            label1.Size = new Size(125, 25);
            label1.TabIndex = 21;
            label1.Text = "RoomNumber";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(151, 190);
            label5.Name = "label5";
            label5.Size = new Size(116, 25);
            label5.TabIndex = 25;
            label5.Text = "SummerPrice";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(151, 153);
            label6.Name = "label6";
            label6.Size = new Size(101, 25);
            label6.TabIndex = 26;
            label6.Text = "WinterPrice";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(151, 264);
            label2.Name = "label2";
            label2.Size = new Size(97, 25);
            label2.TabIndex = 29;
            label2.Text = "RoomType";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(151, 301);
            label3.Name = "label3";
            label3.Size = new Size(102, 25);
            label3.TabIndex = 28;
            label3.Text = "Description";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(151, 227);
            label4.Name = "label4";
            label4.Size = new Size(79, 25);
            label4.TabIndex = 27;
            label4.Text = "Capacity";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(151, 116);
            label7.Name = "label7";
            label7.Size = new Size(53, 25);
            label7.TabIndex = 30;
            label7.Text = "Floor";
            // 
            // RoomEditForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(numWinter);
            Controls.Add(numSummer);
            Controls.Add(numCapacity);
            Controls.Add(CancelBttn);
            Controls.Add(SaveBttn);
            Controls.Add(txtDescription);
            Controls.Add(txtRoomType);
            Controls.Add(txtFloor);
            Controls.Add(txtRoomNumber);
            Name = "RoomEditForm";
            Text = "RoomEditForm";
            ((System.ComponentModel.ISupportInitialize)roomBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCapacity).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSummer).EndInit();
            ((System.ComponentModel.ISupportInitialize)numWinter).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private BindingSource roomBindingSource;
        private TextBox txtDescription;
        private TextBox txtRoomType;
        private TextBox txtFloor;
        private TextBox txtRoomNumber;
        private Button SaveBttn;
        private Button CancelBttn;
        private NumericUpDown numCapacity;
        private NumericUpDown numSummer;
        private NumericUpDown numWinter;
        private Label label1;
        private Label label5;
        private Label label6;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label7;
    }
}