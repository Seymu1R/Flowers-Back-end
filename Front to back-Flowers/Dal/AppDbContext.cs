using Front_to_back_Flowers.Models;
using Microsoft.EntityFrameworkCore;

namespace Front_to_back_Flowers.Dal
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
        public DbSet<Flower> Flowers { get; set; }
        public DbSet<FlowerExpert> FlowerExperts { get; set; }
        public DbSet<FlowerImg> FlowerImages { get; set; }
        public DbSet<MarketingSlider> MarketingSliders { get; set; }
        public DbSet<SliderIndex> SliderIndexs { get; set; }
    }
}
