namespace UsedCars.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateColorsDatatable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Colors (Name) VALUES ('Blue')");
            Sql("INSERT INTO Colors (Name) VALUES ('Red')");
            Sql("INSERT INTO Colors (Name) VALUES ('Yellow')");
            Sql("INSERT INTO Colors (Name) VALUES ('Green')");
            Sql("INSERT INTO Colors (Name) VALUES ('Black')");
            Sql("INSERT INTO Colors (Name) VALUES ('White')");
            Sql("INSERT INTO Colors (Name) VALUES ('Gray')");
            Sql("INSERT INTO Colors (Name) VALUES ('Brown')");
            Sql("INSERT INTO Colors (Name) VALUES ('Pink')");
            Sql("INSERT INTO Colors (Name) VALUES ('Violet')");
            Sql("INSERT INTO Colors (Name) VALUES ('Orange')");
            Sql("INSERT INTO Colors (Name) VALUES ('Gold')");
            Sql("INSERT INTO Colors (Name) VALUES ('Silver')");
            Sql("INSERT INTO Colors (Name) VALUES ('Beige')");
        }
        
        public override void Down()
        {
        }
    }
}
