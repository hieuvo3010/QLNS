using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace QLNS
{
    public class DuAn
    {
        [Key]
        [StringLength(10)]
        public string MaDA { get; set; }
        [StringLength(30)]
        public string TenDA { get; set; }
        [StringLength(30)]
        public string DiaDiem { get; set; }
        // do 1 pb
        [StringLength(10)]
        public string PhongBanId { get; set; }
        public virtual PhongBan PhongBan { get; set; }

        public virtual ICollection<PhanCong> PhanCongs { get; set; }
    }
}
