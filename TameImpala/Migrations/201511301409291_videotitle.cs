namespace TameImpala.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class videotitle : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Videos", "VideoTitle", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Videos", "VideoTitle");
        }
    }
}
