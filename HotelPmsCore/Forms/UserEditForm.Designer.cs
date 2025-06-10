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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserEditForm));
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
            label1.Location = new Point(124, 49);
            label1.Name = "label1";
            label1.Size = new Size(91, 25);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(124, 110);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(361, 49);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(201, 31);
            textBoxUsername.TabIndex = 2;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(361, 110);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(201, 31);
            textBoxPassword.TabIndex = 3;
            // 
            // ButtonSave
            // 
            ButtonSave.BackColor = Color.LightSteelBlue;
            ButtonSave.Location = new Point(194, 367);
            ButtonSave.Name = "ButtonSave";
            ButtonSave.Size = new Size(94, 42);
            ButtonSave.TabIndex = 4;
            ButtonSave.Text = "Save";
            ButtonSave.UseVisualStyleBackColor = false;
            ButtonSave.Click += ButtonSave_Click;
            // 
            // ButtonCancel
            // 
            ButtonCancel.BackColor = Color.Brown;
            ButtonCancel.Location = new Point(382, 367);
            ButtonCancel.Name = "ButtonCancel";
            ButtonCancel.Size = new Size(94, 42);
            ButtonCancel.TabIndex = 5;
            ButtonCancel.Text = "Cancel";
            ButtonCancel.UseVisualStyleBackColor = false;
            ButtonCancel.Click += ButtonCancel_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(124, 184);
            label3.Name = "label3";
            label3.Size = new Size(86, 25);
            label3.TabIndex = 6;
            label3.Text = "FullName";
            // 
            // textBoxFullName
            // 
            textBoxFullName.Location = new Point(361, 178);
            textBoxFullName.Name = "textBoxFullName";
            textBoxFullName.Size = new Size(201, 31);
            textBoxFullName.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(124, 251);
            label4.Name = "label4";
            label4.Size = new Size(64, 25);
            label4.TabIndex = 8;
            label4.Text = "RoleID";
            // 
            // comboBoxUser
            // 
            comboBoxUser.DataSource = typedCategoryBindingSource;
            comboBoxUser.DisplayMember = "Description";
            comboBoxUser.FormattingEnabled = true;
            comboBoxUser.Location = new Point(361, 248);
            comboBoxUser.Name = "comboBoxUser";
            comboBoxUser.Size = new Size(201, 33);
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
            BackColor = Color.MintCream;
            ClientSize = new Size(694, 459);
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
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "UserEditForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "New/Edit User";
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