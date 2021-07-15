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
                if (IsAgeBire(item) || IsBackstagePass(item))
                {
                    IncreaseQualityIfLowerMaxQuality(item);

                    if (IsBackstagePass(item))
                    {
                        if (ShouldIncreaseQualityASecondTime(item))
                        {
                            IncreaseQualityIfLowerMaxQuality(item);
                        }

                        if (ShouldIncreaseQualityAThirdTime(item))
                        {
                            IncreaseQualityIfLowerMaxQuality(item);
                        }
                    }
                }
                else
                {
                    if (IsQualityBiggerZero(item))
                    {
                        DecreaseQualityIfNotSulfuras(item);
                    }
                }

                DecreaseSellInIfNotSulfuras(item);

                if (item.SellIn < 0)
                {
                    if (IsAgeBire(item))
                    {
                        IncreaseQualityIfLowerMaxQuality(item);
                    }
                    else
                    {
                        if (IsBackstagePass(item))
                        {
                            item.Quality = 0;
                        }
                        else
                        {
                            if (IsQualityBiggerZero(item))
                            {
                                DecreaseQualityIfNotSulfuras(item);
                            }
                        }
                    }
                }
            }
        }

        private bool IsAgeBire(Item item) 
            => item.Name == _AgedBrie;

        private bool IsBackstagePass(Item item) 
            => item.Name == _BackstagePass;

        private void DecreaseSellInIfNotSulfuras(Item item)
        {
            if (IsNotSulfuras(item))
            {
                item.SellIn -= 1;
            }
        }

        private bool IsQualityBiggerZero(Item item) 
            => item.Quality > 0;

        private void DecreaseQualityIfNotSulfuras(Item item)
        {
            if (IsNotSulfuras(item))
            {
                item.Quality -= 1;
            }
        }

        private bool IsNotSulfuras(Item item) 
            => item.Name != _Sulfuras;

        private void IncreaseQualityIfLowerMaxQuality(Item item)
        {
            if (item.Quality < _MaxQuality)
            {
                item.Quality += 1;
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
