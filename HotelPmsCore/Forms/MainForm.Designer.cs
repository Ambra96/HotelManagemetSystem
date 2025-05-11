namespace HotelPmsCore.Forms
{
    partial class MainForm
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

     
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            MainPanel = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            button_rooms = new Button();
            button_categories = new Button();
            button_users = new Button();
            button_customers = new Button();
            button_period = new Button();
            button_logout = new Button();
            ButtonPanel = new Panel();
            EditButton = new Button();
            DeleteButton = new Button();
            ExitButton = new Button();
            NewButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ButtonPanel.SuspendLayout();
            SuspendLayout();
            // 
            // MainPanel
            // 
            MainPanel.BackColor = Color.WhiteSmoke;
            MainPanel.Location = new Point(204, 133);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(1495, 755);
            MainPanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.hotel_logo;
            pictureBox1.Location = new Point(12, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(186, 161);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 28F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.PowderBlue;
            label1.Location = new Point(587, 20);
            label1.Name = "label1";
            label1.Size = new Size(562, 74);
            label1.TabIndex = 2;
            label1.Text = "Hotel Management";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // button_rooms
            // 
            button_rooms.BackColor = Color.FromArgb(49, 55, 55);
            button_rooms.BackgroundImageLayout = ImageLayout.Center;
            button_rooms.Cursor = Cursors.Hand;
            button_rooms.FlatAppearance.BorderSize = 0;
            button_rooms.FlatStyle = FlatStyle.Flat;
            button_rooms.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_rooms.ForeColor = Color.White;
            button_rooms.Image = Properties.Resources.room;
            button_rooms.ImageAlign = ContentAlignment.TopCenter;
            button_rooms.Location = new Point(2, 208);
            button_rooms.Name = "button_rooms";
            button_rooms.Size = new Size(196, 96);
            button_rooms.TabIndex = 3;
            button_rooms.Text = "Rooms";
            button_rooms.TextAlign = ContentAlignment.BottomCenter;
            button_rooms.UseVisualStyleBackColor = false;
            button_rooms.Click += button_rooms_Click;
            // 
            // button_categories
            // 
            button_categories.BackColor = Color.FromArgb(49, 55, 55);
            button_categories.BackgroundImageLayout = ImageLayout.None;
            button_categories.FlatAppearance.BorderSize = 0;
            button_categories.FlatStyle = FlatStyle.Flat;
            button_categories.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_categories.ForeColor = Color.White;
            button_categories.Image = Properties.Resources.category;
            button_categories.ImageAlign = ContentAlignment.TopCenter;
            button_categories.Location = new Point(2, 315);
            button_categories.Name = "button_categories";
            button_categories.Size = new Size(196, 96);
            button_categories.TabIndex = 4;
            button_categories.Text = "Categories";
            button_categories.TextAlign = ContentAlignment.BottomCenter;
            button_categories.TextImageRelation = TextImageRelation.ImageAboveText;
            button_categories.UseVisualStyleBackColor = false;
            button_categories.Click += button_categories_Click;
            // 
            // button_users
            // 
            button_users.BackColor = Color.FromArgb(49, 55, 55);
            button_users.FlatAppearance.BorderSize = 0;
            button_users.FlatStyle = FlatStyle.Flat;
            button_users.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            button_users.ForeColor = Color.White;
            button_users.Image = Properties.Resources.user;
            button_users.ImageAlign = ContentAlignment.TopCenter;
            button_users.Location = new Point(2, 563);
            button_users.Name = "button_users";
            button_users.Size = new Size(196, 96);
            button_users.TabIndex = 6;
            button_users.Text = "Users";
            button_users.TextAlign = ContentAlignment.BottomCenter;
            button_users.UseVisualStyleBackColor = false;
            // 
            // button_customers
            // 
            button_customers.BackColor = Color.FromArgb(49, 55, 55);
            button_customers.FlatAppearance.BorderSize = 0;
            button_customers.FlatStyle = FlatStyle.Flat;
            button_customers.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            button_customers.ForeColor = Color.White;
            button_customers.Image = Properties.Resources.customer;
            button_customers.ImageAlign = ContentAlignment.TopCenter;
            button_customers.Location = new Point(2, 435);
            button_customers.Name = "button_customers";
            button_customers.Size = new Size(196, 96);
            button_customers.TabIndex = 5;
            button_customers.Text = "Customers";
            button_customers.TextAlign = ContentAlignment.BottomCenter;
            button_customers.UseVisualStyleBackColor = false;
            button_customers.Click += button_customers_Click;
            // 
            // button_period
            // 
            button_period.BackColor = Color.FromArgb(49, 55, 55);
            button_period.FlatAppearance.BorderSize = 0;
            button_period.FlatStyle = FlatStyle.Flat;
            button_period.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            button_period.ForeColor = Color.White;
            button_period.Image = (Image)resources.GetObject("button_period.Image");
            button_period.ImageAlign = ContentAlignment.TopCenter;
            button_period.Location = new Point(2, 683);
            button_period.Name = "button_period";
            button_period.Size = new Size(196, 96);
            button_period.TabIndex = 7;
            button_period.Text = "Period";
            button_period.TextAlign = ContentAlignment.BottomCenter;
            button_period.UseVisualStyleBackColor = false;
            // 
            // button_logout
            // 
            button_logout.BackColor = Color.FromArgb(49, 55, 55);
            button_logout.FlatAppearance.BorderSize = 2;
            button_logout.FlatStyle = FlatStyle.Flat;
            button_logout.Font = new Font("Bahnschrift", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_logout.ForeColor = Color.SteelBlue;
            button_logout.Image = (Image)resources.GetObject("button_logout.Image");
            button_logout.Location = new Point(2, 876);
            button_logout.Name = "button_logout";
            button_logout.Size = new Size(196, 63);
            button_logout.TabIndex = 8;
            button_logout.Text = "LogOut";
            button_logout.TextAlign = ContentAlignment.MiddleLeft;
            button_logout.TextImageRelation = TextImageRelation.TextBeforeImage;
            button_logout.UseVisualStyleBackColor = false;
            button_logout.Click += button_logout_Click;
            // 
            // ButtonPanel
            // 
            ButtonPanel.BackColor = Color.Transparent;
            ButtonPanel.Controls.Add(EditButton);
            ButtonPanel.Controls.Add(DeleteButton);
            ButtonPanel.Controls.Add(ExitButton);
            ButtonPanel.Controls.Add(NewButton);
            ButtonPanel.Location = new Point(204, 894);
            ButtonPanel.Name = "ButtonPanel";
            ButtonPanel.Size = new Size(1492, 60);
            ButtonPanel.TabIndex = 9;
            // 
            // EditButton
            // 
            EditButton.BackColor = Color.LightSkyBlue;
            EditButton.Location = new Point(581, 4);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(92, 41);
            EditButton.TabIndex = 1;
            EditButton.Text = "Edit";
            EditButton.UseVisualStyleBackColor = false;
            EditButton.Click += EditButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.BackColor = Color.LightSkyBlue;
            DeleteButton.Location = new Point(811, 4);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(92, 41);
            DeleteButton.TabIndex = 2;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = false;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.BackColor = Color.LightSkyBlue;
            ExitButton.Location = new Point(1041, 4);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(92, 41);
            ExitButton.TabIndex = 3;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = false;
            ExitButton.Click += ExitButton_Click;
            // 
            // NewButton
            // 
            NewButton.BackColor = Color.LightSkyBlue;
            NewButton.Location = new Point(351, 4);
            NewButton.Name = "NewButton";
            NewButton.Size = new Size(92, 41);
            NewButton.TabIndex = 0;
            NewButton.Text = "New";
            NewButton.UseVisualStyleBackColor = false;
            NewButton.Click += NewButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 55, 55);
            ClientSize = new Size(1697, 951);
            Controls.Add(ButtonPanel);
            Controls.Add(button_logout);
            Controls.Add(button_period);
            Controls.Add(button_users);
            Controls.Add(button_customers);
            Controls.Add(button_categories);
            Controls.Add(button_rooms);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(MainPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ButtonPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel MainPanel;
        private PictureBox pictureBox1;
        private Label label1;
        private Button button_rooms;
        private Button button_categories;
        private Button button_users;
        private Button button_customers;
        private Button button_period;
        private Button button_logout;
        private Panel ButtonPanel;
        private Button NewButton;
        private Button EditButton;
        private Button DeleteButton;
        private Button ExitButton;
    }
}