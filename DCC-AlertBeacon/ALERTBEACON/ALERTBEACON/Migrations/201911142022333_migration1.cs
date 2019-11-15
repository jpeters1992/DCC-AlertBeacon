namespace ALERTBEACON.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migration1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Observers", "CarIssue", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Observers", "CarIssue");
        }
    }
}
