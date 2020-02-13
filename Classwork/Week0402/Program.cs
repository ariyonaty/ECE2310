using System;

namespace Week0402
{
    class Program
    {
        static void Main(string[] args)
        {
            double min = 10.0;
            double max = 20.0;

            Random rand = new Random();
            double myrand = rand.NextDouble() * (max - min) + min;
            
            Console.WriteLine(Math.Round(myrand, 3));
        }
    }
}
