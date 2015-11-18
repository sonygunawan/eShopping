namespace Pos.Infras.Data.EFRepositories.Migrations
{
    using Pos.Domain;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Pos.Infras.Data.EFRepositories.PosContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }
        
        protected override void Seed(PosContext context)
        {
            var test = new InitialCreate();
            test.Down();
            test.Up();
            var productRepo = new ProductEFRepository(context);
            var momogi = Samples.Momogi;
            var pepsi = Samples.Pepsi;
            var ayam = Samples.Ayam;

            var productCatRepo = new ProductCategoriesEFRepository(context);
            var cate = new ProductCategories();
            cate.Code = "C01";
            cate.Name = "Food";
            cate.AddProductItem(momogi);
            cate.AddProductItem(ayam);
            productCatRepo.Save(cate);

            cate = new ProductCategories();
            cate.Code = "C02";
            cate.Name = "Drinks";
            cate.AddProductItem(pepsi);
            productCatRepo.Save(cate);

            //var suyama = Samples.Suyama;
            //var employeeRepo = new EmployeeEFRepository(context);
            //employeeRepo.Save(suyama);
            //employeeRepo.Save(Samples.Nancy);

            //var saleRepo = new SaleEFRepository(context);
            //var sale = new Sale();
            //sale.Code = "S01";
            //sale.Cashier = suyama;
            //sale.AddLineItem(momogi, 1);
            //sale.AddLineItem(pepsi, 2);
            //saleRepo.Save(sale);

        }
    }
}
