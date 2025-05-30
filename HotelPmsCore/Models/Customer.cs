using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelPmsCore.Models
{
    public class Customer
    {
    
        public int Id { get; set; }

        [Column(TypeName = "VARCHAR(25)")]
        public string FirstName { get; set; } = string.Empty;
        [Column(TypeName = "VARCHAR(25)")]
        public string LastName { get; set; } = string.Empty;
        [Column(TypeName = "VARCHAR(25)")]
        public string Afm { get; set; } = string.Empty;

        [Column(TypeName = "VARCHAR(255)")] 
        public string? Email { get; set; }

        [Column(TypeName = "VARCHAR(15)")]
        public string? Phone { get; set; }

        [Column(TypeName = "TEXT")]
        public string? Address { get; set; }

        [Column(TypeName = "VARCHAR(100)")]
        public string? City { get; set; }

        [Column(TypeName = "VARCHAR(100)")]
        public string? Country { get; set; }

        [Column(TypeName = "VARCHAR(10)")]
        public string? ZipCode { get; set; }

    
    }
} 
