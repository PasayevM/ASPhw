using Microsoft.AspNetCore.Mvc;

namespace ViewsModels.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
