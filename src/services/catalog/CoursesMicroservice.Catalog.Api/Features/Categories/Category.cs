using CoursesMicroservice.Catalog.Api.Features.Courses;
using CoursesMicroservice.Catalog.Api.Repositories;

namespace CoursesMicroservice.Catalog.Api.Features.Categories
{
    public class Category:BaseEntity
    {
        public string Name { get; set; } = default!;
        public List<Course>? Courses { get; set; }
    }
}
