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
        public Guid Id { get; set; }
        [Required]
        [StringLength(500)]
        public string? Name { get; set; }
        [Required]
        [StringLength(500)]
        public string? Description { get; set; }
        [Required]
        [StringLength(500)]
        public string? Image { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public int InStock { get; set; }
        [Required]
        public int UnitQuantity { get; set; }
        [Required]
        [StringLength(50)]
        public UnitType UnitType { get; set; }
        [Required]
        public decimal DosageQuantity { get; set; }
        [Required]
        [StringLength(50)]
        public DosageUnit DosageUnit { get; set; }
        [Required]
        [StringLength(500)]
        public string? Manufacturer { get; set; }
        [Required]
        public DateTime ManufacturedDate { get; set; }
        [Required]
        [StringLength(500)]
        public string? ActiveIngredient { get; set; }
        [Required]
        public DateTime ExpiryDate { get; set; }
        [Required]
        public bool Status { get; set; }
    }
}
