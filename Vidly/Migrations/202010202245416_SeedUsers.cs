namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'0a43a51c-3e92-441f-acd7-ff3427292b65', N'admin@admin.com', 0, N'AI44cfeS1M7KWlGHOtZVWuJjwF1ApV4hqvkw3xctXV6S89yj+a9nG+DjEAv2rpuGvw==', N'987e0171-9f09-456d-b40d-cc5f6b25cb07', NULL, 0, 0, NULL, 1, 0, N'admin@admin.com')
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'9e8259bb-54fe-4392-83db-4c69c509b1f0', N'teste@teste.com', 0, N'AFLrkoEE2KCKUcHJvVpKUxawWGNDfvSh6YRguPJyZC1t4Ior1rxh1ohT5gEFlEj29g==', N'5090dfbc-6c0b-4e90-b543-705f83c6b4fd', NULL, 0, 0, NULL, 1, 0, N'teste@teste.com')
            INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'bab81b9e-6dc1-4770-96d6-d387096b4730', N'CanManageMovies')
            INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'0a43a51c-3e92-441f-acd7-ff3427292b65', N'bab81b9e-6dc1-4770-96d6-d387096b4730')

            ");
        }
        
        public override void Down()
        {
        }
    }
}
