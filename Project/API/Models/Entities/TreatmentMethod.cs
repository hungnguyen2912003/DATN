using API.Models.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models.Entities
{
    [Table("TreatmentMethod")]
    public class TreatmentMethod : GeneralProps
    {
        // ID
        [Key]
        public Guid Id { get; set; }
        // Mã phương pháp
        [Required]
        [StringLength(20)]
        public string? TreatmentMethodCode { get; set; }
        // Tên phương pháp
        [Required]
        [StringLength(50)]
        public string? TreatmentMethodName { get; set; }
        // Mô tả
        [StringLength(500)]
        public string? Description { get; set; }
        // Chi phí
        [Required]
        public decimal Cost { get; set; }
        [Required]
        // Trạng thái
        public bool Status { get; set; }

        // ForeignKey
        public Guid DepartmentId { get; set; }

        /////////////////////////////////////////////////////
        /// Relationships
        [ForeignKey("DepartmentId")]
        public virtual Department? Department { get; set; }
        public virtual ICollection<Room>? Rooms { get; set; }
    }
}
