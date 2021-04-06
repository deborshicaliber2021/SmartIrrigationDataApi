using Microsoft.EntityFrameworkCore;

namespace SmartIrrigationDataApi.Models
{
    public class CustomerDbContext : DbContext
    {
        public CustomerDbContext(DbContextOptions<CustomerDbContext> options)
            : base(options)
        {
        }

        public DbSet<CustomerInfo> CustomerInfoData { get; set; }
    }
}