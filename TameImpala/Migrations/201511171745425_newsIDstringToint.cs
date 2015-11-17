namespace TameImpala.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newsIDstringToint : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.News");
            AlterColumn("dbo.News", "NewsID", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.News", "NewsID");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.News");
            AlterColumn("dbo.News", "NewsID", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.News", "NewsID");
        }
    }
}
