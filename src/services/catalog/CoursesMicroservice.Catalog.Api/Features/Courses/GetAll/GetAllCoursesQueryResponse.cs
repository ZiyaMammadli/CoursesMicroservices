using CoursesMicroservice.Catalog.Api.Features.Categories.Dtos;
using CoursesMicroservice.Catalog.Api.Features.Courses.Dtos;

namespace CoursesMicroservice.Catalog.Api.Features.Courses.GetAll
{
    public class GetAllCoursesQueryResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; } = default!;
        public string ImageUrl { get; set; }
        public FeatureDto Feature { get; set; }
        public CategoryDto Category { get; set; }
    }
}
