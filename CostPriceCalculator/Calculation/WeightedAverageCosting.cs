using CostPriceCalculator.Interfaces;
using CostPriceCalculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostPriceCalculator.Calculation
{
    public class WeightedAverageCosting : ICosting
    {
        Inventory ICosting.GetInventory(List<Inventory> inventory, out double LasInventoryCostPrice)
        {
            LasInventoryCostPrice = GetWeightedAverageCost(inventory);
            return inventory.First(); ;
        }

        private double GetWeightedAverageCost(List<Inventory> inventory)
        {
            return inventory.Sum(x => x.Price * x.SharesCount) / inventory.Sum(x => x.SharesCount);
        }
    }
}
