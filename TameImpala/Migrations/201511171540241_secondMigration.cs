namespace TameImpala.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class secondMigration : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.UpcomingGigs", "UserID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.UpcomingGigs", "UserID", c => c.String());
        }
    }
}
