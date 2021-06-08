using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostPriceCalculator.Orders
{
    public class OrderInvoice
    {
        public double CostPriceOfSoldShares { get; set; }
        public double ProfitLoss { get; set; }
        public double RemShares { get; set; }
        public double CostPriceRemShares { get; set; }
    }
}
