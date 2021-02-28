namespace UsedCars.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MakeCarConditionForeignKeyInCarsDatatable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cars", "CarConditionId", c => c.Int(nullable: false));
            CreateIndex("dbo.Cars", "CarConditionId");
            AddForeignKey("dbo.Cars", "CarConditionId", "dbo.CarConditions", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cars", "CarConditionId", "dbo.CarConditions");
            DropIndex("dbo.Cars", new[] { "CarConditionId" });
            DropColumn("dbo.Cars", "CarConditionId");
        }
    }
}
