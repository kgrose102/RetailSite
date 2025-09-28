using CaseStudy.DAL.DomainClasses;
using Microsoft.EntityFrameworkCore;

namespace CaseStudy.DAL
{
    public class AppDbContext:DbContext
    {
        //constructor
        //like a connection string to the dbContext
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

        public virtual DbSet<Brand>? Brands { get; set; }
        public virtual DbSet<Product>? Products { get; set; }

        public virtual DbSet<Customer> Customers { get; set; }

        public virtual DbSet<Order> Orders { get; set; }

        public virtual DbSet<OrderItem> OrderItems { get; set; }

        public virtual DbSet<Branch>? Branches { get; set; }
    }
}
