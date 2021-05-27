using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace QLNS
{
    [Table("NhanVien")]
    public class NhanVien
    {
        [Key]
        [StringLength(10)]
        public string MaNV { get; set; }
        [StringLength(30)]
        public string HoTen { get; set; }
        [DataType(DataType.Date)]
        public DateTime NgaySinh { get; set; }
        [StringLength(50)]
        public string Email { get; set; }
        [StringLength(250)]
        public string DiaChi { get; set; }
        [StringLength(10)]
        public string PhongBanId { get; set; }
        public virtual PhongBan PhongBan { get; set; }

    }
}
