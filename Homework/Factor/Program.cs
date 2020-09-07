using System;

namespace Factor
{
    class Program
    {
        static void Main(string[] args)
        {
            int p = Int32.Parse(Console.ReadLine());

            int t = 2;
            while (p > 1)
            {
                while (p % t == 0)
                {
                    p /= t;
                    Console.Write("" +t + ' ');
                }
                t++;
            }
        }
    }
}
