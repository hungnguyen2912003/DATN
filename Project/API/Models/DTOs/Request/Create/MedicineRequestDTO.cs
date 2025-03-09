using API.Models.Enums.Medicine;
using System.ComponentModel.DataAnnotations;

namespace API.Models.DTOs.Request.Create
{
    public class MedicineRequestDTO
    {
        public string? MedicineCode { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Image { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int UnitQuantity { get; set; }
        public UnitType UnitType { get; set; }
        public decimal DosageQuantity { get; set; }
        public DosageUnit DosageUnit { get; set; }
        public string? Manufacturer { get; set; }
        public DateTime ManufacturedDate { get; set; }
        public string? ActiveIngredient { get; set; }
        public DateTime ExpiryDate { get; set; }
        public bool Status { get; set; }
        public Guid MedicineCategoryId { get; set; }
    }
}
