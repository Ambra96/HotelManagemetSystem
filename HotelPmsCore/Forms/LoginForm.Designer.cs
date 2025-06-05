namespace HotelPmsCore
{
    partial class LoginForm
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
            backPicPanel = new Panel();
            CancelButton = new Button();
            loginlabel = new Label();
            LoginButton = new Button();
            passwordtext = new TextBox();
            usernametext = new TextBox();
            backPicPanel.SuspendLayout();
            SuspendLayout();
            // 
            // backPicPanel
            // 
            backPicPanel.BackColor = SystemColors.InactiveBorder;
            backPicPanel.Controls.Add(CancelButton);
            backPicPanel.Controls.Add(loginlabel);
            backPicPanel.Controls.Add(LoginButton);
            backPicPanel.Controls.Add(passwordtext);
            backPicPanel.Controls.Add(usernametext);
            backPicPanel.Location = new Point(-2, -4);
            backPicPanel.Name = "backPicPanel";
            backPicPanel.Size = new Size(639, 430);
            backPicPanel.TabIndex = 0;
            // 
            // CancelButton
            // 
            CancelButton.BackColor = Color.Brown;
            CancelButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            CancelButton.Location = new Point(346, 334);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(94, 42);
            CancelButton.TabIndex = 4;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = false;
            CancelButton.Click += CancelButton_Click;
            // 
            // loginlabel
            // 
            loginlabel.AutoSize = true;
            loginlabel.BackColor = Color.Transparent;
            loginlabel.Font = new Font("Times New Roman", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginlabel.ForeColor = Color.PowderBlue;
            loginlabel.Location = new Point(228, 13);
            loginlabel.Name = "loginlabel";
            loginlabel.Size = new Size(146, 51);
            loginlabel.TabIndex = 3;
            loginlabel.Text = "Log In";
            // 
            // LoginButton
            // 
            LoginButton.BackColor = Color.DarkGray;
            LoginButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            LoginButton.Location = new Point(177, 334);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(94, 42);
            LoginButton.TabIndex = 2;
            LoginButton.Text = "Log in";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Enter += LoginButton_Click;
            // 
            // passwordtext
            // 
            passwordtext.BackColor = Color.FromArgb(224, 224, 224);
            passwordtext.Location = new Point(177, 221);
            passwordtext.Name = "passwordtext";
            passwordtext.PasswordChar = '*';
            passwordtext.PlaceholderText = "Password";
            passwordtext.Size = new Size(263, 31);
            passwordtext.TabIndex = 1;
            // 
            // usernametext
            // 
            usernametext.BackColor = Color.FromArgb(224, 224, 224);
            usernametext.Location = new Point(177, 140);
            usernametext.Name = "usernametext";
            usernametext.PlaceholderText = "Username";
            usernametext.Size = new Size(263, 31);
            usernametext.TabIndex = 0;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(636, 426);
            Controls.Add(backPicPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            Load += LoginForm_Load;
            backPicPanel.ResumeLayout(false);
            backPicPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel backPicPanel;
        private TextBox usernametext;
        private TextBox passwordtext;
        private Button LoginButton;
        private Label loginlabel;
        private new Button CancelButton;
    }
}