using System;


namespace ECE2310_Final
{
    public class RightTriangle : GraphObject
    {
        private int _height = 1;
        private int _bas = 1;

        public int Height
        {
            get => _height;
            set => _height = value;
        }
        public int Bas
        {
            get => _bas;
            set => _bas = value;
        }

        public RightTriangle() { }
        public RightTriangle(int height, int bas)
        {
            this.Height = height;
            this.Bas = bas;
        }

        public override double CalArea()
        {
            double area = (0.5) * Bas * Height;
            Area = area;
            return area;
        }
        public override double CalPerimeter()
        {
            double perimeter = Height + Bas + Math.Sqrt(Math.Pow(Height, 2) + Math.Pow(Bas, 2));
            Perimeter = perimeter;
            return perimeter;
        }

        public override string ToString()
        {
            return ($"Triangle info: height = {Height}; base = {Bas}; {base.ToString()}");
        }

    }
}