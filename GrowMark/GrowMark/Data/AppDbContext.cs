using GrowMark.Models;
using Microsoft.EntityFrameworkCore;

namespace GrowMark.Data
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> option):base(option)
        {

        }

        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Feature> Features{ get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Project> Projects { get; set; }
    }
}
