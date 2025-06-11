using HotelPmsCore.Data;
using HotelPmsCore.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HotelPmsCore
{
    public partial class LoginForm : Form
    {
        private readonly HotelPmsCoreContext context;

        public int UserRoleId { get; set; }
        public LoginForm(Data.HotelPmsCoreContext context)
        {
            InitializeComponent();
            //this.AcceptButton = LoginButton;
            //this.CancelButton = CancelButton;
            this.context = context;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            var username = usernametext.Text.Trim();
            var plain = passwordtext.Text;

        
            var user = context.Users
                              .SingleOrDefault(u => u.Username == username);
            if (user == null)
            {
                MessageBox.Show("Invalid username or password");
                return;
            }

            using var hasher = new Argon2();
            bool isValid = false;

            try
            {

                isValid = hasher.VerifyPassword(plain, user.Password);
            }
            catch (FormatException)
            {

                if (user.Password == plain)
                {
                    isValid = true;

                    user.Password = hasher.HashPassword(plain);
                    context.SaveChanges();
                }
            }

            if (isValid)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
        }



        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();

        }
    }
}

