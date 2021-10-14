namespace Gilded_rose
{
    public class BackstageItem : IItem
    {
        public void updateItem(Item item)
        {
            item.SellIn -= 1;

            if (item.SellIn <= 0)
            {
                item.Quality = 0;
            }
            else
            {
                if (item.Quality < 50)
                {
                    item.Quality += 1;
                }

                if (item.SellIn < 10 && item.Quality < 50)
                {
                    item.Quality += 1;
                }

                if (item.SellIn < 5 && item.Quality < 50)
                {
                    item.Quality += 1;
                }
            }
        }
    }

}