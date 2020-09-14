using System;

namespace ShapeFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            double tot = 0;
            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                tot += Factory.GenerateShape((Factory.ShapeID) random.Next(3)).Aera();
            }

            Console.WriteLine(tot);
        }
    }
}
