namespace HotelPmsCore.Forms
{
    partial class CustomerFilter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerFilter));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            TextBoxName = new TextBox();
            TextBoxAfm = new TextBox();
            TextBoxSurname = new TextBox();
            TextBoxNameTo = new TextBox();
            label4 = new Label();
            ButtonClFilter = new Button();
            ButtonOk = new Button();
            ButtonCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 51);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 120);
            label2.Name = "label2";
            label2.Size = new Size(82, 25);
            label2.TabIndex = 1;
            label2.Text = "Surname";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 192);
            label3.Name = "label3";
            label3.Size = new Size(49, 25);
            label3.TabIndex = 2;
            label3.Text = "AFM";
            // 
            // TextBoxName
            // 
            TextBoxName.Location = new Point(128, 51);
            TextBoxName.Name = "TextBoxName";
            TextBoxName.Size = new Size(229, 31);
            TextBoxName.TabIndex = 3;
            // 
            // TextBoxAfm
            // 
            TextBoxAfm.Location = new Point(128, 186);
            TextBoxAfm.Name = "TextBoxAfm";
            TextBoxAfm.Size = new Size(229, 31);
            TextBoxAfm.TabIndex = 4;
            // 
            // TextBoxSurname
            // 
            TextBoxSurname.Location = new Point(128, 120);
            TextBoxSurname.Name = "TextBoxSurname";
            TextBoxSurname.Size = new Size(229, 31);
            TextBoxSurname.TabIndex = 5;
            // 
            // TextBoxNameTo
            // 
            TextBoxNameTo.Location = new Point(439, 54);
            TextBoxNameTo.Name = "TextBoxNameTo";
            TextBoxNameTo.Size = new Size(229, 31);
            TextBoxNameTo.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(387, 57);
            label4.Name = "label4";
            label4.Size = new Size(29, 25);
            label4.TabIndex = 7;
            label4.Text = "to";
            // 
            // ButtonClFilter
            // 
            ButtonClFilter.BackColor = Color.LightSteelBlue;
            ButtonClFilter.Location = new Point(279, 368);
            ButtonClFilter.Name = "ButtonClFilter";
            ButtonClFilter.Size = new Size(137, 42);
            ButtonClFilter.TabIndex = 8;
            ButtonClFilter.Text = "Clear Filter";
            ButtonClFilter.UseVisualStyleBackColor = false;
            ButtonClFilter.Click += ButtonClFilter_Click;
            // 
            // ButtonOk
            // 
            ButtonOk.BackColor = Color.LightSteelBlue;
            ButtonOk.Location = new Point(150, 368);
            ButtonOk.Name = "ButtonOk";
            ButtonOk.Size = new Size(94, 42);
            ButtonOk.TabIndex = 9;
            ButtonOk.Text = "Ok";
            ButtonOk.UseVisualStyleBackColor = false;
            ButtonOk.Click += ButtonOk_Click;
            // 
            // ButtonCancel
            // 
            ButtonCancel.BackColor = Color.Brown;
            ButtonCancel.Location = new Point(461, 368);
            ButtonCancel.Name = "ButtonCancel";
            ButtonCancel.Size = new Size(94, 42);
            ButtonCancel.TabIndex = 10;
            ButtonCancel.Text = "Cancel";
            ButtonCancel.UseVisualStyleBackColor = false;
            ButtonCancel.Click += ButtonCancel_Click;
            // 
            // CustomerFilter
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(694, 459);
            Controls.Add(ButtonCancel);
            Controls.Add(ButtonOk);
            Controls.Add(ButtonClFilter);
            Controls.Add(label4);
            Controls.Add(TextBoxNameTo);
            Controls.Add(TextBoxSurname);
            Controls.Add(TextBoxAfm);
            Controls.Add(TextBoxName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CustomerFilter";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Filter Customer";
            Shown += CustomerFilter_Shown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox TextBoxName;
        private TextBox TextBoxAfm;
        private TextBox TextBoxSurname;
        private TextBox TextBoxNameTo;
        private Label label4;
        private Button ButtonClFilter;
        private Button ButtonOk;
        private Button ButtonCancel;
    }
}