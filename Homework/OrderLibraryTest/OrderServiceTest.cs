using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderLibrary;

namespace OrderLibraryTest
{
    [TestClass]
    public class OrderServiceTest
    {
        [TestMethod]
        public void TestMethod()
        {
            var service = new OrderService();
            service.Add(new Order("XLX", "DZY", 10));
            service.Add(new Order("XLX", "DZY", 11));
            service.Add(new Order("XLX", "DZY", 12));
            service.Add(new Order("XLX", "DZY", 13));
            service.Add(new Order("WZY", "LYX", Decimal.Parse("8.88")));

            var t = service.Retrieve().Where("ItemName", "XLX").OrderBy("Balance", true).Get();

        }
    }
}
