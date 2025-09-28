using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CaseStudy.DAL.DomainClasses
{
    public class OrderItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [ForeignKey("OrderId")]
        public Order? Order { get; set; }
        [Required]
        public int OrderId { get; set; }

        [ForeignKey("ProductId")]
        public Product? Product { get; set; }
        [Required]
        public string? ProductId { get; set; }


        public int QtyOrdered { get; set; }
        public int QtySold { get; set; }
        public int QtyBackOrdered { get; set; }
        [Column(TypeName = "money")]
        public decimal SellingPrice { get; set; }
    }
}
