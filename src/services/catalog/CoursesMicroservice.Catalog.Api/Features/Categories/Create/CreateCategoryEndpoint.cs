using CoursesMicroservice.Shared;
using CoursesMIcroservice.Shared.Extentionsı;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CoursesMicroservice.Catalog.Api.Features.Categories.Create
{
    public static class CreateCategoryEndpoint
    {
        public static RouteGroupBuilder CreateCategoryGroupItemEndpoint(this RouteGroupBuilder group)
        {
            group.MapPost("/", async (CreateCategoryCommandRequest request, IMediator mediatr) =>
            {
                var result = await mediatr.Send(request);
                return result.ToGenericResult();
            });
            return group;
        }
    }
}
