using System;

namespace ShapeFactory
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            double tot = 0;
            var random = new Random();

            for (var i = 0; i < 10; i++) tot += Factory.GenerateShape((Factory.ShapeID) random.Next(3)).Aera();

            Console.WriteLine(tot);
        }
    }
}