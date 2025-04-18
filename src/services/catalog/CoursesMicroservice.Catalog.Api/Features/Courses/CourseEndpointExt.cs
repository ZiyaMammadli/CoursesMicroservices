﻿using CoursesMicroservice.Catalog.Api.Features.Courses.Create;
using CoursesMicroservice.Catalog.Api.Features.Courses.GetAll;

namespace CoursesMicroservice.Catalog.Api.Features.Courses
{
    public static class CourseEndpointExt
    {
        public static void AddCourseGroupEndpointExt(this WebApplication app)
        {
            app.MapGroup("api/courses").WithTags("Courses")
                .CreateCourseGroupItemEndpoint()
                .GetAllCourseGroupItemEndpoint();
        }
    }
}
