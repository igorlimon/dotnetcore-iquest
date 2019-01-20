using Microsoft.EntityFrameworkCore;

namespace RazorPages.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<ParkingLot> ParkingLots { get; set; }
    }
}