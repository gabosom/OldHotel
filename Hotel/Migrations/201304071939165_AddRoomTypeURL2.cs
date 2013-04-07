namespace HotelEden.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRoomTypeURL2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.RoomTypes", "URL23", c => c.String());
            DropColumn("dbo.RoomTypes", "URL");
        }
        
        public override void Down()
        {
            AddColumn("dbo.RoomTypes", "URL", c => c.String());
            DropColumn("dbo.RoomTypes", "URL23");
        }
    }
}