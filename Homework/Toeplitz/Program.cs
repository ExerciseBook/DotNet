using System;

namespace Toeplitz
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var p = new int[3, 4]
            {
                {1, 2, 3, 4},
                {5, 1, 2, 3},
                {9, 5, 1, 2}
            };

            try
            {
                var t = new Toeplitz(p, 3, 4);
                Console.WriteLine("Yes");
            }
            catch (Exception e)
            {
                Console.WriteLine("No");
            }
        }
    }
}