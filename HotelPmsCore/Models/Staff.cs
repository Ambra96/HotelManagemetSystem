using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelPmsCore.Models
{
    public class Staff
    {
        public int Id { get; set; }
        [Column(TypeName = "VARCHAR(128)")]
        public string Firstname { get; set; } = string.Empty;
        [Column(TypeName = "VARCHAR(128)")]
        public string Lastname { get; set; } = string.Empty;

        public int SpecialityId { get; set; }
        [ForeignKey(nameof(SpecialityId))]
        public TypedCategory Speciality { get; set; } = null!;
    }

}
