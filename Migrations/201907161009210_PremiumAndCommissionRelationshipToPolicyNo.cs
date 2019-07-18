namespace FuneralPolicyApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PremiumAndCommissionRelationshipToPolicyNo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Commissions", "PolicyNo", c => c.String());
            AddColumn("dbo.Premiums", "PolicyNo", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Premiums", "PolicyNo");
            DropColumn("dbo.Commissions", "PolicyNo");
        }
    }
}
