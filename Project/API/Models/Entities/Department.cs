using API.Models.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models.Entities
{
    [Table("Department")]
    public class Department : GeneralProps
    {
        [Key]
        // Mã phòng ban
        public Guid Id { get; set; }
        [Required]
        [StringLength(50)]
        // Tên phòng ban
        public string? Name { get; set; }
        [Required]
        [StringLength(500)]
        // Mô tả
        public string? Description { get; set; }
        [Required]
        // Trạng thái phòng ban
        public bool Status { get; set; }
    }
}
