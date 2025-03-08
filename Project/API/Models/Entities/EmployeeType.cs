using API.Models.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models.Entities
{
    [Table("EmployeeType")]
    public class EmployeeType : GeneralProps
    {
        [Key]
        // Mã loại nhân viên
        public Guid Id { get; set; }
        [Required]
        [StringLength(500)]
        // Tên loại nhân viên
        public string? Name { get; set; }
        [StringLength(500)]
        // Mô tả
        public string? Description { get; set; }
    }
}
