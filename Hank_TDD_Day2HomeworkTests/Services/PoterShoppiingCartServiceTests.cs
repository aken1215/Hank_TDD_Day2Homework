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
    }

}