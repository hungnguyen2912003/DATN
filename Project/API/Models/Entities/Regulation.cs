using API.Models.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models.Entities
{
    [Table("Regulation")]
    public class Regulation : GeneralProps
    {
        [Key]
        // ID
        public Guid Id { get; set; }
        [Required]
        [StringLength(50)]
        // Tên quy định
        public string? Name { get; set; }
        // Nội dung
        [Required]
        public string? Content { get; set; }
        // Mô tả
        [StringLength(500)]
        public string? Description { get; set; }
        [Required]
        // Ngày có hiệu lực
        public DateTime EffectiveDate { get; set; }
        // Ngày hết hiệu lực
        [Required]
        public DateTime ExpirationDate { get; set; }
        // Trạng thái
        public bool Status { get; set; }
    }
}
