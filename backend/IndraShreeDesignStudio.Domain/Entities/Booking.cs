using IndraShreeDesignStudio.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndraShreeDesignStudio.Domain.Entities
{
    public class Booking
    {
        public int BookingId { get; set; }

        public DateTime BookingDate { get; set; }

        // Reference to Service entity instead of string
        public int ServiceId { get; set; }
        public Service Service { get; set; }

        public BookingStatus Status { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        // Auditing fields
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}

