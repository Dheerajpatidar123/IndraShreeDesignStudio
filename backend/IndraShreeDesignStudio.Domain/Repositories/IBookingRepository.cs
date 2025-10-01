using IndraShreeDesignStudio.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndraShreeDesignStudio.Domain.Repositories
{
    public interface IBookingRepository
    {
        Task<Booking> GetBookingByIdAsync(int bookingId);
        Task<IEnumerable<Booking>> GetBookingsByUserIdAsync(int userId);
        Task AddBookingAsync(Booking booking);
        Task UpdateBookingAsync(Booking booking);
    }
}
