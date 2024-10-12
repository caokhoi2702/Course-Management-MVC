using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CourseManagementMVC.Models
{
    [Table("MonHoc")]
    public class MonHoc
    {
        public int ID { get; set; }
        [MaxLength(100)]
        public string? TenMonHoc { get; set; } = string.Empty;
        [MaxLength(100)]
        public string? MoTa { get; set; } = string.Empty;
        [MaxLength(100)]
        public int KhoaHocID { get; set; }
    }
}
