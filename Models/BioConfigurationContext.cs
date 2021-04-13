using Microsoft.EntityFrameworkCore;

namespace SmartIrrigationDataApi.Models
{
    public class BioConfigurationDbContext : DbContext
    {
        public BioConfigurationDbContext(DbContextOptions<BioConfigurationDbContext> options)
            : base(options)
        {
        }

        public DbSet<BioConfiguration> BioConfigurations { get; set; }
    }
}