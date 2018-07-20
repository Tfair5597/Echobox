namespace EchoBox.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        GenreID = c.Int(nullable: false, identity: true),
                        GenreName = c.String(nullable: false),
                        GenreDescription = c.String(nullable: false),
                        Instruments = c.String(),
                        isSubGenre = c.Boolean(nullable: false),
                        User_UserID = c.Int(),
                    })
                .PrimaryKey(t => t.GenreID)
                .ForeignKey("dbo.Users", t => t.User_UserID)
                .Index(t => t.User_UserID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        UserName = c.String(nullable: false),
                        fName = c.String(nullable: false),
                        lName = c.String(nullable: false),
                        DateOfBirth = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.UserID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Genres", "User_UserID", "dbo.Users");
            DropIndex("dbo.Genres", new[] { "User_UserID" });
            DropTable("dbo.Users");
            DropTable("dbo.Genres");
        }
    }
}
