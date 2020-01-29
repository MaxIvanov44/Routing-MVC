using Microsoft.AspNetCore.Mvc;

namespace RoutingMVC.Controllers
{
    [Route("[controller]")]
    public class HomeController : Controller
    {
        [Route("")]     // сопоставляется с Home
        [Route("Index")] // сопоставляется с Home/Index
        public IActionResult Index()
        {
            return View();
        }
    }
}
