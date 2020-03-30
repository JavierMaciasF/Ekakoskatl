namespace Ekakoskatl.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateMigratin : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Genders",
                c => new
                    {
                        GenderID = c.Guid(nullable: false),
                        GenderName = c.String(nullable: false, maxLength: 150),
                        GenderDateCreate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.GenderID);
            
            CreateTable(
                "dbo.VideoGender",
                c => new
                    {
                        VideoGenderID = c.Guid(nullable: false),
                        GenderID = c.Guid(nullable: false),
                        VideoID = c.Guid(nullable: false),
                        VideoGenderDateCreate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.VideoGenderID)
                .ForeignKey("dbo.Videos", t => t.VideoID)
                .ForeignKey("dbo.Genders", t => t.GenderID)
                .Index(t => t.GenderID)
                .Index(t => t.VideoID);
            
            CreateTable(
                "dbo.Videos",
                c => new
                    {
                        VideoID = c.Guid(nullable: false),
                        VideoName = c.String(nullable: false, maxLength: 150),
                        VideoDescription = c.String(nullable: false, maxLength: 500),
                        VideoDateCreate = c.DateTime(nullable: false),
                        VideoDateMocdified = c.DateTime(nullable: false),
                        VideoGender = c.Int(nullable: false),
                        VideoImage = c.Binary(storeType: "image"),
                        VideoRoute = c.String(maxLength: 150),
                    })
                .PrimaryKey(t => t.VideoID);
            
            CreateTable(
                "dbo.RecentlySeen",
                c => new
                    {
                        RecentlySeenID = c.Guid(nullable: false),
                        RecentlySeenDateCreate = c.DateTime(nullable: false),
                        VideoID = c.Guid(nullable: false),
                        UserID = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.RecentlySeenID)
                .ForeignKey("dbo.Users", t => t.UserID)
                .ForeignKey("dbo.Videos", t => t.VideoID)
                .Index(t => t.VideoID)
                .Index(t => t.UserID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserID = c.Guid(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 50),
                        UserFirstName = c.String(nullable: false, maxLength: 50),
                        UserLastName = c.String(nullable: false, maxLength: 50),
                        UserDisplayName = c.String(nullable: false, maxLength: 50),
                        UserEMail = c.String(nullable: false, maxLength: 100),
                        UserAge = c.Int(),
                        UserDateCreate = c.DateTime(nullable: false),
                        UserDateModified = c.DateTime(nullable: false),
                        UserPasswordToken = c.String(unicode: false),
                        UserPasswordTokenExp = c.DateTime(),
                        UserResetTokenNextTime = c.Boolean(),
                        UserResetPasswordNextTime = c.Boolean(),
                        UserImage = c.Binary(storeType: "image"),
                    })
                .PrimaryKey(t => t.UserID);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        RolID = c.Guid(nullable: false),
                        RolName = c.String(nullable: false, maxLength: 50),
                        RolDateCreate = c.DateTime(nullable: false),
                        UserID = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.RolID)
                .ForeignKey("dbo.Users", t => t.UserID)
                .Index(t => t.UserID);
            
            CreateTable(
                "dbo.PermissionRoles",
                c => new
                    {
                        PermissionRolID = c.Guid(nullable: false),
                        PermissionRolDateCreate = c.DateTime(nullable: false),
                        PermissionRolDateModified = c.DateTime(nullable: false),
                        PermissionRolSelect = c.Int(nullable: false),
                        PermissionRolUpdate = c.Int(nullable: false),
                        PermissionRolDelete = c.Int(nullable: false),
                        PermissionRolInsert = c.Int(nullable: false),
                        PermissionRolGrant = c.Int(nullable: false),
                        RolID = c.Guid(nullable: false),
                        PermissionID = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.PermissionRolID)
                .ForeignKey("dbo.Permissions", t => t.PermissionID)
                .ForeignKey("dbo.Roles", t => t.RolID)
                .Index(t => t.RolID)
                .Index(t => t.PermissionID);
            
            CreateTable(
                "dbo.Permissions",
                c => new
                    {
                        PermissionID = c.Guid(nullable: false),
                        PermissionName = c.String(nullable: false, maxLength: 100),
                        PermissionDateCreate = c.DateTime(nullable: false),
                        PermissionDateModified = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.PermissionID);
            
            CreateTable(
                "dbo.MenuItems",
                c => new
                    {
                        MenuItemID = c.Guid(nullable: false),
                        MenuItemName = c.String(nullable: false, maxLength: 100),
                        MenuItemRoute = c.String(nullable: false, maxLength: 50),
                        MenuItemDateCreate = c.DateTime(nullable: false),
                        MenuItemDateModified = c.DateTime(nullable: false),
                        MenuItemParentID = c.Guid(),
                        MenuItemFormID = c.String(maxLength: 4, fixedLength: true, unicode: false),
                        MenuItemType = c.Int(nullable: false),
                        MenuItemOrder = c.Int(nullable: false),
                        PermissionID = c.Guid(nullable: false),
                        PermissionTypeAction = c.Int(nullable: false),
                        MenuItemIcon = c.Binary(nullable: false, storeType: "image"),
                    })
                .PrimaryKey(t => t.MenuItemID)
                .ForeignKey("dbo.Permissions", t => t.PermissionID)
                .Index(t => t.PermissionID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.VideoGender", "GenderID", "dbo.Genders");
            DropForeignKey("dbo.VideoGender", "VideoID", "dbo.Videos");
            DropForeignKey("dbo.RecentlySeen", "VideoID", "dbo.Videos");
            DropForeignKey("dbo.Roles", "UserID", "dbo.Users");
            DropForeignKey("dbo.PermissionRoles", "RolID", "dbo.Roles");
            DropForeignKey("dbo.PermissionRoles", "PermissionID", "dbo.Permissions");
            DropForeignKey("dbo.MenuItems", "PermissionID", "dbo.Permissions");
            DropForeignKey("dbo.RecentlySeen", "UserID", "dbo.Users");
            DropIndex("dbo.MenuItems", new[] { "PermissionID" });
            DropIndex("dbo.PermissionRoles", new[] { "PermissionID" });
            DropIndex("dbo.PermissionRoles", new[] { "RolID" });
            DropIndex("dbo.Roles", new[] { "UserID" });
            DropIndex("dbo.RecentlySeen", new[] { "UserID" });
            DropIndex("dbo.RecentlySeen", new[] { "VideoID" });
            DropIndex("dbo.VideoGender", new[] { "VideoID" });
            DropIndex("dbo.VideoGender", new[] { "GenderID" });
            DropTable("dbo.MenuItems");
            DropTable("dbo.Permissions");
            DropTable("dbo.PermissionRoles");
            DropTable("dbo.Roles");
            DropTable("dbo.Users");
            DropTable("dbo.RecentlySeen");
            DropTable("dbo.Videos");
            DropTable("dbo.VideoGender");
            DropTable("dbo.Genders");
        }
    }
}
