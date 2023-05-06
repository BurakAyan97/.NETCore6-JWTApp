using Microsoft.AspNetCore.Mvc;

namespace UdemyJwtApp.UI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
