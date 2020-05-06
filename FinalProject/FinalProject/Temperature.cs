using System;
using System.Text.RegularExpressions;

namespace FinalProject
{
    public class Temperature
    {
        private double _degree = 100;
        private char _scale = 'f';

        public double Degree
        {
            get => _degree;
            set => _degree = value;
        }
        public char Scale
        {
            get => _scale;
            set => _scale = char.ToLower(value);
        }

        public Temperature() { }
        public Temperature(double degree, char scale)
        {
            this.Degree = degree;
            this.Scale = scale;
        }

        public void TemperatureConversion(char scale)
        {
            scale = char.ToLower(scale);
            double degree;
            switch (scale)
            {
                case 'c':
                    if (Scale == 'f')
                    {
                        degree = (Degree - 32) * (5 / 9);
                        Console.WriteLine($"{this.ToString()} --> {degree} °{scale}");
                    }
                    else
                    {
                        Console.WriteLine(this.ToString());
                    }
                    break;
                case 'f':
                    if (Scale == 'c')
                    {
                        degree = (Degree * (9 / 5)) + 32;
                        Console.WriteLine($"{this.ToString()} --> {degree} °{scale}");
                    }
                    else
                    {
                        Console.WriteLine(this.ToString());
                    }
                    break;
                default:
                    Console.WriteLine($"[-] {scale} > not valid scale.");
                    break;
            }
        }

        public override string ToString()
        {
            return ($"Temperature: {Degree} °{Scale}");
        }

    }
}