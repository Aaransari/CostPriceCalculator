using CostPriceCalculator.Interfaces;
using CostPriceCalculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CostPriceCalculator.Calculation
{
    public class HighestCostCosting : ICosting
    {
        Inventory ICosting.GetInventory(List<Inventory> inventory, out double LasInventoryCostPrice)
        {
            inventory.Sort((x, y) => x.Price.CompareTo((y.Price)));
            LasInventoryCostPrice = inventory.First().Price;
            return inventory.First();
        }
    }
}
