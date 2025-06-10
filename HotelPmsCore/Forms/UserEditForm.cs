using HotelPmsCore.Models;
using HotelPmsCore.Services;
using System;
using System.Windows.Forms;

namespace HotelPmsCore.Forms
{
    public partial class UserEditForm : Form
    {
        private readonly UserService svc;

        public UserEditForm(UserService svc)
        {
            InitializeComponent();
            this.svc = svc;
            this.userBindingSource.DataSource = svc.BndSource;

            this.textBoxUsername.DataBindings.Add("Text", this.userBindingSource, nameof(Models.User.Username), true, DataSourceUpdateMode.OnPropertyChanged);
            this.textBoxPassword.DataBindings.Add("Text", this.userBindingSource, nameof(Models.User.Password), true, DataSourceUpdateMode.OnPropertyChanged);
            this.textBoxFullName.DataBindings.Add("Text", this.userBindingSource, nameof(Models.User.FullName), true, DataSourceUpdateMode.OnPropertyChanged);
            comboBoxUser.DataBindings.Add("SelectedValue", this.userBindingSource, "RoleId", true, DataSourceUpdateMode.OnPropertyChanged);

        }


        private void ButtonSave_Click(object sender, EventArgs e)
        {

            DialogResult = DialogResult.OK;
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {

            DialogResult = DialogResult.Cancel;
        }

     
    }
}
