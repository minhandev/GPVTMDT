using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

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
