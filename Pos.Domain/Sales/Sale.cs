using Brain.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pos.Domain
{
    public class Sale : EntityBase
    {
        public string Code { get; set; }
        public DateTime Time { get; set; }

        public Employee Cashier { get; set; }
        public IList<SaleLineItem> LineItems { get; private set; }
        public decimal GetTotal()
        {
            decimal total = 0m;
            foreach (var sli in LineItems)
                total += sli.GetSubtotal();
            return total;
        }

        public Sale()
        {
            Time = DateTime.Now;
            LineItems = new List<SaleLineItem>();
        }

        public void AddLineItem(Product product, int quantity = 1)
        {
            var sli = new SaleLineItem(product, quantity);
            LineItems.Add(sli);
        }

    }
}
