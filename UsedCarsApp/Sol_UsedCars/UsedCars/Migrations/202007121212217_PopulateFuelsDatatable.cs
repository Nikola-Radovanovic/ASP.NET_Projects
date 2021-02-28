namespace UsedCars.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateFuelsDatatable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Fuels (Type) VALUES ('Gasoline')");
            Sql("INSERT INTO Fuels (Type) VALUES ('Diesel')");
            Sql("INSERT INTO Fuels (Type) VALUES ('TNG')");
            Sql("INSERT INTO Fuels (Type) VALUES ('Metan(CNG)')");
            Sql("INSERT INTO Fuels (Type) VALUES ('E-Car')");
            Sql("INSERT INTO Fuels (Type) VALUES ('Hybrid')");
        }
        
        public override void Down()
        {
        }
    }
}
