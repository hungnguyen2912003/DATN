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
        DbSet<EmployeeCategory> employeeCategories { get; set; }
        DbSet<Medicine> medicines { get; set; }
        DbSet<MedicineCategory> medicineCategories { get; set; }
        DbSet<TreatmentMethod> treatmentMethods { get; set; }
        DbSet<Room> rooms { get; set; }
        DbSet<Regulation> regulations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Medicine>(entity =>
            {
                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
                entity.Property(e => e.DosageQuantity).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<TreatmentMethod>(entity =>
            {
                entity.Property(e => e.Cost).HasColumnType("decimal(18, 2)");
            });
        }
    }
}
