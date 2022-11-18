using Microsoft.AspNetCore.Mvc;

namespace eBilet.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
