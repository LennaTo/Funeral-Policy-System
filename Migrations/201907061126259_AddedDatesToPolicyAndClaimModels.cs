namespace FuneralPolicyApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedDatesToPolicyAndClaimModels : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Claims", "PolicyId", c => c.Single(nullable: false));
            AddColumn("dbo.Claims", "ClaimDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Policies", "AgentId", c => c.Int(nullable: false));
            AddColumn("dbo.Policies", "DateWritten", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Policies", "DateWritten");
            DropColumn("dbo.Policies", "AgentId");
            DropColumn("dbo.Claims", "ClaimDate");
            DropColumn("dbo.Claims", "PolicyId");
        }
    }
}
