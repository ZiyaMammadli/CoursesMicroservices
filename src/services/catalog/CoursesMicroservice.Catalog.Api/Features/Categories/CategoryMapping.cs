
using AutoMapper;
using CoursesMicroservice.Catalog.Api.Features.Categories.GetAll;

namespace CoursesMicroservice.Catalog.Api.Features.Categories
{
    public class CategoryMapping:Profile
    {
        public CategoryMapping()
        {
            CreateMap<Category,GetAllCategoryQueryResponse>().ReverseMap();
        }
    }
}
