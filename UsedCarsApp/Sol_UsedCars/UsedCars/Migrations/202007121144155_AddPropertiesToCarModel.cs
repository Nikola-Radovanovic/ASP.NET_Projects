namespace UsedCars.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPropertiesToCarModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cars", "Model", c => c.String(nullable: false, maxLength: 40));
            AddColumn("dbo.Cars", "Kilometers", c => c.Int(nullable: false));
            AddColumn("dbo.Cars", "CubicCapacity", c => c.Int(nullable: false));
            AddColumn("dbo.Cars", "HorsePower", c => c.Int(nullable: false));
            AddColumn("dbo.Cars", "Price", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Cars", "Price");
            DropColumn("dbo.Cars", "HorsePower");
            DropColumn("dbo.Cars", "CubicCapacity");
            DropColumn("dbo.Cars", "Kilometers");
            DropColumn("dbo.Cars", "Model");
        }
    }
}
