namespace BooksDownloadingPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seatnumberaddedtoregister : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "SeatNumber", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "SeatNumber");
        }
    }
}
