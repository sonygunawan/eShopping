using Brain.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pos.Domain
{
    public class ProductCategories : EntityBase
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }

        public IList<Product> Items { get; set; }

        public ProductCategories()
        {
            Items = new List<Product>();
        }
        public void AddProductItem(Product product)
        {
            Items.Add(product);
        }
    }
}
