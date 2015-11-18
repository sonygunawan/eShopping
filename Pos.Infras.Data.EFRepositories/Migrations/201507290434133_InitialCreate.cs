namespace Pos.Infras.Data.EFRepositories.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        
        public override void Up()
        {
            //CreateTable(
            //    "dbo.Employees",
            //    c => new
            //        {
            //            Id = c.Int(nullable: false, identity: true),
            //            Code = c.String(),
            //            Name = c.String(),
            //            BirthDate = c.DateTime(nullable: false),
            //            Address_Street = c.String(),
            //            Address_Country = c.String(),
            //            Address_Zip = c.String(),
            //        })
            //    .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.ProductCategories",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Code = c.String(),
                    Name = c.String(),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                        Name = c.String(),
                        UnitPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);

        }
        
        public override void Down()
        {
            DropTable("dbo.Products");
            DropTable("dbo.ProductCategories");
            //DropTable("dbo.Employees");
        }
    }
}
