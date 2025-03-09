using API.Models.Common;
using API.Repositories.Implementations;
using API.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace API.Configurations
{
    public static class DependencyInjectionConfiguration
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.RegisterDbContext(configuration);
            services.RegisterRepositories();
            return services;
        }

        /// <summary>
        /// Register DbContext
        /// </summary>
        public static IServiceCollection RegisterDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<HospitalDBContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            });
            return services;
        }

        /// <summary>
        /// Register Repositories
        /// </summary>
        public static IServiceCollection RegisterRepositories(this IServiceCollection services)
        {
            services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            services.AddScoped<MedicineRepository>();
            return services;
        }
    }
}
