namespace EF_CodeFirst_24022022.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteOgrenciDersTable : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.OgrenciDers");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.OgrenciDers",
                c => new
                    {
                        Ogrenciid = c.Int(nullable: false),
                        Dersid = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Ogrenciid, t.Dersid });
            
        }
    }
}
