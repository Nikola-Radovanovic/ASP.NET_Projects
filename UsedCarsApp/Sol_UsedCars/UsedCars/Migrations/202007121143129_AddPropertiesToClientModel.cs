namespace UsedCars.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPropertiesToClientModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clients", "Name", c => c.String(nullable: false, maxLength: 40));
            AddColumn("dbo.Clients", "LastName", c => c.String(nullable: false, maxLength: 40));
            AddColumn("dbo.Clients", "Address", c => c.String(nullable: false, maxLength: 70));
            AddColumn("dbo.Clients", "City", c => c.String(nullable: false, maxLength: 40));
            AddColumn("dbo.Clients", "PostalCode", c => c.String(nullable: false, maxLength: 10));
            AddColumn("dbo.Clients", "Country", c => c.String(nullable: false, maxLength: 30));
            AddColumn("dbo.Clients", "Phone", c => c.String(nullable: false, maxLength: 20));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Clients", "Phone");
            DropColumn("dbo.Clients", "Country");
            DropColumn("dbo.Clients", "PostalCode");
            DropColumn("dbo.Clients", "City");
            DropColumn("dbo.Clients", "Address");
            DropColumn("dbo.Clients", "LastName");
            DropColumn("dbo.Clients", "Name");
        }
    }
}
