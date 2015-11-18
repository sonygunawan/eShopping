using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pos.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pos.Domains.Tests
{
    [TestClass]
    public class SaleLineItemTest
    {
        [TestMethod]
        public void sli_with_momogi_2_should_subtotaled_1000()
        {
            var sli = new SaleLineItem(Samples.Momogi, 2);
            Assert.AreEqual(1000m, sli.GetSubtotal());
        }

        [TestMethod]
        public void when_product_price_is_changed_subtotal_should_remain_consistent()
        {
            var momogi = Samples.Momogi;
            var sli = new SaleLineItem(Samples.Momogi, 2);
            Assert.AreEqual(1000m, sli.GetSubtotal());
            momogi.UnitPrice = 0;
            Assert.AreEqual(1000m, sli.GetSubtotal());
        }
    }
}
