using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace CoffeeConsumption.Models
{
    public class OfficeContext : DbContext
    {
        static OfficeContext()
        {
            Database.SetInitializer(new OfficeInitializer());
        }

        public OfficeContext()
            : base("Name=OfficeContext")
        {
        }

        public DbSet<Cup> Cups { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Consumption> Consumptions { get; set; }
        
    }
}