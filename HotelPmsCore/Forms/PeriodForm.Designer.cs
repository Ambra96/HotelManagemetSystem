namespace HotelPmsCore.Forms
{
    partial class PeriodForm
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
            dataGridViewPeriod = new DataGridView();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            startDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            endDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            periodBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridViewPeriod).BeginInit();
            ((System.ComponentModel.ISupportInitialize)periodBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewPeriod
            // 
            dataGridViewPeriod.AutoGenerateColumns = false;
            dataGridViewPeriod.BackgroundColor = Color.MintCream;
            dataGridViewPeriod.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPeriod.Columns.AddRange(new DataGridViewColumn[] { nameDataGridViewTextBoxColumn, startDateDataGridViewTextBoxColumn, endDateDataGridViewTextBoxColumn });
            dataGridViewPeriod.DataSource = periodBindingSource;
            dataGridViewPeriod.Location = new Point(12, 12);
            dataGridViewPeriod.Name = "dataGridViewPeriod";
            dataGridViewPeriod.RowHeadersWidth = 62;
            dataGridViewPeriod.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewPeriod.Size = new Size(1449, 647);
            dataGridViewPeriod.TabIndex = 0;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            startDateDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
            startDateDataGridViewTextBoxColumn.HeaderText = "StartDate";
            startDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            // 
            // endDateDataGridViewTextBoxColumn
            // 
            endDateDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            endDateDataGridViewTextBoxColumn.DataPropertyName = "EndDate";
            endDateDataGridViewTextBoxColumn.HeaderText = "EndDate";
            endDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            endDateDataGridViewTextBoxColumn.Name = "endDateDataGridViewTextBoxColumn";
            // 
            // periodBindingSource
            // 
            periodBindingSource.DataSource = typeof(Models.Period);
            // 
            // PeriodForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 55, 55);
            ClientSize = new Size(1473, 671);
            Controls.Add(dataGridViewPeriod);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PeriodForm";
            Text = "Period";
            ((System.ComponentModel.ISupportInitialize)dataGridViewPeriod).EndInit();
            ((System.ComponentModel.ISupportInitialize)periodBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewPeriod;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
        private BindingSource periodBindingSource;
    }
}