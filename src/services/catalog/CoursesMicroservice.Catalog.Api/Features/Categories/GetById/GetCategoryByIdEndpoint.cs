using CoursesMIcroservice.Shared.Extentionsı;

namespace CoursesMicroservice.Catalog.Api.Features.Categories.GetById
{
    public static class GetCategoryByIdEndpoint
    {
        public static RouteGroupBuilder GetByIdCategoryGroupItem(this RouteGroupBuilder group)
        {
            group.MapGet("/GetById/{id:guid}", async (Guid id, IMediator mediator) =>
            {
                var response = await mediator.Send(new GetCategoryByIdQueryRequest() { Id=id});
                return response.ToGenericResult();
            });
            return group;
        }
    }
}
