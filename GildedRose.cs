using System.Collections.Generic;

namespace csharp
{
    public class GildedRose
    {
        private const string AGED_BRIE = "Aged Brie";
        private const string BACKSTAGE_PASS = "Backstage passes to a TAFKAL80ETC concert";
        private const string SULFURAS = "Sulfuras, Hand of Ragnaros";
        private const string CONJURED_MANA_CAKE = "Conjured Mana Cake";
        private const int MINIMUM_QUALITY = 0;
        private const int MAXIMUM_QUALITY = 50;
        IList<Item> Items;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            foreach (Item CurrentItem in Items)
            {
                DecreaseSellIn(CurrentItem);

                if (IsOtherItem(CurrentItem))
                {
                    UpdateItemQualityForOtherItem(CurrentItem);
                }
                else
                {
                    if (IsAgedBrie(CurrentItem))
                    {
                        UpdateItemQualityForAgedBrie(CurrentItem);
                    }
                    else if (IsBackstagePass(CurrentItem))
                    {
                        UpdateItemQualityForBackstagePass(CurrentItem);
                    }
                    else if (IsConjuredManaCake(CurrentItem))
                    {
                        UpdateItemQualityForConjuredManaCake(CurrentItem);
                    }
                }
            }
        }

        private static void DecreaseSellIn(Item CurrentItem)
        {
            if (!IsSulfuras(CurrentItem))
            {
                CurrentItem.SellIn -= 1;
            }
        }

        private bool IsOtherItem(Item ItemToBeChecked)
        {
            return (!IsAgedBrie(ItemToBeChecked) && !IsBackstagePass(ItemToBeChecked) &&
                !IsConjuredManaCake(ItemToBeChecked) && !IsSulfuras(ItemToBeChecked));
        }

        private bool IsAgedBrie(Item ItemToBeChecked)
        {
            return ItemToBeChecked.Name.Equals(AGED_BRIE);
        }

        private static bool IsBackstagePass(Item CurrentItem)
        {
            return CurrentItem.Name.Equals(BACKSTAGE_PASS);
        }

        private static bool IsConjuredManaCake(Item CurrentItem)
        {
            return CurrentItem.Name.Equals(CONJURED_MANA_CAKE);
        }

        private static bool IsSulfuras(Item CurrentItem)
        {
            return CurrentItem.Name.Equals(SULFURAS);
        }

        private static void UpdateItemQualityForOtherItem(Item CurrentItem)
        {
            DecreaseQuality(CurrentItem);
            DecreaseAdditionalQualityAfterSellInIsBelowZero(CurrentItem);
        }

        private static void UpdateItemQualityForAgedBrie(Item CurrentItem)
        {
            IncreaseQuality(CurrentItem);
            IncreaseAdditionalQualityAfterSellInIsBelowZero(CurrentItem);
        }

        private static void UpdateItemQualityForBackstagePass(Item CurrentItem)
        {
            IncreaseQuality(CurrentItem);
            IncreaseAdditionalQualityIfSellInIsBelowTen(CurrentItem);
            IncreaseAdditionalQualityIfSellInIsBelowFive(CurrentItem);
            SetQualityToZeroIfSellInIsBelowZero(CurrentItem);
        }

        private static void UpdateItemQualityForConjuredManaCake(Item CurrentItem)
        {
            DecreaseQuality(CurrentItem);
            DecreaseQuality(CurrentItem);
            SetQualityToZeroIfSellInIsBelowZero(CurrentItem);
        }

        private static void DecreaseQuality(Item CurrentItem)
        {
            if (CurrentItem.Quality > MINIMUM_QUALITY)
            {
                CurrentItem.Quality -= 1;
            }
        }

        private static void DecreaseAdditionalQualityAfterSellInIsBelowZero(Item CurrentItem)
        {
            if (CurrentItem.SellIn < 0 && CurrentItem.Quality > MINIMUM_QUALITY)
            {
                CurrentItem.Quality -= 1;
            }
        }

        private static void IncreaseQuality(Item CurrentItem)
        {
            if (CurrentItem.Quality < MAXIMUM_QUALITY)
            {
                CurrentItem.Quality += 1;
            }
        }

        private static void IncreaseAdditionalQualityAfterSellInIsBelowZero(Item CurrentItem)
        {
            if (CurrentItem.SellIn < 0 && CurrentItem.Quality < MAXIMUM_QUALITY)
            {
                CurrentItem.Quality += 1;
            }
        }

        private static void IncreaseAdditionalQualityIfSellInIsBelowTen(Item CurrentItem)
        {
            if (CurrentItem.SellIn < 10)
            {
                if (CurrentItem.Quality < MAXIMUM_QUALITY)
                {
                    CurrentItem.Quality += 1;
                }
            }
        }

        private static void IncreaseAdditionalQualityIfSellInIsBelowFive(Item CurrentItem)
        {
            if (CurrentItem.SellIn < 5)
            {
                if (CurrentItem.Quality < MAXIMUM_QUALITY)
                {
                    CurrentItem.Quality += 1;
                }
            }
        }
        private static void SetQualityToZeroIfSellInIsBelowZero(Item CurrentItem)
        {
            if (CurrentItem.SellIn < 0)
            {
                CurrentItem.Quality -= CurrentItem.Quality;
            }
        }
    }
}