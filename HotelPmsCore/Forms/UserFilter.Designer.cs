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
            textBoxFullName.Location = new Point(398, 153);
            textBoxFullName.Name = "textBoxFullName";
            textBoxFullName.Size = new Size(201, 31);
            textBoxFullName.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(161, 159);
            label3.Name = "label3";
            label3.Size = new Size(90, 25);
            label3.TabIndex = 12;
            label3.Text = "FullName:";
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(398, 66);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(201, 31);
            textBoxUsername.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(161, 66);
            label1.Name = "label1";
            label1.Size = new Size(95, 25);
            label1.TabIndex = 8;
            label1.Text = "Username:";
            // 
            // ButtonCancel
            // 
            ButtonCancel.Location = new Point(478, 317);
            ButtonCancel.Name = "ButtonCancel";
            ButtonCancel.Size = new Size(95, 37);
            ButtonCancel.TabIndex = 27;
            ButtonCancel.Text = "Cancel";
            ButtonCancel.UseVisualStyleBackColor = true;
            ButtonCancel.Click += ButtonCancel_Click;
            // 
            // ButtonOk
            // 
            ButtonOk.Location = new Point(192, 317);
            ButtonOk.Name = "ButtonOk";
            ButtonOk.Size = new Size(58, 37);
            ButtonOk.TabIndex = 26;
            ButtonOk.Text = "Ok";
            ButtonOk.UseVisualStyleBackColor = true;
            ButtonOk.Click += ButtonOk_Click;
            // 
            // ButtonClFilter
            // 
            ButtonClFilter.Location = new Point(280, 317);
            ButtonClFilter.Name = "ButtonClFilter";
            ButtonClFilter.Size = new Size(174, 36);
            ButtonClFilter.TabIndex = 25;
            ButtonClFilter.Text = "Clear Filter";
            ButtonClFilter.UseVisualStyleBackColor = true;
            ButtonClFilter.Click += ButtonClFilter_Click;
            // 
            // UserFilter
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ButtonCancel);
            Controls.Add(ButtonOk);
            Controls.Add(ButtonClFilter);
            Controls.Add(textBoxFullName);
            Controls.Add(label3);
            Controls.Add(textBoxUsername);
            Controls.Add(label1);
            Name = "UserFilter";
            Text = "UserFilter";
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