namespace HotelPmsCore.Forms
{
    partial class StaffFilter
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
            textBoxLastname = new TextBox();
            textBoxFirstname = new TextBox();
            label2 = new Label();
            label1 = new Label();
            ButtonCancel = new Button();
            ButtonOk = new Button();
            ButtonClFilter = new Button();
            SuspendLayout();
            // 
            // textBoxLastname
            // 
            textBoxLastname.Location = new Point(371, 138);
            textBoxLastname.Name = "textBoxLastname";
            textBoxLastname.Size = new Size(237, 31);
            textBoxLastname.TabIndex = 8;
            // 
            // textBoxFirstname
            // 
            textBoxFirstname.Location = new Point(371, 60);
            textBoxFirstname.Name = "textBoxFirstname";
            textBoxFirstname.Size = new Size(237, 31);
            textBoxFirstname.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(133, 144);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 6;
            label2.Text = "Lastname:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(133, 66);
            label1.Name = "label1";
            label1.Size = new Size(93, 25);
            label1.TabIndex = 5;
            label1.Text = "Firstname:";
            // 
            // ButtonCancel
            // 
            ButtonCancel.Location = new Point(480, 310);
            ButtonCancel.Name = "ButtonCancel";
            ButtonCancel.Size = new Size(95, 37);
            ButtonCancel.TabIndex = 16;
            ButtonCancel.Text = "Cancel";
            ButtonCancel.UseVisualStyleBackColor = true;
            ButtonCancel.Click += ButtonCancel_Click;
            // 
            // ButtonOk
            // 
            ButtonOk.Location = new Point(194, 310);
            ButtonOk.Name = "ButtonOk";
            ButtonOk.Size = new Size(58, 37);
            ButtonOk.TabIndex = 15;
            ButtonOk.Text = "Ok";
            ButtonOk.UseVisualStyleBackColor = true;
            ButtonOk.Click += ButtonOk_Click;
            // 
            // ButtonClFilter
            // 
            ButtonClFilter.Location = new Point(282, 310);
            ButtonClFilter.Name = "ButtonClFilter";
            ButtonClFilter.Size = new Size(174, 36);
            ButtonClFilter.TabIndex = 14;
            ButtonClFilter.Text = "Clear Filter";
            ButtonClFilter.UseVisualStyleBackColor = true;
            ButtonClFilter.Click += ButtonClFilter_Click;
            // 
            // StaffFilter
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ButtonCancel);
            Controls.Add(ButtonOk);
            Controls.Add(ButtonClFilter);
            Controls.Add(textBoxLastname);
            Controls.Add(textBoxFirstname);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "StaffFilter";
            Text = "StaffFilter";
            //Load += StaffFilter_Load;
            Shown += StaffFilter_Shown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxLastname;
        private TextBox textBoxFirstname;
        private Label label2;
        private Label label1;
        private Button ButtonCancel;
        private Button ButtonOk;
        private Button ButtonClFilter;
    }
}