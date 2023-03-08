using System;
using System.Collections.Generic;

namespace Homework_6._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Gtxovt Shemoiyvanet Masivis Zoma : ");
            int z = Convert.ToInt32(Console.ReadLine());
            int[] mainArray = new int[z];
            List<int> list1 = new List<int>();
            List<int> list2 = new List<int>();
            for (int i = 0; i <mainArray.Length; i++)
            {
                mainArray[i] = i;
            }
            foreach (var item in mainArray)
            {
                if (item % 2 == 0)
                {
                    list1.Add(item);
                }
                if (item % 2 == 1)
                {
                    list2.Add(item);
                }
            }
            foreach (var item in list1)
            {
                Console.WriteLine($"luwebi : {item}");
            }
            foreach (var item in list2)
            {
                Console.WriteLine($"kentebi : {item}");
            }

        }
    }
}
