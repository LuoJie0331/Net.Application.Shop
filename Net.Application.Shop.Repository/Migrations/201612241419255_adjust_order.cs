namespace Net.Application.Shop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adjust_order : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Order", "TotalCost", c => c.Int(nullable: false));
            AddColumn("dbo.Order", "PostFee", c => c.Int(nullable: false));
            AddColumn("dbo.Order", "PostReceiver", c => c.String(maxLength: 20));
            AddColumn("dbo.Order", "PostTel", c => c.String(maxLength: 20));
            AddColumn("dbo.Order", "PostAddress", c => c.String(maxLength: 200));
            AddColumn("dbo.Order", "PostCompany", c => c.String(maxLength: 20));
            AddColumn("dbo.OrderItem", "CheckForOrder", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.OrderItem", "CheckForOrder");
            DropColumn("dbo.Order", "PostCompany");
            DropColumn("dbo.Order", "PostAddress");
            DropColumn("dbo.Order", "PostTel");
            DropColumn("dbo.Order", "PostReceiver");
            DropColumn("dbo.Order", "PostFee");
            DropColumn("dbo.Order", "TotalCost");
        }
    }
}
