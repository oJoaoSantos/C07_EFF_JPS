using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01_EF6_CF.Model
{
    internal partial class Book
    {
        #region Sclarar Properties
        public int BookId { get; set; }
        public int PublisherId { get; set; }
        public string ISBN { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        #endregion

        #region Navigation Properties
        public virtual Publisher Publisher { get; set; }

        #endregion
    }
}
