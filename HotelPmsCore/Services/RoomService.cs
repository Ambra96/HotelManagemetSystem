using HotelPmsCore;
using HotelPmsCore.Data;
using HotelPmsCore.Forms;
using HotelPmsCore.Models;
using HotelPmsCore.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

public class RoomService : PagedService<RoomForm, RoomEditForm, Room>
{
    public RoomService(HotelPmsCoreContext ctx)
        : base(ctx)
    {
    }

    public void ApplyFilters(Dictionary<string, object> filterValues)
    {
        var query = context.Rooms.AsQueryable();

        if (filterValues.TryGetValue("RoomNumber", out var rn) && rn is string roomNumber && !string.IsNullOrWhiteSpace(roomNumber))
            query = query.Where(r => EF.Functions.Like(r.RoomNumber, roomNumber));

        if (filterValues.TryGetValue("Capacity", out var cap) && cap is int capacity && capacity > 0)
            query = query.Where(r => r.PeopleCapacity == capacity);

        BndSource.DataSource = query.ToList();
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
