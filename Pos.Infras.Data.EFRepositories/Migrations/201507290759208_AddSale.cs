namespace Pos.Infras.Data.EFRepositories.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSale : DbMigration
    {
        public override void Up()
        {
            //CreateTable(
            //    "dbo.Sales",
            //    c => new
            //        {
            //            Id = c.Int(nullable: false, identity: true),
            //            Code = c.String(),
            //            Time = c.DateTime(nullable: false),
            //            Cashier_Id = c.Int(),
            //        })
            //    .PrimaryKey(t => t.Id)
            //    .ForeignKey("dbo.Employees", t => t.Cashier_Id)
            //    .Index(t => t.Cashier_Id);
            
            //CreateTable(
            //    "dbo.SaleLineItems",
            //    c => new
            //        {
            //            Id = c.Int(nullable: false, identity: true),
            //            Quantity = c.Int(nullable: false),
            //            UnitPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
            //            Product_Id = c.Int(),
            //            Sale_Id = c.Int(),
            //        })
            //    .PrimaryKey(t => t.Id)
            //    .ForeignKey("dbo.Products", t => t.Product_Id)
            //    .ForeignKey("dbo.Sales", t => t.Sale_Id)
            //    .Index(t => t.Product_Id)
            //    .Index(t => t.Sale_Id);
            
        }
        
        public override void Down()
        {
            //DropForeignKey("dbo.SaleLineItems", "Sale_Id", "dbo.Sales");
            //DropForeignKey("dbo.SaleLineItems", "Product_Id", "dbo.Products");
            //DropForeignKey("dbo.Sales", "Cashier_Id", "dbo.Employees");
            //DropIndex("dbo.SaleLineItems", new[] { "Sale_Id" });
            //DropIndex("dbo.SaleLineItems", new[] { "Product_Id" });
            //DropIndex("dbo.Sales", new[] { "Cashier_Id" });
            //DropTable("dbo.SaleLineItems");
            //DropTable("dbo.Sales");
        }
    }
}
