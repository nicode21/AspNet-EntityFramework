using Microsoft.AspNetCore.Mvc;
using GrowMark.Models;
using System.Drawing;
using GrowMark.ViewModels;
using System.Security.Cryptography.X509Certificates;
using GrowMark.Data;

namespace GrowMark.Controllers
{
    public class HomeController : Controller
    {

        public readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            OurTeam t1 = new()
            {
                Id = 1,
                Image = "team-1.jpg",
                Name = "Alex Robin",
                Position = "Founder & CEO"
            };

            OurTeam t2 = new()
            {
                Id = 2,
                Image = "team-2.jpg",
                Name = "Adam Crew",
                Position = "Co Founder"
            };

            OurTeam t3 = new()
            {
                Id = 3,
                Image = "team-3.jpg",
                Name = "Boris Johnson",
                Position = "Executive Manager"
            };

            OurTeam t4 = new()
            {
                Id = 4,
                Image = "team-4.jpg",
                Name = "Robert Jordan",
                Position = "Digital Marketer"
            };

            Testimonial ts1 = new()
            {
                Id = 1,
                ProfileImage = "testimonial-1.jpg",
                Description = "Diam dolor diam ipsum sit. Aliqu diam amet diam et eos. Clita erat ipsum et lorem et\r\n                    sit, sed stet lorem sit clita duo justo",
                Name = "Client Name",
                Position = "Profession"
            };

            Testimonial ts2 = new()
            {
                Id = 2,
                ProfileImage = "testimonial-2.jpg",
                Description = "Diam dolor diam ipsum sit. Aliqu diam amet diam et eos. Clita erat ipsum et lorem et\r\n                    sit, sed stet lorem sit clita duo justo",
                Name = "Client Name",
                Position = "Profession"
            };

            Testimonial ts3 = new()
            {
                Id = 3,
                ProfileImage = "testimonial-3.jpg",
                Description = "Diam dolor diam ipsum sit. Aliqu diam amet diam et eos. Clita erat ipsum et lorem et\r\n                    sit, sed stet lorem sit clita duo justo",
                Name = "Client Name",
                Position = "Profession"
            };

            Testimonial ts4 = new()
            {
                Id = 4,
                ProfileImage = "testimonial-4.jpg",
                Description = "Diam dolor diam ipsum sit. Aliqu diam amet diam et eos. Clita erat ipsum et lorem et\r\n                    sit, sed stet lorem sit clita duo justo",
                Name = "Client Name",
                Position = "Profession"
            };


            HomeVM home = new()
            {
                OurTeams = new List<OurTeam>() { t1, t2, t3, t4 },
                Testimonials = new List<Testimonial>() { ts1, ts2, ts3, ts4 },
                Sliders = _context.Sliders.ToList(),
                Features = _context.Features.ToList(),
                Services = _context.Services.ToList(),
                Projects = _context.Projects.ToList()
            };

            return View(home);

        }
    }
}
