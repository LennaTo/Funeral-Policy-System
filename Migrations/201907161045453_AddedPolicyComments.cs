namespace FuneralPolicyApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedPolicyComments : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PolicyComments",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PolicyID = c.Int(nullable: false),
                        PolicyNo = c.String(),
                        Comment = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PolicyComments");
        }
    }
}
