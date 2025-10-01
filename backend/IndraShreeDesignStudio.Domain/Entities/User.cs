using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndraShreeDesignStudio.Domain.Entities
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }

        public int RoleId { get; set; }  // Foreign key
        public Role Role { get; set; }   // Navigation property

        public ICollection<Booking> Bookings { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
