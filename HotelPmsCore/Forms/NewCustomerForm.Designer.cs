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
            SuspendLayout();
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(552, 148);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(112, 34);
            SaveButton.TabIndex = 20;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += BtnSave_Click;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(136, 285);
            txtCity.Name = "txtCity";
            txtCity.PlaceholderText = "City";
            txtCity.Size = new Size(150, 31);
            txtCity.TabIndex = 19;
            // 
            // txtZipCode
            // 
            txtZipCode.Location = new Point(136, 359);
            txtZipCode.Name = "txtZipCode";
            txtZipCode.PlaceholderText = "ZipCode";
            txtZipCode.Size = new Size(150, 31);
            txtZipCode.TabIndex = 18;
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(136, 322);
            txtCountry.Name = "txtCountry";
            txtCountry.PlaceholderText = "Country";
            txtCountry.Size = new Size(150, 31);
            txtCountry.TabIndex = 17;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(136, 174);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(150, 31);
            txtEmail.TabIndex = 16;
            // 
            // txtAFM
            // 
            txtAFM.Location = new Point(136, 137);
            txtAFM.Name = "txtAFM";
            txtAFM.PlaceholderText = "AFM";
            txtAFM.Size = new Size(150, 31);
            txtAFM.TabIndex = 15;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(136, 248);
            txtAddress.Name = "txtAddress";
            txtAddress.PlaceholderText = "Address";
            txtAddress.Size = new Size(150, 31);
            txtAddress.TabIndex = 14;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(136, 211);
            txtPhone.Name = "txtPhone";
            txtPhone.PlaceholderText = "Phone";
            txtPhone.Size = new Size(150, 31);
            txtPhone.TabIndex = 13;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(136, 98);
            txtLastName.Name = "txtLastName";
            txtLastName.PlaceholderText = "LastName";
            txtLastName.Size = new Size(150, 31);
            txtLastName.TabIndex = 12;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(136, 61);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.PlaceholderText = "FirstName";
            txtFirstName.Size = new Size(150, 31);
            txtFirstName.TabIndex = 11;
            // 
            // NewCustomerForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Name = "NewCustomerForm";
            Text = "NewCustomerForm";
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
    }
}