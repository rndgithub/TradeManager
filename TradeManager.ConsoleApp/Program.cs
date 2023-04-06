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
            var trades = tradeManager.CreateTrades(10);
        }
    }
}
