namespace TameImpala.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newsIDstringToint : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Article");
            AlterColumn("dbo.Article", "ArticleID", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Article", "ArticleID");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Article");
            AlterColumn("dbo.Article", "ArticleID", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Article", "ArticleID");
        }
    }
}
