﻿using API.Models.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models.Entities
{
    [Table("Department")]
    public class Department : GeneralProps
    {
        [Key]
        // ID
        public Guid Id { get; set; }
        // Mã phòng ban
        [Required]
        [StringLength(20)]
        public string? DepartmentCode { get; set; }
        [Required]
        [StringLength(50)]
        // Tên phòng ban
        public string? Name { get; set; }
        [StringLength(500)]
        // Mô tả
        public string? Description { get; set; }
        [Required]
        // Trạng thái phòng ban
        public bool Status { get; set; }

        /////////////////////////////////////////////////////
        /// Relationships
        public virtual ICollection<Employee>? Employees { get; set; }
        public virtual ICollection<TreatmentMethod>? TreatmentMethods { get; set; }
    }
}
