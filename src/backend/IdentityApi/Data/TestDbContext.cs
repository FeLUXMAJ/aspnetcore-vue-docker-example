using Microsoft.EntityFrameworkCore;

namespace IdentityApi.Data
{
    public class TestContext : DbContext
    {
        // public TestContext()
        // {
        // }

        public TestContext(DbContextOptions<TestContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasKey(u => u.Id)
                .HasName("pk_id");
        }
    }
}
