using Brain.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pos.Domain
{
    public class ProductService : DomainServiceBase<Product>
    {
        public ProductService(IProductRepository productRepository) : base(productRepository)
        {
        }

        public override string GenerateCode()
        {
            return "P" + (repository.GetCount() + 1);
        }

        public override Product New()
        {
            return new Product { Code = GenerateCode(), };
        }

    }
}
