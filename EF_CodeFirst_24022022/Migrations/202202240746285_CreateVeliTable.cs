namespace EF_CodeFirst_24022022.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateVeliTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Velis",
                c => new
                    {
                        Veliid = c.Int(nullable: false, identity: true),
                        isim = c.String(nullable: false, maxLength: 20),
                        Soyisim = c.String(nullable: false, maxLength: 20),
                        Telno = c.String(maxLength: 11),
                        Adres = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Veliid);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Velis");
        }
    }
}
