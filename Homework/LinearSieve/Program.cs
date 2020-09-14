using System;

namespace LinearSieve
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var p = new LinearSieve(100);

            p.CreatePrime();

            foreach (var t in p.p)
            {
                if (t == 0) break;
                Console.WriteLine(t);
            }
        }
    }
}