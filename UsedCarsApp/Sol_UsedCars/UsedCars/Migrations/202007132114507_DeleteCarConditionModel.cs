namespace UsedCars.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteCarConditionModel : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.CarConditions");
        }
        
        public override void Down()
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
    }
}
