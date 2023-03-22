using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D02_EF6_CF_v2.Model
{
    internal class BlogContext : DbContext
    {
        #region Construtor (connectionstring do App.Config)
        public BlogContext() : base("name=BlogEntities")
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
        public DbSet<Blog> Blog { get; set; }
        public DbSet<Post> Post { get; set; } 
        #endregion
    }
}
