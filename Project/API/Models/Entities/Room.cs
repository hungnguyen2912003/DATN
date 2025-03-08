using API.Models.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models.Entities
{
    [Table("Room")]
    public class Room : GeneralProps
    {
        // ID
        [Key]
        public Guid Id { get; set; }
        // Mã phòng
        [Required]
        [StringLength(20)]
        public string? RoomCode { get; set; }
        [Required]
        [StringLength(50)]
        // Tên phòng
        public string? RoomName { get; set; }
        [StringLength(500)]
        // Mô tả
        public string? Description { get; set; }
        [Required]
        // Trạng thái phòng
        public bool Status { get; set; }

        // ForeignKey
        public Guid TreatmentMethodId { get; set; }

        /////////////////////////////////////////////////////
        /// Relationships
        [ForeignKey("TreatmentMethodId")]
        public virtual TreatmentMethod? TreatmentMethod { get; set; }
    }
}
