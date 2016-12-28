namespace Net.Application.Shop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addsomefield : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ProductSell", "ShortIntro", c => c.String(maxLength: 100));
            CreateIndex("dbo.ProductSell", "ProductID");
            AddForeignKey("dbo.ProductSell", "ProductID", "dbo.Product", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductSell", "ProductID", "dbo.Product");
            DropIndex("dbo.ProductSell", new[] { "ProductID" });
            DropColumn("dbo.ProductSell", "ShortIntro");
        }
    }
}
