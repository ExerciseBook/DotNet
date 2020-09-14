using System;

namespace Shapes
{
    public class Point
    {
        public double x, y;

        public Point()
        {

        }

        public Point(Point t)
        {
            this.x = t.x;
            this.y = t.y;
        }

        public double Distance(Point t)
        {
            return Math.Sqrt((x - t.x) * (x - t.x) + (y - t.y) * (y - t.y));
        }
    }
}