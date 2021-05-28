namespace QLNS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ThreeMigrationAddTaiKhoan : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TaiKhoan",
                c => new
                    {
                        TenDangNhap = c.String(nullable: false, maxLength: 30),
                        MatKhau = c.String(maxLength: 30),
                        Quyen = c.String(maxLength: 10),
                    })
                .PrimaryKey(t => t.TenDangNhap);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TaiKhoan");
        }
    }
}
