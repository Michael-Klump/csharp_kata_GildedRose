using System.Collections.Generic;

namespace csharp
{
    public class GildedRose
    {
        private const string AGED_BRIE = "Aged Brie";
        private const string BACKSTAGE_PASS = "Backstage passes to a TAFKAL80ETC concert";
        private const string SULFURAS = "Sulfuras, Hand of Ragnaros";
        private const string CONJURED_MANA_CAKE = "Conjured Mana Cake";
        IList<Item> Items;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            foreach (Item CurrentItem in Items)
            {
                if (!IsAgedBrie(CurrentItem) && !IsBackstagePass(CurrentItem))
                {
                    if (CurrentItem.Quality > 0)
                    {
                        if (!IsSulfuras(CurrentItem))
                        {
                            if (!IsConjuredManaCake(CurrentItem))
                            {
                                CurrentItem.Quality-=1;
                            }
                            else
                            {
                                CurrentItem.Quality-=2;
                            }
                        }
                    }
                }
                else
                {
                    if (CurrentItem.Quality < 50)
                    {
                        CurrentItem.Quality+=1;

                        if (IsBackstagePass(CurrentItem))
                        {
                            if (CurrentItem.SellIn < 11)
                            {
                                if (CurrentItem.Quality < 50)
                                {
                                    CurrentItem.Quality+=1;
                                }
                            }

                            if (CurrentItem.SellIn < 6)
                            {
                                if (CurrentItem.Quality < 50)
                                {
                                    CurrentItem.Quality += 1;
                                }
                            }
                        }
                    }
                }

                if (!IsSulfuras(CurrentItem))
                {
                    CurrentItem.SellIn-=1;
                }

                if (CurrentItem.SellIn < 0)
                {
                    if (!IsAgedBrie(CurrentItem))
                    {
                        if (!IsBackstagePass(CurrentItem))
                        {
                            if (CurrentItem.Quality > 0)
                            {
                                if (!IsSulfuras(CurrentItem))
                                {
                                    if (!IsConjuredManaCake(CurrentItem))
                                    {
                                        CurrentItem.Quality-=1;
                                    }
                                    else
                                    {
                                        CurrentItem.Quality-=2;
                                    }
                                }
                            }
                        }
                        else
                        {
                            CurrentItem.Quality-=CurrentItem.Quality;
                        }
                    }
                    else
                    {
                        if (CurrentItem.Quality < 50)
                        {
                            CurrentItem.Quality+=1;
                        }
                    }
                }
            }
        }

        private bool IsAgedBrie(Item ItemToBeChecked)
        {
            return ItemToBeChecked.Name.Equals(AGED_BRIE);
        }

        private static bool IsConjuredManaCake(Item CurrentItem)
        {
            return CurrentItem.Name.Equals(CONJURED_MANA_CAKE);
        }

        private static bool IsBackstagePass(Item CurrentItem)
        {
            return CurrentItem.Name.Equals(BACKSTAGE_PASS);
        }

        private static bool IsSulfuras(Item CurrentItem)
        {
            return CurrentItem.Name.Equals(SULFURAS);
        }
    }
}