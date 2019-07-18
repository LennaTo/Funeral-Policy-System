namespace FuneralPolicyApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedCommissionModelToHaveAgentName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Commissions", "AgentName", c => c.String());
            DropColumn("dbo.Commissions", "AgentEmail");
            DropColumn("dbo.Commissions", "AgentId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Commissions", "AgentId", c => c.Int(nullable: false));
            AddColumn("dbo.Commissions", "AgentEmail", c => c.String());
            DropColumn("dbo.Commissions", "AgentName");
        }
    }
}
