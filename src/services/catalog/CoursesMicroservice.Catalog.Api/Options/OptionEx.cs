using System.Runtime.CompilerServices;

namespace CoursesMicroservice.Catalog.Api.Options
{
    public static class OptionEx
    {
        public static IServiceCollection AddOptionEx(this IServiceCollection services)
        {
            services.AddOptions<MongoOption>().BindConfiguration(nameof(MongoOption)).ValidateDataAnnotations().ValidateOnStart();
            return services;
        }
    }
}
