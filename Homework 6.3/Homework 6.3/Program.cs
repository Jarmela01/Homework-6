using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

namespace Homework_6._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] points = new int[] { 10, 20, 31, 2, 5, 7, 9, 40, 30, 56 };
            Console.WriteLine("Points : ");

            foreach (var item in points)
            {
                Console.WriteLine(item);
            }

            Array.Sort(points);
            Console.WriteLine("Please Enter Top");
            int top = Convert.ToInt32(Console.ReadLine());
            Array.Reverse(points);

            for (int i = 0; i < top; i++)
            {
                Console.WriteLine($"Top {i+1} is : {points[i]}");
            }





        }
    }
}
