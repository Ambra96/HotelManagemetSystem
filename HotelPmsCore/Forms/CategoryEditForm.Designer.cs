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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryEditForm));
            txtId = new TextBox();
            txtDescription = new TextBox();
            SaveBttn = new Button();
            CancelBttn = new Button();
            typedCategoryBindingSource = new BindingSource(components);
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            comboType = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)typedCategoryBindingSource).BeginInit();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Location = new Point(324, 86);
            txtId.Margin = new Padding(4, 5, 4, 5);
            txtId.Name = "txtId";
            txtId.Size = new Size(220, 31);
            txtId.TabIndex = 0;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(324, 147);
            txtDescription.Margin = new Padding(4, 5, 4, 5);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(220, 31);
            txtDescription.TabIndex = 1;
            // 
            // SaveBttn
            // 
            SaveBttn.BackColor = Color.LightSteelBlue;
            SaveBttn.Location = new Point(190, 322);
            SaveBttn.Margin = new Padding(4, 5, 4, 5);
            SaveBttn.Name = "SaveBttn";
            SaveBttn.Size = new Size(94, 42);
            SaveBttn.TabIndex = 2;
            SaveBttn.Text = "Save";
            SaveBttn.UseVisualStyleBackColor = false;
            SaveBttn.Click += SaveBttn_Click;
            // 
            // CancelBttn
            // 
            CancelBttn.BackColor = Color.Brown;
            CancelBttn.Location = new Point(378, 322);
            CancelBttn.Margin = new Padding(4, 5, 4, 5);
            CancelBttn.Name = "CancelBttn";
            CancelBttn.Size = new Size(94, 42);
            CancelBttn.TabIndex = 3;
            CancelBttn.Text = "Cancel";
            CancelBttn.UseVisualStyleBackColor = false;
            CancelBttn.Click += CancelBttn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(131, 86);
            label1.Name = "label1";
            label1.Size = new Size(30, 25);
            label1.TabIndex = 4;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(131, 147);
            label2.Name = "label2";
            label2.Size = new Size(102, 25);
            label2.TabIndex = 5;
            label2.Text = "Description";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(131, 212);
            label3.Name = "label3";
            label3.Size = new Size(49, 25);
            label3.TabIndex = 6;
            label3.Text = "Type";
            // 
            // comboType
            // 
            comboType.FormattingEnabled = true;
            comboType.Location = new Point(324, 212);
            comboType.Name = "comboType";
            comboType.Size = new Size(220, 33);
            comboType.TabIndex = 7;
            // 
            // CategoryEditForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(694, 459);
            Controls.Add(comboType);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(CancelBttn);
            Controls.Add(SaveBttn);
            Controls.Add(txtDescription);
            Controls.Add(txtId);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CategoryEditForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "New/Edit Category";
            ((System.ComponentModel.ISupportInitialize)typedCategoryBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private BindingSource typedCategoryBindingSource;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox comboType;
        //private TextBox txtDescription;
        //private NumericUpDown numType;   
        //private Button btnSave;
        //private Button btnCancel;
    }
}
