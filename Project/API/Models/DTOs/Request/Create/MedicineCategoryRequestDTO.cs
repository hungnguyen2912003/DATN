using System.ComponentModel.DataAnnotations;

namespace API.Models.DTOs.Request.Create
{
    public class MedicineCategoryRequestDTO
    {
        [Required]
        public string? MedicineCategoryCode { get; set; }
        [Required]
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Image { get; set; }
        [Required]
        public bool Status { get; set; }
    }
}
