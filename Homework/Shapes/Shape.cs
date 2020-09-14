using System.Collections.Generic;

namespace Shapes
{
    public abstract class Shape
    {
        protected List<Point> points = new List<Point>();

        public abstract double Aera();
    }
}