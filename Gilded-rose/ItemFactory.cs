using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace Gilded_rose
{
    public class ItemFactory
    {
        private Dictionary<string, Func<IItem>> _dictionary;

        public ItemFactory()
        {
            _dictionary = new Dictionary<string, Func<IItem>>
            {
                {
                    "Aged Brie", () => new AgedBrieItem()
                },
                {
                    "Backstage passes to a TAFKAL80ETC concert", () => new BackstageItem()
                },
                {
                    "Sulfuras, Hand of Ragnaros", () => new SulfurasItem()
                },
                {
                    "Conjured", () => new ConjuredItem()
                }
            };
        }
        public IItem CreateItem(string itemName)
        {
            if (_dictionary.ContainsKey(itemName))
            {
                return _dictionary[itemName].Invoke();
            }

            return new NormalItem();
        }
    }

    

    
}