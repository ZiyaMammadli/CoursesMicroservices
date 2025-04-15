using CoursesMIcroservice.Shared.Extentionsı;
using MediatR;

namespace CoursesMicroservice.Catalog.Api.Features.Categories.GetAll
{
    public static class GetAllCategoryEndpoint
    {
        public static RouteGroupBuilder GetAllCategoryGroupItem(this RouteGroupBuilder group)
        {
            group.MapGet("/GetAll", async (IMediator mediator) =>
            {
                var response =await mediator.Send(new GetAllCategoryQueryRequest());
                return response.ToGenericResult();
            });
            return group;
        }
    }
}
