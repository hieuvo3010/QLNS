namespace QLNS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FifthMigrationManyToManyWithPhongBanTableAndDuAnTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PhanCong",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 10),
                        IdNhanVien = c.String(maxLength: 10),
                        IdPhongBan = c.String(maxLength: 10),
                        NhanVien_MaNV = c.String(maxLength: 10),
                        PhongBan_MaPhong = c.String(maxLength: 10),
                        DuAn_MaDA = c.String(maxLength: 10),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.NhanVien", t => t.NhanVien_MaNV)
                .ForeignKey("dbo.PhongBan", t => t.PhongBan_MaPhong)
                .ForeignKey("dbo.DuAns", t => t.DuAn_MaDA)
                .Index(t => t.NhanVien_MaNV)
                .Index(t => t.PhongBan_MaPhong)
                .Index(t => t.DuAn_MaDA);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PhanCong", "DuAn_MaDA", "dbo.DuAns");
            DropForeignKey("dbo.PhanCong", "PhongBan_MaPhong", "dbo.PhongBan");
            DropForeignKey("dbo.PhanCong", "NhanVien_MaNV", "dbo.NhanVien");
            DropIndex("dbo.PhanCong", new[] { "DuAn_MaDA" });
            DropIndex("dbo.PhanCong", new[] { "PhongBan_MaPhong" });
            DropIndex("dbo.PhanCong", new[] { "NhanVien_MaNV" });
            DropTable("dbo.PhanCong");
        }
    }
}
