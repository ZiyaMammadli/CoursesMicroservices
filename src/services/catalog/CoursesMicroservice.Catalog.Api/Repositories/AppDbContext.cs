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

        public AppDbContext Create(IMongoDatabase mongoDatabase)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>().UseMongoDB(mongoDatabase.Client,mongoDatabase.DatabaseNamespace.DatabaseName);
            return new AppDbContext(optionsBuilder.Options);
        }

        DbSet<Course> Courses { get; set; }
        DbSet<Category> Categories { get; set; }
    }
}
