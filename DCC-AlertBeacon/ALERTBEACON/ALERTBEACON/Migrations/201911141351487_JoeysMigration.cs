namespace ALERTBEACON.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class JoeysMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Observers", "Issue", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Observers", "Issue");
        }
    }
}
