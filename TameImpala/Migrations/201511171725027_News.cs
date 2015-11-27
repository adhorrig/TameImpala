namespace TameImpala.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class News : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Article",
                c => new
                    {
                        NewsID = c.String(nullable: false, maxLength: 128),
                        url = c.String(),
                        title = c.String(),
                        description = c.String(),
                    })
                .PrimaryKey(t => t.NewsID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Article");
        }
    }
}
