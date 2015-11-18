using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pos.Domain
{
    public class Samples
    {
        public static Employee Suyama
        {
            get { return new Employee { Code = "E01", Name = "Michael Suyama", BirthDate = DateTime.Now.AddYears(-50) }; }
        }

        public static Employee Nancy
        {
            get { return new Employee { Code = "E02", Name = "Nancy Davolio", BirthDate = DateTime.Now.AddYears(-44) }; }
        }

        public static Product Momogi
        {
            get { return new Product { Code = "P01", Name = "Momogi", UnitPrice = 500m }; }
        }

        public static Product Pepsi
        {
            get { return new Product { Code = "P02", Name = "Pepsi", UnitPrice = 1000m }; }
        }

        public static Product Ayam
        {
            get { return new Product { Code = "P03", Name = "Ayam", UnitPrice = 50000m }; }
        }
    }
}
