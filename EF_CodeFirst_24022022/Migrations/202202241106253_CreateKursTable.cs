namespace EF_CodeFirst_24022022.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateKursTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Kurs",
                c => new
                    {
                        Kursid = c.Int(nullable: false, identity: true),
                        Kursadi = c.String(),
                        KusrSaati = c.String(),
                    })
                .PrimaryKey(t => t.Kursid);
            Sql("insert into Kurs values('Matematik','4')");
        }
        
        public override void Down()
        {
            DropTable("dbo.Kurs");
        }
    }
}
