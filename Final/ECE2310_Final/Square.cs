using System;

namespace ECE2310_Final
{
    public class Square : GraphObject
    {
        private int _segment = 1;
        public int Segment
        {
            get => _segment;
            set => _segment = value;
        }

        public Square() { }
        public Square(int segment)
        {
            this.Segment = segment;
        }

        public override double CalArea()
        {
            double area = Math.Pow(Segment, 2);
            base.Area = area;
            return area;
        }
        public override double CalPerimeter()
        {
            double perimeter = 4 * Segment;
            base.Perimeter = perimeter;
            return perimeter;
        }

        public override string ToString()
        {
            return ($"Square info: segment = {Segment}; {base.ToString()}");
        }
    }
}