using Microsoft.EntityFrameworkCore;

namespace RazorPagesMovie.Model
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
               .SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile("appsettings.json")
               .Build();
            string useConnection = configuration.GetSection("UseConnection").Value ?? "DefaultConnection";
            string? connectionString = configuration.GetConnectionString(useConnection);
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
