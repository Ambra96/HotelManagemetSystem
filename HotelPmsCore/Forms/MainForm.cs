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
        }

        private void OpenModule<TForm>() where TForm : Form, IModule
        {
            // tear down previous
            if (activeForm != null)
                MainPanel.Controls.Remove(activeForm);

            // resolve new
            var form = Program.ServiceProvider.GetRequiredService<TForm>();
            if (form is not IModule module)
                throw new InvalidOperationException($"{typeof(TForm).Name} must implement IModule.");

            currentModule = module;
            activeForm = form;

            // embed it
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(form);
            form.Show();

            // update toolbar
            UpdateButtonStates();
        }

        private void button_customers_Click(object s, EventArgs e)
            => OpenModule<CustomerForm>();

        private void button_categories_Click(object s, EventArgs e)
            => OpenModule<CategoryForm>();

        private void button_rooms_Click(object s, EventArgs e)
            => OpenModule<RoomForm>();

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

        // If you have a Refresh button, wire it here:
        private void RefreshButton_Click(object s, EventArgs e)
        {
            currentModule?.RefreshGrid();
            UpdateButtonStates();
        }

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
            // New and Refresh can always be enabled
            NewButton.Enabled = true;
            //RefreshButton.Enabled = true;
        }
    }
}
