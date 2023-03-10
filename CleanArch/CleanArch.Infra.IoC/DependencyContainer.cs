using CleanArch.Application.Interfaces;
using CleanArch.Application.Services;
using CleanArch.Domain.Models.Interfaces;
using CleanArch.Infra.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArch.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Application Layer
            services.AddScoped<ICourseService, CourseService>();

            //Infra.Data layer
            services.AddScoped<ICourseRepository, CourseRepository>();
        }
    }
}
