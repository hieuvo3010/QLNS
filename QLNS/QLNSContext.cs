using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace QLNS
{
    public class QLNSContext : DbContext
    {
        public QLNSContext()
            : base("qlns")
        {

        }

        public DbSet<NhanVien> NhanViens { get; set; }
        public DbSet<PhongBan> PhongBans { get; set; }
        public DbSet<TaiKhoan> TaiKhoans { get; set; }
        public DbSet<DuAn> DuAns { get; set; }
        public DbSet<PhanCong> PhanCongs { get; set; }
    }
}
