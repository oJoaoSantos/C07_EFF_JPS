using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace D04_EF6_Migrations_DAL
{

    public class BookDBContext : DbContext
    {

        // O nome da connectionstring a ser usada neste contexto
        public BookDBContext() : base("BooksDB_D04")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public DbSet<Publisher> Publisher { get; set; }
        public DbSet<Book> Book { get; set; }
        public DbSet<DaweyDecimalClassification> DaweyDecimalClassification { get; set; }

    }

}
