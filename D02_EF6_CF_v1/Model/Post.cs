
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D02_EF6_CF_v1.Model
{
    public class Post

        // Tabela n
    {
        #region Sclarar Properties
        public int PostId { get; set; }     // PK
        public int BlogId { get; set; }     // FK
        public string Title { get; set; }
        public string Content { get; set; }
        #endregion

        #region Navigation Properties
        public virtual Blog Blog { get; set; }
        #endregion
    }
}
