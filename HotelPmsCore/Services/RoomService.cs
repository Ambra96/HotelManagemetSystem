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
  
    }
}
