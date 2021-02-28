namespace UsedCars.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCarConditionModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CarConditions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Condition = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CarConditions");
        }
    }
}
