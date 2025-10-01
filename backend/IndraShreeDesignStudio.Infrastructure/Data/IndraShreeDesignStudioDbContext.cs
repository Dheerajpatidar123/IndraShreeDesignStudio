using Microsoft.EntityFrameworkCore;
using IndraShreeDesignStudio.Domain.Entities;

namespace IndraShreeDesignStudio.Infrastructure.Data
{
    public class IndraShreeDesignStudioDbContext : DbContext
    {
        public IndraShreeDesignStudioDbContext(DbContextOptions<IndraShreeDesignStudioDbContext> options)
            : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Service> Services { get; set; }
        // Add other DbSets as required
    }
}
