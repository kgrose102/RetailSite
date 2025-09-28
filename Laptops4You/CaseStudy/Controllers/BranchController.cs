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
    public class BranchController : Controller
    {
        readonly AppDbContext _db;

        public BranchController(AppDbContext context)
        {
            _db = context;
        }

        [HttpGet("{lat}/{lon}")]
        [AllowAnonymous]
        public async Task<List<Branch>> Index(float lat, float lon)
        {
            BranchDAO dao = new(_db);
            return await dao.GetThreeClosestStores(lat, lon);
        }
    }
}
