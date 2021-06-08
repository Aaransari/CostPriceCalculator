using CostPriceCalculator.Calculation;
using CostPriceCalculator.Exceptions;
using CostPriceCalculator.Interfaces;
using CostPriceCalculator.Models;
using CostPriceCalculator.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CostPriceCalculator.Services
{
    public class InventoryService
    {
        private List<Inventory> inventory;
        private ICosting costingService;

        public InventoryService()
        {
            inventory = new List<Inventory>();
            LoadInventory();
        }

        private void LoadInventory()
        {
            /*
            Object 1:  a) 1/1/2005,  b)  100,  c) 10
            Object 2:  a) 2/2/2005,  b)  40,  c) 12
            Object 3:  a) 3/3/2005,  b)  50,  c) 11
            */

            inventory.Add(new Inventory() { PurchaseDate = DateTime.ParseExact("1/1/2005", "d/M/yyyy", null), SharesCount = 100, Price = 10 });
            inventory.Add(new Inventory() { PurchaseDate = DateTime.ParseExact("2/3/2005", "d/M/yyyy", null), SharesCount = 40, Price = 12 });
            inventory.Add(new Inventory() { PurchaseDate = DateTime.ParseExact("3/3/2005", "d/M/yyyy", null), SharesCount = 50, Price = 11 });

        }

        private int GetSharesCount()
        {
            return inventory.Sum(x => x.SharesCount);
        }
      
        private double GetCostPrice()
        {
            if (GetSharesCount() > 0)
                return inventory.Sum(x => x.Price * x.SharesCount) / GetSharesCount();
            return 0;
        }

       
        public OrderInvoice Order(Order order, CostingMethod costingMethod)
        {
            int sharesToBeSold = order.NoOfShares;
            double totalCostPrice = 0;
            double inventoryCostPrice;
            OrderInvoice orderInvoice = new OrderInvoice();

            if (GetSharesCount() < order.NoOfShares)
                throw new InventoryException(String.Format("Cannot process order for {0} shares, only {1} shares left in Inventory!",
                    order.NoOfShares, GetSharesCount()));

            // Get costing class object based on the costing method selected, default is FIFO
            costingService = CostingType.GetCostingServiceType(costingMethod);

            var inventoryItem = costingService.GetInventory(inventory, out inventoryCostPrice);
            while (costingService.GetInventory(inventory, out inventoryCostPrice).SharesCount < sharesToBeSold)
            {
                totalCostPrice += inventoryItem.SharesCount * inventoryCostPrice;
                sharesToBeSold -= inventoryItem.SharesCount;
                inventory.RemoveAt(0);
            }

            inventoryItem = costingService.GetInventory(inventory, out inventoryCostPrice);
            inventoryItem.SharesCount -= sharesToBeSold;
            totalCostPrice += sharesToBeSold * inventoryCostPrice;

            if (inventoryItem.SharesCount == 0)
                inventory.RemoveAt(0);


            orderInvoice.CostPriceOfSoldShares = totalCostPrice / order.NoOfShares;
            orderInvoice.ProfitLoss = (order.Price * order.NoOfShares) - totalCostPrice;
            orderInvoice.RemShares = GetSharesCount();
            orderInvoice.CostPriceRemShares = GetCostPrice();

            return orderInvoice;
        }
    }
}
