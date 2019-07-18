namespace FuneralPolicyApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DependantPolicyNoToString : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Dependants", "PolicyNo", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Dependants", "PolicyNo", c => c.Int(nullable: false));
        }
    }
}
