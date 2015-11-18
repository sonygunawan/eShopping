using Brain.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pos.Domain
{
    public interface IProductRepository : IRepository<Product>
    {
        IEnumerable<Product> GetByPriceLessThan(decimal price);

    }
}
