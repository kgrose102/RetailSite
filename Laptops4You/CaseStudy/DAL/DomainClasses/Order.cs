using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CaseStudy.DAL.DomainClasses
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public DateTime DateCreated { get; set; }

        [Column(TypeName ="money")]
        public decimal OrderAmount { get; set; }

        [ForeignKey("CustomerId")]
        public Customer? Customer { get; set; }
        [Required]
        public int CustomerId { get; set; }
    }
}
