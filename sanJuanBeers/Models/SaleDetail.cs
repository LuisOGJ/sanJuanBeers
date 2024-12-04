using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sanJuanBeers.Models
{
    public class SaleDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SaleDetailsID { get; set; }
        public int SaleID { get; set; }
        public int BeerID { get; set; }
        public int Quantity { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal SalePrice { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Discount { get; set; }

        [ForeignKey("SaleID")]
        public virtual Sale Sale { get; set; }

        [ForeignKey("BeerID")]
        public virtual Beer Beer { get; set; }
    }
}
