using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelPmsCore.Models
{
    public class PriceList
    {
        public int Id { get; set; }
        public Period Period { get; set; } = new();

        public int BedNumber { get; set; }

        public double Price { get; set; }
    }
}
