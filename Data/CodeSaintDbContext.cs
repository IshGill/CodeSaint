using Microsoft.EntityFrameworkCore;
using CodeSaint.Models;

namespace CodeSaint.Data
{
    public class CodeSaintDbContext : DbContext
    {
        public CodeSaintDbContext() { }
        public CodeSaintDbContext(DbContextOptions<CodeSaintDbContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<Stock> Stocks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Entity<Stock>().ToTable("Stocks");
            modelBuilder.Entity<Stock>()
                .Property(s => s.SuperInvestors)
                .HasConversion(
                    v => string.Join(',', v),
                    v => v.Split(',', StringSplitOptions.RemoveEmptyEntries));
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=ISH;Database=MyDatabase;TrustServerCertificate=Yes;Trusted_Connection=True;MultipleActiveResultSets=true");
        }

    }
}
