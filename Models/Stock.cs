using System;
using System.Collections.Generic;
using System.Linq;

namespace StockPortfolioTracker.Models
{
    public class Stock
    {
        public string Symbol { set; get; }
        public int Quantity { set; get; }
        public decimal Price { set; get; }
        public decimal TotalValue => Price * Quantity;
    }
}