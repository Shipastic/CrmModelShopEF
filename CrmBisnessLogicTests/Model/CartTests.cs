using Microsoft.VisualStudio.TestTools.UnitTesting;
using CrmBisnessLogic.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmBisnessLogic.Model.Tests
{
    [TestClass()]
    public class CartTests
    {
        [TestMethod()]
        public void CartTest()
        {
            //arrange
            var customer = new Customer()
            {
                CustomerId = 1,
                Name = "testUser"
            };
            var product1 = new Product()
            {
                ProductId = 1,
                Name = "pr1",
                Price = 100,
                Count = 10
            };
            var product2 = new Product()
            {
                ProductId = 2,
                Name = "pr2",
                Price = 200,
                Count = 20
            };
            //act

            var cart = new Cart(customer);
            cart.Add(product1);
            cart.Add(product1);
            cart.Add(product2);

            var cartResult = cart.GetAll();
            var expectedResult = new List<Product>()
            {
                product1, product1, product2
            };

            //assert

            Assert.AreEqual(expectedResult.Count, cartResult.Count);
            for(int i = 0; i < expectedResult.Count; i++)
            {
                Assert.AreEqual(expectedResult[i], cartResult[i]);
            }
        }
    }
}