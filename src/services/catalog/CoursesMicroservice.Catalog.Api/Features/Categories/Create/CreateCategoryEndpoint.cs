using CoursesMIcroservice.Shared.Extentionsı;
using CoursesMIcroservice.Shared.Filters;

namespace CoursesMicroservice.Catalog.Api.Features.Categories.Create
{
    public static class CreateCategoryEndpoint
    {
        public static RouteGroupBuilder CreateCategoryGroupItemEndpoint(this RouteGroupBuilder group)
        {
            group.MapPost("/Create", async (CreateCategoryCommandRequest request, IMediator mediatr) => 
            {
                var result = await mediatr.Send(request);
                return result.ToGenericResult();

            }).AddEndpointFilter<ValidationFilter<CreateCategoryCommandRequest>>();

            return group;
        }
    }
}
