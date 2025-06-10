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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryFilter));
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
            label1.Location = new Point(275, 70);
            label1.Name = "label1";
            label1.Size = new Size(102, 25);
            label1.TabIndex = 0;
            label1.Text = "Description";
            // 
            // textBoxDesc
            // 
            textBoxDesc.Location = new Point(190, 140);
            textBoxDesc.Name = "textBoxDesc";
            textBoxDesc.Size = new Size(284, 31);
            textBoxDesc.TabIndex = 1;
            // 
            // ButtonCancel
            // 
            ButtonCancel.BackColor = Color.Brown;
            ButtonCancel.Location = new Point(447, 294);
            ButtonCancel.Name = "ButtonCancel";
            ButtonCancel.Size = new Size(94, 42);
            ButtonCancel.TabIndex = 13;
            ButtonCancel.Text = "Cancel";
            ButtonCancel.UseVisualStyleBackColor = false;
            ButtonCancel.Click += ButtonCancel_Click_1;
            // 
            // ButtonOk
            // 
            ButtonOk.BackColor = Color.LightSteelBlue;
            ButtonOk.Location = new Point(114, 295);
            ButtonOk.Name = "ButtonOk";
            ButtonOk.Size = new Size(94, 42);
            ButtonOk.TabIndex = 12;
            ButtonOk.Text = "Ok";
            ButtonOk.UseVisualStyleBackColor = false;
            ButtonOk.Click += ButtonOk_Click_1;
            // 
            // ButtonClFilter
            // 
            ButtonClFilter.BackColor = Color.LightSteelBlue;
            ButtonClFilter.Location = new Point(261, 294);
            ButtonClFilter.Name = "ButtonClFilter";
            ButtonClFilter.Size = new Size(137, 42);
            ButtonClFilter.TabIndex = 11;
            ButtonClFilter.Text = "Clear Filter";
            ButtonClFilter.UseVisualStyleBackColor = false;
            ButtonClFilter.Click += ButtonClFilter_Click_1;
            // 
            // CategoryFilter
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(694, 459);
            Controls.Add(ButtonCancel);
            Controls.Add(ButtonOk);
            Controls.Add(ButtonClFilter);
            Controls.Add(textBoxDesc);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CategoryFilter";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Filter Category";
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