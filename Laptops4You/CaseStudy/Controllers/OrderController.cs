using CaseStudy.DAL;
using CaseStudy.DAL.DAO;
using CaseStudy.DAL.DomainClasses;
using CaseStudy.Helpers;
using Castle.Components.DictionaryAdapter.Xml;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CaseStudy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class OrderController : Controller
    {
        readonly AppDbContext? _ctx;

        public OrderController(AppDbContext context) // injected here 
        {
            _ctx = context;
        }

        [HttpGet]
        [Route("{email}")]
        //[AllowAnonymous]
        public async Task<List<Order>> List(string email)
        {
            CustomerDAO customerDao = new(_ctx!);
            Customer? orderOwner = await customerDao.GetByEmail(email);

            List<Order> trays = new();

            OrderDAO orderDao = new(_ctx!);
            trays = await orderDao.GetAll(orderOwner!.Id);

            return trays;
        }

        [HttpGet]
        [Route("details/{orderId}")]
        //[AllowAnonymous]
        public async Task<List<OrderDetailsDTO>> List(int orderId)
        {

            List<OrderDetailsDTO> orderDetails = new();

            OrderDAO orderDao = new(_ctx!);
            orderDetails = await orderDao.GetOrderDetails(orderId);

            return orderDetails;
        }

        [HttpPost]
        [Produces("application/json")]
        public async Task<ActionResult<int>> Index(OrderHelper data)
        {
            CustomerDAO customerDAO = new(_ctx!);
            Customer? customer = await customerDAO.GetByEmail(data.Email);

            OrderDAO orderDAO = new(_ctx!);
            int orderId = await orderDAO.SaveOrder(customer!.Id, data.Selections!);
            return orderId;
        }
    }
}
