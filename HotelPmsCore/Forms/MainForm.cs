using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelPmsCore.Models;

namespace HotelPmsCore.Forms
{
    public partial class MainForm : Form
    {
        private Form activeForm = null; //which form is currently open
        public MainForm()
        {
            InitializeComponent();
        }

        private void OpenForm(Form newForm)
        {
            // Close current form
            activeForm?.Close();

            // Configure new form
            activeForm = newForm;
            activeForm.TopLevel = false;
            activeForm.FormBorderStyle = FormBorderStyle.None;
            activeForm.Dock = DockStyle.Fill;

            // Add to your mainpanel
            MainPanel.Controls.Add(activeForm);
            MainPanel.Tag = activeForm;

            // Show the form
            activeForm.BringToFront();
            activeForm.Show();
        }


        private void button_customers_Click(object sender, EventArgs e)
        {
            OpenForm(new CustomerForm());


        }

        private void button_rooms_Click(object sender, EventArgs e)
        {
            OpenForm(new RoomForm());

        }

        private void button_categories_Click(object sender, EventArgs e)
        {
            //OpenForm(new CategoryForm());     //examsofodnfvasnlk
        }

        private void button_users_Click(object sender, EventArgs e)
        {
            //OpenForm(new UserForm());
        }

        private void button_staff_Click(object sender, EventArgs e)
        {
            //OpenForm(new StaffForm());
        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to logout?", "Logout Confirmation",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // close all open forms 
                Application.OpenForms.Cast<Form>().ToList().ForEach(form => form.Close());

            }


        }


        private void NewButton_Click(object sender, EventArgs e)
        {
            ExecuteCrudOperation("Add");
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            ExecuteCrudOperation("Edit");
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            ExecuteCrudOperation("Delete");
        }

        private void ExecuteCrudOperation(string operationName)
        {
            if (activeForm == null) return;

            var method = activeForm.GetType().GetMethod(operationName,
                BindingFlags.Public | BindingFlags.Instance);

            if (method != null)
            {
                try
                {
                    method.Invoke(activeForm, null);
                    RefreshActiveGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error in {operationName}: {ex.InnerException?.Message}");
                }
            }
        }

        private void RefreshActiveGrid()
        {
            var refreshMethod = activeForm?.GetType().GetMethod("RefreshGrid",
                BindingFlags.Public | BindingFlags.Instance);

            refreshMethod?.Invoke(activeForm, null);
        }

        public void UpdateButtonStates()
        {
            if (activeForm == null) return;

            var hasSelectionProp = activeForm.GetType().GetProperty("HasSelection",
                BindingFlags.Public | BindingFlags.Instance);

            DeleteButton.Enabled = hasSelectionProp?.GetValue(activeForm) as bool? ?? false;
            EditButton.Enabled = DeleteButton.Enabled;
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
