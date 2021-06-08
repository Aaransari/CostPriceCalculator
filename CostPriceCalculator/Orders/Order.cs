using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostPriceCalculator.Orders
{
    public class Order
    {
        public DateTime SellDate { get; set; }
        public int NoOfShares { get; set; }
        public double Price { get; set; }
    }
}
