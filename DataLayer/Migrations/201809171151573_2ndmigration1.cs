namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _2ndmigration1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "Email", c => c.String());
            AddColumn("dbo.Students", "Password", c => c.String());
            DropColumn("dbo.ContactDetails", "Email");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ContactDetails", "Email", c => c.String());
            DropColumn("dbo.Students", "Password");
            DropColumn("dbo.Students", "Email");
        }
    }
}
