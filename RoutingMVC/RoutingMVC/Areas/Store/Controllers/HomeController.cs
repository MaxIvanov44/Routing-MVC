using Microsoft.AspNetCore.Mvc;

namespace RoutingMVC.Areas.Store.Controllers
{
    [Area("Store")]
    public class HomeController : Controller
    {
        [Route("Products")]
        [Route("Products/[controller]")]
        [Route("Products/[controller]/[action]")]
        public IActionResult Index()
        {
            return View();
        }
    }
}