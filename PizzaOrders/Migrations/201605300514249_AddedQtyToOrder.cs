namespace PizzaOrders.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedQtyToOrder : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "Quantity", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Orders", "Quantity");
        }
    }
}
