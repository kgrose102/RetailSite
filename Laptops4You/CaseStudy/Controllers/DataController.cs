using CaseStudy.DAL;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CaseStudy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class DataController : ControllerBase
    {
        readonly AppDbContext? _ctx;

        public DataController(AppDbContext context) // injected here 
        {
            _ctx = context;
        }
    }
}
