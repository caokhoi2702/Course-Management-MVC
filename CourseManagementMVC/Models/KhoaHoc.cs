using CourseManagementMVC.Services;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CourseManagementMVC.Models
{
    [Table("KhoaHoc")]
    public class KhoaHoc
    {
        public int ID { get; set; }
        [MaxLength(30)]
        public string? TenKhoaHoc { get; set; } = string.Empty;

    }
}
