using Microsoft.EntityFrameworkCore;
using Practice.Models;

namespace Practice.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options) { }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<SliderInfo> SliderInfos { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<ExpertHeader> ExpertHeaders { get; set; }
        public DbSet<Expert> Experts { get; set; }
        public DbSet<ExpertPosition> ExpertPositions { get; set; }
        public DbSet<ExpertExpertPosition> ExpertExpertPositions { get; set; }
        public DbSet<Subscribe> Subscribes { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogHeader> BlogHeaders { get; set; }
        public DbSet<Say> Says { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Instagram> Instagrams { get; set; }

    }
}
