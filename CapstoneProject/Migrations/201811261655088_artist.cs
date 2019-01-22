namespace CapstoneProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class artist : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Artists", "Name");
            DropColumn("dbo.Artists", "Biography");
            DropColumn("dbo.Artists", "Discriminator");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Artists", "Discriminator", c => c.String(nullable: false, maxLength: 128));
            AddColumn("dbo.Artists", "Biography", c => c.String());
            AddColumn("dbo.Artists", "Name", c => c.String());
        }
    }
}
