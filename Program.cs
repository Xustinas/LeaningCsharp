using LeaningCsharp;
using System;


namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            string entry;
            do
            {
                Console.WriteLine("Please enter id");
                entry = Console.ReadLine().ToLower();
                if (Int32.TryParse(entry, out int number))
                {
                    CollectionOfItems collection = new CollectionOfItems();
                    collection.PrintTitle(number);
                }
                else
                {
                    if (entry == "exit")
                    {
                        break;
                    }
                    Console.WriteLine("Entry could not be parsed.");
                }
            } while (true);
        }
    }
}
