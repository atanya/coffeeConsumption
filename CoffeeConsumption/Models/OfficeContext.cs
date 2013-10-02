using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace CoffeeConsumption.Models
{
    public class OfficeContext : DbContext
    {
        static OfficeContext()
        {
            Database.SetInitializer<OfficeContext>(null);
        }

        public OfficeContext()
            : base("Name=TFSExtensionsContext")
        {
        }

        public DbSet<Cup> Cups { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Consumption> Consumptions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}