using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;

namespace csharp
{
    [TestFixture]
    public class GildedRoseTest
    {

        [Test]
        public void ProduceTestResultsForAgedBrie()
        {
            IList<Item> Items = new List<Item> {
                new Item { Name = "Aged Brie", SellIn = 2, Quality = 0 }
            };

            GildedRose app = new GildedRose(Items);

            for (int DayNumber = 1; DayNumber <= 30; DayNumber++)
            {
                app.UpdateQuality();
                foreach (Item CurrentItem in Items)
                {
                    Console.WriteLine(CurrentItem.Name + "," + CurrentItem.SellIn + "," + CurrentItem.Quality);
                }
            }
        }

        [Test]
        public void UpdateQualityTestForAgedBrie()
        {

            IList<Item> Items = new List<Item> {
                new Item { Name = "Aged Brie", SellIn = 2, Quality = 0 }
            };

            GildedRose app = new GildedRose(Items);

            string[] CurrentTestResultsLines = File.ReadAllLines("CurrentTestResultsAgedBrie.txt");
            int CurrentTestResultLineCounter = 0;

            for (int DayNumber = 1; DayNumber <= 30; DayNumber++)
            {
                app.UpdateQuality();
                foreach (Item CurrentItem in Items)
                {
                    Assert.AreEqual(CurrentTestResultsLines[CurrentTestResultLineCounter],
                        CurrentItem.Name + "," + CurrentItem.SellIn + "," + CurrentItem.Quality);
                    CurrentTestResultLineCounter++;
                }
            }
        }

        [Test]
        public void ProduceTestResultsForBackstagePasses()
        {
            IList<Item> Items = new List<Item> {
                new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 15, Quality = 20 }
            };

            GildedRose app = new GildedRose(Items);

            for (int DayNumber = 1; DayNumber <= 30; DayNumber++)
            {
                app.UpdateQuality();
                foreach (Item CurrentItem in Items)
                {
                    Console.WriteLine(CurrentItem.Name + "," + CurrentItem.SellIn + "," + CurrentItem.Quality);
                }
            }
        }

        [Test]
        public void UpdateQualityTestForBackstagePasses()
        {

            IList<Item> Items = new List<Item> {
                new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 15, Quality = 20 }
            };

            GildedRose app = new GildedRose(Items);

            string[] CurrentTestResultsLines = File.ReadAllLines("CurrentTestResultsBackstagePasses.txt");
            int CurrentTestResultLineCounter = 0;

            for (int DayNumber = 1; DayNumber <= 30; DayNumber++)
            {
                app.UpdateQuality();
                foreach (Item CurrentItem in Items)
                {
                    Assert.AreEqual(CurrentTestResultsLines[CurrentTestResultLineCounter],
                        CurrentItem.Name + "," + CurrentItem.SellIn + "," + CurrentItem.Quality);
                    CurrentTestResultLineCounter++;
                }
            }
        }

        [Test]
        public void ProduceTestResultsForSulfuras()
        {
            IList<Item> Items = new List<Item> {
                new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80 }
            };

            GildedRose app = new GildedRose(Items);

            for (int DayNumber = 1; DayNumber <= 30; DayNumber++)
            {
                app.UpdateQuality();
                foreach (Item CurrentItem in Items)
                {
                    Console.WriteLine(CurrentItem.Name + "," + CurrentItem.SellIn + "," + CurrentItem.Quality);
                }
            }
        }

        [Test]
        public void UpdateQualityTestForSulfuras()
        {

            IList<Item> Items = new List<Item> {
                new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80 }
            };

            GildedRose app = new GildedRose(Items);

            string[] CurrentTestResultsLines = File.ReadAllLines("CurrentTestResultsSulfuras.txt");
            int CurrentTestResultLineCounter = 0;

            for (int DayNumber = 1; DayNumber <= 30; DayNumber++)
            {
                app.UpdateQuality();
                foreach (Item CurrentItem in Items)
                {
                    Assert.AreEqual(CurrentTestResultsLines[CurrentTestResultLineCounter],
                        CurrentItem.Name + "," + CurrentItem.SellIn + "," + CurrentItem.Quality);
                    CurrentTestResultLineCounter++;
                }
            }
        }

        [Test]
        public void ProduceTestResultsForConjuredManaCake()
        {
            IList<Item> Items = new List<Item> {
                new Item { Name = "Conjured Mana Cake", SellIn = 3, Quality = 12 }
            };

            GildedRose app = new GildedRose(Items);

            for (int DayNumber = 1; DayNumber <= 30; DayNumber++)
            {
                app.UpdateQuality();
                foreach (Item CurrentItem in Items)
                {
                    Console.WriteLine(CurrentItem.Name + "," + CurrentItem.SellIn + "," + CurrentItem.Quality);
                }
            }
        }

        [Test]
        public void UpdateQualityTestForConjuredManaCake()
        {

            IList<Item> Items = new List<Item> {
                new Item { Name = "Conjured Mana Cake", SellIn = 3, Quality = 12 }
            };

            GildedRose app = new GildedRose(Items);

            string[] CurrentTestResultsLines = File.ReadAllLines("CurrentTestResultsConjuredManaCake.txt");
            int CurrentTestResultLineCounter = 0;

            for (int DayNumber = 1; DayNumber <= 30; DayNumber++)
            {
                app.UpdateQuality();
                foreach (Item CurrentItem in Items)
                {
                    Assert.AreEqual(CurrentTestResultsLines[CurrentTestResultLineCounter],
                        CurrentItem.Name + "," + CurrentItem.SellIn + "," + CurrentItem.Quality);
                    CurrentTestResultLineCounter++;
                }
            }
        }

        [Test]
        public void ProduceTestResultsForOtherItems()
        {
            IList<Item> Items = new List<Item> {
                new Item { Name = "Other Items", SellIn = 10, Quality = 20 }
            };

            GildedRose app = new GildedRose(Items);

            for (int DayNumber = 1; DayNumber <= 30; DayNumber++)
            {
                app.UpdateQuality();
                foreach (Item CurrentItem in Items)
                {
                    Console.WriteLine(CurrentItem.Name + "," + CurrentItem.SellIn + "," + CurrentItem.Quality);
                }
            }
        }

        [Test]
        public void UpdateQualityTestForOtherItems()
        {

            IList<Item> Items = new List<Item> {
                new Item { Name = "Other Items", SellIn = 10, Quality = 20 }
            };

            GildedRose app = new GildedRose(Items);

            string[] CurrentTestResultsLines = File.ReadAllLines("CurrentTestResultsOtherItems.txt");
            int CurrentTestResultLineCounter = 0;

            for (int DayNumber = 1; DayNumber <= 30; DayNumber++)
            {
                app.UpdateQuality();
                foreach (Item CurrentItem in Items)
                {
                    Assert.AreEqual(CurrentTestResultsLines[CurrentTestResultLineCounter],
                        CurrentItem.Name + "," + CurrentItem.SellIn + "," + CurrentItem.Quality);
                    CurrentTestResultLineCounter++;
                }
            }
        }
    }
}