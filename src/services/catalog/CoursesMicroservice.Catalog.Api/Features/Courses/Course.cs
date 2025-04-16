using CoursesMicroservice.Catalog.Api.Features.Categories;
using CoursesMicroservice.Catalog.Api.Repositories;

namespace CoursesMicroservice.Catalog.Api.Features.Courses
{
    public class Course:BaseEntity
    {
        public Guid UserId { get; set; } = default!;
        public Guid CategoryId { get; set; } = default!;
        public string Name { get; set; } = default!;
        public string? Description { get; set; }
        public decimal Price { get; set; } = default!;
        public string? ImageUrl { get; set; }
        public DateTime Created { get; set; }
        public Feature Feature { get; set; } = default!;
        public Category Category { get; set; } = default!;
    }
}
