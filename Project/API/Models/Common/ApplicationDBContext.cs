using API.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Models.Common
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions options) : base(options)
        {
        }

        DbSet<Employee> employees { get; set; }
        DbSet<Department> departments { get; set; }
    }
}
