using System;
using System.Collections.Generic;

namespace MyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericList<int> list = new GenericList<int>();

            list.Add(1);
            list.Add(1);
            list.Add(4);
            list.Add(5);
            list.Add(1);
            list.Add(4);

            int max = Int32.MinValue;
            int min = Int32.MaxValue;
            int sum = 0;

            list.ForEach(s =>
                {
                    max = Math.Max(max, s);
                    min = Math.Min(min, s);
                    sum += s;
                }
            );

            Console.WriteLine(max);
            Console.WriteLine(min);
            Console.WriteLine(sum);
            
        }
    }
}
