using Microsoft.AspNetCore.Mvc;

namespace GrowMark.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
