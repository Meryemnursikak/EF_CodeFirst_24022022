namespace EF_CodeFirst_24022022.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateSaatColumninDersTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Ders", "saati", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Ders", "saati");
        }
    }
}
