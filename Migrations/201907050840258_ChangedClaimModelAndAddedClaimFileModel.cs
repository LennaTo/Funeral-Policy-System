namespace FuneralPolicyApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedClaimModelAndAddedClaimFileModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ClaimFiles",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        FileName = c.String(),
                        Extension = c.String(),
                        ClaimId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Claims", t => t.ClaimId, cascadeDelete: true)
                .Index(t => t.ClaimId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ClaimFiles", "ClaimId", "dbo.Claims");
            DropIndex("dbo.ClaimFiles", new[] { "ClaimId" });
            DropTable("dbo.ClaimFiles");
        }
    }
}
