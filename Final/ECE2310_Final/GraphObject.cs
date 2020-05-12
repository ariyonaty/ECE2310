using System;

namespace ECE2310_Final
{
    public class GraphObject
    {
        protected double Area { get; set; } = 1;
        protected double Perimeter { get; set; } = 1;

        public GraphObject() { }
        public GraphObject(double area, double perimeter)
        {
            this.Area = area;
            this.Perimeter = perimeter;
        }

        public virtual double CalArea()
        {
            return Area;
        }
        public virtual double CalPerimeter()
        {
            return Perimeter;
        }
        public override string ToString()
        {
            return ($"area = {Math.Round(Area, 2)}; perimeter = {Math.Round(Perimeter, 2)}");
        }
    }
}