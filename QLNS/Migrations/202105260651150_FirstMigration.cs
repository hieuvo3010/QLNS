namespace QLNS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NhanVien",
                c => new
                    {
                        MaNV = c.String(nullable: false, maxLength: 10),
                        HoTen = c.String(maxLength: 30),
                        NgaySinh = c.DateTime(nullable: false),
                        Email = c.String(maxLength: 50),
                        DiaChi = c.String(maxLength: 250),
                    })
                .PrimaryKey(t => t.MaNV);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.NhanVien");
        }
    }
}
