namespace UsedCars.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MakeColorForeignKeyInCarsDatatable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cars", "ColorId", c => c.Int(nullable: false));
            CreateIndex("dbo.Cars", "ColorId");
            AddForeignKey("dbo.Cars", "ColorId", "dbo.Colors", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cars", "ColorId", "dbo.Colors");
            DropIndex("dbo.Cars", new[] { "ColorId" });
            DropColumn("dbo.Cars", "ColorId");
        }
    }
}
