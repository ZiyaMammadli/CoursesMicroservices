namespace CoursesMicroservice.Catalog.Api.Features.Courses.Create
{
    public class CreateCourseCommandRequest:IRequest<ServiceResult<CreateCourseCommandResponse>>
    {
        public Guid CategoryId { get; set; } = default!;
        public string Name { get; set; } = default!;
        public string? Description { get; set; }
        public decimal Price { get; set; } = default!;
        public string? ImageUrl { get; set; }
    }
}
