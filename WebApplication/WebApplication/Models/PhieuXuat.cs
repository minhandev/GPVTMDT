using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplication.Models
{
    public class PhieuXuat
    {
        [Key]
        public int ID_PhieuXuat { get; set; }
        public int ID_NhanVien { get; set; }
        public DateTime ThoiGian { get; set; }
        public string Note { get; set; }
    }
}
