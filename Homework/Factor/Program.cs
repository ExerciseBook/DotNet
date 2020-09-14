using System;

namespace Factor
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var p = int.Parse(Console.ReadLine());

            var t = 2;
            while (p > 1)
            {
                while (p % t == 0)
                {
                    p /= t;
                    Console.Write("" + t + ' ');
                }

                t++;
            }
        }
    }
}