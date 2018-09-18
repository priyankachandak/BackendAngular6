namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class firstMG : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ContactDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StudId = c.Int(nullable: false),
                        Email = c.String(),
                        ContactNumber = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Students", t => t.StudId, cascadeDelete: true)
                .Index(t => t.StudId);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        LastName = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ContactDetails", "StudId", "dbo.Students");
            DropIndex("dbo.ContactDetails", new[] { "StudId" });
            DropTable("dbo.Students");
            DropTable("dbo.ContactDetails");
        }
    }
}
