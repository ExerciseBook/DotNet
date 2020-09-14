using System;

namespace Shapes
{
    public class Triangle : Shape
    {

        public Triangle(Point p1, Point p2, Point p3)
        {
            this.Points.Add(new Point(p1));
            this.Points.Add(new Point(p2));
            this.Points.Add(new Point(p3));
        }

        public override double Aera()
        {
            Point p1 = this.Points[0];
            Point p2 = this.Points[1];
            Point p3 = this.Points[2];

            double l1 = p1.Distance(p2);
            double l2 = p2.Distance(p3);
            double l3 = p3.Distance(p1);

            double hc = (l1 + l2 + l3) / 2;

            return Math.Sqrt(hc * (hc - l1) * (hc - l2) * (hc - l3));
        }
    }
}