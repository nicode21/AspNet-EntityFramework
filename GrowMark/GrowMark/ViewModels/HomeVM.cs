using GrowMark.Models;
using Microsoft.EntityFrameworkCore;

namespace GrowMark.ViewModels
{
    public class HomeVM
    {
        public List<Feature> Features { get; set; }
        public List<OurTeam> OurTeams { get; set; }
        public List<Project> Projects { get; set; }
        public List<Service> Services { get; set; }
        public List<Testimonial> Testimonials { get; set; }
        public List<Slider> Sliders{ get; set; }
    }
}
