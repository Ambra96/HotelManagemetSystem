﻿namespace HotelPmsCore.Forms
{
    partial class PeriodEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PeriodEditForm));
            dateTimePickerEnd = new DateTimePicker();
            dateTimePickerStart = new DateTimePicker();
            textBoxName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            Savebutton = new Button();
            Cancelbutton = new Button();
            bindingSourcePeriod = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)bindingSourcePeriod).BeginInit();
            SuspendLayout();
            // 
            // dateTimePickerEnd
            // 
            dateTimePickerEnd.Location = new Point(293, 225);
            dateTimePickerEnd.Name = "dateTimePickerEnd";
            dateTimePickerEnd.Size = new Size(230, 31);
            dateTimePickerEnd.TabIndex = 15;
            // 
            // dateTimePickerStart
            // 
            dateTimePickerStart.Location = new Point(293, 138);
            dateTimePickerStart.Name = "dateTimePickerStart";
            dateTimePickerStart.Size = new Size(230, 31);
            dateTimePickerStart.TabIndex = 14;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(293, 57);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(230, 31);
            textBoxName.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(138, 225);
            label3.Name = "label3";
            label3.Size = new Size(79, 25);
            label3.TabIndex = 12;
            label3.Text = "EndDate";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(138, 138);
            label2.Name = "label2";
            label2.Size = new Size(85, 25);
            label2.TabIndex = 11;
            label2.Text = "StartDate";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(138, 57);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 10;
            label1.Text = "Name";
            // 
            // Savebutton
            // 
            Savebutton.BackColor = Color.LightSteelBlue;
            Savebutton.Location = new Point(181, 353);
            Savebutton.Name = "Savebutton";
            Savebutton.Size = new Size(94, 42);
            Savebutton.TabIndex = 16;
            Savebutton.Text = "Save";
            Savebutton.UseVisualStyleBackColor = false;
            Savebutton.Click += Savebutton_Click;
            // 
            // Cancelbutton
            // 
            Cancelbutton.BackColor = Color.Brown;
            Cancelbutton.Location = new Point(392, 353);
            Cancelbutton.Name = "Cancelbutton";
            Cancelbutton.Size = new Size(94, 42);
            Cancelbutton.TabIndex = 17;
            Cancelbutton.Text = "Cancel";
            Cancelbutton.UseVisualStyleBackColor = false;
            Cancelbutton.Click += Cancelbutton_Click;
            // 
            // PeriodEditForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(694, 459);
            Controls.Add(Cancelbutton);
            Controls.Add(Savebutton);
            Controls.Add(dateTimePickerEnd);
            Controls.Add(dateTimePickerStart);
            Controls.Add(textBoxName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "PeriodEditForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "New/Edit Period";
            ((System.ComponentModel.ISupportInitialize)bindingSourcePeriod).EndInit();
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
        private Button Savebutton;
        private Button Cancelbutton;
        private BindingSource bindingSourcePeriod;
    }
}