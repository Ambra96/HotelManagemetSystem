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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            mainpanel = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            button_rooms = new Button();
            button_categories = new Button();
            button_users = new Button();
            button_customers = new Button();
            button_staff = new Button();
            button_logout = new Button();
            bttnpanel = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // mainpanel
            // 
            mainpanel.BackColor = Color.WhiteSmoke;
            mainpanel.Location = new Point(204, 133);
            mainpanel.Name = "mainpanel";
            mainpanel.Size = new Size(1495, 727);
            mainpanel.TabIndex = 0;
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
            // button_staff
            // 
            button_staff.BackColor = Color.FromArgb(49, 55, 55);
            button_staff.FlatAppearance.BorderSize = 0;
            button_staff.FlatStyle = FlatStyle.Flat;
            button_staff.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            button_staff.ForeColor = Color.White;
            button_staff.Image = Properties.Resources.staff;
            button_staff.ImageAlign = ContentAlignment.TopCenter;
            button_staff.Location = new Point(2, 683);
            button_staff.Name = "button_staff";
            button_staff.Size = new Size(196, 96);
            button_staff.TabIndex = 7;
            button_staff.Text = "Staff";
            button_staff.TextAlign = ContentAlignment.BottomCenter;
            button_staff.UseVisualStyleBackColor = false;
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
            // 
            // bttnpanel
            // 
            bttnpanel.BackColor = Color.RosyBrown;
            bttnpanel.Location = new Point(204, 860);
            bttnpanel.Name = "bttnpanel";
            bttnpanel.Size = new Size(1492, 94);
            bttnpanel.TabIndex = 9;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 55, 55);
            ClientSize = new Size(1697, 951);
            Controls.Add(bttnpanel);
            Controls.Add(button_logout);
            Controls.Add(button_staff);
            Controls.Add(button_users);
            Controls.Add(button_customers);
            Controls.Add(button_categories);
            Controls.Add(button_rooms);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(mainpanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel mainpanel;
        private PictureBox pictureBox1;
        private Label label1;
        private Button button_rooms;
        private Button button_categories;
        private Button button_users;
        private Button button_customers;
        private Button button_staff;
        private Button button_logout;
        private Panel bttnpanel;
    }
}