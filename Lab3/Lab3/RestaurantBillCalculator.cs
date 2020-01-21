using System.IO;

namespace Lab3
{
    public static class RestaurantBillCalculator
    {
        public static double CalculateTotalCost(StreamReader input)
        {
            const double TAX = 0.05;
             
            double foodAPrice = double.Parse(input.ReadLine());
            double foodBPrice = double.Parse(input.ReadLine());
            double foodCPrice = double.Parse(input.ReadLine());
            double foodDPrice = double.Parse(input.ReadLine());
            double foodEPrice = double.Parse(input.ReadLine());
            double tip = double.Parse(input.ReadLine());

            foodAPrice += (foodAPrice * TAX);
            foodAPrice += (foodAPrice * tip / 100);

            foodBPrice += (foodBPrice * TAX);
            foodBPrice += (foodBPrice * tip / 100);

            foodCPrice += (foodCPrice * TAX);
            foodCPrice += (foodCPrice * tip / 100);

            foodDPrice += (foodDPrice * TAX);
            foodDPrice += (foodDPrice * tip / 100);

            foodEPrice += (foodEPrice * TAX);
            foodEPrice += (foodEPrice * tip / 100);


            double totalCost = foodAPrice + foodBPrice + foodCPrice + foodDPrice + foodEPrice;
            totalCost = (int)(totalCost * 100 + 0.5) / 100.0;

            return totalCost;
        }

        public static double CalculateIndividualCost(StreamReader input, double totalCost)
        {
            double payerCount = double.Parse(input.ReadLine());
            double individualCost = totalCost / payerCount;
            individualCost = (int)(individualCost * 100 + 0.5) / 100.0;

            return individualCost;
        }

        public static uint CalculatePayerCount(StreamReader input, double totalCost)
        {
            double individualCost = double.Parse(input.ReadLine());
            double doublepayerCount = totalCost / individualCost;
            uint payerCount = (uint)(doublepayerCount * 10 + 0.5) / 10;
            if (payerCount * individualCost < totalCost)
            {
                payerCount += 1;
            }

            return payerCount;
        }
    }
}