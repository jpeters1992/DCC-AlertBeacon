namespace ALERTBEACON.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPropertyMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Observers", "CarIssue", c => c.String());
            DropColumn("dbo.Observers", "Issue");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Observers", "Issue", c => c.Int(nullable: false));
            DropColumn("dbo.Observers", "CarIssue");
        }
    }
}
