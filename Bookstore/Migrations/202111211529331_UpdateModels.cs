namespace Bookstore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateModels : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "IsAvailable", c => c.Boolean(nullable: false));
            AddColumn("dbo.Genres", "Description", c => c.String(maxLength: 1000));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Genres", "Description");
            DropColumn("dbo.Books", "IsAvailable");
        }
    }
}
