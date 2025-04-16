
using AutoMapper;
using CoursesMicroservice.Catalog.Api.Repositories;

namespace CoursesMicroservice.Catalog.Api.Features.Courses.Create
{
    public class CreateCourseCommandHandler(AppDbContext context,IMapper mapper) : IRequestHandler<CreateCourseCommandRequest, ServiceResult<CreateCourseCommandResponse>>
    {
        public Task<ServiceResult<CreateCourseCommandResponse>> Handle(CreateCourseCommandRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
