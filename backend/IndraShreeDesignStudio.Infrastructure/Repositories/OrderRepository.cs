using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using IndraShreeDesignStudio.Domain.Entities;
using IndraShreeDesignStudio.Domain.Repositories;
using IndraShreeDesignStudio.Infrastructure.Data;

namespace IndraShreeDesignStudio.Infrastructure.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly IndraShreeDesignStudioDbContext _context;

        public OrderRepository(IndraShreeDesignStudioDbContext context)
        {
            _context = context;
        }

        public async Task AddOrderAsync(Order order)
        {
            await _context.Orders.AddAsync(order);
            await _context.SaveChangesAsync();
        }

        public async Task<Order> GetOrderByIdAsync(int orderId)
        {
            return await _context.Orders
                .Include(o => o.User)
                .FirstOrDefaultAsync(o => o.OrderId == orderId);
        }

        public async Task<IEnumerable<Order>> GetOrdersByUserIdAsync(int userId)
        {
            return await _context.Orders
                .Where(o => o.UserId == userId)
                .ToListAsync();
        }

        public async Task UpdateOrderAsync(Order order)
        {
            _context.Orders.Update(order);
            await _context.SaveChangesAsync();
        }
    }
}
