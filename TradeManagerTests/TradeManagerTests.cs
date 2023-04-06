using Microsoft.VisualStudio.TestTools.UnitTesting;
using TradeManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeManager.Tests
{
    [TestClass()]
    public class TradeManagerTests
    {
        [TestMethod()]
        public void CreateTradesTest()
        {
            var tradeManager = new TradeManager();
            var expectedNumberOfTrades = 10;
            var trades = tradeManager.CreateTrades(expectedNumberOfTrades);
            Assert.AreEqual(expectedNumberOfTrades, trades.Count);
        }
    }
}