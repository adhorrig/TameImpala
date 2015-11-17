namespace TameImpala.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
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
            
            CreateTable(
                "dbo.GoingToGigs",
                c => new
                    {
                        GoingToGigID = c.Boolean(nullable: false),
                        UserID = c.String(),
                    })
                .PrimaryKey(t => t.GoingToGigID);
            
            CreateTable(
                "dbo.PreviousGigs",
                c => new
                    {
                        PreviousGigID = c.Int(nullable: false, identity: true),
                        Location = c.String(),
                        Date = c.DateTime(nullable: false),
                        Description = c.String(),
                        Title = c.String(),
                        Rating = c.Int(nullable: false),
                        UserID = c.String(),
                    })
                .PrimaryKey(t => t.PreviousGigID);
            
            CreateTable(
                "dbo.UpcomingGigs",
                c => new
                    {
                        UpcomingGigID = c.Int(nullable: false, identity: true),
                        Location = c.String(),
                        Price = c.Double(nullable: false),
                        Date = c.DateTime(nullable: false),
                        Description = c.String(),
                        Title = c.String(),
                        UserID = c.String(),
                    })
                .PrimaryKey(t => t.UpcomingGigID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UpcomingGigs");
            DropTable("dbo.PreviousGigs");
            DropTable("dbo.GoingToGigs");
            DropTable("dbo.FavoriteGigs");
        }
    }
}
