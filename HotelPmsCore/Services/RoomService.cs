using HotelPmsCore.Data;
using HotelPmsCore.Forms;
using HotelPmsCore.Models;

namespace HotelPmsCore.Services
{
    public class RoomService
        : PagedService<RoomForm, RoomEditForm, Room>
    {
        public RoomService(HotelPmsCoreContext context)
            : base(context)
        {
          
            PageSize = 10;
        }
    }
}