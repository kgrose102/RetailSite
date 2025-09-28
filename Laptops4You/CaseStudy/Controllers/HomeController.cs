using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CaseStudy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class HomeController : Controller
    {

        [HttpGet]
        public ActionResult<string> Index()
        {
            return "If you see this the server is up and running!";
        }
    }
}
