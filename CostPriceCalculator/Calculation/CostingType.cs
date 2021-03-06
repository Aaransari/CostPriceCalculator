using CostPriceCalculator.Calculation;
using CostPriceCalculator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostPriceCalculator.Calculation
{
    public class CostingType
    {
        public static ICosting GetCostingServiceType(CostingMethod costingMethod)
        {
            switch (costingMethod)
            {
                case CostingMethod.FIFO:
                    return new FIFOCosting();
                case CostingMethod.LIFO:
                    return new LIFOCosting();
                case CostingMethod.HighestCost:
                    return new HighestCostCosting();
                case CostingMethod.LowestCost:
                    return new LowestCostCosting();
                case CostingMethod.WeightedAverage:
                    return new WeightedAverageCosting();
                default:
                    return new LIFOCosting();
            }
        }
    }
}
