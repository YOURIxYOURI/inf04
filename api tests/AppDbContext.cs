using Microsoft.EntityFrameworkCore;

namespace api_tests
{

    /// <summary>
    /// migracja bazy w konsoli nuget add-mig poczym update-database
    /// </summary>
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options, IConfiguration configuration)
        : base(options) { _configuration = configuration; }
        public IConfiguration _configuration { get; }

        public DbSet<data> datas { get; set; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(options =>
                options.UseMySql(_configuration.GetConnectionString("MySqlConnection"), ServerVersion.AutoDetect(_configuration.GetConnectionString("MySqlConnection"))));
            services.AddDbContext<AppDbContext>();

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
