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
            dateTimePickerEnd.Location = new Point(385, 220);
            dateTimePickerEnd.Name = "dateTimePickerEnd";
            dateTimePickerEnd.ShowCheckBox = true;
            dateTimePickerEnd.Size = new Size(230, 31);
            dateTimePickerEnd.TabIndex = 21;
            // 
            // dateTimePickerStart
            // 
            dateTimePickerStart.Location = new Point(385, 133);
            dateTimePickerStart.Name = "dateTimePickerStart";
            dateTimePickerStart.ShowCheckBox = true;
            dateTimePickerStart.Size = new Size(230, 31);
            dateTimePickerStart.TabIndex = 20;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(385, 52);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(230, 31);
            textBoxName.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(131, 220);
            label3.Name = "label3";
            label3.Size = new Size(83, 25);
            label3.TabIndex = 18;
            label3.Text = "EndDate:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(131, 133);
            label2.Name = "label2";
            label2.Size = new Size(89, 25);
            label2.TabIndex = 17;
            label2.Text = "StartDate:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(131, 52);
            label1.Name = "label1";
            label1.Size = new Size(63, 25);
            label1.TabIndex = 16;
            label1.Text = "Name:";
            // 
            // ButtonCancel
            // 
            ButtonCancel.Location = new Point(466, 350);
            ButtonCancel.Name = "ButtonCancel";
            ButtonCancel.Size = new Size(95, 37);
            ButtonCancel.TabIndex = 24;
            ButtonCancel.Text = "Cancel";
            ButtonCancel.UseVisualStyleBackColor = true;
            ButtonCancel.Click += ButtonCancel_Click;
            // 
            // ButtonOk
            // 
            ButtonOk.Location = new Point(180, 350);
            ButtonOk.Name = "ButtonOk";
            ButtonOk.Size = new Size(58, 37);
            ButtonOk.TabIndex = 23;
            ButtonOk.Text = "Ok";
            ButtonOk.UseVisualStyleBackColor = true;
            ButtonOk.Click += ButtonOk_Click;
            // 
            // ButtonClFilter
            // 
            ButtonClFilter.Location = new Point(268, 350);
            ButtonClFilter.Name = "ButtonClFilter";
            ButtonClFilter.Size = new Size(174, 36);
            ButtonClFilter.TabIndex = 22;
            ButtonClFilter.Text = "Clear Filter";
            ButtonClFilter.UseVisualStyleBackColor = true;
            ButtonClFilter.Click += ButtonClFilter_Click;
            // 
            // PeriodFilter
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ButtonCancel);
            Controls.Add(ButtonOk);
            Controls.Add(ButtonClFilter);
            Controls.Add(dateTimePickerEnd);
            Controls.Add(dateTimePickerStart);
            Controls.Add(textBoxName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "PeriodFilter";
            Text = "PeriodFilter";
            //Load += PeriodFilter_Load;
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