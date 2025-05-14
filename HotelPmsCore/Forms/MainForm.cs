using System;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace HotelPmsCore.Forms
{
    public partial class MainForm : Form
    {
        private Form activeForm = null;

        public MainForm()
        {
            InitializeComponent();
        }

        private void OpenForm(Form newForm)
        {
            activeForm?.Close();
            activeForm = newForm;
            activeForm.TopLevel = false;
            activeForm.FormBorderStyle = FormBorderStyle.None;
            activeForm.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(activeForm);
            MainPanel.Tag = activeForm;
            activeForm.BringToFront();
            activeForm.Show();
            UpdateButtonStates();
        }

        private void button_rooms_Click(object s, EventArgs e) => OpenForm(new RoomForm());
        private void button_categories_Click(object s, EventArgs e) => OpenForm(new CategoryForm());
        private void button_customers_Click(object s, EventArgs e) => OpenForm(new CustomerForm());
        // private void button_users_Click(object s, EventArgs e) => OpenForm(new UserForm());
        // private void button_period_Click(object s, EventArgs e) => OpenForm(new PeriodForm());

        private void button_logout_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                "Are you sure you want to log out?",
                "Logout Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();   // only closes MainForm
            }
        }

        private void NewButton_Click(object s, EventArgs e) => ExecuteCrudOperation("Add");
        private void EditButton_Click(object s, EventArgs e) => ExecuteCrudOperation("Edit");
        private void DeleteButton_Click(object s, EventArgs e) => ExecuteCrudOperation("Delete");
        private void ExitButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                "Are you sure you want to exit the application?",
                "Exit Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();  // closes all forms 
            }
        }

        private void ExecuteCrudOperation(string opName)
        {
            if (activeForm == null) return;
            var m = activeForm.GetType()
                              .GetMethod(opName, BindingFlags.Public | BindingFlags.Instance);
            if (m == null) return;

            try
            {
                m.Invoke(activeForm, null);
                RefreshActiveGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error in {opName}: {ex.InnerException?.Message}");
            }
        }

        private void RefreshActiveGrid()
        {
            var m = activeForm?.GetType()
                               .GetMethod("RefreshGrid", BindingFlags.Public | BindingFlags.Instance);
            m?.Invoke(activeForm, null);
        }

        public void UpdateButtonStates()
        {
            if (activeForm == null) return;
            var prop = activeForm.GetType()
                                 .GetProperty("HasSelection", BindingFlags.Public | BindingFlags.Instance);
            bool has = prop?.GetValue(activeForm) as bool? ?? false;
            DeleteButton.Enabled = has;
            EditButton.Enabled = has;
        }
    }
}
