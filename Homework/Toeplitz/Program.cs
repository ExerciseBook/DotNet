using System;

namespace Toeplitz
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] p = new int[3, 4]
            {
                {1, 2, 3, 4},
                {5, 1, 2, 3},
                {9, 5, 1, 2}
            };

            try
            {
                Toeplitz t = new Toeplitz(p, 3 ,4);
                Console.WriteLine("Yes");
            }
            catch (Exception e)
            {
                Console.WriteLine("No");
            }
            

        }
    }
}
