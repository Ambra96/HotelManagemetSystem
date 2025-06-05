namespace HotelPmsCore.Forms
{
    partial class UserEditForm
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
            label1 = new Label();
            label2 = new Label();
            textBoxUsername = new TextBox();
            textBoxPassword = new TextBox();
            ButtonSave = new Button();
            ButtonCancel = new Button();
            userBindingSource = new BindingSource(components);
            label3 = new Label();
            textBoxFullName = new TextBox();
            label4 = new Label();
            comboBoxUser = new ComboBox();
            typedCategoryBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)userBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)typedCategoryBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(182, 38);
            label1.Name = "label1";
            label1.Size = new Size(95, 25);
            label1.TabIndex = 0;
            label1.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(182, 115);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 1;
            label2.Text = "Password:";
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(419, 38);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(201, 31);
            textBoxUsername.TabIndex = 2;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(419, 115);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(201, 31);
            textBoxPassword.TabIndex = 3;
            // 
            // ButtonSave
            // 
            ButtonSave.Location = new Point(233, 355);
            ButtonSave.Name = "ButtonSave";
            ButtonSave.Size = new Size(112, 34);
            ButtonSave.TabIndex = 4;
            ButtonSave.Text = "Save";
            ButtonSave.UseVisualStyleBackColor = true;
            ButtonSave.Click += ButtonSave_Click;
            // 
            // ButtonCancel
            // 
            ButtonCancel.Location = new Point(450, 355);
            ButtonCancel.Name = "ButtonCancel";
            ButtonCancel.Size = new Size(112, 34);
            ButtonCancel.TabIndex = 5;
            ButtonCancel.Text = "Cancel";
            ButtonCancel.UseVisualStyleBackColor = true;
            ButtonCancel.Click += ButtonCancel_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(182, 189);
            label3.Name = "label3";
            label3.Size = new Size(90, 25);
            label3.TabIndex = 6;
            label3.Text = "FullName:";
            // 
            // textBoxFullName
            // 
            textBoxFullName.Location = new Point(419, 183);
            textBoxFullName.Name = "textBoxFullName";
            textBoxFullName.Size = new Size(201, 31);
            textBoxFullName.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(182, 271);
            label4.Name = "label4";
            label4.Size = new Size(68, 25);
            label4.TabIndex = 8;
            label4.Text = "RoleID:";
            // 
            // comboBoxUser
            // 
            comboBoxUser.DataSource = typedCategoryBindingSource;
            comboBoxUser.DisplayMember = "Description";
            comboBoxUser.FormattingEnabled = true;
            comboBoxUser.Location = new Point(419, 268);
            comboBoxUser.Name = "comboBoxUser";
            comboBoxUser.Size = new Size(182, 33);
            comboBoxUser.TabIndex = 9;
            comboBoxUser.ValueMember = "Id";
            // 
            // typedCategoryBindingSource
            // 
            typedCategoryBindingSource.DataSource = typeof(Models.TypedCategory);
            // 
            // UserEditForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBoxUser);
            Controls.Add(label4);
            Controls.Add(textBoxFullName);
            Controls.Add(label3);
            Controls.Add(ButtonCancel);
            Controls.Add(ButtonSave);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UserEditForm";
            Text = "UserEditForm";
            ((System.ComponentModel.ISupportInitialize)userBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)typedCategoryBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxUsername;
        private TextBox textBoxPassword;
        private Button ButtonSave;
        private Button ButtonCancel;
        private BindingSource userBindingSource;
        private Label label3;
        private TextBox textBoxFullName;
        private Label label4;
        private ComboBox comboBoxUser;
        private BindingSource typedCategoryBindingSource;
    }
}