using CaseStudy.DAL;
using CaseStudy.DAL.DAO;
using CaseStudy.DAL.DomainClasses;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CaseStudy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ProductController : Controller
    {
        readonly AppDbContext? _ctx;

        public ProductController(AppDbContext context) // injected here 
        {
            _ctx = context;
        }

        [HttpGet]
        [Route("{catid}")]
        public async Task<ActionResult<List<Product>>> Index(int catid)
        {
            ProductDAO dao = new(_ctx!);
            List<Product> itemsForBrand = await dao.GetAllByBrand(catid);
            return itemsForBrand;
        }
    }
}
