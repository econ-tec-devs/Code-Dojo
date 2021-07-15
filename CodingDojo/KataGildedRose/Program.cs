// -----------------------------------------------------------------------
// <copyright file="Program.cs" company="econ-tec GmbH">
//     Copyright (c) econ-tec GmbH. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------
namespace KataGildedRose
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        private const int _MaxQuality = 50;
        private const string _AgedBrie = "Aged Brie";
        private const string _BackstagePass = "Backstage passes to a TAFKAL80ETC concert";
        private const string _Sulfuras = "Sulfuras, Hand of Ragnaros";
        private IList<Item> _items;

        public IList<Item> PublicItems
        {
            get => _items;
            set => _items = value;
        }

        public void UpdateQuality()
        {
            foreach (var item in _items)
            {
                switch (item.Name)
                {
                    case _AgedBrie:
                        IfQualityLowerMaxQualityIncreaseQuality(item);

                        item.SellIn -= 1;

                        if (item.SellIn < 0)
                        {
                            IfQualityLowerMaxQualityIncreaseQuality(item);
                        }

                        break;
                    case _BackstagePass:
                    {
                        IfQualityLowerMaxQualityIncreaseQuality(item);
                        IfSellInLowerEqual10IncreaseQuality(item);
                        IfSellInLowerEqual5IncreaseQuality(item);

                        item.SellIn -= 1;

                        if (item.SellIn < 0)
                        {
                            item.Quality = 0;
                        }

                        break;
                    }
                    case _Sulfuras:
                    {
                        break;
                    }
                    default:
                    {
                        IfQualityGreater0DecreaseQuality(item);

                        item.SellIn -= 1;

                        if (item.SellIn < 0)
                        {
                            IfQualityGreater0DecreaseQuality(item);
                        }

                        break;
                    }
                }
            }
        }

        private static void IfQualityGreater0DecreaseQuality(Item item)
        {
            if (item.Quality > 0)
            {
                item.Quality -= 1;
            }
        }

        private static void IfQualityLowerMaxQualityIncreaseQuality(Item item)
        {
            if (item.Quality < _MaxQuality)
            {
                item.Quality += 1;
            }
        }

        private static void IfSellInLowerEqual5IncreaseQuality(Item item)
        {
            if (item.SellIn <= 5)
            {
                IfQualityLowerMaxQualityIncreaseQuality(item);
            }
        }

        private static void IfSellInLowerEqual10IncreaseQuality(Item item)
        {
            if (item.SellIn <= 10)
            {
                IfQualityLowerMaxQualityIncreaseQuality(item);
            }
        }

        private static void Main(string[] args)
        {
            Console.WriteLine("OMGHAI!");

            var app = new Program
            {
                _items = new List<Item>
                {
                    new Item { Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20 },
                    new Item { Name = _AgedBrie, SellIn = 2, Quality = 0 },
                    new Item { Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7 },
                    new Item { Name = _Sulfuras, SellIn = 0, Quality = 80 },
                    new Item
                    {
                        Name = _BackstagePass,
                        SellIn = 15,
                        Quality = 20
                    },
                    new Item { Name = "Conjured Mana Cake", SellIn = 3, Quality = 6 }
                }
            };

            app.UpdateQuality();

            Console.ReadKey();
        }
    }

    public class Item
    {
        public string Name { get; set; }

        public int SellIn { get; set; }

        public int Quality { get; set; }
    }
}
