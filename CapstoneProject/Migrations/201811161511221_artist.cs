namespace CapstoneProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class artist : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Artists", "PhoneNumber", c => c.String());
            AlterColumn("dbo.Customers", "PhoneNumber", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "PhoneNumber", c => c.Int(nullable: false));
            AlterColumn("dbo.Artists", "PhoneNumber", c => c.Int(nullable: false));
        }
    }
}
