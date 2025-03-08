using API.Models.Common;
using Microsoft.EntityFrameworkCore;

namespace API.Configurations
{
    public static class EntityFrameworkConfiguration
    {
        public static IServiceCollection InjectDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<HospitalDBContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            });
            return services;
        }
    }
}
