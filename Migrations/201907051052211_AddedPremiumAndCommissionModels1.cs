namespace FuneralPolicyApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedPremiumAndCommissionModels1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Commissions",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PolicyID = c.Int(nullable: false),
                        PremiumID = c.Int(nullable: false),
                        AgentEmail = c.String(),
                        CommissionAmount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Commissions");
        }
    }
}
