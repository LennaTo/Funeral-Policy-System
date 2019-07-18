namespace FuneralPolicyApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CommissionAmountToFloat : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Commissions", "CommissionAmount", c => c.Single(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Commissions", "CommissionAmount", c => c.Int(nullable: false));
        }
    }
}
