namespace FuneralPolicyApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MovedMyDBSetsToCorrectAppDBContext : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Claims",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ClaimNo = c.String(),
                        ClaimAmount = c.Single(nullable: false),
                        CompanyId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CompanyName = c.String(nullable: false),
                        Address = c.String(),
                        Telephone = c.String(),
                        Prefix = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Dependants",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        DOB = c.DateTime(nullable: false),
                        DependentType = c.String(),
                        PolicyId = c.Int(nullable: false),
                        SumAssured = c.String(),
                        DependantStatusID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.DependantStatus",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Status = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Policies",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PolicyNo = c.String(),
                        Premium = c.Single(nullable: false),
                        SumAssured = c.Single(nullable: false),
                        CompanyId = c.Int(nullable: false),
                        PolicyStatusId = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.PolicyStatus",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        StatusName = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Premiums",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PremiumAmount = c.Single(nullable: false),
                        PolicyId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.UserAccounts",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        UserName = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        ConfirmPassword = c.String(),
                        UserRoleId = c.Byte(nullable: false),
                        CompanyId = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.UserID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UserAccounts");
            DropTable("dbo.Premiums");
            DropTable("dbo.PolicyStatus");
            DropTable("dbo.Policies");
            DropTable("dbo.DependantStatus");
            DropTable("dbo.Dependants");
            DropTable("dbo.Companies");
            DropTable("dbo.Claims");
        }
    }
}
