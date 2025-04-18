﻿using CoursesMicroservice.Catalog.Api.Features.Categories.Create;
using CoursesMicroservice.Catalog.Api.Features.Categories.GetAll;
using CoursesMicroservice.Catalog.Api.Features.Categories.GetById;

namespace CoursesMicroservice.Catalog.Api.Features.Categories
{
    public static class CategoryEndpointExt
    {
        public static void AddCategoryGroupEndpointExt(this WebApplication app)
        {
            app.MapGroup("api/categories").WithTags("Categories")
                .CreateCategoryGroupItemEndpoint()
                .GetAllCategoryGroupItem()
                .GetByIdCategoryGroupItem();
        }
    }
}
