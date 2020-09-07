using System;

namespace LinearSieve
{
    class Program
    {
        static void Main(string[] args)
        {
            LinearSieve p = new LinearSieve(100);

            p.CreatePrime();

            foreach (int t in p.p)
            {
                if (t == 0) break;
                Console.WriteLine(t);
            }

        }
    }
}