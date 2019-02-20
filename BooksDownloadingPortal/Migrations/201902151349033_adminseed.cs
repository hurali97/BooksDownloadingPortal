namespace BooksDownloadingPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adminseed : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.AspNetUsers", "SeatNumber");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "SeatNumber", c => c.String(nullable: false));
        }
    }
}
