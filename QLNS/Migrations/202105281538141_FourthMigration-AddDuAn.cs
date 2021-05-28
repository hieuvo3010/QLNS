namespace QLNS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FourthMigrationAddDuAn : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DuAns",
                c => new
                    {
                        MaDA = c.String(nullable: false, maxLength: 10),
                        TenDA = c.String(maxLength: 30),
                        DiaDiem = c.String(maxLength: 30),
                        PhongBanId = c.String(maxLength: 10),
                        PhongBan_MaPhong = c.String(maxLength: 10),
                    })
                .PrimaryKey(t => t.MaDA)
                .ForeignKey("dbo.PhongBan", t => t.PhongBan_MaPhong)
                .Index(t => t.PhongBan_MaPhong);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DuAns", "PhongBan_MaPhong", "dbo.PhongBan");
            DropIndex("dbo.DuAns", new[] { "PhongBan_MaPhong" });
            DropTable("dbo.DuAns");
        }
    }
}
