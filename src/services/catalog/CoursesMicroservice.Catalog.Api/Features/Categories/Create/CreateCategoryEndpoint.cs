﻿using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace CoursesMicroservice.Catalog.Api.Features.Categories.Create
{
    public static class CreateCategoryEndpoint
    {
        public static RouteGroupBuilder CreateCategoryGroupItemEndpoint(this RouteGroupBuilder group)
        {
            group.MapPost("/", async (CreateCategoryCommandRequest request, IMediator mediatr) =>
            {
                var result = await mediatr.Send(request);
                return new ObjectResult(result)
                {
                    StatusCode = result.Status.GetHashCode(),
                };
            });
            return group;
        }
    }
}
