namespace Net.Application.Shop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adjustorderitem : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.OrderItem", "UserID", c => c.Int(nullable: false));
            AddColumn("dbo.OrderItem", "OrderItemStatus", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.OrderItem", "OrderItemStatus");
            DropColumn("dbo.OrderItem", "UserID");
        }
    }
}
