using API.Models.Common;
using API.Models.Enums.Medicine;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models.Entities
{
    [Table("Medicine")]
    public class Medicine : GeneralProps
    {
        [Key]
        // Mã thuốc
        public Guid Id { get; set; }
        [Required]
        [StringLength(500)]
        // Tên thuốc
        public string? Name { get; set; }
        [Required]
        [StringLength(500)]
        // Mô tả
        public string? Description { get; set; }
        [Required]
        [StringLength(500)]
        // Hình ảnh
        public string? Image { get; set; }
        // Giá
        [Required]
        public decimal Price { get; set; }
        [Required]
        // Số lượng tồn kho
        public int InStock { get; set; }
        [Required]
        // Số lượng đơn vị
        public int UnitQuantity { get; set; }
        [Required]
        [StringLength(50)]
        // Đơn vị
        public UnitType UnitType { get; set; }
        [Required]
        // Liều lượng
        public decimal DosageQuantity { get; set; }
        [Required]
        [StringLength(50)]
        // Đơn vị liều lượng
        public DosageUnit DosageUnit { get; set; }
        [Required]
        [StringLength(500)]
        // Nhà sản xuất
        public string? Manufacturer { get; set; }
        [Required]
        // Ngày sản xuất
        public DateTime ManufacturedDate { get; set; }
        [Required]
        [StringLength(500)]
        // Thành phần hoạt chất
        public string? ActiveIngredient { get; set; }
        [Required]
        // Ngày hết hạn
        public DateTime ExpiryDate { get; set; }
        [Required]
        // Trạng thái
        public bool Status { get; set; }
    }
}
