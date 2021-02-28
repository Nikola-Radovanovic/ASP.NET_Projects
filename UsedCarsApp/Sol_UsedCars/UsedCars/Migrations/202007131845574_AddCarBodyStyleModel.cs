namespace UsedCars.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCarBodyStyleModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CarBodyStyles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CarBodyStyles");
        }
    }
}
