using System;

namespace Shapes
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(new Triangle(
                new Point {x = 0, y = 0},
                new Point {x = 0, y = 3},
                new Point {x = 4, y = 0}
            ).Aera());

            Console.WriteLine(new Rectangle(
                new Point {x = 0, y = 0},
                new Point {x = 5, y = 5}
            ).Aera());

            Console.WriteLine(new Square(
                new Point {x = 0, y = 0},
                new Point {x = 5, y = 5}
            ).Aera());

            try
            {
                Console.WriteLine(new Rectangle(
                    new Point {x = 0, y = 0},
                    new Point {x = 0, y = 5}
                ).Aera());
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            try
            {
                Console.WriteLine(new Square(
                    new Point {x = 0, y = 0},
                    new Point {x = 4, y = 5}
                ).Aera());
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}