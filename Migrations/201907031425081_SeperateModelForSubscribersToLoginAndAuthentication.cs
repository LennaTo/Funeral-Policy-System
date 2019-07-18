namespace FuneralPolicyApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeperateModelForSubscribersToLoginAndAuthentication : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Subscribers",
                c => new
                    {
                        SubscriberID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        UserName = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        ConfirmPassword = c.String(),
                        CompanyId = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.SubscriberID);
            
            AddColumn("dbo.Policies", "SubscriberId", c => c.Int(nullable: false));
            DropColumn("dbo.Policies", "PolicyStatusId");
            DropColumn("dbo.Policies", "UserId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Policies", "UserId", c => c.Int(nullable: false));
            AddColumn("dbo.Policies", "PolicyStatusId", c => c.Int(nullable: false));
            DropColumn("dbo.Policies", "SubscriberId");
            DropTable("dbo.Subscribers");
        }
    }
}
