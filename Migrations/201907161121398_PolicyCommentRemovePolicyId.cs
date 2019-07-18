namespace FuneralPolicyApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PolicyCommentRemovePolicyId : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.PolicyComments", "PolicyID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PolicyComments", "PolicyID", c => c.Int(nullable: false));
        }
    }
}
