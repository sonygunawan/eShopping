using Pos.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pos.Infras.Data.EFRepositories
{
    public class SaleEFRepository : EFRepositoryBase<Sale>, ISaleRepository
    {
        public SaleEFRepository(PosContext posContext) : base(posContext)
        {

        }
        public SaleEFRepository() :this(new PosContext())
        {

        }
        protected override DbSet<Sale> GetEFSet()
        {
            return ctx.Sale;
        }
    }
}
