namespace FuneralPolicyApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedAgentTableAndDatesForPremiumPayments : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Commissions", "AgentId", c => c.Int(nullable: false));
            AddColumn("dbo.Policies", "PremiumPaymentLastDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Policies", "PremiumPaymentLastDate");
            DropColumn("dbo.Commissions", "AgentId");
        }
    }
}
