using API.Models.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models.Entities
{
    [Table("EmployeeCategory")]
    public class EmployeeCategory : GeneralProps
    {
        [Key]
        // ID
        public Guid Id { get; set; }
        // Mã loại nhân viên
        [Required]
        [StringLength(20)]
        public string? EmployeeCategoryCode { get; set; }
        [Required]
        [StringLength(50)]
        // Tên loại nhân viên
        public string? Name { get; set; }
        [StringLength(500)]
        // Mô tả
        public string? Description { get; set; }

        /////////////////////////////////////////////////////
        /// Relationship
        public virtual ICollection<Employee>? Employees { get; set; }
    }
}
