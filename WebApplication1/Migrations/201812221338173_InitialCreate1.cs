namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pictures", "Alt", c => c.String());
            AddColumn("dbo.Pictures", "Link", c => c.String());
            DropColumn("dbo.Pictures", "Name");
            DropColumn("dbo.Pictures", "Image");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Pictures", "Image", c => c.Binary());
            AddColumn("dbo.Pictures", "Name", c => c.String());
            DropColumn("dbo.Pictures", "Link");
            DropColumn("dbo.Pictures", "Alt");
        }
    }
}
