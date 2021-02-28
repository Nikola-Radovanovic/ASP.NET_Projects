namespace UsedCars.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MakeBrandForeignKeyInCarsDatatable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cars", "BrandId", c => c.Int(nullable: false));
            CreateIndex("dbo.Cars", "BrandId");
            AddForeignKey("dbo.Cars", "BrandId", "dbo.Brands", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cars", "BrandId", "dbo.Brands");
            DropIndex("dbo.Cars", new[] { "BrandId" });
            DropColumn("dbo.Cars", "BrandId");
        }
    }
}
