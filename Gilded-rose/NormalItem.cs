namespace Gilded_rose
{
    public class NormalItem : IItem
    {
        public void updateItem(Item item)
        {
            item.SellIn -= 1;

            if (item.SellIn > 0 && item.Quality > 0)
            {
                item.Quality -= 1;
            }
            else if (item.SellIn < 0 && item.Quality > 0)
            {
                item.Quality -= 2;
            }
        }
    }
}