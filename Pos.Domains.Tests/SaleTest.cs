using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pos.Domain;

namespace Pos.Domains.Tests
{
    [TestClass]
    public class SaleTest
    {
        [TestMethod]
        public void Sale_with_2_momogi_and_pepsi_should_be_totaled_6000()
        {            
            var sale = new Sale();
            sale.AddLineItem(Samples.Momogi, 2);
            sale.AddLineItem(Samples.Pepsi);

            Assert.AreEqual(6000m, sale.GetTotal());
        }

        [TestMethod]
        public void Sale_with_pepsi_and_ayam_should_be_totaled_55000()
        {
            var sale = new Sale();
            sale.AddLineItem(Samples.Pepsi);
            sale.AddLineItem(Samples.Ayam);
            Assert.AreEqual(55000m, sale.GetTotal());
        }

        [TestMethod]
        public void MyTestMethod()
        {
            var sale = new Sale();
            var momogi = Samples.Momogi;
            sale.AddLineItem(momogi);
            sale.AddLineItem(Samples.Pepsi);
            Assert.AreEqual(5500m, sale.GetTotal());
            momogi.UnitPrice = 0;
            Assert.AreEqual(5500m, sale.GetTotal());
        }
    }
}
