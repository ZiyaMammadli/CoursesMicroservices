using CoursesMicroservice.Catalog.Api.Features.Categories.Create;
using CoursesMicroservice.Catalog.Api.Features.Categories.GetAll;

namespace CoursesMicroservice.Catalog.Api.Features.Categories
{
    public static class CategoryEndpointExt
    {
        public static void AddCategoryGroupEndpointExt(this WebApplication app)
        {
            app.MapGroup("api/categories")
                .CreateCategoryGroupItemEndpoint()
                .GetAllCategoryGroupItem();
        }
    }
}
