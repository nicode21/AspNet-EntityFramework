using Microsoft.AspNetCore.Mvc;

namespace GrowMark.Controllers
{
    public class ProjectsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
