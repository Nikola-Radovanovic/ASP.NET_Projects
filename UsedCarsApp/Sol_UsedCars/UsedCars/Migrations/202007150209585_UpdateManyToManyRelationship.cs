namespace UsedCars.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateManyToManyRelationship : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Ads");
            AddColumn("dbo.Ads", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Ads", "Id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Ads");
            DropColumn("dbo.Ads", "Id");
            AddPrimaryKey("dbo.Ads", new[] { "ClientId", "CarId" });
        }
    }
}
