using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaningCsharp
{
    class CollectionOfItems
    {
        List<Item> Items = new List<Item>();
        public CollectionOfItems()
        {
            Items.Add(new Item(1, "newTitle1"));
            Items.Add(new Item(3, "newTitle3"));
            Items.Add(new Item(10, "newTitle10"));
        }
        public void CheckIfNumberExists(int id) 
        {
            IEnumerable<int> numbers = Items.Select(x => x.Id).ToList();
        
            if (numbers.Contains(id))
            {
                PrintTitle(id);
            }
            else
            {
                Console.WriteLine("Sorry this there is no data with this id");
            }
        }
         public void PrintTitle(int id) 
        {
            IEnumerable<string> word = Items.Where(x => x.Id == id).Select(x => x.Title);
            Console.WriteLine(word.FirstOrDefault());
            
        }
    }
}
