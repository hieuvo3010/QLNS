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
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(QLNS.QLNSContext context)
        {
            //  This method will be called after migrating to the latest version.
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-GB"); //dd/MM/yyyy
            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            //add tt nhân viên
            //context.NhanViens.AddOrUpdate(p => p.MaNV, new NhanVien() { MaNV = "sf001", HoTen = "Hiếu Võ", NgaySinh = DateTime.Parse("30/10/2000"), Email = "hieuvokt123@gmail.com", DiaChi = "Kon Tum" },
            //  new NhanVien() { MaNV = "sf002", HoTen = "Nguyễn Duy Khang", NgaySinh = DateTime.Parse("10/10/2000"), Email = "svdc00001@gmail.com", DiaChi = "Bến Tre" },
            //  new NhanVien() { MaNV = "sf003", HoTen = "Trần Quang Huy", NgaySinh = DateTime.Parse("20/10/2000"), Email = "huytran123@gmail.com", DiaChi = "Kon Tum" });

            ////add tt pb
            //context.PhongBans.AddOrUpdate(p => p.MaPhong, new PhongBan() { MaPhong = "KTDL", TenPhong = "Kĩ thuật dữ liệu"},
            // new PhongBan() { MaPhong = "CNTT", TenPhong = "Công nghệ thông tin" },
            //  new PhongBan() { MaPhong = "TMDT", TenPhong = "Thương mại điện tử"});

            // add tt tài khoản đăng nhập
            context.TaiKhoans.AddOrUpdate(p => p.TenDangNhap, new TaiKhoan() { TenDangNhap = "admin", MatKhau = "admin", Quyen = "admin" },
               new TaiKhoan() { TenDangNhap = "user", MatKhau = "123", Quyen = "user" });
        }
    }
}
 