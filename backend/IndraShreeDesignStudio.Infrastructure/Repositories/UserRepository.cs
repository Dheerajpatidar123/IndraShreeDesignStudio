using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using IndraShreeDesignStudio.Domain.Entities;
using IndraShreeDesignStudio.Domain.Repositories;
using IndraShreeDesignStudio.Infrastructure.Data;


namespace IndraShreeDesignStudio.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly IndraShreeDesignStudioDbContext _context;

        public UserRepository(IndraShreeDesignStudioDbContext context)
        {
            _context = context;
        }

        public async Task AddUserAsync(User user)
        {
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
        }

        public async Task<User> GetUserByEmailAsync(string email)
        {
            return await _context.Users
                .FirstOrDefaultAsync(u => u.Email == email);
        }

        public async Task<User> GetUserByIdAsync(int userId)
        {
            return await _context.Users
                .Include(u => u.Role)  // Include related Role data
                .FirstOrDefaultAsync(u => u.UserId == userId);
        }

        public async Task UpdateUserAsync(User user)
        {
            _context.Users.Update(user);
            await _context.SaveChangesAsync();
        }
    }
}
