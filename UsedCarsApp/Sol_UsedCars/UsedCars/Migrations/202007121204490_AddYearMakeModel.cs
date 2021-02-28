namespace UsedCars.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddYearMakeModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.YearMakes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Year = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.YearMakes");
        }
    }
}
