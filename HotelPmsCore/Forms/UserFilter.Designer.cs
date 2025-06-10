namespace HotelPmsCore.Forms
{
    partial class UserFilter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserFilter));
            textBoxFullName = new TextBox();
            label3 = new Label();
            textBoxUsername = new TextBox();
            label1 = new Label();
            ButtonCancel = new Button();
            ButtonOk = new Button();
            ButtonClFilter = new Button();
            SuspendLayout();
            // 
            // textBoxFullName
            // 
            textBoxFullName.Location = new Point(321, 155);
            textBoxFullName.Name = "textBoxFullName";
            textBoxFullName.Size = new Size(223, 31);
            textBoxFullName.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(124, 164);
            label3.Name = "label3";
            label3.Size = new Size(86, 25);
            label3.TabIndex = 12;
            label3.Text = "FullName";
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(321, 68);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(223, 31);
            textBoxUsername.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(124, 71);
            label1.Name = "label1";
            label1.Size = new Size(91, 25);
            label1.TabIndex = 8;
            label1.Text = "Username";
            // 
            // ButtonCancel
            // 
            ButtonCancel.BackColor = Color.Brown;
            ButtonCancel.Location = new Point(450, 326);
            ButtonCancel.Name = "ButtonCancel";
            ButtonCancel.Size = new Size(94, 42);
            ButtonCancel.TabIndex = 27;
            ButtonCancel.Text = "Cancel";
            ButtonCancel.UseVisualStyleBackColor = false;
            ButtonCancel.Click += ButtonCancel_Click;
            // 
            // ButtonOk
            // 
            ButtonOk.BackColor = Color.LightSteelBlue;
            ButtonOk.Location = new Point(124, 326);
            ButtonOk.Name = "ButtonOk";
            ButtonOk.Size = new Size(94, 42);
            ButtonOk.TabIndex = 26;
            ButtonOk.Text = "Ok";
            ButtonOk.UseVisualStyleBackColor = false;
            ButtonOk.Click += ButtonOk_Click;
            // 
            // ButtonClFilter
            // 
            ButtonClFilter.BackColor = Color.LightSteelBlue;
            ButtonClFilter.Location = new Point(266, 326);
            ButtonClFilter.Name = "ButtonClFilter";
            ButtonClFilter.Size = new Size(137, 42);
            ButtonClFilter.TabIndex = 25;
            ButtonClFilter.Text = "Clear Filter";
            ButtonClFilter.UseVisualStyleBackColor = false;
            ButtonClFilter.Click += ButtonClFilter_Click;
            // 
            // UserFilter
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(694, 459);
            Controls.Add(ButtonCancel);
            Controls.Add(ButtonOk);
            Controls.Add(ButtonClFilter);
            Controls.Add(textBoxFullName);
            Controls.Add(label3);
            Controls.Add(textBoxUsername);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "UserFilter";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Filter User";
            Shown += UserFilter_Shown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxFullName;
        private Label label3;
        private TextBox textBoxUsername;
        private Label label1;
        private Button ButtonCancel;
        private Button ButtonOk;
        private Button ButtonClFilter;
    }
}