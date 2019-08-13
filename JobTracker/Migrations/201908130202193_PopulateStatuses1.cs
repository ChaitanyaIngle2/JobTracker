namespace JobTracker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateStatuses1 : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Status ON");
            Sql("INSERT INTO Status (Id, StatusName) VALUES (0, 'Not Submitted')");
            Sql("INSERT INTO Status (Id, StatusName) VALUES (1, 'Applied')");
            Sql("INSERT INTO Status (Id, StatusName) VALUES (2, 'Phone Interview')");
            Sql("INSERT INTO Status (Id, StatusName) VALUES (3, 'On-Site Interview')");
            Sql("INSERT INTO Status (Id, StatusName) VALUES (4, 'Rejected')");
            Sql("INSERT INTO Status (Id, StatusName) VALUES (5, 'Hired')");
            Sql("SET IDENTITY_INSERT Status OFF");
        }

        public override void Down()
        {
        }
    }
}
