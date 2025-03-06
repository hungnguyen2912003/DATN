using API.Models.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models.Entities
{
    [Table("EmployeeType")]
    public class EmployeeType : GeneralProps
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [StringLength(500)]
        public string? Name { get; set; }
        [StringLength(500)]
        public string? Description { get; set; }
    }
}
