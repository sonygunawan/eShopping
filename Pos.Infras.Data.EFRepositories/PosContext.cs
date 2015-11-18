using Pos.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pos.Infras.Data.EFRepositories
{
    public class PosContext : DbContext
    {
        public DbSet<ProductCategories> ProductCategories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Sale> Sale { get; set; }

        public PosContext()
            : base("Data Source=(LocalDB)\\v11.0;AttachDbFilename='C:\\Users\\Yulia\\Documents\\Visual Studio 2013\\Projects\\BrainTrain\\Pos.UI.WebMvc.Pos\\App_Data\\BrainDB.mdf';Integrated Security=True;Connect Timeout=30")
        {

        }

    }
}
