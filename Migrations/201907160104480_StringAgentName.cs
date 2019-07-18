namespace FuneralPolicyApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StringAgentName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Policies", "AgentName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Policies", "AgentName");
        }
    }
}
