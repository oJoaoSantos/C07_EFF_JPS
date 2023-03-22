using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01_EF6_CF.Model
{
    internal partial class Publisher
    {
        #region Sclarar Properties
        public int PublisherId { get; set; }
        public string Name { get; set; }
        #endregion

        #region Navigation Properties
        public virtual ICollection<Book> Books { get; set; }

        #endregion
    }
}
