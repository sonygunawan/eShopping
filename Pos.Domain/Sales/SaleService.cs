using Brain.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pos.Domain
{
    public class SaleService : DomainServiceBase<Sale>
    {
        public SaleService(ISaleRepository saleRepository)
            : base(saleRepository)
        {

        }

        public override string GenerateCode()
        {
            return "S" + (repository.GetCount() + 1);
        }

        public override Sale New()
        {
            return new Sale { Code = GenerateCode(), };
        }

    }
}
