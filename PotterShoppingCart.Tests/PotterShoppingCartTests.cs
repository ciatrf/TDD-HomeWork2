using System;
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

        [TestMethod()]
        public void 第一集買了一本_第二集也買了一本_價格應為100X2X95折_回傳190() 
        {
            //arrange
            var cart = new PotterShoppingCart();
            var products = new List<PotterBook>
            {
                new PotterBook{Name = "Potter1", Price = 100},
                new PotterBook{Name = "Potter2", Price = 100}
            };
            var expected = 190;
            //act
            var actual = cart.CalculatePrice(products);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void 一二三集各買了一本_價格應為100X3X09_回傳270()
        {
            //arrange
            var cart = new PotterShoppingCart();
            var products = new List<PotterBook>
            {
                new PotterBook{Name = "Potter1", Price = 100},
                new PotterBook{Name = "Potter2", Price = 100},
                new PotterBook{Name = "Potter3", Price = 100}
            };
            var expected = 270;
            //act
            var actual = cart.CalculatePrice(products);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void 一二三四集各買了一本_價格應為100X4X08_回傳320()
        {
            //arrange
            var cart = new PotterShoppingCart();
            var products = new List<PotterBook>
            {
                new PotterBook{Name = "Potter1", Price = 100},
                new PotterBook{Name = "Potter2", Price = 100},
                new PotterBook{Name = "Potter3", Price = 100},
                new PotterBook{Name = "Potter4", Price = 100}
            };
            var expected = 320;
            //act
            var actual = cart.CalculatePrice(products);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
