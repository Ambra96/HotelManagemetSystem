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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffFilter));
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
            textBoxLastname.Location = new Point(303, 139);
            textBoxLastname.Name = "textBoxLastname";
            textBoxLastname.Size = new Size(237, 31);
            textBoxLastname.TabIndex = 8;
            // 
            // textBoxFirstname
            // 
            textBoxFirstname.Location = new Point(303, 61);
            textBoxFirstname.Name = "textBoxFirstname";
            textBoxFirstname.Size = new Size(237, 31);
            textBoxFirstname.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(148, 145);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 6;
            label2.Text = "Lastname";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(148, 67);
            label1.Name = "label1";
            label1.Size = new Size(89, 25);
            label1.TabIndex = 5;
            label1.Text = "Firstname";
            // 
            // ButtonCancel
            // 
            ButtonCancel.BackColor = Color.Brown;
            ButtonCancel.Location = new Point(446, 299);
            ButtonCancel.Name = "ButtonCancel";
            ButtonCancel.Size = new Size(94, 42);
            ButtonCancel.TabIndex = 16;
            ButtonCancel.Text = "Cancel";
            ButtonCancel.UseVisualStyleBackColor = false;
            ButtonCancel.Click += ButtonCancel_Click;
            // 
            // ButtonOk
            // 
            ButtonOk.BackColor = Color.LightSteelBlue;
            ButtonOk.Location = new Point(160, 299);
            ButtonOk.Name = "ButtonOk";
            ButtonOk.Size = new Size(94, 42);
            ButtonOk.TabIndex = 15;
            ButtonOk.Text = "Ok";
            ButtonOk.UseVisualStyleBackColor = false;
            ButtonOk.Click += ButtonOk_Click;
            // 
            // ButtonClFilter
            // 
            ButtonClFilter.BackColor = Color.LightSteelBlue;
            ButtonClFilter.Location = new Point(280, 299);
            ButtonClFilter.Name = "ButtonClFilter";
            ButtonClFilter.Size = new Size(137, 42);
            ButtonClFilter.TabIndex = 14;
            ButtonClFilter.Text = "Clear Filter";
            ButtonClFilter.UseVisualStyleBackColor = false;
            ButtonClFilter.Click += ButtonClFilter_Click;
            // 
            // StaffFilter
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(694, 459);
            Controls.Add(ButtonCancel);
            Controls.Add(ButtonOk);
            Controls.Add(ButtonClFilter);
            Controls.Add(textBoxLastname);
            Controls.Add(textBoxFirstname);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "StaffFilter";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Filter Staff";
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