namespace UsedCars.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MakeCarBodyStyleForeignKeyInCarsDatatable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cars", "CarBodyStyleId", c => c.Int(nullable: false));
            CreateIndex("dbo.Cars", "CarBodyStyleId");
            AddForeignKey("dbo.Cars", "CarBodyStyleId", "dbo.CarBodyStyles", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cars", "CarBodyStyleId", "dbo.CarBodyStyles");
            DropIndex("dbo.Cars", new[] { "CarBodyStyleId" });
            DropColumn("dbo.Cars", "CarBodyStyleId");
        }
    }
}
