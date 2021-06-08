using CostPriceCalculator.Interfaces;
using CostPriceCalculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostPriceCalculator.Calculation
{
    public class LowestCostCosting : ICosting
    {
        Inventory ICosting.GetInventory(List<Inventory> inventory, out double LasInventoryCostPrice)
        {
            inventory.Sort((x, y) => x.Price.CompareTo((y.Price)));
            LasInventoryCostPrice = inventory.Last().Price;
            return inventory.Last();
        }
    }
}
