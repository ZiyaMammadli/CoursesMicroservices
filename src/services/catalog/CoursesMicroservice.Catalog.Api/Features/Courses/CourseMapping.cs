using AutoMapper;
using CoursesMicroservice.Catalog.Api.Features.Categories.Create;
using CoursesMicroservice.Catalog.Api.Features.Courses.Create;

namespace CoursesMicroservice.Catalog.Api.Features.Courses
{
    public class CourseMapping:Profile
    {
        public CourseMapping()
        {
            CreateMap<Course,CreateCourseCommandRequest>().ReverseMap();
        }
    }
}
