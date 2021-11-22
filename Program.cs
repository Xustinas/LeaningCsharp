using System;
using System.Collections.Generic;

namespace LeaningCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // bool text;
            int result = 0;
            int parsedNumber;
            string changedNumberToString;
            string number = EntryText();
            bool text = EntryIsNumber(number);
            CheckIfTextIsAnumber(text, number);
            CheckIfNumberIsInrange(result);
          



            ChangeNumberToText(result);
            //result = ParseToInteger(number);
            //Console.WriteLine(number);
            //Console.WriteLine(number.GetType());

            string ChangeNumberToText(int wholenumber)
            {
                number = Convert.ToString(wholenumber);
                //for (int i = 0; i < number.Length; i++)
                //{
                //    if (number[i] == '-')
                //    {
                //        Console.Write("minus ");
                //    }
                //     else if (number[i]==  '0')
                //     {
                //         Console.Write("nulis"); 
                //     }
                //     else if (number[i] == '1')
                //     {
                //         Console.Write("vienas");
                //     }
                //     else if (number[i] == '2')
                //     {
                //         Console.Write("du");
                //     }
                //     else if (number[i] == '3')
                //     {
                //         Console.Write("trys");
                //     }
                //     else if (number[i] == '4')
                //     {
                //         Console.Write("keturi");
                //     }
                //     else if (number[i] == '5')
                //     {
                //         Console.Write("penki");
                //     }
                //     else if (number[i] == '6')
                //     {
                //         Console.Write("sesi");
                //     }
                //     else if (number[i] == '7')
                //     {
                //         Console.Write("septyni");
                //     }
                //     else if (number[i] == '8')
                //     {
                //         Console.Write("astuoni");
                //     }
                //     else if (number[i] == '9')
                //     {
                //         Console.Write("devyni");
                //     }
                //
                //}
           
                switch (number)
                {
                    case "19":
                        Console.Write("devyniolika");
                        break;
                    case "18":
                        Console.Write("astuoniolika");
                        break;
                    case "17":
                        Console.Write("septyniolika");
                        break;
                    case "16":
                        Console.Write("sesiolika");
                        break;
                    case "15":
                        Console.Write("penkiolika");
                        break;
                    case "14":
                        Console.Write("keturiolika");
                        break;
                    case "13":
                        Console.Write("trylika");
                        break;
                    case "12":
                        Console.Write("dvylika");
                        break;
                    case "11":
                        Console.Write("vienuolika");
                        break;
                    case "10":
                        Console.Write("desimt");
                        break;
                    case "0":
                        Console.Write("nulis");
                        break;
                    case "9":
                        Console.Write("devyni");
                        break;
                    case "8":
                        Console.Write("astuoni");
                        break;
                    case "7":
                        Console.Write("septyni");
                        break;
                    case "6":
                        Console.Write("sesi");
                        break;
                    case "5":
                        Console.Write("penki");
                        break;
                    case "4":
                        Console.Write("keturi");
                        break;
                    case "3":
                        Console.Write("trys");
                        break;
                    case "2":
                        Console.Write("du");
                        break;
                    case "1":
                        Console.Write("vienas");
                        break;
                    case "-19":
                        Console.Write("minus devyniolika");
                        break;
                    case "-18":
                        Console.Write("minus astuoniolika");
                        break;
                    case "-17":
                        Console.Write("minus septyniolika");
                        break;
                    case "-16":
                        Console.Write("minus sesiolika");
                        break;
                    case "-15":
                        Console.Write("minus penkiolika");
                        break;
                    case "-14":
                        Console.Write("minus keturiolika");
                        break;
                    case "-13":
                        Console.Write("minus trylika");
                        break;
                    case "-12":
                        Console.Write("minus dvylika");
                        break;
                    case "-11":
                        Console.Write("minus vienuolika");
                        break;
                    case "-10":
                        Console.Write("minus desimt");
                        break;                   
                    case "-9":
                        Console.Write("minus devyni");
                        break;
                    case "-8":
                        Console.Write("minus astuoni");
                        break;
                    case "-7":
                        Console.Write("minus septyni");
                        break;
                    case "-6":
                        Console.Write("minus sesi");
                        break;
                    case "-5":
                        Console.Write("minus penki");
                        break;
                    case "-4":
                        Console.Write("minus keturi");
                        break;
                    case "-3":
                        Console.Write("minus trys");
                        break;
                    case "-2":
                        Console.Write("minus du");
                        break;
                    case "-1":
                        Console.Write("minus vienas");
                        break;
                    default:
                        break;
                }
                return number;
            }

            int CheckIfNumberIsInrange(int number)
            {
                if (number > -9 && number < 9)
                {
                    Console.WriteLine("Number is in range");
                }
                else
                {
                    Console.WriteLine("Number is out of range");
                }
                return number;
            }

            int CheckIfTextIsAnumber(bool text, string number)
            {
                if (!text)
                {
                    Console.WriteLine("Text was not a number {0}", number);
                }
                else
                {
                    result = ParseToInteger(number);
                }

                return result;
            }
            int ParseToInteger(string number)
            {

                int resultLocal = Int32.Parse(number);
                Console.WriteLine("Text was successfully parsed to number: {0}", resultLocal);
                return resultLocal;
            }

            bool EntryIsNumber(string number)
            {
                bool textLocal = int.TryParse(number, out parsedNumber);
                Console.WriteLine("Entry is number: {0}", textLocal);
                return textLocal;
            }
            string EntryText()
            {
                Console.WriteLine("Please enter number between -9 and 9");
                string entry = Console.ReadLine();
                return entry;
            }

        }
    }
}




