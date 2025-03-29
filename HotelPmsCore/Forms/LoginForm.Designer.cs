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
            checkboxrememberme = new CheckBox();
            cancelButton = new Button();
            loginlabel = new Label();
            loginButton = new Button();
            passwordtext = new TextBox();
            usernametext = new TextBox();
            backPicPanel.SuspendLayout();
            SuspendLayout();
            // 
            // backPicPanel
            // 
            backPicPanel.BackColor = SystemColors.InactiveBorder;
            backPicPanel.BackgroundImage = Properties.Resources.LoginBack;
            backPicPanel.Controls.Add(checkboxrememberme);
            backPicPanel.Controls.Add(cancelButton);
            backPicPanel.Controls.Add(loginlabel);
            backPicPanel.Controls.Add(loginButton);
            backPicPanel.Controls.Add(passwordtext);
            backPicPanel.Controls.Add(usernametext);
            backPicPanel.Location = new Point(-2, -4);
            backPicPanel.Name = "backPicPanel";
            backPicPanel.Size = new Size(639, 430);
            backPicPanel.TabIndex = 0;
            // 
            // checkboxrememberme
            // 
            checkboxrememberme.AutoSize = true;
            checkboxrememberme.BackColor = Color.Transparent;
            checkboxrememberme.Font = new Font("Calibri Light", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkboxrememberme.Location = new Point(177, 267);
            checkboxrememberme.Name = "checkboxrememberme";
            checkboxrememberme.Size = new Size(133, 23);
            checkboxrememberme.TabIndex = 5;
            checkboxrememberme.Text = "Remember me";
            checkboxrememberme.UseVisualStyleBackColor = false;
            // 
            // cancelButton
            // 
            cancelButton.BackColor = Color.Brown;
            cancelButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            cancelButton.Location = new Point(346, 334);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(94, 42);
            cancelButton.TabIndex = 4;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += cancelButton_Click;
            // 
            // loginlabel
            // 
            loginlabel.AutoSize = true;
            loginlabel.BackColor = Color.Transparent;
            loginlabel.Font = new Font("Times New Roman", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginlabel.ForeColor = SystemColors.ControlLightLight;
            loginlabel.Location = new Point(228, 13);
            loginlabel.Name = "loginlabel";
            loginlabel.Size = new Size(146, 51);
            loginlabel.TabIndex = 3;
            loginlabel.Text = "Log In";
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.DarkGray;
            loginButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            loginButton.Location = new Point(177, 334);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(94, 42);
            loginButton.TabIndex = 2;
            loginButton.Text = "Log in";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Enter += loginButton_Click;
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
        private Button loginButton;
        private Label loginlabel;
        private Button cancelButton;
        private CheckBox checkboxrememberme;
    }
}