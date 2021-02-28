namespace UsedCars.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCarBodyStylesDatatable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO CarBodyStyles (Type) VALUES ('Limousine')");
            Sql("INSERT INTO CarBodyStyles (Type) VALUES ('Hatchback')");
            Sql("INSERT INTO CarBodyStyles (Type) VALUES ('Caravan')");
            Sql("INSERT INTO CarBodyStyles (Type) VALUES ('Coupe')");
            Sql("INSERT INTO CarBodyStyles (Type) VALUES ('Convertible/Roadster')");
            Sql("INSERT INTO CarBodyStyles (Type) VALUES ('MiniVan')");
            Sql("INSERT INTO CarBodyStyles (Type) VALUES ('Jeep/SUV')");
            Sql("INSERT INTO CarBodyStyles (Type) VALUES ('PickUp')");
        }
        
        public override void Down()
        {
        }
    }
}
