﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PotterShoppingCart;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PotterShoppingCart;
namespace PotterShoppingCart.Tests
{
    [TestClass()]
    public class PotterShoppingCartTests
    {
        [TestMethod()]
        public void 第一集買了一本_其他都沒買_價格應為100元()
        {
            //arrange
            var cart = new PotterShoppingCart();
            var products = new List<PotterBook>
            {
                new PotterBook{Name = "Potter1", Price = 100}
            };
            var expected = 100;
            //act
            var actual = cart.CalculatePrice(products);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
