using System;

namespace Gilded_rose
{
    public class AgedBrieItem : IItem
    {
        public void updateItem(Item item)
        {
            item.SellIn -= 1;

            if (item.SellIn >= 0 && item.Quality < 50)
            {
                item.Quality += 1;
            }
            else if (item.SellIn < 0)
            {
                item.Quality = Math.Min(item.Quality += 2, 50);
            }
        }
    }
}