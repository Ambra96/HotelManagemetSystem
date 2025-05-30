using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelPmsCore.Models
{
    [PrimaryKey(nameof(Id), nameof(Type))]
    public class TypedCategory
    {
        public int Id { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string Description { get; set; } = string.Empty;

        public int Type { get; set; }
    }

}
