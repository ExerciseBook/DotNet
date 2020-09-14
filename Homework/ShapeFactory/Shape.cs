using System.Collections.Generic;

namespace ShapeFactory
{
    public abstract class Shape
    {
        protected List<Point> points = new List<Point>();

        public abstract double Aera();
    }
}