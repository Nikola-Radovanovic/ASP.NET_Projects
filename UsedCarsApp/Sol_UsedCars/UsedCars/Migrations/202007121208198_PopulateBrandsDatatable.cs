namespace UsedCars.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateBrandsDatatable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Brands (Name) VALUES ('Alfa Romeo')");
            Sql("INSERT INTO Brands (Name) VALUES ('Aston Martin')");
            Sql("INSERT INTO Brands (Name) VALUES ('Audi')");
            Sql("INSERT INTO Brands (Name) VALUES ('Bentley')");
            Sql("INSERT INTO Brands (Name) VALUES ('BMW')");
            Sql("INSERT INTO Brands (Name) VALUES ('Cadillac')");
            Sql("INSERT INTO Brands (Name) VALUES ('Chery')");
            Sql("INSERT INTO Brands (Name) VALUES ('Chevrolet')");
            Sql("INSERT INTO Brands (Name) VALUES ('Chrysler')");
            Sql("INSERT INTO Brands (Name) VALUES ('Citroen')");
            Sql("INSERT INTO Brands (Name) VALUES ('Dacia')");
            Sql("INSERT INTO Brands (Name) VALUES ('Daewoo')");
            Sql("INSERT INTO Brands (Name) VALUES ('Daihatsu')");
            Sql("INSERT INTO Brands (Name) VALUES ('Dodge')");
            Sql("INSERT INTO Brands (Name) VALUES ('Ferrari')");
            Sql("INSERT INTO Brands (Name) VALUES ('Fiat')");
            Sql("INSERT INTO Brands (Name) VALUES ('Ford')");
            Sql("INSERT INTO Brands (Name) VALUES ('GMC')");
            Sql("INSERT INTO Brands (Name) VALUES ('Honda')");
            Sql("INSERT INTO Brands (Name) VALUES ('Hummer')");
            Sql("INSERT INTO Brands (Name) VALUES ('Hyndai')");
            Sql("INSERT INTO Brands (Name) VALUES ('Infinity')");
            Sql("INSERT INTO Brands (Name) VALUES ('Isuzu')");
            Sql("INSERT INTO Brands (Name) VALUES ('Jaguar')");
            Sql("INSERT INTO Brands (Name) VALUES ('Jeep')");
            Sql("INSERT INTO Brands (Name) VALUES ('Kia')");
            Sql("INSERT INTO Brands (Name) VALUES ('Lada')");
            Sql("INSERT INTO Brands (Name) VALUES ('Lamborghini')");
            Sql("INSERT INTO Brands (Name) VALUES ('Lancia')");
            Sql("INSERT INTO Brands (Name) VALUES ('Land Rover')");
            Sql("INSERT INTO Brands (Name) VALUES ('Lexus')");
            Sql("INSERT INTO Brands (Name) VALUES ('Mahindra')");
            Sql("INSERT INTO Brands (Name) VALUES ('Maserati')");
            Sql("INSERT INTO Brands (Name) VALUES ('Maybach')");
            Sql("INSERT INTO Brands (Name) VALUES ('Mazda')");
            Sql("INSERT INTO Brands (Name) VALUES ('Mercedes Benz')");
            Sql("INSERT INTO Brands (Name) VALUES ('Mini')");
            Sql("INSERT INTO Brands (Name) VALUES ('Mitsubishi')");
            Sql("INSERT INTO Brands (Name) VALUES ('Nissan')");
            Sql("INSERT INTO Brands (Name) VALUES ('Opel')");
            Sql("INSERT INTO Brands (Name) VALUES ('Peugeot')");
            Sql("INSERT INTO Brands (Name) VALUES ('Pontiac')");
            Sql("INSERT INTO Brands (Name) VALUES ('Porsche')");
            Sql("INSERT INTO Brands (Name) VALUES ('Renault')");
            Sql("INSERT INTO Brands (Name) VALUES ('Rolls Royce')");
            Sql("INSERT INTO Brands (Name) VALUES ('Rover')");
            Sql("INSERT INTO Brands (Name) VALUES ('Saab')");
            Sql("INSERT INTO Brands (Name) VALUES ('Seat')");
            Sql("INSERT INTO Brands (Name) VALUES ('Smart')");
            Sql("INSERT INTO Brands (Name) VALUES ('Subaru')");
            Sql("INSERT INTO Brands (Name) VALUES ('Suzuki')");
            Sql("INSERT INTO Brands (Name) VALUES ('Tesla')");
            Sql("INSERT INTO Brands (Name) VALUES ('Toyota')");
            Sql("INSERT INTO Brands (Name) VALUES ('Volkswagen')");
            Sql("INSERT INTO Brands (Name) VALUES ('Volvo')");
            Sql("INSERT INTO Brands (Name) VALUES ('Zastava')");
            Sql("INSERT INTO Brands (Name) VALUES ('Škoda')");
            Sql("INSERT INTO Brands (Name) VALUES ('Ostalo')");
        }
        
        public override void Down()
        {
        }
    }
}
