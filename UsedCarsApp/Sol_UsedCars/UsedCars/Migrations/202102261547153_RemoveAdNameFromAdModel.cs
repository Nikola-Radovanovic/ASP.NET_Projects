namespace UsedCars.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveAdNameFromAdModel : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Ads", "AdName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Ads", "AdName", c => c.String(nullable: false, maxLength: 100));
        }
    }
}
