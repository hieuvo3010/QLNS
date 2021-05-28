using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLNS
{
    [Table("TaiKhoan")]
    public class TaiKhoan
    {
        [Key]
        [StringLength(30)]
        public string TenDangNhap { get; set; }
        [StringLength(30)]
        public string MatKhau { get; set; }
        [StringLength(10)]
        public string Quyen { get; set; }
    }
}
