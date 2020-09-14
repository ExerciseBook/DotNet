using System;
using System.Collections;
using System.ComponentModel;
using Shapes;

namespace ShapeFactory
{
    public class Factory
    {
        private static Random random = new Random();

        public enum ShapeID
        {
            Triangle = 0,
            Rectangle = 1,
            Square = 2
        }

        public static Shape GenerateShape(ShapeID t)
        {
            switch (t)
            {
                case ShapeID.Triangle :
                {
                    return new Triangle(
                            new Point { x = GetNextPoint(), y = GetNextPoint() },
                            new Point { x = GetNextPoint(), y = GetNextPoint() },
                            new Point { x = GetNextPoint(), y = GetNextPoint() }
                        );
                }
                case ShapeID.Rectangle :
                {
                    return new Rectangle(
                        new Point { x = GetNextPoint(), y = GetNextPoint() },
                        new Point { x = GetNextPoint(), y = GetNextPoint() }
                    );

                }
                case ShapeID.Square :
                {
                    Point x = new Point {x = GetNextPoint(), y = GetNextPoint()};
                    double line = GetNextPoint();
                    Point y = new Point() { x = x.x + line, y = x.y + line };

                    return new Square(x, y);
                }
            }
            
            throw new InvalidEnumArgumentException();
        }

        private static double GetNextPoint()
        {
            return random.NextDouble() * 2000 - 100;
        }
    }
}