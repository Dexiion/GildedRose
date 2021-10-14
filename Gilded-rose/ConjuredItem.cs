namespace Gilded_rose
{
    public class ConjuredItem : IItem
    {
        public void updateItem(Item item)
        {
            item.SellIn -= 1;

            if (item.SellIn > 0 && item.Quality > 0)
            {
                item.Quality -= 2;
            }
            else if (item.SellIn < 0 && item.Quality > 0)
            {
                item.Quality -= 4;
            }
        }
    }
}