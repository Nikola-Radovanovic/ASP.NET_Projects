namespace UsedCars.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCarConditionBoolPropertiesToCarModel : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Cars", "CarConditionId", "dbo.CarConditions");
            DropIndex("dbo.Cars", new[] { "CarConditionId" });
            AddColumn("dbo.Cars", "FirstOwner", c => c.Boolean(nullable: false));
            AddColumn("dbo.Cars", "Warranty", c => c.Boolean(nullable: false));
            AddColumn("dbo.Cars", "Garaged", c => c.Boolean(nullable: false));
            AddColumn("dbo.Cars", "ServiceBook", c => c.Boolean(nullable: false));
            AddColumn("dbo.Cars", "SpareKey", c => c.Boolean(nullable: false));
            AddColumn("dbo.Cars", "Restaurated", c => c.Boolean(nullable: false));
            AddColumn("dbo.Cars", "Oldtimer", c => c.Boolean(nullable: false));
            AddColumn("dbo.Cars", "AdaptedForTheDisabled", c => c.Boolean(nullable: false));
            AddColumn("dbo.Cars", "TaxiCar", c => c.Boolean(nullable: false));
            AddColumn("dbo.Cars", "TestCar", c => c.Boolean(nullable: false));
            AddColumn("dbo.Cars", "Tuning", c => c.Boolean(nullable: false));
            DropColumn("dbo.Cars", "CarConditionId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Cars", "CarConditionId", c => c.Int(nullable: false));
            DropColumn("dbo.Cars", "Tuning");
            DropColumn("dbo.Cars", "TestCar");
            DropColumn("dbo.Cars", "TaxiCar");
            DropColumn("dbo.Cars", "AdaptedForTheDisabled");
            DropColumn("dbo.Cars", "Oldtimer");
            DropColumn("dbo.Cars", "Restaurated");
            DropColumn("dbo.Cars", "SpareKey");
            DropColumn("dbo.Cars", "ServiceBook");
            DropColumn("dbo.Cars", "Garaged");
            DropColumn("dbo.Cars", "Warranty");
            DropColumn("dbo.Cars", "FirstOwner");
            CreateIndex("dbo.Cars", "CarConditionId");
            AddForeignKey("dbo.Cars", "CarConditionId", "dbo.CarConditions", "Id", cascadeDelete: true);
        }
    }
}
