namespace Net.Application.Shop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_model : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 20),
                        Status = c.Int(nullable: false),
                        CreateTime = c.DateTime(nullable: false),
                        UpdateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.OrderItem",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        OrderID = c.Int(nullable: false),
                        SellID = c.Int(nullable: false),
                        ProductID = c.Int(nullable: false),
                        Price = c.Int(nullable: false),
                        Count = c.Int(nullable: false),
                        Status = c.Int(nullable: false),
                        CreateTime = c.DateTime(nullable: false),
                        UpdateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Order", t => t.OrderID, cascadeDelete: true)
                .Index(t => t.OrderID);
            
            CreateTable(
                "dbo.UserAddress",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserID = c.Int(nullable: false),
                        Province = c.String(nullable: false, maxLength: 20),
                        City = c.String(nullable: false, maxLength: 20),
                        Address = c.String(nullable: false, maxLength: 512),
                        ReceiverName = c.String(nullable: false, maxLength: 64),
                        ReceiverTel = c.String(nullable: false, maxLength: 128),
                        Status = c.Int(nullable: false),
                        CreateTime = c.DateTime(nullable: false),
                        UpdateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.User", t => t.UserID, cascadeDelete: true)
                .Index(t => t.UserID);
            
            CreateTable(
                "dbo.ProductSellCategoryMap",
                c => new
                    {
                        SellID = c.Int(nullable: false),
                        CategoryID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.SellID, t.CategoryID })
                .ForeignKey("dbo.ProductSell", t => t.SellID, cascadeDelete: true)
                .ForeignKey("dbo.Categories", t => t.CategoryID, cascadeDelete: true)
                .Index(t => t.SellID)
                .Index(t => t.CategoryID);
            
            AddColumn("dbo.Order", "UserID", c => c.Int(nullable: false));
            AddColumn("dbo.Order", "TotalPrice", c => c.Int(nullable: false));
            AddColumn("dbo.Order", "OrderStatus", c => c.Int(nullable: false));
            AddColumn("dbo.Product", "Name", c => c.String(nullable: false, maxLength: 1024));
            AddColumn("dbo.Product", "Brand", c => c.String(nullable: false, maxLength: 256));
            AddColumn("dbo.Product", "Price", c => c.Int(nullable: false));
            AddColumn("dbo.Product", "Introduce", c => c.String());
            AddColumn("dbo.ProductSell", "ProductID", c => c.Int(nullable: false));
            AddColumn("dbo.ProductSell", "SellTitle", c => c.String(nullable: false, maxLength: 1024));
            AddColumn("dbo.ProductSell", "Price", c => c.Int(nullable: false));
            AddColumn("dbo.ProductSell", "Stock", c => c.Int(nullable: false));
            AddColumn("dbo.User", "NickName", c => c.String(maxLength: 20));
            AddColumn("dbo.User", "OpenID", c => c.String(maxLength: 100));
            AddColumn("dbo.User", "Mobile", c => c.String(maxLength: 20));
            AddColumn("dbo.User", "IdentityNo", c => c.String(maxLength: 20));
            AddColumn("dbo.User", "Sex", c => c.Int(nullable: false));
            AddColumn("dbo.User", "City", c => c.String(maxLength: 20));
            AddColumn("dbo.User", "Country", c => c.String(maxLength: 50));
            AddColumn("dbo.User", "Province", c => c.String(maxLength: 20));
            AddColumn("dbo.User", "HeadImgUrl", c => c.String(maxLength: 500));
            AddColumn("dbo.User", "Subscribe", c => c.Int(nullable: false));
            AlterColumn("dbo.User", "Name", c => c.String(maxLength: 20));
            CreateIndex("dbo.Order", "UserID");
            AddForeignKey("dbo.Order", "UserID", "dbo.User", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserAddress", "UserID", "dbo.User");
            DropForeignKey("dbo.Order", "UserID", "dbo.User");
            DropForeignKey("dbo.OrderItem", "OrderID", "dbo.Order");
            DropForeignKey("dbo.ProductSellCategoryMap", "CategoryID", "dbo.Categories");
            DropForeignKey("dbo.ProductSellCategoryMap", "SellID", "dbo.ProductSell");
            DropIndex("dbo.UserAddress", new[] { "UserID" });
            DropIndex("dbo.Order", new[] { "UserID" });
            DropIndex("dbo.OrderItem", new[] { "OrderID" });
            DropIndex("dbo.ProductSellCategoryMap", new[] { "CategoryID" });
            DropIndex("dbo.ProductSellCategoryMap", new[] { "SellID" });
            AlterColumn("dbo.User", "Name", c => c.String());
            DropColumn("dbo.User", "Subscribe");
            DropColumn("dbo.User", "HeadImgUrl");
            DropColumn("dbo.User", "Province");
            DropColumn("dbo.User", "Country");
            DropColumn("dbo.User", "City");
            DropColumn("dbo.User", "Sex");
            DropColumn("dbo.User", "IdentityNo");
            DropColumn("dbo.User", "Mobile");
            DropColumn("dbo.User", "OpenID");
            DropColumn("dbo.User", "NickName");
            DropColumn("dbo.ProductSell", "Stock");
            DropColumn("dbo.ProductSell", "Price");
            DropColumn("dbo.ProductSell", "SellTitle");
            DropColumn("dbo.ProductSell", "ProductID");
            DropColumn("dbo.Product", "Introduce");
            DropColumn("dbo.Product", "Price");
            DropColumn("dbo.Product", "Brand");
            DropColumn("dbo.Product", "Name");
            DropColumn("dbo.Order", "OrderStatus");
            DropColumn("dbo.Order", "TotalPrice");
            DropColumn("dbo.Order", "UserID");
            DropTable("dbo.ProductSellCategoryMap");
            DropTable("dbo.UserAddress");
            DropTable("dbo.OrderItem");
            DropTable("dbo.Categories");
        }
    }
}
