using Microsoft.EntityFrameworkCore;

namespace api_tests
{

    /// <summary>
    /// migracja bazy w konsoli nuget add-mig poczym update-database
    /// </summary>
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<data> Datas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}
