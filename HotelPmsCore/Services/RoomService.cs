using Microsoft.Extensions.DependencyInjection;
using HotelPmsCore;
using HotelPmsCore.Data;
using HotelPmsCore.Forms;
using HotelPmsCore.Models;
using HotelPmsCore.Services;

public class RoomService : PagedService<RoomForm, RoomEditForm, Room>
{
    public RoomService(HotelPmsCoreContext ctx)
        : base(ctx)
    {
    }

    public override void New()
    {
      
        var defaultRoomType = context.TypedCategories.FirstOrDefault(tc => tc.Type == 2);
        if (defaultRoomType == null)
        {
            MessageBox.Show("No RoomType categories found in DB!", "Error");
            return;
        }

        var entity = new Room
        {
            RoomType = defaultRoomType
          
        };

        all.Insert(0, entity);
        LoadPage(0);
        BndSource.Position = 0;

        var dlg = Program.ServiceProvider.GetRequiredService<RoomEditForm>();
        if (dlg.ShowDialog() == DialogResult.OK)
        {
            context.Rooms.Add(entity);
            context.SaveChanges();
            ReloadAndNavigate(entity);
        }
        else
        {
            all.RemoveAt(0);
            ReloadAndNavigate(null);
        }
    }
}
