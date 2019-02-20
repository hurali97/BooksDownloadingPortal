namespace BooksDownloadingPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seedusers : DbMigration
    {
        public override void Up()
        {

			Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'22d5c4c5-3e52-4b81-b62f-188872d36c73', N'admin@University.com', 0, N'AAIOHMXj1tAmCZeqbevNwjl8sdxd5JXmJqrOrc3LL+rkV5R9rctbx8+SCh5iCRfbVA==', N'b8bf6738-7ca7-49b6-b85a-0c9d92ffe39a', NULL, 0, 0, NULL, 1, 0, N'admin@University.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'35ec4e07-7cfd-48b2-b95c-afead2643731', N'Admin')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'22d5c4c5-3e52-4b81-b62f-188872d36c73', N'35ec4e07-7cfd-48b2-b95c-afead2643731')

");
        }
        
        public override void Down()
        {
        }
    }
}
