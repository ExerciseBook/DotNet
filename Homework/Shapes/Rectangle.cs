using System;

namespace Shapes
{
    public class Rectangle : Shape
    {
        public Rectangle(Point p1, Point p2)
        {
            if (Math.Abs(p1.x - p2.x) < 1e-9 || Math.Abs(p1.y - p2.y) < 1e-9) throw new InvalidShape();

            this.points.Add(new Point(p1));
            this.points.Add(new Point(p2));
        }

        public override double Aera()
        {
            Point p1 = this.points[0];
            Point p2 = this.points[1];

            double l1 = Math.Abs(p1.x - p2.x);
            double l2 = Math.Abs(p1.y - p2.y);

            return l1 * l2;
        }
    }
}