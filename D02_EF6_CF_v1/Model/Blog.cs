using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D02_EF6_CF_v1.Model
{
    public class Blog

        // Tabela 1
    {
        #region Sclarar Properties
        public int BlogId { get; set; }     // PK + identity (porque está na primeira posição e chamar-se ID)
        public string Name { get; set; }
        #endregion

        #region Navigation Properties
        public virtual ICollection<Post> Posts { get; set; }  // também é possível --> public virtual List<Post> Posts { get; set; }

        #endregion
    }
}
