using System;

namespace Statistic
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            int max = Int32.MinValue, min = Int32.MaxValue, sum = 0, tot = 0;
            while ((line = Console.ReadLine()) != null)
            {
                try
                {
                    int d = Int32.Parse(line);

                    max = Math.Max(max, d);
                    min = Math.Min(min, d);
                    sum += d;
                    tot++;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }

            Console.WriteLine("Max " + max);
            Console.WriteLine("Min " + min);
            Console.WriteLine("Sum " + sum);
            Console.WriteLine("Avg " + (double)sum/tot);
        }
    }
}
