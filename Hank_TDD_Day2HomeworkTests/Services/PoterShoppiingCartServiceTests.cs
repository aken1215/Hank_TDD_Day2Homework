using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hank_TDD_Day2Homework.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hank_TDD_Day2Homework.Models;

namespace Hank_TDD_Day2Homework.Services.Tests
{
    [TestClass()]
    public class PoterShoppiingCartServiceTests
    {
        [TestMethod()]
        public void OrderPoterI_AndBill_ThenPriceIs100()
        {
            //arrange
            var target =  new PoterShoppiingCartService();

            var PoterI = new PoterBook() { Version = PoterVersion.I };

            //act
            target.OrderProduct(PoterI);
            var actual = target.Bill();
            var expected = 100;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Order1_PoterIAndPoterII_AndBill_ThenPriceIs190()
        {
            //arrange
            var target = new PoterShoppiingCartService();
            var PoterI = new PoterBook() { Version = PoterVersion.I };
            var PoterII = new PoterBook() { Version = PoterVersion.II };

            //act
            target.OrderProduct(PoterI);
            target.OrderProduct(PoterII);
            var actual = target.Bill();
            var expected = 190;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Order1_PoterIAndPoterIIAndPoterIII_AndBill_ThenPriceIs270()
        {
            //arrange
            var target = new PoterShoppiingCartService();
            var PoterI = new PoterBook() { Version = PoterVersion.I };
            var PoterII = new PoterBook() { Version = PoterVersion.II };
            var PoterIII = new PoterBook() { Version = PoterVersion.III };

            //act
            target.OrderProduct(PoterI);
            target.OrderProduct(PoterII);
            target.OrderProduct(PoterIII);
            var actual = target.Bill();
            var expected = 270;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Order1_PoterIAndPoterIIAndPoterIIIAndPoterIV_AndBill_ThenPriceIs320()
        {
            //arrange
            var target = new PoterShoppiingCartService();
            var PoterI = new PoterBook() { Version = PoterVersion.I };
            var PoterII = new PoterBook() { Version = PoterVersion.II };
            var PoterIII = new PoterBook() { Version = PoterVersion.III };
            var PoterIV = new PoterBook() { Version = PoterVersion.IV };

            //act
            target.OrderProduct(PoterI);
            target.OrderProduct(PoterII);
            target.OrderProduct(PoterIII);
            target.OrderProduct(PoterIV);
            var actual = target.Bill();
            var expected = 320;

            //assert
            Assert.AreEqual(expected, actual);
        }
    }

}