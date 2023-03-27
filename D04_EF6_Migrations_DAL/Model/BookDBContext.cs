using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace D04_EF6_Migrations_DAL
{

    public class BookDBContext : DbContext
    {
        public BookDBContext() : base("BooksDB_D04")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public DbSet<DaweyDecimalClassification> DaweyDecimalClassification { get; set; }
        public DbSet<Publisher> Publisher { get; set; }
        public DbSet<Book> Book { get; set; }
    }

}
