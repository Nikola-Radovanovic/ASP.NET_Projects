namespace UsedCars.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAdminRole : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers]
                  ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) 
                  VALUES 
                  (N'c1a3ad01-3b98-479f-8178-65bace17fa49', N'admin@admin.com', 0, N'APxaJbaoYnUp0BV2MHUW1SCqMFlAz7kiKslUCd0ujRTexN4Ps5CCcvE8WBUCwvtPgQ==', N'aca70537-0926-4437-b0c6-6d2a963cb2db', NULL, 0, 0, NULL, 1, 0, N'admin@admin.com')");
            Sql(@"INSERT INTO [dbo].[AspNetRoles]
                  ([Id], [Name])
                  VALUES
                  (N'81808dd1-43ae-473a-90fc-349d806e9391', N'Admin')");
            Sql(@"INSERT INTO [dbo].[AspNetUserRoles]
                  ([UserId], [RoleId])
                  VALUES
                  (N'c1a3ad01-3b98-479f-8178-65bace17fa49', N'81808dd1-43ae-473a-90fc-349d806e9391')");
        }
        
        public override void Down()
        {
        }
    }
}
