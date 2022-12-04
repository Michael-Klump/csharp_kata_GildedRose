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
        public void ProduceCurrentTestResults()
        {
            IList<Item> Items = new List<Item> {
                new Item { Name = "Aged Brie", SellIn = 2, Quality = 0 },
                new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 15, Quality = 20 },
                new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80 },
                new Item { Name = "Conjured Mana Cake", SellIn = 3, Quality = 12 },
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
        public void UpdateQualityTest()
        {

            IList<Item> Items = new List<Item> {
                new Item { Name = "Aged Brie", SellIn = 2, Quality = 0 },
                new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 15, Quality = 20 },
                new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80 },
                new Item { Name = "Conjured Mana Cake", SellIn = 3, Quality = 12 },
                new Item { Name = "Other Items", SellIn = 10, Quality = 20 }
            };

            GildedRose app = new GildedRose(Items);

            string[] CurrentTestResultsLines = File.ReadAllLines("CurrentTestResults.txt");
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