using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelPmsCore.Models
{
    public class Reservation
    {
        public int Id { get; set; }

        // link to customer
        public int CustomerId { get; set; }
        [ForeignKey(nameof(CustomerId))]
        public Customer Customer { get; set; } = null!;

        // link to room
        public int RoomId { get; set; }
        [ForeignKey(nameof(RoomId))]
        public Room Room { get; set; } = null!;

        public DateTime ReservationDateFrom { get; set; }
        public DateTime ReservationDateTo { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }

        public bool Canceled { get; set; }
        public double ReservationDayPrice { get; set; }
    }
}
