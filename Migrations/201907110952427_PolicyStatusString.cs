namespace FuneralPolicyApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PolicyStatusString : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Policies", "Status", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Policies", "Status");
        }
    }
}
