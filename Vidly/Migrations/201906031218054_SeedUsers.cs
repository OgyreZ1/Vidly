namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'de69d84b-614e-4c77-9de7-44548aefb652', N'guest@vidly.com', 0, N'AA9ri0Yv1JsFCFmQA6W8TSG5V5Heutg46ToRRSJmUgpwi4ZuX5EFXL/nyKU2sZOyag==', N'83772bb3-8028-4091-8750-c66eafcb40b6', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'400d2aef-edc5-4a3a-be3d-69fdad3b7665', N'admin@vidly.com', 0, N'AJX/OLGjeFEQdlofHnHY28jSDkFJskRteuhf2vsR9mJagxy7M9fLt+nJmH0Hz+e1ag==', N'97188246-4375-474f-8654-2d76a8bb9e8c', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'f5dfc3f4-89ae-4de0-99bb-dc65a26aeecc', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'400d2aef-edc5-4a3a-be3d-69fdad3b7665', N'f5dfc3f4-89ae-4de0-99bb-dc65a26aeecc')

");
        }
        
        public override void Down()
        {
        }
    }
}
