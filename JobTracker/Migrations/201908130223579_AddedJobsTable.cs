namespace JobTracker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedJobsTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Jobs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Company = c.String(),
                        Position = c.String(),
                        StatusId = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Status", t => t.StatusId, cascadeDelete: true)
                .Index(t => t.StatusId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Jobs", "StatusId", "dbo.Status");
            DropIndex("dbo.Jobs", new[] { "StatusId" });
            DropTable("dbo.Jobs");
        }
    }
}
