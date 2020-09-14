using System;

namespace Shapes
{
    public class Square : Rectangle
    {
        public Square(Point p1, Point p2) : base(p1, p2)
        {
            double l1 = Math.Abs(p1.x - p2.x);
            double l2 = Math.Abs(p1.y - p2.y);

            if (Math.Abs(l1 - l2) > 1e-9) throw new InvalidShape();
        }
    }
}