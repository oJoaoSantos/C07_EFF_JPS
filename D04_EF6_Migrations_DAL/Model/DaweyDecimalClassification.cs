using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace D04_EF6_Migrations_DAL
{
    public class DaweyDecimalClassification
    {
        #region Scalar properties
        public int DaweyDecimalClassificationID { get; set; }

        [Required]
        [MaxLength(3, ErrorMessage = "3 character limit.")]
        public string DDCCode { get; set; }

        [Required]
        [MaxLength(100, ErrorMessage = "100 character limit.")]
        public string DDCClassification { get; set; }

        #endregion

        #region Navigation properties
        public ICollection<Book> Book { get; set; }
        #endregion
    }
}
