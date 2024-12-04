using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace sanJuanBeers.Models
{
    public class IngressDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IngressDetailID { get; set; }
        public int IngressID { get; set; }
        public int BeerID { get; set; }
        public int Quantity { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Cost { get; set; }

        [ForeignKey("IngressID")]
        public virtual Ingress Ingress { get; set; }

        [ForeignKey("BeerID")]
        public virtual Beer Beer { get; set; }
    }
}
