using CoursesMicroservice.Catalog.Api.Features.Categories;
using CoursesMicroservice.Catalog.Api.Features.Courses;
using Microsoft.EntityFrameworkCore;
using MongoDB.Driver;

namespace CoursesMicroservice.Catalog.Api.Repositories
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CourseConfiguration).Assembly);
        }

        public static AppDbContext Create(IMongoDatabase mongoDatabase)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>().UseMongoDB(mongoDatabase.Client,mongoDatabase.DatabaseNamespace.DatabaseName);
            return new AppDbContext(optionsBuilder.Options);
        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
