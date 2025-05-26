using System.ComponentModel.DataAnnotations.Schema;

namespace HotelPmsCore.Models
{
    public class Room
    {
        public int Id { get; set; }

        [Column(TypeName = "VARCHAR(25)")]
        public string RoomNumber { get; set; } = string.Empty;

        public int Floor { get; set; }
      
        public double WinterPrice { get; set; }
        public double SummerPrice { get; set; }
        public int PeopleCapacity { get; set; }

        public TypedCategory RoomType { get; set; } = new();
        public string RoomTypeDescription { get; set; } = string.Empty;
    }
}
