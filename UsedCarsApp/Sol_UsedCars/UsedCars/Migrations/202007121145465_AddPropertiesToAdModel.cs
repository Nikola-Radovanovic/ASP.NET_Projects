namespace UsedCars.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPropertiesToAdModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Ads", "AdName", c => c.String(nullable: false, maxLength: 100));
            AddColumn("dbo.Ads", "DatePosted", c => c.DateTime(nullable: false));
            AddColumn("dbo.Ads", "Description", c => c.String(maxLength: 1000));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Ads", "Description");
            DropColumn("dbo.Ads", "DatePosted");
            DropColumn("dbo.Ads", "AdName");
        }
    }
}
