using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace E01_EF6_CF_BooksDB_DAL
{

    public class BookDBContext : DbContext
    {

        // O nome da connectionstring a ser usada neste contexto
        public BookDBContext() : base("BooksDB")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public DbSet<Publisher> Publisher { get; set; }
        public DbSet<Book> Book { get; set; }

    }

}
