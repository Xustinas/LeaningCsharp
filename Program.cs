using System;
using System.Collections.Generic;

namespace LeaningCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter numbers of fibinachi");
            int len = Convert.ToInt32(Console.ReadLine());


            int a = 0, b = 1, c = 0;

            for (int i = 0; i < len; i++)
            {
                c = a + b;
                a = b;
                b = c;
                Console.WriteLine(c);
            }

            // Fibonacci_Recursive(len);
            // static void Fibonacci_Recursive(int len)
            // {
            //     Fibonacci_Rec_Temp(0, 1, 1, len);
            // }
            // static void Fibonacci_Rec_Temp(int a, int b, int counter, int len)
            // {
            //     if (counter <= len)
            //     {
            //         Console.Write("{0} ", a);
            //         Fibonacci_Rec_Temp(b, a + b, counter + 1, len);
            //
            //     }
            // }

        }
    }
}



