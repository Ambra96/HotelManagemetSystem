namespace HotelPmsCore.Forms
{
    partial class CategoryFilter
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
            label1 = new Label();
            textBoxDesc = new TextBox();
            ButtonCancel = new Button();
            ButtonOk = new Button();
            ButtonClFilter = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(309, 80);
            label1.Name = "label1";
            label1.Size = new Size(102, 25);
            label1.TabIndex = 0;
            label1.Text = "Description";
            // 
            // textBoxDesc
            // 
            textBoxDesc.Location = new Point(224, 150);
            textBoxDesc.Name = "textBoxDesc";
            textBoxDesc.Size = new Size(284, 31);
            textBoxDesc.TabIndex = 1;
            // 
            // ButtonCancel
            // 
            ButtonCancel.Location = new Point(446, 319);
            ButtonCancel.Name = "ButtonCancel";
            ButtonCancel.Size = new Size(95, 37);
            ButtonCancel.TabIndex = 13;
            ButtonCancel.Text = "Cancel";
            ButtonCancel.UseVisualStyleBackColor = true;
            ButtonCancel.Click += ButtonCancel_Click_1;
            // 
            // ButtonOk
            // 
            ButtonOk.Location = new Point(160, 319);
            ButtonOk.Name = "ButtonOk";
            ButtonOk.Size = new Size(58, 37);
            ButtonOk.TabIndex = 12;
            ButtonOk.Text = "Ok";
            ButtonOk.UseVisualStyleBackColor = true;
            ButtonOk.Click += ButtonOk_Click_1;
            // 
            // ButtonClFilter
            // 
            ButtonClFilter.Location = new Point(248, 319);
            ButtonClFilter.Name = "ButtonClFilter";
            ButtonClFilter.Size = new Size(174, 36);
            ButtonClFilter.TabIndex = 11;
            ButtonClFilter.Text = "Clear Filter";
            ButtonClFilter.UseVisualStyleBackColor = true;
            ButtonClFilter.Click += ButtonClFilter_Click_1;
            // 
            // CategoryFilter
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ButtonCancel);
            Controls.Add(ButtonOk);
            Controls.Add(ButtonClFilter);
            Controls.Add(textBoxDesc);
            Controls.Add(label1);
            Name = "CategoryFilter";
            Text = "CategoryFilter";
            Load += CategoryFilter_Load;
            Shown += CategoryFilter_Shown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxDesc;
        private Button ButtonCancel;
        private Button ButtonOk;
        private Button ButtonClFilter;
    }
}