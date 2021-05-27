using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace QLNS
{
    [Table("PhongBan")]
    public class PhongBan
    {
        [Key]
        [StringLength(10)]
        public string MaPhong { get; set; }
        [StringLength(30)]
        public string TenPhong { get; set; }
        //phongban có nhiều nhân viên
        public virtual ICollection<NhanVien> NhanViens { get; set; }
    }
}
