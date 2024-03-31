using System;

namespace _03.Flowers
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal roseAutumnWinterPrice = 4.50m;
            decimal roseSpringSummerPrice = 4.10m;
            
            decimal tulipAutumnWinterPrice = 4.15m;
            decimal tulipSpringSummerPrice = 2.50m;
            
            decimal chrysantemumAutumnWinterPrice = 3.75m;
            decimal chrysantemumSpringSummerPrice = 2m;
            
            decimal arrangePrice = 2m;


            int priceIncreasePercentage = 15;

            int tulipPriceDecreasePercentage = 5;
            int rosePriceDecreasePercentage = 10;
            int totalPriceDecreasePercentage = 20;

            int tulipPriceDecreaseThreshold = 7;
            int rosePriceDecreaseThreshold = 10;
            int totalPriceDecreaseThreshold = 20;


            int chrysantemumsPurchased = int.Parse(Console.ReadLine());
            int rosesPurchased = int.Parse(Console.ReadLine());
            int tulipsPurchased = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string isSpecialDay = Console.ReadLine();


            decimal rosesPrice;
            decimal chrysantemumPrice;
            decimal tulipsPrice;
            decimal totalCost;
            if (season == "Winter" || season == "Autumn")
            {
                rosesPrice = rosesPurchased * roseAutumnWinterPrice;
                chrysantemumPrice = chrysantemumsPurchased * chrysantemumAutumnWinterPrice;
                tulipsPrice = tulipsPurchased * tulipAutumnWinterPrice;

                totalCost = rosesPrice + chrysantemumPrice + tulipsPrice;
            }
            else
            {
                rosesPrice = rosesPurchased * roseSpringSummerPrice;
                chrysantemumPrice = chrysantemumsPurchased * chrysantemumSpringSummerPrice;
                tulipsPrice = tulipsPurchased * tulipSpringSummerPrice;

                totalCost = rosesPrice + chrysantemumPrice + tulipsPrice;
            }

            if (isSpecialDay == "Y")
            {
                totalCost += totalCost * priceIncreasePercentage / 100m;
            }

            if (tulipsPurchased > tulipPriceDecreaseThreshold && season == "Spring")
            {
                totalCost -= totalCost * tulipPriceDecreasePercentage / 100m;
            }
            if (rosesPurchased >= rosePriceDecreaseThreshold && season == "Winter")
            {
                totalCost -= totalCost * rosePriceDecreasePercentage / 100m;
            }

            if (rosesPurchased + tulipsPurchased + chrysantemumsPurchased > totalPriceDecreaseThreshold)
            {
                totalCost -= totalCost * totalPriceDecreasePercentage / 100m;
            }

            totalCost += arrangePrice;

            Console.WriteLine("{0:F2}", totalCost);
        }
    }
}
