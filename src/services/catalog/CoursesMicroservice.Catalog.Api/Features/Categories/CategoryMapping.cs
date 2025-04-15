
using AutoMapper;
using CoursesMicroservice.Catalog.Api.Features.Categories.GetAll;
using CoursesMicroservice.Catalog.Api.Features.Categories.GetById;

namespace CoursesMicroservice.Catalog.Api.Features.Categories
{
    public class CategoryMapping:Profile
    {
        public CategoryMapping()
        {
            CreateMap<Category,GetAllCategoryQueryResponse>().ReverseMap();
            CreateMap<Category,GetCategoryByIdQueryResponse>().ReverseMap();
        }
    }
}
