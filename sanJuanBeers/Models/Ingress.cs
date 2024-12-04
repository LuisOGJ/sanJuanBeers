using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sanJuanBeers.Models
{
    public class Ingress
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IngressID { get; set; }
        public int ProviderID { get; set; }
        public int UserID { get; set; }
        public DateTime DateTimeIngress { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Total { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Tax { get; set; }
        public string SerialNumber { get; set; }
        public Boolean IsActive { get; set; }

        [ForeignKey("ProviderID")]
        public virtual Provider Provider { get; set; }

        [ForeignKey("UserID")]
        public virtual User User { get; set; }  

    }
}
