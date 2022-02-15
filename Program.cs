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
            Queue<int> q = new Queue<int>();

            while (q.Count < 3)
            {
                int num = Convert.ToInt32(Console.ReadLine());
                //your code goes here 
                q.Enqueue(num);
                // To copy the queue into a new array, use the ToArray() method of the queue: int[] arr = queue.ToArray();.
                // Then, recall the Array.Sort() method.
            }

            Console.Write("Queue: ");
            foreach (int i in q)
                Console.Write(i + " ");

            Console.WriteLine();
            q.ToArray();
            int[] arr = q.ToArray();
            Array.Sort(arr);
            Console.Write("Sorted: ");
            foreach (int i in arr)
                Console.Write(i + " ");

            //your code goes here

        }
    }
}