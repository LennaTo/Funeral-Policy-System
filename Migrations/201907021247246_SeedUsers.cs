namespace FuneralPolicyApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'0545caca-ca1f-498d-83ba-58ca8266b9ff', N'admin@fps.com', 0, N'AE7aCP/6N7dN+ZUryKRACOVA5FEjXzl/NdkP0JJJoujRApK9as/JfP2DrmuTf7srOQ==', N'cab7f9a9-f73b-4674-b197-2f5f6765eba0', NULL, 0, 0, NULL, 1, 0, N'admin@fps.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'27eb1ceb-6f81-496f-bf1e-efe52878670f', N'staff@fps.com', 0, N'AOeS7wt45pzV1I8uj7epcRydyBdeDe2KbjDHcgMD7w/ZqZ+JlC+SDaTm4jO8zWPSZg==', N'2b0d7c98-e79b-4737-8d1a-2afe5adb4b89', NULL, 0, 0, NULL, 1, 0, N'staff@fps.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'5b3abf2f-1c4c-4196-9e8e-82cf873f9fef', N'owner@fps.com', 0, N'AFfH/2Ry12aJ6COsCvg+Faic2K8z+Hj1qvRJGIPaZcJ7DlaW5E+Sbrakx6+DuOe6qA==', N'3be22c1e-dc1a-43dc-8214-335a04ed1c9c', NULL, 0, 0, NULL, 1, 0, N'owner@fps.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'f89cbea1-0c2c-416c-b5be-822502be008a', N'arniemutasa1@gmail.com', 0, N'AHeYF3sOZHQv4WHP+pMopz0XZXVfZ0wECbwOUjIhdW3ksEZ35Yh7dd0af7/OhLtM2Q==', N'ca8e3b09-00c7-4d73-978c-a8ca2ab829d4', NULL, 0, 0, NULL, 1, 0, N'arniemutasa1@gmail.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'd368e392-c93f-453a-88be-d1e60dd081e4', N'CompanyOwner')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'1cc99f2d-f23c-4eeb-8bbd-791b792f5b1b', N'Staff')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'a8273183-6f63-4f83-8f2e-1a22823b0d68', N'SuperAdmin')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'27eb1ceb-6f81-496f-bf1e-efe52878670f', N'1cc99f2d-f23c-4eeb-8bbd-791b792f5b1b')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'0545caca-ca1f-498d-83ba-58ca8266b9ff', N'a8273183-6f63-4f83-8f2e-1a22823b0d68')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'5b3abf2f-1c4c-4196-9e8e-82cf873f9fef', N'd368e392-c93f-453a-88be-d1e60dd081e4')


");
        }
        
        public override void Down()
        {
        }
    }
}
