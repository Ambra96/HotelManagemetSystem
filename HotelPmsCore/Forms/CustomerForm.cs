using System.Windows.Forms;
using HotelPmsCore.Models;
using HotelPmsCore.Services;

namespace HotelPmsCore.Forms
{
    public partial class CustomerForm : PageCrudServices<Customer>

    {
        public CustomerForm()
        {
            InitializeComponent();
       

        }

   
        protected override DataGridView Grid => dataGridViewCustomer;
        protected override Button PrevBtn => PreviousButton;
        protected override Button NextBtn => NextButton;

        protected override Form CreateEditForm(Customer c)
            => new CustomerEditForm(c);
    }
}

