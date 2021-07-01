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

        [TestCase("Kleines Ei", 5, 25, 4, 24)]
        [TestCase("Kleines Ei", 1, 25, 0, 24)]
        [TestCase("Kleines Ei", 0, 25, -1, 23)]
        [TestCase("Kleines Ei", 0, 0, -1, 0)]
        [TestCase("Kleines Ei", -1, 0, -2, 0)]
        [TestCase("Aged Brie", 15, 5, 14, 6)]
        [TestCase("Aged Brie", 11, 5, 10, 6)]
        [TestCase("Aged Brie", 10, 5, 9, 6)] // Does not meet the conditions described - should be expectedQuality=7
        [TestCase("Aged Brie", 9, 5, 8, 6)] // Does not meet the conditions described - should be expectedQuality=7
        [TestCase("Aged Brie", 5, 5, 4, 6)] // Does not meet the conditions described - should be expectedQuality=8
        [TestCase("Aged Brie", 3, 49, 2, 50)] 
        public void UpdateQuality_InputArgs_ReturnsExpected(string item, int sellIn, int quality, int expectedSellIn, int expectedQuality)
        {
            var firstItem = new Item { Name = item, SellIn = sellIn, Quality = quality };

            _target.PublicItems = new List<Item> { firstItem };
            _target.UpdateQuality();

            Assert.That(firstItem.SellIn, Is.EqualTo(expectedSellIn));
            Assert.That(firstItem.Quality, Is.EqualTo(expectedQuality));
        }
    }
}
