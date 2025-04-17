using CoursesMIcroservice.Shared.Extentionsı;

namespace CoursesMicroservice.Catalog.Api.Features.Courses.GetAll
{
    public static class GetAllCourseEndpoint
    {
        public static RouteGroupBuilder GetAllCourseGroupItemEndpoint(this RouteGroupBuilder group)
        {
            group.MapGet("/GetAll", async (IMediator mediator) =>
            {
                var response = await mediator.Send(new GetAllCoursesQueryRequest());
                return response.ToGenericResult();
            });
            return group;
        }
    }
}
