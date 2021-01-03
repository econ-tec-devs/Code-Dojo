// -----------------------------------------------------------------------
// <copyright file="Sushi.cs" company="econ-tec GmbH">
//     Copyright (c) econ-tec GmbH. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------
namespace KataTest
{
    using System.Collections.Generic;
    using System.Linq;

    public class Sushi
    {
        private static decimal price;

        public static decimal GetPrice(List<string> plates)
        {
            if (plates == null)
            {
                return 0;
            }

            var priceOneRedPlate = 1.95m;
            var priceOneGreenPlate = 3.95m;
            var priceOneGreyPlate = 4.95m;
            var priceOneBluePlate = 0.95m;
            var priceOneYellowPlate = 2.95m;

            if (plates.Contains("red"))
            {
                return GetCalculatePrice(plates, priceOneRedPlate, "red");
            }

            if (plates.Contains("gray"))
            {
                //var gray = plates.Where(x => x == "gray").ToList();
                //price += priceOneGreyPlate * gray.Count;
                return GetCalculatePrice(plates, priceOneGreyPlate, "gray");
            }

            if (plates.Contains("yellow"))
            {
                return GetCalculatePrice(plates, priceOneYellowPlate, "yellow");

                //var yellow = plates.Where(x => x == "yellow").ToList();
                //price += priceOneYellowPlate * yellow.Count;
            }

            if (plates.Contains("blue"))
            {
                return GetCalculatePrice(plates, priceOneBluePlate, "blue");

                //var blue = plates.Where(x => x == "blue").ToList();
                //price += priceOneBluePlate * blue.Count;
            }

            if (plates.Contains("green"))
            {
                return GetCalculatePrice(plates, priceOneGreenPlate, "green");

                //var blue = plates.Where(x => x == "blue").ToList();
                //price += priceOneBluePlate * blue.Count;
            }

            return price;
        }

        private static decimal GetCalculatePrice(List<string> plates, decimal priceOneRedPlate, string color)
        {
            var red = plates.Where(x => x == color).ToList();
            price += priceOneRedPlate * red.Count;
            return price;
        }
    }
}
