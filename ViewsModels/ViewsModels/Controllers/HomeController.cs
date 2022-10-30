using Microsoft.AspNetCore.Mvc;

namespace ViewsModels.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
