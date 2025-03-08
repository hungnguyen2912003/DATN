using API.Models.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models.Entities
{
    [Table("MedicineType")]
    public class MedicineType : GeneralProps
    {
        [Key]
        // ID
        public Guid Id { get; set; }
        [Required]
        [StringLength(20)]
        // Mã loại thuốc
        public string? MedicineTypeCode { get; set; }
        [Required]
        [StringLength(50)]
        // Tên loại thuốc
        public string? Name { get; set; }
        [StringLength(500)]
        // Mô tả
        public string? Description { get; set; }
        [Required]
        [StringLength(500)]
        // Hình ảnh
        public string? Image { get; set; }
        [Required]
        // Trạng thái
        public bool Status { get; set; }
    }
}
