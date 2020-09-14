using System;

namespace Shapes
{
    public class Triangle : Shape
    {
        public Triangle(Point p1, Point p2, Point p3)
        {
            Points.Add(new Point(p1));
            Points.Add(new Point(p2));
            Points.Add(new Point(p3));
        }

        public override double Aera()
        {
            var p1 = Points[0];
            var p2 = Points[1];
            var p3 = Points[2];

            var l1 = p1.Distance(p2);
            var l2 = p2.Distance(p3);
            var l3 = p3.Distance(p1);

            var hc = (l1 + l2 + l3) / 2;

            return Math.Sqrt(hc * (hc - l1) * (hc - l2) * (hc - l3));
        }
    }
}