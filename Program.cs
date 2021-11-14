using System;
using System.Collections.Generic;

namespace LeaningCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter lucky number");
            int lucky = Convert.ToInt32(Console.ReadLine());
            int num = new Random().Next(0, 100);
            int count = 0;
            while (lucky!=num)
            {
                count += 1;
                Console.WriteLine("Total count {0}", count);
                if (lucky<num)
                {
                    Console.WriteLine("Number is higher");
                    lucky = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("Number is lower");
                    lucky = Convert.ToInt32(Console.ReadLine());
                }
               
            }
            Console.WriteLine("Bingo!!!!!");
        }
    }
}



