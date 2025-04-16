
using AutoMapper;
using CoursesMicroservice.Catalog.Api.Repositories;
using MassTransit;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace CoursesMicroservice.Catalog.Api.Features.Courses.Create
{
    public class CreateCourseCommandHandler(AppDbContext context, IMapper mapper) : IRequestHandler<CreateCourseCommandRequest, ServiceResult<CreateCourseCommandResponse>>
    {
        public async Task<ServiceResult<CreateCourseCommandResponse>> Handle(CreateCourseCommandRequest request, CancellationToken cancellationToken)
        {

            var existCategory = await context.Categories.FindAsync(request.CategoryId, cancellationToken);

            if (existCategory is null)
            {
                return ServiceResult<CreateCourseCommandResponse>.Error("Category not found", $"Category id:({request.CategoryId}) was not found", HttpStatusCode.NotFound);
            }

            var existCourse = await context.Courses.AnyAsync(c => c.Name == request.Name, cancellationToken);

            if (existCourse)
            {
                return ServiceResult<CreateCourseCommandResponse>.Error("Course already exist", $"Course name:({request.Name}) already exist", HttpStatusCode.BadRequest);
            }

            var newCourse = mapper.Map<Course>(request);
            newCourse.Id = NewId.NextSequentialGuid();
            newCourse.Created = DateTime.UtcNow;
            newCourse.Feature = new()
            {
                Duration = 0,
                EducatorFullName = "Ziya Mammadli",
                Rating = 0,
            };

            await context.Courses.AddAsync(newCourse);
            await context.SaveChangesAsync();
            return ServiceResult<CreateCourseCommandResponse>.SuccessAsCreated(new CreateCourseCommandResponse() { Id = newCourse.Id }, "api/course/Create");
        }
    }
}
