// -----------------------------------------------------------------------
// <copyright file="Sushi.cs" company="econ-tec GmbH">
//     Copyright (c) econ-tec GmbH. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------
namespace KataTest
{
    using System;
    using System.Collections.Generic;

    public class Sushi
    {
        private static Dictionary<DishColor, decimal> priceList = new Dictionary<DishColor, decimal>()
        {
            { DishColor.Blue, 0.95m },
            { DishColor.Red, 1.95m },
            { DishColor.Yellow, 2.95m },
            { DishColor.Green, 3.95m },
            { DishColor.Gray, 4.95m }
        };

        public static decimal Calculate(List<DishColor> basket)
        {
            decimal sum = 0;
            foreach (var dish in basket)
            {
                sum += priceList[dish];
            }

            return sum;
        }

        public static PriceInfo Calculate(List<DishColor> basket, DateTime date)
        {
            var priceInfo = new PriceInfo();
            if (date.DayOfWeek == DayOfWeek.Monday)
            {
                priceInfo.regularPrice = Calculate(basket);
                priceInfo.priceToPay = priceInfo.regularPrice;
                priceInfo.difference = priceInfo.regularPrice - priceInfo.priceToPay;
            }
            if (date.DayOfWeek == DayOfWeek.Tuesday)
            {
                priceInfo.regularPrice = Calculate(basket);
                priceInfo.priceToPay = priceInfo.regularPrice;
                priceInfo.difference = priceInfo.regularPrice - priceInfo.priceToPay;
            }

            return priceInfo;
        }
    }
}
