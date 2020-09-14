using System.Collections.Generic;

namespace Shapes
{
    public abstract class Shape
    {
        protected List<Point> Points = new List<Point>();

        public abstract double Aera();
    }
}