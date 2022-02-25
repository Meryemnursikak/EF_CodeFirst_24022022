namespace EF_CodeFirst_24022022.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameColumnDersSaatiDersTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Ders", "DersSaati", c => c.Byte(nullable: false));
            DropColumn("dbo.Ders", "saati");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Ders", "saati", c => c.Byte(nullable: false));
            DropColumn("dbo.Ders", "DersSaati");
        }
    }
}
