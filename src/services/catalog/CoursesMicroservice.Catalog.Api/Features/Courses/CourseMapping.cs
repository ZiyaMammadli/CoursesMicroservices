using AutoMapper;
using CoursesMicroservice.Catalog.Api.Features.Categories;
using CoursesMicroservice.Catalog.Api.Features.Categories.Dtos;
using CoursesMicroservice.Catalog.Api.Features.Courses.Create;
using CoursesMicroservice.Catalog.Api.Features.Courses.Dtos;
using CoursesMicroservice.Catalog.Api.Features.Courses.GetAll;

namespace CoursesMicroservice.Catalog.Api.Features.Courses
{
    public class CourseMapping:Profile
    {
        public CourseMapping()
        {
            CreateMap<Course,CreateCourseCommandRequest>().ReverseMap();
            CreateMap<Course,GetAllCoursesQueryResponse>().ReverseMap();
            CreateMap<Feature, FeatureDto>().ReverseMap();
        }
    }
}
