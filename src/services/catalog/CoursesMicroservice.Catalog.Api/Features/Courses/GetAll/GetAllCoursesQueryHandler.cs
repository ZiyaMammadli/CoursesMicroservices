
using AutoMapper;
using CoursesMicroservice.Catalog.Api.Repositories;
using Microsoft.EntityFrameworkCore;

namespace CoursesMicroservice.Catalog.Api.Features.Courses.GetAll
{
    public class GetAllCoursesQueryHandler(AppDbContext context, IMapper mapper) : IRequestHandler<GetAllCoursesQueryRequest, ServiceResult<List<GetAllCoursesQueryResponse>>>
    {
        public async Task<ServiceResult<List<GetAllCoursesQueryResponse>>> Handle(GetAllCoursesQueryRequest request, CancellationToken cancellationToken)
        {
            var courses = await context.Courses.ToListAsync(cancellationToken);

            var categories = await context.Categories.ToListAsync(cancellationToken);

            foreach (var course in courses)
            {
                course.Category = categories.First(c => c.Id == course.CategoryId);
            }

            var newCourses = mapper.Map<List<GetAllCoursesQueryResponse>>(courses);

            return ServiceResult<List<GetAllCoursesQueryResponse>>.SuccessAsOk(newCourses);
        }
    }
}
