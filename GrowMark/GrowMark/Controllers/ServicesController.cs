using Microsoft.AspNetCore.Mvc;

namespace GrowMark.Controllers
{
    public class ServicesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
