namespace UsedCars.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MakeFuelForeignKeyInCarsDatatable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cars", "FuelId", c => c.Int(nullable: false));
            CreateIndex("dbo.Cars", "FuelId");
            AddForeignKey("dbo.Cars", "FuelId", "dbo.Fuels", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cars", "FuelId", "dbo.Fuels");
            DropIndex("dbo.Cars", new[] { "FuelId" });
            DropColumn("dbo.Cars", "FuelId");
        }
    }
}
