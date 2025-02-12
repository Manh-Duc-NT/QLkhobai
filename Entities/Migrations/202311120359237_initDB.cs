namespace Entities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LichDatTramEntities",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Tram = c.Long(nullable: false),
                        TenTaiXe = c.String(),
                        BienSoXe = c.String(),
                        ThoiGianDen = c.DateTime(nullable: false),
                        ThoiGianDi = c.DateTime(nullable: false),
                        NgayTao = c.DateTime(nullable: false),
                        NgayCapNhat = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.NguoiDungEntities",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Ten = c.String(nullable: false, maxLength: 250),
                        NgaySinh = c.DateTime(nullable: false),
                        Email = c.String(),
                        TenDangNhap = c.String(),
                        MatKhau = c.String(),
                        SDT = c.String(),
                        DiaChi = c.String(),
                        ChucVu = c.Int(nullable: false),
                        NgayTao = c.DateTime(nullable: false),
                        NgayCapNhat = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TramEntities",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Ten = c.String(nullable: false, maxLength: 250),
                        HinhAnh = c.String(),
                        KhuVuc = c.Int(nullable: false),
                        SoLuongXe = c.Double(nullable: false),
                        NguoiQuanLy = c.Long(nullable: false),
                        ThoiGianMoCua = c.DateTime(nullable: false),
                        ThoiGianDongCua = c.DateTime(nullable: false),
                        NgayTao = c.DateTime(nullable: false),
                        NgayCapNhat = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TramEntities");
            DropTable("dbo.NguoiDungEntities");
            DropTable("dbo.LichDatTramEntities");
        }
    }
}
