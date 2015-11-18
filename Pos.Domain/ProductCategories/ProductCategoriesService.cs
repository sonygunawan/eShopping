using Brain.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pos.Domain
{
    public class ProductCategoriesService :DomainServiceBase<ProductCategories>
    {
        public ProductCategoriesService(IProductCategoryRepository productCategoriesRepository)
            : base(productCategoriesRepository)
        {
        }
        public override string GenerateCode()
        {
            return "C" + (repository.GetCount() + 1);
        }

        public override ProductCategories New()
        {
            return new ProductCategories { Code = GenerateCode(), };
        }
    }
}
