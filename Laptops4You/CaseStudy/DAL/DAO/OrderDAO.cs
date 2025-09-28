using CaseStudy.DAL.DomainClasses;
using CaseStudy.Helpers;
using CaseStudy.Migrations;
using Microsoft.EntityFrameworkCore;

namespace CaseStudy.DAL.DAO
{
    public class OrderDAO
    {
        private readonly AppDbContext _db;
        public OrderDAO(AppDbContext ctx)
        {
            _db = ctx;
        }

        public async Task<List<Order>> GetAll(int customerId)
        {
            return await _db.Orders!.Where(order => order.CustomerId == customerId).ToListAsync();
        }

        public async Task<List<OrderDetailsDTO>> GetOrderDetails(int  orderId)
        {
            List<OrderDetailsDTO> details = new();

            var queryInLINQ = from order in _db.Orders
                              join OrderItem in _db.OrderItems! on order.Id equals OrderItem.OrderId
                              join Product in _db.Products! on OrderItem.ProductId equals Product.Id
                              where order.Id == orderId
                              select new OrderDetailsDTO
                              {
                                OrderItemId = orderId,
                                ProductName = Product.ProductName,
                                QuantitySold = OrderItem.QtySold,
                                QuantityOrdered = OrderItem.QtyOrdered,
                                QuantityBackOrdered = OrderItem.QtyBackOrdered,
                                CostPrice = OrderItem.SellingPrice * OrderItem.QtySold
                              };
            details = await queryInLINQ.ToListAsync();

            return details;
        }

        public async Task<int> SaveOrder(int customerId, OrderSelection[] selections)
        {
            int OrderId = -1;

            using (var transaction = await _db.Database.BeginTransactionAsync())
            {
                try
                {
                    Order order = new();
                    order.CustomerId = customerId;
                    order.DateCreated = DateTime.Now;
                    order.OrderAmount = 0;

                    foreach (OrderSelection selection in selections)
                    {
                        order.OrderAmount += selection.Item!.MSRP * selection.Qty;
                    }

                    await _db.Orders!.AddAsync(order);
                    await _db.SaveChangesAsync();

                    foreach (OrderSelection selection in selections)
                    {
                        OrderItem item = new();

                        item.OrderId = order.Id;
                        item.ProductId = selection.Item!.Id;
                        item.QtyOrdered = selection.Qty;
                        item.SellingPrice = selection.Item.CostPrice;

                        int qtyOnHand = selection.Item.QtyOnHand;

                        //If Quantity is less than or equel to on hand
                        if (selection.Qty <= qtyOnHand) //Can't figure out the code for accessing quantity
                        {
                            item.QtyOrdered = selection.Qty;
                            item.QtySold = selection.Qty;
                            
                            item.QtyBackOrdered = 0;
                            item.SellingPrice = selection.Item.CostPrice;

                            // reduce products on hand
                            //HERE -= selection.Qty

                            
                        }
                        
                        //If Quantity is greater than on hand
                        if (selection.Qty > qtyOnHand)
                        {
                            item.QtySold = qtyOnHand;
                            item.QtyBackOrdered = selection.Qty - qtyOnHand;

                            //Product Quantity on had = 0
                            //HERE

                            //Product Quantity Back Ordered = item.QtyBackOrdered
                            // Here  = item.QtyBackOrdered
                        }

                        await _db.OrderItems!.AddAsync(item);
                        await _db.SaveChangesAsync();
                    }

                    await transaction.CommitAsync();

                    OrderId = order.Id;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    await transaction.RollbackAsync();
                }
            }
            return OrderId;
        }
    }
}
