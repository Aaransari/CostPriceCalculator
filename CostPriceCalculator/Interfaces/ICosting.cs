using CostPriceCalculator.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CostPriceCalculator.Interfaces
{
    public interface ICosting
    {
        Inventory GetInventory(List<Inventory> inventory, out double LasInventoryCostPrice);
    }
}
