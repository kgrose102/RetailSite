using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CaseStudy.DAL.DomainClasses
{
    public class Product
    {
        [Key]
        public string? Id { get; set; }
        [Required]

        [ForeignKey("BrandId")]
        public Brand? Brand { get; set; }
        [Required]
        public int BrandId { get; set; }

        [Required]
        [StringLength(100)]
        public string? ProductName { get; set; }
        [Required]
        [StringLength(100)]
        public string? GraphicName { get; set; }
        [Required]
        [Column(TypeName = "money")]
        public decimal CostPrice { get; set; }
        [Required]
        [Column(TypeName = "money")]
        public decimal MSRP { get; set; }
        [Required]
        public int QtyOnHand { get; set; }
        
        public int QtyOnBackOrder { get; set; }
        [Required]
        [StringLength (2000)]
        public string? Description { get; set; }
    }
}
