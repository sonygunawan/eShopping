using Brain.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pos.Domain
{
    public class  Product : EntityBase
    {
        private decimal unitPrice;

        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public decimal UnitPrice 
        {
            get { return unitPrice; }
            set
            {
                if (value >= 0)
                    unitPrice = value;
            }
        }
    }
}
