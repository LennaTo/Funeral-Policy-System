namespace FuneralPolicyApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removeLastPayModel : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Policies", "PremiumPaymentLastDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Policies", "PremiumPaymentLastDate", c => c.DateTime(nullable: false));
        }
    }
}
