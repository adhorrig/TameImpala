namespace TameImpala.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class firstMigration : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.GoingToGigs");
            AddColumn("dbo.GoingToGigs", "attending", c => c.Boolean(nullable: false));
            AlterColumn("dbo.GoingToGigs", "GoingToGigID", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.GoingToGigs", "GoingToGigID");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.GoingToGigs");
            AlterColumn("dbo.GoingToGigs", "GoingToGigID", c => c.Boolean(nullable: false));
            DropColumn("dbo.GoingToGigs", "attending");
            AddPrimaryKey("dbo.GoingToGigs", "GoingToGigID");
        }
    }
}
