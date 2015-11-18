using Ninject;
using Pos.Domain;
using Pos.Infras.Data.EFRepositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainTrain.UI.Konsole
{
    public class PosScratch
    {
        static void MainTest(string[] args)
        {
            var kernel = new StandardKernel();

            kernel.Bind<IEmployeeRepository>().To<EmployeeEFRepository>();
            kernel.Bind<IProductRepository>().To<ProductEFRepository>();
            kernel.Bind<EmployeeService>().ToSelf();

            var employeeRepo = kernel.Get<IEmployeeRepository>();
            var suyama = employeeRepo.GetById(1);

            Console.WriteLine(suyama.Name);

            var service = kernel.Get<EmployeeService>();
            Console.WriteLine(service.GenerateCode());
            //Sale s = new Sale();
            //s.LineItems = null;
        }
        static void Main(string[] args)
        {
            var service = new ProductService(new ProductEFRepository());
            Console.WriteLine(service.GenerateCode());

            //var product = service.New();

            var product = new Product { Id = 1, Code = "P01", Name = "Test" };
            var product1 = new Product { Id = 1, Code = "P01", Name = "Test" };

            Console.WriteLine(product == product1);
            Console.WriteLine(product.Equals(product1));
            Console.WriteLine(product.GetHashCode());
            Console.WriteLine(product1.GetHashCode());

        }
    }
}
