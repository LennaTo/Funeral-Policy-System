namespace FuneralPolicyApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedDependantModelAndRelatedStuff : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Dependants", "DependantStatusID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Dependants", "DependantStatusID", c => c.Int(nullable: false));
        }
    }
}
