// -----------------------------------------------------------------------
// <copyright file="ProgramTests.cs" company="econ-tec GmbH">
//     Copyright (c) econ-tec GmbH. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------
namespace KataGildeRoseTest
{
    using System;
    using System.Collections.Generic;
    using KataGildedRose;
    using NUnit.Framework;

    public class ProgramTests
    {
        private Program _target;

        [SetUp]
        public void Setup()
        {
            _target = new Program();
        }

        [Test]
        public void PublicItems_DoesExist_AssertsTrue()
        {
            Assert.That(_target.PublicItems, Is.Null);
        }

        [Test]
        public void UpdateQuality_ItemsNotSet_ThrowsException()
        {
            Assert.Throws<NullReferenceException>(() => _target.UpdateQuality());
        }

        [Test]
        public void UpdateQuality_SetItem_NoException()
        {
            _target.PublicItems = new List<Item>();
            _target.UpdateQuality();
        }

        [Test]
        public void UpdateQuality_SetItemKleinesEi_ValuesDecreaseByOne()
        {
            var kleinesEi = new Item { Name = "Kleines Ei", SellIn = 5, Quality = 25 };

            _target.PublicItems = new List<Item> { kleinesEi };
            _target.UpdateQuality();

            Assert.That(kleinesEi.SellIn, Is.EqualTo(4));
            Assert.That(kleinesEi.Quality, Is.EqualTo(24));
        }

        [Test]
        public void UpdateQuality_SetItemKleinesEiSellInOne_ValuesDecreaseByOne()
        {
            var kleinesEi = new Item { Name = "Kleines Ei", SellIn = 1, Quality = 25 };

            _target.PublicItems = new List<Item> { kleinesEi };
            _target.UpdateQuality();

            Assert.That(kleinesEi.SellIn, Is.EqualTo(0));
            Assert.That(kleinesEi.Quality, Is.EqualTo(24));
        }

        [Test]
        public void UpdateQuality_SetTwoNormalItems_NoSideEffects()
        {
            var firstItem = new Item { Name = "Kleines Ei", SellIn = 1, Quality = 25 };
            var secondItem = new Item { Name = "Schreiterfleisch", SellIn = 4, Quality = 30 };

            _target.PublicItems = new List<Item> { firstItem, secondItem };
            _target.UpdateQuality();

            Assert.That(firstItem.SellIn, Is.EqualTo(0));
            Assert.That(firstItem.Quality, Is.EqualTo(24));
            Assert.That(secondItem.SellIn, Is.EqualTo(3));
            Assert.That(secondItem.Quality, Is.EqualTo(29));
        }

        [Test]
        public void UpdateQuality_SetOneItemSellIn0_ValuesDecreaseByTwo()
        {
            var firstItem = new Item { Name = "Kleines Ei", SellIn = 0, Quality = 25 };

            _target.PublicItems = new List<Item> { firstItem };
            _target.UpdateQuality();

            Assert.That(firstItem.SellIn, Is.EqualTo(-1));
            Assert.That(firstItem.Quality, Is.EqualTo(23));
        }
    }
}
