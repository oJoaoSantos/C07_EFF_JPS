using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace E01_EF6_CF.Model
{
    internal class DBContext : DbContext
    {
        #region Construtor (connectionstring do App.Config)
        public DBContext() : base("name=BookEntities")
        {
        }
        #endregion

        #region Variação da BD
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Desativar a pluralização das tabelas
            modelBuilder.Conventions.Remove<PluralizingEntitySetNameConvention>();
        }
        #endregion

        #region Tabelas em Memória (dbsets)
        public DbSet<Book> Book { get; set; }
        public DbSet<Publisher> Publisher { get; set; }
        #endregion
    }
}
