namespace Net.Application.Shop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_sell : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.OrderItem", "SellID");
            AddForeignKey("dbo.OrderItem", "SellID", "dbo.ProductSell", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderItem", "SellID", "dbo.ProductSell");
            DropIndex("dbo.OrderItem", new[] { "SellID" });
        }
    }
}
