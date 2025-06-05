using HotelPmsCore.Models;

namespace HotelPmsCore.Forms
{
    partial class CustomerEditForm
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
 
        private void InitializeComponent()
        {
      
            components = new System.ComponentModel.Container();
            bindingSourceCustomer = new BindingSource(components);
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtAddress = new TextBox();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            txtAFM = new TextBox();
            txtCity = new TextBox();
            txtZipCode = new TextBox();
            txtCountry = new TextBox();
            SaveButton = new Button();
            CancelButton = new Button();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)bindingSourceCustomer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // bindingSourceCustomer
            // 
            bindingSourceCustomer.DataSource = typeof(Models.Customer);
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(126, 55);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.PlaceholderText = "FirstName";
            txtFirstName.Size = new Size(150, 31);
            txtFirstName.TabIndex = 0;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(126, 92);
            txtLastName.Name = "txtLastName";
            txtLastName.PlaceholderText = "LastName";
            txtLastName.Size = new Size(150, 31);
            txtLastName.TabIndex = 1;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(126, 242);
            txtAddress.Name = "txtAddress";
            txtAddress.PlaceholderText = "Address";
            txtAddress.Size = new Size(150, 31);
            txtAddress.TabIndex = 3;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(126, 205);
            txtPhone.Name = "txtPhone";
            txtPhone.PlaceholderText = "Phone";
            txtPhone.Size = new Size(150, 31);
            txtPhone.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(126, 168);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(150, 31);
            txtEmail.TabIndex = 5;
            // 
            // txtAFM
            // 
            txtAFM.Location = new Point(126, 131);
            txtAFM.Name = "txtAFM";
            txtAFM.PlaceholderText = "AFM";
            txtAFM.Size = new Size(150, 31);
            txtAFM.TabIndex = 4;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(126, 279);
            txtCity.Name = "txtCity";
            txtCity.PlaceholderText = "City";
            txtCity.Size = new Size(150, 31);
            txtCity.TabIndex = 8;
            // 
            // txtZipCode
            // 
            txtZipCode.Location = new Point(126, 353);
            txtZipCode.Name = "txtZipCode";
            txtZipCode.PlaceholderText = "ZipCode";
            txtZipCode.Size = new Size(150, 31);
            txtZipCode.TabIndex = 7;
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(126, 316);
            txtCountry.Name = "txtCountry";
            txtCountry.PlaceholderText = "Country";
            txtCountry.Size = new Size(150, 31);
            txtCountry.TabIndex = 6;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(542, 142);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(112, 34);
            SaveButton.TabIndex = 9;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click_1;
            // 
            // CancelButton
            // 
            CancelButton.CausesValidation = false;
            CancelButton.DialogResult = DialogResult.Cancel;
            CancelButton.Location = new Point(542, 235);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(112, 34);
            CancelButton.TabIndex = 10;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // CustomerEditForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CancelButton);
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
            Name = "CustomerEditForm";
            Text = "CustomerEditForm";
            ((System.ComponentModel.ISupportInitialize)bindingSourceCustomer).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

      

        private BindingSource bindingSourceCustomer;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtAddress;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private TextBox txtAFM;
        private TextBox txtCity;
        private TextBox txtZipCode;
        private TextBox txtCountry;
        private Button SaveButton;
        private new Button CancelButton;
        private ErrorProvider errorProvider;
       
    }
}