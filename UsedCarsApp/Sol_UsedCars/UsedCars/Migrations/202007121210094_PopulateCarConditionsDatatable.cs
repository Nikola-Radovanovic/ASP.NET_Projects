namespace UsedCars.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCarConditionsDatatable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO CarConditions (Condition) VALUES ('First owner')");
            Sql("INSERT INTO CarConditions (Condition) VALUES ('Warranty')");
            Sql("INSERT INTO CarConditions (Condition) VALUES ('Garaged')");
            Sql("INSERT INTO CarConditions (Condition) VALUES ('Service book')");
            Sql("INSERT INTO CarConditions (Condition) VALUES ('Spare key')");
            Sql("INSERT INTO CarConditions (Condition) VALUES ('Restaurated')");
            Sql("INSERT INTO CarConditions (Condition) VALUES ('Oldtimer')");
            Sql("INSERT INTO CarConditions (Condition) VALUES ('Adapted for the disabled')");
            Sql("INSERT INTO CarConditions (Condition) VALUES ('Taxi car')");
            Sql("INSERT INTO CarConditions (Condition) VALUES ('Test car')");
            Sql("INSERT INTO CarConditions (Condition) VALUES ('Tuning')");
        }
        
        public override void Down()
        {
        }
    }
}
