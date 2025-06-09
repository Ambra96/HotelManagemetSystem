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
            settingsPanel = new Panel();
            settingsContentPanel = new Panel();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            menuItemPeriods = new ToolStripMenuItem();
            menuItemCategories = new ToolStripMenuItem();
            menuItemUsers = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            button_rooms = new Button();
            button_staff = new Button();
            button_settings = new Button();
            button_customers = new Button();
            button_reservations = new Button();
            button_logout = new Button();
            ButtonPanel = new Panel();
            BttnFilters = new Button();
            EditButton = new Button();
            DeleteButton = new Button();
            ExitButton = new Button();
            NewButton = new Button();
            MainPanel.SuspendLayout();
            settingsPanel.SuspendLayout();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ButtonPanel.SuspendLayout();
            SuspendLayout();
            // 
            // MainPanel
            // 
            MainPanel.Anchor = AnchorStyles.None;
            MainPanel.BackColor = Color.WhiteSmoke;
            MainPanel.Controls.Add(settingsPanel);
            MainPanel.Location = new Point(207, 196);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(1492, 692);
            MainPanel.TabIndex = 0;
            // 
            // settingsPanel
            // 
            settingsPanel.BackColor = Color.LightGray;
            settingsPanel.Controls.Add(settingsContentPanel);
            settingsPanel.Controls.Add(toolStrip1);
            settingsPanel.Location = new Point(3, 0);
            settingsPanel.Name = "settingsPanel";
            settingsPanel.Size = new Size(1489, 752);
            settingsPanel.TabIndex = 0;
            settingsPanel.Leave += settingsPanel_Leave;
            // 
            // settingsContentPanel
            // 
            settingsContentPanel.Dock = DockStyle.Fill;
            settingsContentPanel.Location = new Point(0, 33);
            settingsContentPanel.Name = "settingsContentPanel";
            settingsContentPanel.Size = new Size(1489, 719);
            settingsContentPanel.TabIndex = 1;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripDropDownButton1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1489, 33);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(34, 28);
            toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { menuItemPeriods, menuItemCategories, menuItemUsers });
            toolStripDropDownButton1.Image = (Image)resources.GetObject("toolStripDropDownButton1.Image");
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new Size(42, 28);
            toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // menuItemPeriods
            // 
            menuItemPeriods.Name = "menuItemPeriods";
            menuItemPeriods.Size = new Size(198, 34);
            menuItemPeriods.Text = "Periods";
            menuItemPeriods.Click += menuItemPeriods_Click;
            // 
            // menuItemCategories
            // 
            menuItemCategories.Name = "menuItemCategories";
            menuItemCategories.Size = new Size(198, 34);
            menuItemCategories.Text = "Categories";
            menuItemCategories.Click += menuItemCategories_Click;
            // 
            // menuItemUsers
            // 
            menuItemUsers.Name = "menuItemUsers";
            menuItemUsers.Size = new Size(198, 34);
            menuItemUsers.Text = "Users";
            menuItemUsers.Click += menuItemUsers_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
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
            label1.Anchor = AnchorStyles.None;
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
            button_rooms.Anchor = AnchorStyles.None;
            button_rooms.BackColor = Color.FromArgb(49, 55, 55);
            button_rooms.BackgroundImageLayout = ImageLayout.Center;
            button_rooms.Cursor = Cursors.Hand;
            button_rooms.FlatAppearance.BorderSize = 0;
            button_rooms.FlatStyle = FlatStyle.Flat;
            button_rooms.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_rooms.ForeColor = Color.White;
            button_rooms.Image = Properties.Resources.room;
            button_rooms.ImageAlign = ContentAlignment.TopCenter;
            button_rooms.Location = new Point(2, 328);
            button_rooms.Name = "button_rooms";
            button_rooms.Size = new Size(196, 96);
            button_rooms.TabIndex = 3;
            button_rooms.Text = "Rooms";
            button_rooms.TextAlign = ContentAlignment.BottomCenter;
            button_rooms.UseVisualStyleBackColor = false;
            button_rooms.Click += button_rooms_Click;
            // 
            // button_staff
            // 
            button_staff.Anchor = AnchorStyles.None;
            button_staff.BackColor = Color.FromArgb(49, 55, 55);
            button_staff.BackgroundImageLayout = ImageLayout.None;
            button_staff.FlatAppearance.BorderSize = 0;
            button_staff.FlatStyle = FlatStyle.Flat;
            button_staff.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_staff.ForeColor = Color.White;
            button_staff.Image = Properties.Resources.category;
            button_staff.ImageAlign = ContentAlignment.TopCenter;
            button_staff.Location = new Point(2, 569);
            button_staff.Name = "button_staff";
            button_staff.Size = new Size(196, 96);
            button_staff.TabIndex = 4;
            button_staff.Text = "Staff";
            button_staff.TextAlign = ContentAlignment.BottomCenter;
            button_staff.TextImageRelation = TextImageRelation.ImageAboveText;
            button_staff.UseVisualStyleBackColor = false;
            button_staff.Click += button_staff_Click;
            // 
            // button_settings
            // 
            button_settings.Anchor = AnchorStyles.None;
            button_settings.BackColor = Color.FromArgb(49, 55, 55);
            button_settings.FlatAppearance.BorderSize = 0;
            button_settings.FlatStyle = FlatStyle.Flat;
            button_settings.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            button_settings.ForeColor = Color.White;
            button_settings.Image = (Image)resources.GetObject("button_settings.Image");
            button_settings.ImageAlign = ContentAlignment.TopCenter;
            button_settings.Location = new Point(2, 699);
            button_settings.Name = "button_settings";
            button_settings.Size = new Size(196, 96);
            button_settings.TabIndex = 6;
            button_settings.Text = "Settings";
            button_settings.TextAlign = ContentAlignment.BottomCenter;
            button_settings.UseVisualStyleBackColor = false;
            button_settings.Click += button_settings_Click;
            // 
            // button_customers
            // 
            button_customers.Anchor = AnchorStyles.None;
            button_customers.BackColor = Color.FromArgb(49, 55, 55);
            button_customers.FlatAppearance.BorderSize = 0;
            button_customers.FlatStyle = FlatStyle.Flat;
            button_customers.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            button_customers.ForeColor = Color.White;
            button_customers.Image = Properties.Resources.customer;
            button_customers.ImageAlign = ContentAlignment.TopCenter;
            button_customers.Location = new Point(2, 211);
            button_customers.Name = "button_customers";
            button_customers.Size = new Size(196, 96);
            button_customers.TabIndex = 5;
            button_customers.Text = "Customers";
            button_customers.TextAlign = ContentAlignment.BottomCenter;
            button_customers.UseVisualStyleBackColor = false;
            button_customers.Click += button_customers_Click;
            // 
            // button_reservations
            // 
            button_reservations.Anchor = AnchorStyles.None;
            button_reservations.BackColor = Color.FromArgb(49, 55, 55);
            button_reservations.FlatAppearance.BorderSize = 0;
            button_reservations.FlatStyle = FlatStyle.Flat;
            button_reservations.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            button_reservations.ForeColor = Color.White;
            button_reservations.Image = (Image)resources.GetObject("button_reservations.Image");
            button_reservations.ImageAlign = ContentAlignment.TopCenter;
            button_reservations.Location = new Point(5, 453);
            button_reservations.Name = "button_reservations";
            button_reservations.Size = new Size(196, 96);
            button_reservations.TabIndex = 7;
            button_reservations.Text = "Reservations";
            button_reservations.TextAlign = ContentAlignment.BottomCenter;
            button_reservations.UseVisualStyleBackColor = false;
            button_reservations.Click += button_reservations_Click_1;
            // 
            // button_logout
            // 
            button_logout.Anchor = AnchorStyles.None;
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
            ButtonPanel.Controls.Add(BttnFilters);
            ButtonPanel.Controls.Add(EditButton);
            ButtonPanel.Controls.Add(DeleteButton);
            ButtonPanel.Controls.Add(ExitButton);
            ButtonPanel.Controls.Add(NewButton);
            ButtonPanel.Location = new Point(204, 894);
            ButtonPanel.Name = "ButtonPanel";
            ButtonPanel.Size = new Size(1492, 60);
            ButtonPanel.TabIndex = 9;
            // 
            // BttnFilters
            // 
            BttnFilters.BackColor = Color.LightSteelBlue;
            BttnFilters.Location = new Point(838, 4);
            BttnFilters.Name = "BttnFilters";
            BttnFilters.Size = new Size(92, 41);
            BttnFilters.TabIndex = 4;
            BttnFilters.Text = "Filters";
            BttnFilters.UseVisualStyleBackColor = false;
            BttnFilters.Click += BttnFilters_Click;
            // 
            // EditButton
            // 
            EditButton.Anchor = AnchorStyles.None;
            EditButton.BackColor = Color.LightSteelBlue;
            EditButton.Location = new Point(438, 4);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(92, 41);
            EditButton.TabIndex = 1;
            EditButton.Text = "Edit";
            EditButton.UseVisualStyleBackColor = false;
            EditButton.Click += EditButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Anchor = AnchorStyles.None;
            DeleteButton.BackColor = Color.LightSteelBlue;
            DeleteButton.Location = new Point(638, 4);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(92, 41);
            DeleteButton.TabIndex = 2;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = false;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Anchor = AnchorStyles.None;
            ExitButton.BackColor = Color.Brown;
            ExitButton.Location = new Point(1038, 4);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(92, 41);
            ExitButton.TabIndex = 3;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = false;
            ExitButton.Click += ExitButton_Click;
            // 
            // NewButton
            // 
            NewButton.Anchor = AnchorStyles.None;
            NewButton.BackColor = Color.LightSteelBlue;
            NewButton.Location = new Point(238, 4);
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
            Controls.Add(button_customers);
            Controls.Add(button_reservations);
            Controls.Add(button_settings);
            Controls.Add(ButtonPanel);
            Controls.Add(button_logout);
            Controls.Add(button_staff);
            Controls.Add(button_rooms);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(MainPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            MainPanel.ResumeLayout(false);
            settingsPanel.ResumeLayout(false);
            settingsPanel.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
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
        private Button button_staff;
        private Button button_settings;
        private Button button_customers;
        private Button button_reservations;
        private Button button_logout;
        private Panel ButtonPanel;
        private Button NewButton;
        private Button EditButton;
        private Button DeleteButton;
        private Button ExitButton;
        private Panel settingsPanel;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem menuItemPeriods;
        private ToolStripMenuItem menuItemCategories;
        private ToolStripMenuItem menuItemUsers;
        private Panel settingsContentPanel;
        private Button BttnFilters;

        public int NewBttn_Click { get; private set; }
    }
}