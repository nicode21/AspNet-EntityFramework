using Microsoft.AspNetCore.Mvc;

namespace GrowMark.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
