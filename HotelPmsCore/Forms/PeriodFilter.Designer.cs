namespace HotelPmsCore.Forms
{
    partial class PeriodFilter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PeriodFilter));
            dateTimePickerEnd = new DateTimePicker();
            dateTimePickerStart = new DateTimePicker();
            textBoxName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ButtonCancel = new Button();
            ButtonOk = new Button();
            ButtonClFilter = new Button();
            SuspendLayout();
            // 
            // dateTimePickerEnd
            // 
            dateTimePickerEnd.Location = new Point(309, 219);
            dateTimePickerEnd.Name = "dateTimePickerEnd";
            dateTimePickerEnd.ShowCheckBox = true;
            dateTimePickerEnd.Size = new Size(230, 31);
            dateTimePickerEnd.TabIndex = 21;
            // 
            // dateTimePickerStart
            // 
            dateTimePickerStart.Location = new Point(309, 132);
            dateTimePickerStart.Name = "dateTimePickerStart";
            dateTimePickerStart.ShowCheckBox = true;
            dateTimePickerStart.Size = new Size(230, 31);
            dateTimePickerStart.TabIndex = 20;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(309, 51);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(230, 31);
            textBoxName.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(129, 219);
            label3.Name = "label3";
            label3.Size = new Size(79, 25);
            label3.TabIndex = 18;
            label3.Text = "EndDate";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(129, 132);
            label2.Name = "label2";
            label2.Size = new Size(85, 25);
            label2.TabIndex = 17;
            label2.Text = "StartDate";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(129, 51);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 16;
            label1.Text = "Name";
            // 
            // ButtonCancel
            // 
            ButtonCancel.BackColor = Color.Brown;
            ButtonCancel.Location = new Point(438, 335);
            ButtonCancel.Name = "ButtonCancel";
            ButtonCancel.Size = new Size(94, 42);
            ButtonCancel.TabIndex = 24;
            ButtonCancel.Text = "Cancel";
            ButtonCancel.UseVisualStyleBackColor = false;
            ButtonCancel.Click += ButtonCancel_Click;
            // 
            // ButtonOk
            // 
            ButtonOk.BackColor = Color.LightSteelBlue;
            ButtonOk.Location = new Point(137, 335);
            ButtonOk.Name = "ButtonOk";
            ButtonOk.Size = new Size(94, 42);
            ButtonOk.TabIndex = 23;
            ButtonOk.Text = "Ok";
            ButtonOk.UseVisualStyleBackColor = false;
            ButtonOk.Click += ButtonOk_Click;
            // 
            // ButtonClFilter
            // 
            ButtonClFilter.BackColor = Color.LightSteelBlue;
            ButtonClFilter.Location = new Point(265, 335);
            ButtonClFilter.Name = "ButtonClFilter";
            ButtonClFilter.Size = new Size(137, 42);
            ButtonClFilter.TabIndex = 22;
            ButtonClFilter.Text = "Clear Filter";
            ButtonClFilter.UseVisualStyleBackColor = false;
            ButtonClFilter.Click += ButtonClFilter_Click;
            // 
            // PeriodFilter
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(694, 459);
            Controls.Add(ButtonCancel);
            Controls.Add(ButtonOk);
            Controls.Add(ButtonClFilter);
            Controls.Add(dateTimePickerEnd);
            Controls.Add(dateTimePickerStart);
            Controls.Add(textBoxName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "PeriodFilter";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Filter Period";
            Shown += PeriodFilter_Shown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePickerEnd;
        private DateTimePicker dateTimePickerStart;
        private TextBox textBoxName;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button ButtonCancel;
        private Button ButtonOk;
        private Button ButtonClFilter;
    }
}