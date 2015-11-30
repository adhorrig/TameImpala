namespace TameImpala.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removeuserid : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.PreviousGigs", "UserID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PreviousGigs", "UserID", c => c.String());
        }
    }
}
