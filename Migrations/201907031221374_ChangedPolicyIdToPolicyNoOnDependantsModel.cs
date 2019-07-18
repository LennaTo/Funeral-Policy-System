namespace FuneralPolicyApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedPolicyIdToPolicyNoOnDependantsModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Dependants", "PolicyNo", c => c.Int(nullable: false));
            DropColumn("dbo.Dependants", "PolicyId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Dependants", "PolicyId", c => c.Int(nullable: false));
            DropColumn("dbo.Dependants", "PolicyNo");
        }
    }
}
