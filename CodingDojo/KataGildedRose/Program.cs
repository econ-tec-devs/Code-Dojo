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
        private const string _AgedBrie = "Aged Brie";
        private const string _BackstagePass = "Backstage passes to a TAFKAL80ETC concert";
        private const string _Sulfuras = "Sulfuras, Hand of Ragnaros";
        private static readonly int _MaxQuality = 50;
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
                    case _Sulfuras:
                        break;

                    case _AgedBrie:
                        IncreaseItemQuality(item);
                        IncreaseQualityIfBackstagePass(item);
                        DecreaseSellIn(item);
                        if (item.SellIn < 0)
                        {
                            IncreaseItemQuality(item);
                        }

                        break;
                    case _BackstagePass:
                        IncreaseItemQuality(item);
                        IncreaseQualityIfBackstagePass(item);
                        DecreaseSellIn(item);
                        if (item.SellIn < 0)
                        {
                            SetQualityZero(item);
                        }

                        break;
                    default:
                        DecreaseQualityIfQualityGreaterZero(item);
                        DecreaseSellIn(item);
                        break;
                }

                if (item.SellIn < 0)
                {
                    switch (item.Name)
                    {
                        case _AgedBrie:
                            break;
                        case _BackstagePass:
                            break;
                        default:
                            DecreaseQualityIfQualityGreaterZero(item);
                            break;
                    }
                }
            }
        }

        private static void SetQualityZero(Item item) => item.Quality = 0;

        private static void DecreaseSellIn(Item item) => item.SellIn -= 1;

        private static void DecreaseQualityIfQualityGreaterZero(Item item)
        {
            if (item.Quality > 0)
            {
                if (IsNotSulfuras(item))
                {
                    DecreaseItemQuality(item);
                }
            }
        }

        private static void IncreaseQualityIfBackstagePass(Item item)
        {
            if (item.Name == _BackstagePass)
            {
                IncreaseQualitySecond(item);

                IncreaseQualityThird(item);
            }
        }

        private static void IncreaseQualityThird(Item item)
        {
            if (item.SellIn <= 5)
            {
                IncreaseItemQuality(item);
            }
        }

        private static void IncreaseQualitySecond(Item item)
        {
            if (item.SellIn <= 10)
            {
                IncreaseItemQuality(item);
            }
        }

        private static bool IsNotSulfuras(Item item) => item.Name != _Sulfuras;

        private static void DecreaseItemQuality(Item item) => item.Quality -= 1;

        private static void IncreaseItemQuality(Item item)
        {
            if (item.Quality < _MaxQuality)
            {
                item.Quality += 1;
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
