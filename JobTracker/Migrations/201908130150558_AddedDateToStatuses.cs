namespace JobTracker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedDateToStatuses : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Status", "Date", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Status", "Date");
        }
    }
}
