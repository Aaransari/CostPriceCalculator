using CostPriceCalculator.Interfaces;
using CostPriceCalculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostPriceCalculator.Calculation
{
    public class FIFOCosting : ICosting
    {
        Inventory ICosting.GetInventory(List<Inventory> inventory, out double inventoryCostPrice)
        {
            inventory.Sort((x,y) => x.PurchaseDate.CompareTo((y.PurchaseDate)));
            inventoryCostPrice = inventory.First().Price;
            return inventory.First();
        }
    }
}
