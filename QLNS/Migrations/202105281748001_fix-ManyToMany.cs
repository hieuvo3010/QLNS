namespace QLNS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixManyToMany : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.PhanCong", "PhongBan_MaPhong", "dbo.PhongBan");
            DropIndex("dbo.PhanCong", new[] { "PhongBan_MaPhong" });
            AddColumn("dbo.PhanCong", "IdDuAn", c => c.String(maxLength: 10));
            DropColumn("dbo.PhanCong", "IdPhongBan");
            DropColumn("dbo.PhanCong", "PhongBan_MaPhong");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PhanCong", "PhongBan_MaPhong", c => c.String(maxLength: 10));
            AddColumn("dbo.PhanCong", "IdPhongBan", c => c.String(maxLength: 10));
            DropColumn("dbo.PhanCong", "IdDuAn");
            CreateIndex("dbo.PhanCong", "PhongBan_MaPhong");
            AddForeignKey("dbo.PhanCong", "PhongBan_MaPhong", "dbo.PhongBan", "MaPhong");
        }
    }
}
