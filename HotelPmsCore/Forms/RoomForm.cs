using System.Windows.Forms;
using HotelPmsCore.Models;
using HotelPmsCore.Services;

namespace HotelPmsCore.Forms
{
    public partial class RoomForm : CrudServices<Room>
    {
        public RoomForm()
        {
            InitializeComponent();
        }

        protected override DataGridView Grid => dataGridViewRoom;
        //protected override Button PrevBtn => PreviousButton;
        //protected override Button NextBtn => NextButton;
        //ean vazw prv/next buttons prepei na valw pagecrudservices!!!!
        protected override Form CreateEditForm(Room d)
          => new RoomEditForm(d);
    }
}
