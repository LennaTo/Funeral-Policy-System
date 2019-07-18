namespace FuneralPolicyApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedPaymentDateToPremium : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Premiums", "PaymentDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Premiums", "PaymentDate");
        }
    }
}
