namespace TameImpala.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class videos : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Videos",
                c => new
                    {
                        VideoID = c.Int(nullable: false, identity: true),
                        VideoURL = c.String(),
                    })
                .PrimaryKey(t => t.VideoID);
            
            DropTable("dbo.FavoriteGigs");
            DropTable("dbo.GoingToGigs");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.GoingToGigs",
                c => new
                    {
                        GoingToGigID = c.Int(nullable: false, identity: true),
                        attending = c.Boolean(nullable: false),
                        UserID = c.String(),
                    })
                .PrimaryKey(t => t.GoingToGigID);
            
            CreateTable(
                "dbo.FavoriteGigs",
                c => new
                    {
                        FavoriteGigID = c.Int(nullable: false, identity: true),
                        Location = c.String(),
                        Date = c.DateTime(nullable: false),
                        Description = c.String(),
                        Title = c.String(),
                        UserID = c.String(),
                    })
                .PrimaryKey(t => t.FavoriteGigID);
            
            DropTable("dbo.Videos");
        }
    }
}
