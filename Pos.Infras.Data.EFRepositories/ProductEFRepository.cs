using Pos.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pos.Infras.Data.EFRepositories
{
    public class ProductEFRepository : EFRepositoryBase<Product>, IProductRepository
    {
        public ProductEFRepository(PosContext posContext): base(posContext)
        {
        }

        public ProductEFRepository() : this(new PosContext())
        {

        }

        public IEnumerable<Product> GetByPriceLessThan(decimal price)
        {
            return data.Where(p => p.UnitPrice < price).ToList();
        }

        protected override DbSet<Product> GetEFSet()
        {
            return ctx.Products;
        }
    }
}
