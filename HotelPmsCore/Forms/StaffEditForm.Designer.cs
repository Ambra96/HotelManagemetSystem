namespace HotelPmsCore.Forms
{
    partial class StaffEditForm
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
            label3 = new Label();
            textBoxFirstname = new TextBox();
            textBoxLastname = new TextBox();
            textBoxSpeciality = new TextBox();
            button1save = new Button();
            button2cancel = new Button();
            StaffBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)StaffBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(121, 77);
            label1.Name = "label1";
            label1.Size = new Size(93, 25);
            label1.TabIndex = 0;
            label1.Text = "Firstname:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(121, 155);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 1;
            label2.Text = "Lastname:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(121, 227);
            label3.Name = "label3";
            label3.Size = new Size(90, 25);
            label3.TabIndex = 2;
            label3.Text = "Speciality:";
            // 
            // textBoxFirstname
            // 
            textBoxFirstname.Location = new Point(359, 71);
            textBoxFirstname.Name = "textBoxFirstname";
            textBoxFirstname.Size = new Size(237, 31);
            textBoxFirstname.TabIndex = 3;
            // 
            // textBoxLastname
            // 
            textBoxLastname.Location = new Point(359, 149);
            textBoxLastname.Name = "textBoxLastname";
            textBoxLastname.Size = new Size(237, 31);
            textBoxLastname.TabIndex = 4;
            // 
            // textBoxSpeciality
            // 
            textBoxSpeciality.Location = new Point(359, 221);
            textBoxSpeciality.Name = "textBoxSpeciality";
            textBoxSpeciality.Size = new Size(237, 31);
            textBoxSpeciality.TabIndex = 5;
            // 
            // button1save
            // 
            button1save.Location = new Point(224, 369);
            button1save.Name = "button1save";
            button1save.Size = new Size(112, 34);
            button1save.TabIndex = 6;
            button1save.Text = "Save";
            button1save.UseVisualStyleBackColor = true;
            button1save.Click += button1save_Click;
            // 
            // button2cancel
            // 
            button2cancel.Location = new Point(428, 369);
            button2cancel.Name = "button2cancel";
            button2cancel.Size = new Size(112, 34);
            button2cancel.TabIndex = 7;
            button2cancel.Text = "Cancel";
            button2cancel.UseVisualStyleBackColor = true;
            button2cancel.Click += button2cancel_Click;
            // 
            // StaffEditForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2cancel);
            Controls.Add(button1save);
            Controls.Add(textBoxSpeciality);
            Controls.Add(textBoxLastname);
            Controls.Add(textBoxFirstname);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "StaffEditForm";
            Text = "StaffEditForm";
            ((System.ComponentModel.ISupportInitialize)StaffBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxFirstname;
        private TextBox textBoxLastname;
        private TextBox textBoxSpeciality;
        private Button button1save;
        private Button button2cancel;
        private BindingSource StaffBindingSource;
    }
}