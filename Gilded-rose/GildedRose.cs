using System;
using System.Collections.Generic;

namespace Gilded_rose
{
    public class GildedRose
    {
        public IList<Item> Items;

        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            var itemFactory = new ItemFactory();
            foreach (var item in Items)
            {
                itemFactory.CreateItem(item.Name).updateItem(item);
            }
        }
    }

    public class Item
    {
        public string Name { get; set; }

        public int SellIn { get; set; }

        public int Quality { get; set; }
    }
}