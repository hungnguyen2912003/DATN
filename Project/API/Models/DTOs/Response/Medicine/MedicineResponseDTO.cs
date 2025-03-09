using API.Models.Enums.Medicine;

namespace API.Models.DTOs.Response.Medicine
{
    public class MedicineResponseDTO
    {
        public Guid Id { get; set; }
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
    }
}
