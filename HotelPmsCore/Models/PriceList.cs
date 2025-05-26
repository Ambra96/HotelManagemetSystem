//using System;
//using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations.Schema;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace HotelPmsCore.Models
//{
//    public class PriceList
//    {
//        public int Id { get; set; }

//        public int PeriodId { get; set; } // Foreign key for Period
//        [ForeignKey("PeriodId")]
//        public Period Period { get; set; } = new();

//        public int BedNumber { get; set; }
//        public double Price { get; set; }
//    }

//}
