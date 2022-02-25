using System;
using System.Collections.Generic;


namespace LeaningCsharp
{
    class CollectionOfItems
    {
        Dictionary<int, Item> items = new Dictionary<int, Item>();

        public CollectionOfItems()
        {
            items.Add(1, new Item(1, "newTitle1"));
            items.Add(3, new Item(3, "newTitle3"));
            items.Add(10, new Item(10, "newTitle10"));
        }
        public void PrintTitle(int id)
        {
            if (items.TryGetValue(id, out Item word))
            {
                Console.WriteLine(word.Title);
            }
            else
            {
                Console.WriteLine("Sorry this there is no data with this id");
            }
        }
    }
}
