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
        private readonly int _MaxQuality = 50;
        private const string _AgedBrie = "Aged Brie";
        private const string _BackstagePass = "Backstage passes to a TAFKAL80ETC concert";
        private const string _Sulfuras = "Sulfuras, Hand of Ragnaros";
        private IList<Item> _items;

        public IList<Item> PublicItems
        {
            get => this._items;
            set => this._items = value;
        }

        public void UpdateQuality()
        {
            foreach (Item item in _items)
            {
                switch (item.Name)
                {
                    case _AgedBrie:
                        IncreaseQualityIfLowerMaxQuality(item);
                        DecreaseSellInByOne(item);
                        if (item.SellIn < 0)
                        {
                            IncreaseQualityIfLowerMaxQuality(item);
                        }
                        break;
                    case _BackstagePass:
                        IncreaseQualityBackstagePass(item);
                        DecreaseSellInByOne(item);
                        if (item.SellIn < 0)
                        {
                            item.Quality = 0;
                        } 
                        break;
                    case _Sulfuras:
                       break;
                    default:
                        if (IsQualityBiggerZero(item))
                        {
                            DecreaseQualityByOne(item);
                        }
                        DecreaseSellInByOne(item);
                        if (item.SellIn < 0)
                        {
                            if (IsQualityBiggerZero(item))
                            {
                                DecreaseQualityByOne(item);
                            }
                        }
                        break;
                }
            }
        }

        private void IncreaseQualityBackstagePass(Item item)
        {
            IncreaseQualityIfLowerMaxQuality(item);
            if (ShouldIncreaseQualityASecondTime(item))
            {
                IncreaseQualityIfLowerMaxQuality(item);
            }

            if (ShouldIncreaseQualityAThirdTime(item))
            {
                IncreaseQualityIfLowerMaxQuality(item);
            }
        }

        private void DecreaseQualityByOne(Item item) 
            => item.Quality -= 1;

        private void DecreaseSellInByOne(Item item) 
            => item.SellIn -= 1;


        private bool IsAgeBrie(Item item) 
            => item.Name == _AgedBrie;

        private bool IsBackstagePass(Item item) 
            => item.Name == _BackstagePass;

        private bool IsQualityBiggerZero(Item item) 
            => item.Quality > 0;

        private bool IsSulfuras(Item item) 
            => item.Name == _Sulfuras;

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

            Program app = new Program
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
