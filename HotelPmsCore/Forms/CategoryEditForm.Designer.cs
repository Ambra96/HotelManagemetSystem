namespace HotelPmsCore.Forms
{
    partial class CategoryEditForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button SaveBttn;
        private System.Windows.Forms.Button CancelBttn;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            txtId = new TextBox();
            txtDescription = new TextBox();
            SaveBttn = new Button();
            CancelBttn = new Button();
            categoryBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource).BeginInit();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Location = new Point(62, 47);
            txtId.Margin = new Padding(4, 5, 4, 5);
            txtId.Name = "txtId";
            txtId.PlaceholderText = "Id";
            txtId.Size = new Size(124, 31);
            txtId.TabIndex = 0;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(62, 109);
            txtDescription.Margin = new Padding(4, 5, 4, 5);
            txtDescription.Name = "txtDescription";
            txtDescription.PlaceholderText = "Description";
            txtDescription.Size = new Size(220, 31);
            txtDescription.TabIndex = 1;
            // 
            // SaveBttn
            // 
            SaveBttn.Location = new Point(62, 172);
            SaveBttn.Margin = new Padding(4, 5, 4, 5);
            SaveBttn.Name = "SaveBttn";
            SaveBttn.Size = new Size(94, 47);
            SaveBttn.TabIndex = 2;
            SaveBttn.Text = "Save";
            SaveBttn.UseVisualStyleBackColor = true;
            // 
            // CancelBttn
            // 
            CancelBttn.Location = new Point(188, 172);
            CancelBttn.Margin = new Padding(4, 5, 4, 5);
            CancelBttn.Name = "CancelBttn";
            CancelBttn.Size = new Size(94, 47);
            CancelBttn.TabIndex = 3;
            CancelBttn.Text = "Cancel";
            CancelBttn.UseVisualStyleBackColor = true;
            // 
            // CategoryEditForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 280);
            Controls.Add(CancelBttn);
            Controls.Add(SaveBttn);
            Controls.Add(txtDescription);
            Controls.Add(txtId);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CategoryEditForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Edit Category";
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private BindingSource categoryBindingSource;
        //private TextBox txtDescription;
        //private NumericUpDown numType;   
        //private Button btnSave;
        //private Button btnCancel;
    }
}
