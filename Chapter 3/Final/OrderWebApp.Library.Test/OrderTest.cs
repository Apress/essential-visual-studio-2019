using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OrderWebApp.Library.Test
{
    [TestClass]
    public class OrderTest
    {
        [TestMethod]
        public void Lines_AddOrderLine_LinesCountIsCorrect()
        {
            Order target = new Order();

            target.AddOrderLine();

            Assert.AreEqual(1, target.Lines.Count,
               "The order line was not added");
        }

        [TestMethod]
        public void Lines_AddOrderLineWithProduct_ProductIsCorrect()
        {
            Order target = new Order();
            Product product = new Product()
            {
                Id = 1,
                Number = "A-123"
            };

            target.AddOrderLine(product, 1);

            Assert.AreEqual(1, target.Lines.Count,
                "The order line was not added");
            Assert.IsNotNull(target.Lines[0].Product,
                "No product was added to the order line");
            Assert.AreEqual(product.Id,
                target.Lines[0].Product.Id,
                "The product was not added to the order line");
        }

    }
}
