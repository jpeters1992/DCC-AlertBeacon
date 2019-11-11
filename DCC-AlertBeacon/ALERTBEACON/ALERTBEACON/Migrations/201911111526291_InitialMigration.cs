namespace ALERTBEACON.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CarOwners",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        licensePlate = c.String(),
                        FirstName = c.String(),
                        LastName = c.String(),
                        StreetAddress = c.String(),
                        City = c.String(),
                        State = c.String(),
                        Reward = c.Int(nullable: false),
                        Email = c.String(),
                        PhoneNumber = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Observers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LicensePlate = c.String(),
                        Email = c.String(),
                        PhoneNumber = c.String(),
                        Reward = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Observers");
            DropTable("dbo.CarOwners");
        }
    }
}
