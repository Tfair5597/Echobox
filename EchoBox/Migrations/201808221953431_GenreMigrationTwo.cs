namespace EchoBox.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GenreMigrationTwo : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Genres", "isSubGenre");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Genres", "isSubGenre", c => c.Boolean(nullable: false));
        }
    }
}
