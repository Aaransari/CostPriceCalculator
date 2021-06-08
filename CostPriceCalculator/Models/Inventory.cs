using System;
using System.Collections.Generic;
using System.Text;

namespace CostPriceCalculator.Models
{
    public class Inventory
    {
        public DateTime PurchaseDate { get; set; }
        public int SharesCount { get; set; }
        public double Price { get; set; }
    }
}
