namespace CitiesCatalog.DataAccess
{
    using CitiesCatalog.Models;
    using System.Data.Entity;

    public class DataContext : DbContext
    {
        public DataContext()
            : base("name=DataContext")
        {
            Database.SetInitializer(new DataInitializer());
        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<City> Cities { get; set; }
    }
}