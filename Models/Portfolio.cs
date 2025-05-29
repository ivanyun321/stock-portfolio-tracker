using System;
using System.Collections.Generic;
using System.Linq;
namespace StockPortfolioTracker.Models
{
    public class Portfolio
    {
        public List<Stock> MyStocks { set; get; } = new();

        public void AddStock(Stock stock)
        {
            MyStocks.Add(stock);
        }

        public decimal TotalValue => MyStocks.Sum(s => s.TotalValue);

    }
}