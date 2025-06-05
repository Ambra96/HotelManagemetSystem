using System;
using System.Windows.Forms;
using HotelPmsCore.Services;
using Microsoft.Extensions.DependencyInjection;

namespace HotelPmsCore.Forms
{
    public partial class MainForm : Form
    {
        private IModule currentModule;
        private Form activeForm;

        public MainForm()
        {
            InitializeComponent();
            settingsPanel.Visible = false;

        }

        private void OpenModule<TForm>() where TForm : Form, IModule
        {


            if (activeForm != null)
                MainPanel.Controls.Remove(activeForm);


            var form = Program.ServiceProvider.GetRequiredService<TForm>();
            if (form is not IModule module)
                throw new InvalidOperationException($"{typeof(TForm).Name} must implement IModule.");

            currentModule = module;
            activeForm = form;


            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(form);
            form.Show();

            UpdateButtonStates();
        }
        private void ShowInSettingsPanel(Form form)
        {
            settingsContentPanel.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            settingsContentPanel.Controls.Add(form);
            form.Show();

            settingsPanel.Visible = true;
            currentModule = form as IModule;
            activeForm = form;
            UpdateButtonStates();
        }




        private void button_customers_Click(object sender, EventArgs e)
        {
            settingsPanel.Visible = false;
            OpenModule<CustomerForm>();
        }
        private void button_rooms_Click(object sender, EventArgs e)
        {
            settingsPanel.Visible = false;
            OpenModule<RoomForm>();
        }

        //private void button_reservations_Click(object sender, EventArgs e)
        //{settingsPanel.Visible = false;
        // OpenModule<CustomerForm>();}

        private void button_staff_Click(object sender, EventArgs e)
        {
            settingsPanel.Visible = false;
            OpenModule<StaffForm>();
        }
        private void NewButton_Click(object s, EventArgs e)
        {
            currentModule?.New();
            currentModule?.RefreshGrid();
            UpdateButtonStates();
        }

        private void EditButton_Click(object s, EventArgs e)
        {
            currentModule?.Edit();
            currentModule?.RefreshGrid();
            UpdateButtonStates();
        }

        private void DeleteButton_Click(object s, EventArgs e)
        {
            currentModule?.Delete();
            currentModule?.RefreshGrid();
            UpdateButtonStates();
        }


        //private void RefreshButton_Click(object s, EventArgs e)
        //{
        //    currentModule?.RefreshGrid();
        //    UpdateButtonStates();
        //}

        private void ExitButton_Click(object s, EventArgs e)
            => Application.Exit();

        private void button_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            var loginForm = Program.ServiceProvider.GetRequiredService<LoginForm>();
            var result = loginForm.ShowDialog();

            if (result == DialogResult.OK)
                this.Show();
            else
                this.Close();
        }

        private void UpdateButtonStates()
        {
            bool has = currentModule?.HasSelection ?? false;
            EditButton.Enabled = has;
            DeleteButton.Enabled = has;
            NewButton.Enabled = true;
            //RefreshButton.Enabled = true;
        }

        private void menuItemPeriods_Click(object sender, EventArgs e)
        {
            var form = Program.ServiceProvider.GetRequiredService<PeriodForm>();
            ShowInSettingsPanel(form);

        }

        private void menuItemCategories_Click(object sender, EventArgs e)
        {
            //var service = Program.ServiceProvider.GetRequiredService<CategoryService>();
            //service.CategoryType = 2; 
            var form = Program.ServiceProvider.GetRequiredService<CategoryForm>();
            ShowInSettingsPanel(form);
        }

        private void menuItemUsers_Click(object sender, EventArgs e)
        {

            var form = Program.ServiceProvider.GetRequiredService<UserForm>();
            ShowInSettingsPanel(form);
        }

        private void button_settings_Click(object sender, EventArgs e)
        {

            settingsPanel.Visible = true;
            settingsPanel.BringToFront();
        }

        private void settingsPanel_Leave(object sender, EventArgs e)
        {
            settingsPanel.Visible = false;
        }

        private void BttnFilters_Click(object sender, EventArgs e)
        {
       
            if (currentModule is IModule module)
                module.ShowFilter();
      
        }
    }
}
//temporary