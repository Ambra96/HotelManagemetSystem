namespace HotelPmsCore.Forms
{
    partial class NewCustomerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewCustomerForm));
            SaveButton = new Button();
            txtCity = new TextBox();
            txtZipCode = new TextBox();
            txtCountry = new TextBox();
            txtEmail = new TextBox();
            txtAFM = new TextBox();
            txtAddress = new TextBox();
            txtPhone = new TextBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            label9 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // SaveButton
            // 
            SaveButton.BackColor = Color.ForestGreen;
            SaveButton.Location = new Point(245, 395);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(181, 42);
            SaveButton.TabIndex = 20;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Click += BtnSave_Click;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(275, 256);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(258, 31);
            txtCity.TabIndex = 19;
            // 
            // txtZipCode
            // 
            txtZipCode.Location = new Point(275, 330);
            txtZipCode.Name = "txtZipCode";
            txtZipCode.Size = new Size(258, 31);
            txtZipCode.TabIndex = 18;
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(275, 293);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(258, 31);
            txtCountry.TabIndex = 17;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(275, 145);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(258, 31);
            txtEmail.TabIndex = 16;
            // 
            // txtAFM
            // 
            txtAFM.Location = new Point(275, 108);
            txtAFM.Name = "txtAFM";
            txtAFM.Size = new Size(258, 31);
            txtAFM.TabIndex = 15;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(275, 219);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(258, 31);
            txtAddress.TabIndex = 14;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(275, 182);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(258, 31);
            txtPhone.TabIndex = 13;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(275, 69);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(258, 31);
            txtLastName.TabIndex = 12;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(275, 32);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(258, 31);
            txtFirstName.TabIndex = 11;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(151, 330);
            label9.Name = "label9";
            label9.Size = new Size(84, 25);
            label9.TabIndex = 29;
            label9.Text = "Zip Code";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(151, 289);
            label5.Name = "label5";
            label5.Size = new Size(75, 25);
            label5.TabIndex = 28;
            label5.Text = "Country";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(151, 252);
            label6.Name = "label6";
            label6.Size = new Size(42, 25);
            label6.TabIndex = 27;
            label6.Text = "City";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(151, 213);
            label7.Name = "label7";
            label7.Size = new Size(77, 25);
            label7.TabIndex = 26;
            label7.Text = "Address";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(151, 182);
            label8.Name = "label8";
            label8.Size = new Size(62, 25);
            label8.TabIndex = 25;
            label8.Text = "Phone";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(151, 145);
            label3.Name = "label3";
            label3.Size = new Size(54, 25);
            label3.TabIndex = 24;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(151, 108);
            label4.Name = "label4";
            label4.Size = new Size(49, 25);
            label4.TabIndex = 23;
            label4.Text = "AFM";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(151, 69);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 22;
            label2.Text = "Lastname";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(151, 32);
            label1.Name = "label1";
            label1.Size = new Size(89, 25);
            label1.TabIndex = 21;
            label1.Text = "Firstname";
            // 
            // NewCustomerForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(694, 459);
            Controls.Add(label9);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(SaveButton);
            Controls.Add(txtCity);
            Controls.Add(txtZipCode);
            Controls.Add(txtCountry);
            Controls.Add(txtEmail);
            Controls.Add(txtAFM);
            Controls.Add(txtAddress);
            Controls.Add(txtPhone);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "NewCustomerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "New Customer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SaveButton;
        private TextBox txtCity;
        private TextBox txtZipCode;
        private TextBox txtCountry;
        private TextBox txtEmail;
        private TextBox txtAFM;
        private TextBox txtAddress;
        private TextBox txtPhone;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private Label label9;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label3;
        private Label label4;
        private Label label2;
        private Label label1;
    }
}