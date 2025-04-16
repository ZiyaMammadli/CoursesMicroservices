using CoursesMIcroservice.Shared.Extentionsı;
using CoursesMIcroservice.Shared.Filters;

namespace CoursesMicroservice.Catalog.Api.Features.Courses.Create
{
    public static class CreateCourseEndpoint
    {
        public static RouteGroupBuilder CreateCourseGroupItemEndpoint(this RouteGroupBuilder group)
        {
            group.MapPost("/Create", async (CreateCourseCommandRequest request,IMediator mediator) =>
            {
                var response = await mediator.Send(request);
                return response.ToGenericResult();
            }).AddEndpointFilter<ValidationFilter<CreateCourseCommandRequest>>(); ;
            return group;
        }
    }
}
