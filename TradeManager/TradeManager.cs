using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeManager
{
    public class TradeManager
    {
        public List<Trade> CreateTrades(int numberOfTradesToCreate)
        {
            var trades = new List<Trade>();
            for (int i = 0; i < numberOfTradesToCreate; i++)
            {
                trades.Add(new Trade());
            }

            return trades;
        }
    }
}
