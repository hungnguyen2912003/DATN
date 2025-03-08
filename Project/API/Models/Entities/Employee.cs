using API.Models.Common;
using API.Models.Enums.Employee;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models.Entities
{
    [Table("Employee")]
    public class Employee : GeneralProps
    {
        [Key]
        // ID
        public Guid Id { get; set; }
        // Mã nhân viên
        [Required]
        [StringLength(10)]
        public string? EmployeeCode { get; set; }
        [Required]
        [StringLength(50)]
        // Họ tên nhân viên
        public string? FullName { get; set; }
        [Required]
        // Giới tính
        public GenderType Gender { get; set; }
        [Required]
        [StringLength(12, MinimumLength = 9)]
        // Chứng minh thư
        public string? IdentityCard { get; set; }
        [Required]
        [EmailAddress]
        // Email
        public string? Email { get; set; }
        [Required]
        [Phone]
        // Số điện thoại
        public string? PhoneNumber { get; set; }
        [Required]
        [StringLength(500)]
        // Địa chỉ
        public string? Address { get; set; }
        [Required]
        // Ngày sinh
        public DateTime DateOfBirth { get; set; }
        [Required]
        [StringLength(500)]
        // Bằng cấp
        public string? Degree { get; set; }
        [Required]
        [StringLength(500)]
        // Trình độ chuyên môn
        public string? ProfessionalQualification { get; set; }
        [Required]
        [StringLength(500)]
        // Hình ảnh
        public string? Image { get; set; }
        [Required]
        // Ngày bắt đầu làm việc
        public DateTime StartDate { get; set; }
        [Required]
        // Trạng thái nhân viên
        public EmployeeStatus Status { get; set; }


        // Foreign Key
        public Guid DepartmentId { get; set; }
        public Guid EmployeeCategoryId { get; set; }

        /////////////////////////////////////////////////////
        /// Relationships
        [ForeignKey("DepartmentId")]
        public virtual Department? Department { get; set; }
        [ForeignKey("EmployeeCategoryId")]
        public virtual EmployeeCategory? EmployeeCategory { get; set; }
    }
}
