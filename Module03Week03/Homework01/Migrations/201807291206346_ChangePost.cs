namespace Homework01.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangePost : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Posts", "Author_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Posts", new[] { "Author_Id" });
            AddColumn("dbo.Posts", "Author", c => c.String());
            DropColumn("dbo.Posts", "Author_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Posts", "Author_Id", c => c.String(maxLength: 128));
            DropColumn("dbo.Posts", "Author");
            CreateIndex("dbo.Posts", "Author_Id");
            AddForeignKey("dbo.Posts", "Author_Id", "dbo.AspNetUsers", "Id");
        }
    }
}
