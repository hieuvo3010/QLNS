using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace QLNS
{
    [Table("PhanCong")]
    public class PhanCong
    {
        [Key]
        [StringLength(10)]
        public string Id { get; set; }

        [StringLength(10)]
        public string IdNhanVien { get; set; }
        public virtual NhanVien NhanVien { get; set; }

        [StringLength(10)]
        public string IdDuAn { get; set; }
        public virtual DuAn DuAn { get; set; }


    }
}
