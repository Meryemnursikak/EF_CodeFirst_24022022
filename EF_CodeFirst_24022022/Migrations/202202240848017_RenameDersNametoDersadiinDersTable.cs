namespace EF_CodeFirst_24022022.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameDersNametoDersadiinDersTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Ders", "DersName", c => c.String());
            Sql("Update Ders set DersName=DersAdi");
            DropColumn("dbo.Ders", "Dersadi");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Ders", "Dersadi", c => c.String());
            DropColumn("dbo.Ders", "DersName");
        }
    }
}
