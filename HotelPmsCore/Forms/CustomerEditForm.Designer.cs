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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerEditForm));
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)bindingSourceCustomer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // bindingSourceCustomer
            // 
            bindingSourceCustomer.DataSource = typeof(Customer);
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(339, 24);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(150, 31);
            txtFirstName.TabIndex = 0;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(339, 61);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(150, 31);
            txtLastName.TabIndex = 1;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(339, 211);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(150, 31);
            txtAddress.TabIndex = 3;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(339, 174);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(150, 31);
            txtPhone.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(339, 137);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(150, 31);
            txtEmail.TabIndex = 5;
            // 
            // txtAFM
            // 
            txtAFM.Location = new Point(339, 100);
            txtAFM.Name = "txtAFM";
            txtAFM.Size = new Size(150, 31);
            txtAFM.TabIndex = 4;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(339, 248);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(150, 31);
            txtCity.TabIndex = 8;
            // 
            // txtZipCode
            // 
            txtZipCode.Location = new Point(339, 322);
            txtZipCode.Name = "txtZipCode";
            txtZipCode.Size = new Size(150, 31);
            txtZipCode.TabIndex = 7;
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(339, 285);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(150, 31);
            txtCountry.TabIndex = 6;
            // 
            // SaveButton
            // 
            SaveButton.BackColor = Color.LightSteelBlue;
            SaveButton.Location = new Point(185, 399);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(94, 42);
            SaveButton.TabIndex = 9;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Click += SaveButton_Click_1;
            // 
            // CancelButton
            // 
            CancelButton.BackColor = Color.Brown;
            CancelButton.CausesValidation = false;
            CancelButton.DialogResult = DialogResult.Cancel;
            CancelButton.Location = new Point(371, 399);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(94, 42);
            CancelButton.TabIndex = 10;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = false;
            CancelButton.Click += CancelButton_Click;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(150, 30);
            label1.Name = "label1";
            label1.Size = new Size(89, 25);
            label1.TabIndex = 11;
            label1.Text = "Firstname";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(150, 67);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 12;
            label2.Text = "Lastname";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(150, 143);
            label3.Name = "label3";
            label3.Size = new Size(54, 25);
            label3.TabIndex = 14;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(150, 106);
            label4.Name = "label4";
            label4.Size = new Size(49, 25);
            label4.TabIndex = 13;
            label4.Text = "AFM";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(150, 287);
            label5.Name = "label5";
            label5.Size = new Size(75, 25);
            label5.TabIndex = 18;
            label5.Text = "Country";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(150, 250);
            label6.Name = "label6";
            label6.Size = new Size(42, 25);
            label6.TabIndex = 17;
            label6.Text = "City";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(150, 211);
            label7.Name = "label7";
            label7.Size = new Size(77, 25);
            label7.TabIndex = 16;
            label7.Text = "Address";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(150, 180);
            label8.Name = "label8";
            label8.Size = new Size(62, 25);
            label8.TabIndex = 15;
            label8.Text = "Phone";
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(150, 328);
            label9.Name = "label9";
            label9.Size = new Size(84, 25);
            label9.TabIndex = 19;
            label9.Text = "Zip Code";
            // 
            // CustomerEditForm
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
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CustomerEditForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "New/Edit Customer ";
            Load += CustomerEditForm_Load;
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
        private Label label3;
        private Label label4;
        private Label label2;
        private Label label1;
        private Label label9;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}