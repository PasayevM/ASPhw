using Microsoft.AspNetCore.Mvc;

namespace ViewsModels.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
