using System;

namespace Casgem_CodeFirstProject.DAL.Entities
{
    public class Booking
    {
        public int BookingId { get; set; }
        public string CustomerName { get; set; }
        public string Destination { get; set; }
        public string Mail { get; set; }
        public DateTime BookingDate { get; set; }
        public string BookingStatus { get; set; }
    }
}