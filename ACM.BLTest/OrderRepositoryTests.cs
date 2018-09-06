using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;
using System.Collections.Generic;

namespace ACM.BLTest
{
    [TestClass]
    public class OrderRepositoryTests
    {
        [TestMethod]
        public void RetrieveOrderDisplayTest()
        {
            //-- Arrange
            var orderRepository = new OrderRepository();
            var expected = new OrderDisplay()
            {
                FirstName = "Bilbo",
                LastName = "Baggins",
                OrderDate = new DateTimeOffset(
                    2014, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0)),
                ShippingAddress = new Address()
                {
                    AddressType = 1,
                    StreetLine1 = "Bag End",
                    StreetLine2 = "Bagshot Row",
                    City = "Hobbiton",
                    State = "Shire",
                    Country = "Middle Earth",
                    PostalCode = "144"
                },
                OrderDisplayItemList = new List<OrderDisplayItem>()
                {
                    new OrderDisplayItem()
                    {
                        ProductName = "Sunflowers",
                        PurchasePrice = 15.96M,
                        OrderQuantity = 2
                    },
                    new OrderDisplayItem()
                    {
                        ProductName = "Rake",
                        PurchasePrice = 6M,
                        OrderQuantity = 1
                    }
                }
            };
            //-- Act
            var actual = orderRepository.RetrieveOrderDisplay(10);

            //-- Assert
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
            Assert.AreEqual(expected.OrderDate, actual.OrderDate);

            for (int i = 0; i < 1; i++)
            {
                Assert.AreEqual(
                    expected.OrderDisplayItemList[i].OrderQuantity, 
                    actual.OrderDisplayItemList[i].OrderQuantity);
                Assert.AreEqual(
                    expected.OrderDisplayItemList[i].ProductName, 
                    actual.OrderDisplayItemList[i].ProductName);
                Assert.AreEqual(
                    expected.OrderDisplayItemList[i].PurchasePrice, 
                    actual.OrderDisplayItemList[i].PurchasePrice);
            }

        }
        
    }
}
