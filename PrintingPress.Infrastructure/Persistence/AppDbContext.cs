using Microsoft.EntityFrameworkCore;
using PrintingPress.Domain.Entities;

namespace PrintingPress.Infrastructure.Persistence
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // We will add Fluent API configurations here later
        }
    }
}