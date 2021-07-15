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
        private static readonly int _MaxQuality = 50;
        private static readonly string _AgedBrie = "Aged Brie";
        private static readonly string _BackstagePass = "Backstage passes to a TAFKAL80ETC concert";
        private static readonly string _Sulfuras = "Sulfuras, Hand of Ragnaros";
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
                if (item.Name != _AgedBrie && item.Name != _BackstagePass)
                {
                    if (item.Quality > 0)
                    {
                        if (item.Name != _Sulfuras)
                        {
                            item.Quality -= 1;
                        }
                    }
                }
                else
                {
                    if (item.Quality < _MaxQuality)
                    {
                        item.Quality += 1;

                        if (item.Name == _BackstagePass)
                        {
                            if (ShouldIncreaseQualityASecondTime(item))
                            {
                                if (item.Quality < _MaxQuality)
                                {
                                    item.Quality += 1;
                                }
                            }

                            if (ShouldIncreaseQualityAThirdTime(item))
                            {
                                if (item.Quality < _MaxQuality)
                                {
                                    item.Quality += 1;
                                }
                            }
                        }
                    }
                }

                if (item.Name != _Sulfuras)
                {
                    item.SellIn -= 1;
                }

                if (item.SellIn < 0)
                {
                    if (item.Name != _AgedBrie)
                    {
                        if (item.Name != _BackstagePass)
                        {
                            if (item.Quality > 0)
                            {
                                if (item.Name != _Sulfuras)
                                {
                                    item.Quality -= 1;
                                }
                            }
                        }
                        else
                        {
                            item.Quality -= item.Quality;
                        }
                    }
                    else
                    {
                        if (item.Quality < _MaxQuality)
                        {
                            item.Quality += 1;
                        }
                    }
                }
            }
        }

        private bool ShouldIncreaseQualityAThirdTime(Item item) 
            => item.SellIn <= 5;

        private bool ShouldIncreaseQualityASecondTime(Item item) 
            => item.SellIn <= 10;

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
