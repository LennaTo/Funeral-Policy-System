namespace FuneralPolicyApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedClaimsToOnlyIdByDependentId : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Claims", "DeceaseDependentId", c => c.Int(nullable: false));
            DropColumn("dbo.Claims", "CompanyId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Claims", "CompanyId", c => c.Int(nullable: false));
            DropColumn("dbo.Claims", "DeceaseDependentId");
        }
    }
}
