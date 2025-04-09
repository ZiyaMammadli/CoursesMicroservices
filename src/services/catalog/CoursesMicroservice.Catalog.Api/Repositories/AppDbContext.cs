using CoursesMicroservice.Catalog.Api.Features.Categories;
using CoursesMicroservice.Catalog.Api.Features.Courses;
using Microsoft.EntityFrameworkCore;

namespace CoursesMicroservice.Catalog.Api.Repositories
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options) { }

        DbSet<Course> Courses { get; set; }
        DbSet<Category> Categories { get; set; }
    }
}
