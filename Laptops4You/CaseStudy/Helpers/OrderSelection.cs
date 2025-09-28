using CaseStudy.DAL.DomainClasses;

namespace CaseStudy.Helpers
{
    public class OrderSelection
    {
        public int Qty { get; set; }

        public Product? Item { get; set; }
    }
}
