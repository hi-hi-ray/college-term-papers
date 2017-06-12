namespace KeepEverything.RaysaDutra.Infra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StartDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        IdCategory = c.Int(nullable: false, identity: true),
                        NameCategory = c.String(nullable: false, maxLength: 255, unicode: false),
                        DescriptionCategory = c.String(nullable: false, maxLength: 500, unicode: false),
                    })
                .PrimaryKey(t => t.IdCategory);
            
            CreateTable(
                "dbo.Tasks",
                c => new
                    {
                        IdTask = c.Int(nullable: false, identity: true),
                        NameTask = c.String(nullable: false, maxLength: 255, unicode: false),
                        DescriptionTask = c.String(maxLength: 500, unicode: false),
                        CurrentSituationTask = c.String(maxLength: 8000, unicode: false),
                        CreatedDateTask = c.DateTime(nullable: false),
                        EndedDateTask = c.DateTime(nullable: false),
                        IdCategory = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdTask)
                .ForeignKey("dbo.Categories", t => t.IdCategory)
                .Index(t => t.IdCategory);
            
            CreateTable(
                "dbo.Tags",
                c => new
                    {
                        IdTag = c.Int(nullable: false, identity: true),
                        NameTag = c.String(nullable: false, maxLength: 255, unicode: false),
                    })
                .PrimaryKey(t => t.IdTag);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 100, unicode: false),
                        Email = c.String(nullable: false, maxLength: 255, unicode: false),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(maxLength: 8000, unicode: false),
                        SecurityStamp = c.String(maxLength: 8000, unicode: false),
                        PhoneNumber = c.String(nullable: false, maxLength: 50, unicode: false),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 255, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TaskTag",
                c => new
                    {
                        Task_IdTask = c.Int(nullable: false),
                        Tag_IdTag = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Task_IdTask, t.Tag_IdTag })
                .ForeignKey("dbo.Tasks", t => t.Task_IdTask)
                .ForeignKey("dbo.Tags", t => t.Tag_IdTag)
                .Index(t => t.Task_IdTask)
                .Index(t => t.Tag_IdTag);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TaskTag", "Tag_IdTag", "dbo.Tags");
            DropForeignKey("dbo.TaskTag", "Task_IdTask", "dbo.Tasks");
            DropForeignKey("dbo.Tasks", "IdCategory", "dbo.Categories");
            DropIndex("dbo.TaskTag", new[] { "Tag_IdTag" });
            DropIndex("dbo.TaskTag", new[] { "Task_IdTask" });
            DropIndex("dbo.Tasks", new[] { "IdCategory" });
            DropTable("dbo.TaskTag");
            DropTable("dbo.Users");
            DropTable("dbo.Tags");
            DropTable("dbo.Tasks");
            DropTable("dbo.Categories");
        }
    }
}
