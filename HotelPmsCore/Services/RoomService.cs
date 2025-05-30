//using HotelPmsCore.Data;
//using HotelPmsCore.Forms;
//using HotelPmsCore.Models;

//namespace HotelPmsCore.Services
//{
//    public class RoomService
//        : PagedService<RoomForm, RoomEditForm, Room>
//    {
//        public RoomService(HotelPmsCoreContext context)
//            : base(context)
//        {

//            PageSize = 10;
//        }
//    }
//}


// Services/RoomService.cs
using HotelPmsCore.Data;
using HotelPmsCore.Forms;
using HotelPmsCore.Models;
using HotelPmsCore.Services;

public class RoomService
  : PagedService<RoomForm, RoomEditForm, Room>
{
    public RoomService(HotelPmsCoreContext ctx)
        : base(ctx)
    {
        // no special SetCurrentTable call needed;
        // your base ctor already loaded all Rooms for paging
    }
}
