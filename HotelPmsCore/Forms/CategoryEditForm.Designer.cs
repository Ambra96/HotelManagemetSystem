namespace HotelPmsCore.Forms
{
    partial class CategoryEditForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox TxtDesc;
        private System.Windows.Forms.TextBox TxtType;
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
            TxtDesc = new TextBox();
            TxtType = new TextBox();
            SaveBttn = new Button();
            CancelBttn = new Button();
            categoryBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource).BeginInit();
            SuspendLayout();
            // 
            // TxtDesc
            // 
            TxtDesc.Location = new Point(62, 47);
            TxtDesc.Margin = new Padding(4, 5, 4, 5);
            TxtDesc.Name = "TxtDesc";
            TxtDesc.PlaceholderText = "Id";
            TxtDesc.Size = new Size(124, 31);
            TxtDesc.TabIndex = 0;
            // 
            // TxtType
            // 
            TxtType.Location = new Point(62, 109);
            TxtType.Margin = new Padding(4, 5, 4, 5);
            TxtType.Name = "TxtType";
            TxtType.PlaceholderText = "Description";
            TxtType.Size = new Size(220, 31);
            TxtType.TabIndex = 1;
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
            SaveBttn.Click += SaveBttn_Click;
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
            CancelBttn.Click += CancelBttn_Click;
            // 
            // CategoryEditForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 280);
            Controls.Add(CancelBttn);
            Controls.Add(SaveBttn);
            Controls.Add(TxtType);
            Controls.Add(TxtDesc);
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
