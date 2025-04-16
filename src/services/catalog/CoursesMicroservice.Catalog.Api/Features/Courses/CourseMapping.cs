using AutoMapper;
using CoursesMicroservice.Catalog.Api.Features.Categories.Create;

namespace CoursesMicroservice.Catalog.Api.Features.Courses
{
    public class CourseMapping:Profile
    {
        public CourseMapping()
        {
            CreateMap<Course,CreateCategoryCommandRequest>().ReverseMap();
        }
    }
}
