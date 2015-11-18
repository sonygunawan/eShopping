using Brain.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pos.Domain
{
    public class SaleLineItem : EntityBase
    {
        private Product product;

        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }

        public Product Product 
        {
            get { return product; }
            set
            {
                UnitPrice = value.UnitPrice;
                product = value;
            }
        }        

        public SaleLineItem(Product product, int quantity)
        {
            this.Product = product;
            this.Quantity = quantity;
        }

        public decimal GetSubtotal()
        {
            return UnitPrice * Quantity;
        }
    }
}
