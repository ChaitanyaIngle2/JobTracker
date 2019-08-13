namespace JobTracker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovedDatefromStatuses : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Status", "Date");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Status", "Date", c => c.DateTime(nullable: false));
        }
    }
}
