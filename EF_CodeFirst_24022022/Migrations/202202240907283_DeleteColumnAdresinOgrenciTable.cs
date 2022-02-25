namespace EF_CodeFirst_24022022.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteColumnAdresinOgrenciTable : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Ogrenciler", "Adres");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Ogrenciler", "Adres", c => c.String());
        }
    }
}
