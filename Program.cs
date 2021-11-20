using System;
using System.Collections.Generic;

namespace LeaningCsharp
{
    class Program
    {
        static void Main(string[] args)
        {


            double bodyFat;

            double H = Entry("Please enter your height");
            double W = Entry("Please enter your weight");


            bodyFat = KMI(H, W);
            Console.WriteLine(bodyFat);

            string body = Transaction(bodyFat);
            Console.WriteLine($"Info about body fat: {body}");

            double Entry(string message)
            {
                Console.WriteLine(message);
                return Convert.ToDouble(Console.ReadLine());
            }

            double KMI(double H, double W)
            {
                return bodyFat = W / (H * H);
            }  

            string Transaction(double bodyFat)
            {
                if (bodyFat < 15)
                {
                    return "alkanas";
                }
                else if (bodyFat < 18.5)
                {
                    return "liesas";
                }
                else if (bodyFat>18.5 && bodyFat < 25)
                {
                    return "normalus";
                }
                else if (bodyFat>25 && bodyFat<30)
                {
                    return "virsvisko";
                }
                else if (bodyFat>30 && bodyFat<40)
                {
                    return "nutukelis";
                }
                else
                {
                    return "nera info";
                }
            }
           
        }
    }
}



