namespace QLNS.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Globalization;
    using System.Linq;
    using System.Threading;

    internal sealed class Configuration : DbMigrationsConfiguration<QLNS.QLNSContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(QLNS.QLNSContext context)
        {
            //  This method will be called after migrating to the latest version.
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-GB"); //dd/MM/yyyy
            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            //add tt nhân viên
            context.NhanViens.AddOrUpdate(p => p.MaNV, new NhanVien() { MaNV = "sf001", HoTen = "Hiếu Võ", NgaySinh = DateTime.Parse("30/10/2000"), Email = "hieuvokt123@gmail.com", DiaChi = "KonTum" },
              new NhanVien() { MaNV = "sf002", HoTen = "Hiếu Võ 2", NgaySinh = DateTime.Parse("10/10/2000"), Email = "hieuvokt1234@gmail.com", DiaChi = "KonTum" },
              new NhanVien() { MaNV = "sf003", HoTen = "Hiếu Võ 3", NgaySinh = DateTime.Parse("20/10/2000"), Email = "hieuvokt1235@gmail.com", DiaChi = "KonTum" });

            //add tt pb
            context.PhongBans.AddOrUpdate(p => p.MaPhong, new PhongBan() { MaPhong = "sf001", TenPhong = "Hiếu Võ"},
             new PhongBan() { MaPhong = "CNTT", TenPhong = "Cong nghe thong tin" },
              new PhongBan() { MaPhong = "dt", TenPhong = "Dien tu"});
        }
    }
}
 