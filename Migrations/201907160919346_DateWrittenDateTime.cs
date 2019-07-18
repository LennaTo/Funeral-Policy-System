namespace FuneralPolicyApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DateWrittenDateTime : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Policies", "DateWritten");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Policies", "DateWritten", c => c.DateTime(nullable: false));
        }
    }
}
