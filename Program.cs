using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> metals = new Dictionary<string, int>();
            metals.Add("Platinum", 70);
            metals.Add("Iridium", 20);
            metals.Add("Palladium", 30);
            metals.Add("Scandium", 12);

            string metalName = Console.ReadLine();
            int price = Convert.ToInt32(Console.ReadLine());

            //add 5th metal details to dictionary

            metals.Add(metalName, price);
            int[] prices = metals.Values.ToArray();
            Array.Sort(prices);
            var temp = prices.LastOrDefault();
            //your code goes here

            var highest = metals.Where(x => x.Value == temp).Select(x=>x.Key);
            Console.WriteLine("The most expensive: " + highest.First());
        }
    }
}