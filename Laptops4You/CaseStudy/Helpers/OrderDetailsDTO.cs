using System.ComponentModel.DataAnnotations.Schema;

namespace CaseStudy.Helpers
{
    public class OrderDetailsDTO
    {
        public int OrderItemId { get; set; }
        public string? ProductName { get; set; }
        public int? QuantitySold { get; set; }
        public int? QuantityOrdered { get; set; }
        public int? QuantityBackOrdered { get; set; }
        public decimal? CostPrice { get; set; }
    }
}
