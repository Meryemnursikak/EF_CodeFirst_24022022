namespace EF_CodeFirst_24022022.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ogrenciler",
                c => new
                    {
                        Ogrid = c.Int(nullable: false, identity: true),
                        Isim = c.String(nullable: false, maxLength: 20),
                        Soyisim = c.String(nullable: false, maxLength: 20),
                        Okulno = c.String(),
                        Tcno = c.String(),
                    })
                .PrimaryKey(t => t.Ogrid);
            
            CreateTable(
                "dbo.Ogretmen",
                c => new
                    {
                        Ogrtid = c.Int(nullable: false, identity: true),
                        Isim = c.String(nullable: false, maxLength: 20),
                        Soyisim = c.String(nullable: false, maxLength: 20),
                        Tcno = c.String(),
                    })
                .PrimaryKey(t => t.Ogrtid);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Ogretmen");
            DropTable("dbo.Ogrenciler");
        }
    }
}
