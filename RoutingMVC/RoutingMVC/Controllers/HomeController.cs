using Microsoft.AspNetCore.Mvc;

namespace RoutingMVC.Controllers
{
    [Route("Store")]
    [Route("[controller]")]
    public class HomeController : Controller
    {
        [Route("Main")]     // сопоставляется с Home/Main, либо с Store/Main
        [Route("Index")] // сопоставляется с Home/Index, либо с Store/Index
        public IActionResult Index()
        {
            return View();
        }
    }
}
