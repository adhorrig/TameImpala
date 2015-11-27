namespace TameImpala.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class refactor : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Articles",
                c => new
                    {
                        ArticleID = c.Int(nullable: false, identity: true),
                        url = c.String(),
                        title = c.String(),
                        description = c.String(),
                    })
                .PrimaryKey(t => t.ArticleID);
            
            DropTable("dbo.News");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.News",
                c => new
                    {
                        NewsID = c.Int(nullable: false, identity: true),
                        url = c.String(),
                        title = c.String(),
                        description = c.String(),
                    })
                .PrimaryKey(t => t.NewsID);
            
            DropTable("dbo.Articles");
        }
    }
}
