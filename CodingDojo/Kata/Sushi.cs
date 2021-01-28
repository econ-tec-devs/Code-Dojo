using System;
using System.Collections.Generic;

namespace Kata
{
    public class Sushi
    {
        private static Dictionary<DishColor, decimal> pricelist = new Dictionary<DishColor, decimal>()
        {
            {DishColor.Blue, 0.95m},
            {DishColor.Red, 1.95m},
            {DishColor.Yellow, 2.95m},
            {DishColor.Green, 3.95m},
            {DishColor.Grey, 4.95m},
        };

        public static Tuple<decimal, decimal, decimal> Calculate(List<DishColor> basket, DateTime timeOfPayment)
        {
            var brunchPrice = 19.90m;
            var sum = Calculate(basket);
            decimal toPay = sum;

            if (timeOfPayment.DayOfWeek == DayOfWeek.Sunday && timeOfPayment.Hour <= 15 && timeOfPayment.Hour >= 11)
            {
                toPay = brunchPrice;
            }

            decimal saved = sum - toPay;

            return new Tuple<decimal, decimal, decimal>(sum, toPay, saved);
        }

   public static decimal Calculate(List<DishColor> basket)
        {
            var sum = 0m;
            
            {
                foreach (var item in basket)
                {
                    sum += pricelist[item];
                }

            }

            return sum;
        }
    }
}