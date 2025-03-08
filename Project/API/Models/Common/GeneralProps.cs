namespace API.Models.Common
{
    public abstract class GeneralProps
    {
        // Người tạo
        public string CreatedBy { get; set; }
        // Ngày tạo
        public DateTime CreatedAt { get; set; }
        // Người cập nhật
        public string UpdatedBy { get; set; }
        // Ngày cập nhật
        public DateTime UpdatedAt { get; set; }
    }
}
