using System;

namespace Gilded_rose
{
    public class ConjuredItem : IItem
    {
        public void updateItem(Item item)
        {
            item.SellIn -= 1;

            if (item.SellIn > 0)
            {
                item.Quality = Math.Max(item.Quality - 2, 0);
            }
            else if (item.SellIn < 0)
            {
                item.Quality = Math.Max(item.Quality - 4, 0);
            }
        }
    }
}