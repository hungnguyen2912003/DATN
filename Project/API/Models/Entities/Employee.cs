using API.Models.Common;
using API.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models.Entities
{
    [Table("Employee")]
    public class Employee : GeneralProps
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string? FullName { get; set; }
        [Required]
        public GenderType Gender { get; set; }
        [Required]
        [StringLength(12, MinimumLength = 9)]
        public string? IdentityCard { get; set; }
        [Required]
        [EmailAddress]
        public string? Email { get; set; }
        [Required]
        [Phone]
        public string? PhoneNumber { get; set; }
        [Required]
        [MaxLength(500)]
        public string? Address { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        [Required]
        [MaxLength(500)]
        public string? Degree { get; set; }
        [Required]
        [MaxLength(500)]
        public string? ProfessionalQualification { get; set; }
        [Required]
        [MaxLength(500)]
        public string? Image { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public EmployeeStatus Status { get; set; }
    }
}
