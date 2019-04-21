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

        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<City> Cities { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contact>().HasIndex(c => c.TelephoneNumber).IsUnique();
            modelBuilder.Entity<City>().HasIndex(c => new { c.Code, c.Name }).IsUnique();
        }
    }
}