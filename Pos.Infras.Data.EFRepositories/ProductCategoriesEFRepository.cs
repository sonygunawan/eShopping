using Pos.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pos.Infras.Data.EFRepositories
{
    public class ProductCategoriesEFRepository : EFRepositoryBase<ProductCategories>, IProductCategoryRepository
    {
        public ProductCategoriesEFRepository(PosContext posContext): base(posContext)
        {
        }

        public ProductCategoriesEFRepository() : this(new PosContext())
        {

        }
        protected override DbSet<ProductCategories> GetEFSet()
        {
            return ctx.ProductCategories;
        }
    }
}
