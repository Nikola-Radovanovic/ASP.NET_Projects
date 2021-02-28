namespace UsedCars.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MakeCompositeKeyInAdsDatatable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ads",
                c => new
                    {
                        ClientId = c.Int(nullable: false),
                        CarId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ClientId, t.CarId })
                .ForeignKey("dbo.Cars", t => t.CarId, cascadeDelete: true)
                .ForeignKey("dbo.Clients", t => t.ClientId, cascadeDelete: true)
                .Index(t => t.ClientId)
                .Index(t => t.CarId);
            
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Ads", "ClientId", "dbo.Clients");
            DropForeignKey("dbo.Ads", "CarId", "dbo.Cars");
            DropIndex("dbo.Ads", new[] { "CarId" });
            DropIndex("dbo.Ads", new[] { "ClientId" });
            DropTable("dbo.Clients");
            DropTable("dbo.Cars");
            DropTable("dbo.Ads");
        }
    }
}
