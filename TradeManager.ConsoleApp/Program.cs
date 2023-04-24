using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeManager.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var tradeManager = new TradeManager();
            var numberOfTrades = 10;
            var trades = tradeManager.CreateTrades(numberOfTrades);
        }
    }
}
