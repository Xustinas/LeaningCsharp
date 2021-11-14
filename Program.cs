using System;
using System.Collections.Generic;

namespace LeaningCsharp
{
    class Program
    {
        static void Main(string[] args)
        {

            char op;
            int first;
            int second;
            double result;
            char esc = (char)27;
            do
            {
                Console.WriteLine("Please enter  operation and two numbers number or if you wanna end enter 'n' or '0'");
                 op = Console.ReadKey(true).KeyChar;
                if (op == esc || op == esc)
                {
                    break;
                }
                first = Convert.ToInt32(Console.ReadLine());
                second = Convert.ToInt32(Console.ReadLine());
                if (op == '+')
                {
                    result = first + second;
                    Console.WriteLine($"{first} {op} {second} = {result}");
                }
                else if (op == '-')
                {
                    result = first - second;
                    Console.WriteLine($"{first} {op} {second} = {result}");
                }
                else if (op == '*')
                {
                    result = first * second;
                    Console.WriteLine($"{first} {op} {second} = {result}");
                }
                else if (op == '/')
                {
                    if (second==0)
                    {
                        Console.WriteLine("cannot be divided by 0");
                        continue;
                    }
                    result = first / second;
                    Console.WriteLine($"{first} {op} {second} = {result}");
                }
           
                else
                {
                    Console.WriteLine("Bad operation entry");
                }
                Console.WriteLine("");
            } while (op != 'n' && op != '0');

        }
    }
}



