using Microsoft.EntityFrameworkCore;
using MyAPI;

public class HeroDbContext : DbContext
{
    public HeroDbContext(DbContextOptions<HeroDbContext> options) : base(options)
    {
    }

    public DbSet<Hero> Heroes { get; set; }

 
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            optionsBuilder.UseSqlServer(connectionString, options =>
            {
                options.EnableRetryOnFailure();
            });

            base.OnConfiguring(optionsBuilder);
        }
    }
}
