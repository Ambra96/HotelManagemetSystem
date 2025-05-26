using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HotelPmsCore.Models
{
    public class User 
    { 
        public int Id { get; set; } 
        [Column(TypeName = "VARCHAR(50)")] 
        public string Username { get; set; } = string.Empty;
        [Column(TypeName = "VARCHAR(128)")]
        public string Password { get; set; } = string.Empty;

        public TypedCategory Role { get; set; } = new() { Type = 3 }; 
        [Column(TypeName = "VARCHAR(50)")] 
        public string FullName { get; set; } = string.Empty;
       
    }

}
