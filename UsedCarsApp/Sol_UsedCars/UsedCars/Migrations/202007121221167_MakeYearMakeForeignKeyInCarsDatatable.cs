namespace UsedCars.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MakeYearMakeForeignKeyInCarsDatatable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cars", "YearMakeId", c => c.Int(nullable: false));
            CreateIndex("dbo.Cars", "YearMakeId");
            AddForeignKey("dbo.Cars", "YearMakeId", "dbo.YearMakes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cars", "YearMakeId", "dbo.YearMakes");
            DropIndex("dbo.Cars", new[] { "YearMakeId" });
            DropColumn("dbo.Cars", "YearMakeId");
        }
    }
}
