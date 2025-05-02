using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelPmsCore.Models
{
    public class Room
    {
        public int Id { get; set; }
        [Column(TypeName = "VARCHAR(25)")]
        public string RoomNumber { get; set; } = string.Empty;

        public int Floor { get; set; }

        public int BedNumber { get; set; }

        public int BathNumber { get; set; }

        public TypedCategory RoomType { get; set; } = new() { Type = 2 };
    }
}
