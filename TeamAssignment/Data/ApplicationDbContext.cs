using Microsoft.EntityFrameworkCore;
using TeamAssignment.Models;

namespace TeamAssignment.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<BoardGame> BoardGames { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
